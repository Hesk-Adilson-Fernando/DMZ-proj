namespace DMZ.UI.UC
{
    partial class PosButtomGroup
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
            this.btnCodigo = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnDescricao = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCodigo
            // 
            this.btnCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnCodigo.FlatAppearance.BorderSize = 0;
            this.btnCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.ForeColor = System.Drawing.Color.White;
            this.btnCodigo.Image = global::DMZ.UI.Properties.Resources.Checkmark_25px;
            this.btnCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodigo.Location = new System.Drawing.Point(3, 3);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(83, 24);
            this.btnCodigo.TabIndex = 29;
            this.btnCodigo.Text = "Código";
            this.btnCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCodigo.UseVisualStyleBackColor = false;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // btnBarcode
            // 
            this.btnBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnBarcode.FlatAppearance.BorderSize = 0;
            this.btnBarcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarcode.ForeColor = System.Drawing.Color.White;
            this.btnBarcode.Image = global::DMZ.UI.Properties.Resources.Checkmark_25px;
            this.btnBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarcode.Location = new System.Drawing.Point(88, 3);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(89, 24);
            this.btnBarcode.TabIndex = 30;
            this.btnBarcode.Text = "Barcode";
            this.btnBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarcode.UseVisualStyleBackColor = false;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // btnDescricao
            // 
            this.btnDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnDescricao.FlatAppearance.BorderSize = 0;
            this.btnDescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescricao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescricao.ForeColor = System.Drawing.Color.White;
            this.btnDescricao.Image = global::DMZ.UI.Properties.Resources.Checkmark_25px;
            this.btnDescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescricao.Location = new System.Drawing.Point(179, 3);
            this.btnDescricao.Name = "btnDescricao";
            this.btnDescricao.Size = new System.Drawing.Size(98, 24);
            this.btnDescricao.TabIndex = 31;
            this.btnDescricao.Text = "Descrição";
            this.btnDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescricao.UseVisualStyleBackColor = false;
            this.btnDescricao.Click += new System.EventHandler(this.btnDescricao_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(3, 28);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(274, 26);
            this.txtCodigo.TabIndex = 32;
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // PosButtomGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnDescricao);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.btnCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PosButtomGroup";
            this.Size = new System.Drawing.Size(279, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCodigo;
        public System.Windows.Forms.Button btnBarcode;
        public System.Windows.Forms.Button btnDescricao;
        public System.Windows.Forms.TextBox txtCodigo;
    }
}
