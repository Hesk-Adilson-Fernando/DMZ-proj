
namespace DMZ.UI.UI.Procr
{
    partial class FrmEnviarEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnviarEmail));
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtEnviadoPor = new System.Windows.Forms.TextBox();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.grpMensagem = new System.Windows.Forms.GroupBox();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.grbDePara = new System.Windows.Forms.GroupBox();
            this.txtSenhaRemet = new System.Windows.Forms.TextBox();
            this.txtEnviarPara = new System.Windows.Forms.TextBox();
            this.lblSubjectLine = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRemetente = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpMensagem.SuspendLayout();
            this.grbDePara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(551, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(519, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.Text = "Envio de Email";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Image = global::DMZ.UI.Properties.Resources.email_send_20px;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(382, 529);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(117, 35);
            this.btnEnviar.TabIndex = 114;
            this.btnEnviar.TabStop = false;
            this.btnEnviar.Text = " &Enviar [ F5 ]";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(70, 122);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(399, 20);
            this.txtAssunto.TabIndex = 2;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(14, 20);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(455, 167);
            this.txtMensagem.TabIndex = 0;
            // 
            // txtEnviadoPor
            // 
            this.txtEnviadoPor.Location = new System.Drawing.Point(70, 31);
            this.txtEnviadoPor.Name = "txtEnviadoPor";
            this.txtEnviadoPor.Size = new System.Drawing.Size(399, 20);
            this.txtEnviadoPor.TabIndex = 1;
            // 
            // btnAnexar
            // 
            this.btnAnexar.BackColor = System.Drawing.Color.White;
            this.btnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexar.Image = global::DMZ.UI.Properties.Resources.email_send_20px;
            this.btnAnexar.Location = new System.Drawing.Point(14, 208);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(129, 35);
            this.btnAnexar.TabIndex = 1;
            this.btnAnexar.TabStop = false;
            this.btnAnexar.Text = " &Anexar [ F9 ]";
            this.btnAnexar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnexar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnexar.UseVisualStyleBackColor = false;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // grpMensagem
            // 
            this.grpMensagem.Controls.Add(this.btnAnexar);
            this.grpMensagem.Controls.Add(this.txtAnexo);
            this.grpMensagem.Controls.Add(this.txtMensagem);
            this.grpMensagem.Location = new System.Drawing.Point(30, 239);
            this.grpMensagem.Name = "grpMensagem";
            this.grpMensagem.Size = new System.Drawing.Size(485, 260);
            this.grpMensagem.TabIndex = 116;
            this.grpMensagem.TabStop = false;
            this.grpMensagem.Text = "Mensagem";
            // 
            // txtAnexo
            // 
            this.txtAnexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAnexo.Enabled = false;
            this.txtAnexo.Location = new System.Drawing.Point(149, 216);
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(320, 20);
            this.txtAnexo.TabIndex = 7;
            // 
            // grbDePara
            // 
            this.grbDePara.Controls.Add(this.txtAssunto);
            this.grbDePara.Controls.Add(this.txtEnviadoPor);
            this.grbDePara.Controls.Add(this.txtSenhaRemet);
            this.grbDePara.Controls.Add(this.txtEnviarPara);
            this.grbDePara.Controls.Add(this.lblSubjectLine);
            this.grbDePara.Controls.Add(this.label2);
            this.grbDePara.Controls.Add(this.lblRemetente);
            this.grbDePara.Controls.Add(this.lblDestinatario);
            this.grbDePara.Location = new System.Drawing.Point(30, 50);
            this.grbDePara.Name = "grbDePara";
            this.grbDePara.Size = new System.Drawing.Size(485, 154);
            this.grbDePara.TabIndex = 115;
            this.grbDePara.TabStop = false;
            this.grbDePara.Text = "Destinatário / Emitente";
            // 
            // txtSenhaRemet
            // 
            this.txtSenhaRemet.Location = new System.Drawing.Point(186, 57);
            this.txtSenhaRemet.Name = "txtSenhaRemet";
            this.txtSenhaRemet.PasswordChar = '.';
            this.txtSenhaRemet.Size = new System.Drawing.Size(268, 20);
            this.txtSenhaRemet.TabIndex = 0;
            // 
            // txtEnviarPara
            // 
            this.txtEnviarPara.Location = new System.Drawing.Point(70, 83);
            this.txtEnviarPara.Name = "txtEnviarPara";
            this.txtEnviarPara.Size = new System.Drawing.Size(399, 20);
            this.txtEnviarPara.TabIndex = 0;
            // 
            // lblSubjectLine
            // 
            this.lblSubjectLine.AutoSize = true;
            this.lblSubjectLine.Location = new System.Drawing.Point(11, 126);
            this.lblSubjectLine.Name = "lblSubjectLine";
            this.lblSubjectLine.Size = new System.Drawing.Size(48, 13);
            this.lblSubjectLine.TabIndex = 2;
            this.lblSubjectLine.Text = "Assunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha do Email do Remetente";
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Location = new System.Drawing.Point(35, 35);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(24, 13);
            this.lblRemetente.TabIndex = 1;
            this.lblRemetente.Text = "De:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(28, 87);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(32, 13);
            this.lblDestinatario.TabIndex = 0;
            this.lblDestinatario.Text = "Para:";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(276, 505);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 59);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 117;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // FrmEnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 586);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grpMensagem);
            this.Controls.Add(this.grbDePara);
            this.Controls.Add(this.pictureBox);
            this.Name = "FrmEnviarEmail";
            this.Text = "FrmEmail";
            this.Click += new System.EventHandler(this.FrmEnviarEmail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEnviarEmail_KeyDown);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.pictureBox, 0);
            this.Controls.SetChildIndex(this.grbDePara, 0);
            this.Controls.SetChildIndex(this.grpMensagem, 0);
            this.Controls.SetChildIndex(this.btnEnviar, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpMensagem.ResumeLayout(false);
            this.grpMensagem.PerformLayout();
            this.grbDePara.ResumeLayout(false);
            this.grbDePara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtEnviadoPor;
        private System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.GroupBox grpMensagem;
        private System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.GroupBox grbDePara;
        private System.Windows.Forms.TextBox txtSenhaRemet;
        private System.Windows.Forms.TextBox txtEnviarPara;
        private System.Windows.Forms.Label lblSubjectLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRemetente;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}