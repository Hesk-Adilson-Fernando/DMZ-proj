namespace DMZ.UI.UI.Contabil
{
    partial class Lc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtDatafin = new DMZ.UI.UC.DMZDt();
            this.dtDataInc = new DMZ.UI.UC.DMZDt();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbDebDifCre = new DMZ.UI.UC.CbDefault();
            this.btnProcess = new System.Windows.Forms.Button();
            this.ucDiario = new DMZ.UI.UC.Procura();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDeb = new DMZ.UI.UC.TbDefault();
            this.tbCred = new DMZ.UI.UC.TbDefault();
            this.dgvDocumentos = new DMZ.UI.Generic.GridUi();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMl = new DMZ.UI.Generic.GridUi();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDebLinhas = new DMZ.UI.UC.TbDefault();
            this.tbCredLinhas = new DMZ.UI.UC.TbDefault();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dmzMenuLinhas = new DMZ.UI.UC.DMZContextMenuStrip();
            this.toolStripExtrato = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripApagar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ClnConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnecre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMl)).BeginInit();
            this.dmzMenuLinhas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Size = new System.Drawing.Size(953, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnPrint, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(921, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.Text = "Documentos Contabilísticos";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtDatafin);
            this.panel2.Controls.Add(this.dtDataInc);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.cbDebDifCre);
            this.panel2.Controls.Add(this.btnProcess);
            this.panel2.Controls.Add(this.ucDiario);
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 51);
            this.panel2.TabIndex = 34;
            // 
            // dtDatafin
            // 
            this.dtDatafin.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtDatafin.LblText = "Data Término";
            this.dtDatafin.Location = new System.Drawing.Point(681, 2);
            this.dtDatafin.Name = "dtDatafin";
            this.dtDatafin.Size = new System.Drawing.Size(151, 41);
            this.dtDatafin.TabIndex = 95;
            // 
            // dtDataInc
            // 
            this.dtDataInc.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtDataInc.LblText = "Data Início";
            this.dtDataInc.Location = new System.Drawing.Point(526, 2);
            this.dtDataInc.Name = "dtDataInc";
            this.dtDataInc.Size = new System.Drawing.Size(152, 41);
            this.dtDataInc.TabIndex = 94;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(380, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 33);
            this.panel5.TabIndex = 93;
            // 
            // cbDebDifCre
            // 
            this.cbDebDifCre.BackColor = System.Drawing.Color.Transparent;
            this.cbDebDifCre.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDebDifCre.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDebDifCre.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDebDifCre.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDebDifCre.CbText = "Débito ≠ Crédito";
            this.cbDebDifCre.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDebDifCre.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDebDifCre.Imagem")));
            this.cbDebDifCre.IsOptionGroup = false;
            this.cbDebDifCre.IsReadOnly = false;
            this.cbDebDifCre.IsRequered = false;
            this.cbDebDifCre.Location = new System.Drawing.Point(407, 17);
            this.cbDebDifCre.Name = "cbDebDifCre";
            this.cbDebDifCre.OnlyCheckBox = true;
            this.cbDebDifCre.Size = new System.Drawing.Size(167, 22);
            this.cbDebDifCre.TabIndex = 92;
            this.cbDebDifCre.Value = null;
            this.cbDebDifCre.Value2 = null;
            this.cbDebDifCre.Visible = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcess.Image = global::DMZ.UI.Properties.Resources.Automatic_251px;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.Location = new System.Drawing.Point(838, 3);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(104, 43);
            this.btnProcess.TabIndex = 91;
            this.btnProcess.Text = "Processar ";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
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
            this.ucDiario.IsUnique = false;
            this.ucDiario.Items = null;
            this.ucDiario.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDiario.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDiario.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.ucDiario.Label1Text = "Diário";
            this.ucDiario.Location = new System.Drawing.Point(7, 0);
            this.ucDiario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDiario.MultDocumento = false;
            this.ucDiario.Name = "ucDiario";
            this.ucDiario.OpenInfo = false;
            this.ucDiario.ParentFormName = null;
            this.ucDiario.Pp = null;
            this.ucDiario.ReturnDt = false;
            this.ucDiario.Selecionado = "dino,descricao";
            this.ucDiario.ShowThirdColumn = false;
            this.ucDiario.Size = new System.Drawing.Size(413, 39);
            this.ucDiario.SqlComandText = "select dino,descricao from Diario where diano =(select ano from param)";
            this.ucDiario.Tabela = "diario";
            this.ucDiario.TabIndex = 0;
            this.ucDiario.TbCkUpdate = false;
            this.ucDiario.TbClear = false;
            this.ucDiario.TbUpDate = null;
            this.ucDiario.Text2 = null;
            this.ucDiario.Text3 = null;
            this.ucDiario.Text4 = null;
            this.ucDiario.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.ucDiario.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.ucDiario.Titulo = "Procurar";
            this.ucDiario.TmpFound = null;
            this.ucDiario.UpdateTextBox = null;
            this.ucDiario.Value = "Dinome";
            this.ucDiario.Value2 = "dino";
            this.ucDiario.Value3 = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbDeb);
            this.panel1.Controls.Add(this.tbCred);
            this.panel1.Controls.Add(this.dgvDocumentos);
            this.panel1.Location = new System.Drawing.Point(3, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 207);
            this.panel1.TabIndex = 35;
            // 
            // tbDeb
            // 
            this.tbDeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeb.AutoComplete = false;
            this.tbDeb.AutoIncrimento = true;
            this.tbDeb.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDeb.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeb.Condicao = "";
            this.tbDeb.InPutMask = false;
            this.tbDeb.IsEmail = false;
            this.tbDeb.IsMatricula = false;
            this.tbDeb.IsMaxLength = false;
            this.tbDeb.IsNuit = false;
            this.tbDeb.IsNumeric = false;
            this.tbDeb.IsReadOnly = true;
            this.tbDeb.IsTelephone = false;
            this.tbDeb.IsUnique = false;
            this.tbDeb.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDeb.label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeb.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDeb.Label1Text = "Débito";
            this.tbDeb.Label1Text2 = null;
            this.tbDeb.Location = new System.Drawing.Point(548, 161);
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
            this.tbDeb.TabIndex = 46;
            this.tbDeb.Tb1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbCred.InPutMask = false;
            this.tbCred.IsEmail = false;
            this.tbCred.IsMatricula = false;
            this.tbCred.IsMaxLength = false;
            this.tbCred.IsNuit = false;
            this.tbCred.IsNumeric = false;
            this.tbCred.IsReadOnly = true;
            this.tbCred.IsTelephone = false;
            this.tbCred.IsUnique = false;
            this.tbCred.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCred.label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCred.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCred.Label1Text = "Crédito";
            this.tbCred.Label1Text2 = null;
            this.tbCred.Location = new System.Drawing.Point(749, 161);
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
            this.tbCred.TabIndex = 45;
            this.tbCred.Tb1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // dgvDocumentos
            // 
            this.dgvDocumentos.AddButtons = false;
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentos.AutoIncrimento = false;
            this.dgvDocumentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentos.CampoCodigo = null;
            this.dgvDocumentos.Codigo = null;
            this.dgvDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocumentos.ColumnHeadersHeight = 30;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnConta,
            this.descricao,
            this.ccusto,
            this.clnDescMov,
            this.deb,
            this.cre,
            this.clnecre,
            this.stamp});
            this.dgvDocumentos.Condicao = null;
            this.dgvDocumentos.CorPreto = false;
            this.dgvDocumentos.CurrentColumnName = null;
            this.dgvDocumentos.DefacolumnName = null;
            this.dgvDocumentos.DellGridRow = null;
            this.dgvDocumentos.DtDS = null;
            this.dgvDocumentos.EnableHeadersVisualStyles = false;
            this.dgvDocumentos.GenerateColumns = false;
            this.dgvDocumentos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDocumentos.GridFilha = true;
            this.dgvDocumentos.GridFilhaSecundaria = false;
            this.dgvDocumentos.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvDocumentos.HeadersHeight = 35;
            this.dgvDocumentos.HeadersVisible = false;
            this.dgvDocumentos.Location = new System.Drawing.Point(8, 3);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.OrderbyCampos = null;
            this.dgvDocumentos.Origem = null;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDocumentos.RowHeadersWidth = 10;
            this.dgvDocumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDocumentos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDocumentos.Size = new System.Drawing.Size(934, 156);
            this.dgvDocumentos.StampCabecalho = "Lcontstamp";
            this.dgvDocumentos.StampLocal = "Mlstamp";
            this.dgvDocumentos.TabelaSql = "Ml";
            this.dgvDocumentos.TabIndex = 44;
            this.dgvDocumentos.TbCodigo = null;
            this.dgvDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvMl);
            this.panel3.Controls.Add(this.tbDebLinhas);
            this.panel3.Controls.Add(this.tbCredLinhas);
            this.panel3.Location = new System.Drawing.Point(2, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 240);
            this.panel3.TabIndex = 36;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMl.ColumnHeadersHeight = 30;
            this.dgvMl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvMl.Condicao = null;
            this.dgvMl.CorPreto = false;
            this.dgvMl.CurrentColumnName = null;
            this.dgvMl.DefacolumnName = null;
            this.dgvMl.DellGridRow = null;
            this.dgvMl.DtDS = null;
            this.dgvMl.EnableHeadersVisualStyles = false;
            this.dgvMl.GenerateColumns = false;
            this.dgvMl.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMl.GridFilha = true;
            this.dgvMl.GridFilhaSecundaria = false;
            this.dgvMl.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvMl.HeadersHeight = 35;
            this.dgvMl.HeadersVisible = false;
            this.dgvMl.Location = new System.Drawing.Point(9, 3);
            this.dgvMl.Name = "dgvMl";
            this.dgvMl.OrderbyCampos = null;
            this.dgvMl.Origem = null;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMl.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMl.RowHeadersWidth = 10;
            this.dgvMl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMl.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvMl.Size = new System.Drawing.Size(934, 189);
            this.dgvMl.StampCabecalho = "Lcontstamp";
            this.dgvMl.StampLocal = "Mlstamp";
            this.dgvMl.TabelaSql = "Ml";
            this.dgvMl.TabIndex = 47;
            this.dgvMl.TbCodigo = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "conta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Conta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "deb";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "Débito";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cre";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "Crédito";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descritivo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Desc. Movimento";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cct";
            this.dataGridViewTextBoxColumn6.HeaderText = "C. Custo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "edeb";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn7.HeaderText = "Débito Moeda";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ecre";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn8.HeaderText = "Crédito Moeda";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // tbDebLinhas
            // 
            this.tbDebLinhas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDebLinhas.AutoComplete = false;
            this.tbDebLinhas.AutoIncrimento = true;
            this.tbDebLinhas.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDebLinhas.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDebLinhas.Condicao = "";
            this.tbDebLinhas.InPutMask = true;
            this.tbDebLinhas.IsEmail = false;
            this.tbDebLinhas.IsMatricula = false;
            this.tbDebLinhas.IsMaxLength = false;
            this.tbDebLinhas.IsNuit = false;
            this.tbDebLinhas.IsNumeric = false;
            this.tbDebLinhas.IsReadOnly = true;
            this.tbDebLinhas.IsTelephone = false;
            this.tbDebLinhas.IsUnique = false;
            this.tbDebLinhas.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDebLinhas.label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDebLinhas.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDebLinhas.Label1Text = "Débito";
            this.tbDebLinhas.Label1Text2 = null;
            this.tbDebLinhas.Location = new System.Drawing.Point(549, 191);
            this.tbDebLinhas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDebLinhas.MaxLength = 0;
            this.tbDebLinhas.MultDocumento = false;
            this.tbDebLinhas.MultiLinhas = true;
            this.tbDebLinhas.Name = "tbDebLinhas";
            this.tbDebLinhas.Nome = "TbDefault";
            this.tbDebLinhas.Obrigatorio = true;
            this.tbDebLinhas.Selected = null;
            this.tbDebLinhas.Size = new System.Drawing.Size(193, 42);
            this.tbDebLinhas.Tabela = null;
            this.tbDebLinhas.TabIndex = 48;
            this.tbDebLinhas.Tb1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDebLinhas.Tb1IsPassword = false;
            this.tbDebLinhas.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDebLinhas.Text2 = "";
            this.tbDebLinhas.Text3 = "";
            this.tbDebLinhas.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDebLinhas.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDebLinhas.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDebLinhas.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDebLinhas.Titulo = null;
            this.tbDebLinhas.ToUpperCase = false;
            this.tbDebLinhas.Value = "debfin";
            this.tbDebLinhas.Value2 = null;
            this.tbDebLinhas.ValueChange = false;
            // 
            // tbCredLinhas
            // 
            this.tbCredLinhas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCredLinhas.AutoComplete = false;
            this.tbCredLinhas.AutoIncrimento = true;
            this.tbCredLinhas.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbCredLinhas.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCredLinhas.Condicao = "";
            this.tbCredLinhas.InPutMask = true;
            this.tbCredLinhas.IsEmail = false;
            this.tbCredLinhas.IsMatricula = false;
            this.tbCredLinhas.IsMaxLength = false;
            this.tbCredLinhas.IsNuit = false;
            this.tbCredLinhas.IsNumeric = false;
            this.tbCredLinhas.IsReadOnly = true;
            this.tbCredLinhas.IsTelephone = false;
            this.tbCredLinhas.IsUnique = false;
            this.tbCredLinhas.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCredLinhas.label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCredLinhas.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCredLinhas.Label1Text = "Crédito";
            this.tbCredLinhas.Label1Text2 = null;
            this.tbCredLinhas.Location = new System.Drawing.Point(750, 191);
            this.tbCredLinhas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCredLinhas.MaxLength = 0;
            this.tbCredLinhas.MultDocumento = false;
            this.tbCredLinhas.MultiLinhas = true;
            this.tbCredLinhas.Name = "tbCredLinhas";
            this.tbCredLinhas.Nome = "TbDefault";
            this.tbCredLinhas.Obrigatorio = true;
            this.tbCredLinhas.Selected = null;
            this.tbCredLinhas.Size = new System.Drawing.Size(193, 42);
            this.tbCredLinhas.Tabela = null;
            this.tbCredLinhas.TabIndex = 47;
            this.tbCredLinhas.Tb1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCredLinhas.Tb1IsPassword = false;
            this.tbCredLinhas.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCredLinhas.Text2 = "";
            this.tbCredLinhas.Text3 = "";
            this.tbCredLinhas.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCredLinhas.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbCredLinhas.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbCredLinhas.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCredLinhas.Titulo = null;
            this.tbCredLinhas.ToUpperCase = false;
            this.tbCredLinhas.Value = "crefin";
            this.tbCredLinhas.Value2 = null;
            this.tbCredLinhas.ValueChange = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(886, -2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(29, 32);
            this.btnPrint.TabIndex = 80;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dmzMenuLinhas
            // 
            this.dmzMenuLinhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzMenuLinhas.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzMenuLinhas.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dmzMenuLinhas.ForeColor = System.Drawing.Color.White;
            this.dmzMenuLinhas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripExtrato,
            this.toolStripSeparator3,
            this.toolStripApagar,
            this.toolStripSeparator4});
            this.dmzMenuLinhas.Name = "dmzContextMenuStrip1";
            this.dmzMenuLinhas.Size = new System.Drawing.Size(180, 60);
            // 
            // toolStripExtrato
            // 
            this.toolStripExtrato.Image = global::DMZ.UI.Properties.Resources.print_251px;
            this.toolStripExtrato.Name = "toolStripExtrato";
            this.toolStripExtrato.Size = new System.Drawing.Size(179, 22);
            this.toolStripExtrato.Text = "Lançamento";
            this.toolStripExtrato.Click += new System.EventHandler(this.toolStripExtrato_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // toolStripApagar
            // 
            this.toolStripApagar.Image = global::DMZ.UI.Properties.Resources.Print_25px;
            this.toolStripApagar.Name = "toolStripApagar";
            this.toolStripApagar.Size = new System.Drawing.Size(179, 22);
            this.toolStripApagar.Text = "Todos lançamentos";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
            // 
            // ClnConta
            // 
            this.ClnConta.DataPropertyName = "Dilno";
            this.ClnConta.HeaderText = "Nº Lançam.";
            this.ClnConta.Name = "ClnConta";
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "Dinome";
            this.descricao.HeaderText = "Diário";
            this.descricao.MinimumWidth = 200;
            this.descricao.Name = "descricao";
            // 
            // ccusto
            // 
            this.ccusto.DataPropertyName = "docno";
            this.ccusto.HeaderText = "Nº Doc";
            this.ccusto.Name = "ccusto";
            this.ccusto.Visible = false;
            // 
            // clnDescMov
            // 
            this.clnDescMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnDescMov.DataPropertyName = "docnome";
            this.clnDescMov.HeaderText = "Documento";
            this.clnDescMov.MinimumWidth = 250;
            this.clnDescMov.Name = "clnDescMov";
            // 
            // deb
            // 
            this.deb.DataPropertyName = "debfin";
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
            this.cre.DataPropertyName = "crefin";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cre.DefaultCellStyle = dataGridViewCellStyle3;
            this.cre.HeaderText = "Crédito";
            this.cre.Name = "cre";
            this.cre.Width = 120;
            // 
            // clnecre
            // 
            this.clnecre.DataPropertyName = "data";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.clnecre.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnecre.HeaderText = "Data";
            this.clnecre.Name = "clnecre";
            this.clnecre.Visible = false;
            this.clnecre.Width = 90;
            // 
            // stamp
            // 
            this.stamp.DataPropertyName = "Lcontstamp";
            this.stamp.HeaderText = "stamp";
            this.stamp.Name = "stamp";
            this.stamp.Visible = false;
            // 
            // Lc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(954, 556);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Lc";
            this.Load += new System.EventHandler(this.Lc_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMl)).EndInit();
            this.dmzMenuLinhas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private UC.Procura ucDiario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Generic.GridUi dgvDocumentos;
        private UC.TbDefault tbDeb;
        private UC.TbDefault tbCred;
        private Generic.GridUi dgvMl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private UC.TbDefault tbDebLinhas;
        private UC.TbDefault tbCredLinhas;
        public System.Windows.Forms.Button btnProcess;
        private UC.CbDefault cbDebDifCre;
        public System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel5;
        private UC.DMZContextMenuStrip dmzMenuLinhas;
        private System.Windows.Forms.ToolStripMenuItem toolStripExtrato;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripApagar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private UC.DMZDt dtDatafin;
        private UC.DMZDt dtDataInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn deb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnecre;
        private System.Windows.Forms.DataGridViewTextBoxColumn stamp;
    }
}
