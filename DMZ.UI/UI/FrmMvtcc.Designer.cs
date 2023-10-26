namespace DMZ.UI.UI
{
    partial class FrmMvtcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMvtcc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem = new System.Windows.Forms.DataGridViewImageColumn();
            this.Origem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.cbConta = new System.Windows.Forms.ComboBox();
            this.cbTodas = new DMZ.UI.UC.CbDefault();
            this.cbSaldoanterior = new DMZ.UI.UC.CbDefault();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMoedaNacional = new DMZ.UI.UC.CbDefault();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(970, 27);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMZ.UI.Properties.Resources.Accounting_22px;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(944, 1);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(254, 17);
            this.label1.Text = "Extracto de Movimentos de Tesouraria";
            // 
            // gridPanel21
            // 
            this.gridPanel21.AddControls = false;
            this.gridPanel21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel21.Callform = false;
            this.gridPanel21.Controls.Add(this.gridUi1);
            this.gridPanel21.DefaultColumn = null;
            this.gridPanel21.Gridnome = "gridUi1";
            this.gridPanel21.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.Label1Color = System.Drawing.Color.White;
            this.gridPanel21.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel21.Label1Text = "Extrato da Conta";
            this.gridPanel21.Location = new System.Drawing.Point(6, 73);
            this.gridPanel21.MostraGravar = false;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("gridPanel21.PictureBox1Image")));
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(960, 446);
            this.gridPanel21.TabIndex = 25;
            this.gridPanel21.TipoMenu = true;
            this.gridPanel21.UsaNomeGrid = false;
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            this.gridUi1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.Color.White;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.numero,
            this.banco,
            this.Emissao,
            this.Documento,
            this.nrdoc,
            this.entrada,
            this.saida,
            this.Saldo,
            this.ordem,
            this.Entidade,
            this.Origem,
            this.Origem2,
            this.localstamp});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.gridUi1.GridFilha = false;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(0, 26);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.ReadOnly = true;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridUi1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi1.Size = new System.Drawing.Size(960, 417);
            this.gridUi1.StampCabecalho = null;
            this.gridUi1.StampLocal = null;
            this.gridUi1.TabelaSql = null;
            this.gridUi1.TabIndex = 0;
            this.gridUi1.TbCodigo = null;
            this.gridUi1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellClick);
            this.gridUi1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridUi1_CellFormatting);
            this.gridUi1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridUi1_CellPainting);
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Tipo de movimento";
            this.Titulo.MinimumWidth = 150;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numtitulo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.numero.DefaultCellStyle = dataGridViewCellStyle3;
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Visible = false;
            this.numero.Width = 60;
            // 
            // banco
            // 
            this.banco.DataPropertyName = "Banco";
            this.banco.HeaderText = "Banco";
            this.banco.Name = "banco";
            this.banco.ReadOnly = true;
            // 
            // Emissao
            // 
            this.Emissao.DataPropertyName = "data";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Emissao.DefaultCellStyle = dataGridViewCellStyle4;
            this.Emissao.HeaderText = "Emissão";
            this.Emissao.Name = "Emissao";
            this.Emissao.ReadOnly = true;
            this.Emissao.Width = 80;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // nrdoc
            // 
            this.nrdoc.DataPropertyName = "nrdoc";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.nrdoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.nrdoc.HeaderText = "Nº Doc.";
            this.nrdoc.Name = "nrdoc";
            this.nrdoc.ReadOnly = true;
            this.nrdoc.Width = 70;
            // 
            // entrada
            // 
            this.entrada.DataPropertyName = "entrada";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.entrada.DefaultCellStyle = dataGridViewCellStyle6;
            this.entrada.HeaderText = "Entrada";
            this.entrada.Name = "entrada";
            this.entrada.ReadOnly = true;
            // 
            // saida
            // 
            this.saida.DataPropertyName = "saida";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.saida.DefaultCellStyle = dataGridViewCellStyle7;
            this.saida.HeaderText = "Saída";
            this.saida.Name = "saida";
            this.saida.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "saldo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0";
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle8;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // ordem
            // 
            this.ordem.DataPropertyName = "ordem";
            this.ordem.HeaderText = "ordem";
            this.ordem.Name = "ordem";
            this.ordem.ReadOnly = true;
            this.ordem.Visible = false;
            // 
            // Entidade
            // 
            this.Entidade.DataPropertyName = "descricao";
            this.Entidade.HeaderText = "Entidade";
            this.Entidade.Name = "Entidade";
            this.Entidade.ReadOnly = true;
            // 
            // Origem
            // 
            this.Origem.HeaderText = ".....";
            this.Origem.Image = global::DMZ.UI.Properties.Resources.Right_28px;
            this.Origem.Name = "Origem";
            this.Origem.ReadOnly = true;
            this.Origem.ToolTipText = "Ver Documento que gerou o movimento";
            this.Origem.Width = 30;
            // 
            // Origem2
            // 
            this.Origem2.DataPropertyName = "origem";
            this.Origem2.HeaderText = "Origem";
            this.Origem2.Name = "Origem2";
            this.Origem2.ReadOnly = true;
            this.Origem2.Visible = false;
            // 
            // localstamp
            // 
            this.localstamp.DataPropertyName = "localstamp";
            this.localstamp.HeaderText = "localstamp";
            this.localstamp.Name = "localstamp";
            this.localstamp.ReadOnly = true;
            this.localstamp.Visible = false;
            // 
            // dtpData2
            // 
            this.dtpData2.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData2.Location = new System.Drawing.Point(730, 48);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(96, 21);
            this.dtpData2.TabIndex = 82;
            // 
            // dtpData1
            // 
            this.dtpData1.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData1.Location = new System.Drawing.Point(628, 48);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(96, 21);
            this.dtpData1.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Conta Tesouraria ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(731, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Término";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(629, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Início";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_20px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(931, 33);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(35, 35);
            this.btnPrint.TabIndex = 95;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Sync_Settings_20px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.Location = new System.Drawing.Point(829, 33);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(101, 35);
            this.btnProcessar.TabIndex = 94;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // cbConta
            // 
            this.cbConta.FormattingEnabled = true;
            this.cbConta.Location = new System.Drawing.Point(6, 48);
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(168, 21);
            this.cbConta.TabIndex = 96;
            // 
            // cbTodas
            // 
            this.cbTodas.BackColor = System.Drawing.Color.Transparent;
            this.cbTodas.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTodas.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTodas.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbTodas.CbText = "Todas contas ";
            this.cbTodas.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTodas.Imagem = ((System.Drawing.Image)(resources.GetObject("cbTodas.Imagem")));
            this.cbTodas.IsOptionGroup = false;
            this.cbTodas.IsReadOnly = false;
            this.cbTodas.IsRequered = false;
            this.cbTodas.Location = new System.Drawing.Point(3, 3);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.OnlyCheckBox = true;
            this.cbTodas.Size = new System.Drawing.Size(148, 22);
            this.cbTodas.TabIndex = 97;
            this.cbTodas.Value = null;
            this.cbTodas.Value2 = null;
            // 
            // cbSaldoanterior
            // 
            this.cbSaldoanterior.BackColor = System.Drawing.Color.Transparent;
            this.cbSaldoanterior.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSaldoanterior.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSaldoanterior.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaldoanterior.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbSaldoanterior.CbText = "Incluir saldos anteriores";
            this.cbSaldoanterior.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSaldoanterior.Imagem = ((System.Drawing.Image)(resources.GetObject("cbSaldoanterior.Imagem")));
            this.cbSaldoanterior.IsOptionGroup = false;
            this.cbSaldoanterior.IsReadOnly = false;
            this.cbSaldoanterior.IsRequered = false;
            this.cbSaldoanterior.Location = new System.Drawing.Point(119, 3);
            this.cbSaldoanterior.Name = "cbSaldoanterior";
            this.cbSaldoanterior.OnlyCheckBox = true;
            this.cbSaldoanterior.Size = new System.Drawing.Size(182, 22);
            this.cbSaldoanterior.TabIndex = 98;
            this.cbSaldoanterior.Value = null;
            this.cbSaldoanterior.Value2 = null;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbMoedaNacional);
            this.panel1.Controls.Add(this.cbSaldoanterior);
            this.panel1.Controls.Add(this.cbTodas);
            this.panel1.Location = new System.Drawing.Point(180, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 32);
            this.panel1.TabIndex = 97;
            // 
            // cbMoedaNacional
            // 
            this.cbMoedaNacional.BackColor = System.Drawing.Color.Transparent;
            this.cbMoedaNacional.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMoedaNacional.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMoedaNacional.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoedaNacional.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbMoedaNacional.CbText = "Moeda Nacional ";
            this.cbMoedaNacional.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbMoedaNacional.Imagem = ((System.Drawing.Image)(resources.GetObject("cbMoedaNacional.Imagem")));
            this.cbMoedaNacional.IsOptionGroup = false;
            this.cbMoedaNacional.IsReadOnly = false;
            this.cbMoedaNacional.IsRequered = false;
            this.cbMoedaNacional.Location = new System.Drawing.Point(294, 3);
            this.cbMoedaNacional.Name = "cbMoedaNacional";
            this.cbMoedaNacional.OnlyCheckBox = true;
            this.cbMoedaNacional.Size = new System.Drawing.Size(148, 22);
            this.cbMoedaNacional.TabIndex = 99;
            this.cbMoedaNacional.Value = null;
            this.cbMoedaNacional.Value2 = null;
            this.cbMoedaNacional.Visible = false;
            // 
            // FrmMvtcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(971, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbConta);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.dtpData1);
            this.Controls.Add(this.dtpData2);
            this.Controls.Add(this.gridPanel21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FrmMvtcc";
            this.Text = "Extracto de Movimentos de Tesouraria";
            this.Load += new System.EventHandler(this.FrmMvtcc_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.gridPanel21, 0);
            this.Controls.SetChildIndex(this.dtpData2, 0);
            this.Controls.SetChildIndex(this.dtpData1, 0);
            this.Controls.SetChildIndex(this.btnProcessar, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.cbConta, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.GridPanel2 gridPanel21;
        private Generic.GridUi gridUi1;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Button btnProcessar;
        private UC.CbDefault cbTodas;
        public System.Windows.Forms.ComboBox cbConta;
        private UC.CbDefault cbSaldoanterior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidade;
        private System.Windows.Forms.DataGridViewImageColumn Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn localstamp;
        private UC.CbDefault cbMoedaNacional;
    }
}
