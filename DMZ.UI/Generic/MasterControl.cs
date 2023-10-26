using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DMZ.DAL.Migrations;

namespace DMZ.UI.Generic
{


    public class MasterControl: DataGridView
    {
        #region "Variables"
         List<int> rowCurrent = new List<int>();
        int rowDefaultHeight = 22;
        int rowExpandedHeight = 300;
        decimal rowDefaultDivider = 0;
        static int rowExpandedDivider = 300 - 22;
        static int rowDividerMargin = 5;
        bool _collapseRow;
        public DetailControl childView = new DetailControl { Height = rowExpandedDivider - rowDividerMargin * 2, Visible = false };
        public DataSet _cDataset;
        private string _foreignKey;
        private string _filterFormat;
        private System.ComponentModel.IContainer components;
        private ImageList RowHeaderIconList = new ImageList();

        #endregion

        #region Initialze and Display

        public void  New( DataSet cDataset)
        {
            Controls.Add(childView);
            InitializeComponent();
            _cDataset = cDataset;
            childView._cDataset = cDataset;
            var c = new CModule();
            c.ApplyGridTheme(this);
            Dock = DockStyle.Fill;
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterControl));
            RowHeaderIconList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // RowHeaderIconList
            // 
            RowHeaderIconList.ImageStream = ((ImageListStreamer)(resources.GetObject("RowHeaderIconList.ImageStream")));
            RowHeaderIconList.TransparentColor = Color.Transparent;
            RowHeaderIconList.Images.SetKeyName(0, "Collapse.png");
            RowHeaderIconList.Images.SetKeyName(1, "Expand.png");
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            ResumeLayout(false);

        }
        #endregion

        #region DataControl

        internal void setParentSource(string tableName, string foreignKey)
        {
            DataSource = new DataView(_cDataset.Tables[tableName]);
            var c = new CModule();
            c.SetGridRowHeader(this);
            _foreignKey = foreignKey;
            if (_cDataset.Tables[tableName].Columns[foreignKey].GetType().ToString() == typeof(int).ToString() || _cDataset.Tables[tableName].Columns[foreignKey].GetType().ToString() == typeof(double).ToString() || _cDataset.Tables[tableName].Columns[foreignKey].GetType().ToString() == typeof(decimal).ToString())
                _filterFormat = foreignKey + "={0}";
            else
                _filterFormat = foreignKey + "='{0}'";
        }

        #endregion


        #region GridEvents

        private void MasterControl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rect = new Rectangle((int) ((rowDefaultHeight - 16) / (decimal) 2), (int) ((rowDefaultHeight - 16) / (double)2), 16, 16);
            if (rect.Contains(e.Location))
            {
                if (rowCurrent.Contains(e.RowIndex))
                {
                    rowCurrent.Clear();
                    Rows[e.RowIndex].Height = rowDefaultHeight;
                    Rows[e.RowIndex].DividerHeight = (int) rowDefaultDivider;
                }
                else
                {
                    if (rowCurrent.Count != 0)
                    {
                        var eRow = rowCurrent[0];
                        rowCurrent.Clear();
                        Rows[eRow].Height = rowDefaultHeight;
                        Rows[eRow].DividerHeight = (int) rowDefaultDivider;
                        ClearSelection();
                        _collapseRow = true;
                        Rows[eRow].Selected = true;
                    }
                    rowCurrent.Add(e.RowIndex);
                    Rows[e.RowIndex].Height = rowExpandedHeight;
                    Rows[e.RowIndex].DividerHeight = rowExpandedDivider;
                }
                ClearSelection();
                _collapseRow = true;
                Rows[e.RowIndex].Selected = true;
            }
            else
                _collapseRow = false;
        }
    private void MasterControl_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
    {
        // set childview control
        var grid = (DataGridView) sender;
        var rect = new Rectangle((int) (e.RowBounds.X + (rowDefaultHeight - 16) / (double)2), (int) (e.RowBounds.Y + ((rowDefaultHeight - 16) / (double)2)), 16, 16);
        if (_collapseRow)
        {
            if (rowCurrent.Contains(e.RowIndex))
            {
                grid.Rows[e.RowIndex].DividerHeight = grid.Rows[e.RowIndex].Height - rowDefaultHeight;
                if (RowHeaderIconList != null)
                    e.Graphics.DrawImage(RowHeaderIconList.Images[0], rect);
                childView.Location = new Point(e.RowBounds.Left + grid.RowHeadersWidth, e.RowBounds.Top + rowDefaultHeight + 5);
                childView.Width = e.RowBounds.Right - grid.RowHeadersWidth;
                childView.Height = grid.Rows[e.RowIndex].DividerHeight - 10;
                childView.Visible = true;
            }
            else
            {
                childView.Visible = false;
                e.Graphics.DrawImage(RowHeaderIconList.Images[1], rect);
            }
            _collapseRow = false;
        }
        else if (rowCurrent.Contains(e.RowIndex))
        {
            grid.Rows[e.RowIndex].DividerHeight = grid.Rows[e.RowIndex].Height - rowDefaultHeight;
            e.Graphics.DrawImage(RowHeaderIconList.Images[0], rect);
            childView.Location = new Point(e.RowBounds.Left + grid.RowHeadersWidth, e.RowBounds.Top + rowDefaultHeight + 5);
            childView.Width = e.RowBounds.Right - grid.RowHeadersWidth;
            childView.Height = grid.Rows[e.RowIndex].DividerHeight - 10;
            childView.Visible = true;
        }
        else
            e.Graphics.DrawImage(RowHeaderIconList.Images[1], rect);
        var c = new CModule();
        c.RowPostPaint_HeaderCount(sender, e);
    }
    private void MasterControl_Scroll(object sender, ScrollEventArgs e)
    {
        if (rowCurrent == null || rowCurrent.Count == 0) return;
        _collapseRow = true;
        ClearSelection();
        Rows[rowCurrent[0]].Selected = true;
    }
    private void MasterControl_SelectionChanged(object sender, EventArgs e)
    {
        if (RowCount == 0) return;
        if (CurrentRow == null || !rowCurrent.Contains(CurrentRow.Index)) return;
        foreach (var cGrid in childView.childGrid)
            ((DataView)cGrid.DataSource).RowFilter = string.Format(_filterFormat, _foreignKey, CurrentRow.Index);
    }

        #endregion
    }
}
