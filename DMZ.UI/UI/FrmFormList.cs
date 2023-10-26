using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmFormList : FrmClasse2
    {
        public FrmFormList()
        {
            InitializeComponent();
        }

        public Action<DataTable,bool> Enviar { get; set; }

        public bool Isdoc { get; set; }
        private void FrmFormList_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnformularios_Click(object sender, EventArgs e)
        {
            var dt = gridUi1.DataSource as DataTable;
            if (dt == null) return;
            if (dt.AsEnumerable().Any(x => x.Field<bool>("ok").Equals(true)))
            {
                var dt2 = dt.AsEnumerable().Where(x => x.Field<bool>("ok").Equals(true)).CopyToDataTable();
                Enviar(dt2,Isdoc);
            }
            Close();
        }

        private void cbDefault1_CheckedChangeds()
        {
            if (gridUi1.Rows.Count>0)
            {
                foreach (DataGridViewRow r in gridUi1.Rows)
                {
                    r.Cells["ok"].Value = cbDefault1.cb1.Checked;
                }
                gridUi1.Update();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
