using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Configuracao;

namespace Configuracao
{
    public class FrmConfigDb : FrmGrad
    {
        // Fields
        public SqlConnection conn;
        private string strerro = "";
        private IContainer components = null;
        public TextBox txtUsuario;
        public TextBox txtServidor;
        public TextBox txtBancoDados;
        public TabControl tabMae;
        public TabPage tabPage1;
        public TextBox txtSenha;
        public Label lblserver;
        public Panel painelmenu;
        public Button btnTestar;
        public Button btnSalvar;
        public CheckBox cbxintegreted;
        public FlowLayoutPanel flowLayoutPanel1;
        public ToolTip toolTip;
        private Panel pnlServer;
        public Button btnServerEye;
        private Panel pnlBd;
        public Label lblbd;
        public Button btnViewBd;
        private Panel pnlUsr;
        public Label label1;
        public Button btnViewUsrname;
        private Panel pnlSenha;
        public Label label2;
        public Button btnViewPw;
        public int Origem = 0;
        // Methods
        public FrmConfigDb()
        {
            InitializeComponent();
        }

        private bool AbrirConexao()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception exception)
            {
                strerro = exception.Message;
                return false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\XmlPath\\Config.xml";
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                string patht = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                if (!Directory.Exists(patht + "\\XmlPath")
                    || !Directory.Exists(patht + "\\XmlPath" + "\\Config.xml"))
                {
                    CreateXml(patht);
                }
                MessageBox.Show("Arquivo de configura\x00e7\x00e3o gravado com sucesso!", "Informa\x00e7\x00f5es", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao tentar gravar arquivo de configura\x00e7\x00e3o : \n" + exception.Message.ToString(), "Informa\x00e7\x00e3o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void btnTestar_Click(object sender, EventArgs e)
        {
            string[] strArray = { "Server=", txtServidor.Text, ";Database=", txtBancoDados.Text, ";user=", txtUsuario.Text, ";password=", txtSenha.Text, ";" };
            string connectionString = string.Concat(strArray);
            conn = new SqlConnection(connectionString);
            if (AbrirConexao())
            {
                MessageBox.Show("Conex\x00e3o estabelecida com sucesso!", "Informa\x00e7\x00e3o", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Erro ao Abrir conexao : " + strerro, "Informa\x00e7\x00e3o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(components, null)))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FrmConfigDb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.S))
            {
                btnSalvar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnTestar_Click(sender, e);
            }
        }

