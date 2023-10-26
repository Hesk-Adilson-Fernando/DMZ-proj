using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmCurso : Basic.FrmClasse
    {
        public FrmCurso()
        {
            InitializeComponent();
        }

        private void FrmCursconfig_Load(object sender, EventArgs e)
        {
            Campo1 = "Codcurso";
            Campo2 = "Desccurso";
            Ctabela = "Curso";
        }
        private Curso curso;
        public override void DefaultValues()
        {
            curso = DoAddline<Curso>();
            status.SetStatusValue();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(curso);
            EF.Save(curso);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            curso = FillControls(curso, dt, i);
            var Grade = SQL.GetGen2DT($"select Gradestamp,Descricao,Codigo from Grade where Cursostamp='{curso.Cursostamp}'");
            gridUiGrade.SetDataSource(Grade);
        }
        private void procura2_Load(object sender, EventArgs e)
        {

        }

        private void gridUi3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.SetPdfFile(gridUi3, "anexo", "pdf");
            Helper.ViewPdfFile(gridUi3, "Ver", "pdf");
        } 
        private void gridUiGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.ShowForm<FrmGrade>(gridUiGrade, this, "Grade", "Gradestamp", "origem");
        }
    }
}
