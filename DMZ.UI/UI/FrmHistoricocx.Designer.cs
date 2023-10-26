
namespace DMZ.UI.UI
{
    partial class FrmHistoricocx
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.tbDefault2 = new DMZ.UI.UC.TbDefault();
            this.tbDefault1 = new DMZ.UI.UC.TbDefault();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Inicio = new System.Windows.Forms.TabPage();
            this.gridUIArm = new DMZ.UI.Generic.GridUi();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Defeito = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridUICaixa = new DMZ.UI.Generic.GridUi();
            this.codtz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poscaixa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.posbanco = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Status = new DMZ.UI.UC.Procura();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUIArm)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUICaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(760, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(728, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.Text = "Históricos de caixa";
            // 
            // btnExtrato
            // 
            this.btnExtrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnExtrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExtrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtrato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrato.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnExtrato.Image = global::DMZ.UI.Properties.Resources.Money_Bag_25px;
            this.btnExtrato.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExtrato.Location = new System.Drawing.Point(654, 418);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(99, 32);
            this.btnExtrato.TabIndex = 72;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtrato.UseVisualStyleBackColor = false;
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
            this.tbDefault2.IsMatricula = false;
            this.tbDefault2.IsMaxLength = false;
            this.tbDefault2.IsNuit = false;
            this.tbDefault2.IsNumeric = false;
            this.tbDefault2.IsReadOnly = false;
            this.tbDefault2.IsTelephone = false;
            this.tbDefault2.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault2.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault2.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault2.Label1Text = "Descrição";
            this.tbDefault2.Location = new System.Drawing.Point(169, 47);
            this.tbDefault2.MaxLength = 0;
            this.tbDefault2.MultDocumento = false;
            this.tbDefault2.MultiLinhas = false;
            this.tbDefault2.Name = "tbDefault2";
            this.tbDefault2.Obrigatorio = true;
            this.tbDefault2.Selected = null;
            this.tbDefault2.Size = new System.Drawing.Size(387, 42);
            this.tbDefault2.Tabela = null;
            this.tbDefault2.TabIndex = 70;
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
            this.tbDefault2.Value = "descricao";
            this.tbDefault2.Value2 = null;
            this.tbDefault2.ValueChange = false;
            // 
            // tbDefault1
            // 
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
            this.tbDefault1.Label1Text = "Referência";
            this.tbDefault1.Location = new System.Drawing.Point(2, 47);
            this.tbDefault1.MaxLength = 0;
            this.tbDefault1.MultDocumento = false;
            this.tbDefault1.MultiLinhas = false;
            this.tbDefault1.Name = "tbDefault1";
            this.tbDefault1.Obrigatorio = true;
            this.tbDefault1.Selected = null;
            this.tbDefault1.Size = new System.Drawing.Size(166, 42);
            this.tbDefault1.Tabela = null;
            this.tbDefault1.TabIndex = 67;
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
            this.tbDefault1.Value = "codccu";
            this.tbDefault1.Value2 = null;
            this.tbDefault1.ValueChange = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel2.Location = new System.Drawing.Point(10, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 3);
            this.panel2.TabIndex = 69;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Inicio);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 309);
            this.tabControl1.TabIndex = 68;
            // 
            // Inicio
            // 
            this.Inicio.Controls.Add(this.gridUIArm);
            this.Inicio.Location = new System.Drawing.Point(4, 22);
            this.Inicio.Name = "Inicio";
            this.Inicio.Padding = new System.Windows.Forms.Padding(3);
            this.Inicio.Size = new System.Drawing.Size(735, 298);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Aberturas ";
            this.Inicio.UseVisualStyleBackColor = true;
            // 
            // gridUIArm
            // 
            this.gridUIArm.AddButtons = false;
            this.gridUIArm.AllowUserToAddRows = false;
            this.gridUIArm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUIArm.AutoIncrimento = false;
            this.gridUIArm.BackgroundColor = System.Drawing.Color.White;
            this.gridUIArm.CampoCodigo = null;
            this.gridUIArm.Codigo = null;
            this.gridUIArm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUIArm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUIArm.ColumnHeadersHeight = 30;
            this.gridUIArm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUIArm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.Defeito});
            this.gridUIArm.Condicao = null;
            this.gridUIArm.CorPreto = true;
            this.gridUIArm.CurrentColumnName = null;
            this.gridUIArm.DefacolumnName = null;
            this.gridUIArm.DtDS = null;
            this.gridUIArm.EnableHeadersVisualStyles = false;
            this.gridUIArm.GenerateColumns = false;
            this.gridUIArm.GridColor = System.Drawing.Color.White;
            this.gridUIArm.GridFilha = true;
            this.gridUIArm.GridFilhaSecundaria = false;
            this.gridUIArm.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUIArm.HeadersHeight = 30;
            this.gridUIArm.HeadersVisible = false;
            this.gridUIArm.Location = new System.Drawing.Point(3, 11);
            this.gridUIArm.Margin = new System.Windows.Forms.Padding(3, 6901, 3, 6901);
            this.gridUIArm.Name = "gridUIArm";
            this.gridUIArm.OrderbyCampos = null;
            this.gridUIArm.RowHeadersVisible = false;
            this.gridUIArm.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridUIArm.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUIArm.Size = new System.Drawing.Size(732, 285);
            this.gridUIArm.StampCabecalho = "ccustamp";
            this.gridUIArm.StampLocal = "ccu_armstamp";
            this.gridUIArm.TabelaSql = "ccu_arm";
            this.gridUIArm.TabIndex = 2;
            this.gridUIArm.TbCodigo = null;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codarm";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Visible = false;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Defeito
            // 
            this.Defeito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Defeito.DataPropertyName = "defeito";
            this.Defeito.HeaderText = "Padrão";
            this.Defeito.Name = "Defeito";
            this.Defeito.Width = 46;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridUICaixa);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fechos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridUICaixa
            // 
            this.gridUICaixa.AddButtons = false;
            this.gridUICaixa.AllowUserToAddRows = false;
            this.gridUICaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUICaixa.AutoIncrimento = false;
            this.gridUICaixa.BackgroundColor = System.Drawing.Color.White;
            this.gridUICaixa.CampoCodigo = null;
            this.gridUICaixa.Codigo = null;
            this.gridUICaixa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUICaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUICaixa.ColumnHeadersHeight = 30;
            this.gridUICaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUICaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codtz,
            this.conta,
            this.banco,
            this.sigla,
            this.poscaixa,
            this.posbanco,
            this.dataGridViewCheckBoxColumn1});
            this.gridUICaixa.Condicao = null;
            this.gridUICaixa.CorPreto = true;
            this.gridUICaixa.CurrentColumnName = null;
            this.gridUICaixa.DefacolumnName = null;
            this.gridUICaixa.DtDS = null;
            this.gridUICaixa.EnableHeadersVisualStyles = false;
            this.gridUICaixa.GenerateColumns = false;
            this.gridUICaixa.GridColor = System.Drawing.Color.White;
            this.gridUICaixa.GridFilha = true;
            this.gridUICaixa.GridFilhaSecundaria = false;
            this.gridUICaixa.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUICaixa.HeadersHeight = 30;
            this.gridUICaixa.HeadersVisible = true;
            this.gridUICaixa.Location = new System.Drawing.Point(3, 0);
            this.gridUICaixa.Margin = new System.Windows.Forms.Padding(3, 6901, 3, 6901);
            this.gridUICaixa.Name = "gridUICaixa";
            this.gridUICaixa.OrderbyCampos = null;
            this.gridUICaixa.RowHeadersVisible = false;
            this.gridUICaixa.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridUICaixa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUICaixa.Size = new System.Drawing.Size(729, 283);
            this.gridUICaixa.StampCabecalho = "ccustamp";
            this.gridUICaixa.StampLocal = "ccu_caixastamp";
            this.gridUICaixa.TabelaSql = "ccu_caixa";
            this.gridUICaixa.TabIndex = 3;
            this.gridUICaixa.TbCodigo = null;
            // 
            // codtz
            // 
            this.codtz.DataPropertyName = "codtz";
            this.codtz.HeaderText = "Código";
            this.codtz.Name = "codtz";
            this.codtz.Visible = false;
            this.codtz.Width = 50;
            // 
            // conta
            // 
            this.conta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.conta.DataPropertyName = "descricao";
            this.conta.HeaderText = "Contas";
            this.conta.Name = "conta";
            // 
            // banco
            // 
            this.banco.DataPropertyName = "banco";
            this.banco.HeaderText = "Banco";
            this.banco.Name = "banco";
            this.banco.Visible = false;
            this.banco.Width = 120;
            // 
            // sigla
            // 
            this.sigla.DataPropertyName = "sigla";
            this.sigla.HeaderText = "Sigla";
            this.sigla.Name = "sigla";
            this.sigla.Visible = false;
            this.sigla.Width = 50;
            // 
            // poscaixa
            // 
            this.poscaixa.DataPropertyName = "Poscaixa";
            this.poscaixa.HeaderText = "É Caixa";
            this.poscaixa.Name = "poscaixa";
            this.poscaixa.Visible = false;
            this.poscaixa.Width = 60;
            // 
            // posbanco
            // 
            this.posbanco.DataPropertyName = "Posbanco";
            this.posbanco.HeaderText = "É Banco";
            this.posbanco.Name = "posbanco";
            this.posbanco.Visible = false;
            this.posbanco.Width = 60;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "defeito";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Padrão";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 46;
            // 
            // Status
            // 
            this.Status.AutoComplete = false;
            this.Status.Campo = null;
            this.Status.Campo1 = null;
            this.Status.CampoStatus = false;
            this.Status.ColunaCodigo = "Código";
            this.Status.ColunaDescricao = "Descrição";
            this.Status.Condicao = "";
            this.Status.DependDescricao = null;
            this.Status.Dependente = false;
            this.Status.DependenteNome = null;
            this.Status.Descname = null;
            this.Status.EnableTb1Field = false;
            this.Status.ExecMetodo = false;
            this.Status.FormName = null;
            this.Status.HideFirstColumn = false;
            this.Status.InserirNovo = false;
            this.Status.InvertColuna = false;
            this.Status.IsLocaDs = false;
            this.Status.IsRequered = false;
            this.Status.IsSqlSelect = false;
            this.Status.Istatus = false;
            this.Status.Items = null;
            this.Status.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.Label1Text = "Status";
            this.Status.Location = new System.Drawing.Point(556, 49);
            this.Status.MultDocumento = false;
            this.Status.Name = "Status";
            this.Status.ParentFormName = null;
            this.Status.Pp = null;
            this.Status.ReturnDt = false;
            this.Status.Selecionado = "codigo,descricao";
            this.Status.ShowThirdColumn = false;
            this.Status.Size = new System.Drawing.Size(212, 39);
            this.Status.SqlComandText = null;
            this.Status.Tabela = "status";
            this.Status.TabIndex = 71;
            this.Status.TbCkUpdate = false;
            this.Status.TbClear = false;
            this.Status.TbUpDate = null;
            this.Status.Text2 = null;
            this.Status.Text3 = null;
            this.Status.Titulo = "Procurar";
            this.Status.TmpFound = null;
            this.Status.UpdateTextBox = null;
            this.Status.Value = "Status";
            this.Status.Value2 = null;
            this.Status.Value3 = null;
            // 
            // FrmHistoricocx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(761, 462);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.tbDefault2);
            this.Controls.Add(this.tbDefault1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Status);
            this.Name = "FrmHistoricocx";
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.Status, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tbDefault1, 0);
            this.Controls.SetChildIndex(this.tbDefault2, 0);
            this.Controls.SetChildIndex(this.btnExtrato, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Inicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUIArm)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUICaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnExtrato;
        private UC.TbDefault tbDefault2;
        private UC.TbDefault tbDefault1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Inicio;
        private Generic.GridUi gridUIArm;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Defeito;
        private System.Windows.Forms.TabPage tabPage2;
        private Generic.GridUi gridUICaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtz;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla;
        private System.Windows.Forms.DataGridViewCheckBoxColumn poscaixa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn posbanco;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private UC.Procura Status;
    }
}
