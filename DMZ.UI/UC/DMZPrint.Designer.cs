
namespace DMZ.UI.UC
{
    partial class DMZPrint
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.MenuPrint = new DMZ.UI.UC.DMZContextMenuStrip();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.nORMALDIRECTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.Location = new System.Drawing.Point(3, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(29, 32);
            this.btnPrint.TabIndex = 96;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // MenuPrint
            // 
            this.MenuPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.MenuPrint.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.MenuPrint.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.MenuPrint.ForeColor = System.Drawing.Color.White;
            this.MenuPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.nToolStripMenuItem,
            this.toolStripSeparator3,
            this.nORMALDIRECTOToolStripMenuItem});
            this.MenuPrint.Name = "dmzContextMenuStrip1";
            this.MenuPrint.Size = new System.Drawing.Size(189, 106);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::DMZ.UI.Properties.Resources.red_file_25px;
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(188, 32);
            this.toolStripMenuItem6.Text = "PREVISUALIZAR PT";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.analyze_25px;
            this.nToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.nToolStripMenuItem.Text = "PREVISUALIZAR EN";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // nORMALDIRECTOToolStripMenuItem
            // 
            this.nORMALDIRECTOToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.print_gradient_25px;
            this.nORMALDIRECTOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nORMALDIRECTOToolStripMenuItem.Name = "nORMALDIRECTOToolStripMenuItem";
            this.nORMALDIRECTOToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.nORMALDIRECTOToolStripMenuItem.Text = "IMPRIMIR DIRECTO";
            // 
            // DMZPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Name = "DMZPrint";
            this.Size = new System.Drawing.Size(42, 30);
            this.MenuPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnPrint;
        private DMZContextMenuStrip MenuPrint;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem nORMALDIRECTOToolStripMenuItem;
    }
}
