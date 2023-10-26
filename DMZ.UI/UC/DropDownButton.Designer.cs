namespace DMZ.UI.UC
{
    partial class DropDownButton
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.panelText = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.panel13.SuspendLayout();
            this.panelText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.Controls.Add(this.panelText);
            this.panel13.Controls.Add(this.btnOpcoes);
            this.panel13.Location = new System.Drawing.Point(1, 1);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(65, 73);
            this.panel13.TabIndex = 39;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // panelText
            // 
            this.panelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelText.BackColor = System.Drawing.Color.Coral;
            this.panelText.Controls.Add(this.label6);
            this.panelText.Controls.Add(this.pictureBox7);
            this.panelText.Location = new System.Drawing.Point(2, 37);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(61, 35);
            this.panelText.TabIndex = 42;
            this.panelText.Click += new System.EventHandler(this.btnOpcoes_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 1);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Opções";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.btnOpcoes_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox7.Image = global::DMZ.UI.Properties.Resources.Expand_Arrow_25px;
            this.pictureBox7.Location = new System.Drawing.Point(17, 13);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 22);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 43;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.btnOpcoes_Click);
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnOpcoes.FlatAppearance.BorderSize = 0;
            this.btnOpcoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcoes.ForeColor = System.Drawing.Color.White;
            this.btnOpcoes.Image = global::DMZ.UI.Properties.Resources.View_Details_23px;
            this.btnOpcoes.Location = new System.Drawing.Point(2, 3);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(61, 35);
            this.btnOpcoes.TabIndex = 30;
            this.btnOpcoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcoes.UseVisualStyleBackColor = false;
            this.btnOpcoes.Click += new System.EventHandler(this.btnOpcoes_Click);
            // 
            // DropDownButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel13);
            this.Name = "DropDownButton";
            this.Size = new System.Drawing.Size(67, 75);
            this.Load += new System.EventHandler(this.DropDownButton_Load);
            this.panel13.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.Button btnOpcoes;
    }
}
