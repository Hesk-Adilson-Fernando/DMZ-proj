namespace DMZ.UI.UI.Contabil
{
    partial class FrmDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbDefault1 = new DMZ.UI.UC.TbDefault();
            this.tbDefault2 = new DMZ.UI.UC.TbDefault();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.GridDocs = new DMZ.UI.Generic.GridUi();
            this.docno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Padrao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbAno = new DMZ.UI.UC.TbDefault();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.tbNome = new DMZ.UI.UC.TbDefault();
            this.tbNumero = new DMZ.UI.UC.TbDefault();
            this.cbDefault3 = new DMZ.UI.UC.CbDefault();
            this.btnMenuLateral = new System.Windows.Forms.Button();
            this.Menu = new DMZ.UI.UC.DMZContextMenuStrip();
            this.Extrato = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Saldos = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMessageShow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDocs)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.btnMenuLateral);
            this.panelTitulo.Size = new System.Drawing.Size(633, 30);
            this.panelTitulo.Controls.SetChildIndex(this.label1, 0);
            this.panelTitulo.Controls.SetChildIndex(this.panel5, 0);
            this.panelTitulo.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panelTitulo.Controls.SetChildIndex(this.panelMessageShow, 0);
            this.panelTitulo.Controls.SetChildIndex(this.btnRefresh, 0);
            this.panelTitulo.Controls.SetChildIndex(this.btnMenuLateral, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 6);
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.Text = "Diarios ";
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
            this.panel5.Location = new System.Drawing.Point(548, 2);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(586, 42);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(589, 415);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMZ.UI.Properties.Resources.Book_Shelf_32px;
            this.pictureBox1.Location = new System.Drawing.Point(-34, 3);
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // panelMessageShow
            // 
            this.panelMessageShow.Location = new System.Drawing.Point(280, 2);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefresh.Location = new System.Drawing.Point(523, 5);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel2.Location = new System.Drawing.Point(8, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 3);
            this.panel2.TabIndex = 63;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 429);
            this.tabControl1.TabIndex = 69;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbDefault1);
            this.panel4.Controls.Add(this.tbDefault2);
            this.panel4.Location = new System.Drawing.Point(3, 345);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 54);
            this.panel4.TabIndex = 76;
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
            this.tbDefault1.IsReadOnly = true;
            this.tbDefault1.IsTelephone = false;
            this.tbDefault1.IsUnique = false;
            this.tbDefault1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault1.label1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault1.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault1.Label1Text = "Débito";
            this.tbDefault1.Label1Text2 = null;
            this.tbDefault1.Location = new System.Drawing.Point(3, 1);
            this.tbDefault1.MaxLength = 0;
            this.tbDefault1.MultDocumento = false;
            this.tbDefault1.MultiLinhas = false;
            this.tbDefault1.Name = "tbDefault1";
            this.tbDefault1.Nome = "TbDefault";
            this.tbDefault1.Obrigatorio = false;
            this.tbDefault1.Selected = null;
            this.tbDefault1.Size = new System.Drawing.Size(163, 42);
            this.tbDefault1.Tabela = null;
            this.tbDefault1.TabIndex = 70;
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
            this.tbDefault1.Value = "deb";
            this.tbDefault1.Value2 = null;
            this.tbDefault1.ValueChange = false;
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
            this.tbDefault2.IsReadOnly = true;
            this.tbDefault2.IsTelephone = false;
            this.tbDefault2.IsUnique = false;
            this.tbDefault2.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault2.label1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault2.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault2.Label1Text = "Crédito";
            this.tbDefault2.Label1Text2 = null;
            this.tbDefault2.Location = new System.Drawing.Point(185, 1);
            this.tbDefault2.MaxLength = 0;
            this.tbDefault2.MultDocumento = false;
            this.tbDefault2.MultiLinhas = false;
            this.tbDefault2.Name = "tbDefault2";
            this.tbDefault2.Nome = "TbDefault";
            this.tbDefault2.Obrigatorio = false;
            this.tbDefault2.Selected = null;
            this.tbDefault2.Size = new System.Drawing.Size(163, 42);
            this.tbDefault2.Tabela = null;
            this.tbDefault2.TabIndex = 71;
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
            this.tbDefault2.Value = "cre";
            this.tbDefault2.Value2 = null;
            this.tbDefault2.ValueChange = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.gridPanel21);
            this.panel6.Controls.Add(this.tbAno);
            this.panel6.Controls.Add(this.cbDefault1);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(558, 338);
            this.panel6.TabIndex = 74;
            // 
            // gridPanel21
            // 
            this.gridPanel21.AddControls = false;
            this.gridPanel21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel21.Callform = false;
            this.gridPanel21.Controls.Add(this.GridDocs);
            this.gridPanel21.DefaultColumn = null;
            this.gridPanel21.Gridnome = "GridMovim";
            this.gridPanel21.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.Label1Color = System.Drawing.Color.DarkGoldenrod;
            this.gridPanel21.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel21.Label1Text = "Documentos ";
            this.gridPanel21.Location = new System.Drawing.Point(2, 44);
            this.gridPanel21.MostraGravar = false;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.Documents_20px;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(553, 293);
            this.gridPanel21.TabIndex = 78;
            this.gridPanel21.TipoMenu = false;
            this.gridPanel21.UsaNomeGrid = false;
            // 
            // GridDocs
            // 
            this.GridDocs.AddButtons = false;
            this.GridDocs.AllowUserToAddRows = false;
            this.GridDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridDocs.AutoIncrimento = false;
            this.GridDocs.BackgroundColor = System.Drawing.Color.White;
            this.GridDocs.CampoCodigo = null;
            this.GridDocs.Codigo = null;
            this.GridDocs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDocs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridDocs.ColumnHeadersHeight = 30;
            this.GridDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docno,
            this.descricao,
            this.Padrao});
            this.GridDocs.Condicao = null;
            this.GridDocs.CorPreto = false;
            this.GridDocs.CurrentColumnName = null;
            this.GridDocs.DefacolumnName = "descricao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDocs.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridDocs.DellGridRow = null;
            this.GridDocs.DtDS = null;
            this.GridDocs.EnableHeadersVisualStyles = false;
            this.GridDocs.GenerateColumns = false;
            this.GridDocs.GridColor = System.Drawing.Color.SteelBlue;
            this.GridDocs.GridFilha = true;
            this.GridDocs.GridFilhaSecundaria = false;
            this.GridDocs.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridDocs.HeadersHeight = 35;
            this.GridDocs.HeadersVisible = false;
            this.GridDocs.Location = new System.Drawing.Point(1, 27);
            this.GridDocs.Name = "GridDocs";
            this.GridDocs.OrderbyCampos = null;
            this.GridDocs.Origem = null;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDocs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridDocs.RowHeadersWidth = 10;
            this.GridDocs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.GridDocs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridDocs.Size = new System.Drawing.Size(552, 261);
            this.GridDocs.StampCabecalho = "Diariostamp";
            this.GridDocs.StampLocal = "Diariodocstamp";
            this.GridDocs.TabelaSql = "Diariodoc";
            this.GridDocs.TabIndex = 43;
            this.GridDocs.TbCodigo = null;
            this.GridDocs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDocs_CellEndEdit);
            this.GridDocs.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.GridDocs_EditingControlShowing);
            // 
            // docno
            // 
            this.docno.DataPropertyName = "codigo";
            this.docno.HeaderText = "Código";
            this.docno.Name = "docno";
            this.docno.Width = 60;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 200;
            this.descricao.Name = "descricao";
            // 
            // Padrao
            // 
            this.Padrao.DataPropertyName = "padrao";
            this.Padrao.HeaderText = "Padrão";
            this.Padrao.Name = "Padrao";
            this.Padrao.Width = 60;
            // 
            // tbAno
            // 
            this.tbAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAno.AutoComplete = false;
            this.tbAno.AutoIncrimento = false;
            this.tbAno.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbAno.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAno.Condicao = "";
            this.tbAno.InPutMask = false;
            this.tbAno.IsEmail = false;
            this.tbAno.IsMatricula = false;
            this.tbAno.IsMaxLength = false;
            this.tbAno.IsNuit = false;
            this.tbAno.IsNumeric = false;
            this.tbAno.IsReadOnly = false;
            this.tbAno.IsTelephone = false;
            this.tbAno.IsUnique = false;
            this.tbAno.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAno.label1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAno.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbAno.Label1Text = "Ano";
            this.tbAno.Label1Text2 = null;
            this.tbAno.Location = new System.Drawing.Point(395, 0);
            this.tbAno.MaxLength = 0;
            this.tbAno.MultDocumento = false;
            this.tbAno.MultiLinhas = false;
            this.tbAno.Name = "tbAno";
            this.tbAno.Nome = "TbDefault";
            this.tbAno.Obrigatorio = true;
            this.tbAno.Selected = null;
            this.tbAno.Size = new System.Drawing.Size(158, 42);
            this.tbAno.Tabela = null;
            this.tbAno.TabIndex = 72;
            this.tbAno.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAno.Tb1IsPassword = false;
            this.tbAno.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAno.Text2 = "";
            this.tbAno.Text3 = "";
            this.tbAno.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAno.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbAno.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbAno.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAno.Titulo = null;
            this.tbAno.ToUpperCase = false;
            this.tbAno.Value = "diano";
            this.tbAno.Value2 = null;
            this.tbAno.ValueChange = false;
            // 
            // cbDefault1
            // 
            this.cbDefault1.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "Diário de Apuramentos?";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(12, 20);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = false;
            this.cbDefault1.Size = new System.Drawing.Size(177, 22);
            this.cbDefault1.TabIndex = 70;
            this.cbDefault1.Value = "apura";
            this.cbDefault1.Value2 = null;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.AutoComplete = false;
            this.tbNome.AutoIncrimento = false;
            this.tbNome.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbNome.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.Condicao = "";
            this.tbNome.InPutMask = false;
            this.tbNome.IsEmail = false;
            this.tbNome.IsMatricula = false;
            this.tbNome.IsMaxLength = false;
            this.tbNome.IsNuit = false;
            this.tbNome.IsNumeric = false;
            this.tbNome.IsReadOnly = false;
            this.tbNome.IsTelephone = false;
            this.tbNome.IsUnique = false;
            this.tbNome.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNome.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbNome.Label1Text = "Descrição";
            this.tbNome.Label1Text2 = null;
            this.tbNome.Location = new System.Drawing.Point(131, 38);
            this.tbNome.MaxLength = 0;
            this.tbNome.MultDocumento = false;
            this.tbNome.MultiLinhas = false;
            this.tbNome.Name = "tbNome";
            this.tbNome.Nome = "TbDefault";
            this.tbNome.Obrigatorio = true;
            this.tbNome.Selected = null;
            this.tbNome.Size = new System.Drawing.Size(363, 42);
            this.tbNome.Tabela = null;
            this.tbNome.TabIndex = 64;
            this.tbNome.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Tb1IsPassword = false;
            this.tbNome.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNome.Text2 = "";
            this.tbNome.Text3 = "";
            this.tbNome.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbNome.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbNome.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNome.Titulo = null;
            this.tbNome.ToUpperCase = false;
            this.tbNome.Value = "descricao";
            this.tbNome.Value2 = null;
            this.tbNome.ValueChange = false;
            // 
            // tbNumero
            // 
            this.tbNumero.AutoComplete = false;
            this.tbNumero.AutoIncrimento = true;
            this.tbNumero.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbNumero.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumero.Condicao = "";
            this.tbNumero.InPutMask = false;
            this.tbNumero.IsEmail = false;
            this.tbNumero.IsMatricula = false;
            this.tbNumero.IsMaxLength = false;
            this.tbNumero.IsNuit = false;
            this.tbNumero.IsNumeric = false;
            this.tbNumero.IsReadOnly = false;
            this.tbNumero.IsTelephone = false;
            this.tbNumero.IsUnique = false;
            this.tbNumero.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNumero.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbNumero.Label1Text = "Código";
            this.tbNumero.Label1Text2 = null;
            this.tbNumero.Location = new System.Drawing.Point(0, 38);
            this.tbNumero.MaxLength = 0;
            this.tbNumero.MultDocumento = false;
            this.tbNumero.MultiLinhas = false;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Nome = "TbDefault";
            this.tbNumero.Obrigatorio = true;
            this.tbNumero.Selected = null;
            this.tbNumero.Size = new System.Drawing.Size(125, 42);
            this.tbNumero.Tabela = null;
            this.tbNumero.TabIndex = 62;
            this.tbNumero.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Tb1IsPassword = false;
            this.tbNumero.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNumero.Text2 = "";
            this.tbNumero.Text3 = "";
            this.tbNumero.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumero.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbNumero.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbNumero.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNumero.Titulo = null;
            this.tbNumero.ToUpperCase = false;
            this.tbNumero.Value = "dino";
            this.tbNumero.Value2 = null;
            this.tbNumero.ValueChange = false;
            // 
            // cbDefault3
            // 
            this.cbDefault3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDefault3.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault3.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault3.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault3.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault3.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault3.CbText = "Padrão";
            this.cbDefault3.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault3.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault3.Imagem")));
            this.cbDefault3.IsOptionGroup = false;
            this.cbDefault3.IsReadOnly = false;
            this.cbDefault3.IsRequered = false;
            this.cbDefault3.Location = new System.Drawing.Point(500, 56);
            this.cbDefault3.Name = "cbDefault3";
            this.cbDefault3.OnlyCheckBox = false;
            this.cbDefault3.Size = new System.Drawing.Size(105, 22);
            this.cbDefault3.TabIndex = 68;
            this.cbDefault3.Value = "defeito";
            this.cbDefault3.Value2 = null;
            // 
            // btnMenuLateral
            // 
            this.btnMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMenuLateral.FlatAppearance.BorderSize = 0;
            this.btnMenuLateral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMenuLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuLateral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuLateral.ForeColor = System.Drawing.Color.White;
            this.btnMenuLateral.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_251px;
            this.btnMenuLateral.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuLateral.Location = new System.Drawing.Point(0, -1);
            this.btnMenuLateral.Name = "btnMenuLateral";
            this.btnMenuLateral.Size = new System.Drawing.Size(30, 29);
            this.btnMenuLateral.TabIndex = 68;
            this.btnMenuLateral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuLateral.UseVisualStyleBackColor = false;
            this.btnMenuLateral.Click += new System.EventHandler(this.btnMenuLateral_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Menu.ContextBackcolor = System.Drawing.Color.WhiteSmoke;
            this.Menu.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Extrato,
            this.toolStripSeparator5,
            this.Saldos,
            this.planoDeContasToolStripMenuItem});
            this.Menu.Name = "Apuramentos";
            this.Menu.Size = new System.Drawing.Size(187, 88);
            // 
            // Extrato
            // 
            this.Extrato.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.Extrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Extrato.Image = global::DMZ.UI.Properties.Resources.Graph_20px;
            this.Extrato.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Extrato.Name = "Extrato";
            this.Extrato.Size = new System.Drawing.Size(186, 26);
            this.Extrato.Text = "Extrato";
            this.Extrato.Click += new System.EventHandler(this.Extrato_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(183, 6);
            // 
            // Saldos
            // 
            this.Saldos.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.Saldos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Saldos.Image = global::DMZ.UI.Properties.Resources.Increase_20px;
            this.Saldos.Name = "Saldos";
            this.Saldos.Size = new System.Drawing.Size(186, 26);
            this.Saldos.Text = "Saldos";
            this.Saldos.Visible = false;
            // 
            // planoDeContasToolStripMenuItem
            // 
            this.planoDeContasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.planoDeContasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.planoDeContasToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Group_Objects_28px;
            this.planoDeContasToolStripMenuItem.Name = "planoDeContasToolStripMenuItem";
            this.planoDeContasToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.planoDeContasToolStripMenuItem.Text = "Plano de contas ";
            this.planoDeContasToolStripMenuItem.Visible = false;
            this.planoDeContasToolStripMenuItem.Click += new System.EventHandler(this.planoDeContasToolStripMenuItem_Click);
            // 
            // FrmDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(633, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbDefault3);
            this.Name = "FrmDiario";
            this.Text = "Form Classe";
            this.Load += new System.EventHandler(this.FrmDiario_Load);
            this.Controls.SetChildIndex(this.cbDefault3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panelTitulo, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tbNumero, 0);
            this.Controls.SetChildIndex(this.tbNome, 0);
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
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDocs)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UC.TbDefault tbNome;
        private UC.TbDefault tbNumero;
        private System.Windows.Forms.Panel panel2;
        private UC.CbDefault cbDefault3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.TbDefault tbDefault1;
        private System.Windows.Forms.Panel panel6;
        private UC.TbDefault tbAno;
        private UC.TbDefault tbDefault2;
        private UC.CbDefault cbDefault1;
        private System.Windows.Forms.Panel panel4;
        public UC.GridPanel2 gridPanel21;
        public Generic.GridUi GridDocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn docno;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Padrao;
        public System.Windows.Forms.Button btnMenuLateral;
        private UC.DMZContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Extrato;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Saldos;
        private System.Windows.Forms.ToolStripMenuItem planoDeContasToolStripMenuItem;
    }
}
