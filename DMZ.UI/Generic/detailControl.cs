using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.Generic
{
    public class DetailControl: TabControl
    {
        #region MyRegion

        internal List<DataGridView> childGrid = new List<DataGridView>();
        internal DataSet _cDataset;

        #endregion

        #region MyRegion

        internal void Add(string tableName, string pageCaption,DataTable dt)
        {
            var tPage = new TabPage { Text = pageCaption };
            TabPages.Add(tPage);
            var newGrid = new DataGridView { Dock = DockStyle.Fill, DataSource = new DataView(dt) };
            tPage.Controls.Add(newGrid);
            var c= new CModule();
            c.ApplyGridTheme(newGrid);
            c.SetGridRowHeader(newGrid);
            newGrid.RowPostPaint += c.RowPostPaint_HeaderCount;
            childGrid.Add(newGrid);
        }

        #endregion
    }
}
