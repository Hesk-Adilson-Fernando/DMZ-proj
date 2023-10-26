using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    partial class Apiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apiva));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEntreMeses = new DMZ.UI.UC.CbDefault();
            this.cbMes = new DMZ.UI.UC.CbDefault();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mesFim = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.mesInicio = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.cbMeses = new DMZ.UI.UC.DmzProcura();
            this.dgvApura = new DMZ.UI.Generic.GridUi();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.subt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericAno = new System.Windows.Forms.NumericUpDown();
            this.numericMes = new System.Windows.Forms.NumericUpDown();
            this.numericDia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApura)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Size = new System.Drawing.Size(834, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnPrint, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(802, 3);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.Text = "APURAMENTO DO IVA";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbEntreMeses);
            this.panel1.Controls.Add(this.cbMes);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cbMeses);
            this.panel1.Location = new System.Drawing.Point(5, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 56);
            this.panel1.TabIndex = 0;
            // 
            // cbEntreMeses
            // 
            this.cbEntreMeses.BackColor = System.Drawing.Color.Transparent;
            this.cbEntreMeses.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEntreMeses.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEntreMeses.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEntreMeses.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbEntreMeses.CbText = "";
            this.cbEntreMeses.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbEntreMeses.Imagem = ((System.Drawing.Image)(resources.GetObject("cbEntreMeses.Imagem")));
            this.cbEntreMeses.IsOptionGroup = false;
            this.cbEntreMeses.IsReadOnly = false;
            this.cbEntreMeses.IsRequered = false;
            this.cbEntreMeses.Location = new System.Drawing.Point(448, 25);
            this.cbEntreMeses.Name = "cbEntreMeses";
            this.cbEntreMeses.OnlyCheckBox = true;
            this.cbEntreMeses.Size = new System.Drawing.Size(30, 25);
            this.cbEntreMeses.TabIndex = 504;
            this.cbEntreMeses.Value = null;
            this.cbEntreMeses.Value2 = null;
            this.cbEntreMeses.Visible = false;
            this.cbEntreMeses.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbEntreMeses_CheckedChangeds);
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.Color.Transparent;
            this.cbMes.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMes.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMes.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbMes.CbText = "";
            this.cbMes.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbMes.Imagem = ((System.Drawing.Image)(resources.GetObject("cbMes.Imagem")));
            this.cbMes.IsOptionGroup = false;
            this.cbMes.IsReadOnly = false;
            this.cbMes.IsRequered = false;
            this.cbMes.Location = new System.Drawing.Point(6, 25);
            this.cbMes.Name = "cbMes";
            this.cbMes.OnlyCheckBox = true;
            this.cbMes.Size = new System.Drawing.Size(30, 25);
            this.cbMes.TabIndex = 503;
            this.cbMes.Value = null;
            this.cbMes.Value2 = null;
            this.cbMes.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbMes_CheckedChangeds);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mesFim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mesInicio);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.groupBox1.Location = new System.Drawing.Point(478, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 45);
            this.groupBox1.TabIndex = 499;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes(s)";
            this.groupBox1.Visible = false;
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Image = global::DMZ.UI.Properties.Resources.Automatic_251px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(738, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 50);
            this.button2.TabIndex = 458;
            this.button2.Text = "Processar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // cbMeses
            // 
            this.cbMeses.BtnEnabled = true;
            this.cbMeses.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMeses.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMeses.Condicao = null;
            this.cbMeses.ExecMetodo = false;
            this.cbMeses.HideFirstColumn = false;
            this.cbMeses.InvertColuna = false;
            this.cbMeses.IsLocaDs = false;
            this.cbMeses.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMeses.Label1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMeses.Label1Text = "Mês de apuramento";
            this.cbMeses.Location = new System.Drawing.Point(34, 12);
            this.cbMeses.MySQLQuerry = null;
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Pp = null;
            this.cbMeses.Size = new System.Drawing.Size(394, 39);
            this.cbMeses.SqlComandText = "select codigo,ltrim(rtrim(mes)) as descricao from mescont order by Convert(decima" +
    "l,codigo)";
            this.cbMeses.TabIndex = 457;
            this.cbMeses.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMeses.Tb1Multiline = false;
            this.cbMeses.Text2 = null;
            this.cbMeses.Text3 = null;
            this.cbMeses.RefreshControls += new DMZ.UI.UC.DmzProcura.Refrescar(this.cbMeses_RefreshControls);
            // 
            // dgvApura
            // 
            this.dgvApura.AddButtons = false;
            this.dgvApura.AllowUserToAddRows = false;
            this.dgvApura.AllowUserToDeleteRows = false;
            this.dgvApura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApura.AutoIncrimento = false;
            this.dgvApura.BackgroundColor = System.Drawing.Color.White;
            this.dgvApura.CampoCodigo = null;
            this.dgvApura.Codigo = null;
            this.dgvApura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApura.ColumnHeadersHeight = 30;
            this.dgvApura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvApura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conta,
            this.descricao,
            this.debito,
            this.credito,
            this.stamp,
            this.Column1,
            this.subt});
            this.dgvApura.Condicao = null;
            this.dgvApura.CorPreto = false;
            this.dgvApura.CurrentColumnName = null;
            this.dgvApura.DefacolumnName = null;
            this.dgvApura.DellGridRow = null;
            this.dgvApura.DtDS = null;
            this.dgvApura.EnableHeadersVisualStyles = false;
            this.dgvApura.GenerateColumns = false;
            this.dgvApura.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvApura.GridFilha = false;
            this.dgvApura.GridFilhaSecundaria = false;
            this.dgvApura.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvApura.HeadersHeight = 30;
            this.dgvApura.HeadersVisible = false;
            this.dgvApura.Location = new System.Drawing.Point(6, 98);
            this.dgvApura.Name = "dgvApura";
            this.dgvApura.OrderbyCampos = null;
            this.dgvApura.Origem = null;
            this.dgvApura.ReadOnly = true;
            this.dgvApura.RowHeadersWidth = 20;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvApura.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvApura.Size = new System.Drawing.Size(831, 455);
            this.dgvApura.StampCabecalho = null;
            this.dgvApura.StampLocal = null;
            this.dgvApura.TabelaSql = null;
            this.dgvApura.TabIndex = 1;
            this.dgvApura.TbCodigo = null;
            // 
            // conta
            // 
            this.conta.DataPropertyName = "conta";
            this.conta.HeaderText = "Conta";
            this.conta.Name = "conta";
            this.conta.ReadOnly = true;
            this.conta.Width = 120;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // debito
            // 
            this.debito.DataPropertyName = "deb";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.debito.DefaultCellStyle = dataGridViewCellStyle2;
            this.debito.HeaderText = "Débito";
            this.debito.Name = "debito";
            this.debito.ReadOnly = true;
            this.debito.Width = 120;
            // 
            // credito
            // 
            this.credito.DataPropertyName = "cre";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.credito.DefaultCellStyle = dataGridViewCellStyle3;
            this.credito.HeaderText = "Crédito";
            this.credito.Name = "credito";
            this.credito.ReadOnly = true;
            this.credito.Width = 120;
            // 
            // stamp
            // 
            this.stamp.HeaderText = "stamp";
            this.stamp.Name = "stamp";
            this.stamp.ReadOnly = true;
            this.stamp.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // subt
            // 
            this.subt.HeaderText = "subt";
            this.subt.Name = "subt";
            this.subt.ReadOnly = true;
            this.subt.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numericAno);
            this.panel2.Controls.Add(this.numericMes);
            this.panel2.Controls.Add(this.numericDia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnLancar);
            this.panel2.Location = new System.Drawing.Point(5, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 51);
            this.panel2.TabIndex = 2;
            // 
            // numericAno
            // 
            this.numericAno.BackColor = System.Drawing.Color.White;
            this.numericAno.Enabled = false;
            this.numericAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.numericAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.numericAno.Location = new System.Drawing.Point(627, 18);
            this.numericAno.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericAno.Name = "numericAno";
            this.numericAno.Size = new System.Drawing.Size(58, 20);
            this.numericAno.TabIndex = 456;
            this.numericAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericMes
            // 
            this.numericMes.BackColor = System.Drawing.Color.White;
            this.numericMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.numericMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.numericMes.Location = new System.Drawing.Point(586, 18);
            this.numericMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMes.Name = "numericMes";
            this.numericMes.Size = new System.Drawing.Size(41, 20);
            this.numericMes.TabIndex = 455;
            this.numericMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericDia
            // 
            this.numericDia.BackColor = System.Drawing.Color.White;
            this.numericDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.numericDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.numericDia.Location = new System.Drawing.Point(545, 18);
            this.numericDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericDia.Name = "numericDia";
            this.numericDia.Size = new System.Drawing.Size(41, 20);
            this.numericDia.TabIndex = 454;
            this.numericDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(542, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 453;
            this.label2.Text = "Data de Emissão";
            // 
            // btnLancar
            // 
            this.btnLancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnLancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLancar.Image = global::DMZ.UI.Properties.Resources.loading_25px;
            this.btnLancar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLancar.Location = new System.Drawing.Point(698, 6);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(132, 35);
            this.btnLancar.TabIndex = 452;
            this.btnLancar.Text = "Lançamento";
            this.btnLancar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(747, -2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(29, 32);
            this.btnPrint.TabIndex = 81;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.btnMaxMin.Location = new System.Drawing.Point(776, 4);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 86;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 606);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(839, 5);
            this.panel6.TabIndex = 457;
            // 
            // Apiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 611);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvApura);
            this.Controls.Add(this.panel1);
            this.Name = "Apiva";
            this.Text = "Apuramento do IVA";
            this.Load += new System.EventHandler(this.Apiva_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgvApura, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApura)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private GridUi dgvApura;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn stamp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn subt;
        public System.Windows.Forms.Button btnMaxMin;
        private UC.DmzProcura cbMeses;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown mesFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown mesInicio;
        private UC.CbDefault cbEntreMeses;
        private UC.CbDefault cbMes;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numericAno;
        private System.Windows.Forms.NumericUpDown numericMes;
        private System.Windows.Forms.NumericUpDown numericDia;
        private System.Windows.Forms.Label label2;
    }
}