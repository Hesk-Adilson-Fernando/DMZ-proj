namespace DMZ.UI.UC
{
    partial class DtDefault
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
            this.label1 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // dt1
            // 
            this.dt1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dt1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dt1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dt1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dt1.CalendarTrailingForeColor = System.Drawing.Color.GreenYellow;
            this.dt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt1.Location = new System.Drawing.Point(3, 18);
            this.dt1.MinDate = new System.DateTime(1909, 11, 23, 0, 0, 0, 0);
            this.dt1.Name = "dt1";
            this.dt1.ShowCheckBox = true;
            this.dt1.Size = new System.Drawing.Size(121, 20);
            this.dt1.TabIndex = 4;
            this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // DtDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.label1);
            this.Name = "DtDefault";
            this.Size = new System.Drawing.Size(125, 42);
            this.Load += new System.EventHandler(this.dtpDefault_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dt1;

        #endregion
        // private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        // private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
    }
}
