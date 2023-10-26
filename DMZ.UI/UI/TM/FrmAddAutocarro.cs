using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Collections.Generic;
using System.Data;

namespace DMZ.UI.TM
{
    public partial class FrmAddAutocarro : Basic.FrmClasse2
    {
        public FrmAddAutocarro()
        {
            InitializeComponent();
        }

        public string Familiacarstamp { get; internal set; }
        public DataTable dtAutocarro { get; private set; }

        private void FrmAddAutocarro_Load(object sender, EventArgs e)
        {
            gridAuto.Condicao = $"Familiacarstamp='{Familiacarstamp}'";
            gridAuto.BindGridView();
            CLocalStamp = Familiacarstamp;
        }

        private void gridProf_EditingControlShowing(object sender, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private bool gridPanel21_BeforeAddLineEvent()
        {
            var qry = $"select Matricula,Descricao,Ststamp from st where Viatura =1 ";
            dtAutocarro = SQL.GetGen2DT(qry);
            if (dtAutocarro.HasRows())
            {
                var f = new FrmSelect
                {
                    SelectCampos = "",
                    HideFirstColumn = true,
                    Tamanhos = new List<decimal>() { 100, 150,0 },
                    ColFillName = "Descricao",
                    Tabela = "",
                    Condicao = "",
                    SendData = ReceiveInfo,
                    _dt = dtAutocarro
                };
                var xx = $"select Matricula,Descricao,Ststamp from st where 1=0";
                f._dt2 = SQL.GetGen2DT(xx);
                f.ShowDialog();
            }
            else
            {
                MsBox.Show("Não existe professor indicado para esta disciplina, porfavor consulte o RH");
            }
            return true;
        }

        private void ReceiveInfo(DataTable dt)
        {
            if (dt.HasRows())
            {
                foreach (var dr in dt.AsEnumerable())
                {
                    if (!dr.DataRowIsNull())
                    {
                        gridAuto.AddLine();
                        //gridAuto.DataRowr["pestamp"] = dr["pestamp"].ToString();
                        gridAuto.DataRowr["Matricula"] = dr["Matricula"].ToString();
                        gridAuto.DataRowr["Descviatura"] = dr["Descricao"].ToString();
                        gridAuto.DataRowr["Familiacarstamp"] = Familiacarstamp;
                        gridAuto.DataRowr["Ststamp"] = dr["Ststamp"].ToString();
                    }
                }
                gridAuto.Update();
            }
        }
    }
}
