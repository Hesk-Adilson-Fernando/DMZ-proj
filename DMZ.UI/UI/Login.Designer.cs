using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Generic;
using DMZ.UI.Properties;
using DMZ.UI.UC;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace DMZ.UI.UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelModulos = new System.Windows.Forms.Panel();
            this.panelTipoacesso = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPosRest = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnBackoffice = new System.Windows.Forms.Button();
            this.btnCriarEmpresa = new System.Windows.Forms.Button();
            this.lblSoftwareVersion = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.btnKeyBoardPw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEmpresas = new System.Windows.Forms.Button();
            this.panelEmpreas = new System.Windows.Forms.Panel();
            this.gridDatabases = new DMZ.UI.Generic.GridUi();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbEmpresa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbVPN = new DMZ.UI.UC.CbDefault();
            this.lblSettings = new System.Windows.Forms.LinkLabel();
            this.dmzFramework = new DMZ.UI.UC.DMZContextMenuStrip();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.button2 = new System.Windows.Forms.Button();
            this.elipseControl1 = new DMZ.UI.Generic.ElipseControl();
            this.btnViewUsrname = new System.Windows.Forms.Button();
            this.panelModulos.SuspendLayout();
            this.panelTipoacesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEmpreas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatabases)).BeginInit();
            this.dmzFramework.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 527);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panelModulos
            // 
            this.panelModulos.Controls.Add(this.panelTipoacesso);
            this.panelModulos.Location = new System.Drawing.Point(47, 397);
            this.panelModulos.Name = "panelModulos";
            this.panelModulos.Size = new System.Drawing.Size(279, 99);
            this.panelModulos.TabIndex = 15;
            this.panelModulos.Visible = false;
            // 
            // panelTipoacesso
            // 
            this.panelTipoacesso.Controls.Add(this.btnPosRest);
            this.panelTipoacesso.Controls.Add(this.btnPos);
            this.panelTipoacesso.Controls.Add(this.btnBackoffice);
            this.panelTipoacesso.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.panelTipoacesso.Location = new System.Drawing.Point(0, 0);
            this.panelTipoacesso.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelTipoacesso.Name = "panelTipoacesso";
            this.panelTipoacesso.Size = new System.Drawing.Size(279, 98);
            this.panelTipoacesso.TabIndex = 0;
            // 
            // btnPosRest
            // 
            this.btnPosRest.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPosRest.FlatAppearance.BorderSize = 0;
            this.btnPosRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnPosRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPosRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosRest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosRest.ForeColor = System.Drawing.Color.White;
            this.btnPosRest.Location = new System.Drawing.Point(3, 58);
            this.btnPosRest.Name = "btnPosRest";
            this.btnPosRest.Size = new System.Drawing.Size(273, 37);
            this.btnPosRest.TabIndex = 6;
            this.btnPosRest.Text = "POS RESTAURANTE";
            this.btnPosRest.UseVisualStyleBackColor = false;
            this.btnPosRest.Visible = false;
            this.btnPosRest.Click += new System.EventHandler(this.btnPosRest_Click);
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPos.FlatAppearance.BorderSize = 0;
            this.btnPos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnPos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.ForeColor = System.Drawing.Color.White;
            this.btnPos.Location = new System.Drawing.Point(3, 15);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(273, 37);
            this.btnPos.TabIndex = 4;
            this.btnPos.Text = "POS SUPERMERCADO";
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Visible = false;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnBackoffice
            // 
            this.btnBackoffice.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBackoffice.FlatAppearance.BorderSize = 0;
            this.btnBackoffice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBackoffice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackoffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackoffice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackoffice.ForeColor = System.Drawing.Color.White;
            this.btnBackoffice.Location = new System.Drawing.Point(282, 58);
            this.btnBackoffice.Name = "btnBackoffice";
            this.btnBackoffice.Size = new System.Drawing.Size(273, 37);
            this.btnBackoffice.TabIndex = 5;
            this.btnBackoffice.Text = "BACK OFFICE";
            this.btnBackoffice.UseVisualStyleBackColor = false;
            this.btnBackoffice.Visible = false;
            this.btnBackoffice.Click += new System.EventHandler(this.btnBackoffice_Click);
            // 
            // btnCriarEmpresa
            // 
            this.btnCriarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnCriarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnCriarEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCriarEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCriarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarEmpresa.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCriarEmpresa.Image = global::DMZ.UI.Properties.Resources.Dog_House_20px;
            this.btnCriarEmpresa.Location = new System.Drawing.Point(15, 491);
            this.btnCriarEmpresa.Name = "btnCriarEmpresa";
            this.btnCriarEmpresa.Size = new System.Drawing.Size(26, 24);
            this.btnCriarEmpresa.TabIndex = 77;
            this.dmzToolTip1.SetToolTip(this.btnCriarEmpresa, "Criar empresa");
            this.btnCriarEmpresa.UseVisualStyleBackColor = false;
            this.btnCriarEmpresa.Click += new System.EventHandler(this.btnCriarEmpresa_Click);
            // 
            // lblSoftwareVersion
            // 
            this.lblSoftwareVersion.AutoSize = true;
            this.lblSoftwareVersion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareVersion.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblSoftwareVersion.Location = new System.Drawing.Point(129, 69);
            this.lblSoftwareVersion.Name = "lblSoftwareVersion";
            this.lblSoftwareVersion.Size = new System.Drawing.Size(150, 23);
            this.lblSoftwareVersion.TabIndex = 12;
            this.lblSoftwareVersion.Text = "DMZ SOFTWARE";
            this.lblSoftwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.White;
            this.tbUser.Location = new System.Drawing.Point(83, 318);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(216, 20);
            this.tbUser.TabIndex = 1;
            this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            this.tbUser.MouseLeave += new System.EventHandler(this.tbUser_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(221, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "RC 22.0.1";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLogin.Location = new System.Drawing.Point(52, 412);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(247, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "CONFIRMAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.btnLogin_Paint);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.ForeColor = System.Drawing.Color.White;
            this.textBoxSenha.Location = new System.Drawing.Point(81, 364);
            this.textBoxSenha.Multiline = true;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(216, 20);
            this.textBoxSenha.TabIndex = 2;
            this.textBoxSenha.UseSystemPasswordChar = true;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // btnKeyBoardPw
            // 
            this.btnKeyBoardPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKeyBoardPw.FlatAppearance.BorderSize = 0;
            this.btnKeyBoardPw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnKeyBoardPw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyBoardPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyBoardPw.ForeColor = System.Drawing.Color.White;
            this.btnKeyBoardPw.Image = global::DMZ.UI.Properties.Resources.Keyboard_20px;
            this.btnKeyBoardPw.Location = new System.Drawing.Point(379, 502);
            this.btnKeyBoardPw.Name = "btnKeyBoardPw";
            this.btnKeyBoardPw.Size = new System.Drawing.Size(24, 20);
            this.btnKeyBoardPw.TabIndex = 70;
            this.btnKeyBoardPw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dmzToolTip1.SetToolTip(this.btnKeyBoardPw, "Teclado virtual");
            this.btnKeyBoardPw.UseVisualStyleBackColor = false;
            this.btnKeyBoardPw.Click += new System.EventHandler(this.btnKeyBoardPw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMZ.UI.Properties.Resources.Registered_Trademark_20px;
            this.pictureBox1.Location = new System.Drawing.Point(270, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnClose.Image = global::DMZ.UI.Properties.Resources.Close_Window_25px;
            this.btnClose.Location = new System.Drawing.Point(385, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 74;
            this.dmzToolTip1.SetToolTip(this.btnClose, "Fechar o software");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Image = global::DMZ.UI.Properties.Resources.Client_Management_25px;
            this.button3.Location = new System.Drawing.Point(53, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 28);
            this.button3.TabIndex = 75;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.Image = global::DMZ.UI.Properties.Resources.Key_15px;
            this.button4.Location = new System.Drawing.Point(53, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 28);
            this.button4.TabIndex = 76;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEmpresas
            // 
            this.btnEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnEmpresas.FlatAppearance.BorderSize = 0;
            this.btnEmpresas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEmpresas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresas.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEmpresas.Image = global::DMZ.UI.Properties.Resources.Menu_20px;
            this.btnEmpresas.Location = new System.Drawing.Point(15, 5);
            this.btnEmpresas.Name = "btnEmpresas";
            this.btnEmpresas.Size = new System.Drawing.Size(26, 24);
            this.btnEmpresas.TabIndex = 78;
            this.dmzToolTip1.SetToolTip(this.btnEmpresas, "Escolher empresa");
            this.btnEmpresas.UseVisualStyleBackColor = false;
            this.btnEmpresas.Click += new System.EventHandler(this.btnEmpresas_Click);
            // 
            // panelEmpreas
            // 
            this.panelEmpreas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmpreas.Controls.Add(this.gridDatabases);
            this.panelEmpreas.Location = new System.Drawing.Point(45, 12);
            this.panelEmpreas.Name = "panelEmpreas";
            this.panelEmpreas.Size = new System.Drawing.Size(278, 228);
            this.panelEmpreas.TabIndex = 79;
            this.panelEmpreas.Visible = false;
            // 
            // gridDatabases
            // 
            this.gridDatabases.AddButtons = false;
            this.gridDatabases.AllowUserToAddRows = false;
            this.gridDatabases.AllowUserToDeleteRows = false;
            this.gridDatabases.AutoIncrimento = false;
            this.gridDatabases.BackgroundColor = System.Drawing.Color.Silver;
            this.gridDatabases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDatabases.CampoCodigo = null;
            this.gridDatabases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDatabases.Codigo = null;
            this.gridDatabases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDatabases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDatabases.ColumnHeadersHeight = 30;
            this.gridDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDatabases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome});
            this.gridDatabases.Condicao = null;
            this.gridDatabases.CorPreto = true;
            this.gridDatabases.CurrentColumnName = null;
            this.gridDatabases.DefacolumnName = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDatabases.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDatabases.DellGridRow = null;
            this.gridDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatabases.DtDS = null;
            this.gridDatabases.EnableHeadersVisualStyles = false;
            this.gridDatabases.GenerateColumns = false;
            this.gridDatabases.GridColor = System.Drawing.Color.Goldenrod;
            this.gridDatabases.GridFilha = true;
            this.gridDatabases.GridFilhaSecundaria = false;
            this.gridDatabases.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDatabases.HeadersHeight = 30;
            this.gridDatabases.HeadersVisible = false;
            this.gridDatabases.Location = new System.Drawing.Point(0, 0);
            this.gridDatabases.Name = "gridDatabases";
            this.gridDatabases.OrderbyCampos = null;
            this.gridDatabases.Origem = null;
            this.gridDatabases.ReadOnly = true;
            this.gridDatabases.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDatabases.RowHeadersVisible = false;
            this.gridDatabases.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridDatabases.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDatabases.RowTemplate.ReadOnly = true;
            this.gridDatabases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDatabases.Size = new System.Drawing.Size(276, 226);
            this.gridDatabases.StampCabecalho = "Ststamp";
            this.gridDatabases.StampLocal = "StPrecostamp";
            this.gridDatabases.TabelaSql = "StPrecos";
            this.gridDatabases.TabIndex = 41;
            this.gridDatabases.TbCodigo = null;
            this.gridDatabases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDatabases_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Name";
            this.Nome.HeaderText = "Empresas";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel8.Location = new System.Drawing.Point(54, 341);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(247, 1);
            this.panel8.TabIndex = 80;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel9.Location = new System.Drawing.Point(54, 387);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(247, 1);
            this.panel9.TabIndex = 81;
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.AutoSize = true;
            this.tbEmpresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpresa.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.tbEmpresa.Location = new System.Drawing.Point(130, 498);
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(106, 16);
            this.tbEmpresa.TabIndex = 83;
            this.tbEmpresa.Text = "DMZ SOFTWARE";
            this.tbEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Image = global::DMZ.UI.Properties.Resources.Dog_House_20px;
            this.button1.Location = new System.Drawing.Point(385, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 84;
            this.dmzToolTip1.SetToolTip(this.button1, "Criar empresa");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbVPN
            // 
            this.cbVPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.cbVPN.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVPN.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVPN.CbFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVPN.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbVPN.CbText = "";
            this.cbVPN.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVPN.Imagem = ((System.Drawing.Image)(resources.GetObject("cbVPN.Imagem")));
            this.cbVPN.IsOptionGroup = false;
            this.cbVPN.IsReadOnly = false;
            this.cbVPN.IsRequered = false;
            this.cbVPN.Location = new System.Drawing.Point(351, 478);
            this.cbVPN.Margin = new System.Windows.Forms.Padding(4);
            this.cbVPN.Name = "cbVPN";
            this.cbVPN.OnlyCheckBox = true;
            this.cbVPN.Size = new System.Drawing.Size(31, 22);
            this.cbVPN.TabIndex = 87;
            this.dmzToolTip1.SetToolTip(this.cbVPN, "Trabalha Remotamente ");
            this.cbVPN.Value = "";
            this.cbVPN.Value2 = null;
            this.cbVPN.Visible = false;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.ContextMenuStrip = this.dmzFramework;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.lblSettings.LinkColor = System.Drawing.Color.DimGray;
            this.lblSettings.Location = new System.Drawing.Point(51, 498);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(65, 15);
            this.lblSettings.TabIndex = 14;
            this.lblSettings.TabStop = true;
            this.lblSettings.Text = "Definições\r\n";
            this.dmzToolTip1.SetToolTip(this.lblSettings, "Definiçoes avançadas");
            this.lblSettings.Visible = false;
            this.lblSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSettings_LinkClicked);
            // 
            // dmzFramework
            // 
            this.dmzFramework.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzFramework.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzFramework.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dmzFramework.ForeColor = System.Drawing.Color.White;
            this.dmzFramework.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dmzFramework.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator16,
            this.toolStripMenuItem3,
            this.toolStripMenuItem12,
            this.toolStripSeparator17});
            this.dmzFramework.Name = "dmzContextMenuStrip2";
            this.dmzFramework.Size = new System.Drawing.Size(120, 68);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(116, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::DMZ.UI.Properties.Resources.Expensive_2_32px;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem3.Text = "Encrypt";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Image = global::DMZ.UI.Properties.Resources.Data_Sheet_25px;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem12.Text = "Decrypt";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(116, 6);
            // 
            // cbDefault1
            // 
            this.cbDefault1.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "checkBox2";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(966, 83);
            this.cbDefault1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = false;
            this.cbDefault1.Size = new System.Drawing.Size(250, 34);
            this.cbDefault1.TabIndex = 13;
            this.cbDefault1.Value = null;
            this.cbDefault1.Value2 = null;
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Master 20";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Image = global::DMZ.UI.Properties.Resources.Settings_251px;
            this.button2.Location = new System.Drawing.Point(359, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 26);
            this.button2.TabIndex = 88;
            this.dmzToolTip1.SetToolTip(this.button2, "Fechar o software");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 0;
            this.elipseControl1.TargetControl = this;
            // 
            // btnViewUsrname
            // 
            this.btnViewUsrname.Image = global::DMZ.UI.Properties.Resources.Eye_22px;
            this.btnViewUsrname.Location = new System.Drawing.Point(272, 364);
            this.btnViewUsrname.Name = "btnViewUsrname";
            this.btnViewUsrname.Size = new System.Drawing.Size(25, 20);
            this.btnViewUsrname.TabIndex = 89;
            this.btnViewUsrname.UseVisualStyleBackColor = true;
            this.btnViewUsrname.Click += new System.EventHandler(this.btnViewUsrname_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 527);
            this.Controls.Add(this.btnViewUsrname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbVPN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEmpresa);
            this.Controls.Add(this.panelModulos);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnCriarEmpresa);
            this.Controls.Add(this.panelEmpreas);
            this.Controls.Add(this.btnEmpresas);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKeyBoardPw);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.lblSoftwareVersion);
            this.Controls.Add(this.cbDefault1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panelModulos.ResumeLayout(false);
            this.panelTipoacesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEmpreas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatabases)).EndInit();
            this.dmzFramework.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        //private DevComponents.DotNetBar.Controls.Line line1;
        private TextBox tbUser;
        //private DevComponents.DotNetBar.Controls.Line line2;
        private Label label1;
        private Button btnLogin;
        private CbDefault cbDefault1;
        private Label lblSoftwareVersion;
        private TextBox textBoxSenha;
        private LinkLabel lblSettings;
        private Panel panelModulos;
        public Button btnKeyBoardPw;
        private PictureBox pictureBox1;
        public Button btnClose;
        private FlowLayoutPanel panelTipoacesso;
        public Button button3;
        public Button button4;
        private DMZContextMenuStrip dmzFramework;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripSeparator toolStripSeparator17;
        private Button btnCriarEmpresa;
        private Button btnEmpresas;
        private Panel panelEmpreas;
        private GridUi gridDatabases;
        private DataGridViewTextBoxColumn Nome;
        private DMZToolTip dmzToolTip1;
        private ElipseControl elipseControl1;
        private Panel panel9;
        private Panel panel8;
        private Label tbEmpresa;
        private Button button1;
        private CbDefault cbVPN;
        private Button btnPos;
        private Button btnBackoffice;
        public Button button2;
        private Button btnPosRest;
        public Button btnViewUsrname;
    }
}