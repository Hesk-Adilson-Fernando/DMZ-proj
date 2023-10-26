using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;

namespace DMZ.UI.UI
{
    public partial class FrmTpgf : Basic.FrmClasse
    {
        private Tpgf tpgf;

        public FrmTpgf()
        {
            InitializeComponent();
        }

        public bool Rh { get; set; }
        private void FrmTpgf_Load(object sender, EventArgs e)
        {
            Campo1 = "Numdoc";
            Campo2 = "descricao";
            Ctabela = "Tpgf";
        }

        public override void DefaultValues()
        {
            tpgf = DoAddline<Tpgf>();
            tpgf.Rh = Rh;
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(tpgf);
            EF.Save(tpgf);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            tpgf = FillControls(tpgf, dt, i);
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
