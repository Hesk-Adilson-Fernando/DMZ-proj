namespace DMZ.UI.UI
{
    partial class FrmArmazem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArmazem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDefault2 = new DMZ.UI.UC.CbDefault();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.gridPreco = new DMZ.UI.Generic.GridUi();
            this.Referenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDefault3 = new DMZ.UI.UC.TbDefault();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.tbDefault2 = new DMZ.UI.UC.TbDefault();
            this.tbNumero = new DMZ.UI.UC.TbDefault();
            this.barraText2 = new DMZ.UI.UC.BarraText();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dmzContextMenuStrip1 = new DMZ.UI.UC.DMZContextMenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.reajusteDePreçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.últimasComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapaDeVendasPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.listagemDeProdutosComStockPorArmazemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuLateral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMessageShow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreco)).BeginInit();
            this.dmzContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.btnMenuLateral);
            this.panelTitulo.Controls.Add(this.btnPrint);
            this.panelTitulo.Location = new System.Drawing.Point(-6, 1);
            this.panelTitulo.Size = new System.Drawing.Size(780, 30);
            this.panelTitulo.Controls.SetChildIndex(this.label1, 0);
            this.panelTitulo.Controls.SetChildIndex(this.panel5, 0);
            this.panelTitulo.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panelTitulo.Controls.SetChildIndex(this.panelMessageShow, 0);
            this.panelTitulo.Controls.SetChildIndex(this.btnRefresh, 0);
            this.panelTitulo.Controls.SetChildIndex(this.btnPrint, 0);
            this.panelTitulo.Controls.SetChildIndex(this.btnMenuLateral, 0);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.Text = "Armazens";
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
            this.panel5.Location = new System.Drawing.Point(699, 3);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(730, 36);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(730, 458);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-34, 3);
            // 
            // panelMessageShow
            // 
            this.panelMessageShow.Location = new System.Drawing.Point(278, 4);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefresh.Location = new System.Drawing.Point(673, 5);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 518);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.barraText2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbDefault2);
            this.panel2.Controls.Add(this.barraText1);
            this.panel2.Controls.Add(this.gridPreco);
            this.panel2.Controls.Add(this.tbDefault3);
            this.panel2.Controls.Add(this.cbDefault1);
            this.panel2.Controls.Add(this.tbDefault2);
            this.panel2.Controls.Add(this.tbNumero);
            this.panel2.Location = new System.Drawing.Point(3, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 452);
            this.panel2.TabIndex = 103;
            // 
            // cbDefault2
            // 
            this.cbDefault2.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault2.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault2.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault2.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault2.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault2.CbText = "É um armazem cozinha";
            this.cbDefault2.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault2.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault2.Imagem")));
            this.cbDefault2.IsOptionGroup = false;
            this.cbDefault2.IsReadOnly = false;
            this.cbDefault2.IsRequered = false;
            this.cbDefault2.Location = new System.Drawing.Point(184, 129);
            this.cbDefault2.Name = "cbDefault2";
            this.cbDefault2.OnlyCheckBox = false;
            this.cbDefault2.Size = new System.Drawing.Size(167, 22);
            this.cbDefault2.TabIndex = 105;
            this.cbDefault2.Value = "cozinha";
            this.cbDefault2.Value2 = null;
            // 
            // barraText1
            // 
            this.barraText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.White;
            this.barraText1.Label1Text = "Lista de produtos no armazem";
            this.barraText1.Location = new System.Drawing.Point(10, 157);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(678, 30);
            this.barraText1.TabIndex = 104;
            // 
            // gridPreco
            // 
            this.gridPreco.AddButtons = false;
            this.gridPreco.AllowUserToAddRows = false;
            this.gridPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPreco.AutoIncrimento = false;
            this.gridPreco.BackgroundColor = System.Drawing.Color.White;
            this.gridPreco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPreco.CampoCodigo = null;
            this.gridPreco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridPreco.Codigo = null;
            this.gridPreco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPreco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPreco.ColumnHeadersHeight = 30;
            this.gridPreco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPreco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referenc,
            this.descricao,
            this.Stock,
            this.Preco,
            this.Total});
            this.gridPreco.Condicao = null;
            this.gridPreco.CorPreto = true;
            this.gridPreco.CurrentColumnName = null;
            this.gridPreco.DefacolumnName = null;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPreco.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridPreco.DellGridRow = null;
            this.gridPreco.DtDS = null;
            this.gridPreco.EnableHeadersVisualStyles = false;
            this.gridPreco.GenerateColumns = false;
            this.gridPreco.GridColor = System.Drawing.Color.White;
            this.gridPreco.GridFilha = true;
            this.gridPreco.GridFilhaSecundaria = false;
            this.gridPreco.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPreco.HeadersHeight = 30;
            this.gridPreco.HeadersVisible = false;
            this.gridPreco.Location = new System.Drawing.Point(11, 186);
            this.gridPreco.Name = "gridPreco";
            this.gridPreco.OrderbyCampos = null;
            this.gridPreco.Origem = null;
            this.gridPreco.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridPreco.RowHeadersVisible = false;
            this.gridPreco.RowHeadersWidth = 30;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gridPreco.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridPreco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPreco.Size = new System.Drawing.Size(675, 255);
            this.gridPreco.StampCabecalho = "Ststamp";
            this.gridPreco.StampLocal = "StPrecostamp";
            this.gridPreco.TabelaSql = "StPrecos";
            this.gridPreco.TabIndex = 56;
            this.gridPreco.TbCodigo = null;
            // 
            // Referenc
            // 
            this.Referenc.DataPropertyName = "Ref";
            this.Referenc.HeaderText = "Referência";
            this.Referenc.Name = "Referenc";
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.Width = 120;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "preco";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle3;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 120;
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
            this.tbDefault3.IsMatricula = false;
            this.tbDefault3.IsMaxLength = false;
            this.tbDefault3.IsNuit = false;
            this.tbDefault3.IsNumeric = false;
            this.tbDefault3.IsReadOnly = false;
            this.tbDefault3.IsTelephone = false;
            this.tbDefault3.IsUnique = false;
            this.tbDefault3.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault3.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault3.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault3.Label1Text = "Observação";
            this.tbDefault3.Label1Text2 = null;
            this.tbDefault3.Location = new System.Drawing.Point(7, 86);
            this.tbDefault3.MaxLength = 0;
            this.tbDefault3.MultDocumento = false;
            this.tbDefault3.MultiLinhas = false;
            this.tbDefault3.Name = "tbDefault3";
            this.tbDefault3.Nome = "TbDefault";
            this.tbDefault3.Obrigatorio = false;
            this.tbDefault3.Selected = null;
            this.tbDefault3.Size = new System.Drawing.Size(681, 42);
            this.tbDefault3.Tabela = null;
            this.tbDefault3.TabIndex = 55;
            this.tbDefault3.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault3.Tb1IsPassword = false;
            this.tbDefault3.Tb1MaxLength = 1000000;
            this.tbDefault3.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault3.Text2 = "";
            this.tbDefault3.Text3 = "";
            this.tbDefault3.Text4 = "";
            this.tbDefault3.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault3.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault3.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault3.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault3.Titulo = null;
            this.tbDefault3.ToUpperCase = false;
            this.tbDefault3.Value = "obs";
            this.tbDefault3.Value2 = null;
            this.tbDefault3.Value3 = null;
            this.tbDefault3.Value4 = null;
            this.tbDefault3.ValueChange = false;
            // 
            // cbDefault1
            // 
            this.cbDefault1.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "É um armazem padrão";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(11, 129);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = false;
            this.cbDefault1.Size = new System.Drawing.Size(167, 22);
            this.cbDefault1.TabIndex = 54;
            this.cbDefault1.Value = "padrao";
            this.cbDefault1.Value2 = null;
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
            this.tbDefault2.IsUnique = false;
            this.tbDefault2.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDefault2.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault2.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDefault2.Label1Text = "Descrição";
            this.tbDefault2.Label1Text2 = null;
            this.tbDefault2.Location = new System.Drawing.Point(7, 42);
            this.tbDefault2.MaxLength = 0;
            this.tbDefault2.MultDocumento = false;
            this.tbDefault2.MultiLinhas = false;
            this.tbDefault2.Name = "tbDefault2";
            this.tbDefault2.Nome = "TbDefault";
            this.tbDefault2.Obrigatorio = true;
            this.tbDefault2.Selected = null;
            this.tbDefault2.Size = new System.Drawing.Size(414, 42);
            this.tbDefault2.Tabela = null;
            this.tbDefault2.TabIndex = 53;
            this.tbDefault2.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefault2.Tb1IsPassword = false;
            this.tbDefault2.Tb1MaxLength = 1000000;
            this.tbDefault2.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDefault2.Text2 = "";
            this.tbDefault2.Text3 = "";
            this.tbDefault2.Text4 = "";
            this.tbDefault2.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDefault2.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDefault2.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDefault2.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDefault2.Titulo = null;
            this.tbDefault2.ToUpperCase = false;
            this.tbDefault2.Value = "descricao";
            this.tbDefault2.Value2 = null;
            this.tbDefault2.Value3 = null;
            this.tbDefault2.Value4 = null;
            this.tbDefault2.ValueChange = false;
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
            this.tbNumero.Location = new System.Drawing.Point(7, 2);
            this.tbNumero.MaxLength = 0;
            this.tbNumero.MultDocumento = false;
            this.tbNumero.MultiLinhas = false;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Nome = "TbDefault";
            this.tbNumero.Obrigatorio = false;
            this.tbNumero.Selected = null;
            this.tbNumero.Size = new System.Drawing.Size(414, 42);
            this.tbNumero.Tabela = null;
            this.tbNumero.TabIndex = 52;
            this.tbNumero.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Tb1IsPassword = false;
            this.tbNumero.Tb1MaxLength = 1000000;
            this.tbNumero.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNumero.Text2 = "";
            this.tbNumero.Text3 = "";
            this.tbNumero.Text4 = "";
            this.tbNumero.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumero.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbNumero.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbNumero.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNumero.Titulo = null;
            this.tbNumero.ToUpperCase = false;
            this.tbNumero.Value = "codigo";
            this.tbNumero.Value2 = null;
            this.tbNumero.Value3 = null;
            this.tbNumero.Value4 = null;
            this.tbNumero.ValueChange = false;
            // 
            // barraText2
            // 
            this.barraText2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraText2.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText2.Label1ForeColor = System.Drawing.Color.White;
            this.barraText2.Label1Text = "Dados de armazem";
            this.barraText2.Location = new System.Drawing.Point(0, 0);
            this.barraText2.Name = "barraText2";
            this.barraText2.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText2.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText2.PictureBox1Image")));
            this.barraText2.Size = new System.Drawing.Size(699, 30);
            this.barraText2.TabIndex = 102;
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
            this.btnPrint.Location = new System.Drawing.Point(638, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(29, 32);
            this.btnPrint.TabIndex = 79;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dmzContextMenuStrip1
            // 
            this.dmzContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzContextMenuStrip1.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzContextMenuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dmzContextMenuStrip1.ForeColor = System.Drawing.Color.White;
            this.dmzContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dmzContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripSeparator4,
            this.toolStripMenuItem5,
            this.reajusteDePreçosToolStripMenuItem,
            this.últimasComprasToolStripMenuItem,
            this.mapaDeVendasPorMesToolStripMenuItem,
            this.toolStripSeparator8,
            this.listagemDeProdutosComStockPorArmazemToolStripMenuItem});
            this.dmzContextMenuStrip1.Name = "dmzContextMenuStrip2";
            this.dmzContextMenuStrip1.Size = new System.Drawing.Size(356, 172);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::DMZ.UI.Properties.Resources.Archive_Folder_32px;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(355, 26);
            this.toolStripMenuItem4.Text = "Curva ABC";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(352, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::DMZ.UI.Properties.Resources.Expensive_2_32px;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(355, 26);
            this.toolStripMenuItem5.Text = "Produtos Vendidos";
            // 
            // reajusteDePreçosToolStripMenuItem
            // 
            this.reajusteDePreçosToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Data_Sheet_25px;
            this.reajusteDePreçosToolStripMenuItem.Name = "reajusteDePreçosToolStripMenuItem";
            this.reajusteDePreçosToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.reajusteDePreçosToolStripMenuItem.Text = "Reajuste de preços ";
            // 
            // últimasComprasToolStripMenuItem
            // 
            this.últimasComprasToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.File_Settings_25px;
            this.últimasComprasToolStripMenuItem.Name = "últimasComprasToolStripMenuItem";
            this.últimasComprasToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.últimasComprasToolStripMenuItem.Text = "Historico de compras ";
            // 
            // mapaDeVendasPorMesToolStripMenuItem
            // 
            this.mapaDeVendasPorMesToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Flow_25px;
            this.mapaDeVendasPorMesToolStripMenuItem.Name = "mapaDeVendasPorMesToolStripMenuItem";
            this.mapaDeVendasPorMesToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.mapaDeVendasPorMesToolStripMenuItem.Text = "Histórico de vendas ";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(352, 6);
            // 
            // listagemDeProdutosComStockPorArmazemToolStripMenuItem
            // 
            this.listagemDeProdutosComStockPorArmazemToolStripMenuItem.Name = "listagemDeProdutosComStockPorArmazemToolStripMenuItem";
            this.listagemDeProdutosComStockPorArmazemToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.listagemDeProdutosComStockPorArmazemToolStripMenuItem.Text = "Listagem de produtos com stock por armazem";
            this.listagemDeProdutosComStockPorArmazemToolStripMenuItem.Click += new System.EventHandler(this.listagemDeProdutosComStockPorArmazemToolStripMenuItem_Click);
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
            this.btnMenuLateral.Location = new System.Drawing.Point(6, 0);
            this.btnMenuLateral.Name = "btnMenuLateral";
            this.btnMenuLateral.Size = new System.Drawing.Size(30, 29);
            this.btnMenuLateral.TabIndex = 80;
            this.btnMenuLateral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuLateral.UseVisualStyleBackColor = false;
            this.btnMenuLateral.Click += new System.EventHandler(this.btnMenuLateral_Click);
            // 
            // FrmArmazem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(774, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmArmazem";
            this.Text = "Form Classe";
            this.Load += new System.EventHandler(this.FrmArmazem_Load);
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPreco)).EndInit();
            this.dmzContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private UC.TbDefault tbDefault3;
        private UC.CbDefault cbDefault1;
        private UC.TbDefault tbDefault2;
        private UC.TbDefault tbNumero;
        private UC.BarraText barraText2;
        private UC.BarraText barraText1;
        private Generic.GridUi gridPreco;
        public System.Windows.Forms.Button btnPrint;
        private UC.DMZContextMenuStrip dmzContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem reajusteDePreçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem últimasComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapaDeVendasPorMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem listagemDeProdutosComStockPorArmazemToolStripMenuItem;
        public System.Windows.Forms.Button btnMenuLateral;
        private UC.CbDefault cbDefault2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
