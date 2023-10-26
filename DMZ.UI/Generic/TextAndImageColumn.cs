using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.Generic
{
    public class TextAndImageColumn : DataGridViewTextBoxColumn
    {
        private Image _imageValue;

        public TextAndImageColumn()
        {
            CellTemplate = new TextAndImageCell();
        }

        public sealed override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set => base.CellTemplate = value;
        }

        public override object Clone()
        {
            var c = base.Clone() as TextAndImageColumn;
            c._imageValue = _imageValue;
            c.ImageSize = ImageSize;
            return c;
        }

        public Image Image
        {
            get => _imageValue;
            set
            {
                if (Image == value) return;
                _imageValue = value;
                ImageSize = value.Size;

                if (InheritedStyle == null) return;
                var inheritedPadding = InheritedStyle.Padding;
                DefaultCellStyle.Padding = new Padding(ImageSize.Width,
                    inheritedPadding.Top, inheritedPadding.Right,
                    inheritedPadding.Bottom);
            }
        }
       // private TextAndImageCell TextAndImageCellTemplate => this.CellTemplate as TextAndImageCell;

        internal Size ImageSize { get;  set; }
    }

    public class TextAndImageCell : DataGridViewTextBoxCell
    {
        private Image _imageValue;
        private Size _imageSize;
        public override object Clone()
        {
            var c = base.Clone() as TextAndImageCell;
            if (c != null)
            {
                c._imageValue = _imageValue;
                c._imageSize = _imageSize;
                
            }
            return c;
        }
        public Image Image
        {
            get
            {
                if (OwningColumn == null ||OwningTextAndImageColumn == null)
                {

                    return _imageValue;
                }

                if (_imageValue != null)
                {
                    return _imageValue;
                }

                return OwningTextAndImageColumn.Image;
            }
            set
            {
                if (_imageValue == value) return;
                _imageValue = value;
                _imageSize = value.Size;

                var inheritedPadding = InheritedStyle.Padding;
                Style.Padding = new Padding(_imageSize.Width,
                    inheritedPadding.Top, inheritedPadding.Right,
                    inheritedPadding.Bottom);
            }
        }
        protected override void Paint(Graphics graphics, Rectangle clipBounds,
        Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,
        object value, object formattedValue, string errorText,
        DataGridViewCellStyle cellStyle,
        DataGridViewAdvancedBorderStyle advancedBorderStyle,
        DataGridViewPaintParts paintParts)
        {
            // Paint the base content
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
               value, formattedValue, errorText, cellStyle,
               advancedBorderStyle, paintParts);

            if (Image == null) return;
            // Draw the image clipped to the cell.
            var container =graphics.BeginContainer();

            graphics.SetClip(cellBounds);
            graphics.DrawImageUnscaled(Image, cellBounds.Location);

            graphics.EndContainer(container);
        }
        private TextAndImageColumn OwningTextAndImageColumn => OwningColumn as TextAndImageColumn;
    }
}
