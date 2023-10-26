using System;

namespace DMZ.UI.UI
{
    public partial class FrmCodcc : Basic.FrmClasse2
    {
        public FrmCodcc()
        {
            InitializeComponent();
        }

        private void FrmCodcc_Load(object sender, EventArgs e)
        {

            gridDeb.Condicao = "codigo < 100 order by codigo";
            gridDeb.BindGridView();
            gridCre.Condicao = "codigo >= 100 order by codigo";
            gridCre.BindGridView();
        }

    }
}
