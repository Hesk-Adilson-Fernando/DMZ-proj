using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmTRcl : Basic.FrmClasse
    {
        private TRcl _tRcl;

        public FrmTRcl()
        {
            InitializeComponent();
        }

        private void FrmTRcl_Load(object sender, EventArgs e)
        {
            Campo1 = "Numdoc";
            Campo2 = "descricao";
            Ctabela = "TRcl";
        }
        public override void DefaultValues()
        {
            _tRcl = DoAddline<TRcl>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_tRcl);
            EF.Save(_tRcl);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _tRcl = FillControls(_tRcl, dt, i);
        }

        public void ReceiveData(DataTable dt)
        {
            //foreach (var r in dt.AsEnumerable())
            //{
            //    if (r==null)continue;
            //    gridUi1.AddLine();
            //    var index = gridUi1.Rows.Count - 1;
            //    gridUi1.Rows[index].Cells[0].Value = r[0];
            //    gridUi1.Rows[index].Cells[1].Value = r[1];
            //}
            //gridUi1.Update();
        }
        private void gridPanel2_CallForm()
        {
            var f = new FrmAddlines("Módulos Disponíveis", "Select Codigo, Descricao, OK = CAST(0 as bit) from modulos order by codigo ") {PControl = ReceiveData};
            f.ShowForm(this);

        }

        private void dgvHorasExtras_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            dgvHorasExtras.BeginEdit(true);
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
