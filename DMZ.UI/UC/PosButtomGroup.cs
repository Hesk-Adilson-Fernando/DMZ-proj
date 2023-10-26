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
    public partial class PosButtomGroup : UserControl
    {
        public PosButtomGroup()
        {
            InitializeComponent();
        }
        public delegate void Refrescar();

        public event Refrescar RefreshControls;
        protected virtual void OnRefreshControls()
        {
            var handler = RefreshControls;
            handler?.Invoke();
        }
        private void btnCodigo_Click(object sender, EventArgs e)
        {
            btnCodigo.Image = Properties.Resources.Checkmark_25px;
            //Codigo = true;
            //Barcode = false;
            //btnBarcode.Enabled = false;
            //btnBarcode.Image=null;
            //btnDescricao.Image = null;
            //btnDescricao.Enabled=false;
        }

        public bool Descricao { get; private set; }
        public bool Codigo { get; set; }
        public bool Barcode { get; private set; }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            btnBarcode.Image = Properties.Resources.Checkmark_25px;
            Barcode = true;
            Codigo = false;
            btnCodigo.BackColor= Color.DarkGoldenrod;
            btnCodigo.Image = null;
            btnDescricao.Image = null;
            btnDescricao.BackColor = Color.DarkGoldenrod;
            btnBarcode.BackColor = Color.FromArgb(39, 59, 80);
        }

        private void btnDescricao_Click(object sender, EventArgs e)
        {
            btnBarcode.Image = null;
            btnBarcode.BackColor = Color.DarkGoldenrod;
            Descricao = true;
            Codigo = false;
            Barcode = false;
            btnCodigo.BackColor = Color.DarkGoldenrod;
            btnCodigo.Image = null;
            btnDescricao.Image = Properties.Resources.Checkmark_25px;
            btnDescricao.BackColor = Color.FromArgb(39, 59, 80);
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                OnRefreshControls();
            }
            
        }
    }
}
