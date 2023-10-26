using DMZ.UI.UC;

namespace DMZ.UI.UI
{
    partial class FrmRe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.dmzGridButtons1 = new DMZ.UI.UC.DmzGridButtons();
            this.gridUIFt1 = new DMZ.UI.Generic.GridUIFt();
            this.Origem = new System.Windows.Forms.DataGridViewImageColumn();
            this.ref1 = new DMZ.UI.Generic.TextAndImageColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabIVA = new DMZ.UI.Generic.TextAndImageColumn();
            this.txiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ivainc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ValorIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Armazem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codarment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSubTotal = new DMZ.UI.UC.TbDefault();
            this.tbDesconto = new DMZ.UI.UC.TbDefault();
            this.tbTotalIva = new DMZ.UI.UC.TbDefault();
            this.tbTotal = new DMZ.UI.UC.TbDefault();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbDefault1 = new DMZ.UI.UC.TbDefault();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtDi = new DMZ.UI.UC.DtDefault();
            this.dtVencimento = new DMZ.UI.UC.DtDefault();
            this.tbEntidade = new DMZ.UI.UC.Procura();
            this.tbCcusto = new DMZ.UI.UC.Procura();
            this.tbNumdoc = new DMZ.UI.UC.TbDefault();
            this.ucMoeda = new DMZ.UI.UC.Procura();
            this.btnTdi = new System.Windows.Forms.Button();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.btnPrint = new System.Windows.Forms.Button();
            this.DeleteRow = new DMZ.UI.UC.DMZContextMenuStrip();
            this.btnMenuDelLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMessageShow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUIFt1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DeleteRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.btnPrint);
            this.panelTitulo.Controls.Add(this.btnTdi);
            this.panelTitulo.Size = new System.Drawing.Size(845, 30);
            this.panelTitulo.Controls.SetChildIndex(this.btnRefresh, 0);
            this.panelTitulo.Controls.SetChildIndex(this.label1, 0);
            this.panelTitulo.Controls.SetChildIndex(this.panel5, 0);
            this.panelTitulo.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panelTitulo.Controls.SetChildIndex(this.panelMessageShow, 0);
            this.panelTitulo.Controls.SetChildIndex(this.btnTdi, 0);
            this.panelTitulo.Controls.SetChildIndex(this.btnPrint, 0);
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
            this.panel5.Location = new System.Drawing.Point(760, 2);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(801, 36);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(801, 387);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-26, 1);
            // 
            // panelMessageShow
            // 
            this.panelMessageShow.Location = new System.Drawing.Point(346, 3);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefresh.Location = new System.Drawing.Point(705, 5);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageInicio);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 360);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.Controls.Add(this.dmzGridButtons1);
            this.tabPageInicio.Controls.Add(this.gridUIFt1);
            this.tabPageInicio.Controls.Add(this.panel9);
            this.tabPageInicio.Controls.Add(this.panel8);
            this.tabPageInicio.Controls.Add(this.button3);
            this.tabPageInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageInicio.Location = new System.Drawing.Point(4, 24);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInicio.Size = new System.Drawing.Size(781, 332);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "Dados Gerais ";
            this.tabPageInicio.UseVisualStyleBackColor = true;
            // 
            // dmzGridButtons1
            // 
            this.dmzGridButtons1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzGridButtons1.BtnDellBackColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzGridButtons1.BtnDellImage = ((System.Drawing.Image)(resources.GetObject("dmzGridButtons1.BtnDellImage")));
            this.dmzGridButtons1.BtnNovoBackColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzGridButtons1.BtnNovoImage = ((System.Drawing.Image)(resources.GetObject("dmzGridButtons1.BtnNovoImage")));
            this.dmzGridButtons1.Gridnome = "gridUIFt1";
            this.dmzGridButtons1.Location = new System.Drawing.Point(3, 6);
            this.dmzGridButtons1.Name = "dmzGridButtons1";
            this.dmzGridButtons1.PanelBackColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzGridButtons1.Size = new System.Drawing.Size(769, 25);
            this.dmzGridButtons1.TabIndex = 84;
            // 
            // gridUIFt1
            // 
            this.gridUIFt1.AddButtons = true;
            this.gridUIFt1.AllowUserToAddRows = false;
            this.gridUIFt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUIFt1.BackgroundColor = System.Drawing.Color.White;
            this.gridUIFt1.CampoCodigo = null;
            this.gridUIFt1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUIFt1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUIFt1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUIFt1.ColumnHeadersHeight = 35;
            this.gridUIFt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUIFt1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Origem,
            this.ref1,
            this.Descricao,
            this.Quant,
            this.Preco,
            this.Subtotal,
            this.Percdesc,
            this.Desconto,
            this.TabIVA,
            this.txiva,
            this.Ivainc,
            this.ValorIVA,
            this.Total,
            this.Unidade,
            this.Armazem,
            this.arm,
            this.Codarment,
            this.Ordem});
            this.gridUIFt1.ColunasCriadas = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUIFt1.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridUIFt1.DsDt = null;
            this.gridUIFt1.EnableHeadersVisualStyles = false;
            this.gridUIFt1.GenerateColumns = false;
            this.gridUIFt1.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUIFt1.GridFilha = true;
            this.gridUIFt1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUIFt1.Location = new System.Drawing.Point(3, 28);
            this.gridUIFt1.Name = "gridUIFt1";
            this.gridUIFt1.NotExecuteEndEditEvent = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUIFt1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridUIFt1.RowHeadersVisible = false;
            this.gridUIFt1.RowHeadersWidth = 30;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUIFt1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridUIFt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUIFt1.Size = new System.Drawing.Size(769, 218);
            this.gridUIFt1.StampCabecalho = "distamp";
            this.gridUIFt1.StampLocal = "dilstamp";
            this.gridUIFt1.TabelaSql = "dil";
            this.gridUIFt1.TabIndex = 0;
            this.gridUIFt1.TbCodigo = null;
            this.gridUIFt1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUIFt1_CellContentClick);
            this.gridUIFt1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUIFt1_CellEndEdit);
            this.gridUIFt1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUIFt1_CellEnter);
            this.gridUIFt1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridUIFt1_CellMouseClick);
            this.gridUIFt1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUIFt1_CellValidated);
            this.gridUIFt1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUIFt1_CellValueChanged);
            this.gridUIFt1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridUIFt1_EditingControlShowing);
            this.gridUIFt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridUIFt1_KeyDown);
            this.gridUIFt1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridUIFt1_MouseDown);
            // 
            // Origem
            // 
            this.Origem.HeaderText = "...";
            this.Origem.Image = global::DMZ.UI.Properties.Resources.Right_28px;
            this.Origem.Name = "Origem";
            this.Origem.Width = 30;
            // 
            // ref1
            // 
            this.ref1.DataPropertyName = "ref";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.ref1.DefaultCellStyle = dataGridViewCellStyle2;
            this.ref1.HeaderText = "Referência ";
            this.ref1.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.ref1.Name = "ref1";
            this.ref1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 250;
            this.Descricao.Name = "Descricao";
            // 
            // Quant
            // 
            this.Quant.DataPropertyName = "quant";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Quant.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quant.HeaderText = "Quant";
            this.Quant.Name = "Quant";
            this.Quant.Width = 70;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "preco";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle4;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "subtotall";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.Subtotal.HeaderText = "Sub Total";
            this.Subtotal.Name = "Subtotal";
            // 
            // Percdesc
            // 
            this.Percdesc.DataPropertyName = "perdesc";
            this.Percdesc.HeaderText = "%Desc";
            this.Percdesc.Name = "Percdesc";
            this.Percdesc.Visible = false;
            this.Percdesc.Width = 50;
            // 
            // Desconto
            // 
            this.Desconto.DataPropertyName = "descontol";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Desconto.DefaultCellStyle = dataGridViewCellStyle6;
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            this.Desconto.Visible = false;
            // 
            // TabIVA
            // 
            this.TabIVA.DataPropertyName = "tabiva";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.TabIVA.DefaultCellStyle = dataGridViewCellStyle7;
            this.TabIVA.HeaderText = "Tab. IVA";
            this.TabIVA.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.TabIVA.Name = "TabIVA";
            this.TabIVA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TabIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TabIVA.Width = 70;
            // 
            // txiva
            // 
            this.txiva.DataPropertyName = "txiva";
            this.txiva.HeaderText = "IVA";
            this.txiva.Name = "txiva";
            // 
            // Ivainc
            // 
            this.Ivainc.DataPropertyName = "ivainc";
            this.Ivainc.HeaderText = "Ivainc";
            this.Ivainc.Name = "Ivainc";
            this.Ivainc.Width = 50;
            // 
            // ValorIVA
            // 
            this.ValorIVA.DataPropertyName = "valival";
            this.ValorIVA.HeaderText = "Valor IVA";
            this.ValorIVA.Name = "ValorIVA";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "totall";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Unidade
            // 
            this.Unidade.DataPropertyName = "unidade";
            this.Unidade.HeaderText = "Unidade";
            this.Unidade.Name = "Unidade";
            // 
            // Armazem
            // 
            this.Armazem.DataPropertyName = "armazem";
            this.Armazem.HeaderText = "Cod. Arm";
            this.Armazem.Name = "Armazem";
            this.Armazem.Visible = false;
            this.Armazem.Width = 70;
            // 
            // arm
            // 
            this.arm.DataPropertyName = "Descarm";
            this.arm.HeaderText = "Armazem";
            this.arm.Name = "arm";
            this.arm.Width = 120;
            // 
            // Codarment
            // 
            this.Codarment.DataPropertyName = "Armazem2";
            this.Codarment.HeaderText = "Armazem Entrada";
            this.Codarment.Name = "Codarment";
            this.Codarment.Visible = false;
            // 
            // Ordem
            // 
            this.Ordem.DataPropertyName = "ordem";
            this.Ordem.HeaderText = "Ordem";
            this.Ordem.Name = "Ordem";
            this.Ordem.Visible = false;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.tbSubTotal);
            this.panel9.Controls.Add(this.tbDesconto);
            this.panel9.Controls.Add(this.tbTotalIva);
            this.panel9.Controls.Add(this.tbTotal);
            this.panel9.Location = new System.Drawing.Point(0, 252);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(774, 77);
            this.panel9.TabIndex = 44;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel7.Location = new System.Drawing.Point(498, 13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(25, 53);
            this.panel7.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel4.Location = new System.Drawing.Point(747, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 53);
            this.panel4.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(561, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(537, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total IVA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(284, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Desconto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(290, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "SubTotal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubTotal.AutoComplete = false;
            this.tbSubTotal.AutoIncrimento = false;
            this.tbSubTotal.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbSubTotal.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubTotal.Condicao = "";
            this.tbSubTotal.InPutMask = true;
            this.tbSubTotal.IsEmail = false;
            this.tbSubTotal.IsMaxLength = false;
            this.tbSubTotal.IsNumeric = false;
            this.tbSubTotal.IsReadOnly = true;
            this.tbSubTotal.IsTelephone = false;
            this.tbSubTotal.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSubTotal.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbSubTotal.Label1Text = "SubTotal";
            this.tbSubTotal.Location = new System.Drawing.Point(346, 0);
            this.tbSubTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSubTotal.MaxLength = 0;
            this.tbSubTotal.MultDocumento = false;
            this.tbSubTotal.MultiLinhas = false;
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.Obrigatorio = false;
            this.tbSubTotal.Selected = null;
            this.tbSubTotal.Size = new System.Drawing.Size(174, 39);
            this.tbSubTotal.Tabela = null;
            this.tbSubTotal.TabIndex = 10;
            this.tbSubTotal.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.Tb1IsPassword = false;
            this.tbSubTotal.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSubTotal.Text2 = "";
            this.tbSubTotal.Text3 = "";
            this.tbSubTotal.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubTotal.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbSubTotal.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbSubTotal.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSubTotal.Titulo = null;
            this.tbSubTotal.ToUpperCase = false;
            this.tbSubTotal.Value = "Subtotal";
            this.tbSubTotal.Value2 = null;
            this.tbSubTotal.ValueChange = false;
            // 
            // tbDesconto
            // 
            this.tbDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDesconto.AutoComplete = false;
            this.tbDesconto.AutoIncrimento = false;
            this.tbDesconto.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDesconto.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDesconto.Condicao = "";
            this.tbDesconto.InPutMask = true;
            this.tbDesconto.IsEmail = false;
            this.tbDesconto.IsMaxLength = false;
            this.tbDesconto.IsNumeric = false;
            this.tbDesconto.IsReadOnly = true;
            this.tbDesconto.IsTelephone = false;
            this.tbDesconto.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDesconto.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesconto.label1ForeColor = System.Drawing.Color.White;
            this.tbDesconto.Label1Text = "";
            this.tbDesconto.Location = new System.Drawing.Point(346, 28);
            this.tbDesconto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDesconto.MaxLength = 0;
            this.tbDesconto.MultDocumento = false;
            this.tbDesconto.MultiLinhas = false;
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Obrigatorio = false;
            this.tbDesconto.Selected = null;
            this.tbDesconto.Size = new System.Drawing.Size(174, 39);
            this.tbDesconto.Tabela = null;
            this.tbDesconto.TabIndex = 9;
            this.tbDesconto.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesconto.Tb1IsPassword = false;
            this.tbDesconto.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDesconto.Text2 = "";
            this.tbDesconto.Text3 = "";
            this.tbDesconto.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDesconto.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDesconto.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDesconto.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDesconto.Titulo = null;
            this.tbDesconto.ToUpperCase = false;
            this.tbDesconto.Value = "Desconto";
            this.tbDesconto.Value2 = null;
            this.tbDesconto.ValueChange = false;
            // 
            // tbTotalIva
            // 
            this.tbTotalIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalIva.AutoComplete = false;
            this.tbTotalIva.AutoIncrimento = false;
            this.tbTotalIva.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbTotalIva.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalIva.Condicao = "";
            this.tbTotalIva.InPutMask = true;
            this.tbTotalIva.IsEmail = false;
            this.tbTotalIva.IsMaxLength = false;
            this.tbTotalIva.IsNumeric = false;
            this.tbTotalIva.IsReadOnly = true;
            this.tbTotalIva.IsTelephone = false;
            this.tbTotalIva.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTotalIva.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalIva.label1ForeColor = System.Drawing.Color.White;
            this.tbTotalIva.Label1Text = "";
            this.tbTotalIva.Location = new System.Drawing.Point(596, 0);
            this.tbTotalIva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTotalIva.MaxLength = 0;
            this.tbTotalIva.MultDocumento = false;
            this.tbTotalIva.MultiLinhas = false;
            this.tbTotalIva.Name = "tbTotalIva";
            this.tbTotalIva.Obrigatorio = false;
            this.tbTotalIva.Selected = null;
            this.tbTotalIva.Size = new System.Drawing.Size(174, 39);
            this.tbTotalIva.Tabela = null;
            this.tbTotalIva.TabIndex = 8;
            this.tbTotalIva.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalIva.Tb1IsPassword = false;
            this.tbTotalIva.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTotalIva.Text2 = "";
            this.tbTotalIva.Text3 = "";
            this.tbTotalIva.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalIva.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbTotalIva.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbTotalIva.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTotalIva.Titulo = null;
            this.tbTotalIva.ToUpperCase = false;
            this.tbTotalIva.Value = "Totaliva";
            this.tbTotalIva.Value2 = null;
            this.tbTotalIva.ValueChange = false;
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.AutoComplete = false;
            this.tbTotal.AutoIncrimento = false;
            this.tbTotal.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbTotal.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.Condicao = "";
            this.tbTotal.InPutMask = true;
            this.tbTotal.IsEmail = false;
            this.tbTotal.IsMaxLength = false;
            this.tbTotal.IsNumeric = false;
            this.tbTotal.IsReadOnly = true;
            this.tbTotal.IsTelephone = false;
            this.tbTotal.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTotal.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.label1ForeColor = System.Drawing.Color.White;
            this.tbTotal.Label1Text = "";
            this.tbTotal.Location = new System.Drawing.Point(596, 28);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTotal.MaxLength = 0;
            this.tbTotal.MultDocumento = false;
            this.tbTotal.MultiLinhas = false;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Obrigatorio = false;
            this.tbTotal.Selected = null;
            this.tbTotal.Size = new System.Drawing.Size(174, 39);
            this.tbTotal.Tabela = null;
            this.tbTotal.TabIndex = 7;
            this.tbTotal.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Tb1IsPassword = false;
            this.tbTotal.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTotal.Text2 = "";
            this.tbTotal.Text3 = "";
            this.tbTotal.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbTotal.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbTotal.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTotal.Titulo = null;
            this.tbTotal.ToUpperCase = false;
            this.tbTotal.Value = "Total";
            this.tbTotal.Value2 = null;
            this.tbTotal.ValueChange = false;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel8.Controls.Add(this.tbDefault1);
            this.panel8.Location = new System.Drawing.Point(6, 506);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1348, 47);
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
            this.tbDefault1.Location = new System.Drawing.Point(1130, 5);
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
            this.button3.Location = new System.Drawing.Point(1258, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 28);
            this.button3.TabIndex = 40;
            this.button3.Text = "Apagar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFacturar.Image = global::DMZ.UI.Properties.Resources.Check_23px;
            this.btnFacturar.Location = new System.Drawing.Point(803, 158);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(31, 33);
            this.btnFacturar.TabIndex = 48;
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dmzToolTip1.SetToolTip(this.btnFacturar, "Facturar o documento");
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtDi);
            this.panel2.Controls.Add(this.dtVencimento);
            this.panel2.Controls.Add(this.tbEntidade);
            this.panel2.Controls.Add(this.tbCcusto);
            this.panel2.Controls.Add(this.tbNumdoc);
            this.panel2.Controls.Add(this.ucMoeda);
            this.panel2.Location = new System.Drawing.Point(7, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 86);
            this.panel2.TabIndex = 38;
            // 
            // dtDi
            // 
            this.dtDi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDi.BackColor = System.Drawing.Color.Transparent;
            this.dtDi.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dtDi.Label1Text = "Data de Emissão";
            this.dtDi.Location = new System.Drawing.Point(537, 1);
            this.dtDi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtDi.Name = "dtDi";
            this.dtDi.Size = new System.Drawing.Size(123, 42);
            this.dtDi.TabIndex = 5;
            this.dtDi.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dtDi.Value = "data";
            // 
            // dtVencimento
            // 
            this.dtVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtVencimento.BackColor = System.Drawing.Color.Transparent;
            this.dtVencimento.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dtVencimento.Label1Text = "Validade";
            this.dtVencimento.Location = new System.Drawing.Point(536, 38);
            this.dtVencimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(124, 42);
            this.dtVencimento.TabIndex = 4;
            this.dtVencimento.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dtVencimento.Value = "Dataven";
            // 
            // tbEntidade
            // 
            this.tbEntidade.AutoComplete = false;
            this.tbEntidade.BackColor = System.Drawing.Color.Transparent;
            this.tbEntidade.Campo = null;
            this.tbEntidade.Campo1 = null;
            this.tbEntidade.CampoStatus = false;
            this.tbEntidade.ColunaCodigo = "Código";
            this.tbEntidade.ColunaDescricao = "Descrição";
            this.tbEntidade.Condicao = "";
            this.tbEntidade.DependDescricao = null;
            this.tbEntidade.Dependente = false;
            this.tbEntidade.DependenteNome = null;
            this.tbEntidade.Descname = null;
            this.tbEntidade.ExecMetodo = false;
            this.tbEntidade.FormName = "FrmFnc";
            this.tbEntidade.HideFirstColumn = false;
            this.tbEntidade.InserirNovo = true;
            this.tbEntidade.InvertColuna = false;
            this.tbEntidade.IsLocaDs = false;
            this.tbEntidade.IsRequered = false;
            this.tbEntidade.IsSqlSelect = false;
            this.tbEntidade.Istatus = false;
            this.tbEntidade.Items = null;
            this.tbEntidade.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEntidade.Label1Text = "Entidade";
            this.tbEntidade.Location = new System.Drawing.Point(7, 3);
            this.tbEntidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEntidade.MultDocumento = false;
            this.tbEntidade.Name = "tbEntidade";
            this.tbEntidade.ParentFormName = null;
            this.tbEntidade.Pp = null;
            this.tbEntidade.ReturnDt = false;
            this.tbEntidade.Selecionado = "no,nome";
            this.tbEntidade.ShowThirdColumn = false;
            this.tbEntidade.Size = new System.Drawing.Size(432, 39);
            this.tbEntidade.SqlComandText = null;
            this.tbEntidade.Tabela = "fnc";
            this.tbEntidade.TabIndex = 0;
            this.tbEntidade.TbCkUpdate = false;
            this.tbEntidade.TbClear = false;
            this.tbEntidade.TbUpDate = null;
            this.tbEntidade.Text2 = null;
            this.tbEntidade.Text3 = null;
            this.tbEntidade.Titulo = "Procurar";
            this.tbEntidade.TmpFound = null;
            this.tbEntidade.UpdateTextBox = null;
            this.tbEntidade.Value = "nome";
            this.tbEntidade.Value2 = "no";
            // 
            // tbCcusto
            // 
            this.tbCcusto.AutoComplete = false;
            this.tbCcusto.Campo = null;
            this.tbCcusto.Campo1 = null;
            this.tbCcusto.CampoStatus = false;
            this.tbCcusto.ColunaCodigo = "Código";
            this.tbCcusto.ColunaDescricao = "Descrição";
            this.tbCcusto.Condicao = "";
            this.tbCcusto.DependDescricao = null;
            this.tbCcusto.Dependente = false;
            this.tbCcusto.DependenteNome = null;
            this.tbCcusto.Descname = null;
            this.tbCcusto.ExecMetodo = false;
            this.tbCcusto.FormName = "FrmCCusto";
            this.tbCcusto.HideFirstColumn = false;
            this.tbCcusto.InserirNovo = true;
            this.tbCcusto.InvertColuna = false;
            this.tbCcusto.IsLocaDs = false;
            this.tbCcusto.IsRequered = true;
            this.tbCcusto.IsSqlSelect = false;
            this.tbCcusto.Istatus = false;
            this.tbCcusto.Items = null;
            this.tbCcusto.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCcusto.Label1Text = "Centro de Custo";
            this.tbCcusto.Location = new System.Drawing.Point(6, 40);
            this.tbCcusto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCcusto.MultDocumento = false;
            this.tbCcusto.Name = "tbCcusto";
            this.tbCcusto.ParentFormName = null;
            this.tbCcusto.Pp = null;
            this.tbCcusto.ReturnDt = false;
            this.tbCcusto.Selecionado = "CodCcu,Descricao";
            this.tbCcusto.ShowThirdColumn = false;
            this.tbCcusto.Size = new System.Drawing.Size(220, 39);
            this.tbCcusto.SqlComandText = null;
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
            this.tbCcusto.Value = "Ccusto";
            this.tbCcusto.Value2 = null;
            // 
            // tbNumdoc
            // 
            this.tbNumdoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumdoc.AutoComplete = false;
            this.tbNumdoc.AutoIncrimento = true;
            this.tbNumdoc.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbNumdoc.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumdoc.Condicao = "";
            this.tbNumdoc.InPutMask = false;
            this.tbNumdoc.IsEmail = false;
            this.tbNumdoc.IsMaxLength = false;
            this.tbNumdoc.IsNumeric = false;
            this.tbNumdoc.IsReadOnly = true;
            this.tbNumdoc.IsTelephone = false;
            this.tbNumdoc.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNumdoc.label1Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumdoc.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbNumdoc.Label1Text = "Nº Documento";
            this.tbNumdoc.Location = new System.Drawing.Point(652, 3);
            this.tbNumdoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumdoc.MaxLength = 0;
            this.tbNumdoc.MultDocumento = false;
            this.tbNumdoc.MultiLinhas = true;
            this.tbNumdoc.Name = "tbNumdoc";
            this.tbNumdoc.Obrigatorio = false;
            this.tbNumdoc.Selected = null;
            this.tbNumdoc.Size = new System.Drawing.Size(131, 42);
            this.tbNumdoc.Tabela = null;
            this.tbNumdoc.TabIndex = 3;
            this.tbNumdoc.Tb1Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumdoc.Tb1IsPassword = false;
            this.tbNumdoc.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNumdoc.Text2 = "";
            this.tbNumdoc.Text3 = "";
            this.tbNumdoc.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumdoc.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbNumdoc.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbNumdoc.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNumdoc.Titulo = null;
            this.tbNumdoc.ToUpperCase = false;
            this.tbNumdoc.Value = "Numero";
            this.tbNumdoc.Value2 = null;
            this.tbNumdoc.ValueChange = false;
            // 
            // ucMoeda
            // 
            this.ucMoeda.AutoComplete = false;
            this.ucMoeda.Campo = null;
            this.ucMoeda.Campo1 = null;
            this.ucMoeda.CampoStatus = false;
            this.ucMoeda.ColunaCodigo = "Código";
            this.ucMoeda.ColunaDescricao = "Descrição";
            this.ucMoeda.Condicao = "";
            this.ucMoeda.DependDescricao = null;
            this.ucMoeda.Dependente = false;
            this.ucMoeda.DependenteNome = null;
            this.ucMoeda.Descname = null;
            this.ucMoeda.ExecMetodo = false;
            this.ucMoeda.FormName = "FrmMoedas";
            this.ucMoeda.HideFirstColumn = false;
            this.ucMoeda.InserirNovo = true;
            this.ucMoeda.InvertColuna = true;
            this.ucMoeda.IsLocaDs = false;
            this.ucMoeda.IsRequered = false;
            this.ucMoeda.IsSqlSelect = false;
            this.ucMoeda.Istatus = false;
            this.ucMoeda.Items = null;
            this.ucMoeda.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMoeda.Label1Text = "Moeda";
            this.ucMoeda.Location = new System.Drawing.Point(232, 40);
            this.ucMoeda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMoeda.MultDocumento = false;
            this.ucMoeda.Name = "ucMoeda";
            this.ucMoeda.ParentFormName = null;
            this.ucMoeda.Pp = null;
            this.ucMoeda.ReturnDt = false;
            this.ucMoeda.Selecionado = "moeda,descricao";
            this.ucMoeda.ShowThirdColumn = false;
            this.ucMoeda.Size = new System.Drawing.Size(206, 39);
            this.ucMoeda.SqlComandText = null;
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
            // btnTdi
            // 
            this.btnTdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnTdi.FlatAppearance.BorderSize = 0;
            this.btnTdi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTdi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTdi.ForeColor = System.Drawing.Color.White;
            this.btnTdi.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_251px;
            this.btnTdi.Location = new System.Drawing.Point(0, -6);
            this.btnTdi.Name = "btnTdi";
            this.btnTdi.Size = new System.Drawing.Size(32, 39);
            this.btnTdi.TabIndex = 35;
            this.btnTdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTdi.UseVisualStyleBackColor = false;
            this.btnTdi.Click += new System.EventHandler(this.btnTdi_Click);
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Software";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.Location = new System.Drawing.Point(729, -3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(30, 36);
            this.btnPrint.TabIndex = 81;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dmzToolTip1.SetToolTip(this.btnPrint, "Imprimir Recibos ");
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // DeleteRow
            // 
            this.DeleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.DeleteRow.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.DeleteRow.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.DeleteRow.ForeColor = System.Drawing.Color.White;
            this.DeleteRow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DeleteRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuDelLinha,
            this.toolStripMenuItem2,
            this.btnMenuRefresh});
            this.DeleteRow.Name = "dmzContextMenuStrip2";
            this.DeleteRow.Size = new System.Drawing.Size(137, 82);
            // 
            // btnMenuDelLinha
            // 
            this.btnMenuDelLinha.Image = global::DMZ.UI.Properties.Resources.ApagarLinha;
            this.btnMenuDelLinha.Name = "btnMenuDelLinha";
            this.btnMenuDelLinha.Size = new System.Drawing.Size(136, 26);
            this.btnMenuDelLinha.Text = "Eliminar ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::DMZ.UI.Properties.Resources.Duplicar;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
            this.toolStripMenuItem2.Text = "Duplicar  ";
            // 
            // btnMenuRefresh
            // 
            this.btnMenuRefresh.Image = global::DMZ.UI.Properties.Resources.Refresh;
            this.btnMenuRefresh.Name = "btnMenuRefresh";
            this.btnMenuRefresh.Size = new System.Drawing.Size(136, 26);
            this.btnMenuRefresh.Text = "Refresh";
            // 
            // FrmRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(845, 491);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmRe";
            this.Text = "Form Classe";
            this.Load += new System.EventHandler(this.FrmRE_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panelTitulo, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.btnFacturar, 0);
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
            this.tabPageInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUIFt1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.DeleteRow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInicio;
        private UC.DmzGridButtons dmzGridButtons1;
        private Generic.GridUIFt gridUIFt1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public UC.TbDefault tbSubTotal;
        public UC.TbDefault tbDesconto;
        public UC.TbDefault tbTotalIva;
        public UC.TbDefault tbTotal;
        private System.Windows.Forms.Panel panel8;
        private UC.TbDefault tbDefault1;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private UC.TbDefault tbNumdoc;
        public System.Windows.Forms.Button btnTdi;
        private Generic.DMZToolTip dmzToolTip1;
        public UC.DtDefault dtDi;
        public UC.DtDefault dtVencimento;
        public UC.Procura tbEntidade;
        public UC.Procura tbCcusto;
        public UC.Procura ucMoeda;
        private DMZContextMenuStrip DeleteRow;
        private System.Windows.Forms.ToolStripMenuItem btnMenuDelLinha;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnMenuRefresh;
        public System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewImageColumn Origem;
        private Generic.TextAndImageColumn ref1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private Generic.TextAndImageColumn TabIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn txiva;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ivainc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Armazem;
        private System.Windows.Forms.DataGridViewTextBoxColumn arm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codarment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        public System.Windows.Forms.Button btnPrint;
    }
}
