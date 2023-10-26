using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.Basic
{
    public partial class MdiMaster : Form
    {
        public MdiMaster()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        private void MdiMaster_Load(object sender, EventArgs e)
        {
            //tabControl1.TabPages.Remove(tabPageContabilidade);
            //if (Controls != null)
            //    Controls.OfType<MdiMaster>().FirstOrDefault().BackColor = Color.Lavender;
            //Controls.OfType<MdiMaster>().FirstOrDefault().BackgroundImage = Properties.Resources._28_Free_Books_for_Learning_Software_Architecture;
        }
    }
}
