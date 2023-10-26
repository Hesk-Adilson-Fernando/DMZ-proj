namespace DMZ.UI.UC
{
    partial class DMZNumero
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcura2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcura2
            // 
            this.btnProcura2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcura2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcura2.FlatAppearance.BorderSize = 0;
            this.btnProcura2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcura2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcura2.ForeColor = System.Drawing.Color.Transparent;
            this.btnProcura2.Image = global::DMZ.UI.Properties.Resources.Search_19px;
            this.btnProcura2.Location = new System.Drawing.Point(75, 16);
            this.btnProcura2.Name = "btnProcura2";
            this.btnProcura2.Size = new System.Drawing.Size(23, 21);
            this.btnProcura2.TabIndex = 37;
            this.btnProcura2.UseVisualStyleBackColor = false;
            this.btnProcura2.Click += new System.EventHandler(this.btnProcura2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // nud1
            // 
            this.nud1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud1.Location = new System.Drawing.Point(6, 17);
            this.nud1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(67, 20);
            this.nud1.TabIndex = 38;
            this.nud1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DMZNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.btnProcura2);
            this.Controls.Add(this.label1);
            this.Name = "DMZNumero";
            this.Size = new System.Drawing.Size(100, 40);
            this.Load += new System.EventHandler(this.DMZNumero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnProcura2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nud1;
    }
}
