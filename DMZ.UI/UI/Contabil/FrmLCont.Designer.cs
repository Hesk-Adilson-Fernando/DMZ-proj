using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    partial class FrmLCont
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDefault6 = new DMZ.UI.UC.TbDefault();
            this.tbDefault5 = new DMZ.UI.UC.TbDefault();
            this.ucMoeda = new DMZ.UI.UC.Procura();
            this.tbDefault4 = new DMZ.UI.UC.TbDefault();
            this.Cliente = new DMZ.UI.UC.Procura();
            this.tbCcusto = new DMZ.UI.UC.Procura();
            this.procura3 = new DMZ.UI.UC.Procura();
            this.tbDefault2 = new DMZ.UI.UC.TbDefault();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvML = new DMZ.UI.Generic.GridUi();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDebito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnedeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnecre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbDefault1 = new DMZ.UI.UC.TbDefault();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMessageShow.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvML)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnOptions);
            this.panel4.Size = new System.Drawing.Size(806, 30);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.panel5, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.panelMessageShow, 0);
            this.panel4.Controls.SetChildIndex(this.btnOptions, 0);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.Text = "Lançamentos Contabilísticos";
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
            this.panel5.Location = new System.Drawing.Point(721, 2);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(762, 36);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(762, 354);
            // 
            // panelMessageShow
            // 
            this.panelMessageShow.Location = new System.Drawing.Point(409, 3);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbDefault6);
            this.panel2.Controls.Add(this.tbDefault5);
            this.panel2.Controls.Add(this.ucMoeda);
            this.panel2.Controls.Add(this.tbDefault4);
            this.panel2.Controls.Add(this.Cliente);
            this.panel2.Controls.Add(this.tbCcusto);
            this.panel2.Controls.Add(this.procura3);
            this.panel2.Controls.Add(this.tbDefault2);
            this.panel2.Location = new System.Drawing.Point(4, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 86);
            this.panel2.TabIndex = 33;
            // 
            // tbDefault6
            // 
            this.tbDefault6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault6.AutoComplete = false;
            this.tbDefault6.AutoIncrimento = true;
            this.tbDefault6.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault6.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault6.Condicao = "";
            this.tbDefault6.InPutMask = false;
            this.tbDefault6.IsEmail = false;
            this.tbDefault6.IsMaxLength = false;
            this.tbDefault6.IsNumeric = false;
            this.tbDefault6.IsReadOnly = true;
            this.tbDefault6.IsTelephone = false;
            this.tbDefault6.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault6.label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault6.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault6.Label1Text = "Câmbio";
            this.tbDefault6.Location = new System.Drawing.Point(434, 1);
            this.tbDefault6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDefault6.MaxLength = 0;
            this.tbDefault6.MultDocumento = false;
            this.tbDefault6.MultiLinhas = true;
            this.tbDefault6.Name = "tbDefault6";
            this.tbDefault6.Obrigatorio = false;
            this.tbDefault6.Selected = null;
            this.tbDefault6.Size = new System.Drawing.Size(116, 42);
            this.tbDefault6.Tabela = null;
            this.tbDefault6.TabIndex = 10;
            this.tbDefault6.Tb1Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault6.Tb1IsPassword = false;
            this.tbDefault6.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDefault6.Text2 = "";
            this.tbDefault6.Text3 = "";
            this.tbDefault6.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault6.Titulo = null;
            this.tbDefault6.ToUpperCase = false;
            this.tbDefault6.Value = "Numero";
            this.tbDefault6.Value2 = null;
            this.tbDefault6.ValueChange = false;
            // 
            // tbDefault5
            // 
            this.tbDefault5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault5.AutoComplete = false;
            this.tbDefault5.AutoIncrimento = true;
            this.tbDefault5.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault5.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault5.Condicao = "";
            this.tbDefault5.InPutMask = false;
            this.tbDefault5.IsEmail = false;
            this.tbDefault5.IsMaxLength = false;
            this.tbDefault5.IsNumeric = false;
            this.tbDefault5.IsReadOnly = true;
            this.tbDefault5.IsTelephone = false;
            this.tbDefault5.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault5.label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault5.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault5.Label1Text = "Nº Documento";
            this.tbDefault5.Location = new System.Drawing.Point(301, 43);
            this.tbDefault5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDefault5.MaxLength = 0;
            this.tbDefault5.MultDocumento = false;
            this.tbDefault5.MultiLinhas = true;
            this.tbDefault5.Name = "tbDefault5";
            this.tbDefault5.Obrigatorio = false;
            this.tbDefault5.Selected = null;
            this.tbDefault5.Size = new System.Drawing.Size(132, 42);
            this.tbDefault5.Tabela = null;
            this.tbDefault5.TabIndex = 9;
            this.tbDefault5.Tb1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault5.Tb1IsPassword = false;
            this.tbDefault5.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDefault5.Text2 = "";
            this.tbDefault5.Text3 = "";
            this.tbDefault5.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault5.Titulo = null;
            this.tbDefault5.ToUpperCase = false;
            this.tbDefault5.Value = "Numero";
            this.tbDefault5.Value2 = null;
            this.tbDefault5.ValueChange = false;
            // 
            // ucMoeda
            // 
            this.ucMoeda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMoeda.AutoComplete = false;
            this.ucMoeda.Campo = null;
            this.ucMoeda.Campo1 = null;
            this.ucMoeda.CampoStatus = false;
            this.ucMoeda.ColunaCodigo = "Código";
            this.ucMoeda.ColunaDescricaoString = "Descrição";
            this.ucMoeda.Condicao = "";
            this.ucMoeda.DependDescricao = null;
            this.ucMoeda.Dependente = false;
            this.ucMoeda.DependenteNome = null;
            this.ucMoeda.ExecMetodo = false;
            this.ucMoeda.FormName = null;
            this.ucMoeda.HideFirstColumn = false;
            this.ucMoeda.InserirNovo = false;
            this.ucMoeda.InvertColuna = true;
            this.ucMoeda.IsLocaDs = false;
            this.ucMoeda.IsRequered = false;
            this.ucMoeda.IsSqlSelect = false;
            this.ucMoeda.Items = null;
            this.ucMoeda.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMoeda.Label1Text = "Moeda";
            this.ucMoeda.Location = new System.Drawing.Point(304, 0);
            this.ucMoeda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMoeda.MultDocumento = false;
            this.ucMoeda.Name = "ucMoeda";
            this.ucMoeda.ParentFormName = null;
            this.ucMoeda.Pp = null;
            this.ucMoeda.ReturnDt = false;
            this.ucMoeda.Selecionado = "moeda,descricao";
            this.ucMoeda.ShowThirdColumn = false;
            this.ucMoeda.Size = new System.Drawing.Size(147, 39);
            this.ucMoeda.SQLComandText = null;
            this.ucMoeda.Tabela = "moedas";
            this.ucMoeda.TabIndex = 2;
            this.ucMoeda.TbCkUpdate = false;
            this.ucMoeda.TbClear = false;
            this.ucMoeda.TbUpDate = null;
            this.ucMoeda.Text2 = null;
            this.ucMoeda.Text3 = null;
            this.ucMoeda.Titulo = "Procurar";
            this.ucMoeda.TmpFound = null;
            this.ucMoeda.UpdateTextBox = null;
            this.ucMoeda.Value = "Moeda";
            this.ucMoeda.Value2 = null;
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
            this.tbDefault4.Label1Text = "Dia";
            this.tbDefault4.Location = new System.Drawing.Point(660, 41);
            this.tbDefault4.MaxLength = 0;
            this.tbDefault4.MultDocumento = false;
            this.tbDefault4.MultiLinhas = false;
            this.tbDefault4.Name = "tbDefault4";
            this.tbDefault4.Obrigatorio = false;
            this.tbDefault4.Selected = null;
            this.tbDefault4.Size = new System.Drawing.Size(87, 39);
            this.tbDefault4.Tabela = null;
            this.tbDefault4.TabIndex = 8;
            this.tbDefault4.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault4.Tb1IsPassword = false;
            this.tbDefault4.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault4.Text2 = "";
            this.tbDefault4.Text3 = "";
            this.tbDefault4.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault4.Titulo = null;
            this.tbDefault4.ToUpperCase = false;
            this.tbDefault4.Value = null;
            this.tbDefault4.Value2 = null;
            this.tbDefault4.ValueChange = false;
            // 
            // Cliente
            // 
            this.Cliente.AutoComplete = false;
            this.Cliente.BackColor = System.Drawing.Color.Transparent;
            this.Cliente.Campo = null;
            this.Cliente.Campo1 = null;
            this.Cliente.CampoStatus = false;
            this.Cliente.ColunaCodigo = "Código";
            this.Cliente.ColunaDescricaoString = "Descrição";
            this.Cliente.Condicao = "";
            this.Cliente.DependDescricao = null;
            this.Cliente.Dependente = false;
            this.Cliente.DependenteNome = null;
            this.Cliente.ExecMetodo = false;
            this.Cliente.FormName = null;
            this.Cliente.HideFirstColumn = false;
            this.Cliente.InserirNovo = false;
            this.Cliente.InvertColuna = false;
            this.Cliente.IsLocaDs = false;
            this.Cliente.IsRequered = false;
            this.Cliente.IsSqlSelect = false;
            this.Cliente.Items = null;
            this.Cliente.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cliente.Label1Text = "Diário";
            this.Cliente.Location = new System.Drawing.Point(7, 0);
            this.Cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cliente.MultDocumento = false;
            this.Cliente.Name = "Cliente";
            this.Cliente.ParentFormName = null;
            this.Cliente.Pp = null;
            this.Cliente.ReturnDt = false;
            this.Cliente.Selecionado = "no,nome";
            this.Cliente.ShowThirdColumn = false;
            this.Cliente.Size = new System.Drawing.Size(312, 39);
            this.Cliente.SQLComandText = null;
            this.Cliente.Tabela = "cl";
            this.Cliente.TabIndex = 0;
            this.Cliente.TbCkUpdate = false;
            this.Cliente.TbClear = false;
            this.Cliente.TbUpDate = null;
            this.Cliente.Text2 = null;
            this.Cliente.Text3 = null;
            this.Cliente.Titulo = "Procurar";
            this.Cliente.TmpFound = null;
            this.Cliente.UpdateTextBox = null;
            this.Cliente.Value = "nome";
            this.Cliente.Value2 = "no";
            // 
            // tbCcusto
            // 
            this.tbCcusto.AutoComplete = false;
            this.tbCcusto.Campo = null;
            this.tbCcusto.Campo1 = null;
            this.tbCcusto.CampoStatus = false;
            this.tbCcusto.ColunaCodigo = "Código";
            this.tbCcusto.ColunaDescricaoString = "Descrição";
            this.tbCcusto.Condicao = "";
            this.tbCcusto.DependDescricao = null;
            this.tbCcusto.Dependente = false;
            this.tbCcusto.DependenteNome = null;
            this.tbCcusto.ExecMetodo = false;
            this.tbCcusto.FormName = null;
            this.tbCcusto.HideFirstColumn = false;
            this.tbCcusto.InserirNovo = false;
            this.tbCcusto.InvertColuna = false;
            this.tbCcusto.IsLocaDs = false;
            this.tbCcusto.IsRequered = false;
            this.tbCcusto.IsSqlSelect = false;
            this.tbCcusto.Items = null;
            this.tbCcusto.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCcusto.Label1Text = "Mês";
            this.tbCcusto.Location = new System.Drawing.Point(546, 40);
            this.tbCcusto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCcusto.MultDocumento = false;
            this.tbCcusto.Name = "tbCcusto";
            this.tbCcusto.ParentFormName = null;
            this.tbCcusto.Pp = null;
            this.tbCcusto.ReturnDt = false;
            this.tbCcusto.Selecionado = "CodCcu,Descricao";
            this.tbCcusto.ShowThirdColumn = false;
            this.tbCcusto.Size = new System.Drawing.Size(121, 39);
            this.tbCcusto.SQLComandText = null;
            this.tbCcusto.Tabela = "ccu";
            this.tbCcusto.TabIndex = 7;
            this.tbCcusto.TbCkUpdate = false;
            this.tbCcusto.TbClear = false;
            this.tbCcusto.TbUpDate = null;
            this.tbCcusto.Text2 = null;
            this.tbCcusto.Text3 = null;
            this.tbCcusto.Titulo = "Procurar";
            this.tbCcusto.TmpFound = null;
            this.tbCcusto.UpdateTextBox = null;
            this.tbCcusto.Value = "ccusto";
            this.tbCcusto.Value2 = null;
            // 
            // procura3
            // 
            this.procura3.AutoComplete = false;
            this.procura3.Campo = null;
            this.procura3.Campo1 = null;
            this.procura3.CampoStatus = false;
            this.procura3.ColunaCodigo = "Código";
            this.procura3.ColunaDescricaoString = "Descrição";
            this.procura3.Condicao = "";
            this.procura3.DependDescricao = null;
            this.procura3.Dependente = false;
            this.procura3.DependenteNome = null;
            this.procura3.ExecMetodo = false;
            this.procura3.FormName = null;
            this.procura3.HideFirstColumn = false;
            this.procura3.InserirNovo = false;
            this.procura3.InvertColuna = false;
            this.procura3.IsLocaDs = false;
            this.procura3.IsRequered = false;
            this.procura3.IsSqlSelect = false;
            this.procura3.Items = null;
            this.procura3.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procura3.Label1Text = "Documento";
            this.procura3.Location = new System.Drawing.Point(5, 42);
            this.procura3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.procura3.MultDocumento = false;
            this.procura3.Name = "procura3";
            this.procura3.ParentFormName = null;
            this.procura3.Pp = null;
            this.procura3.ReturnDt = false;
            this.procura3.Selecionado = "no,nome";
            this.procura3.ShowThirdColumn = false;
            this.procura3.Size = new System.Drawing.Size(314, 39);
            this.procura3.SQLComandText = null;
            this.procura3.Tabela = "vend";
            this.procura3.TabIndex = 6;
            this.procura3.TbCkUpdate = false;
            this.procura3.TbClear = false;
            this.procura3.TbUpDate = null;
            this.procura3.Text2 = null;
            this.procura3.Text3 = null;
            this.procura3.Titulo = "Procurar";
            this.procura3.TmpFound = null;
            this.procura3.UpdateTextBox = null;
            this.procura3.Value = "Vendedor";
            this.procura3.Value2 = "codvend";
            // 
            // tbDefault2
            // 
            this.tbDefault2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault2.AutoComplete = false;
            this.tbDefault2.AutoIncrimento = true;
            this.tbDefault2.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault2.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault2.Condicao = "";
            this.tbDefault2.InPutMask = false;
            this.tbDefault2.IsEmail = false;
            this.tbDefault2.IsMaxLength = false;
            this.tbDefault2.IsNumeric = false;
            this.tbDefault2.IsReadOnly = true;
            this.tbDefault2.IsTelephone = false;
            this.tbDefault2.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault2.label1Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault2.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault2.Label1Text = "Nº Documento";
            this.tbDefault2.Location = new System.Drawing.Point(543, 2);
            this.tbDefault2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDefault2.MaxLength = 0;
            this.tbDefault2.MultDocumento = false;
            this.tbDefault2.MultiLinhas = true;
            this.tbDefault2.Name = "tbDefault2";
            this.tbDefault2.Obrigatorio = false;
            this.tbDefault2.Selected = null;
            this.tbDefault2.Size = new System.Drawing.Size(204, 42);
            this.tbDefault2.Tabela = null;
            this.tbDefault2.TabIndex = 3;
            this.tbDefault2.Tb1Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault2.Tb1IsPassword = false;
            this.tbDefault2.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDefault2.Text2 = "";
            this.tbDefault2.Text3 = "";
            this.tbDefault2.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault2.Titulo = null;
            this.tbDefault2.ToUpperCase = false;
            this.tbDefault2.Value = "Numero";
            this.tbDefault2.Value2 = null;
            this.tbDefault2.ValueChange = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 323);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvML);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvML
            // 
            this.dgvML.AddButtons = false;
            this.dgvML.AllowUserToAddRows = false;
            this.dgvML.AllowUserToDeleteRows = false;
            this.dgvML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvML.BackgroundColor = System.Drawing.Color.White;
            this.dgvML.CampoCodigo = null;
            this.dgvML.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvML.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvML.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.del,
            this.conta,
            this.descricao,
            this.clnDebito,
            this.clnCredito,
            this.clnDescMov,
            this.ccusto,
            this.clnedeb,
            this.clnecre});
            this.dgvML.CorPreto = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvML.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvML.EnableHeadersVisualStyles = false;
            this.dgvML.GenerateColumns = false;
            this.dgvML.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvML.GridFilha = false;
            this.dgvML.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvML.HeadersHeight = 30;
            this.dgvML.HeadersVisible = false;
            this.dgvML.Location = new System.Drawing.Point(9, 6);
            this.dgvML.Name = "dgvML";
            this.dgvML.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvML.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvML.RowHeadersWidth = 10;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvML.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvML.Size = new System.Drawing.Size(729, 272);
            this.dgvML.StampCabecalho = null;
            this.dgvML.StampLocal = null;
            this.dgvML.TabelaSql = null;
            this.dgvML.TabIndex = 43;
            this.dgvML.TbCodigo = null;
            // 
            // del
            // 
            this.del.HeaderText = "";
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.del.ToolTipText = "Remover";
            this.del.Width = 30;
            // 
            // conta
            // 
            this.conta.DataPropertyName = "conta";
            this.conta.HeaderText = "Conta";
            this.conta.Name = "conta";
            this.conta.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 280;
            // 
            // clnDebito
            // 
            this.clnDebito.DataPropertyName = "deb";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.clnDebito.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnDebito.HeaderText = "Débito";
            this.clnDebito.Name = "clnDebito";
            this.clnDebito.ReadOnly = true;
            this.clnDebito.Width = 90;
            // 
            // clnCredito
            // 
            this.clnCredito.DataPropertyName = "cre";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.clnCredito.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnCredito.HeaderText = "Crédito";
            this.clnCredito.Name = "clnCredito";
            this.clnCredito.ReadOnly = true;
            this.clnCredito.Width = 90;
            // 
            // clnDescMov
            // 
            this.clnDescMov.DataPropertyName = "descritivo";
            this.clnDescMov.HeaderText = "Desc. Movimento";
            this.clnDescMov.Name = "clnDescMov";
            this.clnDescMov.ReadOnly = true;
            this.clnDescMov.Width = 180;
            // 
            // ccusto
            // 
            this.ccusto.DataPropertyName = "cct";
            this.ccusto.HeaderText = "C. Custo";
            this.ccusto.Name = "ccusto";
            this.ccusto.ReadOnly = true;
            this.ccusto.Width = 120;
            // 
            // clnedeb
            // 
            this.clnedeb.DataPropertyName = "edeb";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clnedeb.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnedeb.HeaderText = "Débito Moeda";
            this.clnedeb.Name = "clnedeb";
            this.clnedeb.ReadOnly = true;
            this.clnedeb.Width = 90;
            // 
            // clnecre
            // 
            this.clnecre.DataPropertyName = "ecre";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clnecre.DefaultCellStyle = dataGridViewCellStyle5;
            this.clnecre.HeaderText = "Crédito Moeda";
            this.clnecre.Name = "clnecre";
            this.clnecre.ReadOnly = true;
            this.clnecre.Width = 90;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel8.Controls.Add(this.tbDefault1);
            this.panel8.Location = new System.Drawing.Point(6, 469);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1311, 47);
            this.panel8.TabIndex = 42;
            // 
            // tbDefault1
            // 
            this.tbDefault1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault1.AutoComplete = false;
            this.tbDefault1.AutoIncrimento = false;
            this.tbDefault1.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault1.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault1.Condicao = "";
            this.tbDefault1.InPutMask = false;
            this.tbDefault1.IsEmail = false;
            this.tbDefault1.IsMaxLength = false;
            this.tbDefault1.IsNumeric = false;
            this.tbDefault1.IsReadOnly = false;
            this.tbDefault1.IsTelephone = false;
            this.tbDefault1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault1.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault1.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault1.Label1Text = "Nº Documento";
            this.tbDefault1.Location = new System.Drawing.Point(1093, 5);
            this.tbDefault1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDefault1.MaxLength = 0;
            this.tbDefault1.MultDocumento = false;
            this.tbDefault1.MultiLinhas = false;
            this.tbDefault1.Name = "tbDefault1";
            this.tbDefault1.Obrigatorio = false;
            this.tbDefault1.Selected = null;
            this.tbDefault1.Size = new System.Drawing.Size(213, 45);
            this.tbDefault1.Tabela = null;
            this.tbDefault1.TabIndex = 4;
            this.tbDefault1.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault1.Tb1IsPassword = false;
            this.tbDefault1.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault1.Text2 = "";
            this.tbDefault1.Text3 = "";
            this.tbDefault1.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault1.Titulo = null;
            this.tbDefault1.ToUpperCase = false;
            this.tbDefault1.Value = null;
            this.tbDefault1.Value2 = null;
            this.tbDefault1.ValueChange = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::DMZ.UI.Properties.Resources.DeleteFactl;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1221, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 28);
            this.button3.TabIndex = 40;
            this.button3.Text = "Apagar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.btnOptions.Location = new System.Drawing.Point(697, 2);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(18, 27);
            this.btnOptions.TabIndex = 34;
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.UseVisualStyleBackColor = false;
            // 
            // FrmLCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(806, 458);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmLCont";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmLCont_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMessageShow.ResumeLayout(false);
            this.panelMessageShow.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvML)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private UC.Procura Cliente;
        private UC.Procura tbCcusto;
        private UC.Procura procura3;
        private UC.TbDefault tbDefault2;
        private UC.Procura ucMoeda;
        public System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel8;
        private UC.TbDefault tbDefault1;
        public System.Windows.Forms.Button button3;
        private UC.TbDefault tbDefault5;
        private UC.TbDefault tbDefault4;
        private UC.TbDefault tbDefault6;
        private GridUi dgvML;
        private System.Windows.Forms.DataGridViewImageColumn del;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDebito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnedeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnecre;
    }
}
