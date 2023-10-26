namespace DMZ.UI.UI
{
    partial class DMZLICPW
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnValorPanelShow = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(260, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(228, 2);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnValorPanelShow);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 130);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnValorPanelShow
            // 
            this.btnValorPanelShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValorPanelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnValorPanelShow.FlatAppearance.BorderSize = 0;
            this.btnValorPanelShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValorPanelShow.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnValorPanelShow.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnValorPanelShow.Image = global::DMZ.UI.Properties.Resources.Approval_28px;
            this.btnValorPanelShow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValorPanelShow.Location = new System.Drawing.Point(40, 75);
            this.btnValorPanelShow.Name = "btnValorPanelShow";
            this.btnValorPanelShow.Size = new System.Drawing.Size(174, 31);
            this.btnValorPanelShow.TabIndex = 89;
            this.btnValorPanelShow.Text = "Executar";
            this.btnValorPanelShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValorPanelShow.UseVisualStyleBackColor = false;
            this.btnValorPanelShow.Click += new System.EventHandler(this.btnValorPanelShow_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(41, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 29);
            this.textBox1.TabIndex = 88;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // DMZLICPW
            // 
            this.AcceptButton = this.btnValorPanelShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(261, 163);
            this.Controls.Add(this.panel1);
            this.Name = "DMZLICPW";
            this.Load += new System.EventHandler(this.DMZLICPW_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnValorPanelShow;
        private System.Windows.Forms.TextBox textBox1;
    }
}
