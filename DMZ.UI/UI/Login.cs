using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using DMZ.BL.Classes;
using DMZ.DAL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Configuration = System.Configuration.Configuration;

namespace DMZ.UI.UI
{
    public partial class Login : Form
    {

        private XmlDocument _xml;
        private XmlNode _node;
        private DataTable _dtUsrModulos;
        public bool Memp { get; set; }
        public Login()
        {
            InitializeComponent();
            //var t = new Thread(StartForm);
            //t.Start();
            //Thread.Sleep(5000);
            //InitializeComponent();
            //t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }
        private void GetSettings()
        {
            GetUser();
            GetLic();
        }

        void GetLic()
        {
            Memp =  Criptografia.Decrypt(_xml.SelectSingleNode("//Memp")?.InnerText).ToBool();
            CheckLic(false);  
        }
        private void GetUser()
        {
            var xmlPath = Application.StartupPath + "\\" + "TblDefa.xml";
            _xml = new XmlDocument();
            _xml.Load(xmlPath);
            _node = _xml.SelectSingleNode("//Login");
            if (_node != null)
            {
                tbUser.Text = Criptografia.Decrypt(_node.InnerText);
                tbUser.ForeColor = Color.White;
            }
            vpn=_xml.SelectSingleNode("//VPN");
            if (vpn !=null)
            {
                cbVPN.Update(vpn.InnerText.ToBool());
            }
        }

        private void SaveSettings()
        {
            if (_node == null) return;
            _node.InnerText = Criptografia.Encrypt(tbUser.Text.Trim());//tbUser.Text.Trim();
            //vpn.InnerText = cbVPN.cb1.Checked.ToString();
            var xmlPath = Application.StartupPath + "\\" + "TblDefa.xml";
            _xml.Save(xmlPath);
           // CheckLic(true);
        }
        private void CheckLic(bool status,string bdname="")
        {
            var xmlfilePath = Application.StartupPath + "\\" + $"Licence{bdname.Trim()}.xml";
            var xmlFile = new XmlDocument();
            if (!File.Exists(xmlfilePath))
            {
                xmlfilePath = Application.StartupPath + "\\" + "Licence.xml"; 
            }
            xmlFile.Load(xmlfilePath);

            if (!status)
            {
                var xmlFile2 = XmlReader.Create(xmlfilePath, new XmlReaderSettings());
                var dataSet = new DataSet();
                dataSet.ReadXml(xmlFile2);
                licdt = dataSet.Tables[0];
            }
            var encriptedNode = xmlFile.SelectSingleNode("//Encripted");
            var encriptedNodeValor = false;
            if (encriptedNode != null)
            {
                encriptedNodeValor = TryValue(encriptedNode.InnerText);
            }
            if (xmlFile.DocumentElement == null) return;
            var nodes = xmlFile.DocumentElement.ChildNodes;
            if (!status)
            {
                if (GetNoveValue("Ges").ToBool())
                {
                    if (GetNoveValue("Fullic").ToBool())
                    {
                        VerificaLic("Fulllicval", "Fulllicdata", "CERTIFICADA", 1);
                    }
                    if (GetNoveValue("Demo").ToBool())
                    {
                        VerificaLic("DemoVal", "Demodata", "DEMOSTRAÇÃO", 1);
                    }
                    if (GetNoveValue("tec").ToBool())
                    {
                        VerificaLic("Tecval", "Tecdata", "TÉCNICA", 1);
                    }
                }
                if (GetNoveValue("ct").ToBool())
                {
                    VerificaLic("Ctval", "CtData", "CONTABILIDADE", 2);
                }
                if (GetNoveValue("RHS").ToBool())
                {
                    VerificaLic("Rhval", "Rhdata", "RECURSOS HUMANOS", 3);
                }
                Pbl.URh =GetNoveValue("URh").ToDecimal();
                Pbl.UCt =GetNoveValue("UCt").ToDecimal();
                Pbl.UGes =GetNoveValue("UGes").ToDecimal();

            }
        }

        private string GetNoveValue(string Nodename)
        {
           return Criptografia.Decrypt(licdt?.Rows[0][Nodename.Trim()].ToString());
        }

        private void VerificaLic(string val, string data, string versao, decimal origem)
        {
            var dias =GetDias(val,data); 
            if (dias > 0)
            {
                if (dias < 10)
                {
                    MessagemWarning(dias.ToDecimal(),versao);
                }
            }
            else
            {
                MessagemExpirada(versao,origem);
            }
            if (origem==1)
            {
                Pbl.VersaoActivo=versao;
            }
        }

        private double GetDias(string val, string data)
        {
            var validade = GetValor(val).ToDateTimeValue();
            var dataValue = GetValor(data).ToDateTimeValue(); 
            return validade.TotalDays(dataValue);
        }

        private void MessagemExpirada(string versao,decimal origem)
        {
           
            //MsBox.Show("Estimado" + $"A VERSÃO {versao} EXPRIROU \r\nPorfavor contacte a DMZ SISTEMAS, Tel(s): 840515627/847028510 ou seu REVENDIDOR LOCAL, para renovação da LICENÇA");
            //Pbl.GesExpirado=false;
            //Pbl.CtExpirado=false;
            //Pbl.RhsExpirado=false;
            //switch (origem)
            //{
            //    case 1:
            //        Pbl.GesExpirado=true;
            //        break;
            //    case 2:
            //        Pbl.CtExpirado=true;
            //        break;
            //    case 3:
            //        Pbl.RhsExpirado=true;
            //        break;
            //}
            //Pbl.VersaoActivo=versao;
        }

        private void MessagemWarning(decimal dias,string versao)
        {
          
           // MsBox.Show("Estimado" + $"Restam apenas {dias} dia(s) de validade do DMZ Software versão: {versao} em uso. \r\nPorfavor contacte a DMZ SISTEMAS, Tel(s): 840515627/847028510 ou seu REVENDIDOR LOCAL, para renovação da LICENÇA");
            //Pbl.GesExpirado=false;
            Pbl.CtExpirado=false;
            Pbl.RhsExpirado=false;
           
        }

        private string GetValor(string name)
        {
           return Criptografia.Decrypt(licdt?.Rows[0][name.Trim()].ToString());
        }

        DataTable licdt;
        private bool TryValue(string encriptedNodeInnerText)
        {

            if (!bool.TryParse(encriptedNodeInnerText,out var xx))
            {
                xx = Convert.ToBoolean(Criptografia.Decrypt(encriptedNodeInnerText));
            }
            return xx;
        }
        private Usr _usr;
        private Server _myServer;
        private Configuration _config;
        private string _connectionString;
        private ServerConnection _cnn;
        private XmlNode vpn;

        private void tbUser_Enter(object sender, EventArgs e)
        {

        }
        private void tbUser_Leave(object sender, EventArgs e)
        {
            tbUser.Text = tbUser.Text.ToUpper();
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }
        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (tbUser.Text == "")
            {
                MsBox.Show(@"Por favor digita o nome do utilizador!");
                tbUser.Focus();
                Cursor = Cursors.Default;
                return;
            }
            var msprint = "";
            var us = SQL.GetRow($"Usrstamp","usr",$"login='{tbUser.Text.ToLower().Trim()}' and pw='{textBoxSenha.Text.Trim()}' ");
            if (us==null)
            {
                MsBox.Show("Não tem usuário com os dados definidos");
                return;
            }
            if (us.Table.TableName.Equals("Error"))
            {
                var mensagem = us["ColError"].ToString();
                if (mensagem.Contains("Invalid object name 'usr'."))
                {
                    msprint = $"Desculpe não exite usuário:  {tbUser.Text}, na base de dados: {tbEmpresa.Text}!.";
                }
                MsBox.Show(msprint);
                return;
            }
            //_usr = SQL.GetRowToEnt<Usr>($"usrstamp ='{us["Usrstamp"].ToString().Trim()}'");
            //if (_usr == null)
            //{
            //    MsBox.Show("Não tem usuário com os dados definidos");
            //    return;
            //}
             _usr = SQL.Authentication<Usr>(tbUser.Text.ToLower().Trim(), textBoxSenha.Text.Trim());
            if (_usr == null)
            {
                MsBox.Show("Não tem usuário com os dados definidos");
                return;
            }


            Pbl.Param = SQL.GetRowToEnt<Param>();
            if (_usr !=null)
            {
                if (!_usr.Ccustamp.IsNullOrEmpty())
                {
                    Pbl.CCu = SQL.GetRowToEnt<CCu>($"Ccustamp='{_usr.Ccustamp.Trim()}'");
                }
                var usrlog = SQL.DoAddline<UsrlogSect>();
                usrlog.EntradaDataHora = DateTime.Now;
                usrlog.Usrstamp = _usr.Usrstamp;
                usrlog.SaidaDataHora =null;
                usrlog.ObsfielUsrname = tbUser.Text.ToLower().Trim();
                usrlog.ObsUsrPw = textBoxSenha.Text.ToLower().Trim();
                if (usrlog.UsrlogSectstamp.IsNullOrEmpty())
                {
                    usrlog.UsrlogSectstamp = Pbl.Stamp();
                }
                usrlog.Obs = _usr.Nome;
                Pbl.UsrlogSect = usrlog;
                SQL.ExecUsrLogSession(Pbl.UsrlogSect);
               
            }
           
            var serverAno = SQL.ServerData().Year;
            if (Pbl.Param.Anoref != serverAno)
            {
                var dres = MsBox.Show($"Estimado(a): {_usr.Nome},\r\n" + $"O Ano Corrente no sistema é: {Pbl.Param.Anoref}: \r\nDiferente de: {serverAno}, deseja que o software actualize para te?", DResult.YesNo);
                if (dres.DialogResult == DialogResult.Yes)
                {
                    SQL.SqlCmd($"update param set anoref ={serverAno}");
                    Helper.Alert("Ano corrente actualizado com sucesso", Form_Alert.EnmType.Success);
                }
            }
            ChamadasAssincronas();
            var existe = SQL.CheckExist($"Descricao","UsrModulo",$"Usrstamp='{_usr.Usrstamp.Trim()}'");
            if (!existe)
            {
                MsBox.Show($"Não tem Modulo configurado para o ->: {_usr.Nome}");
                panelModulos.Visible = false;
            }
            else
            {
                switch (_usr.TipoAcesso)
                {
                    case 0:                      
                        CallBackOffice();
                        break;
                    case 1:
                        CallBackOffice();
                        break;
                    case 2:
                        CallPosSup();
                        GetGenerico();
                        break;
                    case 3:
                        panelModulos.Visible = true;
                        btnPos.Visible = true;
                        btnBackoffice.Visible = true;
                        break;
                    case 4:
                        panelModulos.Visible = true;
                        btnPosRest.Visible = true;
                        btnBackoffice.Visible = true;
                        break;
                    case 5:
                        CallPosRes();
                        GetGenerico();
                        break;
                }
            }
            Security.ProtectConnectionString();
            SaveSettings();
            Pbl.FillContasEmpresa();
        }
        private void ObjOnClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null) 
                CallForm();
        }
        private void CallForm()
        {
            CallDemoMdi();
            RefreshModulos();
        }

        private void CallDemoMdi()
        {
            Hide();
            var demoMdi= new DemoMdi();
            demoMdi.DtUsrModulos = _dtUsrModulos;
            demoMdi.Show();
        }

        private void ChamadasAssincronas()
        {
            Pbl.Empresa = SQL.GetRowToEnt<Empresa>(); //EF.GetEnt<Empresa>();
            Pbl.Usr = _usr;
            Pbl.MoedaBase = SQL.GetField("Moeda", "Moedas", "Princip=1").ToString();
        }

        private void RefreshModulos()
        {
            var dt=Helper.GetModulos();
            foreach (var row in dt.AsEnumerable())
            {
                if (row == null) continue;
                if (!Criptografia.Decrypt(row["Ges"].ToString()).ToBool())
                {
                    SQL.SqlCmd("delete from EmpresaMod where ltrim(rtrim(Sigla)) ='Ges'");
                }

                if (!Criptografia.Decrypt(row["POSR"].ToString()).ToBool())
                {
                    SQL.SqlCmd("delete from EmpresaMod where ltrim(rtrim(Sigla)) ='POSR'");
                }

                if (!Criptografia.Decrypt(row["CT"].ToString()).ToBool())
                {
                    SQL.SqlCmd("delete from EmpresaMod where ltrim(rtrim(Sigla)) ='CT'");
                }

                if (!Criptografia.Decrypt(row["AC"].ToString()).ToBool())
                {
                    SQL.SqlCmd("delete from EmpresaMod where ltrim(rtrim(Sigla)) ='AC'");
                }

            }
            SQL.SqlCmd("delete from UsrModulo where Codigo not in(select sigla from EmpresaMod)");
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Pbl.SqlDate = SQL.CurrentData();
            Security.UnprotectConnectionString();
            WinAPI.AnimateWindow(Handle,2000,WinAPI.CENTER);
            GetSettings();
            if (Memp)
            {
                BindDataBaseGrid();
                btnEmpresas.Visible = true;
                btnCriarEmpresa.Visible = true;
            }
            else
            {
                btnEmpresas.Visible = false;
                btnCriarEmpresa.Visible = false; 
                var builder =GetConstring();
                tbEmpresa.Text = "EMPRESA: "+builder.InitialCatalog;
            }
            textBoxSenha.UseSystemPasswordChar =true;
            textBoxSenha.PasswordChar =Convert.ToChar("*");
        }

        private SqlConnectionStringBuilder GetConstring()
        {
            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //var connectionString=config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString;


            var configuracaoXml = new ConfiguracaoXml();
            configuracaoXml.LerConfiguracaoBanco();
            string strConn = string.Format("Server={0};Database={1};user={2};password={3}; Integrated Security={4}", configuracaoXml.Servidor, configuracaoXml.BancoDados, configuracaoXml.Usuario
                , configuracaoXml.Senha, configuracaoXml.Idmodeintgratd);
            
            return new SqlConnectionStringBuilder(strConn);
        }
        public  void  BindDataBaseGrid()
        {
            var builder =GetConstring();
            tbEmpresa.Text = "EMPRESA: "+builder.InitialCatalog;
            var cnn = new ServerConnection($@"{builder.DataSource}", $"{builder.UserID}", $"{builder.Password}");
            cnn.Connect();
            _myServer = new Server(cnn);

            var dt = new DataTable();
            var col = new DataColumn("Name",typeof(string));
            dt.Columns.Add(col);

            var xmlfilePath = Application.StartupPath + "\\" + $"DBNAME.xml";
            var xmlFile2 = XmlReader.Create(xmlfilePath, new XmlReaderSettings());
            var dataSet = new DataSet();
            dataSet.ReadXml(xmlFile2);
            DataTable tab = dataSet.Tables[0];
            foreach (Database db in _myServer.Databases)
            {
                var nome = db.Name.Trim();
                if (!nome.Equals("master") && !nome.Equals("model") &&!nome.Equals("msdb") &&!nome.Equals("tempdb") &&!nome.Equals("ReportServer$SERVER")&&!nome.Equals("ReportServer$SERVERTempDB")&&!nome.Equals("ReportServer$SQLEXPRESS")&&!nome.Equals("REPORTSERVER$SQLEXPRESSTEMPDB")  )
                {
                    if (tab.HasRows())
                    {
                        foreach (var item in tab.AsEnumerable())
                        {
                            if (!item.DataRowIsNull())
                            {
                                if (item[0].ToString().ToLower().Equals(nome.ToLower()))
                                {
                                    dt.Rows.Add(nome.ToUpper());
                                }
                            }
                        }
                    }
                    else
                    {
                        dt.Rows.Add(nome.ToUpper());
                    } 
                    
                }
            }
            gridDatabases.SetDataSource(dt);
            cnn.Disconnect();
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            var btnPath = new  GraphicsPath();
            var rect = btnLogin.ClientRectangle;
            rect.Inflate(0,30);
            btnPath.AddEllipse(rect);
            btnLogin.Region = new Region(btnPath);
        }
        private void lblSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var b = new Dmzbd {ShowInTaskbar = false, StartPosition = FormStartPosition.CenterScreen};
            b.ShowDialog();
        }

        private void tbUser_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnKeyBoardPw_Click(object sender, EventArgs e)
        {
            Helper.StartOSK();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CheckLic2(true);
        }

        private void CheckLic2(bool status)
        {
            var xmlfilePath = Application.StartupPath + "\\" + "Licence.xml";
            var xmlFile = new XmlDocument();
            xmlFile.Load(xmlfilePath);
            var encriptedNode = xmlFile.SelectSingleNode("//Encripted");
            var encriptedNodeValor = false;
            if (encriptedNode != null)
            {
                encriptedNodeValor = TryValue(encriptedNode.InnerText);
            }
            if (xmlFile.DocumentElement == null) return;
            var nodes = xmlFile.DocumentElement.ChildNodes;
            foreach (XmlNode xnode in nodes)
            {
                if (xnode == null) continue;
                if (status)
                {
                    if (encriptedNodeValor) continue;
                    if (xnode.Name == "Encripted")
                    {
                        xnode.InnerText = "true";
                    }
                    //xnode.InnerText = Criptografia.Encrypt(xnode.InnerText);
                }
                else
                {
                    if (!encriptedNodeValor) continue;
                    if (xnode.Name == "Encripted")
                    {
                        xnode.InnerText = "false";
                    }
                    // xnode.InnerText = Criptografia.Decrypt(xnode.InnerText);
                }
            }
            xmlFile.Save(xmlfilePath);
        }
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            CheckLic2(false);
        }

        private void btnCriarEmpresa_Click(object sender, EventArgs e)
        {
            var f = new CreateDB {ShowInTaskbar = false};
            f.ShowDialog();
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            if (!panelEmpreas.Visible)
            {
              BindDataBaseGrid();  
            }
            panelEmpreas.Visible = !panelEmpreas.Visible;
        }

        private void gridDatabases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridDatabases.CurrentRow == null) return;
            var bd = gridDatabases.CurrentRow.Cells[0].Value.ToString().Trim();
            btnEmpresas.PerformClick();
            ConnHelper.Save(_myServer.FullTextService.Name.Trim(), bd,null);
            //panelTipoacesso.Controls.Clear();
            GetUser();
            textBoxSenha.Text = "";
            CheckLic(false,bd); 
            tbEmpresa.Text ="EMPRESA: "+ bd;
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxSenha.UseSystemPasswordChar = !textBoxSenha.UseSystemPasswordChar;
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            textBoxSenha.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista= VPN.ListaVPN();
            string msg = "";
            foreach (var item in lista)
            {
                msg=msg+"\r\n"+item;
            }
            MsBox.Show(msg);
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            CallPosSup();
            GetGenerico();
        }
        private void GetGenerico()
        {
            Pbl.CL = SQL.GetRowToEnt<Cl>("Generico=1");
            Pbl.DtContas = GenBl.GetContas(Pbl.Usr.Usrstamp.Trim());
        }

        private void btnBackoffice_Click(object sender, EventArgs e)
        {
            CallBackOffice();
        }

        void CallBackOffice()
        {
            CallForm();
            panelModulos.Visible = false;
            Cursor = Cursors.Default;
        }

        void CallPosSup()
        {
            Hide();
           var demoMdi = new FrmPosSup();
            demoMdi.Origem = 1;
            demoMdi.Show();
        }
        void CallPosRes()
        {
            Hide();
            var demoMdi = new FrmPosRest();
            demoMdi.Origem = 1;
            demoMdi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var b = new Dmzbd { ShowInTaskbar = false, StartPosition = FormStartPosition.CenterScreen };
            b.ShowDialog();
        }

        private void btnPosRest_Click(object sender, EventArgs e)
        {
            CallPosRes();
            GetGenerico();         
        }
        void Visiualizarsenha(TextBox txt, Button btnServerEye)
        {
            if (txt.UseSystemPasswordChar)
            {
                txt.UseSystemPasswordChar = false; 
                btnServerEye.Image = Properties.Resources.Eye_22px;
            }
            else
            {
                txt.UseSystemPasswordChar = true;
                btnServerEye.Image = Properties.Resources.cancel_28px;
            }
        }
        private void btnViewUsrname_Click(object sender, EventArgs e)
        {
            Visiualizarsenha(textBoxSenha, btnViewUsrname);
        }
    }
}
