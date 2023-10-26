using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public enum TextPosition
    {
        Left,
        Right,
        Center,
        Sliding,
        None
    }
    class DMZProgressBar: ProgressBar
    {
        //Fields 
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;
        //Others
        private bool paintedBack =false;
        private bool stopPainting =false;

        //Construtor 
        public DMZProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint,true);
            this.ForeColor=Color.White;
        }
        [Category("DMZ Software")]
        public Color ChannelColor { 
            get => channelColor; 
            set {
                channelColor = value; 
                this.Invalidate(); 
                }}
        public Color SliderColor { 
            get => sliderColor; 
                        set {
                sliderColor = value; 
                this.Invalidate(); 
                }}
        [Category("DMZ Software")]
        public Color ForeBackColor { 
            get => foreBackColor; 
                        set {
                foreBackColor = value; 
                this.Invalidate(); 
                }}
        [Category("DMZ Software")]
        public int ChannelHeight { 
            get => channelHeight; 
                set {
                channelHeight = value; 
                this.Invalidate(); 
                }}
        [Category("DMZ Software")]
        public int SliderHeight { get => sliderHeight; 
                            set {
                sliderHeight = value; 
                this.Invalidate(); 
                }}
        [Category("DMZ Software")]
        public TextPosition ShowValue { get => showValue; 
                set {
                showValue = value; 
                this.Invalidate(); 
                }}
        [Category("DMZ Software")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font { get => base.Font; set => base.Font = value; }
        [Category("DMZ Software")]
        public override Color ForeColor { get => base.ForeColor ; set => base.ForeColor = value; }
        //Paint Background 
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (stopPainting ==false)
            {
                if (paintedBack == false)
                {
                    //Fields 
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0,0,this.Width,ChannelHeight);
                    using (var brushChannel = new SolidBrush(channelColor))
                    {
                        if (channelHeight>=sliderHeight)
                        {
                            rectChannel.Y=this.Height-channelHeight;
                        }
                        else
                        {
                            rectChannel.Y=Height-((channelHeight+sliderHeight)/2);
                        }
                        //Painting
                        graph.Clear(this.Parent.BackColor);
                        graph.FillRectangle(brushChannel,rectChannel);
                        //Stop Paiting..
                        if (this.DesignMode==false)
                        {
                            paintedBack = true;
                        }
                    }
                }
                //Reset Paiting ...
                if (this.Value==this.Maximum||this.Value==Minimum)
                {
                    paintedBack=false;
                }
            }
        }
                    //Paint slider  
        protected void OnPaint(PaintEventArgs e)
        {
            if (stopPainting==false)
            {
                Graphics graph = e.Graphics;
                double scalaFactor =(((double)this.Value-this.Minimum)/((double)this.Maximum-this.Minimum));
                int sliderWidth =(int)(this.Width*scalaFactor);
                Rectangle rectSlider = new Rectangle(0,0,sliderWidth,sliderHeight);
                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    if (sliderHeight>=channelHeight)
                    {
                        rectSlider.Y=this.Height-sliderHeight;
                    }
                    else
                    {
                        rectSlider.Y=this.Height-((sliderHeight+channelHeight)/2);
                    }
                    //Painting 
                    if (sliderWidth>1)
                    {
                        graph.FillRectangle(brushSlider,rectSlider);
                    }
                    if (showValue != TextPosition.None)
                    {
                        DrawTextValue(graph, sliderWidth, rectSlider);
                    }
                }
            }
            if (Value==Maximum)
            {
                stopPainting=true;
            }
            else
            {
                stopPainting=false;
            }
        }

        private void DrawTextValue(Graphics graph, int sliderWidth, Rectangle rectSlider)
        {
            //Fields 
            string text = this.Value.ToString()+"%";
            var textSize =TextRenderer.MeasureText(text,this.Font);
            var retText= new Rectangle(0,0,textSize.Width,textSize.Height+2);
            using (var brushText= new SolidBrush(this.ForeColor))
            using (var brushTextBack= new SolidBrush(this.foreBackColor))
            using (var textFormat= new StringFormat())
            {
                switch (showValue)
                {
                    case TextPosition.Left:
                        retText.X=0;
                        textFormat.Alignment = StringAlignment.Near;
                        break;
                    case TextPosition.Center:
                        retText.X=(Width-textSize.Width)/2;
                        textFormat.Alignment = StringAlignment.Center;
                        break;
                    case TextPosition.Right:
                        retText.X=Width-textSize.Width;
                        textFormat.Alignment = StringAlignment.Far;
                        break;
                    case TextPosition.Sliding:
                        retText.X=sliderWidth-textSize.Width;
                        textFormat.Alignment = StringAlignment.Center;
                        //Clean Preveous Text 
                        using (var brushClear = new SolidBrush(Parent.BackColor))
                        {
                            var ret = rectSlider;
                            ret.Y=retText.Y;
                            ret.Height=retText.Height;
                            graph.FillRectangle(brushClear,ret);
                        }
                        break;
                }
                //Painting
                graph.FillRectangle(brushTextBack,retText);
                graph.DrawString(text,Font,brushText,retText,textFormat);

            }
        }
    }
}
