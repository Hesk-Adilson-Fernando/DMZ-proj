using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.Generic
{
    public class SizeablePanel : Panel {
        //private const int CGripSize = 20;
        //private bool _mDragging;
        //private Point _mDragPos;

        //public SizeablePanel() {
        //    DoubleBuffered = true;
        //    SetStyle(ControlStyles.ResizeRedraw, true);
        //    BackColor = Color.White;
        //}

        //protected override void OnPaint(PaintEventArgs e) {
        //    ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor,
        //        new Rectangle(this.ClientSize.Width - CGripSize, this.ClientSize.Height - CGripSize, CGripSize, CGripSize));
        //    base.OnPaint(e);
        //}

        //private bool IsOnGrip(Point pos) {
        //    return pos.X >= this.ClientSize.Width - CGripSize &&
        //           pos.Y >= this.ClientSize.Height - CGripSize;
        //}

        //protected override void OnMouseDown(MouseEventArgs e) {
        //    _mDragging = IsOnGrip(e.Location);
        //    _mDragPos = e.Location;
        //    base.OnMouseDown(e);
        //}

        //protected override void OnMouseUp(MouseEventArgs e) {
        //    _mDragging = false;
        //    base.OnMouseUp(e);
        //}

        //protected override void OnMouseMove(MouseEventArgs e) {
        //    if (_mDragging) {
        //        Size = new Size(Width + e.X - _mDragPos.X,
        //            this.Height + e.Y - _mDragPos.Y);
        //        _mDragPos = e.Location;
        //    }
        //    else if (IsOnGrip(e.Location)) this.Cursor = Cursors.SizeNWSE;
        //    else Cursor = Cursors.Default;
        //    base.OnMouseMove(e);
        //}
    }
}
