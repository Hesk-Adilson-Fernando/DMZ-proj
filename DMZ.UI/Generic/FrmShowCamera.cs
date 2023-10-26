using DMZ.UI.Classes;
using System;
using System.Drawing;

namespace DMZ.UI.Generic
{
    public partial class FrmShowCamera : Basic.FrmClasse2
    {
        private UsbCamera camera;
        private int cameraIndex;

        public FrmShowCamera()
        {
            InitializeComponent();
        }

        public Action<Image> SendImagem { get; internal set; }

        private void FrmShowCamera_Load(object sender, EventArgs e)
        {
            var devices = UsbCamera.FindDevices();
            if (devices.Length == 0) return;
            comboBox1.Items.AddRange(devices);
            comboBox1.SelectedIndex = 0;
            IniciarCamera();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendImagem.Invoke(camera.GetBitmap());
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarCamera();
        }

        private void IniciarCamera()
        {
            var formats = UsbCamera.GetVideoFormat(0);
            foreach (var item in formats) Console.WriteLine(item);
            var format = formats[0];
            camera = new UsbCamera(cameraIndex, format);
            FormClosing += (s, ev) => camera.Release();
            camera.SetPreviewControl(pictureBox2.Handle, pictureBox2.ClientSize);
            pictureBox2.Resize += (s, ev) => camera.SetPreviewSize(pictureBox2.ClientSize); // support resize.
            camera.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (camera !=null)
            {
                camera.Stop();
            }
            cameraIndex = comboBox1.SelectedIndex;
        }
    }
}
