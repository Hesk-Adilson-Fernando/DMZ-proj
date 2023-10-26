using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using com.itextpdf.text.pdf;
using DMZ.BL.Classes;
using DMZ.DAL.Context;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Agent;
using Microsoft.SqlServer.Management.Smo.Wmi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//using Microsoft.SqlServer.Management.Smo.Wmi;

namespace DMZ.UI.UI
{
    public partial class Dmzbd : Form
    {
        private Server _myServer;
        private static string FolderPath => string.Concat(Directory.GetCurrentDirectory(),
            "\\VPN");
        public Dmzbd()
        {
            InitializeComponent();
        }

        private void DMZBD_Load(object sender, EventArgs e)
        {
            lblSoftwareVersion.Text = Pbl.Info;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void DMZBD_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void lblSoftwareVersion_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageBack);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageRestore);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var str =MigrateData.ApplyDatabasePendingMigrations();
            var fileName = Application.StartupPath+"\\SQLScript.sql";
            try    
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (var sw = File.CreateText(fileName))
                {
                    sw.Write(str);
                }
                MsBox.Show(str);
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnProcessBackup_Click(object sender, EventArgs e)
        {
            // Configuration config = ConfigurationManager.OpenExeConfiguration("DMZ.UI.EXE");
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text))
            {
                if (ConnHelper.Save(comboBox1.Text.Trim(),comboBox2.Text.Trim(),tbPw.Text.Trim()))
                {
                    MsBox.Show("Actualizado com sucesso");
                }
            }
            else
            {
                MsBox.Show("Deve indicar a Instancia e Base de dados!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInstance_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.Items.Clear();
            }
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.Items.Clear();
            }
            DataTable table = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow server in table.Rows)
            {
                var servers = $"{server[table.Columns["ServerName"]]}\\{server[table.Columns["InstanceName"]]}";
                comboBox1.Items.Add(servers);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            //var dt = SmoApplication.EnumAvailableSqlServers();
            //foreach (DataRow r in dt.Rows)
            //{
            //    if (r != null)
            //        comboBox1.Items.Add(r["Name"].ToString());
            //}
        }

        internal static DataTable  GetReturnTable(SqlCommand cmd,string tabela)
        {
            var sqlDataAdapter = new SqlDataAdapter(cmd);
            var dtable = new DataTable {TableName = tabela};
            sqlDataAdapter.Fill(dtable);
            return dtable;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.Items.Clear();
            }
            _myServer = new Server(comboBox1.Text.Trim());
            foreach (Database db in _myServer.Databases)
            {
                if (!db.Name.ToLower().Trim().Equals("master")&& !db.Name.ToLower().Trim().Equals("model")
                                                              && !db.Name.ToLower().Trim().Equals("msdb") && 
                                                              !db.Name.ToLower().Trim().Equals("tempdb"))
                {
                    comboBox2.Items.Add(db.Name.Trim());
                }
            }
            if (comboBox2.Items.Count>0)
            {
                comboBox2.SelectedIndex = 0;
            }
        }

        void AutomaticJobProgramme()
        {
             var srv = new Server();  
  
            //Define an Operator object variable by supplying the Agent (parent JobServer object) and the name in the constructor.   
            var op = new Operator(srv.JobServer, "Test_Operator")
            {
                NetSendAddress = "Network1_PC"
            };

            //Set the Net send address.   


            //Create the operator on the instance of SQL Server Agent.   
            op.Create();  
  
            //Define a Job object variable by supplying the Agent and the name arguments in the constructor and setting properties.   
            var jb = new Job(srv.JobServer, "Test_Job");  
  
            //Specify which operator to inform and the completion action.   
            jb.OperatorToNetSend = "Test_Operator";  
            jb.NetSendLevel = CompletionAction.Always;  
  
            //Create the job on the instance of SQL Server Agent.   
            jb.Create();  
  
            //Define a JobStep object variable by supplying the parent job and name arguments in the constructor.   
            var jbstp = new JobStep(jb, "Test_Job_Step");  
            jbstp.Command = "Test_StoredProc";  
            jbstp.OnSuccessAction = StepCompletionAction.QuitWithSuccess;  
            jbstp.OnFailAction = StepCompletionAction.QuitWithFailure;  
  
            //Create the job step on the instance of SQL Agent.   
            jbstp.Create();  
  
            //Define a JobSchedule object variable by supplying the parent job and name arguments in the constructor.   
  
            var jbsch = new JobSchedule(jb, "Test_Job_Schedule");  
  
            //Set properties to define the schedule frequency, and duration.   
            jbsch.FrequencyTypes = FrequencyTypes.Daily;  
            jbsch.FrequencySubDayTypes = FrequencySubDayTypes.Minute;  
            jbsch.FrequencySubDayInterval = 30;  
            var ts1 = new TimeSpan(9, 0, 0);  
            jbsch.ActiveStartTimeOfDay = ts1;  
  
            var ts2 = new TimeSpan(17, 0, 0);  
            jbsch.ActiveEndTimeOfDay = ts2;  
            jbsch.FrequencyInterval = 1;  
  
            var d = new DateTime(2003, 1, 1);  
            jbsch.ActiveStartDate = d;  
  
            //Create the job schedule on the instance of SQL Agent.   
            jbsch.Create();  
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
                //Declare and create an instance of the ManagedComputer   
                //object that represents the WMI Provider services.   
                //Mc = new ManagedComputer();
                ////Iterate through each service registered with the WMI Provider.   
                //BindGrid();
        }

        private void BindGrid()
        {
            gridUi2.Rows.Clear();
            //foreach (Service svc in Mc.Services)
            //{
            //    if (svc.ServiceState == ServiceState.Running)
            //    {
            //        gridUi2.Rows.Add(svc.Name, svc.ServiceState,Properties.Resources.pause_25px);  
            //    }
            //    else
            //    {
            //        gridUi2.Rows.Add(svc.Name, svc.ServiceState,Properties.Resources.play_25px );
            //    }
                    
            //}
        }

       // public ManagedComputer Mc { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageSQLSERVICES);
        }


        private void gridUi2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (!gridUi2.CurrentCell.OwningColumn.Name.Equals("tamanho")) return;
            ////Reference the Microsoft SQL Server service.
            //if (gridUi2.CurrentRow == null) return;
            //var servicename = gridUi2.CurrentRow.Cells[0].Value.ToString().Trim();
            //var mysvc = Mc.Services[servicename];
            //if (mysvc.ServiceState == ServiceState.Running)
            //{
            //    var dr =MsBox.Show("Deseja parar o serviço? ",DResult.YesNo);
            //    if (dr.DialogResult != DialogResult.Yes) return;
            //    mysvc.Stop();
            //    mysvc.Refresh();
            //    BindGrid();
            //}
            //else
            //{
            //    var dr =MsBox.Show("Deseja iniciar o serviço? ",DResult.YesNo);
            //    if (dr.DialogResult != DialogResult.Yes) return;
            //    mysvc.Start();
            //    mysvc.Refresh();
            //    BindGrid();
            //}
        }

        private void btnVPNConfig_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageVPN);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FolderPath + "\\VpnDisconnect.bat", @"rasdial /d");

            var newProcess = new Process
            {
                StartInfo =
                {
                    FileName = FolderPath + "\\VpnDisconnect.bat",
                    WindowStyle = ProcessWindowStyle.Normal
                }
            };

            newProcess.Start();
            newProcess.WaitForExit();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);
            var sb = new StringBuilder();
            sb.AppendLine("[VPN]");
            sb.AppendLine("MEDIA=rastapi");
            sb.AppendLine("Port=VPN2-0");
            sb.AppendLine("Device=WAN Miniport (IKEv2)");
            sb.AppendLine("DEVICE=vpn");
            sb.AppendLine("PhoneNumber=" + txtHost.Text);

            File.WriteAllText(FolderPath + "\\VpnConnection.pbk", sb.ToString());

            sb = new StringBuilder();
            sb.AppendLine("rasdial \"VPN\" " + txtUsrname.Text + " " + txtPassword.Text + " /phonebook:\"" + FolderPath +
                          "\\VpnConnection.pbk\"");

            File.WriteAllText(FolderPath + "\\VpnConnection.bat", sb.ToString());

            var newProcess = new Process
            {
                StartInfo =
                {
                    FileName = FolderPath + "\\VpnConnection.bat",
                    WindowStyle = ProcessWindowStyle.Normal
                }
            };

            newProcess.Start();
            newProcess.WaitForExit();
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = @"CREATE TABLE [dbo].[Anolect](
	                        [Codigo] [decimal](9, 0) NOT NULL,
	                        [Ano] [decimal](9, 0) NOT NULL,
	                        [Descricao] [nvarchar](80) NOT NULL,
	                        [Anolectstamp] [nvarchar](80) NOT NULL,
                         CONSTRAINT [PK_dbo.Anolect] PRIMARY KEY CLUSTERED 
                        (
	                        [Anolectstamp] ASC
                        )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                        ) ON [PRIMARY]
                        ";
            SQL.SqlCmd(f);
            MsBox.Show("Processo executado com sucesso");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
