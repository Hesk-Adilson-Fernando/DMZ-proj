using System;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmPrevis : FrmClasse2
    {
        public FrmPrevis()
        {
            InitializeComponent();
        }

        public DataGridView grid;
        private void btnCompras_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
                grid.CurrentCell.Value = tbAbout.Text;
            Close();
        }

        private void btnZomIn_Click(object sender, EventArgs e)
        {
            try
            {
                float currentSize;
                currentSize = tbAbout.Font.Size;
                if (tbAbout.Font.Size > 350) return;
                currentSize += 2.0F;
                tbAbout.Font = new Font(tbAbout.Font.Name, currentSize,
                    tbAbout.Font.Style, tbAbout.Font.Unit);
            }
            catch
            {
                //
            }
        }

        private void btnZomOut_Click(object sender, EventArgs e)
        {
            try
            {
                float currentSize;
                if (tbAbout.Font.Size < 0) return;
                currentSize = tbAbout.Font.Size;
                currentSize -= 2.0F;
                tbAbout.Font = new Font(tbAbout.Font.Name, currentSize,
                    tbAbout.Font.Style, tbAbout.Font.Unit);
            }
            catch 
            {
                //
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrevis_Load(object sender, EventArgs e)
        {
            tbAbout.Text = grid.CurrentCell.Value.ToString();
        }
    }
}
