using System;
using System.Data;
using System.Windows.Forms;
using DMZ.UI.Basic;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmShowData : FrmClasse2
    {
        public FrmShowData()
        {
            InitializeComponent();
        }

        public string CamposToFill { get; set; }

        private void FrmShowData_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CamposToFill)) return;
            //foreach (var c in CamposToFill.Split(','))
            //{
            //    foreach (DataGridViewTextBoxColumn col in gridUi1.Columns)
            //    {
            //        if (col.Name.Equals(c.Trim()))
            //        {
            //            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        }
            //        else
            //        {
            //            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //           // col.Width = 
            //        }
            //    }
            //}

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var _dt=gridUi1.DataSource as DataTable;
            ;
            if (!(_dt?.Rows.Count > 0)) return;
            var f = new FrmGenreport {Gendt = _dt, Titulo = label1.Text, Filtro = ""};
            f.ShowForm(this);
        }
    }
}
