using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;

namespace DMZ.UI.UI
{
    public partial class FrmSubFam : Basic.FrmClasse
    {
        private SubFam _subFam;
        public FrmSubFam()
        {
            InitializeComponent();
        }

        public decimal CodFamilia { get; set; }
        public string Familiastamp { get; set; }

        private void FrmSubFam_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "SubFam";
        }

        public override void DefaultValues()
        {
            _subFam = DoAddline<SubFam>();
            _subFam.Familiastamp = Familiastamp;
            base.DefaultValues();
            if (codigo.tB1.Text.Length==1)
            {
                codigo.tB1.Text = CodFamilia.ToString().Trim() + codigo.tB1.Text;
            }
        }
        public override void Gravar()
        {
            FillEntity(_subFam);
            SQLExec.Save(_subFam);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            Procurou = true;
            _subFam = FillControls(_subFam, dt, i);
        }

    }
}
