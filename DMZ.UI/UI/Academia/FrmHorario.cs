using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmHorario :Basic.FrmClasse
    {
        public FrmHorario()
        {
            InitializeComponent();
        }

        private void FrmHorario_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Horario";
        }
        private Horario horario;

        public DataTable Dt { get; private set; }

        public override void DefaultValues()
        {
            horario = DoAddline<Horario>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(horario);
            EF.Save(horario);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            horario = FillControls(horario, dt, i);
        }
        private void cbDefault2_Load(object sender, EventArgs e)
        {

        }

        private void tbTurma_RefreshControls()
        {
            tbAnosem.tb1.Text = tbTurma.Text3;
        }

        private void gridUi3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi3.CurrentRow == null) return;
            if (!tbTurma.tb1.Text.IsNullOrEmpty())
            {
                var qry = $"select Referenc,Disciplina from Turmadisc where Turmastamp='{tbTurma.Text2.Trim()}'";
                Dt = Helper.SetBinds(e.Control, "Disciplina", qry);
            }
        }

        private void gridUi3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi3.CurrentCell?.Value == null) return;
            var valor = gridUi3.CurrentCell.Value.ToString().Trim();
            var dr = Dt.AsEnumerable().FirstOrDefault(s => s.Field<string>("Disciplina").Trim().Equals(valor));
            if (dr == null) return;
            gridUi3.CurrentCell.Value = dr["Referenc"].ToString();//Armazemstamp
            gridUi3.Update();
        }
    }
}
