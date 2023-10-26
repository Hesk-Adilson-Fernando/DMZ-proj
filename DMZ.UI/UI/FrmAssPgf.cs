using System;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmAssPgf : FrmClasse2
    {
        public FrmAssPgf()
        {
            InitializeComponent();
        }

        private void FrmAssPgf_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            _currentTabPage = tabPageHome;
            btnPrev.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (_currentTabPage.Name)
            {
                case "tabPageHome":
                    CallTabPage(tabPageFirst);
                    btnPrev.Visible = true;
                    break;
                case "tabPageFirst":
                    CallTabPage(tabPageSecond);
                    break;
                case "tabPageSecond":
                    CallTabPage(tabPageLast);
                    btnNext.Enabled = false;
                    break;
            }
        }

        private TabPage _currentTabPage;
        private void CallTabPage(TabPage tabPage)
        {
            _currentTabPage = tabPage;
            tabControl1.SelectTab(tabPage);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            switch (_currentTabPage.Name)
            {
                case "tabPageFirst":
                    CallTabPage(tabPageHome);
                    break;
                case "tabPageSecond":
                    CallTabPage(tabPageFirst);
                    btnNext.Enabled = true;
                    break;
                case "tabPageLast":
                    CallTabPage(tabPageSecond);
                    btnNext.Enabled = true;
                    break;
            }
        }
    }
}
