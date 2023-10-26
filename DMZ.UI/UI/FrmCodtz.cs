using System;

namespace DMZ.UI.UI
{
    public partial class FrmCodtz : Basic.FrmClasse2
    {
        public FrmCodtz()
        {
            InitializeComponent();
        }

        private void FrmCodtz_Load(object sender, EventArgs e)
        {
            grident.Condicao = "codigo < 50 order by codigo";
            grident.BindGridView();
            gridsaida.Condicao = "codigo > 50 order by codigo";
            gridsaida.BindGridView();
        }
    }
}
