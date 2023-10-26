using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DMZ.UI.Basic;

namespace DMZ.UI.Generic
{
    public partial class ImageBoxTiffViewer : FrmClasse2
    {
        public ImageBoxTiffViewer()
        {
            InitializeComponent();
        }
        #region Fields

        private int _currentPage;

        private Image _openImage;

        private int _pageCount;

        #endregion
        private void ImageBoxTiffViewer_Load(object sender, EventArgs e)
        {

        }

            #region Methods

    /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.FormClosing" /> event.</summary>
    /// <param name="e">A <see cref="T:System.Windows.Forms.FormClosingEventArgs" /> that contains the event data. </param>
    //protected override void OnFormClosing(FormClosingEventArgs e)
    //{
    //  base.OnFormClosing(e);
    //  if (!e.Cancel)
    //  {
    //    CloseImage();
    //  }
    //}

    /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Shown" /> event.</summary>
    /// <param name="e">A <see cref="T:System.EventArgs" /> that contains the event data. </param>
    protected override void OnShown(EventArgs e)
    {
      string[] arguments;

      base.OnShown(e);

      //arguments = Environment.GetCommandLineArgs();

      //this.OpenImage(arguments.Length > 1 ? arguments[1] : "NewtonsCradle.tif");
    }

    private void CloseImage()
    {
      if (_openImage != null)
      {
        imageBox.Image = null;
        _openImage.Dispose();
        _openImage = null;
      }
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        Clipboard.SetImage(imageBox.Image);
      }
      catch (ExternalException ex)
      {
        MsBox.Show($@"Failed to copy image to the Clipboard. {ex.GetBaseException().Message}");
      }
    }

