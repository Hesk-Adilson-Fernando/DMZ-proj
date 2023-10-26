namespace DMZ.UI.UI.Contabil
{
    partial class FrmBalanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBalanco));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radOpSaldo = new System.Windows.Forms.GroupBox();
            this.rbSsaldosPer = new DMZ.UI.UC.CbDefault();
            this.rbSsaldosAc = new DMZ.UI.UC.CbDefault();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ContaFim = new System.Windows.Forms.NumericUpDown();
            this.ContaInicio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDoisDigitos = new DMZ.UI.UC.CbDefault();
            this.ContasMov = new DMZ.UI.UC.CbDefault();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mesFim = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.mesInicio = new System.Windows.Forms.NumericUpDown();
            this.cbIntegApenas = new DMZ.UI.UC.CbDefault();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gridContas = new DMZ.UI.Generic.GridUi();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.integracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbProcura = new System.Windows.Forms.TextBox();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.radOpSaldo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContaFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContaInicio)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesInicio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Size = new System.Drawing.Size(781, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(749, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.Text = "BALANÇO";
            // 
            // radOpSaldo
            // 
            this.radOpSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radOpSaldo.Controls.Add(this.rbSsaldosPer);
            this.radOpSaldo.Controls.Add(this.rbSsaldosAc);
            this.radOpSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radOpSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radOpSaldo.Location = new System.Drawing.Point(473, 3);
            this.radOpSaldo.Name = "radOpSaldo";
            this.radOpSaldo.Size = new System.Drawing.Size(172, 103);
            this.radOpSaldo.TabIndex = 456;
            this.radOpSaldo.TabStop = false;
            this.radOpSaldo.Text = "Opções de saldo";
            // 
            // rbSsaldosPer
            // 
            this.rbSsaldosPer.BackColor = System.Drawing.Color.Transparent;
            this.rbSsaldosPer.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSsaldosPer.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSsaldosPer.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSsaldosPer.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbSsaldosPer.CbText = "Só saldo do período";
            this.rbSsaldosPer.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbSsaldosPer.Imagem = ((System.Drawing.Image)(resources.GetObject("rbSsaldosPer.Imagem")));
            this.rbSsaldosPer.IsOptionGroup = false;
            this.rbSsaldosPer.IsReadOnly = false;
            this.rbSsaldosPer.IsRequered = false;
            this.rbSsaldosPer.Location = new System.Drawing.Point(6, 50);
            this.rbSsaldosPer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSsaldosPer.Name = "rbSsaldosPer";
            this.rbSsaldosPer.OnlyCheckBox = true;
            this.rbSsaldosPer.Size = new System.Drawing.Size(249, 27);
            this.rbSsaldosPer.TabIndex = 497;
            this.rbSsaldosPer.Value = null;
            this.rbSsaldosPer.Value2 = null;
            // 
            // rbSsaldosAc
            // 
            this.rbSsaldosAc.BackColor = System.Drawing.Color.Transparent;
            this.rbSsaldosAc.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSsaldosAc.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSsaldosAc.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSsaldosAc.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbSsaldosAc.CbText = "Só os saldos acumulados ";
            this.rbSsaldosAc.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbSsaldosAc.Imagem = ((System.Drawing.Image)(resources.GetObject("rbSsaldosAc.Imagem")));
            this.rbSsaldosAc.IsOptionGroup = false;
            this.rbSsaldosAc.IsReadOnly = false;
            this.rbSsaldosAc.IsRequered = false;
            this.rbSsaldosAc.Location = new System.Drawing.Point(6, 24);
            this.rbSsaldosAc.Name = "rbSsaldosAc";
            this.rbSsaldosAc.OnlyCheckBox = true;
            this.rbSsaldosAc.Size = new System.Drawing.Size(249, 22);
            this.rbSsaldosAc.TabIndex = 496;
            this.rbSsaldosAc.Value = null;
            this.rbSsaldosAc.Value2 = null;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tbDoisDigitos);
            this.groupBox1.Controls.Add(this.ContasMov);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbIntegApenas);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 106);
            this.groupBox1.TabIndex = 458;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ContaFim);
            this.groupBox3.Controls.Add(this.ContaInicio);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 45);
            this.groupBox3.TabIndex = 504;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conta(s)";
            // 
            // ContaFim
            // 
            this.ContaFim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContaFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ContaFim.Location = new System.Drawing.Point(139, 20);
            this.ContaFim.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.ContaFim.Name = "ContaFim";
            this.ContaFim.Size = new System.Drawing.Size(94, 20);
            this.ContaFim.TabIndex = 502;
            // 
            // ContaInicio
            // 
            this.ContaInicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ContaInicio.Location = new System.Drawing.Point(6, 20);
            this.ContaInicio.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.ContaInicio.Name = "ContaInicio";
            this.ContaInicio.Size = new System.Drawing.Size(94, 20);
            this.ContaInicio.TabIndex = 501;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(106, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 499;
            this.label2.Text = "até";
            // 
            // tbDoisDigitos
            // 
            this.tbDoisDigitos.BackColor = System.Drawing.Color.Transparent;
            this.tbDoisDigitos.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDoisDigitos.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDoisDigitos.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDoisDigitos.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDoisDigitos.CbText = "Só contas de dois dígitos";
            this.tbDoisDigitos.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbDoisDigitos.Imagem = ((System.Drawing.Image)(resources.GetObject("tbDoisDigitos.Imagem")));
            this.tbDoisDigitos.IsOptionGroup = false;
            this.tbDoisDigitos.IsReadOnly = false;
            this.tbDoisDigitos.IsRequered = false;
            this.tbDoisDigitos.Location = new System.Drawing.Point(245, 59);
            this.tbDoisDigitos.Name = "tbDoisDigitos";
            this.tbDoisDigitos.OnlyCheckBox = true;
            this.tbDoisDigitos.Size = new System.Drawing.Size(207, 22);
            this.tbDoisDigitos.TabIndex = 503;
            this.tbDoisDigitos.Value = null;
            this.tbDoisDigitos.Value2 = null;
            // 
            // ContasMov
            // 
            this.ContasMov.BackColor = System.Drawing.Color.Transparent;
            this.ContasMov.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContasMov.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ContasMov.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContasMov.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.ContasMov.CbText = "Só contas movimentadas";
            this.ContasMov.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContasMov.Imagem = ((System.Drawing.Image)(resources.GetObject("ContasMov.Imagem")));
            this.ContasMov.IsOptionGroup = false;
            this.ContasMov.IsReadOnly = false;
            this.ContasMov.IsRequered = false;
            this.ContasMov.Location = new System.Drawing.Point(245, 34);
            this.ContasMov.Name = "ContasMov";
            this.ContasMov.OnlyCheckBox = true;
            this.ContasMov.Size = new System.Drawing.Size(207, 22);
            this.ContasMov.TabIndex = 502;
            this.ContasMov.Value = null;
            this.ContasMov.Value2 = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mesFim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mesInicio);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 45);
            this.groupBox2.TabIndex = 499;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mes(s)";
            // 
            // mesFim
            // 
            this.mesFim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mesFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mesFim.Location = new System.Drawing.Point(98, 19);
            this.mesFim.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.mesFim.Name = "mesFim";
            this.mesFim.Size = new System.Drawing.Size(53, 20);
            this.mesFim.TabIndex = 500;
            this.mesFim.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(65, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 499;
            this.label3.Text = "até";
            // 
            // mesInicio
            // 
            this.mesInicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mesInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mesInicio.Location = new System.Drawing.Point(6, 19);
            this.mesInicio.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.mesInicio.Name = "mesInicio";
            this.mesInicio.Size = new System.Drawing.Size(53, 20);
            this.mesInicio.TabIndex = 499;
            this.mesInicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbIntegApenas
            // 
            this.cbIntegApenas.BackColor = System.Drawing.Color.Transparent;
            this.cbIntegApenas.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIntegApenas.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIntegApenas.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIntegApenas.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbIntegApenas.CbText = "Apenas contas de Integração";
            this.cbIntegApenas.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIntegApenas.Imagem = ((System.Drawing.Image)(resources.GetObject("cbIntegApenas.Imagem")));
            this.cbIntegApenas.IsOptionGroup = false;
            this.cbIntegApenas.IsReadOnly = false;
            this.cbIntegApenas.IsRequered = false;
            this.cbIntegApenas.Location = new System.Drawing.Point(245, 82);
            this.cbIntegApenas.Name = "cbIntegApenas";
            this.cbIntegApenas.OnlyCheckBox = true;
            this.cbIntegApenas.Size = new System.Drawing.Size(249, 22);
            this.cbIntegApenas.TabIndex = 495;
            this.cbIntegApenas.Value = null;
            this.cbIntegApenas.Value2 = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProcessar);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.radOpSaldo);
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 114);
            this.panel1.TabIndex = 480;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessar.FlatAppearance.BorderSize = 0;
            this.btnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.Location = new System.Drawing.Point(660, 37);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(104, 32);
            this.btnProcessar.TabIndex = 459;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(660, 74);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 32);
            this.btnPrint.TabIndex = 82;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridContas
            // 
            this.gridContas.AddButtons = false;
            this.gridContas.AllowUserToAddRows = false;
            this.gridContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridContas.AutoIncrimento = false;
            this.gridContas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridContas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridContas.CampoCodigo = null;
            this.gridContas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridContas.Codigo = null;
            this.gridContas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridContas.ColumnHeadersHeight = 30;
            this.gridContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conta,
            this.descricao1,
            this.saldo,
            this.integracao,
            this.Titulo});
            this.gridContas.Condicao = null;
            this.gridContas.CorPreto = true;
            this.gridContas.CurrentColumnName = null;
            this.gridContas.DefacolumnName = null;
            this.gridContas.DellGridRow = null;
            this.gridContas.DtDS = null;
            this.gridContas.EnableHeadersVisualStyles = false;
            this.gridContas.GenerateColumns = false;
            this.gridContas.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.gridContas.GridFilha = true;
            this.gridContas.GridFilhaSecundaria = false;
            this.gridContas.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridContas.HeadersHeight = 30;
            this.gridContas.HeadersVisible = false;
            this.gridContas.Location = new System.Drawing.Point(2, 182);
            this.gridContas.Name = "gridContas";
            this.gridContas.OrderbyCampos = null;
            this.gridContas.Origem = null;
            this.gridContas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridContas.RowHeadersVisible = false;
            this.gridContas.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridContas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContas.Size = new System.Drawing.Size(772, 377);
            this.gridContas.StampCabecalho = "Ststamp";
            this.gridContas.StampLocal = "StPrecostamp";
            this.gridContas.TabelaSql = "StPrecos";
            this.gridContas.TabIndex = 486;
            this.gridContas.TbCodigo = null;
            this.gridContas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridContas_CellFormatting);
            // 
            // conta
            // 
            this.conta.DataPropertyName = "conta";
            this.conta.HeaderText = "Conta";
            this.conta.Name = "conta";
            this.conta.Width = 130;
            // 
            // descricao1
            // 
            this.descricao1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao1.DataPropertyName = "descricao";
            this.descricao1.HeaderText = "Descricao";
            this.descricao1.Name = "descricao1";
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.saldo.DefaultCellStyle = dataGridViewCellStyle2;
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.Width = 150;
            // 
            // integracao
            // 
            this.integracao.DataPropertyName = "integracao";
            this.integracao.HeaderText = "integracao";
            this.integracao.Name = "integracao";
            this.integracao.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(133, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(481, 23);
            this.textBox1.TabIndex = 488;
            // 
            // tbProcura
            // 
            this.tbProcura.BackColor = System.Drawing.Color.Snow;
            this.tbProcura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProcura.Location = new System.Drawing.Point(2, 157);
            this.tbProcura.Name = "tbProcura";
            this.tbProcura.Size = new System.Drawing.Size(129, 23);
            this.tbProcura.TabIndex = 487;
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.Image = global::DMZ.UI.Properties.Resources.Maximize_Window_25px;
            this.btnMaxMin.Location = new System.Drawing.Point(720, 2);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 90;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 562);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(780, 5);
            this.panel6.TabIndex = 489;
            // 
            // FrmBalanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 567);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbProcura);
            this.Controls.Add(this.gridContas);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBalanco";
            this.Text = "frmBalanco";
            this.Load += new System.EventHandler(this.frmBalanco_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridContas, 0);
            this.Controls.SetChildIndex(this.tbProcura, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.radOpSaldo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContaFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContaInicio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesInicio)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox radOpSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private UC.CbDefault cbIntegApenas;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnPrint;
        private UC.CbDefault rbSsaldosPer;
        private UC.CbDefault rbSsaldosAc;
        public System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown mesFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown mesInicio;
        private Generic.GridUi gridContas;
        private UC.CbDefault tbDoisDigitos;
        private UC.CbDefault ContasMov;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbProcura;
        public System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn integracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown ContaFim;
        private System.Windows.Forms.NumericUpDown ContaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
    }
}