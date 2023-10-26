using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmAssistenteCl : Basic.FrmClasse2
    {
        public FrmAssistenteCl()
        {
            InitializeComponent();
        }

        private void FrmAssistenteCl_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void btnContasCl_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageNumeros);
        }

        private void btnCc_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageCC);
        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPagefactmensal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageDividas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageCC);
        }
    }
}
