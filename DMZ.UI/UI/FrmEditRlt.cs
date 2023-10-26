using System;
using System.Drawing;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmEditRlt : FrmClasse2
    {
        public FrmEditRlt()
        {
            InitializeComponent();
        }

        public Action<string> SendInfo { get; set; }

        private void FrmEditRlt_Load(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            SendInfo.Invoke(tbQuerry.Text);
            Close();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            var size = tbQuerry.Font.Size;
            tbQuerry.Font = new Font(tbQuerry.Font.Name,size + 1);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            var size = tbQuerry.Font.Size;
            tbQuerry.Font = new Font(tbQuerry.Font.Name,size -1);
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            FontStyle style = tbQuerry.SelectionFont.Style;
            if (tbQuerry.SelectionFont.Bold)
            {
                style = style & ~FontStyle.Bold;
                btnBold.Font = new Font(btnBold.Font, FontStyle.Regular);
            }
            else
            {
                style = style | FontStyle.Bold;
                btnBold.Font = new Font(btnBold.Font, FontStyle.Bold);
            }
            tbQuerry.SelectionFont = new Font(tbQuerry.SelectionFont, style);
            tbQuerry.Focus();
        }
    }
}
