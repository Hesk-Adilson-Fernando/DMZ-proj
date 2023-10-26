using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.Generic
{
    public delegate void CheckBoxClickedHandler(bool state);
    public class DataGridViewCheckBoxHeaderCellEventArgs : EventArgs
    {
        bool _bChecked;
        public DataGridViewCheckBoxHeaderCellEventArgs(bool bChecked)
        {
            _bChecked = bChecked;
        }
        public bool Checked
        {
            get { return _bChecked; }
        }
    }
    class DatagridViewCheckBoxHeaderCell : DataGridViewColumnHeaderCell
    {
        Point _checkBoxLocation;
        Size _checkBoxSize;
        bool _checked;
        Point _cellLocation;
        System.Windows.Forms.VisualStyles.CheckBoxState _cbState = 
            System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;
        public event CheckBoxClickedHandler OnCheckBoxClicked;

        protected override void Paint(Graphics graphics, 
            Rectangle clipBounds, 
            Rectangle cellBounds, 
            int rowIndex, 
            DataGridViewElementStates dataGridViewElementState, 
            object value, 
            object formattedValue, 
            string errorText, 
            DataGridViewCellStyle cellStyle, 
            DataGridViewAdvancedBorderStyle advancedBorderStyle, 
            DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, 
                dataGridViewElementState, value, 
                formattedValue, errorText, cellStyle, 
                advancedBorderStyle, paintParts);
            var p = new Point();
            var s = CheckBoxRenderer.GetGlyphSize(graphics, 
            System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            p.X = cellBounds.Location.X + 
                cellBounds.Width / 2 - s.Width / 2 ;
            p.Y = cellBounds.Location.Y + 
                cellBounds.Height / 2 - s.Height / 2;
            _cellLocation = cellBounds.Location;
            _checkBoxLocation = p;
            _checkBoxSize = s;
            if (_checked)
                _cbState = System.Windows.Forms.VisualStyles.
                    CheckBoxState.CheckedNormal;
            else
                _cbState = System.Windows.Forms.VisualStyles.
                    CheckBoxState.UncheckedNormal;
            CheckBoxRenderer.DrawCheckBox
            (graphics, _checkBoxLocation, _cbState);
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            var p = new Point(e.X + _cellLocation.X, e.Y + _cellLocation.Y);
            if (p.X >= _checkBoxLocation.X && p.X <= 
                _checkBoxLocation.X + _checkBoxSize.Width 
            && p.Y >= _checkBoxLocation.Y && p.Y <= 
                _checkBoxLocation.Y + _checkBoxSize.Height)
            {
                _checked = !_checked;
                if (OnCheckBoxClicked != null)
                {
                    OnCheckBoxClicked(_checked);
                    DataGridView.InvalidateCell(this);
                }
                
            } 
            base.OnMouseClick(e);
        }     
    }
}
