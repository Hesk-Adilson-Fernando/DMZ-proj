namespace DMZ.UI.UC
{
    partial class Procartigos
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
            this.tbProcArtigos = new System.Windows.Forms.TextBox();
            this.cbDefaultproc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbProcArtigos
            // 
            this.tbProcArtigos.Location = new System.Drawing.Point(104, 4);
            this.tbProcArtigos.Name = "tbProcArtigos";
            this.tbProcArtigos.Size = new System.Drawing.Size(186, 20);
            this.tbProcArtigos.TabIndex = 0;
            this.tbProcArtigos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProcArtigos_KeyPress);
            // 
            // cbDefaultproc
            // 
            this.cbDefaultproc.FormattingEnabled = true;
            this.cbDefaultproc.Location = new System.Drawing.Point(8, 3);
            this.cbDefaultproc.Name = "cbDefaultproc";
            this.cbDefaultproc.Size = new System.Drawing.Size(94, 21);
            this.cbDefaultproc.TabIndex = 1;
            // 
            // Procartigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbDefaultproc);
            this.Controls.Add(this.tbProcArtigos);
            this.Name = "Procartigos";
            this.Size = new System.Drawing.Size(296, 29);
            this.Load += new System.EventHandler(this.Procartigos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox tbProcArtigos;
        private System.Windows.Forms.ComboBox cbDefaultproc;
    }
}
