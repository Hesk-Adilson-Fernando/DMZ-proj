namespace DMZ.UI.UC
{
    partial class DmzLateralButton
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
            this.panelLateralSelect = new System.Windows.Forms.Panel();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateralSelect
            // 
            this.panelLateralSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLateralSelect.Location = new System.Drawing.Point(0, 0);
            this.panelLateralSelect.Name = "panelLateralSelect";
            this.panelLateralSelect.Size = new System.Drawing.Size(6, 53);
            this.panelLateralSelect.TabIndex = 0;
            // 
            // panelFundo
            // 
            this.panelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFundo.Controls.Add(this.tB1);
            this.panelFundo.Controls.Add(this.btnImagem);
            this.panelFundo.Location = new System.Drawing.Point(7, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(70, 53);
            this.panelFundo.TabIndex = 1;
            this.panelFundo.Click += new System.EventHandler(this.panelFundo_Click);
            this.panelFundo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFundo_Paint);
            // 
            // tB1
            // 
            this.tB1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB1.BackColor = System.Drawing.SystemColors.Control;
            this.tB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB1.Location = new System.Drawing.Point(3, 34);
            this.tB1.Multiline = true;
            this.tB1.Name = "tB1";
            this.tB1.ReadOnly = true;
            this.tB1.Size = new System.Drawing.Size(66, 20);
            this.tB1.TabIndex = 78;
            this.tB1.Click += new System.EventHandler(this.tB1_Click);
            // 
            // btnImagem
            // 
            this.btnImagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImagem.FlatAppearance.BorderSize = 0;
            this.btnImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImagem.Image = global::DMZ.UI.Properties.Resources.Minimize_Window_28px;
            this.btnImagem.Location = new System.Drawing.Point(18, 0);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(39, 34);
            this.btnImagem.TabIndex = 77;
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // DmzLateralButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.panelLateralSelect);
            this.Name = "DmzLateralButton";
            this.Size = new System.Drawing.Size(79, 53);
            this.Load += new System.EventHandler(this.DMZLateralButton_Load);
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateralSelect;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Button btnImagem;
        public System.Windows.Forms.TextBox tB1;
    }
}
