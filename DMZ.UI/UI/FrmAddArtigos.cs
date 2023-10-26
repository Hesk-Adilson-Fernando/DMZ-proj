using System;
using System.Data;
using System.Linq;
using DMZ.UI.Basic;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmAddArtigos : FrmClasse2
    {
        public FrmAddArtigos()
        {
            InitializeComponent();
        }
        public Action<DataTable> SendData;
        private void FrmAddArtigos_Load(object sender, EventArgs e)
        {
        }

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
                MsBox.Show("Deve selecionar uma linha pelomenos!");
            }
        }

        public void BindiGrid(DataTable dt)
        {
            GridProcess.DataSource = null;
            GridProcess.AutoIncrimento = false;
            GridProcess.DataSource = dt;
        }
    }
}
