namespace DMZ.UI.UI
{
    partial class FrmReg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReg));
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnIntrodValor = new System.Windows.Forms.Button();
            this.tbValorReg = new System.Windows.Forms.TextBox();
            this.tbContador = new System.Windows.Forms.TextBox();
            this.tbValorIntrod = new System.Windows.Forms.TextBox();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.tbTotalDocums = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.tbProcura = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(783, 26);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(758, 1);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.Text = "Regulazicação de documentos";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.numero,
            this.Data,
            this.Moeda,
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
            this.gridUi1.Location = new System.Drawing.Point(6, 71);
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
            this.gridUi1.Size = new System.Drawing.Size(772, 388);
            this.gridUi1.StampCabecalho = null;
            this.gridUi1.StampLocal = null;
            this.gridUi1.TabelaSql = null;
            this.gridUi1.TabIndex = 0;
            this.gridUi1.TbCodigo = null;
            this.gridUi1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellContentClick);
            this.gridUi1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellEndEdit);
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
            this.Data.Width = 85;
            // 
            // Moeda
            // 
            this.Moeda.DataPropertyName = "moeda";
            this.Moeda.HeaderText = "Moeda";
            this.Moeda.Name = "Moeda";
            this.Moeda.Width = 80;
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
            this.OK.DataPropertyName = "Ok2";
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
            // btnIntrodValor
            // 
            this.btnIntrodValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIntrodValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnIntrodValor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnIntrodValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntrodValor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntrodValor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnIntrodValor.Image = global::DMZ.UI.Properties.Resources.Print_25px1;
            this.btnIntrodValor.Location = new System.Drawing.Point(300, 464);
            this.btnIntrodValor.Name = "btnIntrodValor";
            this.btnIntrodValor.Size = new System.Drawing.Size(38, 32);
            this.btnIntrodValor.TabIndex = 85;
            this.btnIntrodValor.TabStop = false;
            this.btnIntrodValor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.dmzToolTip1.SetToolTip(this.btnIntrodValor, "Inserir valor aleatório");
            this.btnIntrodValor.UseVisualStyleBackColor = false;
            this.btnIntrodValor.Visible = false;
            this.btnIntrodValor.Click += new System.EventHandler(this.btnIntrodValor_Click);
            // 
            // tbValorReg
            // 
            this.tbValorReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorReg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorReg.ForeColor = System.Drawing.Color.Maroon;
            this.tbValorReg.Location = new System.Drawing.Point(531, 467);
            this.tbValorReg.Multiline = true;
            this.tbValorReg.Name = "tbValorReg";
            this.tbValorReg.ReadOnly = true;
            this.tbValorReg.Size = new System.Drawing.Size(140, 26);
            this.tbValorReg.TabIndex = 86;
            this.tbValorReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbContador
            // 
            this.tbContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContador.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContador.ForeColor = System.Drawing.Color.Maroon;
            this.tbContador.Location = new System.Drawing.Point(490, 467);
            this.tbContador.Multiline = true;
            this.tbContador.Name = "tbContador";
            this.tbContador.ReadOnly = true;
            this.tbContador.Size = new System.Drawing.Size(37, 26);
            this.tbContador.TabIndex = 87;
            // 
            // tbValorIntrod
            // 
            this.tbValorIntrod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorIntrod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorIntrod.Location = new System.Drawing.Point(149, 465);
            this.tbValorIntrod.Multiline = true;
            this.tbValorIntrod.Name = "tbValorIntrod";
            this.tbValorIntrod.Size = new System.Drawing.Size(145, 28);
            this.tbValorIntrod.TabIndex = 88;
            this.tbValorIntrod.TabStop = false;
            this.tbValorIntrod.Visible = false;
            this.tbValorIntrod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbValorIntrod_KeyUp);
            // 
            // btnAceitar
            // 
            this.btnAceitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnAceitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAceitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAceitar.Image = global::DMZ.UI.Properties.Resources.Checked_23px;
            this.btnAceitar.Location = new System.Drawing.Point(675, 462);
            this.btnAceitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(103, 32);
            this.btnAceitar.TabIndex = 204;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAceitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceitar.UseVisualStyleBackColor = false;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Image = global::DMZ.UI.Properties.Resources.Estimate_25px;
            this.button1.Location = new System.Drawing.Point(149, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 28);
            this.button1.TabIndex = 205;
            this.button1.TabStop = false;
            this.button1.Text = "Introduzir Valor ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Software";
            // 
            // tbTotalDocums
            // 
            this.tbTotalDocums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalDocums.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalDocums.ForeColor = System.Drawing.Color.Maroon;
            this.tbTotalDocums.Location = new System.Drawing.Point(5, 467);
            this.tbTotalDocums.Multiline = true;
            this.tbTotalDocums.Name = "tbTotalDocums";
            this.tbTotalDocums.ReadOnly = true;
            this.tbTotalDocums.Size = new System.Drawing.Size(137, 26);
            this.tbTotalDocums.TabIndex = 206;
            this.tbTotalDocums.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbDefault1);
            this.panel1.Controls.Add(this.tbProcura);
            this.panel1.Location = new System.Drawing.Point(6, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 33);
            this.panel1.TabIndex = 207;
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
            this.cbDefault1.Location = new System.Drawing.Point(622, 5);
            this.cbDefault1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = true;
            this.cbDefault1.Size = new System.Drawing.Size(143, 24);
            this.cbDefault1.TabIndex = 83;
            this.cbDefault1.Value = null;
            this.cbDefault1.Value2 = null;
            this.cbDefault1.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault1_CheckedChangeds);
            // 
            // tbProcura
            // 
            this.tbProcura.BackColor = System.Drawing.Color.Snow;
            this.tbProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProcura.Location = new System.Drawing.Point(5, 5);
            this.tbProcura.Name = "tbProcura";
            this.tbProcura.Size = new System.Drawing.Size(283, 23);
            this.tbProcura.TabIndex = 82;
            this.tbProcura.TextChanged += new System.EventHandler(this.tbProcura_TextChanged);
            // 
            // FrmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbTotalDocums);
            this.Controls.Add(this.tbValorIntrod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.tbContador);
            this.Controls.Add(this.tbValorReg);
            this.Controls.Add(this.btnIntrodValor);
            this.Controls.Add(this.gridUi1);
            this.Name = "FrmReg";
            this.Load += new System.EventHandler(this.FrmReg_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.gridUi1, 0);
            this.Controls.SetChildIndex(this.btnIntrodValor, 0);
            this.Controls.SetChildIndex(this.tbValorReg, 0);
            this.Controls.SetChildIndex(this.tbContador, 0);
            this.Controls.SetChildIndex(this.btnAceitar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.tbValorIntrod, 0);
            this.Controls.SetChildIndex(this.tbTotalDocums, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Generic.GridUi gridUi1;
        public System.Windows.Forms.Button btnIntrodValor;
        private System.Windows.Forms.TextBox tbValorReg;
        private System.Windows.Forms.TextBox tbContador;
        private System.Windows.Forms.TextBox tbValorIntrod;
        public System.Windows.Forms.Button btnAceitar;
        public System.Windows.Forms.Button button1;
        private Generic.DMZToolTip dmzToolTip1;
        private System.Windows.Forms.TextBox tbTotalDocums;
        private System.Windows.Forms.Panel panel1;
        private UC.CbDefault cbDefault1;
        private System.Windows.Forms.TextBox tbProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valordoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorporReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValRegularizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn deb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn oristamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rcladiant;
    }
}
