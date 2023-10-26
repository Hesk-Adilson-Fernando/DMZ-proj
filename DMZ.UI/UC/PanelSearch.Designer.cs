namespace DMZ.UI.UC
{
    partial class PanelSearch
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
            this.panelText = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelText
            // 
            this.panelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panelText.Controls.Add(this.textBox1);
            this.panelText.Controls.Add(this.btnCheck);
            this.panelText.Controls.Add(this.cb1);
            this.panelText.Location = new System.Drawing.Point(3, 2);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(313, 30);
            this.panelText.TabIndex = 72;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheck.Image = global::DMZ.UI.Properties.Resources.Unchecked_Checkbox_23px;
            this.btnCheck.Location = new System.Drawing.Point(3, 1);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(25, 26);
            this.btnCheck.TabIndex = 36;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.ForeColor = System.Drawing.Color.White;
            this.cb1.Location = new System.Drawing.Point(10, 4);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(87, 20);
            this.cb1.TabIndex = 37;
            this.cb1.Text = "Descrição";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // PanelSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelText);
            this.Name = "PanelSearch";
            this.Size = new System.Drawing.Size(326, 32);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnCheck;
        public System.Windows.Forms.CheckBox cb1;
    }
}
