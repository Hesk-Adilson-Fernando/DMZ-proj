using System;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class BaseUI : Form
    {
        public BaseUI()
        {
            InitializeComponent();
        }

        #region Grupo Arastar 

        private const int tolerance = 15;
        private const int WM_NCHITTEST = 123;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle SizeGripRectangle;
        //protected override void WndProc(ref Message msj)
        //{
        //    const int CoordenadaWFP = 0X84;
        //    const int DesIsquierda = 16;
        //    const int DesDerecha = 17;
        //    if (msj.Msg==CoordenadaWFP)
        //    {
        //        int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
        //        int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000)>>16);
        //        Point CoordenaArea = PointToClient(new Point(x,y));
        //        Size TamanhoForm = ClientSize;
        //        if (CoordenaArea.X >=TamanhoForm.Width-16 && CoordenaArea.Y >=TamanhoForm.Height)
        //        {
        //            msj.Result = (IntPtr)(IsMirrored?DesIsquierda:DesDerecha);
        //            return;
        //        }
        //    }
        //    base.WndProc(ref msj);
        //}
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = PointToClient(new Point(m.LParam.ToInt32() & 0xFFFF, m.LParam.ToInt32()>>16));
                    if (SizeGripRectangle.Contains(hitPoint))
                    {
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    }
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0,0,ClientRectangle.Width,ClientRectangle.Height));
            SizeGripRectangle = new Rectangle(ClientRectangle.Width-tolerance,ClientRectangle.Height-tolerance,tolerance,tolerance);
            region.Exclude(SizeGripRectangle);
            BasePanel.Region = region;
            Invalidate();
        }
        protected override void OnPaint( PaintEventArgs e)
        {
            var blueBrush = new SolidBrush(Color.FromArgb(55,61,69));
            e.Graphics.FillRectangle(blueBrush,SizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics,Color.Transparent,SizeGripRectangle);

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }
        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void MenuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }
        private void panelConteiner_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        #endregion

        #region Grupo Butoes Maximizar...
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int _h;
        private int _w;
        private int _lx;
        private int _ly;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            Maximizar();
        }

        private void Maximizar()
        {
            _h = Height;
            _w = Width;
            _lx = Location.X;
            _ly = Location.Y;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnReautar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReautar_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Normal;
            Size = new Size(_w,_h);
            Location = new Point(_lx,_ly);
            btnMaximizar.Visible = true;
            btnReautar.Visible = false;
        }
        #endregion

        private void btnSlide_Click(object sender, EventArgs e)
        {
            MenuVertical.Width = MenuVertical.Width==250 ? 52 : 250;
        }

        private void ShowInPanel(Form frm)
        {
            if (panelConteiner.Controls.Count>0)
            {
                panelConteiner.Controls.RemoveAt(0);
            }
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelConteiner.Controls.Add(frm);
            panelConteiner.Tag = frm;
            frm.Show();
        }

        private void panelConteiner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BaseUI_Load(object sender, EventArgs e)
        {
            Maximizar();
            // lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnProduto_Click_1(object sender, EventArgs e)
        {

        }
    }
}
