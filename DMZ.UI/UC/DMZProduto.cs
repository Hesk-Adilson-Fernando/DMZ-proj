using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.UI;

namespace DMZ.UI.UC
{
    public partial class DMZProduto : UserControl
    {
        private string _codigo;
        private string _preco;
        private string _nome;

        public DMZProduto()
        {
            InitializeComponent();
        }
        [Category("Product Details")]
        public string Nome
        {
            get => _nome;
            set { _nome = value; lblName.Text = value; }
        }
        [Category("Product Details")]
        public string Preco
        {
            get => _preco;
            set { _preco = value; lblPrice.Text = value; }
        }
        public string Codigo
        {
            get => _codigo;
            set { _codigo = value; lblPrice.Text = value; }
        }
        public string Refenrec { get; set; }
        public bool Usaquant2 { get; internal set; }

        private void Adicionar(bool operacao) {
            if (Usaquant2)
            {
                var dt = SQL.GetGen2DT($"select * from StQuant where ststamp ='{Refenrec.Trim()}'");
                if (dt.HasRows())
                {
                    var f = new FrmQuant2();
                    f.Dt = dt;
                    f.SendData = ReceiveData;
                    f.TopLevel = false;
                    //f.Size = new Size(((FrmPosRest)ParentForm)?.fLPSubProduct.Size.Width - 10, ((FrmPosRest)ParentForm)?.fLPSubProduct.Size.Height - 10);
                   // ((FrmPosRest)ParentForm)?.fLPSubProduct.Controls.Clear();
                    ((FrmPosRest)ParentForm)?.fLPSubProduct.Controls.Add(f);
                   // f.FormClosing += F_FormClosing;
                    f.label1.Text=lblName.Text+" - Itens";
                    f.Show();
                    
                    //f.ShowDialog();
                }
            }
            else
            {
                ((FrmPosRest)ParentForm)?.AddLine(Refenrec,operacao);
            }

        }
        public void ReceiveData(DataRow stQuant,bool operacao)
        {
            ((FrmPosRest)ParentForm)?.AddLine(Refenrec, true, stQuant);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Adicionar(false);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            Adicionar(true);
        }

        private void picBoxProduct_Click(object sender, EventArgs e)
        {
            Adicionar(true);
        }

        private void lblName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DMZProduto_Load(object sender, EventArgs e)
        {

        }

        private void lblPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