        private void FrmConfigDb_Load(object sender, EventArgs e)
        {
            Size = new Size(313, 402);
            try
            {
                if (Origem==1)
                {
                    cbxintegreted.Visible = pnlServer.Visible =
                                    pnlUsr.Visible =
                                        pnlSenha.Visible = false;
                }
                var constr = SQL.GetConectionString();
                if (constr.retorno)
                {
                    string usr = constr.usr;
                    string psw = constr.senha;
                    string bd = constr.bd;
                    string srv = constr.servido;
                    txtServidor.Text = srv;
                    txtBancoDados.Text = bd;
                    txtUsuario.Text = usr;
                    txtSenha.Text = psw;
                }
                else
                {
                    MessageBox.Show($@"Ocorreu um erro ao tentar carregar as credenciais do usuário!",
                        $@"Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message, "Informa\x00e7\x00e3o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void CreateXml(string patht)
        {
            if (!Directory.Exists(patht + "\\XmlPath"))
            {
                Directory.CreateDirectory(patht + "\\XmlPath");
            }
            StreamWriter objEscreve = new StreamWriter(patht + "\\XmlPath" + "\\Config.xml");
            objEscreve.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>");
            objEscreve.WriteLine("<useroptions>");
            objEscreve.WriteLine("<idmodeusr>{0}</idmodeusr>", ClsCryptografia.Crypto(txtUsuario.Text, true));
            objEscreve.WriteLine("<idmodebd>{0}</idmodebd>", ClsCryptografia.Crypto(txtBancoDados.Text, true));
            objEscreve.WriteLine("<idmodesrv>{0}</idmodesrv>", ClsCryptografia.Crypto(txtServidor.Text, true));
            objEscreve.WriteLine($"<idmodepw>{ClsCryptografia.Crypto(txtSenha.Text, true)}</idmodepw>");
            objEscreve.WriteLine($"<idmodeintgratd>{ClsCryptografia.Crypto(cbxintegreted.Checked.ToString().ToLower(), true)}</idmodeintgratd>");
            objEscreve.WriteLine("</useroptions>");
            objEscreve.Flush();

            objEscreve.Close();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigDb));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBancoDados = new System.Windows.Forms.TextBox();
            this.tabMae = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.btnServerEye = new System.Windows.Forms.Button();
            this.lblserver = new System.Windows.Forms.Label();
            this.pnlBd = new System.Windows.Forms.Panel();
            this.lblbd = new System.Windows.Forms.Label();
            this.btnViewBd = new System.Windows.Forms.Button();
            this.pnlUsr = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewUsrname = new System.Windows.Forms.Button();
            this.pnlSenha = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewPw = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cbxintegreted = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnTestar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.painelmenu = new System.Windows.Forms.Panel();
            this.tabMae.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlServer.SuspendLayout();
            this.pnlBd.SuspendLayout();
            this.pnlUsr.SuspendLayout();
            this.pnlSenha.SuspendLayout();
            this.painelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(3, 22);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(252, 21);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.UseSystemPasswordChar = true;
            // 
            // txtServidor
            // 
            this.txtServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServidor.Location = new System.Drawing.Point(5, 19);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(252, 21);
            this.txtServidor.TabIndex = 0;
            this.txtServidor.UseSystemPasswordChar = true;
            // 
            // txtBancoDados
            // 
            this.txtBancoDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBancoDados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBancoDados.Location = new System.Drawing.Point(5, 20);
            this.txtBancoDados.Name = "txtBancoDados";
            this.txtBancoDados.Size = new System.Drawing.Size(252, 21);
            this.txtBancoDados.TabIndex = 1;
            // 
            // tabMae
            // 
            this.tabMae.Controls.Add(this.tabPage1);
            this.tabMae.Location = new System.Drawing.Point(2, 74);
            this.tabMae.Name = "tabMae";
            this.tabMae.SelectedIndex = 0;
            this.tabMae.Size = new System.Drawing.Size(294, 277);
            this.tabMae.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(286, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CONEXÃO COM SERVIDOR";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlServer);
            this.flowLayoutPanel1.Controls.Add(this.pnlBd);
            this.flowLayoutPanel1.Controls.Add(this.pnlUsr);
            this.flowLayoutPanel1.Controls.Add(this.pnlSenha);
            this.flowLayoutPanel1.Controls.Add(this.cbxintegreted);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(274, 235);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // pnlServer
            // 
            this.pnlServer.Controls.Add(this.btnServerEye);
            this.pnlServer.Controls.Add(this.lblserver);
            this.pnlServer.Controls.Add(this.txtServidor);
            this.pnlServer.Location = new System.Drawing.Point(3, 3);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(260, 45);
            this.pnlServer.TabIndex = 48;
            // 
            // btnServerEye
            // 
            this.btnServerEye.Image = global::Configuracao.Properties.Resources.eye_care;
            this.btnServerEye.Location = new System.Drawing.Point(233, 19);
            this.btnServerEye.Name = "btnServerEye";
            this.btnServerEye.Size = new System.Drawing.Size(25, 21);
            this.btnServerEye.TabIndex = 47;
            this.btnServerEye.UseVisualStyleBackColor = true;
            this.btnServerEye.Click += new System.EventHandler(this.btnServerEye_Click);
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Location = new System.Drawing.Point(9, 3);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(47, 13);
            this.lblserver.TabIndex = 42;
            this.lblserver.Text = "Servidor";
            // 
            // pnlBd
            // 
            this.pnlBd.Controls.Add(this.lblbd);
            this.pnlBd.Controls.Add(this.btnViewBd);
            this.pnlBd.Controls.Add(this.txtBancoDados);
            this.pnlBd.Location = new System.Drawing.Point(3, 54);
            this.pnlBd.Name = "pnlBd";
            this.pnlBd.Size = new System.Drawing.Size(260, 45);
            this.pnlBd.TabIndex = 48;
            // 
            // lblbd
            // 
            this.lblbd.AutoSize = true;
            this.lblbd.Location = new System.Drawing.Point(9, 5);
            this.lblbd.Name = "lblbd";
            this.lblbd.Size = new System.Drawing.Size(84, 13);
            this.lblbd.TabIndex = 48;
            this.lblbd.Text = "Banco de Dados";
            // 
            // btnViewBd
            // 
            this.btnViewBd.Image = global::Configuracao.Properties.Resources.eye_care;
            this.btnViewBd.Location = new System.Drawing.Point(233, 20);
            this.btnViewBd.Name = "btnViewBd";
            this.btnViewBd.Size = new System.Drawing.Size(25, 21);
            this.btnViewBd.TabIndex = 47;
            this.btnViewBd.UseVisualStyleBackColor = true;
            this.btnViewBd.Click += new System.EventHandler(this.btnViewBd_Click);
            // 
            // pnlUsr
            // 
            this.pnlUsr.Controls.Add(this.label1);
            this.pnlUsr.Controls.Add(this.btnViewUsrname);
            this.pnlUsr.Controls.Add(this.txtUsuario);
            this.pnlUsr.Location = new System.Drawing.Point(3, 105);
            this.pnlUsr.Name = "pnlUsr";
            this.pnlUsr.Size = new System.Drawing.Size(260, 45);
            this.pnlUsr.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Usuário";
            // 
            // btnViewUsrname
            // 
            this.btnViewUsrname.Image = global::Configuracao.Properties.Resources.eye_care;
            this.btnViewUsrname.Location = new System.Drawing.Point(233, 22);
            this.btnViewUsrname.Name = "btnViewUsrname";
            this.btnViewUsrname.Size = new System.Drawing.Size(25, 21);
            this.btnViewUsrname.TabIndex = 47;
            this.btnViewUsrname.UseVisualStyleBackColor = true;
            this.btnViewUsrname.Click += new System.EventHandler(this.btnViewUsrname_Click);
            // 
            // pnlSenha
            // 
            this.pnlSenha.Controls.Add(this.label2);
            this.pnlSenha.Controls.Add(this.btnViewPw);
            this.pnlSenha.Controls.Add(this.txtSenha);
            this.pnlSenha.Location = new System.Drawing.Point(3, 156);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(260, 45);
            this.pnlSenha.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Senha";
            // 
            // btnViewPw
            // 
            this.btnViewPw.Image = global::Configuracao.Properties.Resources.eye_care;
            this.btnViewPw.Location = new System.Drawing.Point(233, 21);
            this.btnViewPw.Name = "btnViewPw";
            this.btnViewPw.Size = new System.Drawing.Size(25, 21);
            this.btnViewPw.TabIndex = 47;
            this.btnViewPw.UseVisualStyleBackColor = true;
            this.btnViewPw.Click += new System.EventHandler(this.btnViewPw_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(5, 21);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(252, 21);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // cbxintegreted
            // 
            this.cbxintegreted.AutoSize = true;
            this.cbxintegreted.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxintegreted.Location = new System.Drawing.Point(3, 207);
            this.cbxintegreted.Name = "cbxintegreted";
            this.cbxintegreted.Size = new System.Drawing.Size(162, 23);
            this.cbxintegreted.TabIndex = 46;
            this.cbxintegreted.Text = "Integrated Security";
            this.cbxintegreted.UseVisualStyleBackColor = true;
            // 
            // btnTestar
            // 
            this.btnTestar.BackColor = System.Drawing.Color.Transparent;
            this.btnTestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTestar.Image = ((System.Drawing.Image)(resources.GetObject("btnTestar.Image")));
            this.btnTestar.Location = new System.Drawing.Point(71, 5);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(64, 57);
            this.btnTestar.TabIndex = 2;
            this.btnTestar.Text = "&Testar";
            this.btnTestar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTestar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.btnTestar, "Testar [ F5 ]");
            this.btnTestar.UseVisualStyleBackColor = false;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 57);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.btnSalvar, "Salvar [ Ctrl + S ]");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // painelmenu
            // 
            this.painelmenu.BackgroundImage = global::Configuracao.Properties.Resources._28_Free_Books_for_Learning_Software_Architecture;
            this.painelmenu.Controls.Add(this.btnTestar);
            this.painelmenu.Controls.Add(this.btnSalvar);
            this.painelmenu.Location = new System.Drawing.Point(0, 0);
            this.painelmenu.Name = "painelmenu";
            this.painelmenu.Size = new System.Drawing.Size(296, 70);
            this.painelmenu.TabIndex = 48;
            // 
            // FrmConfigDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 351);
            this.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(200)))), ((int)(((byte)(232)))));
            this.Color2 = System.Drawing.SystemColors.Control;
            this.ColorAngle = 90F;
            this.Controls.Add(this.painelmenu);
            this.Controls.Add(this.tabMae);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmConfigDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração do banco";
            this.Load += new System.EventHandler(this.FrmConfigDb_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConfigDb_KeyDown);
            this.tabMae.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnlServer.ResumeLayout(false);
            this.pnlServer.PerformLayout();
            this.pnlBd.ResumeLayout(false);
            this.pnlBd.PerformLayout();
            this.pnlUsr.ResumeLayout(false);
            this.pnlUsr.PerformLayout();
            this.pnlSenha.ResumeLayout(false);
            this.pnlSenha.PerformLayout();
            this.painelmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        void Visiualizarsenha(TextBox txt, Button btnServerEye)
        {
            if (txt.UseSystemPasswordChar)
            {
                txt.UseSystemPasswordChar = false;
                btnServerEye.Image = Properties.Resources.hide;
            }
            else
            {
                txt.UseSystemPasswordChar = true;
                btnServerEye.Image = Properties.Resources.eye_care;
            }
        }
        private void btnServerEye_Click(object sender, EventArgs e)
        {
            Visiualizarsenha(txtServidor, btnServerEye);
        }

        private void btnViewBd_Click(object sender, EventArgs e)
        {
            Visiualizarsenha(txtBancoDados, btnViewBd);
        }
        private void btnViewUsrname_Click(object sender, EventArgs e)
        {
            Visiualizarsenha(txtUsuario, btnViewUsrname);
        }
        private void btnViewPw_Click(object sender, EventArgs e)
        {
            Visiualizarsenha(txtSenha, btnViewPw);
        }
    }




}
