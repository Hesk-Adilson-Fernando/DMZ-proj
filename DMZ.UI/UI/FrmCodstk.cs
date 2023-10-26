using System;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmCodstk : FrmClasse2
    {
        public FrmCodstk()
        {
            InitializeComponent();
        }
        private void FrmCodstk_Load(object sender, EventArgs e)
        {
            grident.Condicao = "codigo < 50 order by codigo";
            grident.BindGridView();
            gridsaida.Condicao = "codigo > 50 order by codigo";
            gridsaida.BindGridView();
            //Helper.BindGrids(grident, "select * from codstk where codigo < 50 order by codigo");
            //Helper.BindGrids(gridsaida, "select * from codstk where codigo > 50 order by codigo");
        }

    }
}
