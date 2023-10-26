using DMZ.Model.Model;
using DMZ.UI.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public partial class DMZProdesp : UserControl
    {
        public DMZProdesp()
        {
            InitializeComponent();
        }
        public DataRow stQuant;
        private void lblDescPos_Click(object sender, EventArgs e)
        {
            CallMetodo();
        }

        private void CallMetodo()
        {
            ((FrmQuant2)ParentForm).SendData.Invoke(stQuant, ((FrmQuant2)ParentForm).Operacao);
            ((FrmQuant2)ParentForm).Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CallMetodo();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            CallMetodo();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            CallMetodo();
        }

        private void lblPreco_Click(object sender, EventArgs e)
        {
            CallMetodo();
        }
    }
}
