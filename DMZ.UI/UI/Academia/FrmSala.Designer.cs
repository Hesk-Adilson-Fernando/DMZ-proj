namespace DMZ.UI.UI.Academia
{
    partial class FrmSala
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbCodigo = new DMZ.UI.UC.TbDefault();
            this.tbDescricao = new DMZ.UI.UC.TbDefault();
            this.tbDefault1 = new DMZ.UI.UC.TbDefault();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMessageShow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Size = new System.Drawing.Size(524, 30);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.Text = "Cadastro de salas ";
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
            this.panel5.Location = new System.Drawing.Point(441, 2);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(475, 36);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(475, 162);
            // 
            // panelMessageShow
            // 
            this.panelMessageShow.Location = new System.Drawing.Point(201, 4);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefresh.Location = new System.Drawing.Point(415, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 217);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.tbDefault1);
            this.tabPage1.Controls.Add(this.tbCodigo);
            this.tabPage1.Controls.Add(this.tbDescricao);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados gerais ";
            // 
            // tbCodigo
            // 
            this.tbCodigo.AutoComplete = false;
            this.tbCodigo.AutoIncrimento = false;
            this.tbCodigo.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbCodigo.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigo.Condicao = "";
            this.tbCodigo.InPutMask = false;
            this.tbCodigo.IsEmail = false;
            this.tbCodigo.IsMatricula = false;
            this.tbCodigo.IsMaxLength = false;
            this.tbCodigo.IsNuit = false;
            this.tbCodigo.IsNumeric = false;
            this.tbCodigo.IsReadOnly = false;
            this.tbCodigo.IsTelephone = false;
            this.tbCodigo.IsUnique = false;
            this.tbCodigo.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCodigo.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCodigo.Label1Text = "Código";
            this.tbCodigo.Label1Text2 = null;
            this.tbCodigo.Location = new System.Drawing.Point(15, 24);
            this.tbCodigo.MaxLength = 0;
            this.tbCodigo.MultDocumento = false;
            this.tbCodigo.MultiLinhas = false;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Nome = "TbDefault";
            this.tbCodigo.Obrigatorio = false;
            this.tbCodigo.Selected = null;
            this.tbCodigo.Size = new System.Drawing.Size(163, 42);
            this.tbCodigo.Tabela = null;
            this.tbCodigo.TabIndex = 2;
            this.tbCodigo.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Tb1IsPassword = false;
            this.tbCodigo.Tb1MaxLength = 1000000;
            this.tbCodigo.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCodigo.Text2 = "";
            this.tbCodigo.Text3 = "";
            this.tbCodigo.Text4 = "";
            this.tbCodigo.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigo.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbCodigo.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbCodigo.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCodigo.Titulo = null;
            this.tbCodigo.ToUpperCase = false;
            this.tbCodigo.Value = "codigo";
            this.tbCodigo.Value2 = null;
            this.tbCodigo.Value3 = null;
            this.tbCodigo.Value4 = null;
            this.tbCodigo.ValueChange = false;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricao.AutoComplete = false;
            this.tbDescricao.AutoIncrimento = false;
            this.tbDescricao.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDescricao.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricao.Condicao = "";
            this.tbDescricao.InPutMask = false;
            this.tbDescricao.IsEmail = false;
            this.tbDescricao.IsMatricula = false;
            this.tbDescricao.IsMaxLength = false;
            this.tbDescricao.IsNuit = false;
            this.tbDescricao.IsNumeric = false;
            this.tbDescricao.IsReadOnly = false;
            this.tbDescricao.IsTelephone = false;
            this.tbDescricao.IsUnique = false;
            this.tbDescricao.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescricao.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDescricao.Label1Text = "Descrição";
            this.tbDescricao.Label1Text2 = null;
            this.tbDescricao.Location = new System.Drawing.Point(15, 120);
            this.tbDescricao.MaxLength = 0;
            this.tbDescricao.MultDocumento = false;
            this.tbDescricao.MultiLinhas = false;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Nome = "TbDefault";
            this.tbDescricao.Obrigatorio = true;
            this.tbDescricao.Selected = null;
            this.tbDescricao.Size = new System.Drawing.Size(412, 42);
            this.tbDescricao.Tabela = null;
            this.tbDescricao.TabIndex = 3;
            this.tbDescricao.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Tb1IsPassword = false;
            this.tbDescricao.Tb1MaxLength = 1000000;
            this.tbDescricao.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDescricao.Text2 = "";
            this.tbDescricao.Text3 = "";
            this.tbDescricao.Text4 = "";
            this.tbDescricao.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricao.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDescricao.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDescricao.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescricao.Titulo = null;
            this.tbDescricao.ToUpperCase = false;
            this.tbDescricao.Value = "descricao";
            this.tbDescricao.Value2 = null;
            this.tbDescricao.Value3 = null;
            this.tbDescricao.Value4 = null;
            this.tbDescricao.ValueChange = false;
            // 
            // tbDefault1
            // 
            this.tbDefault1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault1.AutoComplete = false;
            this.tbDefault1.AutoIncrimento = false;
            this.tbDefault1.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault1.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault1.Condicao = "";
            this.tbDefault1.InPutMask = false;
            this.tbDefault1.IsEmail = false;
            this.tbDefault1.IsMatricula = false;
            this.tbDefault1.IsMaxLength = false;
            this.tbDefault1.IsNuit = false;
            this.tbDefault1.IsNumeric = false;
            this.tbDefault1.IsReadOnly = false;
            this.tbDefault1.IsTelephone = false;
            this.tbDefault1.IsUnique = false;
            this.tbDefault1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault1.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault1.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault1.Label1Text = "Capacidade ";
            this.tbDefault1.Label1Text2 = null;
            this.tbDefault1.Location = new System.Drawing.Point(15, 72);
            this.tbDefault1.MaxLength = 0;
            this.tbDefault1.MultDocumento = false;
            this.tbDefault1.MultiLinhas = false;
            this.tbDefault1.Name = "tbDefault1";
            this.tbDefault1.Nome = "TbDefault";
            this.tbDefault1.Obrigatorio = true;
            this.tbDefault1.Selected = null;
            this.tbDefault1.Size = new System.Drawing.Size(163, 42);
            this.tbDefault1.Tabela = null;
            this.tbDefault1.TabIndex = 4;
            this.tbDefault1.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault1.Tb1IsPassword = false;
            this.tbDefault1.Tb1MaxLength = 1000000;
            this.tbDefault1.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault1.Text2 = "";
            this.tbDefault1.Text3 = "";
            this.tbDefault1.Text4 = "";
            this.tbDefault1.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault1.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault1.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault1.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault1.Titulo = null;
            this.tbDefault1.ToUpperCase = false;
            this.tbDefault1.Value = "capacidade ";
            this.tbDefault1.Value2 = null;
            this.tbDefault1.Value3 = null;
            this.tbDefault1.Value4 = null;
            this.tbDefault1.ValueChange = false;
            // 
            // FrmSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 263);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmSala";
            this.Text = "FrmSala";
            this.Load += new System.EventHandler(this.FrmSala_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panelTitulo, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMessageShow.ResumeLayout(false);
            this.panelMessageShow.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.TbDefault tbDefault1;
        private UC.TbDefault tbCodigo;
        private UC.TbDefault tbDescricao;
    }
}