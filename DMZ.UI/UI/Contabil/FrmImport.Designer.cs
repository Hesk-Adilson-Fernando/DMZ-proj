namespace DMZ.UI.UI.Contabil
{
    partial class FrmImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImport));
            this.dataGridView1 = new DMZ.UI.Generic.GridUi();
            this.ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.integracao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pgcstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nupdAnoOrig = new System.Windows.Forms.NumericUpDown();
            this.nupDest = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnProcura = new System.Windows.Forms.Button();
            this.rbPgc = new DMZ.UI.UC.CbDefault();
            this.rbDiario = new DMZ.UI.UC.CbDefault();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAnoOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDest)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Size = new System.Drawing.Size(808, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(776, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(279, 17);
            this.label1.Text = "Importação de Plano de Contas e Diários";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AddButtons = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoIncrimento = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CampoCodigo = null;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.Codigo = null;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ok,
            this.conta,
            this.Descricao2,
            this.Valor,
            this.integracao,
            this.pgcstamp});
            this.dataGridView1.Condicao = null;
            this.dataGridView1.CorPreto = true;
            this.dataGridView1.CurrentColumnName = null;
            this.dataGridView1.DefacolumnName = null;
            this.dataGridView1.DellGridRow = null;
            this.dataGridView1.DtDS = null;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GenerateColumns = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.GridFilha = false;
            this.dataGridView1.GridFilhaSecundaria = false;
            this.dataGridView1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.HeadersHeight = 30;
            this.dataGridView1.HeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.OrderbyCampos = "";
            this.dataGridView1.Origem = null;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(798, 287);
            this.dataGridView1.StampCabecalho = "";
            this.dataGridView1.StampLocal = "";
            this.dataGridView1.TabelaSql = "";
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.TbCodigo = null;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ok
            // 
            this.ok.DataPropertyName = "ok";
            this.ok.HeaderText = "....";
            this.ok.Name = "ok";
            this.ok.ReadOnly = true;
            this.ok.Width = 30;
            // 
            // conta
            // 
            this.conta.DataPropertyName = "codigo";
            this.conta.HeaderText = "Código";
            this.conta.Name = "conta";
            this.conta.ReadOnly = true;
            this.conta.Width = 120;
            // 
            // Descricao2
            // 
            this.Descricao2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao2.DataPropertyName = "descricao";
            this.Descricao2.HeaderText = "Descrição";
            this.Descricao2.Name = "Descricao2";
            this.Descricao2.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ano";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Ano";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // integracao
            // 
            this.integracao.DataPropertyName = "integracao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = false;
            this.integracao.DefaultCellStyle = dataGridViewCellStyle3;
            this.integracao.FillWeight = 90F;
            this.integracao.HeaderText = "Integradora";
            this.integracao.Name = "integracao";
            this.integracao.ReadOnly = true;
            this.integracao.Visible = false;
            this.integracao.Width = 70;
            // 
            // pgcstamp
            // 
            this.pgcstamp.DataPropertyName = "pgcstamp";
            this.pgcstamp.HeaderText = "pgcstamp";
            this.pgcstamp.Name = "pgcstamp";
            this.pgcstamp.ReadOnly = true;
            this.pgcstamp.Visible = false;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Sync_Settings_20px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.Location = new System.Drawing.Point(678, 445);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(123, 32);
            this.btnProcessar.TabIndex = 94;
            this.btnProcessar.Text = "PROCESSAR";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.Image = global::DMZ.UI.Properties.Resources.Maximize_Window_25px;
            this.btnMaxMin.Location = new System.Drawing.Point(750, 2);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 88;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // barraText1
            // 
            this.barraText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.White;
            this.barraText1.Label1Text = "Configuração ";
            this.barraText1.Location = new System.Drawing.Point(1, 35);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(804, 30);
            this.barraText1.TabIndex = 95;
            // 
            // cbDefault1
            // 
            this.cbDefault1.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "Selecçionar todos";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(3, 125);
            this.cbDefault1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = true;
            this.cbDefault1.Size = new System.Drawing.Size(143, 24);
            this.cbDefault1.TabIndex = 96;
            this.cbDefault1.Value = null;
            this.cbDefault1.Value2 = null;
            this.cbDefault1.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault1_CheckedChangeds);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 484);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(806, 5);
            this.panel7.TabIndex = 101;
            // 
            // nupdAnoOrig
            // 
            this.nupdAnoOrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nupdAnoOrig.Location = new System.Drawing.Point(192, 31);
            this.nupdAnoOrig.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupdAnoOrig.Minimum = new decimal(new int[] {
            1989,
            0,
            0,
            0});
            this.nupdAnoOrig.Name = "nupdAnoOrig";
            this.nupdAnoOrig.Size = new System.Drawing.Size(63, 21);
            this.nupdAnoOrig.TabIndex = 3;
            this.nupdAnoOrig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupdAnoOrig.Value = new decimal(new int[] {
            1989,
            0,
            0,
            0});
            // 
            // nupDest
            // 
            this.nupDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nupDest.Location = new System.Drawing.Point(367, 31);
            this.nupDest.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupDest.Minimum = new decimal(new int[] {
            1989,
            0,
            0,
            0});
            this.nupDest.Name = "nupDest";
            this.nupDest.Size = new System.Drawing.Size(63, 21);
            this.nupDest.TabIndex = 4;
            this.nupDest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupDest.Value = new decimal(new int[] {
            1989,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(282, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ano de Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(110, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano de Origem";
            // 
            // BtnProcura
            // 
            this.BtnProcura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProcura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BtnProcura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcura.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BtnProcura.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnProcura.Image = global::DMZ.UI.Properties.Resources.Synchronize_28px;
            this.BtnProcura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProcura.Location = new System.Drawing.Point(679, 8);
            this.BtnProcura.Name = "BtnProcura";
            this.BtnProcura.Size = new System.Drawing.Size(111, 40);
            this.BtnProcura.TabIndex = 95;
            this.BtnProcura.Text = "PROCURAR";
            this.BtnProcura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProcura.UseVisualStyleBackColor = false;
            this.BtnProcura.Click += new System.EventHandler(this.BtnProcura_Click);
            // 
            // rbPgc
            // 
            this.rbPgc.BackColor = System.Drawing.Color.Transparent;
            this.rbPgc.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPgc.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPgc.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPgc.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbPgc.CbText = "Plano de Contas";
            this.rbPgc.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbPgc.Imagem = ((System.Drawing.Image)(resources.GetObject("rbPgc.Imagem")));
            this.rbPgc.IsOptionGroup = false;
            this.rbPgc.IsReadOnly = false;
            this.rbPgc.IsRequered = false;
            this.rbPgc.Location = new System.Drawing.Point(8, 3);
            this.rbPgc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPgc.Name = "rbPgc";
            this.rbPgc.OnlyCheckBox = true;
            this.rbPgc.Size = new System.Drawing.Size(143, 24);
            this.rbPgc.TabIndex = 102;
            this.rbPgc.Value = null;
            this.rbPgc.Value2 = null;
            this.rbPgc.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.rbPgc_CheckedChangeds);
            // 
            // rbDiario
            // 
            this.rbDiario.BackColor = System.Drawing.Color.Transparent;
            this.rbDiario.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbDiario.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbDiario.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiario.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbDiario.CbText = "Diários";
            this.rbDiario.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbDiario.Imagem = ((System.Drawing.Image)(resources.GetObject("rbDiario.Imagem")));
            this.rbDiario.IsOptionGroup = false;
            this.rbDiario.IsReadOnly = false;
            this.rbDiario.IsRequered = false;
            this.rbDiario.Location = new System.Drawing.Point(8, 28);
            this.rbDiario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDiario.Name = "rbDiario";
            this.rbDiario.OnlyCheckBox = true;
            this.rbDiario.Size = new System.Drawing.Size(96, 24);
            this.rbDiario.TabIndex = 103;
            this.rbDiario.Value = null;
            this.rbDiario.Value2 = null;
            this.rbDiario.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.rbDiario_CheckedChangeds);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbDiario);
            this.panel1.Controls.Add(this.rbPgc);
            this.panel1.Controls.Add(this.BtnProcura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nupDest);
            this.panel1.Controls.Add(this.nupdAnoOrig);
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 59);
            this.panel1.TabIndex = 0;
            // 
            // FrmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 489);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.cbDefault1);
            this.Controls.Add(this.barraText1);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmImport";
            this.Text = "Importação de Plano de Contas e Diários";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnProcessar, 0);
            this.Controls.SetChildIndex(this.barraText1, 0);
            this.Controls.SetChildIndex(this.cbDefault1, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdAnoOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Generic.GridUi dataGridView1;
        private System.Windows.Forms.Button btnProcessar;
        public System.Windows.Forms.Button btnMaxMin;
        private UC.BarraText barraText1;
        private UC.CbDefault cbDefault1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown nupdAnoOrig;
        private System.Windows.Forms.NumericUpDown nupDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnProcura;
        private UC.CbDefault rbPgc;
        private UC.CbDefault rbDiario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn integracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn pgcstamp;
    }
}