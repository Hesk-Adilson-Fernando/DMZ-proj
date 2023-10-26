namespace DMZ.UI.Basic
{
    partial class PosProc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbContido = new System.Windows.Forms.CheckBox();
            this.cbProc = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblEncontrado = new System.Windows.Forms.Label();
            this.dgvProcura = new System.Windows.Forms.DataGridView();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeach2 = new System.Windows.Forms.Button();
            this.tbProc = new System.Windows.Forms.TextBox();
            this.btnProcura = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKeyBoardUsr = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnKeyBoardUsr);
            this.panel4.Size = new System.Drawing.Size(389, 31);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnKeyBoardUsr, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(355, 3);
            this.btnClose.Size = new System.Drawing.Size(28, 25);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.Text = "Procura";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbContido);
            this.panel1.Controls.Add(this.cbProc);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lblEncontrado);
            this.panel1.Controls.Add(this.dgvProcura);
            this.panel1.Controls.Add(this.btnSeach2);
            this.panel1.Controls.Add(this.tbProc);
            this.panel1.Controls.Add(this.btnProcura);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 340);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbContido
            // 
            this.cbContido.AutoSize = true;
            this.cbContido.BackColor = System.Drawing.Color.Transparent;
            this.cbContido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContido.ForeColor = System.Drawing.Color.Black;
            this.cbContido.Location = new System.Drawing.Point(8, 36);
            this.cbContido.Name = "cbContido";
            this.cbContido.Size = new System.Drawing.Size(81, 21);
            this.cbContido.TabIndex = 215;
            this.cbContido.Text = "Contido";
            this.cbContido.UseVisualStyleBackColor = false;
            // 
            // cbProc
            // 
            this.cbProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProc.AutoSize = true;
            this.cbProc.BackColor = System.Drawing.Color.Transparent;
            this.cbProc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.cbProc.Location = new System.Drawing.Point(330, 13);
            this.cbProc.Name = "cbProc";
            this.cbProc.Size = new System.Drawing.Size(15, 14);
            this.cbProc.TabIndex = 214;
            this.cbProc.UseVisualStyleBackColor = false;
            this.cbProc.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(319, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 23);
            this.numericUpDown1.TabIndex = 213;
            // 
            // lblEncontrado
            // 
            this.lblEncontrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEncontrado.AutoSize = true;
            this.lblEncontrado.Location = new System.Drawing.Point(7, 296);
            this.lblEncontrado.Name = "lblEncontrado";
            this.lblEncontrado.Size = new System.Drawing.Size(47, 17);
            this.lblEncontrado.TabIndex = 212;
            this.lblEncontrado.Text = "label2";
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
            this.dgvProcura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProcura.ColumnHeadersHeight = 30;
            this.dgvProcura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProcura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Descricao});
            this.dgvProcura.EnableHeadersVisualStyles = false;
            this.dgvProcura.GridColor = System.Drawing.Color.White;
            this.dgvProcura.Location = new System.Drawing.Point(8, 64);
            this.dgvProcura.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProcura.Name = "dgvProcura";
            this.dgvProcura.ReadOnly = true;
            this.dgvProcura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcura.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProcura.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProcura.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProcura.RowTemplate.Height = 30;
            this.dgvProcura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcura.Size = new System.Drawing.Size(369, 227);
            this.dgvProcura.TabIndex = 211;
            // 
            // Referencia
            // 
            this.Referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Referencia.HeaderText = "Referência";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 270;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // btnSeach2
            // 
            this.btnSeach2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeach2.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSeach2.FlatAppearance.BorderSize = 0;
            this.btnSeach2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSeach2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeach2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach2.ForeColor = System.Drawing.Color.White;
            this.btnSeach2.Image = global::DMZ.UI.Properties.Resources.Check_All_25px;
            this.btnSeach2.Location = new System.Drawing.Point(300, 296);
            this.btnSeach2.Name = "btnSeach2";
            this.btnSeach2.Size = new System.Drawing.Size(78, 39);
            this.btnSeach2.TabIndex = 209;
            this.btnSeach2.Text = "OK";
            this.btnSeach2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeach2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeach2.UseVisualStyleBackColor = false;
            this.btnSeach2.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // tbProc
            // 
            this.tbProc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProc.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProc.Location = new System.Drawing.Point(8, 5);
            this.tbProc.Name = "tbProc";
            this.tbProc.Size = new System.Drawing.Size(344, 29);
            this.tbProc.TabIndex = 208;
            this.tbProc.Click += new System.EventHandler(this.tbProc_Click);
            this.tbProc.Enter += new System.EventHandler(this.tbProc_Enter);
            this.tbProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProc_KeyPress);
            // 
            // btnProcura
            // 
            this.btnProcura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnProcura.FlatAppearance.BorderSize = 0;
            this.btnProcura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcura.ForeColor = System.Drawing.Color.White;
            this.btnProcura.Image = global::DMZ.UI.Properties.Resources.Search_25px;
            this.btnProcura.Location = new System.Drawing.Point(351, 5);
            this.btnProcura.Name = "btnProcura";
            this.btnProcura.Size = new System.Drawing.Size(30, 29);
            this.btnProcura.TabIndex = 207;
            this.btnProcura.UseVisualStyleBackColor = false;
            this.btnProcura.Click += new System.EventHandler(this.btnProcura_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Referência";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 270;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnKeyBoardUsr
            // 
            this.btnKeyBoardUsr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKeyBoardUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnKeyBoardUsr.FlatAppearance.BorderSize = 0;
            this.btnKeyBoardUsr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnKeyBoardUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyBoardUsr.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyBoardUsr.ForeColor = System.Drawing.Color.White;
            this.btnKeyBoardUsr.Image = global::DMZ.UI.Properties.Resources.Keyboard_25px;
            this.btnKeyBoardUsr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeyBoardUsr.Location = new System.Drawing.Point(311, 3);
            this.btnKeyBoardUsr.Name = "btnKeyBoardUsr";
            this.btnKeyBoardUsr.Size = new System.Drawing.Size(35, 25);
            this.btnKeyBoardUsr.TabIndex = 70;
            this.btnKeyBoardUsr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeyBoardUsr.UseVisualStyleBackColor = false;
            this.btnKeyBoardUsr.Click += new System.EventHandler(this.btnKeyBoardUsr_Click);
            // 
            // PosProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(390, 373);
            this.Controls.Add(this.panel1);
            this.Name = "PosProc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.POSProc_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        public System.Windows.Forms.Button btnSeach2;
        private System.Windows.Forms.TextBox tbProc;
        public System.Windows.Forms.Button btnProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblEncontrado;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.CheckBox cbProc;
        public System.Windows.Forms.CheckBox cbContido;
        public System.Windows.Forms.Button btnKeyBoardUsr;
    }
}
