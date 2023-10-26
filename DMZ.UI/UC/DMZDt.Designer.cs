namespace DMZ.UI.UC
{
    partial class DMZDt
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
            this.Ano = new System.Windows.Forms.NumericUpDown();
            this.Mes = new System.Windows.Forms.NumericUpDown();
            this.Dia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia)).BeginInit();
            this.SuspendLayout();
            // 
            // Ano
            // 
            this.Ano.BackColor = System.Drawing.Color.White;
            this.Ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Ano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Ano.Location = new System.Drawing.Point(88, 16);
            this.Ano.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(58, 20);
            this.Ano.TabIndex = 75;
            this.Ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Mes
            // 
            this.Mes.BackColor = System.Drawing.Color.White;
            this.Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Mes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Mes.Location = new System.Drawing.Point(47, 16);
            this.Mes.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(41, 20);
            this.Mes.TabIndex = 74;
            this.Mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Dia
            // 
            this.Dia.BackColor = System.Drawing.Color.White;
            this.Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Dia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Dia.Location = new System.Drawing.Point(6, 16);
            this.Dia.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(41, 20);
            this.Dia.TabIndex = 73;
            this.Dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Data de Emissão";
            // 
            // DMZDt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ano);
            this.Controls.Add(this.Mes);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.label2);
            this.Name = "DMZDt";
            this.Size = new System.Drawing.Size(151, 41);
            this.Load += new System.EventHandler(this.DMZDt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown Ano;
        public System.Windows.Forms.NumericUpDown Mes;
        public System.Windows.Forms.NumericUpDown Dia;
    }
}
