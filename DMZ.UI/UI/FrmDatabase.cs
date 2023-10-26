using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Configuration = System.Configuration.Configuration;
using Size = System.Drawing.Size;

namespace DMZ.UI.UI
{
    public partial class FrmDatabase : FrmClasse2
    {
        private Server _myServer;
        private Configuration _config;
        private string _connectionString;
        private ServerConnection _cnn;

        public FrmDatabase()
        {
            InitializeComponent();
            
        }
        private void FrmDatabase_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _connectionString = _config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString;
            var builder = new SqlConnectionStringBuilder(_connectionString);
            tbDBname.Text = builder.InitialCatalog;
            tbBD2.Text = builder.InitialCatalog;
            tbFileName.Text = builder.InitialCatalog + @"_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss.bak");
            ServerInitiation();
            tbEndereco.Text = _myServer.BackupDirectory + (_myServer.BackupDirectory.EndsWith("") ? @"\" : string.Empty);
            textBox1.Text = tbEndereco.Text;
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageBack);
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageRestore);
        }

        private void btnProcessBackup_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show("Deseja executar o Backup da Base de Dados?",DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            BackupDb(tbDBname.Text.Trim());
            //MsBox.Show("Backup executado com sucesso para a pasta <BACKUP>.");
        }
        private void BackupDb(string dataBaseName)
        {
            var  source = new Backup();
            //ServerInitiation();
            var backupFileName = tbEndereco.Text + tbFileName.Text;
            // Depends on SQL Server Edition
            source.Action = BackupActionType.Database;
            source.CopyOnly = true;
            source.Checksum = true;
            source.Incremental = false;
            source.BackupSetDescription = "DMZ BACKUP " + dataBaseName;
            source.BackupSetName = "COPY ONLY(FULL) DMZ BACKUP " + dataBaseName;
            source.ContinueAfterError = false;
            source.SkipTapeHeader = true;
            source.UnloadTapeAfter = false;
            source.NoRewind = true;
            source.FormatMedia = true;
            source.Initialize = true;
            // setup percent complete notification
            source.PercentCompleteNotification = 1;
            source.PercentComplete += Source_PercentComplete;
            // setup backup destination
            source.Database = dataBaseName;
            var destination = new BackupDeviceItem(backupFileName,DeviceType.File);
            source.Devices.Add(destination);
            //backup starts here
            //---------------------------------------------------------------------
            source.SqlBackup(_myServer);
            // label5.Text = $@"A base de dados {dataBaseName} foi copiada com sucesso";
            _cnn.Disconnect();
        }
        private void ServerInitiation()
        {
            var builder = new SqlConnectionStringBuilder(_connectionString);
            var tmpConn = new SqlConnection
            {
                ConnectionString = $"SERVER = {builder.DataSource.Trim()}; DATABASE = master; User ID = {builder.UserID.Trim()}; Password ={builder.Password.Trim()} "
            };
            _cnn = new ServerConnection(tmpConn.ConnectionString);
            _cnn.Connect();
            _myServer = new Server(_cnn);
        }

        private void btnSelBackup_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog
            {
                Filter = @"Text files (*.bak)|*.bak|All files (*.*)|*.*",
                CheckFileExists = true,
                CheckPathExists = true
            };
            //var path = Application.StartupPath+"\\Backup";
            var path = tbEndereco.Text;
            if(Directory.Exists(path))
            {
                openFileDialog1.InitialDirectory = path;
            }
            var dr =openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)  
            {  
                textBox1.Text = openFileDialog1.FileName;  
            }
        }
        private void CompletionStatusInPercent(object sender, PercentCompleteEventArgs args)
        {
            Thread.Sleep(100);
            progressBar2.Value = args.Percent;
            labelMessagem2.Text = $@"Base de Dados {progressBar1.Value}% restaurada!..";
            progressBar2.Update();
        }
        private void restore_Complete2(object sender, ServerMessageEventArgs e)
        {
            labelMessagem2.Text = @"Base de dados restaurada com sucesso!..";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show($"Deseja restaurar a base de dados {tbBD2.Text.Trim().ToUpper()}?");
            if (dr.DialogResult != DialogResult.Yes) return;
            var filePath = textBox1.Text.Trim();
            try
            {
                var databaseName = tbBD2.Text.Trim();
                var res = new Restore();
                res.Devices.AddDevice(filePath, DeviceType.File);
                var dataFile = new RelocateFile
                {
                    LogicalFileName = res.ReadFileList(_myServer).Rows[0][0].ToString(),
                    PhysicalFileName = _myServer.Databases[databaseName].FileGroups[0].Files[0].FileName
                };
                var logFile = new RelocateFile
                {
                    LogicalFileName = res.ReadFileList(_myServer).Rows[1][0].ToString(),
                    PhysicalFileName = _myServer.Databases[databaseName].LogFiles[0].FileName
                };
                res.RelocateFiles.Clear();
                res.RelocateFiles.Add(dataFile);
                res.RelocateFiles.Add(logFile);
                res.Database = databaseName;
                res.ReplaceDatabase = true;
                res.NoRecovery = false;
                _myServer.KillAllProcesses(databaseName);
                res.PercentCompleteNotification = 1;
                res.PercentComplete += CompletionStatusInPercent;
                res.Complete += restore_Complete2;
                res.SqlRestore(_myServer);
                _cnn.Disconnect();
            }
            catch (SmoException ex)
            {
                throw new SmoException(ex.Message, ex.InnerException);
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message, ex.InnerException);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Source_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            lblMenssagem.Text = $@"{e.Percent}% cópia concluida!..";
            progressBar1.Value = e.Percent;
            progressBar1.Update();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe",tbEndereco.Text.Trim());
        }
    }
}
