using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.PRC
{
    public partial class FrmAddArtigos1 : FrmClasse2
    {
        public FrmAddArtigos1()
        {
            InitializeComponent();
        }
        public Action<DataTable> SendData;
        public int Origem { get; set; } = 0;

        private void cbDefault1_CheckedChangeds()
        {
            GridProcess.CheckUncheckAll("Status",cbDefault1.cb1.Checked);
        }
        private void btnAddprocess_Click(object sender, EventArgs e)
        {
            var tab = GridProcess.DataSource as DataTable;
            if (tab == null) return;
            if (tab.AsEnumerable().Any(x =>x.Field<bool>("ok").Equals(true)))
            {
                tab = tab.AsEnumerable().Where(x =>x.Field<bool>("ok").Equals(true)).CopyToDataTable();
                SendData.Invoke(tab);
                Close();
            }
            else
            {
                MsBox.Show("Deve selecionar uma linha pelo menos!");
            }
        }

        public void BindiGrid(DataTable dt)
        {
            _dtGrid = dt;
            GridProcess.DataSource = null;
            GridProcess.AutoIncrimento = false;
            GridProcess.DataSource = dt;
        }
        private DataTable _dtGrid;
        private void tbProdMesasProc_TextChanged(object sender, EventArgs e)
        {
            var contage = 0;
            for (int i = 0; i < _dtGrid.Columns.Count; i++)
            {
                if (_dtGrid.Columns[i].ColumnName.ToLower().Equals("familia"))
                {
                    contage = +1;
                }
            }
            DataView dv = new DataView(_dtGrid);
            var qr= $"((descricao like '%{tbProdMesasProc.Text}%') or" +
                    $" (ref like '%{tbProdMesasProc.Text}%')   ";
            if (contage > 0)
            {
                qr += $"or (familia like '%{tbProdMesasProc.Text}%')  ";
            }
            qr += ")";
            dv.RowFilter = qr;
            GridProcess.AutoGenerateColumns = false;
            DataTable dt = dv.ToTable();
            GridProcess.DataSource = dt;
        }

        private void GridProcess_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (Origem == 1)
            {
                btnAddprocess.Visible = false;
                return;
            }
            if (GridProcess.CurrentRow != null && GridProcess.CurrentRow.Index<0) return;
            if (GridProcess.CurrentRow != null && !GridProcess.CurrentRow.Cells["Status"].Value.ToBool())
            {
                GridProcess.CurrentRow.Cells["Status"].Value = true;
            }
            btnAddprocess.PerformClick();
        }

        private void FrmAddArtigos_Load(object sender, EventArgs e)
        {
            if (Origem==1)
            {
                btnAddprocess.Visible = false;
            }
        }
    }
}
