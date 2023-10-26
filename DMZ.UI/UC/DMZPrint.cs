using System;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public partial class DMZPrint : UserControl
    {
        public DMZPrint()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MenuPrint.ShowMenuStrip(btnPrint);
            //if (Usracessos.Imprimir)
            //{
            //    MenuPrint.ShowMenuStrip(btnPrint);
            //}
            //else
            //{
            //    MsBox.Show("Não tem permissão para imprimir. Contacte o administrador!");
            //}
        }
    }
}
