namespace DMZ.UI.UI.Contabil
{
    partial class Pcdiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pcdiario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ncontDest = new System.Windows.Forms.NumericUpDown();
            this.nContOri = new System.Windows.Forms.NumericUpDown();
            this.rbPgcDiar = new DMZ.UI.UC.CbDefault();
            this.rbDiario = new DMZ.UI.UC.CbDefault();
            this.rbPgc = new DMZ.UI.UC.CbDefault();
            this.btnDell = new System.Windows.Forms.Button();
            this.radCheckBox1 = new DMZ.UI.UC.CbDefault();
            this.btnMudar = new System.Windows.Forms.Button();
            this.radCheckBox2 = new DMZ.UI.UC.CbDefault();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.ClnConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncontDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nContOri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(696, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(664, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.Text = "Criar contas e diários ";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcurar.Image = global::DMZ.UI.Properties.Resources.Search_30px;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcurar.Location = new System.Drawing.Point(594, 7);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(80, 61);
            this.btnProcurar.TabIndex = 72;
            this.btnProcurar.Text = "Procurar ";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ncontDest);
            this.panel1.Controls.Add(this.nContOri);
            this.panel1.Controls.Add(this.rbPgcDiar);
            this.panel1.Controls.Add(this.rbDiario);
            this.panel1.Controls.Add(this.rbPgc);
            this.panel1.Controls.Add(this.btnProcurar);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 76);
            this.panel1.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(312, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "Ano  destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(317, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Ano origem";
            // 
            // ncontDest
            // 
            this.ncontDest.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ncontDest.Location = new System.Drawing.Point(394, 41);
            this.ncontDest.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.ncontDest.Name = "ncontDest";
            this.ncontDest.Size = new System.Drawing.Size(97, 24);
            this.ncontDest.TabIndex = 84;
            this.ncontDest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nContOri
            // 
            this.nContOri.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.nContOri.Location = new System.Drawing.Point(394, 9);
            this.nContOri.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nContOri.Name = "nContOri";
            this.nContOri.Size = new System.Drawing.Size(97, 24);
            this.nContOri.TabIndex = 83;
            this.nContOri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbPgcDiar
            // 
            this.rbPgcDiar.BackColor = System.Drawing.Color.Transparent;
            this.rbPgcDiar.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPgcDiar.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPgcDiar.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPgcDiar.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbPgcDiar.CbText = "Plano de Contas e Diários";
            this.rbPgcDiar.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbPgcDiar.Imagem = ((System.Drawing.Image)(resources.GetObject("rbPgcDiar.Imagem")));
            this.rbPgcDiar.IsOptionGroup = false;
            this.rbPgcDiar.IsReadOnly = false;
            this.rbPgcDiar.IsRequered = false;
            this.rbPgcDiar.Location = new System.Drawing.Point(4, 51);
            this.rbPgcDiar.Name = "rbPgcDiar";
            this.rbPgcDiar.OnlyCheckBox = true;
            this.rbPgcDiar.Size = new System.Drawing.Size(206, 22);
            this.rbPgcDiar.TabIndex = 75;
            this.rbPgcDiar.Value = null;
            this.rbPgcDiar.Value2 = null;
            this.rbPgcDiar.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.rbPgcDiar_CheckedChangeds);
            // 
            // rbDiario
            // 
            this.rbDiario.BackColor = System.Drawing.Color.Transparent;
            this.rbDiario.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbDiario.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbDiario.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiario.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbDiario.CbText = "Diários";
            this.rbDiario.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbDiario.Imagem = ((System.Drawing.Image)(resources.GetObject("rbDiario.Imagem")));
            this.rbDiario.IsOptionGroup = false;
            this.rbDiario.IsReadOnly = false;
            this.rbDiario.IsRequered = false;
            this.rbDiario.Location = new System.Drawing.Point(4, -1);
            this.rbDiario.Name = "rbDiario";
            this.rbDiario.OnlyCheckBox = true;
            this.rbDiario.Size = new System.Drawing.Size(167, 22);
            this.rbDiario.TabIndex = 74;
            this.rbDiario.Value = null;
            this.rbDiario.Value2 = null;
            this.rbDiario.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.rbDiario_CheckedChangeds);
            // 
            // rbPgc
            // 
            this.rbPgc.BackColor = System.Drawing.Color.Transparent;
            this.rbPgc.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPgc.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPgc.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPgc.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbPgc.CbText = "Plano de contas ";
            this.rbPgc.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbPgc.Imagem = ((System.Drawing.Image)(resources.GetObject("rbPgc.Imagem")));
            this.rbPgc.IsOptionGroup = false;
            this.rbPgc.IsReadOnly = false;
            this.rbPgc.IsRequered = false;
            this.rbPgc.Location = new System.Drawing.Point(4, 26);
            this.rbPgc.Name = "rbPgc";
            this.rbPgc.OnlyCheckBox = true;
            this.rbPgc.Size = new System.Drawing.Size(167, 22);
            this.rbPgc.TabIndex = 73;
            this.rbPgc.Value = null;
            this.rbPgc.Value2 = null;
            this.rbPgc.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.rbPgc_CheckedChangeds);
            // 
            // btnDell
            // 
            this.btnDell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnDell.FlatAppearance.BorderSize = 0;
            this.btnDell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDell.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDell.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDell.Image = global::DMZ.UI.Properties.Resources.Trash_32px;
            this.btnDell.Location = new System.Drawing.Point(10, 487);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(39, 42);
            this.btnDell.TabIndex = 75;
            this.btnDell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDell.UseVisualStyleBackColor = false;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radCheckBox1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.radCheckBox1.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckBox1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.radCheckBox1.CbText = "Copiar os saldos ";
            this.radCheckBox1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radCheckBox1.Imagem = ((System.Drawing.Image)(resources.GetObject("radCheckBox1.Imagem")));
            this.radCheckBox1.IsOptionGroup = false;
            this.radCheckBox1.IsReadOnly = false;
            this.radCheckBox1.IsRequered = false;
            this.radCheckBox1.Location = new System.Drawing.Point(3, 0);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.OnlyCheckBox = true;
            this.radCheckBox1.Size = new System.Drawing.Size(131, 22);
            this.radCheckBox1.TabIndex = 92;
            this.radCheckBox1.Value = null;
            this.radCheckBox1.Value2 = null;
            // 
            // btnMudar
            // 
            this.btnMudar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMudar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMudar.FlatAppearance.BorderSize = 0;
            this.btnMudar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMudar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMudar.Image = global::DMZ.UI.Properties.Resources.Automatic_251px;
            this.btnMudar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMudar.Location = new System.Drawing.Point(549, 4);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(80, 57);
            this.btnMudar.TabIndex = 90;
            this.btnMudar.Text = "Processar ";
            this.btnMudar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMudar.UseVisualStyleBackColor = false;
            this.btnMudar.Click += new System.EventHandler(this.btnMudar_Click);
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox2.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radCheckBox2.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.radCheckBox2.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckBox2.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.radCheckBox2.CbText = "Copiar todas contas ou diários ";
            this.radCheckBox2.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radCheckBox2.Imagem = ((System.Drawing.Image)(resources.GetObject("radCheckBox2.Imagem")));
            this.radCheckBox2.IsOptionGroup = false;
            this.radCheckBox2.IsReadOnly = false;
            this.radCheckBox2.IsRequered = false;
            this.radCheckBox2.Location = new System.Drawing.Point(3, 20);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.OnlyCheckBox = true;
            this.radCheckBox2.Size = new System.Drawing.Size(241, 22);
            this.radCheckBox2.TabIndex = 91;
            this.radCheckBox2.Value = null;
            this.radCheckBox2.Value2 = null;
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            this.gridUi1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.Color.White;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnConta,
            this.descricao});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUi1.GridFilha = true;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(10, 115);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUi1.Size = new System.Drawing.Size(677, 366);
            this.gridUi1.StampCabecalho = "Dcstamp";
            this.gridUi1.StampLocal = "Dclistamp";
            this.gridUi1.TabelaSql = "Dcli";
            this.gridUi1.TabIndex = 89;
            this.gridUi1.TbCodigo = null;
            // 
            // ClnConta
            // 
            this.ClnConta.DataPropertyName = "codigo";
            this.ClnConta.HeaderText = "Código";
            this.ClnConta.MinimumWidth = 100;
            this.ClnConta.Name = "ClnConta";
            this.ClnConta.Width = 150;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 150;
            this.descricao.Name = "descricao";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblMensagem);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.radCheckBox1);
            this.panel2.Controls.Add(this.btnMudar);
            this.panel2.Controls.Add(this.radCheckBox2);
            this.panel2.Location = new System.Drawing.Point(55, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 68);
            this.panel2.TabIndex = 93;
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMensagem.Location = new System.Drawing.Point(240, 40);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(254, 24);
            this.lblMensagem.TabIndex = 460;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(239, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(255, 30);
            this.progressBar1.TabIndex = 459;
            // 
            // Pcdiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(697, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridUi1);
            this.Controls.Add(this.btnDell);
            this.Controls.Add(this.panel1);
            this.Name = "Pcdiario";
            this.Load += new System.EventHandler(this.Pcdiario_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnDell, 0);
            this.Controls.SetChildIndex(this.gridUi1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncontDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nContOri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Panel panel1;
        private UC.CbDefault rbPgcDiar;
        private UC.CbDefault rbDiario;
        private UC.CbDefault rbPgc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ncontDest;
        private System.Windows.Forms.NumericUpDown nContOri;
        public System.Windows.Forms.Button btnDell;
        private UC.CbDefault radCheckBox1;
        public System.Windows.Forms.Button btnMudar;
        private UC.CbDefault radCheckBox2;
        private Generic.GridUi gridUi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblMensagem;
    }
}
