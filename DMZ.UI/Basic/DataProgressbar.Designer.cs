namespace DMZ.UI.Basic
{
    partial class DataProgressbar
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
            this.labelTempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenuLateral = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(382, 26);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(354, 1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTempo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnMenuLateral);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 112);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempo.ForeColor = System.Drawing.Color.Maroon;
            this.labelTempo.Location = new System.Drawing.Point(30, 88);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTempo.Size = new System.Drawing.Size(74, 16);
            this.labelTempo.TabIndex = 70;
            this.labelTempo.Text = "Processing %";
            this.labelTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Processing ";
            // 
            // btnMenuLateral
            // 
            this.btnMenuLateral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMenuLateral.FlatAppearance.BorderSize = 0;
            this.btnMenuLateral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMenuLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuLateral.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuLateral.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMenuLateral.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnMenuLateral.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuLateral.Location = new System.Drawing.Point(276, 75);
            this.btnMenuLateral.Name = "btnMenuLateral";
            this.btnMenuLateral.Size = new System.Drawing.Size(96, 32);
            this.btnMenuLateral.TabIndex = 68;
            this.btnMenuLateral.Text = "Iniciar";
            this.btnMenuLateral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuLateral.UseVisualStyleBackColor = false;
            this.btnMenuLateral.Visible = false;
            this.btnMenuLateral.Click += new System.EventHandler(this.btnMenuLateral_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lblStatus.Location = new System.Drawing.Point(30, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 17);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Processing %";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.progressBar1.Location = new System.Drawing.Point(27, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(345, 34);
            this.progressBar1.TabIndex = 0;
            // 
            // DataProgressbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(383, 139);
            this.Controls.Add(this.panel1);
            this.Name = "DataProgressbar";
            this.Load += new System.EventHandler(this.DataProgressbar_Load);
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Button btnMenuLateral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTempo;
    }
}
