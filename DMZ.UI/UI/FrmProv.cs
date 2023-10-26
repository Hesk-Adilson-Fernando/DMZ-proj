using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmProv : Basic.FrmClasse
    {
        public FrmProv()
        {
            InitializeComponent();
        }
        private Prov _prov;
        private void FrmProv_Load(object sender, EventArgs e)
        {
            Ctabela = "Prov";
            Campo1 = "codProv";
            Campo2 = "descricao";
            gridUIDistritos.Codigo = "coddist";
            gridUIDistritos.AutoIncrimento = true;
            gridUiPad.GridFilhaSecundaria = true;
            gridUiPad.Condicao = "1=1";
           // gridUiPad.OrderbyCampos = "Codpad";
        }
        public override void DefaultValues()
        {
            _prov = DoAddline<Prov>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_prov);
            EF.Save(_prov);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _prov = FillControls(_prov, dt, i);
            gridUIDistritos.Condicao = $"Provstamp='{CLocalStamp}'";
            if (gridUIDistritos.CurrentRow == null) return;
            var stampdist = gridUIDistritos.CurrentRow.Cells["diststamp"].Value.ToString().Trim();
            gridUiPad.Condicao = $"Diststamp='{stampdist}'";
            gridUiPad.BindGridView();
            //var dr = gridUIDistritos.CurrentRow;
            //var dt2 = gridUiPad.DataSource as DataTable;
            //if (dt2 == null) return;
            //dt2.Rows.Clear();
            //gridUiPad.DataSource = dt2;
        }

        private void gridPanel21_CallForm()
        {

            if (gridUIDistritos.CurrentRow !=null)
            {

                var stampdist = gridUIDistritos.CurrentRow.Cells["diststamp"].Value.ToString().Trim();
                if (gridUiPad.Rows.Count >0)
                {
                    gridUiPad.SaveData(true, "pad", stampdist);
                }
                var coddist=gridUIDistritos.CurrentRow.Cells["coddist"].Value.ToString().Trim();
                gridUiPad.AddLine();
                gridUiPad.DataRowr["coddist"] = coddist;
                var mx = SQL.Maximo("pad", "Codpad", $"coddist ={coddist}");
                var codpad = ""; 
                if (mx.ToString().Length==1)
                {
                    codpad = coddist.Trim() + mx;
                }
                else
                {
                    codpad = mx.ToString();
                }
                gridUiPad.DataRowr["coddist"] = coddist;
                gridUiPad.DataRowr["Codpad"] = codpad;
                gridUiPad.DataRowr["Diststamp"] = stampdist;
            }
            else
            {
                MsBox.Show("Deve selecionar o distrito na tabela acima!..");
            }
        }

        private void gridUIDistritos_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (gridUIDistritos.CurrentRow != null)
            {
                var stampdist = gridUIDistritos.CurrentRow.Cells["diststamp"].Value.ToString().Trim();
                gridUiPad.Condicao = $"Diststamp='{stampdist}'";
                gridUiPad.BindGridView();
            }
        }
    }
}
