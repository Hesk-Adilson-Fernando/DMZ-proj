using DMZ.UI.Basic;
using DMZ.UI.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System.Collections.Generic;
using System.Management;

namespace DMZ.UI.UC
{
    public partial class ImgGroup : UserControl
    {
        public ImgGroup()
        {
            InitializeComponent();
        }
        private Form MyParent { get; set; }
        public bool SetWhitePicture { get; set; }
        public string Value { get; set; }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            var opf = new OpenFileDialog
            {
                Filter = @"Choose Image(*.jpg;*.png;*.gif;*.jpeg;*.tiff;*.bmp)|*.jpg;*.png;*.gif;*.jpeg;*.tiff;*.bmp"
            };
            // chose the images type
            if (opf.ShowDialog() != DialogResult.OK) return;
            // get the image returned by OpenFileDialog 
            pictureBox1.Image = Image.FromFile(opf.FileName);
            var ex = opf.GetFileExtention();
            if (ex=="tiff")
            {
                TiffImage = true;
            }
        }

        public bool TiffImage { get; set; }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MyParent = ParentForm;
            var editeMode = MyParent != null && ((FrmClasse)MyParent).EditMode;
            if (!editeMode) return;
            var dr = MsBox.Show("Deseja eliminar a imagem", DResult.YesNo);
            if (dr.DialogResult == DialogResult.Yes)
            {
                pictureBox1.Image = null;
            }
        }

        private void ImgGroup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m= new ImageBoxTiffViewer();
            m.OpenImage(pictureBox1.Image);
            m.ShowForm(ParentForm);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            //GetAllConnectedCameras();
            FrmShowCamera f = new FrmShowCamera();
            f.ShowForm(ParentForm);
            f.SendImagem=ReceiveFoto;
            
        }
        void ReceiveFoto(Image imagem)
        {
            pictureBox1.Image=imagem;
        }
        PictureBox _pb = new PictureBox();
        public static List<string> GetAllConnectedCameras()
        {
            var cameraNames = new List<string>();
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE (PNPClass = 'Image' OR PNPClass = 'Camera')"))
            {
                foreach (var device in searcher.Get())
                {
                    MsBox.Show(device["Caption"].ToString());
                    cameraNames.Add(device["Caption"].ToString());
                }
            }

            return cameraNames;
        }
    }
}
