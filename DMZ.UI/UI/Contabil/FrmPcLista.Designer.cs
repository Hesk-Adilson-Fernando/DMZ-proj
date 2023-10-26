
namespace DMZ.UI.UI.Contabil
{
    partial class FrmPcLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPcLista));
            this.gridContas = new DMZ.UI.Generic.GridUi();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbContasDois = new DMZ.UI.UC.CbDefault();
            this.label2 = new System.Windows.Forms.Label();
            this.nrAno = new System.Windows.Forms.NumericUpDown();
            this.rbInteg = new DMZ.UI.UC.CbDefault();
            this.rbContasMov = new DMZ.UI.UC.CbDefault();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrAno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(647, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(615, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.Text = "Plano de Contas ";
            // 
            // gridContas
            // 
            this.gridContas.AddButtons = false;
            this.gridContas.AllowUserToAddRows = false;
            this.gridContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridContas.AutoIncrimento = false;
            this.gridContas.BackgroundColor = System.Drawing.Color.White;
            this.gridContas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridContas.CampoCodigo = null;
            this.gridContas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridContas.Codigo = null;
            this.gridContas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridContas.ColumnHeadersHeight = 30;
            this.gridContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conta,
            this.descricao,
            this.ano,
            this.Tipo});
            this.gridContas.Condicao = null;
            this.gridContas.CorPreto = true;
            this.gridContas.CurrentColumnName = null;
            this.gridContas.DefacolumnName = null;
            this.gridContas.DellGridRow = null;
            this.gridContas.DtDS = null;
            this.gridContas.EnableHeadersVisualStyles = false;
            this.gridContas.GenerateColumns = false;
            this.gridContas.GridColor = System.Drawing.Color.SteelBlue;
            this.gridContas.GridFilha = true;
            this.gridContas.GridFilhaSecundaria = false;
            this.gridContas.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridContas.HeadersHeight = 30;
            this.gridContas.HeadersVisible = false;
            this.gridContas.Location = new System.Drawing.Point(8, 120);
            this.gridContas.Name = "gridContas";
            this.gridContas.OrderbyCampos = null;
            this.gridContas.Origem = null;
            this.gridContas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridContas.RowHeadersVisible = false;
            this.gridContas.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridContas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContas.Size = new System.Drawing.Size(634, 459);
            this.gridContas.StampCabecalho = "Ststamp";
            this.gridContas.StampLocal = "StPrecostamp";
            this.gridContas.TabelaSql = "StPrecos";
            this.gridContas.TabIndex = 483;
            this.gridContas.TbCodigo = null;
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
            // ano
            // 
            this.ano.DataPropertyName = "ano";
            this.ano.HeaderText = "Ano";
            this.ano.Name = "ano";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 50;
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
            this.panel1.Location = new System.Drawing.Point(8, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 83);
            this.panel1.TabIndex = 482;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnProcessar.FlatAppearance.BorderSize = 0;
            this.btnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.Location = new System.Drawing.Point(525, 8);
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
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(525, 46);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 32);
            this.btnPrint.TabIndex = 82;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.rbContasDois);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nrAno);
            this.groupBox1.Controls.Add(this.rbInteg);
            this.groupBox1.Controls.Add(this.rbContasMov);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 63);
            this.groupBox1.TabIndex = 458;
            this.groupBox1.TabStop = false;
            // 
            // rbContasDois
            // 
            this.rbContasDois.BackColor = System.Drawing.Color.Transparent;
            this.rbContasDois.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbContasDois.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbContasDois.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContasDois.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbContasDois.CbText = "Contas de dois dígitos";
            this.rbContasDois.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbContasDois.Imagem = ((System.Drawing.Image)(resources.GetObject("rbContasDois.Imagem")));
            this.rbContasDois.IsOptionGroup = false;
            this.rbContasDois.IsReadOnly = false;
            this.rbContasDois.IsRequered = false;
            this.rbContasDois.Location = new System.Drawing.Point(183, 35);
            this.rbContasDois.Name = "rbContasDois";
            this.rbContasDois.OnlyCheckBox = true;
            this.rbContasDois.Size = new System.Drawing.Size(178, 22);
            this.rbContasDois.TabIndex = 498;
            this.rbContasDois.Value = null;
            this.rbContasDois.Value2 = null;
            this.rbContasDois.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.rbContasDois_CheckedChangeds);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(386, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 497;
            this.label2.Text = "Ano Contabilístico";
            // 
            // nrAno
            // 
            this.nrAno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nrAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nrAno.Location = new System.Drawing.Point(389, 34);
            this.nrAno.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nrAno.Name = "nrAno";
            this.nrAno.Size = new System.Drawing.Size(115, 23);
            this.nrAno.TabIndex = 496;
            // 
            // rbInteg
            // 
            this.rbInteg.BackColor = System.Drawing.Color.Transparent;
            this.rbInteg.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbInteg.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbInteg.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInteg.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbInteg.CbText = "Contas de Integração";
            this.rbInteg.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbInteg.Imagem = ((System.Drawing.Image)(resources.GetObject("rbInteg.Imagem")));
            this.rbInteg.IsOptionGroup = false;
            this.rbInteg.IsReadOnly = false;
            this.rbInteg.IsRequered = false;
            this.rbInteg.Location = new System.Drawing.Point(8, 35);
            this.rbInteg.Name = "rbInteg";
            this.rbInteg.OnlyCheckBox = true;
            this.rbInteg.Size = new System.Drawing.Size(178, 22);
            this.rbInteg.TabIndex = 495;
            this.rbInteg.Value = null;
            this.rbInteg.Value2 = null;
            this.rbInteg.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.rbInteg_CheckedChangeds);
            // 
            // rbContasMov
            // 
            this.rbContasMov.BackColor = System.Drawing.Color.Transparent;
            this.rbContasMov.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbContasMov.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbContasMov.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContasMov.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbContasMov.CbText = "Contas de movimento";
            this.rbContasMov.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbContasMov.Imagem = ((System.Drawing.Image)(resources.GetObject("rbContasMov.Imagem")));
            this.rbContasMov.IsOptionGroup = false;
            this.rbContasMov.IsReadOnly = false;
            this.rbContasMov.IsRequered = false;
            this.rbContasMov.Location = new System.Drawing.Point(8, 7);
            this.rbContasMov.Name = "rbContasMov";
            this.rbContasMov.OnlyCheckBox = true;
            this.rbContasMov.Size = new System.Drawing.Size(167, 22);
            this.rbContasMov.TabIndex = 493;
            this.rbContasMov.Value = null;
            this.rbContasMov.Value2 = null;
            this.rbContasMov.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.rbContasMov_CheckedChangeds);
            // 
            // FrmPcLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(648, 591);
            this.Controls.Add(this.gridContas);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPcLista";
            this.Load += new System.EventHandler(this.FrmPcLista_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridContas, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrAno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Generic.GridUi gridContas;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnProcessar;
        public System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private UC.CbDefault rbInteg;
        private UC.CbDefault rbContasMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.NumericUpDown nrAno;
        private System.Windows.Forms.Label label2;
        private UC.CbDefault rbContasDois;
    }
}
