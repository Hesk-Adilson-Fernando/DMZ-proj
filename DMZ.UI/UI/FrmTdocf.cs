using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;

namespace DMZ.UI.UI
{
    public partial class FrmTdocf : Basic.FrmClasse
    {
        public FrmTdocf()
        {
            InitializeComponent();
        }
        private Tdocf _tdocf;
        private void FrmTdocf_Load(object sender, EventArgs e)
        {
            Campo1 = "Numdoc";
            Campo2 = "descricao";
            Ctabela ="tdocf";  
        }
        public override void DefaultValues()
        {
            _tdocf = DoAddline<Tdocf>();
            base.DefaultValues();
            //dmzOptionGroup1.RefreshControl();
        }
        public override void Save()
        {
            FillEntity(_tdocf);
            EF.Save(_tdocf);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _tdocf = FillControls(_tdocf, dt, i);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dgvHorasExtras_EditingControlShowing(object sender, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs e)
        {
            var colName = dgvHorasExtras.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (colName.Equals("ccusto"))
            {
                DtCcu = Helper.SetBinds(e.Control, "descricao", "select codccu, descricao from ccu");
            }
        }

        public DataTable DtCcu { get; set; }

        private void dgvHorasExtras_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            dgvHorasExtras.BeginEdit(true);
        }

        private void dgvHorasExtras_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var colName = dgvHorasExtras.CurrentCell.OwningColumn.Name;
            if (!colName.Trim().Equals("ccusto")) return;
            if (dgvHorasExtras.CurrentRow == null) return;//
            var valor = dgvHorasExtras.CurrentRow.Cells["ccusto"].Value.ToString().Trim();
            if (!(DtCcu?.Rows.Count > 0)) return;
            var dr = Enumerable.Where(DtCcu.AsEnumerable(), r => r != null).FirstOrDefault(r => r["descricao"].ToString().Trim().Equals(valor));
            if (dr == null) return;
            dgvHorasExtras.CurrentRow.Cells["codccu"].Value = dr["codccu"].ToString();
        }
    }
}
