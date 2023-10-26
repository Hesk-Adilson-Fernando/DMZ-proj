namespace DMZ.UI.UI
{
    partial class FrmConsultacx
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultacx));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.nrdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTodas = new DMZ.UI.UC.CbDefault();
            this.cbSupervisor = new DMZ.UI.UC.CbDefault();
            this.comboBox1 = new DMZ.UI.UC.DmzProcura();
            this.comboBox2 = new DMZ.UI.UC.DmzProcura();
            this.dmzEntreDatas1 = new DMZ.UI.UC.DMZEntreDatas();
            this.MenuPrint = new DMZ.UI.UC.DMZContextMenuStrip();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.MenuPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(834, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(801, 1);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.Text = "Folha de Caixa";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(898, 40);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 35);
            this.btnPrint.TabIndex = 93;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Settings_251px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.Location = new System.Drawing.Point(678, 66);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(106, 35);
            this.btnProcessar.TabIndex = 90;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.button1.Location = new System.Drawing.Point(790, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 36);
            this.button1.TabIndex = 99;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridUi1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.panel1.Location = new System.Drawing.Point(2, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 378);
            this.panel1.TabIndex = 100;
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.Color.Snow;
            this.gridUi1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrdoc,
            this.formasp,
            this.entrada,
            this.saida,
            this.Saldo,
            this.Emissao,
            this.numero,
            this.Documento});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.White;
            this.gridUi1.GridFilha = false;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(2, 3);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridUi1.Size = new System.Drawing.Size(824, 368);
            this.gridUi1.StampCabecalho = null;
            this.gridUi1.StampLocal = null;
            this.gridUi1.TabelaSql = null;
            this.gridUi1.TabIndex = 99;
            this.gridUi1.TbCodigo = null;
            // 
            // nrdoc
            // 
            this.nrdoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nrdoc.DataPropertyName = "Contatesoura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.nrdoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.nrdoc.HeaderText = "Caixa";
            this.nrdoc.MinimumWidth = 150;
            this.nrdoc.Name = "nrdoc";
            // 
            // formasp
            // 
            this.formasp.DataPropertyName = "inicial";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.formasp.DefaultCellStyle = dataGridViewCellStyle4;
            this.formasp.HeaderText = "Saldo Inicial";
            this.formasp.MinimumWidth = 100;
            this.formasp.Name = "formasp";
            this.formasp.Visible = false;
            this.formasp.Width = 110;
            // 
            // entrada
            // 
            this.entrada.DataPropertyName = "entrada";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.entrada.DefaultCellStyle = dataGridViewCellStyle5;
            this.entrada.HeaderText = "Entrada";
            this.entrada.Name = "entrada";
            this.entrada.Width = 110;
            // 
            // saida
            // 
            this.saida.DataPropertyName = "saida";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.saida.DefaultCellStyle = dataGridViewCellStyle6;
            this.saida.HeaderText = "Saída";
            this.saida.Name = "saida";
            this.saida.Width = 110;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Total";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle7;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 110;
            // 
            // Emissao
            // 
            this.Emissao.DataPropertyName = "Datamov";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.Emissao.DefaultCellStyle = dataGridViewCellStyle8;
            this.Emissao.HeaderText = "Data";
            this.Emissao.Name = "Emissao";
            this.Emissao.Width = 80;
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numero.DataPropertyName = "Nome";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.numero.DefaultCellStyle = dataGridViewCellStyle9;
            this.numero.HeaderText = "Entidade";
            this.numero.MinimumWidth = 120;
            this.numero.Name = "numero";
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "nomeUsr";
            this.Documento.HeaderText = "Utilizador";
            this.Documento.Name = "Documento";
            // 
            // cbTodas
            // 
            this.cbTodas.BackColor = System.Drawing.Color.Transparent;
            this.cbTodas.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTodas.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTodas.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbTodas.CbText = "Todas as contas ";
            this.cbTodas.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTodas.Imagem = ((System.Drawing.Image)(resources.GetObject("cbTodas.Imagem")));
            this.cbTodas.IsOptionGroup = false;
            this.cbTodas.IsReadOnly = false;
            this.cbTodas.IsRequered = false;
            this.cbTodas.Location = new System.Drawing.Point(3, 35);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.OnlyCheckBox = true;
            this.cbTodas.Size = new System.Drawing.Size(127, 22);
            this.cbTodas.TabIndex = 103;
            this.cbTodas.Value = null;
            this.cbTodas.Value2 = null;
            // 
            // cbSupervisor
            // 
            this.cbSupervisor.BackColor = System.Drawing.Color.Transparent;
            this.cbSupervisor.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSupervisor.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSupervisor.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupervisor.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbSupervisor.CbText = "Supervisor";
            this.cbSupervisor.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSupervisor.Enabled = false;
            this.cbSupervisor.Imagem = ((System.Drawing.Image)(resources.GetObject("cbSupervisor.Imagem")));
            this.cbSupervisor.IsOptionGroup = false;
            this.cbSupervisor.IsReadOnly = true;
            this.cbSupervisor.IsRequered = false;
            this.cbSupervisor.Location = new System.Drawing.Point(142, 35);
            this.cbSupervisor.Name = "cbSupervisor";
            this.cbSupervisor.OnlyCheckBox = true;
            this.cbSupervisor.Size = new System.Drawing.Size(142, 22);
            this.cbSupervisor.TabIndex = 104;
            this.cbSupervisor.Value = null;
            this.cbSupervisor.Value2 = null;
            // 
            // comboBox1
            // 
            this.comboBox1.BtnEnabled = true;
            this.comboBox1.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.Condicao = null;
            this.comboBox1.ExecMetodo = true;
            this.comboBox1.HideFirstColumn = false;
            this.comboBox1.InvertColuna = false;
            this.comboBox1.IsLocaDs = false;
            this.comboBox1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Label1Text = "Conta ou Caixa";
            this.comboBox1.Location = new System.Drawing.Point(2, 62);
            this.comboBox1.MySQLQuerry = null;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Pp = null;
            this.comboBox1.Size = new System.Drawing.Size(186, 39);
            this.comboBox1.SqlComandText = "";
            this.comboBox1.TabIndex = 131;
            this.comboBox1.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Tb1Multiline = false;
            this.comboBox1.Text2 = null;
            this.comboBox1.Text3 = null;
            this.comboBox1.Text4 = null;
            this.comboBox1.RefreshControls += new DMZ.UI.UC.DmzProcura.Refrescar(this.comboBox2_RefreshControls);
            this.comboBox1.GetDataEvent += new DMZ.UI.UC.DmzProcura.GetData(this.comboBox1_GetDataEvent);
            // 
            // comboBox2
            // 
            this.comboBox2.BtnEnabled = true;
            this.comboBox2.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.Condicao = null;
            this.comboBox2.ExecMetodo = false;
            this.comboBox2.HideFirstColumn = false;
            this.comboBox2.InvertColuna = false;
            this.comboBox2.IsLocaDs = false;
            this.comboBox2.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.Label1Text = "Utilizador ";
            this.comboBox2.Location = new System.Drawing.Point(194, 63);
            this.comboBox2.MySQLQuerry = null;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Pp = null;
            this.comboBox2.Size = new System.Drawing.Size(298, 39);
            this.comboBox2.SqlComandText = "select Login,Nome from usr ";
            this.comboBox2.TabIndex = 132;
            this.comboBox2.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Tb1Multiline = false;
            this.comboBox2.Text2 = null;
            this.comboBox2.Text3 = null;
            this.comboBox2.Text4 = null;
            this.comboBox2.RefreshControls += new DMZ.UI.UC.DmzProcura.Refrescar(this.comboBox2_RefreshControls);
            // 
            // dmzEntreDatas1
            // 
            this.dmzEntreDatas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzEntreDatas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzEntreDatas1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzEntreDatas1.HideShowDt2 = true;
            this.dmzEntreDatas1.Label3Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzEntreDatas1.Label3ForeColor = System.Drawing.SystemColors.ControlText;
            this.dmzEntreDatas1.LabelText = "Datas de movimentos";
            this.dmzEntreDatas1.Location = new System.Drawing.Point(498, 32);
            this.dmzEntreDatas1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dmzEntreDatas1.Name = "dmzEntreDatas1";
            this.dmzEntreDatas1.Panel1BackColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzEntreDatas1.Size = new System.Drawing.Size(174, 70);
            this.dmzEntreDatas1.TabIndex = 133;
            // 
            // MenuPrint
            // 
            this.MenuPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuPrint.ContextBackcolor = System.Drawing.Color.WhiteSmoke;
            this.MenuPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MenuPrint.ForeColor = System.Drawing.Color.White;
            this.MenuPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripSeparator5,
            this.nToolStripMenuItem});
            this.MenuPrint.Name = "dmzContextMenuStrip1";
            this.MenuPrint.Size = new System.Drawing.Size(153, 54);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "IMPRIMIR POS ";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.nToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nToolStripMenuItem.Text = "IMPRIMIR A4";
            this.nToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // FrmConsultacx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(835, 484);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.dmzEntreDatas1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbSupervisor);
            this.Controls.Add(this.cbTodas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Name = "FrmConsultacx";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmConsultacx_Load);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.cbTodas, 0);
            this.Controls.SetChildIndex(this.cbSupervisor, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.dmzEntreDatas1, 0);
            this.Controls.SetChildIndex(this.btnProcessar, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.MenuPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Button btnProcessar;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Generic.GridUi gridUi1;
        private UC.CbDefault cbTodas;
        public UC.DmzProcura comboBox1;
        public UC.DmzProcura comboBox2;
        private UC.DMZEntreDatas dmzEntreDatas1;
        public UC.CbDefault cbSupervisor;
        private UC.DMZContextMenuStrip MenuPrint;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn formasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
    }
}
