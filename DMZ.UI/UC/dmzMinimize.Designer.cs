namespace DMZ.UI.UC
{
    partial class DmzMinimize
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
            this.btnKb = new System.Windows.Forms.Button();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.SuspendLayout();
            // 
            // btnKb
            // 
            this.btnKb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnKb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKb.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnKb.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnKb.Image = global::DMZ.UI.Properties.Resources.Text_Input_Form_25px;
            this.btnKb.Location = new System.Drawing.Point(4, 3);
            this.btnKb.Name = "btnKb";
            this.btnKb.Size = new System.Drawing.Size(36, 20);
            this.btnKb.TabIndex = 77;
            this.btnKb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKb.UseVisualStyleBackColor = false;
            this.btnKb.Click += new System.EventHandler(this.btnKb_Click);
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Software";
            // 
            // DmzMinimize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKb);
            this.Name = "DmzMinimize";
            this.Size = new System.Drawing.Size(44, 26);
            this.Load += new System.EventHandler(this.DmzMinimize_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKb;
        private Generic.DMZToolTip dmzToolTip1;
    }
}
