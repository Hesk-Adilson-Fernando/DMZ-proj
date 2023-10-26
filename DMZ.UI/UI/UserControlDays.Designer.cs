namespace DMZ.UI.UI
{
    partial class UserControlDays
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
            this.lblevent = new System.Windows.Forms.Label();
            this.lbdays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblevent
            // 
            this.lblevent.Location = new System.Drawing.Point(0, 38);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(100, 22);
            this.lblevent.TabIndex = 4;
            this.lblevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblevent.Click += new System.EventHandler(this.lblevent_Click);
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.Location = new System.Drawing.Point(41, 16);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(20, 17);
            this.lbdays.TabIndex = 3;
            this.lbdays.Text = "00";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(100, 60);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbdays;
        public System.Windows.Forms.Label lblevent;
    }
}
