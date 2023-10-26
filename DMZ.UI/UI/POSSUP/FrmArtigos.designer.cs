namespace DMZ.UI.UI
{
    partial class FrmArtigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArtigos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cbCodigoBarras = new DMZ.UI.UC.CbDefault();
            this.rdPreco6 = new System.Windows.Forms.RadioButton();
            this.rdPreco5 = new System.Windows.Forms.RadioButton();
            this.rdPreco4 = new System.Windows.Forms.RadioButton();
            this.rdPreco3 = new System.Windows.Forms.RadioButton();
            this.rdPreco2 = new System.Windows.Forms.RadioButton();
            this.rdPreco1 = new System.Windows.Forms.RadioButton();
            this.cbReferenc = new DMZ.UI.UC.CbDefault();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.gridProdutos = new DMZ.UI.Generic.GridUi();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigobarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ststamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Size = new System.Drawing.Size(693, 30);
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::DMZ.UI.Properties.Resources.Playlist_25px;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(31, 24);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(667, 2);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 6);
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.Text = "PRODUTOS";
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel15.Controls.Add(this.cbCodigoBarras);
            this.panel15.Controls.Add(this.rdPreco6);
            this.panel15.Controls.Add(this.rdPreco5);
            this.panel15.Controls.Add(this.rdPreco4);
            this.panel15.Controls.Add(this.rdPreco3);
            this.panel15.Controls.Add(this.rdPreco2);
            this.panel15.Controls.Add(this.rdPreco1);
            this.panel15.Controls.Add(this.cbReferenc);
            this.panel15.Controls.Add(this.textBox2);
            this.panel15.Controls.Add(this.panel11);
            this.panel15.Location = new System.Drawing.Point(3, 33);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(692, 486);
            this.panel15.TabIndex = 95;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            // 
            // cbCodigoBarras
            // 
            this.cbCodigoBarras.BackColor = System.Drawing.Color.Transparent;
            this.cbCodigoBarras.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCodigoBarras.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCodigoBarras.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodigoBarras.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbCodigoBarras.CbText = "Código de barras";
            this.cbCodigoBarras.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCodigoBarras.Imagem = ((System.Drawing.Image)(resources.GetObject("cbCodigoBarras.Imagem")));
            this.cbCodigoBarras.IsOptionGroup = false;
            this.cbCodigoBarras.IsReadOnly = false;
            this.cbCodigoBarras.IsRequered = false;
            this.cbCodigoBarras.Location = new System.Drawing.Point(103, 33);
            this.cbCodigoBarras.Name = "cbCodigoBarras";
            this.cbCodigoBarras.OnlyCheckBox = true;
            this.cbCodigoBarras.Size = new System.Drawing.Size(125, 22);
            this.cbCodigoBarras.TabIndex = 99;
            this.cbCodigoBarras.Value = null;
            this.cbCodigoBarras.Value2 = null;
            // 
            // rdPreco6
            // 
            this.rdPreco6.AutoSize = true;
            this.rdPreco6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdPreco6.Location = new System.Drawing.Point(464, 37);
            this.rdPreco6.Name = "rdPreco6";
            this.rdPreco6.Size = new System.Drawing.Size(57, 17);
            this.rdPreco6.TabIndex = 98;
            this.rdPreco6.TabStop = true;
            this.rdPreco6.Text = "preco6";
            this.rdPreco6.UseVisualStyleBackColor = true;
            this.rdPreco6.Visible = false;
            this.rdPreco6.CheckedChanged += new System.EventHandler(this.rdPreco6_CheckedChanged);
            // 
            // rdPreco5
            // 
            this.rdPreco5.AutoSize = true;
            this.rdPreco5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdPreco5.Location = new System.Drawing.Point(233, 40);
            this.rdPreco5.Name = "rdPreco5";
            this.rdPreco5.Size = new System.Drawing.Size(57, 17);
            this.rdPreco5.TabIndex = 98;
            this.rdPreco5.TabStop = true;
            this.rdPreco5.Text = "preco5";
            this.rdPreco5.UseVisualStyleBackColor = true;
            this.rdPreco5.Visible = false;
            this.rdPreco5.CheckedChanged += new System.EventHandler(this.rdPreco5_CheckedChanged);
            // 
            // rdPreco4
            // 
            this.rdPreco4.AutoSize = true;
            this.rdPreco4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdPreco4.Location = new System.Drawing.Point(621, 10);
            this.rdPreco4.Name = "rdPreco4";
            this.rdPreco4.Size = new System.Drawing.Size(57, 17);
            this.rdPreco4.TabIndex = 98;
            this.rdPreco4.TabStop = true;
            this.rdPreco4.Text = "preco4";
            this.rdPreco4.UseVisualStyleBackColor = true;
            this.rdPreco4.Visible = false;
            this.rdPreco4.CheckedChanged += new System.EventHandler(this.rdPreco4_CheckedChanged);
            // 
            // rdPreco3
            // 
            this.rdPreco3.AutoSize = true;
            this.rdPreco3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdPreco3.Location = new System.Drawing.Point(464, 9);
            this.rdPreco3.Name = "rdPreco3";
            this.rdPreco3.Size = new System.Drawing.Size(57, 17);
            this.rdPreco3.TabIndex = 98;
            this.rdPreco3.TabStop = true;
            this.rdPreco3.Text = "preco3";
            this.rdPreco3.UseVisualStyleBackColor = true;
            this.rdPreco3.Visible = false;
            this.rdPreco3.CheckedChanged += new System.EventHandler(this.rdPreco3_CheckedChanged);
            // 
            // rdPreco2
            // 
            this.rdPreco2.AutoSize = true;
            this.rdPreco2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdPreco2.Location = new System.Drawing.Point(354, 10);
            this.rdPreco2.Name = "rdPreco2";
            this.rdPreco2.Size = new System.Drawing.Size(57, 17);
            this.rdPreco2.TabIndex = 98;
            this.rdPreco2.TabStop = true;
            this.rdPreco2.Text = "preco2";
            this.rdPreco2.UseVisualStyleBackColor = true;
            this.rdPreco2.Visible = false;
            this.rdPreco2.CheckedChanged += new System.EventHandler(this.rdPreco2_CheckedChanged);
            // 
            // rdPreco1
            // 
            this.rdPreco1.AutoSize = true;
            this.rdPreco1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdPreco1.Location = new System.Drawing.Point(233, 10);
            this.rdPreco1.Name = "rdPreco1";
            this.rdPreco1.Size = new System.Drawing.Size(57, 17);
            this.rdPreco1.TabIndex = 98;
            this.rdPreco1.TabStop = true;
            this.rdPreco1.Text = "preco1";
            this.rdPreco1.UseVisualStyleBackColor = true;
            this.rdPreco1.Visible = false;
            this.rdPreco1.CheckedChanged += new System.EventHandler(this.rdPreco1_CheckedChanged);
            // 
            // cbReferenc
            // 
            this.cbReferenc.BackColor = System.Drawing.Color.Transparent;
            this.cbReferenc.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbReferenc.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbReferenc.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReferenc.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbReferenc.CbText = "Referência";
            this.cbReferenc.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbReferenc.Imagem = ((System.Drawing.Image)(resources.GetObject("cbReferenc.Imagem")));
            this.cbReferenc.IsOptionGroup = false;
            this.cbReferenc.IsReadOnly = false;
            this.cbReferenc.IsRequered = false;
            this.cbReferenc.Location = new System.Drawing.Point(3, 33);
            this.cbReferenc.Name = "cbReferenc";
            this.cbReferenc.OnlyCheckBox = true;
            this.cbReferenc.Size = new System.Drawing.Size(104, 22);
            this.cbReferenc.TabIndex = 97;
            this.cbReferenc.Value = null;
            this.cbReferenc.Value2 = null;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(9, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(676, 29);
            this.textBox2.TabIndex = 96;
            this.textBox2.Tag = "Escreva a descricao do artigo";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Controls.Add(this.gridProdutos);
            this.panel11.Location = new System.Drawing.Point(5, 89);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(683, 388);
            this.panel11.TabIndex = 92;
            // 
            // gridProdutos
            // 
            this.gridProdutos.AddButtons = true;
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProdutos.AutoIncrimento = false;
            this.gridProdutos.BackgroundColor = System.Drawing.Color.White;
            this.gridProdutos.CampoCodigo = null;
            this.gridProdutos.Codigo = null;
            this.gridProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProdutos.ColumnHeadersHeight = 30;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referencia,
            this.Codigobarras,
            this.descricao,
            this.preco,
            this.preco1,
            this.preco2,
            this.preco3,
            this.preco4,
            this.preco5,
            this.stock,
            this.ststamp});
            this.gridProdutos.Condicao = null;
            this.gridProdutos.CorPreto = true;
            this.gridProdutos.CurrentColumnName = null;
            this.gridProdutos.DefacolumnName = null;
            this.gridProdutos.DellGridRow = null;
            this.gridProdutos.DtDS = null;
            this.gridProdutos.EnableHeadersVisualStyles = false;
            this.gridProdutos.GenerateColumns = false;
            this.gridProdutos.GridColor = System.Drawing.Color.White;
            this.gridProdutos.GridFilha = true;
            this.gridProdutos.GridFilhaSecundaria = false;
            this.gridProdutos.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridProdutos.HeadersHeight = 30;
            this.gridProdutos.HeadersVisible = false;
            this.gridProdutos.Location = new System.Drawing.Point(3, 4);
            this.gridProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.OrderbyCampos = null;
            this.gridProdutos.Origem = null;
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.RowHeadersVisible = false;
            this.gridProdutos.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProdutos.RowTemplate.Height = 28;
            this.gridProdutos.Size = new System.Drawing.Size(677, 381);
            this.gridProdutos.StampCabecalho = "";
            this.gridProdutos.StampLocal = "";
            this.gridProdutos.TabelaSql = "";
            this.gridProdutos.TabIndex = 74;
            this.gridProdutos.TbCodigo = null;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "Todos Artigos";
            // 
            // referencia
            // 
            this.referencia.DataPropertyName = "referenc";
            this.referencia.HeaderText = "Referência  ";
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            // 
            // Codigobarras
            // 
            this.Codigobarras.DataPropertyName = "CodigoBarras";
            this.Codigobarras.HeaderText = "C. de Barras";
            this.Codigobarras.Name = "Codigobarras";
            this.Codigobarras.ReadOnly = true;
            this.Codigobarras.Width = 110;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 200;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.preco.DefaultCellStyle = dataGridViewCellStyle2;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 90;
            // 
            // preco1
            // 
            this.preco1.DataPropertyName = "preco1";
            this.preco1.HeaderText = "preco1";
            this.preco1.Name = "preco1";
            this.preco1.ReadOnly = true;
            this.preco1.Visible = false;
            // 
            // preco2
            // 
            this.preco2.DataPropertyName = "preco2";
            this.preco2.HeaderText = "preco2";
            this.preco2.Name = "preco2";
            this.preco2.ReadOnly = true;
            this.preco2.Visible = false;
            // 
            // preco3
            // 
            this.preco3.DataPropertyName = "preco3";
            this.preco3.HeaderText = "preco3";
            this.preco3.Name = "preco3";
            this.preco3.ReadOnly = true;
            this.preco3.Visible = false;
            // 
            // preco4
            // 
            this.preco4.DataPropertyName = "preco4";
            this.preco4.HeaderText = "preco4";
            this.preco4.Name = "preco4";
            this.preco4.ReadOnly = true;
            this.preco4.Visible = false;
            // 
            // preco5
            // 
            this.preco5.DataPropertyName = "preco5";
            this.preco5.HeaderText = "preco5";
            this.preco5.Name = "preco5";
            this.preco5.ReadOnly = true;
            this.preco5.Visible = false;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.stock.DefaultCellStyle = dataGridViewCellStyle3;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // ststamp
            // 
            this.ststamp.DataPropertyName = "ststamp";
            this.ststamp.HeaderText = "Código de barras";
            this.ststamp.Name = "ststamp";
            this.ststamp.ReadOnly = true;
            this.ststamp.Visible = false;
            // 
            // FrmArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(694, 522);
            this.Controls.Add(this.panel15);
            this.Name = "FrmArtigos";
            this.Load += new System.EventHandler(this.FrmArtigos_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel15, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel11;
        public Generic.GridUi gridProdutos;
        private Generic.DMZToolTip dmzToolTip1;
        private UC.CbDefault cbReferenc;
        public System.Windows.Forms.RadioButton rdPreco6;
        public System.Windows.Forms.RadioButton rdPreco5;
        public System.Windows.Forms.RadioButton rdPreco4;
        public System.Windows.Forms.RadioButton rdPreco3;
        public System.Windows.Forms.RadioButton rdPreco2;
        public System.Windows.Forms.RadioButton rdPreco1;
        private UC.CbDefault cbCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigobarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco2;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco3;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco4;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco5;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ststamp;
    }
}
