using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;



namespace DMZ.UI.Generic
{
  internal sealed partial class AboutDialog : Form
  {
    #region Constructors

    public AboutDialog()
    {
      InitializeComponent();
    }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      //FileVersionInfo versionInfo;

      //versionInfo = FileVersionInfo.GetVersionInfo(typeof(MainForm).Assembly.Location);
      //nameLabel.Text = versionInfo.ProductName;
      //copyrightLabel.Text = versionInfo.LegalCopyright;

      //base.OnLoad(e);
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void webLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try
      {
        Process.Start("http://www.dmzsoftware.co.mz");
      }
      catch (Win32Exception ex)
      {
        MessageBox.Show(ex.GetBaseException().Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

        #endregion

        private void AboutDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
