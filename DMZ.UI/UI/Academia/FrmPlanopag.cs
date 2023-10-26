using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Generic;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmPlanopag : Basic.FrmClasse
    {
        public FrmPlanopag()
        {
            InitializeComponent();
        }

        private void FrmPlanopag_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Planopag";
        }
        private Planopag planopag;
        public override void DefaultValues()
        {
            planopag = DoAddline<Planopag>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(planopag);
            EF.Save(planopag);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            planopag = FillControls(planopag, dt, i);
        }

        private void tbDefault5_Load(object sender, EventArgs e)
        {

        }

        private void btnParcelas_Click(object sender, EventArgs e)
        {
            if (!tbParcelas.tb1.Text.IsNullOrEmpty())
            {
                if (!tbValorProp.tb1.Text.IsNullOrEmpty())
                {
                    var parcelas = tbParcelas.tb1.Text.ToDecimal();
                    for (int i = 1; i <= parcelas; i++)
                    {
                        gridUi3.AddLine();
                        gridUi3.DataRowr["Parecela"] = i;
                        gridUi3.DataRowr["Valorbruto"] = tbValorProp.tb1.Text.ToDecimal();
                        gridUi3.DataRowr["ValorTotal"] = tbValorProp.tb1.Text.ToDecimal();
                        gridUi3.DataRowr["Titulo"] = "Mensalidade";
                        if (i==1)
                        {
                            gridUi3.DataRowr["Data"] = dtData.dt1.Value;
                        }
                        else
                        {
                            var data = new DateTime(dtData.dt1.Value.Year, dtData.dt1.Value.Month+i-1, dtData.dt1.Value.Day);
                            gridUi3.DataRowr["Data"] = data;
                        }
                    }
                    gridUi3.Update();
                }
                else
                {
                    MsBox.Show("Deve indicar o valor da propina mensal!");
                }
            }
            else
            {
                MsBox.Show("Deve indicar o número de parcelas!");
            }
        }
    }
}
