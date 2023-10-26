namespace DMZ.UI.UI
{
    partial class FrmProdVend
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdVend));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.cbArmazem = new DMZ.UI.UC.DmzProcura();
            this.cbCCusto = new DMZ.UI.UC.DmzProcura();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.cbDetalhado = new DMZ.UI.UC.CbDefault();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSimplificadoarm = new DMZ.UI.UC.CbDefault();
            this.cbSimplificado = new DMZ.UI.UC.CbDefault();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Armazem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(912, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(880, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.Text = "Produtos Vendidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(569, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 117;
            this.label4.Text = "Início";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(671, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Término";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_20px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(875, 60);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(35, 35);
            this.btnPrint.TabIndex = 114;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpData1
            // 
            this.dtpData1.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData1.Location = new System.Drawing.Point(568, 74);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(96, 22);
            this.dtpData1.TabIndex = 113;
            // 
            // dtpData2
            // 
            this.dtpData2.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData2.Location = new System.Drawing.Point(670, 74);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(96, 22);
            this.dtpData2.TabIndex = 112;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Sync_Settings_20px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.Location = new System.Drawing.Point(774, 60);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(100, 35);
            this.btnProcessar.TabIndex = 111;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ref,
            this.formasp,
            this.quant,
            this.Preco,
            this.Total,
            this.Armazem,
            this.Cliente,
            this.Documento,
            this.Data});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.White;
            this.gridUi1.GridFilha = false;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(9, 99);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.ReadOnly = true;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridUi1.Size = new System.Drawing.Size(902, 403);
            this.gridUi1.StampCabecalho = null;
            this.gridUi1.StampLocal = null;
            this.gridUi1.TabelaSql = null;
            this.gridUi1.TabIndex = 120;
            this.gridUi1.TbCodigo = null;
            // 
            // cbArmazem
            // 
            this.cbArmazem.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbArmazem.IsLocaDs = false;
            this.cbArmazem.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbArmazem.Label1Text = "Armazem (Vazio = Todos)";
            this.cbArmazem.Location = new System.Drawing.Point(2, 57);
            this.cbArmazem.Name = "cbArmazem";
            this.cbArmazem.Pp = null;
            this.cbArmazem.Size = new System.Drawing.Size(274, 39);
            this.cbArmazem.SqlComandText = "select Codigo,descricao from armazem";
            this.cbArmazem.TabIndex = 128;
            this.cbArmazem.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbArmazem.Text2 = null;
            // 
            // cbCCusto
            // 
            this.cbCCusto.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCCusto.IsLocaDs = false;
            this.cbCCusto.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCCusto.Label1Text = "Centro de custo";
            this.cbCCusto.Location = new System.Drawing.Point(289, 57);
            this.cbCCusto.Name = "cbCCusto";
            this.cbCCusto.Pp = null;
            this.cbCCusto.Size = new System.Drawing.Size(263, 39);
            this.cbCCusto.SqlComandText = "select CodCcu,Descricao  from ccu";
            this.cbCCusto.TabIndex = 129;
            this.cbCCusto.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCCusto.Text2 = null;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Location = new System.Drawing.Point(9, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 44);
            this.panel1.TabIndex = 130;
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbTotal.Location = new System.Drawing.Point(615, 7);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(276, 26);
            this.tbTotal.TabIndex = 0;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbDetalhado
            // 
            this.cbDetalhado.BackColor = System.Drawing.Color.Transparent;
            this.cbDetalhado.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDetalhado.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDetalhado.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDetalhado.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDetalhado.CbText = "Detalhado";
            this.cbDetalhado.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDetalhado.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDetalhado.Imagem")));
            this.cbDetalhado.IsOptionGroup = false;
            this.cbDetalhado.IsReadOnly = false;
            this.cbDetalhado.IsRequered = false;
            this.cbDetalhado.Location = new System.Drawing.Point(3, -2);
            this.cbDetalhado.Name = "cbDetalhado";
            this.cbDetalhado.OnlyCheckBox = true;
            this.cbDetalhado.Size = new System.Drawing.Size(167, 22);
            this.cbDetalhado.TabIndex = 131;
            this.cbDetalhado.Value = null;
            this.cbDetalhado.Value2 = null;
            this.cbDetalhado.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDetalhado_CheckedChangeds);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbSimplificadoarm);
            this.panel2.Controls.Add(this.cbSimplificado);
            this.panel2.Controls.Add(this.cbDetalhado);
            this.panel2.Location = new System.Drawing.Point(10, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 24);
            this.panel2.TabIndex = 132;
            // 
            // cbSimplificadoarm
            // 
            this.cbSimplificadoarm.BackColor = System.Drawing.Color.Transparent;
            this.cbSimplificadoarm.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSimplificadoarm.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSimplificadoarm.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSimplificadoarm.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbSimplificadoarm.CbText = "Simplificado em armazens ";
            this.cbSimplificadoarm.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSimplificadoarm.Imagem = ((System.Drawing.Image)(resources.GetObject("cbSimplificadoarm.Imagem")));
            this.cbSimplificadoarm.IsOptionGroup = false;
            this.cbSimplificadoarm.IsReadOnly = false;
            this.cbSimplificadoarm.IsRequered = false;
            this.cbSimplificadoarm.Location = new System.Drawing.Point(288, -2);
            this.cbSimplificadoarm.Name = "cbSimplificadoarm";
            this.cbSimplificadoarm.OnlyCheckBox = true;
            this.cbSimplificadoarm.Size = new System.Drawing.Size(209, 22);
            this.cbSimplificadoarm.TabIndex = 133;
            this.cbSimplificadoarm.Value = null;
            this.cbSimplificadoarm.Value2 = null;
            this.cbSimplificadoarm.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbSimplificadoarm_CheckedChangeds);
            // 
            // cbSimplificado
            // 
            this.cbSimplificado.BackColor = System.Drawing.Color.Transparent;
            this.cbSimplificado.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSimplificado.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSimplificado.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSimplificado.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbSimplificado.CbText = "Simplificado";
            this.cbSimplificado.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSimplificado.Imagem = ((System.Drawing.Image)(resources.GetObject("cbSimplificado.Imagem")));
            this.cbSimplificado.IsOptionGroup = false;
            this.cbSimplificado.IsReadOnly = false;
            this.cbSimplificado.IsRequered = false;
            this.cbSimplificado.Location = new System.Drawing.Point(145, -2);
            this.cbSimplificado.Name = "cbSimplificado";
            this.cbSimplificado.OnlyCheckBox = true;
            this.cbSimplificado.Size = new System.Drawing.Size(167, 22);
            this.cbSimplificado.TabIndex = 132;
            this.cbSimplificado.Value = null;
            this.cbSimplificado.Value2 = null;
            this.cbSimplificado.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbSimplificado_CheckedChangeds);
            // 
            // Ref
            // 
            this.Ref.DataPropertyName = "Ref";
            this.Ref.HeaderText = "Referência";
            this.Ref.Name = "Ref";
            this.Ref.ReadOnly = true;
            // 
            // formasp
            // 
            this.formasp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.formasp.DataPropertyName = "descricao";
            this.formasp.HeaderText = "Descrição";
            this.formasp.MinimumWidth = 120;
            this.formasp.Name = "formasp";
            this.formasp.ReadOnly = true;
            // 
            // quant
            // 
            this.quant.DataPropertyName = "vendido";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.quant.DefaultCellStyle = dataGridViewCellStyle3;
            this.quant.HeaderText = "Quant.";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            this.quant.Width = 70;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle4;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 90;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Armazem
            // 
            this.Armazem.DataPropertyName = "Descarm";
            this.Armazem.HeaderText = "Armazem";
            this.Armazem.Name = "Armazem";
            this.Armazem.ReadOnly = true;
            this.Armazem.Width = 130;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Nome";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 70;
            // 
            // FrmProdVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(913, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbCCusto);
            this.Controls.Add(this.cbArmazem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpData1);
            this.Controls.Add(this.dtpData2);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.gridUi1);
            this.Name = "FrmProdVend";
            this.Load += new System.EventHandler(this.FrmProdVend_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.gridUi1, 0);
            this.Controls.SetChildIndex(this.btnProcessar, 0);
            this.Controls.SetChildIndex(this.dtpData2, 0);
            this.Controls.SetChildIndex(this.dtpData1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbArmazem, 0);
            this.Controls.SetChildIndex(this.cbCCusto, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.DateTimePicker dtpData2;
        public System.Windows.Forms.Button btnProcessar;
        private Generic.GridUi gridUi1;
        private UC.DmzProcura cbArmazem;
        private UC.DmzProcura cbCCusto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Panel panel2;
        public UC.CbDefault cbDetalhado;
        public UC.CbDefault cbSimplificadoarm;
        public UC.CbDefault cbSimplificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn formasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Armazem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}
