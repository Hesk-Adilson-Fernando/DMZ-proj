namespace DMZ.UI.UI
{
    partial class Dmzbd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSoftwareVersion = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBack = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnInstance = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcessBackup = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tabPageRestore = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPageSQLSERVICES = new System.Windows.Forms.TabPage();
            this.btnServices = new System.Windows.Forms.Button();
            this.gridUi2 = new DMZ.UI.Generic.GridUi();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanho = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPageVPN = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsrname = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVPNConfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBack.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageRestore.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPageSQLSERVICES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi2)).BeginInit();
            this.tabPageVPN.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblSoftwareVersion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DMZ.UI.Properties.Resources.Close_Window_25px;
            this.btnClose.Location = new System.Drawing.Point(540, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 22);
            this.btnClose.TabIndex = 34;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSoftwareVersion
            // 
            this.lblSoftwareVersion.AutoSize = true;
            this.lblSoftwareVersion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareVersion.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSoftwareVersion.Location = new System.Drawing.Point(3, 5);
            this.lblSoftwareVersion.Name = "lblSoftwareVersion";
            this.lblSoftwareVersion.Size = new System.Drawing.Size(44, 16);
            this.lblSoftwareVersion.TabIndex = 13;
            this.lblSoftwareVersion.Text = "label2";
            this.lblSoftwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSoftwareVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSoftwareVersion_MouseDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBack);
            this.tabControl1.Controls.Add(this.tabPageRestore);
            this.tabControl1.Controls.Add(this.tabPageSQLSERVICES);
            this.tabControl1.Controls.Add(this.tabPageVPN);
            this.tabControl1.Location = new System.Drawing.Point(151, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 465);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPageBack
            // 
            this.tabPageBack.BackColor = System.Drawing.Color.Beige;
            this.tabPageBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageBack.Controls.Add(this.button2);
            this.tabPageBack.Controls.Add(this.tbPw);
            this.tabPageBack.Controls.Add(this.label8);
            this.tabPageBack.Controls.Add(this.panel3);
            this.tabPageBack.Controls.Add(this.comboBox2);
            this.tabPageBack.Controls.Add(this.comboBox1);
            this.tabPageBack.Controls.Add(this.btnInstance);
            this.tabPageBack.Controls.Add(this.label4);
            this.tabPageBack.Controls.Add(this.label3);
            this.tabPageBack.Controls.Add(this.btnProcessBackup);
            this.tabPageBack.Controls.Add(this.panel8);
            this.tabPageBack.Location = new System.Drawing.Point(4, 22);
            this.tabPageBack.Name = "tabPageBack";
            this.tabPageBack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBack.Size = new System.Drawing.Size(396, 439);
            this.tabPageBack.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Image = global::DMZ.UI.Properties.Resources.align_text_left_21px;
            this.button2.Location = new System.Drawing.Point(3, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 27);
            this.button2.TabIndex = 119;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPw
            // 
            this.tbPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPw.Location = new System.Drawing.Point(20, 350);
            this.tbPw.Name = "tbPw";
            this.tbPw.Size = new System.Drawing.Size(341, 20);
            this.tbPw.TabIndex = 118;
            this.tbPw.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label8.Location = new System.Drawing.Point(17, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 117;
            this.label8.Text = "Password";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 173);
            this.panel3.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-2, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 68);
            this.label7.TabIndex = 36;
            this.label7.Text = "Bem Vindo ao assinstente de configuração do sistema.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(20, 304);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(341, 21);
            this.comboBox2.TabIndex = 99;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 21);
            this.comboBox1.TabIndex = 98;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnInstance
            // 
            this.btnInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnInstance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnInstance.Image = global::DMZ.UI.Properties.Resources.Add_Property_20px;
            this.btnInstance.Location = new System.Drawing.Point(359, 254);
            this.btnInstance.Name = "btnInstance";
            this.btnInstance.Size = new System.Drawing.Size(29, 22);
            this.btnInstance.TabIndex = 97;
            this.btnInstance.UseVisualStyleBackColor = false;
            this.btnInstance.Click += new System.EventHandler(this.btnInstance_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label4.Location = new System.Drawing.Point(17, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 96;
            this.label4.Text = "Instância ou IP do Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label3.Location = new System.Drawing.Point(17, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 94;
            this.label3.Text = "Base de Dados ";
            // 
            // btnProcessBackup
            // 
            this.btnProcessBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProcessBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessBackup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessBackup.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessBackup.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnProcessBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessBackup.Location = new System.Drawing.Point(280, 391);
            this.btnProcessBackup.Name = "btnProcessBackup";
            this.btnProcessBackup.Size = new System.Drawing.Size(111, 40);
            this.btnProcessBackup.TabIndex = 85;
            this.btnProcessBackup.Text = "Executar";
            this.btnProcessBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessBackup.UseVisualStyleBackColor = false;
            this.btnProcessBackup.Click += new System.EventHandler(this.btnProcessBackup_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel8.Location = new System.Drawing.Point(3, 167);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(388, 19);
            this.panel8.TabIndex = 116;
            // 
            // tabPageRestore
            // 
            this.tabPageRestore.BackColor = System.Drawing.Color.Snow;
            this.tabPageRestore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageRestore.Controls.Add(this.panel4);
            this.tabPageRestore.Controls.Add(this.panel9);
            this.tabPageRestore.Controls.Add(this.button4);
            this.tabPageRestore.Location = new System.Drawing.Point(4, 22);
            this.tabPageRestore.Name = "tabPageRestore";
            this.tabPageRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRestore.Size = new System.Drawing.Size(396, 439);
            this.tabPageRestore.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 173);
            this.panel4.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 68);
            this.label1.TabIndex = 36;
            this.label1.Text = "Bem Vindo ao assinstente de configuração do sistema.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel9.Location = new System.Drawing.Point(3, 174);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(388, 10);
            this.panel9.TabIndex = 118;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(252, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 40);
            this.button4.TabIndex = 90;
            this.button4.Text = "Run Migrations";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPageSQLSERVICES
            // 
            this.tabPageSQLSERVICES.BackColor = System.Drawing.Color.Beige;
            this.tabPageSQLSERVICES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageSQLSERVICES.Controls.Add(this.btnServices);
            this.tabPageSQLSERVICES.Controls.Add(this.gridUi2);
            this.tabPageSQLSERVICES.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQLSERVICES.Name = "tabPageSQLSERVICES";
            this.tabPageSQLSERVICES.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQLSERVICES.Size = new System.Drawing.Size(396, 439);
            this.tabPageSQLSERVICES.TabIndex = 2;
            // 
            // btnServices
            // 
            this.btnServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnServices.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServices.Location = new System.Drawing.Point(284, 403);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(104, 30);
            this.btnServices.TabIndex = 89;
            this.btnServices.Text = "Processar";
            this.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // gridUi2
            // 
            this.gridUi2.AddButtons = false;
            this.gridUi2.AllowUserToAddRows = false;
            this.gridUi2.AutoIncrimento = false;
            this.gridUi2.BackgroundColor = System.Drawing.Color.White;
            this.gridUi2.CampoCodigo = null;
            this.gridUi2.Codigo = null;
            this.gridUi2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi2.ColumnHeadersHeight = 30;
            this.gridUi2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.tipo,
            this.tamanho});
            this.gridUi2.Condicao = null;
            this.gridUi2.CorPreto = false;
            this.gridUi2.CurrentColumnName = null;
            this.gridUi2.DefacolumnName = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUi2.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi2.DellGridRow = null;
            this.gridUi2.DtDS = null;
            this.gridUi2.EnableHeadersVisualStyles = false;
            this.gridUi2.GenerateColumns = false;
            this.gridUi2.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUi2.GridFilha = false;
            this.gridUi2.GridFilhaSecundaria = false;
            this.gridUi2.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi2.HeadersHeight = 30;
            this.gridUi2.HeadersVisible = false;
            this.gridUi2.Location = new System.Drawing.Point(6, 6);
            this.gridUi2.Name = "gridUi2";
            this.gridUi2.OrderbyCampos = null;
            this.gridUi2.Origem = null;
            this.gridUi2.RowHeadersVisible = false;
            this.gridUi2.RowHeadersWidth = 30;
            this.gridUi2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUi2.Size = new System.Drawing.Size(384, 395);
            this.gridUi2.StampCabecalho = null;
            this.gridUi2.StampLocal = null;
            this.gridUi2.TabelaSql = null;
            this.gridUi2.TabIndex = 1;
            this.gridUi2.TbCodigo = null;
            this.gridUi2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi2_CellClick);
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "Name";
            this.nome.HeaderText = "Serviço";
            this.nome.Name = "nome";
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "ServiceState";
            this.tipo.HeaderText = "Status";
            this.tipo.Name = "tipo";
            // 
            // tamanho
            // 
            this.tamanho.HeaderText = "....";
            this.tamanho.Name = "tamanho";
            this.tamanho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tamanho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tamanho.Width = 30;
            // 
            // tabPageVPN
            // 
            this.tabPageVPN.BackColor = System.Drawing.Color.Snow;
            this.tabPageVPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageVPN.Controls.Add(this.tableLayoutPanel2);
            this.tabPageVPN.Location = new System.Drawing.Point(4, 22);
            this.tabPageVPN.Name = "tabPageVPN";
            this.tabPageVPN.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVPN.Size = new System.Drawing.Size(396, 439);
            this.tabPageVPN.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.Label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtHost, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPassword, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtUsrname, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 175);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(37, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 13);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Host:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password";
            // 
            // txtHost
            // 
            this.txtHost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHost.Location = new System.Drawing.Point(75, 11);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(246, 20);
            this.txtHost.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(75, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Username:";
            // 
            // txtUsrname
            // 
            this.txtUsrname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsrname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsrname.Location = new System.Drawing.Point(75, 54);
            this.txtUsrname.Name = "txtUsrname";
            this.txtUsrname.Size = new System.Drawing.Size(246, 20);
            this.txtUsrname.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnDisconnect, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnConnect, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(75, 132);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(283, 40);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(144, 3);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(104, 32);
            this.btnDisconnect.TabIndex = 15;
            this.btnDisconnect.Text = "Disconectar";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(3, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(104, 32);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnVPNConfig);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnRestore);
            this.panel2.Controls.Add(this.btnBackup);
            this.panel2.Location = new System.Drawing.Point(9, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 461);
            this.panel2.TabIndex = 28;
            // 
            // btnVPNConfig
            // 
            this.btnVPNConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVPNConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnVPNConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnVPNConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVPNConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVPNConfig.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnVPNConfig.Image = global::DMZ.UI.Properties.Resources.connect_25px;
            this.btnVPNConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVPNConfig.Location = new System.Drawing.Point(3, 111);
            this.btnVPNConfig.Name = "btnVPNConfig";
            this.btnVPNConfig.Size = new System.Drawing.Size(132, 30);
            this.btnVPNConfig.TabIndex = 89;
            this.btnVPNConfig.Text = "VPN Config.";
            this.btnVPNConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVPNConfig.UseVisualStyleBackColor = false;
            this.btnVPNConfig.Click += new System.EventHandler(this.btnVPNConfig_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Image = global::DMZ.UI.Properties.Resources.Data_Sheet_251px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 88;
            this.button1.Text = "SQL Services ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(-15, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(168, 178);
            this.panel5.TabIndex = 87;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(-107, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 10);
            this.panel6.TabIndex = 117;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(262, 10);
            this.panel7.TabIndex = 118;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DMZ.UI.Properties.Resources.DMZ_7;
            this.pictureBox2.Location = new System.Drawing.Point(12, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRestore.Image = global::DMZ.UI.Properties.Resources.delete_ticket_25px;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.Location = new System.Drawing.Point(3, 39);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(132, 30);
            this.btnRestore.TabIndex = 84;
            this.btnRestore.Text = "Migrations";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBackup.Image = global::DMZ.UI.Properties.Resources.Data_Backup_20px;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.Location = new System.Drawing.Point(3, 3);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(132, 30);
            this.btnBackup.TabIndex = 82;
            this.btnBackup.Text = "SQL Server";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // Dmzbd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(567, 509);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dmzbd";
            this.Text = "DMZBD";
            this.Load += new System.EventHandler(this.DMZBD_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DMZBD_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageBack.ResumeLayout(false);
            this.tabPageBack.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPageRestore.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPageSQLSERVICES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUi2)).EndInit();
            this.tabPageVPN.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSoftwareVersion;
        public System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnProcessBackup;
        private System.Windows.Forms.TabPage tabPageRestore;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnRestore;
        public System.Windows.Forms.Button btnBackup;
        public System.Windows.Forms.Button btnInstance;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPageSQLSERVICES;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnServices;
        private Generic.GridUi gridUi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewImageColumn tamanho;
        private System.Windows.Forms.TabPage tabPageVPN;
        public System.Windows.Forms.Button btnVPNConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtHost;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtUsrname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        internal System.Windows.Forms.Button btnDisconnect;
        internal System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbPw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Button button2;
    }
}