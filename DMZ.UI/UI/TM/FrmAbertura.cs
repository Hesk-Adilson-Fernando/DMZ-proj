using DMZ.Model.Model;
using System;

namespace DMZ.UI.UI.TM
{
    public partial class FrmAbertura : Basic.FrmClasse
    {
        public FrmAbertura()
        {
            InitializeComponent();
        }
        private Auxiliar _auxiliar;
        private void FrmAbertura_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Auxiliar";
        }
    }
}
