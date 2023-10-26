using System;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Properties;

namespace DMZ.UI.Basic
{
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
        }

        public enum EnmAction
        {
            Wait,
            Start,
            Close
        }

        public enum EnmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private EnmAction _action;

        private int _x, _y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(_action)
            {
                case EnmAction.Wait:
                    timer1.Interval = 5000;
                    _action = EnmAction.Close;
                    break;
                case EnmAction.Start:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (_x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            _action = EnmAction.Wait;
                        }
                    }
                    break;
                case EnmAction.Close:
                    timer1.Interval = 1;
                    Opacity -= 0.1;

                    Left -= 3;
                    if (Opacity == 0.0)
                    {
                        Close();
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            _action = EnmAction.Close;
        }

        private void Form_Alert_Load(object sender, EventArgs e)
        {

        }

        public void ShowAlert(string msg, EnmType type)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (var i = 1; i < 10; i++)
            {
                fname = "alert" + i;
                var frm = (Form_Alert)Application.OpenForms[fname];

                if (frm != null) continue;
                Name = fname;
                _x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                _y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                Location = new Point(_x, _y);
                break;
            }
            _x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;

            switch(type)
            {
                case EnmType.Success:
                    pictureBox1.Image = Resources.success;
                    BackColor = Color.SeaGreen;
                    break;
                case EnmType.Error:
                    pictureBox1.Image = Resources.error;
                    BackColor = Color.DarkRed;
                    break;
                case EnmType.Info:
                    pictureBox1.Image = Resources.info;
                    BackColor = Color.RoyalBlue;
                    break;
                case EnmType.Warning:
                    pictureBox1.Image = Resources.warning;
                    BackColor = Color.DarkOrange;
                    break;
            }


            lblMsg.Text = msg;
            Show();
            _action = EnmAction.Start;
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}
