namespace DMZ.UI.Basic
{
    partial class FrmSelect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnProcess = new System.Windows.Forms.Button();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.gridUi2 = new DMZ.UI.Generic.GridUi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMoveAllPrev = new System.Windows.Forms.Button();
            this.btnMoveAllNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.tbProcura = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(639, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(610, 1);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.Text = "Processamento";
            // 
            // BtnProcess
            // 
            this.BtnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProcess.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnProcess.FlatAppearance.BorderSize = 0;
            this.BtnProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcess.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcess.ForeColor = System.Drawing.Color.White;
            this.BtnProcess.Image = global::DMZ.UI.Properties.Resources.Process_20px;
            this.BtnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProcess.Location = new System.Drawing.Point(516, 5);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(115, 29);
            this.BtnProcess.TabIndex = 59;
            this.BtnProcess.Text = "Processar";
            this.BtnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProcess.UseVisualStyleBackColor = false;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            this.gridUi1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.Color.White;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(104)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUi1.GridFilha = false;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(3, 74);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi1.Size = new System.Drawing.Size(282, 316);
            this.gridUi1.StampCabecalho = null;
            this.gridUi1.StampLocal = null;
            this.gridUi1.TabelaSql = null;
            this.gridUi1.TabIndex = 0;
            this.gridUi1.TbCodigo = null;
            // 
            // gridUi2
            // 
            this.gridUi2.AddButtons = false;
            this.gridUi2.AllowUserToAddRows = false;
            this.gridUi2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUi2.AutoIncrimento = false;
            this.gridUi2.BackgroundColor = System.Drawing.Color.White;
            this.gridUi2.CampoCodigo = null;
            this.gridUi2.Codigo = null;
            this.gridUi2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(104)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUi2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUi2.Condicao = null;
            this.gridUi2.CorPreto = false;
            this.gridUi2.CurrentColumnName = null;
            this.gridUi2.DefacolumnName = null;
            this.gridUi2.DellGridRow = null;
            this.gridUi2.DtDS = null;
            this.gridUi2.EnableHeadersVisualStyles = false;
            this.gridUi2.GenerateColumns = false;
            this.gridUi2.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUi2.GridFilha = false;
            this.gridUi2.GridFilhaSecundaria = false;
            this.gridUi2.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi2.HeadersHeight = 30;
            this.gridUi2.HeadersVisible = false;
            this.gridUi2.Location = new System.Drawing.Point(343, 74);
            this.gridUi2.Name = "gridUi2";
            this.gridUi2.OrderbyCampos = null;
            this.gridUi2.Origem = null;
            this.gridUi2.RowHeadersVisible = false;
            this.gridUi2.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUi2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi2.Size = new System.Drawing.Size(294, 316);
            this.gridUi2.StampCabecalho = null;
            this.gridUi2.StampLocal = null;
            this.gridUi2.TabelaSql = null;
            this.gridUi2.TabIndex = 60;
            this.gridUi2.TbCodigo = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMoveAllPrev);
            this.panel1.Controls.Add(this.btnMoveAllNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Location = new System.Drawing.Point(291, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 351);
            this.panel1.TabIndex = 61;
            // 
            // btnMoveAllPrev
            // 
            this.btnMoveAllPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMoveAllPrev.FlatAppearance.BorderSize = 0;
            this.btnMoveAllPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMoveAllPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveAllPrev.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAllPrev.ForeColor = System.Drawing.Color.White;
            this.btnMoveAllPrev.Image = global::DMZ.UI.Properties.Resources.Double_Left_23px;
            this.btnMoveAllPrev.Location = new System.Drawing.Point(8, 160);
            this.btnMoveAllPrev.Name = "btnMoveAllPrev";
            this.btnMoveAllPrev.Size = new System.Drawing.Size(28, 26);
            this.btnMoveAllPrev.TabIndex = 30;
            this.dmzToolTip1.SetToolTip(this.btnMoveAllPrev, "Tudo para Tabela Anterior");
            this.btnMoveAllPrev.UseVisualStyleBackColor = false;
            // 
            // btnMoveAllNext
            // 
            this.btnMoveAllNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMoveAllNext.FlatAppearance.BorderSize = 0;
            this.btnMoveAllNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMoveAllNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveAllNext.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAllNext.ForeColor = System.Drawing.Color.White;
            this.btnMoveAllNext.Image = global::DMZ.UI.Properties.Resources.Double_Right_25px;
            this.btnMoveAllNext.Location = new System.Drawing.Point(8, 133);
            this.btnMoveAllNext.Name = "btnMoveAllNext";
            this.btnMoveAllNext.Size = new System.Drawing.Size(28, 26);
            this.btnMoveAllNext.TabIndex = 29;
            this.dmzToolTip1.SetToolTip(this.btnMoveAllNext, "Tudo pa Tabela seguinte");
            this.btnMoveAllNext.UseVisualStyleBackColor = false;
            this.btnMoveAllNext.Click += new System.EventHandler(this.btnMoveAllNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = global::DMZ.UI.Properties.Resources.Less_Than_25px_2;
            this.btnPrev.Location = new System.Drawing.Point(8, 67);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 26);
            this.btnPrev.TabIndex = 28;
            this.dmzToolTip1.SetToolTip(this.btnPrev, "Tabela Anterior");
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::DMZ.UI.Properties.Resources.More_Than_25px;
            this.btnNext.Location = new System.Drawing.Point(8, 40);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 26);
            this.btnNext.TabIndex = 27;
            this.dmzToolTip1.SetToolTip(this.btnNext, "Tabela seguinte");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Software";
            // 
            // tbProcura
            // 
            this.tbProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbProcura.Location = new System.Drawing.Point(3, 39);
            this.tbProcura.Name = "tbProcura";
            this.tbProcura.Size = new System.Drawing.Size(282, 29);
            this.tbProcura.TabIndex = 210;
            this.tbProcura.TextChanged += new System.EventHandler(this.tbProcura_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(343, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 29);
            this.textBox1.TabIndex = 211;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.BtnProcess);
            this.panel2.Location = new System.Drawing.Point(3, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 38);
            this.panel2.TabIndex = 212;
            // 
            // FrmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbProcura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridUi2);
            this.Controls.Add(this.gridUi1);
            this.Name = "FrmSelect";
            this.Load += new System.EventHandler(this.FrmSelect_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.gridUi1, 0);
            this.Controls.SetChildIndex(this.gridUi2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tbProcura, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnProcess;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnMoveAllPrev;
        public System.Windows.Forms.Button btnMoveAllNext;
        public System.Windows.Forms.Button btnPrev;
        public System.Windows.Forms.Button btnNext;
        public Generic.GridUi gridUi1;
        public Generic.GridUi gridUi2;
        private Generic.DMZToolTip dmzToolTip1;
        private System.Windows.Forms.TextBox tbProcura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
    }
}
