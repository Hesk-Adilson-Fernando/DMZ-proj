using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmMoedas : Basic.FrmClasse
    {
        public FrmMoedas()
        {
            InitializeComponent();
        }
        private Moedas _moedas;
        private void FrmMoedas__Load(object sender, EventArgs e)
        {
            Campo1 = "Moeda";
            Campo2 = "Descricao";
            Ctabela = "Moedas";
        }
        public override void DefaultValues()
        {
            _moedas = DoAddline<Moedas>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_moedas);
            EF.Save(_moedas);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _moedas = FillControls(_moedas, dt, i);
        }
    }
}
