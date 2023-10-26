namespace DMZ.UI.UI
{
    partial class FrmSubFam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubFam));
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.panel6 = new System.Windows.Forms.Panel();
            this.codigo = new DMZ.UI.UC.TbDefault();
            this.descricao = new DMZ.UI.UC.TbDefault();
            this.imgGroup1 = new DMZ.UI.UC.ImgGroup();
            this.descricaopos = new DMZ.UI.UC.TbDefault();
            this.pos = new DMZ.UI.UC.CbDefault();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(572, 30);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.Text = "Subfamílias";
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(487, 2);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(528, 36);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(528, 211);
            // 
            // barraText1
            // 
            this.barraText1.Label1Text = "SubFamílias de Produtos ";
            this.barraText1.Location = new System.Drawing.Point(0, 37);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(527, 30);
            this.barraText1.TabIndex = 78;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.codigo);
            this.panel6.Controls.Add(this.descricao);
            this.panel6.Controls.Add(this.descricaopos);
            this.panel6.Location = new System.Drawing.Point(3, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(522, 241);
            this.panel6.TabIndex = 77;
            // 
            // codigo
            // 
            this.codigo.AutoComplete = false;
            this.codigo.AutoIncrimento = true;
            this.codigo.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.codigo.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.codigo.Condicao = "";
            this.codigo.InPutMask = false;
            this.codigo.IsEmail = false;
            this.codigo.IsMaxLength = false;
            this.codigo.IsNumeric = false;
            this.codigo.IsReadOnly = false;
            this.codigo.IsTelephone = false;
            this.codigo.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.codigo.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.codigo.Label1Text = "Código";
            this.codigo.Location = new System.Drawing.Point(5, 14);
            this.codigo.MaxLength = 0;
            this.codigo.MultDocumento = false;
            this.codigo.MultiLinhas = false;
            this.codigo.Name = "codigo";
            this.codigo.Obrigatorio = false;
            this.codigo.Selected = null;
            this.codigo.Size = new System.Drawing.Size(142, 42);
            this.codigo.Tabela = null;
            this.codigo.TabIndex = 0;
            this.codigo.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Tb1IsPassword = false;
            this.codigo.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.codigo.Text2 = "";
            this.codigo.Text3 = "";
            this.codigo.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigo.Titulo = null;
            this.codigo.ToUpperCase = false;
            this.codigo.Value = "codigo";
            this.codigo.Value2 = null;
            this.codigo.ValueChange = false;
            // 
            // descricao
            // 
            this.descricao.AutoComplete = false;
            this.descricao.AutoIncrimento = false;
            this.descricao.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.descricao.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.descricao.Condicao = "";
            this.descricao.InPutMask = false;
            this.descricao.IsEmail = false;
            this.descricao.IsMaxLength = false;
            this.descricao.IsNumeric = false;
            this.descricao.IsReadOnly = false;
            this.descricao.IsTelephone = false;
            this.descricao.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.descricao.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.descricao.Label1Text = "Descrição";
            this.descricao.Location = new System.Drawing.Point(151, 14);
            this.descricao.MaxLength = 0;
            this.descricao.MultDocumento = false;
            this.descricao.MultiLinhas = false;
            this.descricao.Name = "descricao";
            this.descricao.Obrigatorio = true;
            this.descricao.Selected = null;
            this.descricao.Size = new System.Drawing.Size(362, 42);
            this.descricao.Tabela = null;
            this.descricao.TabIndex = 1;
            this.descricao.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Tb1IsPassword = false;
            this.descricao.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.descricao.Text2 = "";
            this.descricao.Text3 = "";
            this.descricao.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricao.Titulo = null;
            this.descricao.ToUpperCase = false;
            this.descricao.Value = "descricao";
            this.descricao.Value2 = null;
            this.descricao.ValueChange = false;
            // 
            // imgGroup1
            // 
            this.imgGroup1.BackColor = System.Drawing.Color.Transparent;
            this.imgGroup1.Location = new System.Drawing.Point(335, 3);
            this.imgGroup1.Name = "imgGroup1";
            this.imgGroup1.Size = new System.Drawing.Size(158, 124);
            this.imgGroup1.TabIndex = 55;
            this.imgGroup1.Value = "Imagem";
            // 
            // descricaopos
            // 
            this.descricaopos.AutoComplete = false;
            this.descricaopos.AutoIncrimento = false;
            this.descricaopos.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.descricaopos.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaopos.Condicao = "";
            this.descricaopos.InPutMask = false;
            this.descricaopos.IsEmail = false;
            this.descricaopos.IsMaxLength = false;
            this.descricaopos.IsNumeric = false;
            this.descricaopos.IsReadOnly = false;
            this.descricaopos.IsTelephone = false;
            this.descricaopos.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.descricaopos.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaopos.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.descricaopos.Label1Text = "Descrição POS";
            this.descricaopos.Location = new System.Drawing.Point(6, 62);
            this.descricaopos.MaxLength = 0;
            this.descricaopos.MultDocumento = false;
            this.descricaopos.MultiLinhas = false;
            this.descricaopos.Name = "descricaopos";
            this.descricaopos.Obrigatorio = false;
            this.descricaopos.Selected = null;
            this.descricaopos.Size = new System.Drawing.Size(507, 42);
            this.descricaopos.Tabela = null;
            this.descricaopos.TabIndex = 53;
            this.descricaopos.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaopos.Tb1IsPassword = false;
            this.descricaopos.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.descricaopos.Text2 = "";
            this.descricaopos.Text3 = "";
            this.descricaopos.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaopos.Titulo = null;
            this.descricaopos.ToUpperCase = false;
            this.descricaopos.Value = "Descpos";
            this.descricaopos.Value2 = null;
            this.descricaopos.ValueChange = false;
            // 
            // pos
            // 
            this.pos.BackColor = System.Drawing.Color.Transparent;
            this.pos.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.pos.CbText = "Aparece no POS ?";
            this.pos.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pos.Imagem = ((System.Drawing.Image)(resources.GetObject("pos.Imagem")));
            this.pos.IsOptionGroup = false;
            this.pos.IsReadOnly = false;
            this.pos.IsRequered = false;
            this.pos.Location = new System.Drawing.Point(3, 3);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(167, 22);
            this.pos.TabIndex = 54;
            this.pos.Value = "Pos";
            this.pos.Value2 = null;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pos);
            this.panel2.Controls.Add(this.imgGroup1);
            this.panel2.Location = new System.Drawing.Point(14, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 128);
            this.panel2.TabIndex = 56;
            // 
            // FrmSubFam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(572, 315);
            this.Controls.Add(this.barraText1);
            this.Controls.Add(this.panel6);
            this.Name = "FrmSubFam";
            this.Text = "Form Classe";
            this.Load += new System.EventHandler(this.FrmSubFam_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.barraText1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public UC.BarraText barraText1;
        private System.Windows.Forms.Panel panel6;
        private UC.TbDefault codigo;
        private UC.TbDefault descricao;
        private UC.ImgGroup imgGroup1;
        private UC.TbDefault descricaopos;
        private UC.CbDefault pos;
        private System.Windows.Forms.Panel panel2;
    }
}
