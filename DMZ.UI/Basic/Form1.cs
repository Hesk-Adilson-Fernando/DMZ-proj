using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.Basic
{
    public partial class Form1 : Form
    {
        private readonly Timer t =new Timer();
        //pb = ProgressBar
        private double _pbUnit;
        private int _pbWidth, _pbHeight, _pbComplete;
        private Bitmap _bmp;
        private Graphics _g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get picboxPB dimension
            _pbWidth = picboxPB.Width;
            _pbHeight = picboxPB.Height;

            _pbUnit = _pbWidth / 100.0;

            //pbComplete - This is equal to work completed in % [min = 0 max = 100]
            _pbComplete = 0;

            //create bitmap
            _bmp = new Bitmap(_pbWidth, _pbHeight);

            //timer
            t.Interval = 50;    //in millisecond
            t.Tick += T_Tick;
            t.Start();
        }

        public void T_Tick(object sender, EventArgs e)
        {
            //graphics
            _g = Graphics.FromImage(_bmp);

            //clear graphics
            _g.Clear(Color.LightSkyBlue);

            //draw progressbar
            _g.FillRectangle(Brushes.DarkGoldenrod, new Rectangle(0, 0, (int)(_pbComplete * _pbUnit), _pbHeight));

            //draw % complete
            _g.DrawString(_pbComplete + "%", new Font("Arial", _pbHeight / 2), Brushes.White,
                new PointF(_pbWidth / 2 - _pbHeight, _pbHeight / 10));

            //load bitmap in picturebox picboxPB
            picboxPB.Image = _bmp;

            //update pbComplete
            //Note!
            //To keep things simple I am adding +1 to pbComplete every 50ms
            //You can change this as per your requirement :)
            _pbComplete++;
            if (_pbComplete <= 100) return;
            //dispose
            _g.Dispose();
            t.Stop();

        }
    }
}
