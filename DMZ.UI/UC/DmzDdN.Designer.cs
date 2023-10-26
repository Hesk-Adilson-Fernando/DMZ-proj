
namespace DMZ.UI.UC
{
    partial class DmzDdN
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
            this.ano = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.ano)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ano
            // 
            this.ano.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ano.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano.Location = new System.Drawing.Point(0, 25);
            this.ano.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(112, 22);
            this.ano.TabIndex = 92;
            this.ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ano.ValueChanged += new System.EventHandler(this.ano_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 24);
            this.panel1.TabIndex = 93;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Ano";
            this.dmzToolTip1.SetToolTip(this.checkBox1, "Incluir/Excluir o filtro");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ SOFTWARE 2022";
            // 
            // DmzDdN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ano);
            this.Name = "DmzDdN";
            this.Size = new System.Drawing.Size(114, 48);
            this.Load += new System.EventHandler(this.DmzDdN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ano)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.NumericUpDown ano;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckBox checkBox1;
        private Generic.DMZToolTip dmzToolTip1;
    }
}
