namespace DMZ.UI.Basic
{
    partial class Proc2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbContido = new System.Windows.Forms.CheckBox();
            this.lblEncontrado = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnSeach2 = new System.Windows.Forms.Button();
            this.tbProc = new System.Windows.Forms.TextBox();
            this.btnSeach = new System.Windows.Forms.Button();
            this.cbProc = new System.Windows.Forms.CheckBox();
            this.dgvProcura = new System.Windows.Forms.DataGridView();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCcusto = new System.Windows.Forms.CheckBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(457, 26);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(431, 2);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.Text = "Procurar";
            // 
            // cbContido
            // 
            this.cbContido.AutoSize = true;
            this.cbContido.BackColor = System.Drawing.Color.Transparent;
            this.cbContido.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContido.ForeColor = System.Drawing.Color.Black;
            this.cbContido.Location = new System.Drawing.Point(10, 75);
            this.cbContido.Name = "cbContido";
            this.cbContido.Size = new System.Drawing.Size(70, 20);
            this.cbContido.TabIndex = 198;
            this.cbContido.Text = "Contido";
            this.cbContido.UseVisualStyleBackColor = false;
            // 
            // lblEncontrado
            // 
            this.lblEncontrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEncontrado.AutoSize = true;
            this.lblEncontrado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncontrado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncontrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.lblEncontrado.Location = new System.Drawing.Point(13, 286);
            this.lblEncontrado.Name = "lblEncontrado";
            this.lblEncontrado.Size = new System.Drawing.Size(57, 16);
            this.lblEncontrado.TabIndex = 195;
            this.lblEncontrado.Text = "Procura";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Location = new System.Drawing.Point(18, 82);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(0, 13);
            this.lblDescricao.TabIndex = 192;
            // 
            // btnSeach2
            // 
            this.btnSeach2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeach2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnSeach2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSeach2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeach2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSeach2.Image = global::DMZ.UI.Properties.Resources.Checked_23px;
            this.btnSeach2.Location = new System.Drawing.Point(347, 285);
            this.btnSeach2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeach2.Name = "btnSeach2";
            this.btnSeach2.Size = new System.Drawing.Size(103, 32);
            this.btnSeach2.TabIndex = 203;
            this.btnSeach2.Text = "Aceitar";
            this.btnSeach2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSeach2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeach2.UseVisualStyleBackColor = false;
            this.btnSeach2.Click += new System.EventHandler(this.btnSeach2_Click);
            // 
            // tbProc
            // 
            this.tbProc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProc.Location = new System.Drawing.Point(10, 51);
            this.tbProc.Margin = new System.Windows.Forms.Padding(2);
            this.tbProc.Name = "tbProc";
            this.tbProc.Size = new System.Drawing.Size(417, 23);
            this.tbProc.TabIndex = 202;
            // 
            // btnSeach
            // 
            this.btnSeach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnSeach.FlatAppearance.BorderSize = 0;
            this.btnSeach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeach.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.ForeColor = System.Drawing.Color.White;
            this.btnSeach.Image = global::DMZ.UI.Properties.Resources.Search_25px;
            this.btnSeach.Location = new System.Drawing.Point(427, 51);
            this.btnSeach.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(22, 23);
            this.btnSeach.TabIndex = 201;
            this.btnSeach.UseVisualStyleBackColor = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // cbProc
            // 
            this.cbProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProc.AutoSize = true;
            this.cbProc.BackColor = System.Drawing.Color.Transparent;
            this.cbProc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.cbProc.Location = new System.Drawing.Point(406, 57);
            this.cbProc.Name = "cbProc";
            this.cbProc.Size = new System.Drawing.Size(15, 14);
            this.cbProc.TabIndex = 204;
            this.cbProc.UseVisualStyleBackColor = false;
            this.cbProc.Visible = false;
            // 
            // dgvProcura
            // 
            this.dgvProcura.AllowUserToAddRows = false;
            this.dgvProcura.AllowUserToDeleteRows = false;
            this.dgvProcura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcura.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProcura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcura.ColumnHeadersHeight = 30;
            this.dgvProcura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProcura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Descricao,
            this.Quant});
            this.dgvProcura.EnableHeadersVisualStyles = false;
            this.dgvProcura.GridColor = System.Drawing.Color.White;
            this.dgvProcura.Location = new System.Drawing.Point(10, 97);
            this.dgvProcura.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProcura.Name = "dgvProcura";
            this.dgvProcura.ReadOnly = true;
            this.dgvProcura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcura.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcura.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProcura.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProcura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcura.Size = new System.Drawing.Size(439, 182);
            this.dgvProcura.TabIndex = 205;
            this.dgvProcura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcura_CellDoubleClick);
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referência";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.Width = 130;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Quant
            // 
            this.Quant.HeaderText = "Quantidade";
            this.Quant.Name = "Quant";
            this.Quant.ReadOnly = true;
            this.Quant.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(387, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 23);
            this.numericUpDown1.TabIndex = 189;
            this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown1_Enter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Referência";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // cbCcusto
            // 
            this.cbCcusto.AutoSize = true;
            this.cbCcusto.BackColor = System.Drawing.Color.Transparent;
            this.cbCcusto.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCcusto.ForeColor = System.Drawing.Color.Black;
            this.cbCcusto.Location = new System.Drawing.Point(131, 74);
            this.cbCcusto.Name = "cbCcusto";
            this.cbCcusto.Size = new System.Drawing.Size(163, 20);
            this.cbCcusto.TabIndex = 206;
            this.cbCcusto.Text = "Todos os centros de custo";
            this.cbCcusto.UseVisualStyleBackColor = false;
            // 
            // Proc2
            // 
            this.AcceptButton = this.btnSeach;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(457, 323);
            this.Controls.Add(this.cbCcusto);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.dgvProcura);
            this.Controls.Add(this.cbProc);
            this.Controls.Add(this.btnSeach2);
            this.Controls.Add(this.tbProc);
            this.Controls.Add(this.cbContido);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblEncontrado);
            this.Controls.Add(this.lblDescricao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = true;
            this.Name = "Proc2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Proc2_FormClosed);
            this.Load += new System.EventHandler(this.Proc2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Proc2_MouseDown);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.lblEncontrado, 0);
            this.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.Controls.SetChildIndex(this.cbContido, 0);
            this.Controls.SetChildIndex(this.tbProc, 0);
            this.Controls.SetChildIndex(this.btnSeach2, 0);
            this.Controls.SetChildIndex(this.cbProc, 0);
            this.Controls.SetChildIndex(this.dgvProcura, 0);
            this.Controls.SetChildIndex(this.btnSeach, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.cbCcusto, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        public System.Windows.Forms.Label lblEncontrado;
        public System.Windows.Forms.CheckBox cbContido;
        public System.Windows.Forms.Button btnSeach2;
        private System.Windows.Forms.TextBox tbProc;
        public System.Windows.Forms.Button btnSeach;
        public System.Windows.Forms.CheckBox cbProc;
        private System.Windows.Forms.DataGridView dgvProcura;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.CheckBox cbCcusto;
    }
}