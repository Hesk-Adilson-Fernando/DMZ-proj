using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmDpd : Basic.FrmClasse
    {
        private Dc _dc;
        private DataTable _dtconta;
        private DataTable _ddi;
        public FrmDpd()
        {
            InitializeComponent();
        }

        private void FrmDPD_Load(object sender, EventArgs e)
        {
            Ctabela = "dc";
            Campo1 = "docno";
            Campo2 = "docnome";
        }
        public override void DefaultValues()
        {
            _dc = DoAddline<Dc>();
            base.DefaultValues();
        }

        public override bool BeforeSave()
        {
            if (cbApRes.cb1.Checked)
            {
                if (SQL.CheckExist("select top 1 docno from dc where apurares=1"))
                {
                    MsBox.Show("Estimado(a), Já existe um documento de apuramento de Resultado!");
                    return false;
                }
            }

            if (cbApIVA.cb1.Checked)
            {
                if (!SQL.CheckExist("select top 1 docno from dc where apuraiva=1")) return base.BeforeSave();
                MsBox.Show("Estimado(a), Já existe um documento de apuramento de IVA!");
                return false;
            }
            return base.BeforeSave();
        }

        public override void Save()
        {
            FillEntity(_dc);
            EF.Save(_dc);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _dc = FillControls(_dc, dt, i);
        }
        private void gridPanel21_Load(object sender, EventArgs e)
        {

        }
        private void Parametr(DataTable dt)
        {
            foreach (var r in dt.AsEnumerable())
            {
                var rw = _ddi.AsEnumerable().FirstOrDefault(x => x.Field<string>("conta").Trim().Equals(r["conta"].ToString().Trim()));
                if (rw == null) continue;
                rw["factor"] = r["factor"];
            }
            dgvDcli.Update();
        }


        private void btnFactor_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            var cal = new FrmCalFactor { PControl = Parametr };
            _ddi = dgvDcli.DataSource as DataTable;
            if (_ddi != null)
                foreach (var r in _ddi.AsEnumerable())
                {
                    if (r == null) return;
                    var dr = cal.Dt.NewRow();
                    dr["conta"] = r["conta"];
                    dr["integ"] = false;
                    cal.Dt.Rows.Add(dr);
                }

            cal.ShowForm(this);
        }

        private void gridUi1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDcli.CurrentRow == null) return;
               var lista = new List<Ec>{new Ec{Conta=true,Nome="ClnConta"},new Ec{Conta=false,Nome="descricao"}};
               _dtconta = Ct.EditControl(dgvDcli.CurrentCell, e,lista);
        }
        private void gridUi1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Ct.CellEndEdit(dgvDcli, _dtconta,new List<string>{"descricao","clnconta"});
        }


        private void dgvDcli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.ColumnIndex != 1) return;
            if (dgvDcli.CurrentRow == null) return;
            Ct.CallQuerryForm(this);
        }

        public override void UpdateGrid(DataRow dr)
        {
            if (dgvDcli.CurrentRow != null)
            {
                dgvDcli.CurrentRow.Cells["clnconta"].Value = dr[0];
                dgvDcli.CurrentRow.Cells["descricao"].Value = dr[1];
            }
            dgvDcli.Update();
        }

        private void dgvDcli_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDcli_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            

            
            //if (e.Context == DataGridViewDataErrorContexts.Commit)
            //{
            //    MsBox.Show("Commit error");
            //}
            //if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            //{
            //    MsBox.Show("Cell change");
            //}
            //if (e.Context == DataGridViewDataErrorContexts.Parsing)
            //{
            //    
            //}
            //if (e.Context == DataGridViewDataErrorContexts.LeaveControl)
            //{
            //    MsBox.Show("leave control error");
            //}

            //if (e.Exception )
            //{
            //    var view = (DataGridView)sender;
            //    view.Rows[e.RowIndex].ErrorText = "an error";
            //    view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";
            //    e.ThrowException = false;
            //}
        }

        private void dgvDcli_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Helper.CellEnter(sender,e);
        }
    }
}
