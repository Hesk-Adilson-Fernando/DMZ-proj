using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public partial class SaveCancel : UserControl
    {
        public SaveCancel()
        {
            InitializeComponent();

        }
        public delegate void ClickButton();
        public event ClickButton Execute;
        public virtual void ButtonClick()
        {
            var handler = Execute;
            handler?.Invoke();
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            ButtonClick();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (ParentForm != null)
                ParentForm.Close();
        }
    }
}
