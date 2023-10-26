using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmGrupo : Basic.FrmClasse
    {
        public FrmGrupo()
        {
            InitializeComponent();
        }
        private Grupo grupo;
        private void FrmGrupo_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Grupo";
            gridUI1.Codigo = "Codigo";
            gridUI1.AutoIncrimento = true;
        }
        public override void DefaultValues()
        {
            grupo = DoAddline<Grupo>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(grupo);
            EF.Save(grupo);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            grupo = FillControls(grupo, dt, i);
            gridUI1.Condicao = $"Grupostamp='{CLocalStamp}'";
        }

        private void gridUI1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.SetPdfFile(gridUI1, "anexo", "pdf");
            Helper.ViewPdfFile(gridUI1, "ver", "pdf");
        }
    }
}
