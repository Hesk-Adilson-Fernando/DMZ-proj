using System;
using DMZ.BL.Classes;

namespace DMZ.UI.UI.Contabil
{
    public partial class Pedeval : Basic.FrmClasse2
    {
        public Pedeval()
        {
            InitializeComponent();
        }

        public Action<decimal> PControl;
        private void btnProcess_Click(object sender, EventArgs e)
        {
            PControl?.Invoke(tbValor.Text.ToDecimal());
            Close();
        }
    }
}
