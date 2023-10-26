namespace DMZ.UI.UC
{
    partial class DMZModulos
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
            this.btnModulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModulo
            // 
            this.btnModulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnModulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnModulo.Image = global::DMZ.UI.Properties.Resources.Accounting_22px;
            this.btnModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModulo.Location = new System.Drawing.Point(1, 2);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(209, 33);
            this.btnModulo.TabIndex = 69;
            this.btnModulo.Text = "Contabilidade ";
            this.btnModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // DMZModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModulo);
            this.Name = "DMZModulos";
            this.Size = new System.Drawing.Size(213, 38);
            this.Load += new System.EventHandler(this.DMZModulos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnModulo;
    }
}
