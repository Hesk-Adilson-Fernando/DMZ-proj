namespace DMZ.UI.UI.Contabil
{
    partial class Balancete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balancete));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barraText3 = new DMZ.UI.UC.BarraText();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ApuraRes = new DMZ.UI.UC.CbDefault();
            this.cbApuraIva = new DMZ.UI.UC.CbDefault();
            this.SaldAcumPer = new DMZ.UI.UC.CbDefault();
            this.rbSsaldosAc = new DMZ.UI.UC.CbDefault();
            this.panel3 = new System.Windows.Forms.Panel();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDoisDigitos = new DMZ.UI.UC.CbDefault();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Entrecontas = new DMZ.UI.UC.CbDefault();
            this.ContaFim = new System.Windows.Forms.NumericUpDown();
            this.ContaInicio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nrAno = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mesFim = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.mesInicio = new System.Windows.Forms.NumericUpDown();
            this.ContasMov = new DMZ.UI.UC.CbDefault();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gridContas = new DMZ.UI.Generic.GridUi();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbProcura = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debitosaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credsaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContaFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContaInicio)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrAno)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Size = new System.Drawing.Size(923, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(891, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.Text = "Balancetes Contabilísticos ";
            // 
            // barraText3
            // 
            this.barraText3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraText3.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText3.Label1ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.barraText3.Label1Text = "Opções avançadas";
            this.barraText3.Location = new System.Drawing.Point(561, 3);
            this.barraText3.Name = "barraText3";
            this.barraText3.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText3.PictureBox1Image = global::DMZ.UI.Properties.Resources.Caixa_25px;
            this.barraText3.Size = new System.Drawing.Size(246, 30);
            this.barraText3.TabIndex = 88;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.groupBox4);
            this.panel8.Location = new System.Drawing.Point(563, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(240, 112);
            this.panel8.TabIndex = 87;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ApuraRes);
            this.groupBox4.Controls.Add(this.cbApuraIva);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.groupBox4.Location = new System.Drawing.Point(3, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 97);
            this.groupBox4.TabIndex = 499;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exclusões";
            // 
            // ApuraRes
            // 
            this.ApuraRes.BackColor = System.Drawing.Color.Transparent;
            this.ApuraRes.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApuraRes.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.ApuraRes.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApuraRes.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.ApuraRes.CbText = " Exclui movimentos de apuram. Res";
            this.ApuraRes.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApuraRes.Imagem = ((System.Drawing.Image)(resources.GetObject("ApuraRes.Imagem")));
            this.ApuraRes.IsOptionGroup = false;
            this.ApuraRes.IsReadOnly = false;
            this.ApuraRes.IsRequered = false;
            this.ApuraRes.Location = new System.Drawing.Point(7, 68);
            this.ApuraRes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApuraRes.Name = "ApuraRes";
            this.ApuraRes.OnlyCheckBox = true;
            this.ApuraRes.Size = new System.Drawing.Size(270, 25);
            this.ApuraRes.TabIndex = 106;
            this.ApuraRes.Value = "";
            this.ApuraRes.Value2 = null;
            this.ApuraRes.Load += new System.EventHandler(this.cbDefault1_Load);
            // 
            // cbApuraIva
            // 
            this.cbApuraIva.BackColor = System.Drawing.Color.Transparent;
            this.cbApuraIva.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbApuraIva.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbApuraIva.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApuraIva.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbApuraIva.CbText = " Exclui movimentos de apuram. IVA";
            this.cbApuraIva.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbApuraIva.Imagem = ((System.Drawing.Image)(resources.GetObject("cbApuraIva.Imagem")));
            this.cbApuraIva.IsOptionGroup = false;
            this.cbApuraIva.IsReadOnly = false;
            this.cbApuraIva.IsRequered = false;
            this.cbApuraIva.Location = new System.Drawing.Point(7, 40);
            this.cbApuraIva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbApuraIva.Name = "cbApuraIva";
            this.cbApuraIva.OnlyCheckBox = true;
            this.cbApuraIva.Size = new System.Drawing.Size(270, 25);
            this.cbApuraIva.TabIndex = 105;
            this.cbApuraIva.Value = "";
            this.cbApuraIva.Value2 = null;
            // 
            // SaldAcumPer
            // 
            this.SaldAcumPer.BackColor = System.Drawing.Color.Transparent;
            this.SaldAcumPer.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaldAcumPer.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.SaldAcumPer.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldAcumPer.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.SaldAcumPer.CbText = "Saldos do período e acumulados";
            this.SaldAcumPer.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaldAcumPer.Imagem = ((System.Drawing.Image)(resources.GetObject("SaldAcumPer.Imagem")));
            this.SaldAcumPer.IsOptionGroup = false;
            this.SaldAcumPer.IsReadOnly = false;
            this.SaldAcumPer.IsRequered = false;
            this.SaldAcumPer.Location = new System.Drawing.Point(216, 30);
            this.SaldAcumPer.Name = "SaldAcumPer";
            this.SaldAcumPer.OnlyCheckBox = true;
            this.SaldAcumPer.Size = new System.Drawing.Size(231, 22);
            this.SaldAcumPer.TabIndex = 104;
            this.SaldAcumPer.Value = "";
            this.SaldAcumPer.Value2 = null;
            this.SaldAcumPer.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.rbSaldAcumPer_CheckedChangeds);
            // 
            // rbSsaldosAc
            // 
            this.rbSsaldosAc.BackColor = System.Drawing.Color.Transparent;
            this.rbSsaldosAc.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSsaldosAc.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSsaldosAc.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSsaldosAc.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbSsaldosAc.CbText = "Só os saldos do período";
            this.rbSsaldosAc.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbSsaldosAc.Imagem = ((System.Drawing.Image)(resources.GetObject("rbSsaldosAc.Imagem")));
            this.rbSsaldosAc.IsOptionGroup = false;
            this.rbSsaldosAc.IsReadOnly = false;
            this.rbSsaldosAc.IsRequered = false;
            this.rbSsaldosAc.Location = new System.Drawing.Point(216, 6);
            this.rbSsaldosAc.Name = "rbSsaldosAc";
            this.rbSsaldosAc.OnlyCheckBox = true;
            this.rbSsaldosAc.Size = new System.Drawing.Size(172, 22);
            this.rbSsaldosAc.TabIndex = 101;
            this.rbSsaldosAc.Value = "";
            this.rbSsaldosAc.Value2 = null;
            this.rbSsaldosAc.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.rbSsaldosAc_CheckedChangeds);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.barraText1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnProcessar);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.barraText3);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Location = new System.Drawing.Point(3, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 147);
            this.panel3.TabIndex = 483;
            // 
            // barraText1
            // 
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.barraText1.Label1Text = "Filtagem de dados ";
            this.barraText1.Location = new System.Drawing.Point(8, 3);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText1.PictureBox1Image = global::DMZ.UI.Properties.Resources.Forward_20px;
            this.barraText1.Size = new System.Drawing.Size(553, 30);
            this.barraText1.TabIndex = 461;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbDoisDigitos);
            this.panel1.Controls.Add(this.SaldAcumPer);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.rbSsaldosAc);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ContasMov);
            this.panel1.Location = new System.Drawing.Point(10, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 112);
            this.panel1.TabIndex = 460;
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
            this.tbDoisDigitos.Location = new System.Drawing.Point(3, 6);
            this.tbDoisDigitos.Name = "tbDoisDigitos";
            this.tbDoisDigitos.OnlyCheckBox = true;
            this.tbDoisDigitos.Size = new System.Drawing.Size(207, 22);
            this.tbDoisDigitos.TabIndex = 501;
            this.tbDoisDigitos.Value = null;
            this.tbDoisDigitos.Value2 = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Entrecontas);
            this.groupBox3.Controls.Add(this.ContaFim);
            this.groupBox3.Controls.Add(this.ContaInicio);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.groupBox3.Location = new System.Drawing.Point(3, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 45);
            this.groupBox3.TabIndex = 500;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conta(s)";
            // 
            // Entrecontas
            // 
            this.Entrecontas.BackColor = System.Drawing.Color.Transparent;
            this.Entrecontas.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Entrecontas.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.Entrecontas.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrecontas.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Entrecontas.CbText = "";
            this.Entrecontas.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Entrecontas.Imagem = ((System.Drawing.Image)(resources.GetObject("Entrecontas.Imagem")));
            this.Entrecontas.IsOptionGroup = false;
            this.Entrecontas.IsReadOnly = false;
            this.Entrecontas.IsRequered = false;
            this.Entrecontas.Location = new System.Drawing.Point(-2, 15);
            this.Entrecontas.Name = "Entrecontas";
            this.Entrecontas.OnlyCheckBox = true;
            this.Entrecontas.Size = new System.Drawing.Size(30, 25);
            this.Entrecontas.TabIndex = 502;
            this.Entrecontas.Value = null;
            this.Entrecontas.Value2 = null;
            // 
            // ContaFim
            // 
            this.ContaFim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContaFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ContaFim.Location = new System.Drawing.Point(155, 20);
            this.ContaFim.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.ContaFim.Name = "ContaFim";
            this.ContaFim.Size = new System.Drawing.Size(90, 20);
            this.ContaFim.TabIndex = 502;
            this.ContaFim.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // ContaInicio
            // 
            this.ContaInicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ContaInicio.Location = new System.Drawing.Point(32, 20);
            this.ContaInicio.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.ContaInicio.Name = "ContaInicio";
            this.ContaInicio.Size = new System.Drawing.Size(90, 20);
            this.ContaInicio.TabIndex = 501;
            this.ContaInicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(125, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 499;
            this.label2.Text = "até";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nrAno);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.groupBox2.Location = new System.Drawing.Point(423, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 45);
            this.groupBox2.TabIndex = 499;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ano contabilístico";
            // 
            // nrAno
            // 
            this.nrAno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nrAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nrAno.Location = new System.Drawing.Point(6, 20);
            this.nrAno.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nrAno.Name = "nrAno";
            this.nrAno.Size = new System.Drawing.Size(53, 20);
            this.nrAno.TabIndex = 496;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mesFim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mesInicio);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.groupBox1.Location = new System.Drawing.Point(262, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 45);
            this.groupBox1.TabIndex = 498;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes(s)";
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
            this.ContasMov.Location = new System.Drawing.Point(3, 30);
            this.ContasMov.Name = "ContasMov";
            this.ContasMov.OnlyCheckBox = true;
            this.ContasMov.Size = new System.Drawing.Size(207, 22);
            this.ContasMov.TabIndex = 493;
            this.ContasMov.Value = null;
            this.ContasMov.Value2 = null;
            this.ContasMov.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.ContasMov_CheckedChangeds);
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
            this.btnProcessar.Location = new System.Drawing.Point(811, 72);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(97, 32);
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
            this.btnPrint.Location = new System.Drawing.Point(811, 108);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 32);
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
            this.descricao,
            this.deb,
            this.Cre,
            this.Debitosaldo,
            this.Credsaldo});
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
            this.gridContas.Location = new System.Drawing.Point(3, 211);
            this.gridContas.Name = "gridContas";
            this.gridContas.OrderbyCampos = null;
            this.gridContas.Origem = null;
            this.gridContas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridContas.RowHeadersVisible = false;
            this.gridContas.RowHeadersWidth = 30;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gridContas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContas.Size = new System.Drawing.Size(917, 336);
            this.gridContas.StampCabecalho = "Ststamp";
            this.gridContas.StampLocal = "StPrecostamp";
            this.gridContas.TabelaSql = "StPrecos";
            this.gridContas.TabIndex = 485;
            this.gridContas.TbCodigo = null;
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
            this.btnMaxMin.Location = new System.Drawing.Point(866, 2);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 89;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(136, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 23);
            this.textBox1.TabIndex = 487;
            // 
            // tbProcura
            // 
            this.tbProcura.BackColor = System.Drawing.Color.Snow;
            this.tbProcura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProcura.Location = new System.Drawing.Point(3, 186);
            this.tbProcura.Name = "tbProcura";
            this.tbProcura.Size = new System.Drawing.Size(129, 23);
            this.tbProcura.TabIndex = 486;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 552);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(924, 5);
            this.panel6.TabIndex = 490;
            // 
            // conta
            // 
            this.conta.DataPropertyName = "conta";
            this.conta.HeaderText = "Conta";
            this.conta.Name = "conta";
            this.conta.Width = 130;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // deb
            // 
            this.deb.DataPropertyName = "deb";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.deb.DefaultCellStyle = dataGridViewCellStyle2;
            this.deb.HeaderText = "Débito";
            this.deb.Name = "deb";
            this.deb.Width = 120;
            // 
            // Cre
            // 
            this.Cre.DataPropertyName = "cre";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Cre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cre.HeaderText = "Crédito";
            this.Cre.Name = "Cre";
            this.Cre.Width = 120;
            // 
            // Debitosaldo
            // 
            this.Debitosaldo.DataPropertyName = "sdeb";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Debitosaldo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Debitosaldo.HeaderText = "Saldo Devedor";
            this.Debitosaldo.Name = "Debitosaldo";
            this.Debitosaldo.Width = 120;
            // 
            // Credsaldo
            // 
            this.Credsaldo.DataPropertyName = "scre";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Credsaldo.DefaultCellStyle = dataGridViewCellStyle5;
            this.Credsaldo.HeaderText = "Saldo Credor";
            this.Credsaldo.Name = "Credsaldo";
            this.Credsaldo.Width = 120;
            // 
            // Balancete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(924, 557);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbProcura);
            this.Controls.Add(this.gridContas);
            this.Controls.Add(this.panel3);
            this.Name = "Balancete";
            this.Load += new System.EventHandler(this.Balancete_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.gridContas, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tbProcura, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContaFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContaInicio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nrAno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UC.BarraText barraText3;
        private System.Windows.Forms.Panel panel8;
        private UC.CbDefault SaldAcumPer;
        private UC.CbDefault rbSsaldosAc;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnProcessar;
        public System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.NumericUpDown nrAno;
        private UC.CbDefault ContasMov;
        private Generic.GridUi gridContas;
        private UC.BarraText barraText1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown mesFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown mesInicio;
        private System.Windows.Forms.GroupBox groupBox4;
        private UC.CbDefault Entrecontas;
        private System.Windows.Forms.NumericUpDown ContaFim;
        private System.Windows.Forms.NumericUpDown ContaInicio;
        public System.Windows.Forms.Button btnMaxMin;
        private UC.CbDefault tbDoisDigitos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbProcura;
        private UC.CbDefault ApuraRes;
        private UC.CbDefault cbApuraIva;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn deb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debitosaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credsaldo;
    }
}
