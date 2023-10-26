using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Configuration = System.Configuration.Configuration;


namespace DMZ.UI.UI
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class CreateDB : Form
	{
		private Label label1;
        public Panel panelTitulo;
        public Panel panelMessageShow;
        private ProgressBar progressBar1;
        public Label lblMessage;
        public PictureBox pictureBox1;
        public Panel panel5;
        public Button btnClose;
        public Label label2;
        public Button btnExecutar;
        private TabControl tabControl1;
        private TabPage tabPageBack;
        private Panel panel2;
        public Button btnRestore;
        public Button btnProp;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox tbDB;
        private ProgressBar progressBar2;
        private Label label5;
        private GridUi gridDatabases;
        private DataGridViewTextBoxColumn Nome;
        public Button btnDelete;
        private DMZToolTip dmzToolTip1;
        private Panel panel8;
        private Panel panel4;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public CreateDB()
        {
            _cnn = null;
            //
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelMessageShow = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBack = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gridDatabases = new DMZ.UI.Generic.GridUi();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnProp = new System.Windows.Forms.Button();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.panelTitulo.SuspendLayout();
            this.panelMessageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatabases)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da empresa (ex: DMZSISTEMAS)";
            // 
            // tbDB
            // 
            this.tbDB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDB.Location = new System.Drawing.Point(6, 172);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(231, 22);
            this.tbDB.TabIndex = 0;
            this.tbDB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbDB.Leave += new System.EventHandler(this.tbDatabaseName_Leave);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panelTitulo.Controls.Add(this.panelMessageShow);
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.panel5);
            this.panelTitulo.Controls.Add(this.label2);
            this.panelTitulo.Location = new System.Drawing.Point(2, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(641, 30);
            this.panelTitulo.TabIndex = 23;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // panelMessageShow
            // 
            this.panelMessageShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMessageShow.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panelMessageShow.Controls.Add(this.progressBar1);
            this.panelMessageShow.Controls.Add(this.lblMessage);
            this.panelMessageShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMessageShow.Location = new System.Drawing.Point(331, 3);
            this.panelMessageShow.Name = "panelMessageShow";
            this.panelMessageShow.Size = new System.Drawing.Size(193, 25);
            this.panelMessageShow.TabIndex = 32;
            this.panelMessageShow.Visible = false;
            this.panelMessageShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMessageShow_MouseDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(113, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(76, 20);
            this.progressBar1.TabIndex = 34;
            this.progressBar1.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(6, 3);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(78, 17);
            this.lblMessage.TabIndex = 33;
            this.lblMessage.Text = "Form Classe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMZ.UI.Properties.Resources.DOT_25px;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Location = new System.Drawing.Point(554, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(84, 29);
            this.panel5.TabIndex = 32;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DMZ.UI.Properties.Resources.Close_Window_25px;
            this.btnClose.Location = new System.Drawing.Point(55, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 26);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(31, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Criar empresa ";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnExecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnExecutar.Image = global::DMZ.UI.Properties.Resources.Add_Database_23px;
            this.btnExecutar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecutar.Location = new System.Drawing.Point(298, 424);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(137, 32);
            this.btnExecutar.TabIndex = 34;
            this.btnExecutar.Text = "Criar empresa ";
            this.btnExecutar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPageBack);
            this.tabControl1.Location = new System.Drawing.Point(180, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(455, 486);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPageBack
            // 
            this.tabPageBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageBack.Controls.Add(this.btnDelete);
            this.tabPageBack.Controls.Add(this.gridDatabases);
            this.tabPageBack.Controls.Add(this.label5);
            this.tabPageBack.Controls.Add(this.progressBar2);
            this.tabPageBack.Controls.Add(this.panel1);
            this.tabPageBack.Controls.Add(this.btnExecutar);
            this.tabPageBack.Controls.Add(this.tbDB);
            this.tabPageBack.Controls.Add(this.label1);
            this.tabPageBack.Controls.Add(this.panel8);
            this.tabPageBack.Location = new System.Drawing.Point(4, 22);
            this.tabPageBack.Name = "tabPageBack";
            this.tabPageBack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBack.Size = new System.Drawing.Size(447, 460);
            this.tabPageBack.TabIndex = 0;
            this.tabPageBack.UseVisualStyleBackColor = true;
            this.tabPageBack.Click += new System.EventHandler(this.tabPageBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDelete.Image = global::DMZ.UI.Properties.Resources.Trash_25px_1;
            this.btnDelete.Location = new System.Drawing.Point(407, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 26);
            this.btnDelete.TabIndex = 41;
            this.dmzToolTip1.SetToolTip(this.btnDelete, "Eliminar empresa");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridDatabases
            // 
            this.gridDatabases.AddButtons = false;
            this.gridDatabases.AllowUserToAddRows = false;
            this.gridDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDatabases.AutoIncrimento = false;
            this.gridDatabases.BackgroundColor = System.Drawing.Color.White;
            this.gridDatabases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDatabases.CampoCodigo = null;
            this.gridDatabases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDatabases.Codigo = null;
            this.gridDatabases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDatabases.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDatabases.DellGridRow = null;
            this.gridDatabases.DtDS = null;
            this.gridDatabases.EnableHeadersVisualStyles = false;
            this.gridDatabases.GenerateColumns = false;
            this.gridDatabases.GridColor = System.Drawing.Color.Goldenrod;
            this.gridDatabases.GridFilha = true;
            this.gridDatabases.GridFilhaSecundaria = false;
            this.gridDatabases.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDatabases.HeadersHeight = 30;
            this.gridDatabases.HeadersVisible = false;
            this.gridDatabases.Location = new System.Drawing.Point(6, 197);
            this.gridDatabases.Name = "gridDatabases";
            this.gridDatabases.OrderbyCampos = null;
            this.gridDatabases.Origem = null;
            this.gridDatabases.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDatabases.RowHeadersVisible = false;
            this.gridDatabases.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridDatabases.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDatabases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDatabases.Size = new System.Drawing.Size(429, 197);
            this.gridDatabases.StampCabecalho = "Ststamp";
            this.gridDatabases.StampLocal = "StPrecostamp";
            this.gridDatabases.TabelaSql = "StPrecos";
            this.gridDatabases.TabIndex = 40;
            this.gridDatabases.TbCodigo = null;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Name";
            this.Nome.HeaderText = "Designação";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(6, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "%";
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar2.Location = new System.Drawing.Point(6, 429);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(286, 22);
            this.progressBar2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 135);
            this.panel1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "O assistente ajuda a criar uma nova empresa\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 52);
            this.label3.TabIndex = 36;
            this.label3.Text = "Bem Vindo ao assinstente de criação de  empresas ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel8.Location = new System.Drawing.Point(3, 127);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(439, 19);
            this.panel8.TabIndex = 116;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnRestore);
            this.panel2.Controls.Add(this.btnProp);
            this.panel2.Location = new System.Drawing.Point(6, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 482);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(-1, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 178);
            this.panel3.TabIndex = 85;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel4.Location = new System.Drawing.Point(-110, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 10);
            this.panel4.TabIndex = 117;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DMZ.UI.Properties.Resources.DMZ_7;
            this.pictureBox2.Location = new System.Drawing.Point(3, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 133);
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
            this.btnRestore.Image = global::DMZ.UI.Properties.Resources.Data_Recovery_20px;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.Location = new System.Drawing.Point(0, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(165, 30);
            this.btnRestore.TabIndex = 84;
            this.btnRestore.Text = "Empresas";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnProp
            // 
            this.btnProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProp.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProp.Image = global::DMZ.UI.Properties.Resources.Add_Property_20px;
            this.btnProp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProp.Location = new System.Drawing.Point(0, 35);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(165, 30);
            this.btnProp.TabIndex = 83;
            this.btnProp.Text = "Propriedades";
            this.btnProp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProp.UseVisualStyleBackColor = false;
            this.btnProp.Visible = false;
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Master 20";
            // 
            // CreateDB
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(643, 533);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CreateDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create SQL Server Database using C# - PhuongNT";
            this.Load += new System.EventHandler(this.CreateDB_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateDB_MouseDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelMessageShow.ResumeLayout(false);
            this.panelMessageShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBack.ResumeLayout(false);
            this.tabPageBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatabases)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private Server _myServer;
        ServerConnection _cnn;
        private string _connectionString;

        private static Configuration _config;
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}



        private void CreateDB_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            BindDataBase();
        }

        private void BindDataBase()
        {
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _connectionString=_config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString;
            var builder = new SqlConnectionStringBuilder(_connectionString);
            _cnn = new ServerConnection($@"{builder.DataSource}", $"{builder.UserID}", $"{builder.Password}");
            _cnn.Connect();
            _myServer = new Server(_cnn);
            gridDatabases.DataSource = null;
            var dt = new DataTable();
            var col = new DataColumn("Name",typeof(string));
            dt.Columns.Add(col);
            foreach (Database db in _myServer.Databases)
            {
                var nome = db.Name.Trim();
                if (!nome.Equals("master") && !nome.Equals("model") &&!nome.Equals("msdb") &&!nome.Equals("tempdb") &&!nome.Equals("ReportServer$SERVER")&&!nome.Equals("ReportServer$SERVERTempDB")  )
                {
                    dt.Rows.Add(nome.ToUpper());  
                }
            }
            gridDatabases.AutoGenerateColumns = false;
            gridDatabases.DataSource = null;
            gridDatabases.DataSource = dt;
        }


        public string Subdir { get; set; }
        public string ServerName { get; set; }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            CreateRestoreDatabase();
            BindDataBase();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void CreateDB_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void panelMessageShow_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageBack);
           // tabControl1.SelectTab(tabPageRestore);
        }

        private void tbDatabaseName_Leave(object sender, EventArgs e)
        {
            tbDB.Text=tbDB.Text.ToUpper();
        }
        private bool TryValue(string encriptedNodeInnerText)
        {

            if (!bool.TryParse(encriptedNodeInnerText,out var xx))
            {
                xx = Convert.ToBoolean(Criptografia.Decrypt(encriptedNodeInnerText));
            }
            return xx;
        }
        private void CheckLic(bool status)
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
                    if (xnode.Name=="Encripted")
                    {
                        xnode.InnerText = "true";
                    }
                    xnode.InnerText = Criptografia.Encrypt(xnode.InnerText);
                }
                else
                {
                    var valor = encriptedNodeValor ? Criptografia.Decrypt(xnode.InnerText) : xnode.InnerText;
                    switch (xnode.Name)
                    {
                        //case "Tec":
                        //    Pbl.LicencaTecnica = Convert.ToBoolean(valor);
                        //    break;
                        //case "LimitMov":
                        //    Pbl.LimitMov = valor.ToDecimal();
                        //    break;
                        //case "Trial":
                        //    Pbl.LicencaTrial = Convert.ToBoolean(valor);
                        //    break;
                        //case "LimitTrial":
                        //    Pbl.LimitTrial = valor.ToDecimal();
                        //    break;
                    }
                }
            }

            if (status)
            {
                xmlFile.Save(xmlfilePath); 
            }
        }

        private static void CopyXmlDocument(string oldfile, string newfile)
        {
            var document = new XmlDocument();
            document.Load(oldfile);
            // Modify XML file using XmlDocument here
            if (File.Exists(newfile))
                File.Delete(newfile);
            document.Save(newfile);
        }
        public void CreateRestoreDatabase()
        {
            if (gridDatabases.Rows.Count>30)
            {
                MsBox.Show(
                    "Desculpa não pode criar mais que 30 empresas, a sua licença não permite \r\nPorfavor consulte a DMZ Sistemas:\r\n-Tel: 840515627\r\n-Email: comercial@dmzsoftware.co.mz");
            }
            else
            {
                ServerInitiation();
                var databaseName = tbDB.Text.Trim();
                var db = new Database(_myServer,databaseName);
                if (_myServer.Databases[databaseName] ==null)
                {
                    db.Create();
                    //Application.ExecutablePath
                    var licence = Application.StartupPath + "\\" + "Licence.xml";
                    var newlicence =Application.StartupPath + "\\" + $"Licence{databaseName.Trim()}.xml"; 
                    CopyXmlDocument(licence, newlicence);
                    label5.Text = @"Base de dados criada com sucesso ";
                }
                var bkFolder = _myServer.BackupDirectory + (_myServer.BackupDirectory.EndsWith("") ? @"\" : string.Empty);
                var filePath= $"{bkFolder}DMZ.bak";
                try
                {
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

        private void CompletionStatusInPercent(object sender, PercentCompleteEventArgs args)
        {
            Thread.Sleep(100);
            progressBar2.Value = args.Percent;
            label5.Text = $@"Empresa {progressBar2.Value}% criada!..";
            progressBar2.Update();
        }
        private void restore_Complete2(object sender, ServerMessageEventArgs e)
        {
            label5.Text = @"Empresa criada com sucesso!..";
        }

        private void tabPageBack_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridDatabases.CurrentRow == null) return;
            var empresa = gridDatabases.CurrentRow.Cells[0].Value.ToString();
            var dr = MsBox.Show($"Deseja eliminar a empresa: {empresa.ToUpper()} \r\n A Eliminação irá apagar toda informação",DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            var dr2 = MsBox.Show("Deseja que o DMZ Software, faça uma cópia de segurança antes se eliminar!",DResult.YesNo);
            if (dr2.DialogResult == DialogResult.Yes)
            {
                BackupDb(empresa.Trim());

            }
            DropDb(empresa.Trim());
            BindDataBase();
            var newfile =Application.StartupPath + "\\" + $"Licence{empresa.Trim()}.xml"; 
            if (File.Exists(newfile))
                File.Delete(newfile);

        }

        private void DropDb(string empresa)
        {
            _myServer.KillAllProcesses(empresa.Trim());
            _myServer.Databases[empresa.Trim()].Drop();
            label5.Text = $@"Empresa {empresa} eliminada com sucesso!..";
        }

        private void BackupDb(string dataBaseName)
        {
            var  source = new Backup();
            ServerInitiation();
            var backupFileName = _myServer.BackupDirectory +(_myServer.BackupDirectory.EndsWith("") ? @"\" : string.Empty) + dataBaseName 
                                 + "_" + DateTime.Now.ToString("yyyyMMdd_HH_mm_ss.bak");
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

        private void Source_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            label5.Text = $@"{e.Percent}% cópia concluida!..";
            progressBar2.Value = e.Percent;
            progressBar2.Update();
        }
    }
}
