using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.Generic
{
    public class CModule
    {
        private DataGridViewCellStyle dateCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight };
        private DataGridViewCellStyle amountCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "N2" };
        private DataGridViewCellStyle gridCellStyle = new DataGridViewCellStyle
        {
            Alignment = DataGridViewContentAlignment.MiddleLeft,
            BackColor = Color.FromArgb(Convert.ToInt32(Convert.ToByte(79)),
                Convert.ToInt32(Convert.ToByte(129)), Convert.ToInt32(Convert.ToByte(189))),
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
            ForeColor = SystemColors.ControlLightLight, SelectionBackColor = SystemColors.Highlight,
            SelectionForeColor = SystemColors.HighlightText, WrapMode = DataGridViewTriState.True
        };

        private DataGridViewCellStyle gridCellStyle2 = new DataGridViewCellStyle
        {
            Alignment = DataGridViewContentAlignment.MiddleLeft,
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        };
        private DataGridViewCellStyle gridCellStyle3 = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleLeft, BackColor = Color.Lavender, Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)};
        public void ApplyGridTheme(DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.BackgroundColor = SystemColors.Window;
            grid.BorderStyle = BorderStyle.None;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid.ColumnHeadersDefaultCellStyle = gridCellStyle;
            grid.ColumnHeadersHeight = 32;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.DefaultCellStyle = gridCellStyle2;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = SystemColors.GradientInactiveCaption;
            grid.ReadOnly = true;
            grid.RowHeadersVisible = true;
            grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid.RowHeadersDefaultCellStyle = gridCellStyle3;
            grid.Font = gridCellStyle.Font;
        }
        public void SetGridRowHeader(DataGridView dgv, bool hSize = false)
        {
            dgv.TopLeftHeaderCell.Value = "NO ";
            dgv.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
            foreach (DataGridViewColumn cCol in dgv.Columns)
            {
                if (cCol.ValueType.ToString() == typeof(DateTime).ToString())
                    cCol.DefaultCellStyle = dateCellStyle;
                else if (cCol.ValueType.ToString() == typeof(decimal).ToString() | cCol.ValueType.ToString() == typeof(double).ToString())
                    cCol.DefaultCellStyle = amountCellStyle;
            }
            if (hSize)
                dgv.RowHeadersWidth = dgv.RowHeadersWidth + 16;
            dgv.AutoResizeColumns();
        }
        public void RowPostPaint_HeaderCount(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // set rowheader count
            var grid = (DataGridView)sender;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Center;
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height - grid.Rows[e.RowIndex].DividerHeight);
            e.Graphics.DrawString(rowIdx, grid.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

    }
}
