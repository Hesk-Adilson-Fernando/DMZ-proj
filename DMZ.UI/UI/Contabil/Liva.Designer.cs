namespace DMZ.UI.UI.Contabil
{
    partial class Liva
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.tbAdoc = new DMZ.UI.UC.TbDefault();
            this.dtData = new DMZ.UI.UC.DtDefault();
            this.ucDiario = new DMZ.UI.UC.Procura();
            this.ucDoc = new DMZ.UI.UC.Procura();
            this.tbNumero = new DMZ.UI.UC.TbDefault();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMl = new DMZ.UI.Generic.GridUi();
            this.ClnConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnedeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnecre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbMes = new DMZ.UI.UC.TbDefault();
            this.tbDeb = new DMZ.UI.UC.TbDefault();
            this.tbCred = new DMZ.UI.UC.TbDefault();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbDefault1 = new DMZ.UI.UC.TbDefault();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMl)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(868, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(836, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.Text = "Lançar apuramento do IVA";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGravar);
            this.panel2.Controls.Add(this.tbAdoc);
            this.panel2.Controls.Add(this.dtData);
            this.panel2.Controls.Add(this.ucDiario);
            this.panel2.Controls.Add(this.ucDoc);
            this.panel2.Controls.Add(this.tbNumero);
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 87);
            this.panel2.TabIndex = 34;
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGravar.Image = global::DMZ.UI.Properties.Resources.Save_as_25px_2;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(773, 15);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(84, 63);
            this.btnGravar.TabIndex = 453;
            this.btnGravar.Text = "Lançar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // tbAdoc
            // 
            this.tbAdoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdoc.AutoComplete = false;
            this.tbAdoc.AutoIncrimento = false;
            this.tbAdoc.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbAdoc.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdoc.Condicao = "";
            this.tbAdoc.InPutMask = false;
            this.tbAdoc.IsEmail = false;
            this.tbAdoc.IsMatricula = false;
            this.tbAdoc.IsMaxLength = false;
            this.tbAdoc.IsNuit = false;
            this.tbAdoc.IsNumeric = false;
            this.tbAdoc.IsReadOnly = false;
            this.tbAdoc.IsTelephone = false;
            this.tbAdoc.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAdoc.label1Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdoc.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbAdoc.Label1Text = "Nº Documento";
            this.tbAdoc.Location = new System.Drawing.Point(455, 41);
            this.tbAdoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAdoc.MaxLength = 0;
            this.tbAdoc.MultDocumento = false;
            this.tbAdoc.MultiLinhas = false;
            this.tbAdoc.Name = "tbAdoc";
            this.tbAdoc.Nome = "TbDefault";
            this.tbAdoc.Obrigatorio = false;
            this.tbAdoc.Selected = null;
            this.tbAdoc.Size = new System.Drawing.Size(309, 42);
            this.tbAdoc.Tabela = null;
            this.tbAdoc.TabIndex = 12;
            this.tbAdoc.Tb1Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdoc.Tb1IsPassword = false;
            this.tbAdoc.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAdoc.Text2 = "";
            this.tbAdoc.Text3 = "";
            this.tbAdoc.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdoc.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbAdoc.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbAdoc.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAdoc.Titulo = null;
            this.tbAdoc.ToUpperCase = false;
            this.tbAdoc.Value = "adoc";
            this.tbAdoc.Value2 = null;
            this.tbAdoc.ValueChange = false;
            // 
            // dtData
            // 
            this.dtData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData.BackColor = System.Drawing.Color.Transparent;
            this.dtData.Dt1Value = new System.DateTime(2021, 4, 9, 0, 0, 0, 0);
            this.dtData.DtCustomFormat = null;
            this.dtData.DtFormat = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.DtShowUpDown = false;
            this.dtData.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dtData.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dtData.Label1Text = "Data de Emissão";
            this.dtData.Location = new System.Drawing.Point(461, -3);
            this.dtData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(123, 42);
            this.dtData.TabIndex = 11;
            this.dtData.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dtData.Value = "Data";
            // 
            // ucDiario
            // 
            this.ucDiario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDiario.AutoComplete = false;
            this.ucDiario.BackColor = System.Drawing.Color.Transparent;
            this.ucDiario.Campo = "descricao";
            this.ucDiario.Campo1 = null;
            this.ucDiario.CampoStatus = false;
            this.ucDiario.ColunaCodigo = "Código";
            this.ucDiario.ColunaDescricao = "Descrição";
            this.ucDiario.Condicao = "";
            this.ucDiario.DependDescricao = null;
            this.ucDiario.Dependente = false;
            this.ucDiario.DependenteNome = null;
            this.ucDiario.Descname = null;
            this.ucDiario.EnableTb1Field = false;
            this.ucDiario.ExecMetodo = false;
            this.ucDiario.FormName = null;
            this.ucDiario.HideFirstColumn = false;
            this.ucDiario.InserirNovo = false;
            this.ucDiario.InvertColuna = false;
            this.ucDiario.IsLocaDs = false;
            this.ucDiario.IsRequered = true;
            this.ucDiario.IsSqlSelect = true;
            this.ucDiario.Istatus = false;
            this.ucDiario.Items = null;
            this.ucDiario.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDiario.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.ucDiario.Label1Text = "Diário";
            this.ucDiario.Location = new System.Drawing.Point(7, 0);
            this.ucDiario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDiario.MultDocumento = false;
            this.ucDiario.Name = "ucDiario";
            this.ucDiario.ParentFormName = null;
            this.ucDiario.Pp = null;
            this.ucDiario.ReturnDt = false;
            this.ucDiario.Selecionado = "dino,descricao";
            this.ucDiario.ShowThirdColumn = false;
            this.ucDiario.Size = new System.Drawing.Size(446, 39);
            this.ucDiario.SqlComandText = "select dino,descricao from Diario where diano =(select ano from param)";
            this.ucDiario.Tabela = "diario";
            this.ucDiario.TabIndex = 0;
            this.ucDiario.TbCkUpdate = false;
            this.ucDiario.TbClear = false;
            this.ucDiario.TbUpDate = null;
            this.ucDiario.Text2 = null;
            this.ucDiario.Text3 = null;
            this.ucDiario.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.ucDiario.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.ucDiario.Titulo = "Procurar";
            this.ucDiario.TmpFound = null;
            this.ucDiario.UpdateTextBox = null;
            this.ucDiario.Value = "Dinome";
            this.ucDiario.Value2 = "dino";
            this.ucDiario.Value3 = null;
            // 
            // ucDoc
            // 
            this.ucDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDoc.AutoComplete = false;
            this.ucDoc.Campo = null;
            this.ucDoc.Campo1 = null;
            this.ucDoc.CampoStatus = false;
            this.ucDoc.ColunaCodigo = "Código";
            this.ucDoc.ColunaDescricao = "Descrição";
            this.ucDoc.Condicao = "";
            this.ucDoc.DependDescricao = null;
            this.ucDoc.Dependente = false;
            this.ucDoc.DependenteNome = null;
            this.ucDoc.Descname = null;
            this.ucDoc.EnableTb1Field = false;
            this.ucDoc.ExecMetodo = false;
            this.ucDoc.FormName = null;
            this.ucDoc.HideFirstColumn = false;
            this.ucDoc.InserirNovo = false;
            this.ucDoc.InvertColuna = false;
            this.ucDoc.IsLocaDs = false;
            this.ucDoc.IsRequered = false;
            this.ucDoc.IsSqlSelect = false;
            this.ucDoc.Istatus = false;
            this.ucDoc.Items = null;
            this.ucDoc.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDoc.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.ucDoc.Label1Text = "Documento";
            this.ucDoc.Location = new System.Drawing.Point(5, 42);
            this.ucDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDoc.MultDocumento = false;
            this.ucDoc.Name = "ucDoc";
            this.ucDoc.ParentFormName = null;
            this.ucDoc.Pp = null;
            this.ucDoc.ReturnDt = false;
            this.ucDoc.Selecionado = "docno,docnome";
            this.ucDoc.ShowThirdColumn = false;
            this.ucDoc.Size = new System.Drawing.Size(448, 39);
            this.ucDoc.SqlComandText = null;
            this.ucDoc.Tabela = "dc";
            this.ucDoc.TabIndex = 6;
            this.ucDoc.TbCkUpdate = false;
            this.ucDoc.TbClear = false;
            this.ucDoc.TbUpDate = null;
            this.ucDoc.Text2 = null;
            this.ucDoc.Text3 = null;
            this.ucDoc.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.ucDoc.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.ucDoc.Titulo = "Procurar";
            this.ucDoc.TmpFound = null;
            this.ucDoc.UpdateTextBox = null;
            this.ucDoc.Value = "docnome";
            this.ucDoc.Value2 = "docno";
            this.ucDoc.Value3 = null;
            // 
            // tbNumero
            // 
            this.tbNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumero.AutoComplete = false;
            this.tbNumero.AutoIncrimento = true;
            this.tbNumero.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbNumero.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumero.Condicao = "";
            this.tbNumero.InPutMask = false;
            this.tbNumero.IsEmail = false;
            this.tbNumero.IsMatricula = false;
            this.tbNumero.IsMaxLength = false;
            this.tbNumero.IsNuit = false;
            this.tbNumero.IsNumeric = false;
            this.tbNumero.IsReadOnly = true;
            this.tbNumero.IsTelephone = false;
            this.tbNumero.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNumero.label1Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbNumero.Label1Text = "Nº de Lançamento";
            this.tbNumero.Location = new System.Drawing.Point(604, 2);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumero.MaxLength = 0;
            this.tbNumero.MultDocumento = false;
            this.tbNumero.MultiLinhas = true;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Nome = "TbDefault";
            this.tbNumero.Obrigatorio = true;
            this.tbNumero.Selected = null;
            this.tbNumero.Size = new System.Drawing.Size(158, 42);
            this.tbNumero.Tabela = null;
            this.tbNumero.TabIndex = 3;
            this.tbNumero.Tb1Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Tb1IsPassword = false;
            this.tbNumero.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNumero.Text2 = "";
            this.tbNumero.Text3 = "";
            this.tbNumero.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumero.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbNumero.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbNumero.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNumero.Titulo = null;
            this.tbNumero.ToUpperCase = false;
            this.tbNumero.Value = "dilno";
            this.tbNumero.Value2 = null;
            this.tbNumero.ValueChange = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 127);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 386);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvMl);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(851, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvMl
            // 
            this.dgvMl.AddButtons = false;
            this.dgvMl.AllowUserToAddRows = false;
            this.dgvMl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMl.AutoIncrimento = false;
            this.dgvMl.BackgroundColor = System.Drawing.Color.White;
            this.dgvMl.CampoCodigo = null;
            this.dgvMl.Codigo = null;
            this.dgvMl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMl.ColumnHeadersHeight = 35;
            this.dgvMl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnConta,
            this.descricao,
            this.deb,
            this.cre,
            this.clnDescMov,
            this.ccusto,
            this.clnedeb,
            this.clnecre});
            this.dgvMl.Condicao = null;
            this.dgvMl.CorPreto = false;
            this.dgvMl.CurrentColumnName = null;
            this.dgvMl.DefacolumnName = null;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMl.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMl.DtDS = null;
            this.dgvMl.EnableHeadersVisualStyles = false;
            this.dgvMl.GenerateColumns = false;
            this.dgvMl.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMl.GridFilha = true;
            this.dgvMl.GridFilhaSecundaria = false;
            this.dgvMl.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvMl.HeadersHeight = 35;
            this.dgvMl.HeadersVisible = false;
            this.dgvMl.Location = new System.Drawing.Point(6, 6);
            this.dgvMl.Name = "dgvMl";
            this.dgvMl.OrderbyCampos = null;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMl.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMl.RowHeadersWidth = 10;
            this.dgvMl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMl.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMl.Size = new System.Drawing.Size(839, 295);
            this.dgvMl.StampCabecalho = "Lcontstamp";
            this.dgvMl.StampLocal = "Mlstamp";
            this.dgvMl.TabelaSql = "Ml";
            this.dgvMl.TabIndex = 45;
            this.dgvMl.TbCodigo = null;
            // 
            // ClnConta
            // 
            this.ClnConta.DataPropertyName = "conta";
            this.ClnConta.HeaderText = "Conta";
            this.ClnConta.Name = "ClnConta";
            this.ClnConta.Width = 150;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 200;
            this.descricao.Name = "descricao";
            // 
            // deb
            // 
            this.deb.DataPropertyName = "deb";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.deb.DefaultCellStyle = dataGridViewCellStyle2;
            this.deb.HeaderText = "Débito";
            this.deb.Name = "deb";
            this.deb.Width = 120;
            // 
            // cre
            // 
            this.cre.DataPropertyName = "cre";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cre.DefaultCellStyle = dataGridViewCellStyle3;
            this.cre.HeaderText = "Crédito";
            this.cre.Name = "cre";
            this.cre.Width = 120;
            // 
            // clnDescMov
            // 
            this.clnDescMov.DataPropertyName = "descritivo";
            this.clnDescMov.HeaderText = "Desc. Movimento";
            this.clnDescMov.MinimumWidth = 120;
            this.clnDescMov.Name = "clnDescMov";
            this.clnDescMov.Width = 130;
            // 
            // ccusto
            // 
            this.ccusto.DataPropertyName = "cct";
            this.ccusto.HeaderText = "C. Custo";
            this.ccusto.Name = "ccusto";
            this.ccusto.Visible = false;
            this.ccusto.Width = 120;
            // 
            // clnedeb
            // 
            this.clnedeb.DataPropertyName = "edeb";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clnedeb.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnedeb.HeaderText = "Débito Moeda";
            this.clnedeb.Name = "clnedeb";
            this.clnedeb.Visible = false;
            this.clnedeb.Width = 90;
            // 
            // clnecre
            // 
            this.clnecre.DataPropertyName = "ecre";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clnecre.DefaultCellStyle = dataGridViewCellStyle5;
            this.clnecre.HeaderText = "Crédito Moeda";
            this.clnecre.Name = "clnecre";
            this.clnecre.Visible = false;
            this.clnecre.Width = 90;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbMes);
            this.panel1.Controls.Add(this.tbDeb);
            this.panel1.Controls.Add(this.tbCred);
            this.panel1.Location = new System.Drawing.Point(6, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 43);
            this.panel1.TabIndex = 44;
            // 
            // tbMes
            // 
            this.tbMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMes.AutoComplete = false;
            this.tbMes.AutoIncrimento = false;
            this.tbMes.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbMes.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMes.Condicao = "";
            this.tbMes.InPutMask = false;
            this.tbMes.IsEmail = false;
            this.tbMes.IsMatricula = false;
            this.tbMes.IsMaxLength = false;
            this.tbMes.IsNuit = false;
            this.tbMes.IsNumeric = false;
            this.tbMes.IsReadOnly = true;
            this.tbMes.IsTelephone = false;
            this.tbMes.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMes.label1Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMes.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbMes.Label1Text = "Mês";
            this.tbMes.Location = new System.Drawing.Point(4, -2);
            this.tbMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMes.MaxLength = 0;
            this.tbMes.MultDocumento = false;
            this.tbMes.MultiLinhas = false;
            this.tbMes.Name = "tbMes";
            this.tbMes.Nome = "TbDefault";
            this.tbMes.Obrigatorio = false;
            this.tbMes.Selected = null;
            this.tbMes.Size = new System.Drawing.Size(227, 42);
            this.tbMes.Tabela = null;
            this.tbMes.TabIndex = 454;
            this.tbMes.Tb1Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMes.Tb1IsPassword = false;
            this.tbMes.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMes.Text2 = "";
            this.tbMes.Text3 = "";
            this.tbMes.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMes.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbMes.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbMes.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMes.Titulo = null;
            this.tbMes.ToUpperCase = false;
            this.tbMes.Value = "mes";
            this.tbMes.Value2 = null;
            this.tbMes.ValueChange = false;
            // 
            // tbDeb
            // 
            this.tbDeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeb.AutoComplete = false;
            this.tbDeb.AutoIncrimento = true;
            this.tbDeb.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDeb.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeb.Condicao = "";
            this.tbDeb.InPutMask = true;
            this.tbDeb.IsEmail = false;
            this.tbDeb.IsMatricula = false;
            this.tbDeb.IsMaxLength = false;
            this.tbDeb.IsNuit = false;
            this.tbDeb.IsNumeric = false;
            this.tbDeb.IsReadOnly = true;
            this.tbDeb.IsTelephone = false;
            this.tbDeb.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDeb.label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeb.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDeb.Label1Text = "Débito";
            this.tbDeb.Location = new System.Drawing.Point(439, -1);
            this.tbDeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDeb.MaxLength = 0;
            this.tbDeb.MultDocumento = false;
            this.tbDeb.MultiLinhas = true;
            this.tbDeb.Name = "tbDeb";
            this.tbDeb.Nome = "TbDefault";
            this.tbDeb.Obrigatorio = true;
            this.tbDeb.Selected = null;
            this.tbDeb.Size = new System.Drawing.Size(193, 42);
            this.tbDeb.Tabela = null;
            this.tbDeb.TabIndex = 12;
            this.tbDeb.Tb1Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeb.Tb1IsPassword = false;
            this.tbDeb.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDeb.Text2 = "";
            this.tbDeb.Text3 = "";
            this.tbDeb.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeb.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDeb.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDeb.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDeb.Titulo = null;
            this.tbDeb.ToUpperCase = false;
            this.tbDeb.Value = "debfin";
            this.tbDeb.Value2 = null;
            this.tbDeb.ValueChange = false;
            // 
            // tbCred
            // 
            this.tbCred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCred.AutoComplete = false;
            this.tbCred.AutoIncrimento = true;
            this.tbCred.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbCred.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCred.Condicao = "";
            this.tbCred.InPutMask = true;
            this.tbCred.IsEmail = false;
            this.tbCred.IsMatricula = false;
            this.tbCred.IsMaxLength = false;
            this.tbCred.IsNuit = false;
            this.tbCred.IsNumeric = false;
            this.tbCred.IsReadOnly = true;
            this.tbCred.IsTelephone = false;
            this.tbCred.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCred.label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCred.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCred.Label1Text = "Crédito";
            this.tbCred.Location = new System.Drawing.Point(640, -1);
            this.tbCred.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCred.MaxLength = 0;
            this.tbCred.MultDocumento = false;
            this.tbCred.MultiLinhas = true;
            this.tbCred.Name = "tbCred";
            this.tbCred.Nome = "TbDefault";
            this.tbCred.Obrigatorio = true;
            this.tbCred.Selected = null;
            this.tbCred.Size = new System.Drawing.Size(193, 42);
            this.tbCred.Tabela = null;
            this.tbCred.TabIndex = 11;
            this.tbCred.Tb1Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCred.Tb1IsPassword = false;
            this.tbCred.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCred.Text2 = "";
            this.tbCred.Text3 = "";
            this.tbCred.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCred.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbCred.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbCred.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCred.Titulo = null;
            this.tbCred.ToUpperCase = false;
            this.tbCred.Value = "crefin";
            this.tbCred.Value2 = null;
            this.tbCred.ValueChange = false;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel8.Controls.Add(this.tbDefault1);
            this.panel8.Location = new System.Drawing.Point(6, 532);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1418, 47);
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
            this.tbDefault1.IsMatricula = false;
            this.tbDefault1.IsMaxLength = false;
            this.tbDefault1.IsNuit = false;
            this.tbDefault1.IsNumeric = false;
            this.tbDefault1.IsReadOnly = false;
            this.tbDefault1.IsTelephone = false;
            this.tbDefault1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault1.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault1.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault1.Label1Text = "Nº Documento";
            this.tbDefault1.Location = new System.Drawing.Point(1200, 5);
            this.tbDefault1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDefault1.MaxLength = 0;
            this.tbDefault1.MultDocumento = false;
            this.tbDefault1.MultiLinhas = false;
            this.tbDefault1.Name = "tbDefault1";
            this.tbDefault1.Nome = "TbDefault";
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
            this.tbDefault1.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault1.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault1.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
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
            this.button3.Location = new System.Drawing.Point(1328, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 28);
            this.button3.TabIndex = 40;
            this.button3.Text = "Apagar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(851, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Outros dados ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Liva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(869, 525);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Name = "Liva";
            this.Load += new System.EventHandler(this.Liva_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private UC.TbDefault tbAdoc;
        private UC.DtDefault dtData;
        private UC.Procura ucDiario;
        private UC.Procura ucDoc;
        private UC.TbDefault tbNumero;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Generic.GridUi dgvMl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn deb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnedeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnecre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private UC.TbDefault tbDefault1;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button btnGravar;
        public UC.TbDefault tbMes;
        public UC.TbDefault tbDeb;
        public UC.TbDefault tbCred;
    }
}