    private void firstPageToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowPage(1);
    }

    private int GetPageCount(Image image)
    {
      FrameDimension dimension;

      dimension = FrameDimension.Page;

      return image.GetFrameCount(dimension);
    }

    private void lastPageToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowPage(_pageCount);
    }

    private void nextPageToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowPage(_currentPage + 1);
    }

    private void OpenImage(string fileName)
    {
      fileName = Path.Combine(Environment.CurrentDirectory, fileName);

      if (!File.Exists(fileName))
      {
        MsBox.Show($@"Cannot find file '{fileName}'");
      }
      else
      {
        try
        {
          OpenImage(Image.FromFile(fileName));
        }
        catch (OutOfMemoryException ex)
        {
          MsBox.Show($"Failed to open file '{fileName}'. {ex.GetBaseException().Message}");
        }
      }
    }

    public void OpenImage(Image image)
    {
     CloseImage();

      _openImage = image;
      _pageCount = GetPageCount(image);

      imageBox.Image = _openImage;

      ShowPage(1);

      imageBox.ZoomToFit();
    }

    private void OpenImage()
    {
      using (var dialog = new OpenFileDialog
                                     {
                                       Title = @"Abrir Imagem",
                                       DefaultExt = "tiff",
                                       Filter = @"All Pictures(*.emf; *.wmf; *.jpg; *.jpeg; *.jfif; *.jpe; *.png; *.bmp; *.dib; *.rle; *.gif; *.tif; *.tiff)| *.emf; *.wmf; *.jpg; *.jpeg; *.jfif; *.jpe; *.png; *.bmp; *.dib; *.rle; *.gif; *.tif; *.tiff | Windows Enhanced Metafile (*.emf) | *.emf | Windows Metafile(*.wmf) | *.wmf | JPEG File Interchange Format(*.jpg; *.jpeg; *.jfif; *.jpe)| *.jpg; *.jpeg; *.jfif; *.jpe | Portable Networks Graphic (*.png) | *.png | Windows Bitmap(*.bmp; *.dib; *.rle)| *.bmp; *.dib; *.rle | Graphics Interchange Format (*.gif) | *.gif | Tagged Image File Format(*.tif; *.tiff)| *.tif; *.tiff | All files(*.*) | *.*"
                                     })
      {
        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
          OpenImage(dialog.FileName);
        }
      }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenImage();
    }

    private void previousPageToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowPage(_currentPage - 1);
    }

    private void SaveImageFrame()
    {
      using (SaveFileDialog dialog = new SaveFileDialog
                                     {
                                       Filter = @"Portable Networks Graphic (*.png)|*.png|All Files (*.*)|*.*",
                                       DefaultExt = "png",
                                       Title = @"Guardar o Frame como"
                                     })
      {
        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
          SaveImageFrame(dialog.FileName);
        }
      }
    }

    private void SaveImageFrame(string fileName)
    {
      try
      {
        _openImage.Save(fileName, ImageFormat.Png);
      }
      catch (ExternalException ex)
      {
        MessageBox.Show($@"Failed to save file '{fileName}'. {ex.GetBaseException().Message}", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ShowPage(int page)
    {
      _currentPage = page;

      // update the current frame of the image
      _openImage.SelectActiveFrame(FrameDimension.Page, page - 1);

      // The ImageBox control doesn't know the image 
      // has changed, so force a repaint
      imageBox.Invalidate();

      UpdateUi();
    }

    private void UpdateUi()
    {
      bool canMovePrevious;
      bool canMoveNext;

      pageToolStripStatusLabel.Text = $"{_currentPage} of {_pageCount}";

      canMovePrevious = _currentPage > 1;
      canMoveNext = _currentPage < _pageCount;

      firstPageToolStripButton.Enabled = canMovePrevious;
      //firstPageToolStripMenuItem.Enabled = canMovePrevious;

      previousPageToolStripButton.Enabled = canMovePrevious;
      //previousPageToolStripMenuItem.Enabled = canMovePrevious;

      nextPageToolStripButton.Enabled = canMoveNext;
      //nextPageToolStripMenuItem.Enabled = canMoveNext;

      lastPageToolStripButton.Enabled = canMoveNext;
      //lastPageToolStripMenuItem.Enabled = canMoveNext;
    }

        #endregion

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }

        public bool Maximizado { get; set; }
        public void Maximizar()
        {
            NSize = Size;
            NLocation = Location;
            var height = MdiParent.Size.Height;
            var width = MdiParent.Size.Width;
            int widthMenupanel = 0;
            if (MdiParent is DemoMdi)
            {
                widthMenupanel = ((DemoMdi) MdiParent).PanelSideMenu.Size.Width; 
            }
            if (widthMenupanel==40)
            {
                Size = new Size(width-50, height - 165);
                Location = new Point(MdiParent.Location.X+45, Location.Y); 
            }
            else
            {
                Size = new Size(width-175, height - 165);
                Location = new Point(MdiParent.Location.X+175, Location.Y);    
            }
            Maximizado = true;
        }

        public Point NLocation { get; set; }
        public Size NSize { get; set; }
        public void MoveUP()
        {
            NSize = Size;
            NLocation = Location;
            var height = MdiParent.Size.Height;
            var width = MdiParent.Size.Width;
            Size = new Size(width - 70, height - 165);
            var x = MdiParent.Location.X;
            var y = MdiParent.Location.Y;
            Location = new Point(48, y + 110);
        }
        public void MoveDow()
        {
            Size = NSize;
            Location = NLocation;
        }
        public void Minimizar()
        {
            Size = NSize;
            Location = NLocation;
            Maximizado = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveImageFrame();
        }
        private void btnCrop_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
            Controls.Add(pictureBox1);
        }
        int crpX, crpY, rectW, rectH;

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Dimensions :" + rectW + "," + rectH;
            Cursor = Cursors.Default;
            Bitmap bmp2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp2, pictureBox1.ClientRectangle);
            Bitmap crpImg = new Bitmap(rectW, rectH);
            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }
            imageBox.Image = crpImg;
            imageBox.SizeMode = (Cyotek.Windows.Forms.ImageBoxSizeMode)PictureBoxSizeMode.CenterImage;
        }

        // Declare crop pen for cropping image
        public Pen crpPen = new Pen(Color.White);
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                crpX = e.X;
                crpY = e.Y;
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Refresh();
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }
    }
}
