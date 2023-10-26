namespace DMZ.UI.UC
{
    partial class DMZEntreDatas
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
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.Data1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt1
            // 
            this.dt1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt1.Location = new System.Drawing.Point(2, 45);
            this.dt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(78, 21);
            this.dt1.TabIndex = 0;
            this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // dt2
            // 
            this.dt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt2.Location = new System.Drawing.Point(92, 45);
            this.dt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(78, 21);
            this.dt2.TabIndex = 1;
            // 
            // Data1
            // 
            this.Data1.AutoSize = true;
            this.Data1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data1.Location = new System.Drawing.Point(3, 27);
            this.Data1.Name = "Data1";
            this.Data1.Size = new System.Drawing.Size(41, 16);
            this.Data1.TabIndex = 2;
            this.Data1.Text = "Data1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 24);
            this.panel1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Entre datas";
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
            // DMZEntreDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data1);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.dt1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DMZEntreDatas";
            this.Size = new System.Drawing.Size(174, 70);
            this.Load += new System.EventHandler(this.EntreDatas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Data1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dt1;
        public System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckBox checkBox1;
        private Generic.DMZToolTip dmzToolTip1;
    }
}
