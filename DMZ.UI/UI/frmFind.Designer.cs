namespace DMZ.UI.UI
{
    partial class frmFind
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
            this.btnCriar = new System.Windows.Forms.Button();
            this.dgvProc = new System.Windows.Forms.DataGridView();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(463, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(431, 2);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(396, 7);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(60, 23);
            this.btnCriar.TabIndex = 10;
            this.btnCriar.UseVisualStyleBackColor = true;
            // 
            // dgvProc
            // 
            this.dgvProc.AllowUserToAddRows = false;
            this.dgvProc.AllowUserToDeleteRows = false;
            this.dgvProc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProc.Location = new System.Drawing.Point(3, 60);
            this.dgvProc.Name = "dgvProc";
            this.dgvProc.ReadOnly = true;
            this.dgvProc.RowHeadersWidth = 4;
            this.dgvProc.Size = new System.Drawing.Size(456, 288);
            this.dgvProc.TabIndex = 9;
            this.dgvProc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProc_CellContentClick);
            this.dgvProc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProc_CellContentDoubleClick);
            this.dgvProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProc_KeyPress);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(58, 34);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(397, 20);
            this.txtFind.TabIndex = 7;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(456, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.dgvProc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Name = "frmFind";
            this.Text = "Localizar";
            this.Load += new System.EventHandler(this.frmFind_Load);
            this.Controls.SetChildIndex(this.txtFind, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvProc, 0);
            this.Controls.SetChildIndex(this.btnCriar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.DataGridView dgvProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button button1;
    }
}