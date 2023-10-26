namespace DMZ.UI.UI
{
    partial class FrmVend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVend));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Inicio = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbDefault3 = new DMZ.UI.UC.TbDefault();
            this.tbDefault9 = new DMZ.UI.UC.TbDefault();
            this.tbDefault10 = new DMZ.UI.UC.TbDefault();
            this.tbDefault8 = new DMZ.UI.UC.TbDefault();
            this.tbDefault7 = new DMZ.UI.UC.TbDefault();
            this.procura1 = new DMZ.UI.UC.Procura();
            this.procura5 = new DMZ.UI.UC.Procura();
            this.tbDefault4 = new DMZ.UI.UC.TbDefault();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.procura3 = new DMZ.UI.UC.Procura();
            this.tbDefault2 = new DMZ.UI.UC.TbDefault();
            this.tbDefault1 = new DMZ.UI.UC.TbDefault();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMessageShow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Inicio.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Size = new System.Drawing.Size(690, 30);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.Text = "Vendedores ";
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
            this.panel5.Location = new System.Drawing.Point(605, 2);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(646, 36);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(646, 291);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefresh.Location = new System.Drawing.Point(579, 3);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Inicio);
            this.tabControl1.Location = new System.Drawing.Point(4, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 291);
            this.tabControl1.TabIndex = 49;
            // 
            // Inicio
            // 
            this.Inicio.Controls.Add(this.panel6);
            this.Inicio.Controls.Add(this.barraText1);
            this.Inicio.Location = new System.Drawing.Point(4, 22);
            this.Inicio.Name = "Inicio";
            this.Inicio.Padding = new System.Windows.Forms.Padding(3);
            this.Inicio.Size = new System.Drawing.Size(622, 265);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Início";
            this.Inicio.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tbDefault3);
            this.panel6.Controls.Add(this.tbDefault9);
            this.panel6.Controls.Add(this.tbDefault10);
            this.panel6.Controls.Add(this.tbDefault8);
            this.panel6.Controls.Add(this.tbDefault7);
            this.panel6.Controls.Add(this.procura1);
            this.panel6.Controls.Add(this.procura5);
            this.panel6.Controls.Add(this.tbDefault4);
            this.panel6.Location = new System.Drawing.Point(6, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(610, 227);
            this.panel6.TabIndex = 50;
            // 
            // tbDefault3
            // 
            this.tbDefault3.AutoComplete = false;
            this.tbDefault3.AutoIncrimento = false;
            this.tbDefault3.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault3.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault3.Condicao = "";
            this.tbDefault3.InPutMask = false;
            this.tbDefault3.IsEmail = false;
            this.tbDefault3.IsMaxLength = false;
            this.tbDefault3.IsNumeric = false;
            this.tbDefault3.IsReadOnly = false;
            this.tbDefault3.IsTelephone = false;
            this.tbDefault3.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault3.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault3.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault3.Label1Text = "Morada";
            this.tbDefault3.Location = new System.Drawing.Point(10, 8);
            this.tbDefault3.MaxLength = 0;
            this.tbDefault3.MultDocumento = false;
            this.tbDefault3.MultiLinhas = false;
            this.tbDefault3.Name = "tbDefault3";
            this.tbDefault3.Obrigatorio = false;
            this.tbDefault3.Selected = null;
            this.tbDefault3.Size = new System.Drawing.Size(303, 42);
            this.tbDefault3.Tabela = null;
            this.tbDefault3.TabIndex = 37;
            this.tbDefault3.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault3.Tb1IsPassword = false;
            this.tbDefault3.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault3.Text2 = "";
            this.tbDefault3.Text3 = "";
            this.tbDefault3.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault3.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault3.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault3.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault3.Titulo = null;
            this.tbDefault3.ToUpperCase = false;
            this.tbDefault3.Value = "Morada";
            this.tbDefault3.Value2 = null;
            this.tbDefault3.ValueChange = false;
            // 
            // tbDefault9
            // 
            this.tbDefault9.AutoComplete = false;
            this.tbDefault9.AutoIncrimento = false;
            this.tbDefault9.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault9.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault9.Condicao = "";
            this.tbDefault9.InPutMask = false;
            this.tbDefault9.IsEmail = false;
            this.tbDefault9.IsMaxLength = false;
            this.tbDefault9.IsNumeric = false;
            this.tbDefault9.IsReadOnly = false;
            this.tbDefault9.IsTelephone = false;
            this.tbDefault9.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault9.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault9.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault9.Label1Text = "Contacto 2";
            this.tbDefault9.Location = new System.Drawing.Point(11, 126);
            this.tbDefault9.MaxLength = 0;
            this.tbDefault9.MultDocumento = false;
            this.tbDefault9.MultiLinhas = false;
            this.tbDefault9.Name = "tbDefault9";
            this.tbDefault9.Obrigatorio = false;
            this.tbDefault9.Selected = null;
            this.tbDefault9.Size = new System.Drawing.Size(303, 42);
            this.tbDefault9.Tabela = null;
            this.tbDefault9.TabIndex = 47;
            this.tbDefault9.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault9.Tb1IsPassword = false;
            this.tbDefault9.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault9.Text2 = "";
            this.tbDefault9.Text3 = "";
            this.tbDefault9.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault9.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault9.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault9.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault9.Titulo = null;
            this.tbDefault9.ToUpperCase = false;
            this.tbDefault9.Value = "Telefone";
            this.tbDefault9.Value2 = null;
            this.tbDefault9.ValueChange = false;
            // 
            // tbDefault10
            // 
            this.tbDefault10.AutoComplete = false;
            this.tbDefault10.AutoIncrimento = false;
            this.tbDefault10.btnProcura2ForeColor = System.Drawing.Color.White;
            this.tbDefault10.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault10.Condicao = "";
            this.tbDefault10.InPutMask = false;
            this.tbDefault10.IsEmail = false;
            this.tbDefault10.IsMaxLength = false;
            this.tbDefault10.IsNumeric = false;
            this.tbDefault10.IsReadOnly = false;
            this.tbDefault10.IsTelephone = false;
            this.tbDefault10.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault10.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault10.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault10.Label1Text = "Observação";
            this.tbDefault10.Location = new System.Drawing.Point(10, 166);
            this.tbDefault10.MaxLength = 0;
            this.tbDefault10.MultDocumento = false;
            this.tbDefault10.MultiLinhas = true;
            this.tbDefault10.Name = "tbDefault10";
            this.tbDefault10.Obrigatorio = false;
            this.tbDefault10.Selected = null;
            this.tbDefault10.Size = new System.Drawing.Size(597, 55);
            this.tbDefault10.Tabela = null;
            this.tbDefault10.TabIndex = 48;
            this.tbDefault10.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault10.Tb1IsPassword = false;
            this.tbDefault10.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault10.Text2 = "";
            this.tbDefault10.Text3 = "";
            this.tbDefault10.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault10.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault10.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault10.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault10.Titulo = null;
            this.tbDefault10.ToUpperCase = false;
            this.tbDefault10.Value = "obs";
            this.tbDefault10.Value2 = null;
            this.tbDefault10.ValueChange = false;
            // 
            // tbDefault8
            // 
            this.tbDefault8.AutoComplete = false;
            this.tbDefault8.AutoIncrimento = false;
            this.tbDefault8.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault8.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault8.Condicao = "";
            this.tbDefault8.InPutMask = false;
            this.tbDefault8.IsEmail = false;
            this.tbDefault8.IsMaxLength = false;
            this.tbDefault8.IsNumeric = false;
            this.tbDefault8.IsReadOnly = false;
            this.tbDefault8.IsTelephone = false;
            this.tbDefault8.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault8.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault8.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault8.Label1Text = "Contacto 1";
            this.tbDefault8.Location = new System.Drawing.Point(11, 86);
            this.tbDefault8.MaxLength = 0;
            this.tbDefault8.MultDocumento = false;
            this.tbDefault8.MultiLinhas = false;
            this.tbDefault8.Name = "tbDefault8";
            this.tbDefault8.Obrigatorio = false;
            this.tbDefault8.Selected = null;
            this.tbDefault8.Size = new System.Drawing.Size(303, 42);
            this.tbDefault8.Tabela = null;
            this.tbDefault8.TabIndex = 46;
            this.tbDefault8.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault8.Tb1IsPassword = false;
            this.tbDefault8.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault8.Text2 = "";
            this.tbDefault8.Text3 = "";
            this.tbDefault8.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault8.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault8.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault8.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault8.Titulo = null;
            this.tbDefault8.ToUpperCase = false;
            this.tbDefault8.Value = "Celular";
            this.tbDefault8.Value2 = null;
            this.tbDefault8.ValueChange = false;
            // 
            // tbDefault7
            // 
            this.tbDefault7.AutoComplete = false;
            this.tbDefault7.AutoIncrimento = false;
            this.tbDefault7.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDefault7.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault7.Condicao = "";
            this.tbDefault7.InPutMask = false;
            this.tbDefault7.IsEmail = false;
            this.tbDefault7.IsMaxLength = false;
            this.tbDefault7.IsNumeric = false;
            this.tbDefault7.IsReadOnly = false;
            this.tbDefault7.IsTelephone = false;
            this.tbDefault7.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault7.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault7.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault7.Label1Text = "Email";
            this.tbDefault7.Location = new System.Drawing.Point(11, 46);
            this.tbDefault7.MaxLength = 0;
            this.tbDefault7.MultDocumento = false;
            this.tbDefault7.MultiLinhas = false;
            this.tbDefault7.Name = "tbDefault7";
            this.tbDefault7.Obrigatorio = false;
            this.tbDefault7.Selected = null;
            this.tbDefault7.Size = new System.Drawing.Size(303, 42);
            this.tbDefault7.Tabela = null;
            this.tbDefault7.TabIndex = 41;
            this.tbDefault7.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault7.Tb1IsPassword = false;
            this.tbDefault7.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault7.Text2 = "";
            this.tbDefault7.Text3 = "";
            this.tbDefault7.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault7.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault7.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault7.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault7.Titulo = null;
            this.tbDefault7.ToUpperCase = false;
            this.tbDefault7.Value = "email";
            this.tbDefault7.Value2 = null;
            this.tbDefault7.ValueChange = false;
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
            this.procura1.FormName = null;
            this.procura1.HideFirstColumn = false;
            this.procura1.InserirNovo = false;
            this.procura1.InvertColuna = false;
            this.procura1.IsLocaDs = false;
            this.procura1.IsRequered = false;
            this.procura1.IsSqlSelect = true;
            this.procura1.Istatus = false;
            this.procura1.Items = null;
            this.procura1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procura1.Label1Text = "Tipo";
            this.procura1.Location = new System.Drawing.Point(338, 88);
            this.procura1.MultDocumento = false;
            this.procura1.Name = "procura1";
            this.procura1.ParentFormName = null;
            this.procura1.Pp = null;
            this.procura1.ReturnDt = false;
            this.procura1.Selecionado = "Interno,Externo";
            this.procura1.ShowThirdColumn = false;
            this.procura1.Size = new System.Drawing.Size(280, 39);
            this.procura1.SqlComandText = "select Descricao from Auxiliar where Tabela=9";
            this.procura1.Tabela = null;
            this.procura1.TabIndex = 49;
            this.procura1.TbCkUpdate = false;
            this.procura1.TbClear = false;
            this.procura1.TbUpDate = null;
            this.procura1.Text2 = null;
            this.procura1.Text3 = null;
            this.procura1.Titulo = "Procurar";
            this.procura1.TmpFound = null;
            this.procura1.UpdateTextBox = null;
            this.procura1.Value = "tipo";
            this.procura1.Value2 = null;
            // 
            // procura5
            // 
            this.procura5.AutoComplete = false;
            this.procura5.Campo = null;
            this.procura5.Campo1 = null;
            this.procura5.CampoStatus = false;
            this.procura5.ColunaCodigo = "Código";
            this.procura5.ColunaDescricao = "Descrição";
            this.procura5.Condicao = "";
            this.procura5.DependDescricao = null;
            this.procura5.Dependente = false;
            this.procura5.DependenteNome = null;
            this.procura5.Descname = null;
            this.procura5.ExecMetodo = false;
            this.procura5.FormName = null;
            this.procura5.HideFirstColumn = false;
            this.procura5.InserirNovo = false;
            this.procura5.InvertColuna = false;
            this.procura5.IsLocaDs = false;
            this.procura5.IsRequered = true;
            this.procura5.IsSqlSelect = false;
            this.procura5.Istatus = false;
            this.procura5.Items = null;
            this.procura5.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procura5.Label1Text = "Centro de Custo";
            this.procura5.Location = new System.Drawing.Point(338, 49);
            this.procura5.MultDocumento = false;
            this.procura5.Name = "procura5";
            this.procura5.ParentFormName = null;
            this.procura5.Pp = null;
            this.procura5.ReturnDt = false;
            this.procura5.Selecionado = "codccu,descricao";
            this.procura5.ShowThirdColumn = false;
            this.procura5.Size = new System.Drawing.Size(280, 39);
            this.procura5.SqlComandText = null;
            this.procura5.Tabela = "ccu";
            this.procura5.TabIndex = 45;
            this.procura5.TbCkUpdate = false;
            this.procura5.TbClear = false;
            this.procura5.TbUpDate = null;
            this.procura5.Text2 = null;
            this.procura5.Text3 = null;
            this.procura5.Titulo = "Procurar";
            this.procura5.TmpFound = null;
            this.procura5.UpdateTextBox = null;
            this.procura5.Value = "ccusto";
            this.procura5.Value2 = "codccu";
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
            this.tbDefault4.Label1Text = "NUIT";
            this.tbDefault4.Location = new System.Drawing.Point(338, 8);
            this.tbDefault4.MaxLength = 0;
            this.tbDefault4.MultDocumento = false;
            this.tbDefault4.MultiLinhas = false;
            this.tbDefault4.Name = "tbDefault4";
            this.tbDefault4.Obrigatorio = true;
            this.tbDefault4.Selected = null;
            this.tbDefault4.Size = new System.Drawing.Size(263, 42);
            this.tbDefault4.Tabela = null;
            this.tbDefault4.TabIndex = 38;
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
            this.tbDefault4.Value = "nuit";
            this.tbDefault4.Value2 = null;
            this.tbDefault4.ValueChange = false;
            // 
            // barraText1
            // 
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.White;
            this.barraText1.Label1Text = "Dados do vendedor ";
            this.barraText1.Location = new System.Drawing.Point(5, 4);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(613, 30);
            this.barraText1.TabIndex = 75;
            // 
            // procura3
            // 
            this.procura3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.procura3.AutoComplete = false;
            this.procura3.Campo = null;
            this.procura3.Campo1 = null;
            this.procura3.CampoStatus = false;
            this.procura3.ColunaCodigo = "Código";
            this.procura3.ColunaDescricao = "Descrição";
            this.procura3.Condicao = "";
            this.procura3.DependDescricao = null;
            this.procura3.Dependente = false;
            this.procura3.DependenteNome = null;
            this.procura3.Descname = null;
            this.procura3.ExecMetodo = false;
            this.procura3.FormName = null;
            this.procura3.HideFirstColumn = false;
            this.procura3.InserirNovo = false;
            this.procura3.InvertColuna = false;
            this.procura3.IsLocaDs = false;
            this.procura3.IsRequered = true;
            this.procura3.IsSqlSelect = false;
            this.procura3.Istatus = false;
            this.procura3.Items = null;
            this.procura3.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procura3.Label1Text = "Status";
            this.procura3.Location = new System.Drawing.Point(472, 34);
            this.procura3.MultDocumento = false;
            this.procura3.Name = "procura3";
            this.procura3.ParentFormName = null;
            this.procura3.Pp = null;
            this.procura3.ReturnDt = false;
            this.procura3.Selecionado = "codigo,descricao";
            this.procura3.ShowThirdColumn = false;
            this.procura3.Size = new System.Drawing.Size(172, 39);
            this.procura3.SqlComandText = null;
            this.procura3.Tabela = "status";
            this.procura3.TabIndex = 54;
            this.procura3.TbCkUpdate = false;
            this.procura3.TbClear = false;
            this.procura3.TbUpDate = null;
            this.procura3.Text2 = null;
            this.procura3.Text3 = null;
            this.procura3.Titulo = "Procurar";
            this.procura3.TmpFound = null;
            this.procura3.UpdateTextBox = null;
            this.procura3.Value = "status";
            this.procura3.Value2 = null;
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
            this.tbDefault2.Label1Text = "Nome Completo";
            this.tbDefault2.Location = new System.Drawing.Point(121, 32);
            this.tbDefault2.MaxLength = 0;
            this.tbDefault2.MultDocumento = false;
            this.tbDefault2.MultiLinhas = false;
            this.tbDefault2.Name = "tbDefault2";
            this.tbDefault2.Obrigatorio = true;
            this.tbDefault2.Selected = null;
            this.tbDefault2.Size = new System.Drawing.Size(353, 42);
            this.tbDefault2.Tabela = null;
            this.tbDefault2.TabIndex = 53;
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
            this.tbDefault2.Value = "nome";
            this.tbDefault2.Value2 = null;
            this.tbDefault2.ValueChange = false;
            // 
            // tbDefault1
            // 
            this.tbDefault1.AutoComplete = false;
            this.tbDefault1.AutoIncrimento = true;
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
            this.tbDefault1.Label1Text = "Número";
            this.tbDefault1.Location = new System.Drawing.Point(-2, 32);
            this.tbDefault1.MaxLength = 0;
            this.tbDefault1.MultDocumento = false;
            this.tbDefault1.MultiLinhas = false;
            this.tbDefault1.Name = "tbDefault1";
            this.tbDefault1.Obrigatorio = true;
            this.tbDefault1.Selected = null;
            this.tbDefault1.Size = new System.Drawing.Size(117, 42);
            this.tbDefault1.Tabela = null;
            this.tbDefault1.TabIndex = 52;
            this.tbDefault1.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault1.Tb1IsPassword = false;
            this.tbDefault1.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault1.Text2 = "";
            this.tbDefault1.Text3 = "";
            this.tbDefault1.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault1.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault1.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault1.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault1.Titulo = null;
            this.tbDefault1.ToUpperCase = false;
            this.tbDefault1.Value = "no";
            this.tbDefault1.Value2 = null;
            this.tbDefault1.ValueChange = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel2.Location = new System.Drawing.Point(7, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 3);
            this.panel2.TabIndex = 55;
            // 
            // FrmVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 395);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.procura3);
            this.Controls.Add(this.tbDefault2);
            this.Controls.Add(this.tbDefault1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmVend";
            this.Text = "Form Classe";
            this.Load += new System.EventHandler(this.FrmVend_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panelTitulo, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.tbDefault1, 0);
            this.Controls.SetChildIndex(this.tbDefault2, 0);
            this.Controls.SetChildIndex(this.procura3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
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
            this.Inicio.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Inicio;
        private UC.TbDefault tbDefault10;
        private UC.Procura procura5;
        private UC.TbDefault tbDefault4;
        private UC.TbDefault tbDefault3;
        private UC.TbDefault tbDefault7;
        private UC.TbDefault tbDefault8;
        private UC.TbDefault tbDefault9;
        private UC.Procura procura1;
        private UC.Procura procura3;
        private UC.TbDefault tbDefault2;
        private UC.TbDefault tbDefault1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private UC.BarraText barraText1;
    }
}
