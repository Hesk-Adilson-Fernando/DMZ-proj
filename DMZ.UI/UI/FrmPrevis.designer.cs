
namespace DMZ.UI.UI
{
    partial class FrmPrevis
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
            this.btnZomIn = new System.Windows.Forms.Button();
            this.btnZomOut = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(609, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(577, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.Text = "Editor de Texto";
            // 
            // btnZomIn
            // 
            this.btnZomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZomIn.BackColor = System.Drawing.Color.Silver;
            this.btnZomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnZomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZomIn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZomIn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnZomIn.Location = new System.Drawing.Point(502, 6);
            this.btnZomIn.Name = "btnZomIn";
            this.btnZomIn.Size = new System.Drawing.Size(28, 34);
            this.btnZomIn.TabIndex = 74;
            this.btnZomIn.Text = "+";
            this.btnZomIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZomIn.UseVisualStyleBackColor = false;
            this.btnZomIn.Click += new System.EventHandler(this.btnZomIn_Click);
            // 
            // btnZomOut
            // 
            this.btnZomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZomOut.BackColor = System.Drawing.Color.Silver;
            this.btnZomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnZomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZomOut.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZomOut.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnZomOut.Location = new System.Drawing.Point(536, 6);
            this.btnZomOut.Name = "btnZomOut";
            this.btnZomOut.Size = new System.Drawing.Size(28, 34);
            this.btnZomOut.TabIndex = 75;
            this.btnZomOut.Text = "-";
            this.btnZomOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZomOut.UseVisualStyleBackColor = false;
            this.btnZomOut.Click += new System.EventHandler(this.btnZomOut_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompras.BackColor = System.Drawing.Color.Silver;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCompras.Image = global::DMZ.UI.Properties.Resources.Monitor_25px;
            this.btnCompras.Location = new System.Drawing.Point(570, 6);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(28, 34);
            this.btnCompras.TabIndex = 76;
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // tbAbout
            // 
            this.tbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAbout.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAbout.Location = new System.Drawing.Point(3, 35);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(605, 329);
            this.tbAbout.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnZomOut);
            this.panel1.Controls.Add(this.btnZomIn);
            this.panel1.Controls.Add(this.btnCompras);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(2, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 44);
            this.panel1.TabIndex = 77;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FrmPrevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbAbout);
            this.Name = "FrmPrevis";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FrmPrevis_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tbAbout, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnZomIn;
        public System.Windows.Forms.Button btnZomOut;
        public System.Windows.Forms.Button btnCompras;
        public System.Windows.Forms.TextBox tbAbout;
        private System.Windows.Forms.Panel panel1;
    }
}