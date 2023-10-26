using System;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Extensions;

namespace DMZ.UI.UI
{
    public partial class FrmStockminalert : FrmClasse2
    {
        public FrmStockminalert()
        {
            InitializeComponent();
        }

        private void FrmStockminalert_Load(object sender, EventArgs e)
        {
            var dt = SQL.GetGen2DT(@"
                select ref,st.Descricao,starm.Stock,starm.StockMin from starm 
                right join st on st.Referenc = Starm.Ref
                where starm.Stock<starm.StockMin order by st.Descricao");
            gridUi1.SetDataSource(dt);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Configuracao.ShowMenuStrip(btnMenu);
        }
    }
}
