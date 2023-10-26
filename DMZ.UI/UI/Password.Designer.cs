namespace DMZ.UI.UI
{
    partial class Password
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSenhaNovaRepetir = new System.Windows.Forms.TextBox();
            this.lblErrorSenha = new System.Windows.Forms.Label();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.tbSenhaNova = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblSoftwareVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSenhaActual = new System.Windows.Forms.TextBox();
            this.lblUsr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSenhaNovaRepetir
            // 
            this.tbSenhaNovaRepetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbSenhaNovaRepetir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSenhaNovaRepetir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenhaNovaRepetir.ForeColor = System.Drawing.Color.White;
            this.tbSenhaNovaRepetir.Location = new System.Drawing.Point(12, 243);
            this.tbSenhaNovaRepetir.Name = "tbSenhaNovaRepetir";
            this.tbSenhaNovaRepetir.Size = new System.Drawing.Size(196, 27);
            this.tbSenhaNovaRepetir.TabIndex = 23;
            this.tbSenhaNovaRepetir.UseSystemPasswordChar = true;
            // 
            // lblErrorSenha
            // 
            this.lblErrorSenha.AutoSize = true;
            this.lblErrorSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblErrorSenha.Location = new System.Drawing.Point(12, 225);
            this.lblErrorSenha.Name = "lblErrorSenha";
            this.lblErrorSenha.Size = new System.Drawing.Size(136, 17);
            this.lblErrorSenha.TabIndex = 22;
            this.lblErrorSenha.Text = "Repetir Nova Senha";
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.AutoSize = true;
            this.lblErrorUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblErrorUsuario.Location = new System.Drawing.Point(12, 175);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(87, 17);
            this.lblErrorUsuario.TabIndex = 21;
            this.lblErrorUsuario.Text = "Nova Senha";
            // 
            // tbSenhaNova
            // 
            this.tbSenhaNova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbSenhaNova.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSenhaNova.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenhaNova.ForeColor = System.Drawing.Color.White;
            this.tbSenhaNova.Location = new System.Drawing.Point(12, 194);
            this.tbSenhaNova.Multiline = true;
            this.tbSenhaNova.Name = "tbSenhaNova";
            this.tbSenhaNova.Size = new System.Drawing.Size(196, 25);
            this.tbSenhaNova.TabIndex = 20;
            this.tbSenhaNova.UseSystemPasswordChar = true;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOk.Location = new System.Drawing.Point(150, 284);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(55, 32);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DMZBD_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblSoftwareVersion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 29);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DMZ.UI.Properties.Resources.icon_cerrar2;
            this.btnClose.Location = new System.Drawing.Point(196, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblSoftwareVersion
            // 
            this.lblSoftwareVersion.AutoSize = true;
            this.lblSoftwareVersion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareVersion.ForeColor = System.Drawing.Color.White;
            this.lblSoftwareVersion.Location = new System.Drawing.Point(3, 5);
            this.lblSoftwareVersion.Name = "lblSoftwareVersion";
            this.lblSoftwareVersion.Size = new System.Drawing.Size(45, 16);
            this.lblSoftwareVersion.TabIndex = 13;
            this.lblSoftwareVersion.Text = "label2";
            this.lblSoftwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSoftwareVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSoftwareVersion_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(11, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Senha Actual";
            // 
            // tbSenhaActual
            // 
            this.tbSenhaActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbSenhaActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSenhaActual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenhaActual.ForeColor = System.Drawing.Color.White;
            this.tbSenhaActual.Location = new System.Drawing.Point(11, 145);
            this.tbSenhaActual.Multiline = true;
            this.tbSenhaActual.Name = "tbSenhaActual";
            this.tbSenhaActual.Size = new System.Drawing.Size(196, 25);
            this.tbSenhaActual.TabIndex = 24;
            this.tbSenhaActual.UseSystemPasswordChar = true;
            // 
            // lblUsr
            // 
            this.lblUsr.AutoSize = true;
            this.lblUsr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsr.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsr.Location = new System.Drawing.Point(57, 62);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(66, 21);
            this.lblUsr.TabIndex = 26;
            this.lblUsr.Text = "Usuário";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(219, 321);
            this.Controls.Add(this.lblUsr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSenhaActual);
            this.Controls.Add(this.tbSenhaNovaRepetir);
            this.Controls.Add(this.lblErrorSenha);
            this.Controls.Add(this.lblErrorUsuario);
            this.Controls.Add(this.tbSenhaNova);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Password";
            this.Text = "Password";
            this.Load += new System.EventHandler(this.Password_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DMZBD_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSenhaNovaRepetir;
        private System.Windows.Forms.Label lblErrorSenha;
        private System.Windows.Forms.Label lblErrorUsuario;
        private System.Windows.Forms.TextBox tbSenhaNova;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblSoftwareVersion;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbSenhaActual;
        public System.Windows.Forms.Label lblUsr;
    }
}