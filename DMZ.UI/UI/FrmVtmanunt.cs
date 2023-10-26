using System;
using DMZ.BL.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmVtmanunt : Basic.FrmClasse2
    {
        public FrmVtmanunt()
        {
            InitializeComponent();
        }

        private void FrmVtmanunt_Load(object sender, EventArgs e)
        {
            gridPreco.DataSource = null;
            gridPreco.AutoGenerateColumns = false;
            gridPreco.DataSource = SQL.GetGen2DT("select * from Vtmanunt order by data desc");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var qry = "select data,Matricula,Km,Motorista from Vtmanunt";
            //var dt = SQL.GetGen2DT(qry);
            //var frm = new FrmPrint();
            
        }
    }
}
