using System;
using System.ComponentModel;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.UI;

namespace DMZ.UI.UC
{
    public partial class Category : UserControl
    {
        public Category()
        {
            InitializeComponent();
        }

        private string _name;
        private string _codfam;

        [Category("Category Details")]
        public string Titulo
        {
            get => _name;
            set { _name = value; btnCategory.Text = value; }
        }
        public string Codigo
        {
            get => _codfam;
            set { _codfam = value; lblCodigo.Text = value; }
        }

        public int Origem { get; set; }

        public string CodFam { get; set;}

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            string qry;
            ((FrmPosRest)ParentForm).fLPSubProduct.Controls.Clear();
            qry = Helper.GetProdutos($" and st.CodFam='{CodFam.Trim()}'");
            var dt = SQL.GetGenDT(qry);
            if (dt.HasRows())
            {
                Helper.ViewProdutos(dt,(Button)sender,ParentForm,Origem);
            }
        }
    }
}
