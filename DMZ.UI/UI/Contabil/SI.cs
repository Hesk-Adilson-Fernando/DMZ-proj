using System;

namespace DMZ.UI.UI.Contabil
{
    public partial class SI : Basic.FrmClasse2
    {
        public SI()
        {
            InitializeComponent();
        }

        private void SI_Load(object sender, EventArgs e)
        {
            tbDescricao.Text = "Saldos Iniciais";
        }
    }
}
