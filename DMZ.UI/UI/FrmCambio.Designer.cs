namespace DMZ.UI.UI
{
    partial class FrmCambio
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.procura1 = new DMZ.UI.UC.Procura();
            this.dtDefault2 = new DMZ.UI.UC.DtDefault();
            this.tbDefault4 = new DMZ.UI.UC.TbDefault();
            this.tbDefault2 = new DMZ.UI.UC.TbDefault();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMessageShow.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Size = new System.Drawing.Size(513, 30);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.Text = "Câmbio";
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
            this.panel5.Location = new System.Drawing.Point(428, 2);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(469, 36);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(469, 225);
            // 
            // panelMessageShow
            // 
            this.panelMessageShow.Location = new System.Drawing.Point(174, 3);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefresh.Location = new System.Drawing.Point(402, 4);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.procura1);
            this.tabPage1.Controls.Add(this.dtDefault2);
            this.tabPage1.Controls.Add(this.tbDefault4);
            this.tabPage1.Controls.Add(this.tbDefault2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(455, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // procura1
            // 
            this.procura1.AutoComplete = false;
            this.procura1.Campo = null;
            this.procura1.Campo1 = null;
            this.procura1.CampoStatus = false;
            this.procura1.ColunaCodigo = "Código";
            this.procura1.ColunaDescricao = "Descrição";
            this.procura1.Condicao = "";
            this.procura1.DependDescricao = null;
            this.procura1.Dependente = false;
            this.procura1.DependenteNome = null;
            this.procura1.Descname = null;
            this.procura1.ExecMetodo = false;
            this.procura1.FormName = "FrmMoedas";
            this.procura1.HideFirstColumn = false;
            this.procura1.InserirNovo = true;
            this.procura1.InvertColuna = true;
            this.procura1.IsLocaDs = false;
            this.procura1.IsRequered = false;
            this.procura1.IsSqlSelect = false;
            this.procura1.Istatus = false;
            this.procura1.Items = null;
            this.procura1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procura1.Label1Text = "Moeda";
            this.procura1.Location = new System.Drawing.Point(18, 21);
            this.procura1.MultDocumento = false;
            this.procura1.Name = "procura1";
            this.procura1.ParentFormName = null;
            this.procura1.Pp = null;
            this.procura1.ReturnDt = false;
            this.procura1.Selecionado = "Moeda,descricao";
            this.procura1.ShowThirdColumn = false;
            this.procura1.Size = new System.Drawing.Size(139, 39);
            this.procura1.SqlComandText = null;
            this.procura1.Tabela = "moedas";
            this.procura1.TabIndex = 4;
            this.procura1.TbCkUpdate = false;
            this.procura1.TbClear = false;
            this.procura1.TbUpDate = null;
            this.procura1.Text2 = null;
            this.procura1.Text3 = null;
            this.procura1.Titulo = "Procurar";
            this.procura1.TmpFound = null;
            this.procura1.UpdateTextBox = null;
            this.procura1.Value = "Moeda";
            this.procura1.Value2 = null;
            // 
            // dtDefault2
            // 
            this.dtDefault2.BackColor = System.Drawing.Color.Transparent;
            this.dtDefault2.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dtDefault2.Label1Text = "Data";
            this.dtDefault2.Location = new System.Drawing.Point(20, 65);
            this.dtDefault2.Name = "dtDefault2";
            this.dtDefault2.Size = new System.Drawing.Size(123, 42);
            this.dtDefault2.TabIndex = 3;
            this.dtDefault2.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dtDefault2.Value = "data";
            // 
            // tbDefault4
            // 
            this.tbDefault4.AutoComplete = false;
            this.tbDefault4.AutoIncrimento = false;
            this.tbDefault4.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault4.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault4.Condicao = "";
            this.tbDefault4.InPutMask = false;
            this.tbDefault4.IsEmail = false;
            this.tbDefault4.IsMaxLength = false;
            this.tbDefault4.IsNumeric = false;
            this.tbDefault4.IsReadOnly = false;
            this.tbDefault4.IsTelephone = false;
            this.tbDefault4.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault4.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault4.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault4.Label1Text = "Venda";
            this.tbDefault4.Location = new System.Drawing.Point(15, 162);
            this.tbDefault4.MaxLength = 0;
            this.tbDefault4.MultDocumento = false;
            this.tbDefault4.MultiLinhas = false;
            this.tbDefault4.Name = "tbDefault4";
            this.tbDefault4.Obrigatorio = true;
            this.tbDefault4.Selected = null;
            this.tbDefault4.Size = new System.Drawing.Size(338, 42);
            this.tbDefault4.Tabela = null;
            this.tbDefault4.TabIndex = 2;
            this.tbDefault4.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault4.Tb1IsPassword = false;
            this.tbDefault4.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault4.Text2 = "";
            this.tbDefault4.Text3 = "";
            this.tbDefault4.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault4.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault4.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault4.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault4.Titulo = null;
            this.tbDefault4.ToUpperCase = false;
            this.tbDefault4.Value = "venda";
            this.tbDefault4.Value2 = null;
            this.tbDefault4.ValueChange = false;
            // 
            // tbDefault2
            // 
            this.tbDefault2.AutoComplete = false;
            this.tbDefault2.AutoIncrimento = false;
            this.tbDefault2.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault2.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault2.Condicao = "";
            this.tbDefault2.InPutMask = false;
            this.tbDefault2.IsEmail = false;
            this.tbDefault2.IsMaxLength = false;
            this.tbDefault2.IsNumeric = false;
            this.tbDefault2.IsReadOnly = false;
            this.tbDefault2.IsTelephone = false;
            this.tbDefault2.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault2.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault2.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault2.Label1Text = "Compra";
            this.tbDefault2.Location = new System.Drawing.Point(15, 114);
            this.tbDefault2.MaxLength = 0;
            this.tbDefault2.MultDocumento = false;
            this.tbDefault2.MultiLinhas = false;
            this.tbDefault2.Name = "tbDefault2";
            this.tbDefault2.Obrigatorio = true;
            this.tbDefault2.Selected = null;
            this.tbDefault2.Size = new System.Drawing.Size(338, 42);
            this.tbDefault2.Tabela = null;
            this.tbDefault2.TabIndex = 1;
            this.tbDefault2.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault2.Tb1IsPassword = false;
            this.tbDefault2.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault2.Text2 = "";
            this.tbDefault2.Text3 = "";
            this.tbDefault2.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault2.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault2.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault2.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault2.Titulo = null;
            this.tbDefault2.ToUpperCase = false;
            this.tbDefault2.Value = "compra";
            this.tbDefault2.Value2 = null;
            this.tbDefault2.ValueChange = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(4, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 271);
            this.tabControl1.TabIndex = 38;
            // 
            // FrmCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(513, 329);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCambio";
            this.Text = "Form Classe";
            this.Load += new System.EventHandler(this.FrmCambio_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panelTitulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMessageShow.ResumeLayout(false);
            this.panelMessageShow.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private UC.DtDefault dtDefault1;
        private UC.TbDefault tbDefault4;
        private UC.TbDefault tbDefault2;
        private System.Windows.Forms.TabControl tabControl1;
        private UC.DtDefault dtDefault2;
        private UC.Procura procura1;
    }
}
