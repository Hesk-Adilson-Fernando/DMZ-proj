namespace DMZ.UI.UI.Contabil
{
    partial class frmListaMov
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridMov = new System.Windows.Forms.DataGridView();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrlanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDebito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbConta = new System.Windows.Forms.TextBox();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.chbMeses = new System.Windows.Forms.CheckBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMov)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(994, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(962, 2);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 44);
            // 
            // GridMov
            // 
            this.GridMov.AllowUserToAddRows = false;
            this.GridMov.AllowUserToDeleteRows = false;
            this.GridMov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conta,
            this.diario,
            this.doc,
            this.nrlanc,
            this.nrdoc,
            this.descricao,
            this.clnDebito,
            this.clnCredito,
            this.clnSaldo,
            this.data});
            this.GridMov.Location = new System.Drawing.Point(2, 74);
            this.GridMov.Name = "GridMov";
            this.GridMov.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMov.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridMov.RowHeadersWidth = 10;
            this.GridMov.Size = new System.Drawing.Size(994, 379);
            this.GridMov.TabIndex = 4;
            // 
            // conta
            // 
            this.conta.DataPropertyName = "conta";
            this.conta.HeaderText = "Conta";
            this.conta.Name = "conta";
            this.conta.ReadOnly = true;
            this.conta.Width = 90;
            // 
            // diario
            // 
            this.diario.DataPropertyName = "diario";
            this.diario.HeaderText = "Diário";
            this.diario.Name = "diario";
            this.diario.ReadOnly = true;
            this.diario.Width = 50;
            // 
            // doc
            // 
            this.doc.DataPropertyName = "docno";
            this.doc.HeaderText = "Doc.";
            this.doc.Name = "doc";
            this.doc.ReadOnly = true;
            this.doc.Width = 60;
            // 
            // nrlanc
            // 
            this.nrlanc.DataPropertyName = "nrlanc";
            this.nrlanc.HeaderText = "Nº Lanc.";
            this.nrlanc.Name = "nrlanc";
            this.nrlanc.ReadOnly = true;
            this.nrlanc.Width = 75;
            // 
            // nrdoc
            // 
            this.nrdoc.DataPropertyName = "nrdoc";
            this.nrdoc.HeaderText = "Nº Doc";
            this.nrdoc.Name = "nrdoc";
            this.nrdoc.ReadOnly = true;
            this.nrdoc.Width = 75;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descr";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // clnDebito
            // 
            this.clnDebito.DataPropertyName = "deb";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.clnDebito.DefaultCellStyle = dataGridViewCellStyle6;
            this.clnDebito.HeaderText = "Débito";
            this.clnDebito.Name = "clnDebito";
            this.clnDebito.ReadOnly = true;
            this.clnDebito.Width = 90;
            // 
            // clnCredito
            // 
            this.clnCredito.DataPropertyName = "cre";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.clnCredito.DefaultCellStyle = dataGridViewCellStyle7;
            this.clnCredito.HeaderText = "Crédito";
            this.clnCredito.Name = "clnCredito";
            this.clnCredito.ReadOnly = true;
            this.clnCredito.Width = 90;
            // 
            // clnSaldo
            // 
            this.clnSaldo.DataPropertyName = "saldo";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.clnSaldo.DefaultCellStyle = dataGridViewCellStyle8;
            this.clnSaldo.HeaderText = "Saldo";
            this.clnSaldo.Name = "clnSaldo";
            this.clnSaldo.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.data.DefaultCellStyle = dataGridViewCellStyle9;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 80;
            // 
            // tbConta
            // 
            this.tbConta.Location = new System.Drawing.Point(116, 48);
            this.tbConta.Name = "tbConta";
            this.tbConta.Size = new System.Drawing.Size(145, 20);
            this.tbConta.TabIndex = 5;
            this.tbConta.TextChanged += new System.EventHandler(this.tbConta_TextChanged);
            this.tbConta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbConta_KeyDown);
            // 
            // cmbMeses
            // 
            this.cmbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(401, 52);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(242, 21);
            this.cmbMeses.TabIndex = 10;
            this.cmbMeses.SelectedIndexChanged += new System.EventHandler(this.cmbMeses_SelectedIndexChanged);
            // 
            // chbMeses
            // 
            this.chbMeses.AutoSize = true;
            this.chbMeses.Location = new System.Drawing.Point(349, 56);
            this.chbMeses.Name = "chbMeses";
            this.chbMeses.Size = new System.Drawing.Size(46, 17);
            this.chbMeses.TabIndex = 11;
            this.chbMeses.Text = "Mês";
            this.chbMeses.UseVisualStyleBackColor = true;
            this.chbMeses.CheckedChanged += new System.EventHandler(this.chbMese_CheckedChanged);
            // 
            // frmListaMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.chbMeses);
            this.Controls.Add(this.cmbMeses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbConta);
            this.Controls.Add(this.GridMov);
            this.Name = "frmListaMov";
            this.Text = "Lista de Movimentos";
            this.Load += new System.EventHandler(this.frmListaMov_Load);
            this.Controls.SetChildIndex(this.GridMov, 0);
            this.Controls.SetChildIndex(this.tbConta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbMeses, 0);
            this.Controls.SetChildIndex(this.chbMeses, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMov;
        private System.Windows.Forms.TextBox tbConta;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.CheckBox chbMeses;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn diario;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrlanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDebito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}