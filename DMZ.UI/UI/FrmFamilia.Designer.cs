namespace DMZ.UI.UI
{
    partial class FrmFamilia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFamilia));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.gridUI1 = new DMZ.UI.Generic.GridUi();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnProc = new DMZ.UI.Generic.TextAndImageColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbCodigo = new DMZ.UI.UC.TbDefault();
            this.tbDescricao = new DMZ.UI.UC.TbDefault();
            this.imgGroup1 = new DMZ.UI.UC.ImgGroup();
            this.tbDefault3 = new DMZ.UI.UC.TbDefault();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.procura1 = new DMZ.UI.UC.Procura();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMessageShow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUI1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Size = new System.Drawing.Size(705, 30);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.Text = "Familias ";
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
            this.panel5.Location = new System.Drawing.Point(620, 2);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(661, 36);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(661, 449);
            // 
            // panelMessageShow
            // 
            this.panelMessageShow.Location = new System.Drawing.Point(330, 3);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefresh.Location = new System.Drawing.Point(594, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(9, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 515);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.barraText1);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais ";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(6, 186);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(628, 297);
            this.tabControl2.TabIndex = 77;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.gridPanel21);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(620, 271);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Subfamílias ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridPanel21
            // 
            this.gridPanel21.AddControls = false;
            this.gridPanel21.Callform = false;
            this.gridPanel21.Controls.Add(this.gridUI1);
            this.gridPanel21.DefaultColumn = null;
            this.gridPanel21.Gridnome = "gridUI1";
            this.gridPanel21.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.Label1Color = System.Drawing.Color.White;
            this.gridPanel21.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel21.Label1Text = "";
            this.gridPanel21.Location = new System.Drawing.Point(5, 6);
            this.gridPanel21.MostraGravar = false;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.Activo;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(607, 257);
            this.gridPanel21.TabIndex = 76;
            this.gridPanel21.TipoMenu = false;
            this.gridPanel21.UsaNomeGrid = false;
            this.gridPanel21.CallForm += new DMZ.UI.UC.GridPanel2.ClickButton(this.gridPanel21_CallForm);
            this.gridPanel21.BeforeAddLineEvent += new DMZ.UI.UC.GridPanel2.BeforeAddLineDelegate(this.gridPanel21_BeforeAddLineEvent);
            // 
            // gridUI1
            // 
            this.gridUI1.AddButtons = false;
            this.gridUI1.AllowUserToAddRows = false;
            this.gridUI1.AutoIncrimento = false;
            this.gridUI1.BackgroundColor = System.Drawing.Color.Snow;
            this.gridUI1.CampoCodigo = null;
            this.gridUI1.Codigo = null;
            this.gridUI1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUI1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUI1.ColumnHeadersHeight = 30;
            this.gridUI1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUI1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.descricao,
            this.pos,
            this.btnProc,
            this.Imagem});
            this.gridUI1.Condicao = null;
            this.gridUI1.CorPreto = true;
            this.gridUI1.CurrentColumnName = null;
            this.gridUI1.DefacolumnName = null;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUI1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridUI1.DellGridRow = null;
            this.gridUI1.DtDS = null;
            this.gridUI1.EnableHeadersVisualStyles = false;
            this.gridUI1.GenerateColumns = false;
            this.gridUI1.GridColor = System.Drawing.Color.White;
            this.gridUI1.GridFilha = true;
            this.gridUI1.GridFilhaSecundaria = false;
            this.gridUI1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUI1.HeadersHeight = 30;
            this.gridUI1.HeadersVisible = false;
            this.gridUI1.Location = new System.Drawing.Point(0, 25);
            this.gridUI1.Name = "gridUI1";
            this.gridUI1.OrderbyCampos = null;
            this.gridUI1.Origem = null;
            this.gridUI1.RowHeadersVisible = false;
            this.gridUI1.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUI1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUI1.RowTemplate.Height = 60;
            this.gridUI1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUI1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUI1.Size = new System.Drawing.Size(607, 229);
            this.gridUI1.StampCabecalho = "familiastamp";
            this.gridUI1.StampLocal = "Subfamstamp";
            this.gridUI1.TabelaSql = "Subfam";
            this.gridUI1.TabIndex = 75;
            this.gridUI1.TbCodigo = null;
            this.gridUI1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUI1_CellClick);
            this.gridUI1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUI1_CellEnter);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 120;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 280;
            this.descricao.Name = "descricao";
            // 
            // pos
            // 
            this.pos.DataPropertyName = "Pos";
            this.pos.HeaderText = "POS";
            this.pos.Name = "pos";
            this.pos.Width = 30;
            // 
            // btnProc
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnProc.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnProc.HeaderText = "...";
            this.btnProc.Image = global::DMZ.UI.Properties.Resources.External_Link_251px;
            this.btnProc.Name = "btnProc";
            this.btnProc.Width = 30;
            // 
            // Imagem
            // 
            this.Imagem.DataPropertyName = "Imagem";
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagem.MinimumWidth = 100;
            this.Imagem.Name = "Imagem";
            // 
            // barraText1
            // 
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.White;
            this.barraText1.Label1Text = "Famílias ";
            this.barraText1.Location = new System.Drawing.Point(5, 8);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(632, 30);
            this.barraText1.TabIndex = 74;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tbCodigo);
            this.panel6.Controls.Add(this.tbDescricao);
            this.panel6.Controls.Add(this.imgGroup1);
            this.panel6.Controls.Add(this.tbDefault3);
            this.panel6.Controls.Add(this.cbDefault1);
            this.panel6.Controls.Add(this.procura1);
            this.panel6.Location = new System.Drawing.Point(6, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(627, 140);
            this.panel6.TabIndex = 73;
            // 
            // tbCodigo
            // 
            this.tbCodigo.AutoComplete = false;
            this.tbCodigo.AutoIncrimento = true;
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
            this.tbCodigo.Location = new System.Drawing.Point(3, 7);
            this.tbCodigo.MaxLength = 0;
            this.tbCodigo.MultDocumento = false;
            this.tbCodigo.MultiLinhas = false;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Nome = "TbDefault";
            this.tbCodigo.Obrigatorio = false;
            this.tbCodigo.Selected = null;
            this.tbCodigo.Size = new System.Drawing.Size(129, 42);
            this.tbCodigo.Tabela = null;
            this.tbCodigo.TabIndex = 0;
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
            this.tbDescricao.Location = new System.Drawing.Point(132, 7);
            this.tbDescricao.MaxLength = 0;
            this.tbDescricao.MultDocumento = false;
            this.tbDescricao.MultiLinhas = false;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Nome = "TbDefault";
            this.tbDescricao.Obrigatorio = true;
            this.tbDescricao.Selected = null;
            this.tbDescricao.Size = new System.Drawing.Size(326, 42);
            this.tbDescricao.Tabela = null;
            this.tbDescricao.TabIndex = 1;
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
            // imgGroup1
            // 
            this.imgGroup1.BackColor = System.Drawing.Color.Transparent;
            this.imgGroup1.Location = new System.Drawing.Point(464, 3);
            this.imgGroup1.Name = "imgGroup1";
            this.imgGroup1.SetWhitePicture = false;
            this.imgGroup1.Size = new System.Drawing.Size(158, 129);
            this.imgGroup1.TabIndex = 55;
            this.imgGroup1.TiffImage = false;
            this.imgGroup1.Value = "Imagem";
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
            this.tbDefault3.Label1Text = "Descrição POS";
            this.tbDefault3.Label1Text2 = null;
            this.tbDefault3.Location = new System.Drawing.Point(3, 48);
            this.tbDefault3.MaxLength = 0;
            this.tbDefault3.MultDocumento = false;
            this.tbDefault3.MultiLinhas = false;
            this.tbDefault3.Name = "tbDefault3";
            this.tbDefault3.Nome = "TbDefault";
            this.tbDefault3.Obrigatorio = false;
            this.tbDefault3.Selected = null;
            this.tbDefault3.Size = new System.Drawing.Size(452, 42);
            this.tbDefault3.Tabela = null;
            this.tbDefault3.TabIndex = 53;
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
            this.tbDefault3.Value = "Descpos";
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
            this.cbDefault1.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "Aparece no POS ?";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(7, 106);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = false;
            this.cbDefault1.Size = new System.Drawing.Size(143, 22);
            this.cbDefault1.TabIndex = 54;
            this.cbDefault1.Value = "pos";
            this.cbDefault1.Value2 = null;
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
            this.procura1.EnableTb1Field = false;
            this.procura1.ExecMetodo = false;
            this.procura1.FormName = null;
            this.procura1.HideFirstColumn = true;
            this.procura1.InserirNovo = false;
            this.procura1.InvertColuna = true;
            this.procura1.IsLocaDs = false;
            this.procura1.IsRequered = false;
            this.procura1.IsSqlSelect = true;
            this.procura1.Istatus = false;
            this.procura1.IsUnique = false;
            this.procura1.Items = null;
            this.procura1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procura1.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procura1.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.procura1.Label1Text = "Código de integração á contabilidade ";
            this.procura1.Location = new System.Drawing.Point(149, 91);
            this.procura1.MultDocumento = false;
            this.procura1.Name = "procura1";
            this.procura1.OpenInfo = false;
            this.procura1.ParentFormName = null;
            this.procura1.Pp = null;
            this.procura1.ReturnDt = false;
            this.procura1.Selecionado = "Familiastamp,descricao";
            this.procura1.ShowThirdColumn = false;
            this.procura1.Size = new System.Drawing.Size(320, 42);
            this.procura1.SqlComandText = "select Codcpoc,Descricao from Cpoc";
            this.procura1.Tabela = "familia";
            this.procura1.TabIndex = 68;
            this.procura1.TbCkUpdate = false;
            this.procura1.TbClear = false;
            this.procura1.TbUpDate = null;
            this.procura1.Text2 = null;
            this.procura1.Text3 = null;
            this.procura1.Text4 = null;
            this.procura1.Text5 = null;
            this.procura1.Text6 = null;
            this.procura1.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.procura1.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.procura1.Titulo = "Procurar";
            this.procura1.TmpFound = null;
            this.procura1.UpdateTextBox = null;
            this.procura1.Value = "Cpoc";
            this.procura1.Value2 = "";
            this.procura1.Value3 = null;
            this.procura1.Value4 = null;
            this.procura1.Value5 = null;
            this.procura1.Value6 = null;
            // 
            // FrmFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(705, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmFamilia";
            this.Text = "Form Classe";
            this.Load += new System.EventHandler(this.FrmFamilia_Load);
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
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUI1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.TbDefault tbDescricao;
        private UC.TbDefault tbCodigo;
        private UC.ImgGroup imgGroup1;
        private UC.CbDefault cbDefault1;
        private UC.TbDefault tbDefault3;
        private UC.BarraText barraText1;
        private System.Windows.Forms.Panel panel6;
        private Generic.GridUi gridUI1;
        private UC.GridPanel2 gridPanel21;
        private UC.Procura procura1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pos;
        private Generic.TextAndImageColumn btnProc;
        private System.Windows.Forms.DataGridViewImageColumn Imagem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
