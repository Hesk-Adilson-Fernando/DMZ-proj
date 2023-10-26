using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmGrade : Basic.FrmClasse
    {
        public FrmGrade()
        {
            InitializeComponent();
        }

        private void FrmGrade_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela ="Grade";
        }
        private Grade grade;
        private DataTable dtetapa;

        public DataTable Dt { get; private set; }

        public override void DefaultValues()
        {
            grade = DoAddline<Grade>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(grade);
            EF.Save(grade);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            grade = FillControls(grade, dt, i);
        }

        private void gridUi3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var nome=gridUi3.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("etapa"))
            {
                var qry = "select Semstamp,Codigo,Ordem from sem";
                dtetapa = Helper.SetBinds(e.Control, "Codigo", qry);
            }
            else
            {
                Dt = Helper.ShowDisciplina(gridUi3.CurrentCell, e, "select Referenc,Descricao,Ststamp,sigla,Credac,Cargahtotal,Cargahteorica,Cargahpratica from ST where disciplina=1");
            }
        }

        private void gridUi3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUi3.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))
            {
                SetRowValue("descricao");
            }
            if (nome.Equals("referenc"))
            {
                SetRowValue("referenc");
            }
            if (nome.Equals("etapa"))
            {
                if (gridUi3.CurrentCell?.Value == null) return;
                var valor = gridUi3.CurrentCell.Value.ToString().Trim();
                if (!(dtetapa?.Rows.Count > 0)) return;
                var dr = dtetapa.AsEnumerable().FirstOrDefault(s => s.Field<string>("codigo").Trim().Equals(valor));
                if (dr == null) return;
                gridUi3.CurrentRow.Cells["Semstamp"].Value = dr["Semstamp"].ToString();
                gridUi3.CurrentRow.Cells["Ordem"].Value = dr["Ordem"].ToString();
                gridUi3.Update();
            }
            SetTotais();
        }

        private void SetTotais()
        {
            gridUi3.Update();
            if (gridUi3.Rows.Count>0)
            {
                DataTable dt = gridUi3.GetBindedTable();
                tbTotalDisc.tb1.Text = dt.Rows.Count.ToString();
                tbCContato.tb1.Text = dt.Sum("Cargahteorica").ToString();
                tbCredTotal.tb1.Text = dt.Sum("Credac").ToString();
                tbCEstudo.tb1.Text = dt.Sum("Cargahpratica").ToString();
                tbCTotal.tb1.Text = dt.Sum("Cargahtotal").ToString();
            }
        }

        private void SetRowValue(string referenc)
        {
            if (gridUi3.CurrentCell?.Value == null) return;
            var valor = gridUi3.CurrentCell.Value.ToString().Trim();
            if (!(Dt?.Rows.Count > 0)) return;
            var dr = Dt.AsEnumerable().FirstOrDefault(s => s.Field<string>(referenc).Trim().Equals(valor));
            if (dr == null) return;
            switch (referenc)
            {
                case "descricao":
                    gridUi3.CurrentRow.Cells["referenc"].Value = dr[0].ToString();
                    NewMethod(dr);
                    break;
                default:
                    gridUi3.CurrentRow.Cells["descricao"].Value = dr[1].ToString();
                    NewMethod(dr);
                    break;
            }
            gridUi3.Update();
        }

        private void NewMethod(DataRow dr)
        {
            gridUi3.CurrentRow.Cells["ststamp"].Value = dr["ststamp"].ToString();
            gridUi3.CurrentRow.Cells["Credac"].Value = dr["Credac"].ToString();
            gridUi3.CurrentRow.Cells["CHpratica"].Value = dr["Cargahpratica"].ToString();
            gridUi3.CurrentRow.Cells["chteorica"].Value = dr["Cargahteorica"].ToString();
            gridUi3.CurrentRow.Cells["CHTotal"].Value = dr["Cargahtotal"].ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SetTotais();
        }

        private void gridUi3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Helper.CellEnter(sender,e);
        }
    }
}
