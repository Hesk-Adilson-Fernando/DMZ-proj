using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.UC;
using System;
using System.Linq;

namespace DMZ.UI.UI.RH
{
    public partial class FrmRHDashboard : Basic.FrmClasse2
    {
        public FrmRHDashboard()
        {
            InitializeComponent();
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }

        private void FrmRHDashboard_Load(object sender, EventArgs e)
        {
            //BindPanel(dmzPanel1);
            if (!dmzPanel1.Origem.IsNullOrEmpty())
            {
                var dt = SQL.GetGen2DT($"select * from rlt where ComboQry5 ='{dmzPanel1.Origem.Trim()}' and TipoRlt=1");
                if (dt.HasRows())
                {
                    dmzPanel1.BindGrid(dt.RowZero("crquery").ToString(), dt.RowZero("descricao").ToString());
                }
            }
            if (!dmzPanel2.Origem.IsNullOrEmpty())
            {
                var dt = SQL.GetGen2DT($"select * from rlt where ComboQry5 ='{dmzPanel2.Origem.Trim()}' and TipoRlt=1");
                if (dt.HasRows())
                {
                    dmzPanel2.BindGrid(dt.RowZero("crquery").ToString(), dt.RowZero("descricao").ToString());
                }
            }
            //BindPanel(dmzPanel2);
            BindPanel(dmzPanel3);
        }
        private void BindPanel(DMZDataDisplay d)
        {
            if (!d.Origem.IsNullOrEmpty())
            {
                var dt = SQL.GetGen2DT($"select * from rlt where ComboQry5 ='{d.Origem.Trim()}' and TipoRlt=1");
                if (dt.HasRows())
                {
                    d.BindGrid(dt.RowZero("crquery").ToString(), dt.RowZero("descricao").ToString());
                } 
            }
        }

        private void dmzPanel1_BtnRefrescar()
        {
            BindPanel(dmzPanel1);
        }

        private void dmzPanel2_BtnRefrescar()
        {
            BindPanel(dmzPanel2);
        }
    }
}
