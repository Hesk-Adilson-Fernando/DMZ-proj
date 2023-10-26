namespace DMZ.UI.UI
{
    partial class FrmReg2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbTotalDocums = new System.Windows.Forms.TextBox();
            this.tbValorIntrod = new System.Windows.Forms.TextBox();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.tbContador = new System.Windows.Forms.TextBox();
            this.tbValorReg = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valordoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorporReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValRegularizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ccstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oristamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rcladiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccusto = new DMZ.UI.UC.DmzProcura();
            this.tbMoeda = new DMZ.UI.UC.DmzProcura();
            this.tbClienteForn = new DMZ.UI.UC.DmzProcura();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Size = new System.Drawing.Size(780, 29);
            this.panel4.Controls.SetChildIndex(this.btnPrint, 0);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(748, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.Text = "Encontro de contas";
            // 
            // tbTotalDocums
            // 
            this.tbTotalDocums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalDocums.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalDocums.ForeColor = System.Drawing.Color.Maroon;
            this.tbTotalDocums.Location = new System.Drawing.Point(17, 523);
            this.tbTotalDocums.Multiline = true;
            this.tbTotalDocums.Name = "tbTotalDocums";
            this.tbTotalDocums.ReadOnly = true;
            this.tbTotalDocums.Size = new System.Drawing.Size(137, 26);
            this.tbTotalDocums.TabIndex = 214;
            this.tbTotalDocums.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbValorIntrod
            // 
            this.tbValorIntrod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorIntrod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorIntrod.Location = new System.Drawing.Point(160, 523);
            this.tbValorIntrod.Multiline = true;
            this.tbValorIntrod.Name = "tbValorIntrod";
            this.tbValorIntrod.Size = new System.Drawing.Size(145, 28);
            this.tbValorIntrod.TabIndex = 211;
            this.tbValorIntrod.TabStop = false;
            this.tbValorIntrod.Visible = false;
            // 
            // btnAceitar
            // 
            this.btnAceitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnAceitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAceitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAceitar.Image = global::DMZ.UI.Properties.Resources.Checked_23px;
            this.btnAceitar.Location = new System.Drawing.Point(677, 518);
            this.btnAceitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(103, 32);
            this.btnAceitar.TabIndex = 212;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAceitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceitar.UseVisualStyleBackColor = false;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // tbContador
            // 
            this.tbContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContador.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContador.ForeColor = System.Drawing.Color.Maroon;
            this.tbContador.Location = new System.Drawing.Point(311, 523);
            this.tbContador.Multiline = true;
            this.tbContador.Name = "tbContador";
            this.tbContador.ReadOnly = true;
            this.tbContador.Size = new System.Drawing.Size(37, 26);
            this.tbContador.TabIndex = 210;
            // 
            // tbValorReg
            // 
            this.tbValorReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorReg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorReg.ForeColor = System.Drawing.Color.Maroon;
            this.tbValorReg.Location = new System.Drawing.Point(354, 523);
            this.tbValorReg.Multiline = true;
            this.tbValorReg.Name = "tbValorReg";
            this.tbValorReg.ReadOnly = true;
            this.tbValorReg.Size = new System.Drawing.Size(318, 26);
            this.tbValorReg.TabIndex = 209;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_25px1;
            this.btnPrint.Location = new System.Drawing.Point(704, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(38, 32);
            this.btnPrint.TabIndex = 208;
            this.btnPrint.TabStop = false;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessar.FlatAppearance.BorderSize = 0;
            this.btnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnProcessar.Location = new System.Drawing.Point(657, 59);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(114, 32);
            this.btnProcessar.TabIndex = 216;
            this.btnProcessar.TabStop = false;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.numero,
            this.Moeda,
            this.Data,
            this.Valordoc,
            this.ValorporReg,
            this.ValRegularizado,
            this.deb,
            this.cre,
            this.tipo,
            this.OK,
            this.ccstamp,
            this.Origem,
            this.oristamp,
            this.Rcladiant});
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
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(12, 140);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridUi1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi1.Size = new System.Drawing.Size(759, 354);
            this.gridUi1.StampCabecalho = null;
            this.gridUi1.StampLocal = null;
            this.gridUi1.TabelaSql = null;
            this.gridUi1.TabIndex = 220;
            this.gridUi1.TbCodigo = null;
            this.gridUi1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellClick);
            this.gridUi1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellContentClick);
            this.gridUi1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellEndEdit);
            this.gridUi1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridUi1_CellFormatting);
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Documento.DataPropertyName = "descricao";
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 150;
            this.Documento.Name = "Documento";
            // 
            // numero
            // 
            this.numero.DataPropertyName = "nrdoc";
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.Width = 60;
            // 
            // Moeda
            // 
            this.Moeda.DataPropertyName = "moeda";
            this.Moeda.HeaderText = "Moeda";
            this.Moeda.Name = "Moeda";
            this.Moeda.Width = 80;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data ";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle3;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Visible = false;
            // 
            // Valordoc
            // 
            this.Valordoc.DataPropertyName = "valordoc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Valordoc.DefaultCellStyle = dataGridViewCellStyle4;
            this.Valordoc.HeaderText = "Valor Doc.";
            this.Valordoc.Name = "Valordoc";
            this.Valordoc.Width = 110;
            // 
            // ValorporReg
            // 
            this.ValorporReg.DataPropertyName = "valorpreg";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.ValorporReg.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValorporReg.HeaderText = "Por pagar";
            this.ValorporReg.Name = "ValorporReg";
            // 
            // ValRegularizado
            // 
            this.ValRegularizado.DataPropertyName = "valorreg";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.ValRegularizado.DefaultCellStyle = dataGridViewCellStyle6;
            this.ValRegularizado.HeaderText = "Á pagar";
            this.ValRegularizado.Name = "ValRegularizado";
            this.ValRegularizado.Width = 110;
            // 
            // deb
            // 
            this.deb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deb.DataPropertyName = "deb";
            this.deb.HeaderText = "deb";
            this.deb.Name = "deb";
            this.deb.Visible = false;
            this.deb.Width = 49;
            // 
            // cre
            // 
            this.cre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cre.DataPropertyName = "cre";
            this.cre.HeaderText = "cre";
            this.cre.Name = "cre";
            this.cre.Visible = false;
            this.cre.Width = 46;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.Visible = false;
            // 
            // OK
            // 
            this.OK.DataPropertyName = "ok";
            this.OK.HeaderText = "OK";
            this.OK.Name = "OK";
            this.OK.Width = 30;
            // 
            // ccstamp
            // 
            this.ccstamp.DataPropertyName = "ccstamp";
            this.ccstamp.HeaderText = "ccstamp";
            this.ccstamp.Name = "ccstamp";
            this.ccstamp.Visible = false;
            // 
            // Origem
            // 
            this.Origem.DataPropertyName = "origem";
            this.Origem.HeaderText = "Origem";
            this.Origem.Name = "Origem";
            this.Origem.Visible = false;
            // 
            // oristamp
            // 
            this.oristamp.HeaderText = "oristamp";
            this.oristamp.Name = "oristamp";
            this.oristamp.Visible = false;
            // 
            // Rcladiant
            // 
            this.Rcladiant.DataPropertyName = "Rcladiant";
            this.Rcladiant.HeaderText = "Rcladiant";
            this.Rcladiant.Name = "Rcladiant";
            this.Rcladiant.Visible = false;
            // 
            // Ccusto
            // 
            this.Ccusto.BtnEnabled = true;
            this.Ccusto.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.Ccusto.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.Ccusto.Condicao = null;
            this.Ccusto.ExecMetodo = false;
            this.Ccusto.HideFirstColumn = false;
            this.Ccusto.InvertColuna = false;
            this.Ccusto.IsLocaDs = false;
            this.Ccusto.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ccusto.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ccusto.Label1Text = "Centro de Custo";
            this.Ccusto.Location = new System.Drawing.Point(403, 79);
            this.Ccusto.MySQLQuerry = null;
            this.Ccusto.Name = "Ccusto";
            this.Ccusto.Pp = null;
            this.Ccusto.Size = new System.Drawing.Size(232, 39);
            this.Ccusto.SqlComandText = "select CodCcu,Descricao from CCu";
            this.Ccusto.TabIndex = 221;
            this.Ccusto.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ccusto.Tb1Multiline = false;
            this.Ccusto.Text2 = null;
            this.Ccusto.Text3 = null;
            this.Ccusto.Text4 = null;
            // 
            // tbMoeda
            // 
            this.tbMoeda.BtnEnabled = true;
            this.tbMoeda.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMoeda.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMoeda.Condicao = null;
            this.tbMoeda.ExecMetodo = false;
            this.tbMoeda.HideFirstColumn = false;
            this.tbMoeda.InvertColuna = false;
            this.tbMoeda.IsLocaDs = false;
            this.tbMoeda.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMoeda.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoeda.Label1Text = "Moeda";
            this.tbMoeda.Location = new System.Drawing.Point(12, 79);
            this.tbMoeda.MySQLQuerry = null;
            this.tbMoeda.Name = "tbMoeda";
            this.tbMoeda.Pp = null;
            this.tbMoeda.Size = new System.Drawing.Size(370, 39);
            this.tbMoeda.SqlComandText = "select Descricao,moeda from moedas";
            this.tbMoeda.TabIndex = 221;
            this.tbMoeda.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMoeda.Tb1Multiline = false;
            this.tbMoeda.Text2 = null;
            this.tbMoeda.Text3 = null;
            this.tbMoeda.Text4 = null;
            // 
            // tbClienteForn
            // 
            this.tbClienteForn.BtnEnabled = true;
            this.tbClienteForn.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbClienteForn.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbClienteForn.Condicao = null;
            this.tbClienteForn.ExecMetodo = false;
            this.tbClienteForn.HideFirstColumn = false;
            this.tbClienteForn.InvertColuna = false;
            this.tbClienteForn.IsLocaDs = false;
            this.tbClienteForn.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClienteForn.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClienteForn.Label1Text = "Nome do Cliente/Fornrcedor";
            this.tbClienteForn.Location = new System.Drawing.Point(12, 34);
            this.tbClienteForn.MySQLQuerry = null;
            this.tbClienteForn.Name = "tbClienteForn";
            this.tbClienteForn.Pp = null;
            this.tbClienteForn.Size = new System.Drawing.Size(623, 39);
            this.tbClienteForn.SqlComandText = "select Descricao,moeda from moedas";
            this.tbClienteForn.TabIndex = 221;
            this.tbClienteForn.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClienteForn.Tb1Multiline = false;
            this.tbClienteForn.Text2 = null;
            this.tbClienteForn.Text3 = null;
            this.tbClienteForn.Text4 = null;
            // 
            // FrmReg2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(779, 561);
            this.Controls.Add(this.tbClienteForn);
            this.Controls.Add(this.tbMoeda);
            this.Controls.Add(this.Ccusto);
            this.Controls.Add(this.gridUi1);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.tbContador);
            this.Controls.Add(this.tbValorReg);
            this.Controls.Add(this.tbTotalDocums);
            this.Controls.Add(this.tbValorIntrod);
            this.Name = "FrmReg2";
            this.Load += new System.EventHandler(this.FrmReg2_Load);
            this.Controls.SetChildIndex(this.tbValorIntrod, 0);
            this.Controls.SetChildIndex(this.tbTotalDocums, 0);
            this.Controls.SetChildIndex(this.tbValorReg, 0);
            this.Controls.SetChildIndex(this.tbContador, 0);
            this.Controls.SetChildIndex(this.btnAceitar, 0);
            this.Controls.SetChildIndex(this.btnProcessar, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.gridUi1, 0);
            this.Controls.SetChildIndex(this.Ccusto, 0);
            this.Controls.SetChildIndex(this.tbMoeda, 0);
            this.Controls.SetChildIndex(this.tbClienteForn, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbTotalDocums;
        public System.Windows.Forms.TextBox tbValorIntrod;
        public System.Windows.Forms.Button btnAceitar;
        public System.Windows.Forms.TextBox tbContador;
        public System.Windows.Forms.TextBox tbValorReg;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Button btnProcessar;
        public Generic.GridUi gridUi1;
        public UC.DmzProcura Ccusto;
        public UC.DmzProcura tbMoeda;
        public UC.DmzProcura tbClienteForn;
        public System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        public System.Windows.Forms.DataGridViewTextBoxColumn numero;
        public System.Windows.Forms.DataGridViewTextBoxColumn Moeda;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data;
        public System.Windows.Forms.DataGridViewTextBoxColumn Valordoc;
        public System.Windows.Forms.DataGridViewTextBoxColumn ValorporReg;
        public System.Windows.Forms.DataGridViewTextBoxColumn ValRegularizado;
        public System.Windows.Forms.DataGridViewTextBoxColumn deb;
        public System.Windows.Forms.DataGridViewTextBoxColumn cre;
        public System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        public System.Windows.Forms.DataGridViewCheckBoxColumn OK;
        public System.Windows.Forms.DataGridViewTextBoxColumn ccstamp;
        public System.Windows.Forms.DataGridViewTextBoxColumn Origem;
        public System.Windows.Forms.DataGridViewTextBoxColumn oristamp;
        public System.Windows.Forms.DataGridViewTextBoxColumn Rcladiant;
    }
}
