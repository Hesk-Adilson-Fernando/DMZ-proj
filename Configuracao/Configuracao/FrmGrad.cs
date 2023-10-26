using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.Configuracao
{
    public class FrmGrad : Form
    {
        // Fields
        private Color _Color1 = Color.Gainsboro;
        private Color _Color2 = Color.White;
        private float _ColorAngle = 30f;
        private Container components = null;

        // Methods
        public FrmGrad()
        {
            InitializeComponent();
            SetStyles();
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(components, null)))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrad));
            this.SuspendLayout();
            // 
            // FrmGrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 342);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGrad";
            this.Text = "FrmGrad";
            this.ResumeLayout(false);

        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, _Color1, _Color2, _ColorAngle);
            pevent.Graphics.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void SetStyles()
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        // Properties
        public Color Color1
        {
            get =>
                _Color1;
            set
            {
                _Color1 = value;
                Invalidate();
            }
        }

        public Color Color2
        {
            get =>
                _Color2;
            set
            {
                _Color2 = value;
                Invalidate();
            }
        }

        public float ColorAngle
        {
            get =>
                _ColorAngle;
            set
            {
                _ColorAngle = value;
                Invalidate();
            }
        }
    }



}
