namespace DMZ.UI.UI
{
    partial class FrmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.barraText3 = new DMZ.UI.UC.BarraText();
            this.barraText2 = new DMZ.UI.UC.BarraText();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.gridUI1 = new DMZ.UI.Generic.GridUi();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            this.factlstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.btnClosePanelMenu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbTeste = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbCaixa = new System.Windows.Forms.TextBox();
            this.tbPosto = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.posButtomGroup1 = new DMZ.UI.UC.PosButtomGroup();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUI1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.panel4.Controls.Add(this.lblInfo);
            this.panel4.Controls.Add(this.btnClosePanelMenu);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Size = new System.Drawing.Size(1110, 46);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClosePanelMenu, 0);
            this.panel4.Controls.SetChildIndex(this.lblInfo, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMZ.UI.Properties.Resources.Shopping_Cart_96px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(1077, 7);
            this.btnClose.Size = new System.Drawing.Size(21, 25);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 17);
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.Text = "POS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(105, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 36);
            this.panel1.TabIndex = 25;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblInfo.Location = new System.Drawing.Point(117, 21);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(74, 19);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "Software";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.panelMenu);
            this.panel3.Controls.Add(this.barraText1);
            this.panel3.Controls.Add(this.gridUI1);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(2, 120);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 441);
            this.panel3.TabIndex = 26;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.Controls.Add(this.barraText3);
            this.panelMenu.Controls.Add(this.barraText2);
            this.panelMenu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(381, 197);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(254, 249);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Visible = false;
            // 
            // barraText3
            // 
            this.barraText3.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText3.Label1ForeColor = System.Drawing.Color.White;
            this.barraText3.Label1Text = "G - Abrir gaveta";
            this.barraText3.Location = new System.Drawing.Point(9, 58);
            this.barraText3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barraText3.Name = "barraText3";
            this.barraText3.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.barraText3.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText3.PictureBox1Image")));
            this.barraText3.Size = new System.Drawing.Size(239, 37);
            this.barraText3.TabIndex = 1;
            // 
            // barraText2
            // 
            this.barraText2.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText2.Label1ForeColor = System.Drawing.Color.White;
            this.barraText2.Label1Text = "F1 - Novo Registo";
            this.barraText2.Location = new System.Drawing.Point(9, 20);
            this.barraText2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barraText2.Name = "barraText2";
            this.barraText2.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.barraText2.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText2.PictureBox1Image")));
            this.barraText2.Size = new System.Drawing.Size(239, 37);
            this.barraText2.TabIndex = 0;
            // 
            // barraText1
            // 
            this.barraText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.White;
            this.barraText1.Label1Text = "Lista de Produtos ";
            this.barraText1.Location = new System.Drawing.Point(-2, -5);
            this.barraText1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.DarkGoldenrod;
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(853, 30);
            this.barraText1.TabIndex = 1;
            // 
            // gridUI1
            // 
            this.gridUI1.AddButtons = true;
            this.gridUI1.AllowUserToAddRows = false;
            this.gridUI1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUI1.AutoIncrimento = false;
            this.gridUI1.BackgroundColor = System.Drawing.Color.White;
            this.gridUI1.CampoCodigo = null;
            this.gridUI1.Codigo = null;
            this.gridUI1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUI1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUI1.ColumnHeadersHeight = 30;
            this.gridUI1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUI1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referencia,
            this.Descricao,
            this.Quant,
            this.preco,
            this.SubTotal,
            this.del,
            this.factlstamp});
            this.gridUI1.Condicao = null;
            this.gridUI1.CorPreto = true;
            this.gridUI1.CurrentColumnName = null;
            this.gridUI1.DefacolumnName = null;
            this.gridUI1.DtDS = null;
            this.gridUI1.EnableHeadersVisualStyles = false;
            this.gridUI1.GenerateColumns = false;
            this.gridUI1.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUI1.GridFilha = true;
            this.gridUI1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUI1.HeadersHeight = 30;
            this.gridUI1.HeadersVisible = false;
            this.gridUI1.Location = new System.Drawing.Point(0, 25);
            this.gridUI1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridUI1.Name = "gridUI1";
           // this.gridUI1.OrderByCampos = null;
            this.gridUI1.RowHeadersWidth = 30;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUI1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridUI1.Size = new System.Drawing.Size(851, 414);
            this.gridUI1.StampCabecalho = "factstamp";
            this.gridUI1.StampLocal = "factlstamp";
            this.gridUI1.TabelaSql = "factl";
            this.gridUI1.TabIndex = 0;
            this.gridUI1.TbCodigo = null;
            this.gridUI1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUI1_CellClick);
            this.gridUI1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUI1_CellContentClick);
            this.gridUI1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUI1_CellValidated);
            this.gridUI1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUI1_CellValueChanged);
            // 
            // referencia
            // 
            this.referencia.DataPropertyName = "ref";
            this.referencia.HeaderText = "Referência";
            this.referencia.Name = "referencia";
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Quant
            // 
            this.Quant.DataPropertyName = "quant";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Quant.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quant.HeaderText = "Quant";
            this.Quant.Name = "Quant";
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.preco.DefaultCellStyle = dataGridViewCellStyle3;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "Subtotall";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubTotal.HeaderText = "Sub Total ";
            this.SubTotal.Name = "SubTotal";
            // 
            // del
            // 
            this.del.HeaderText = ".....";
            this.del.Image = global::DMZ.UI.Properties.Resources.Trash_25Black;
            this.del.Name = "del";
            this.del.Width = 30;
            // 
            // factlstamp
            // 
            this.factlstamp.DataPropertyName = "factlstamp";
            this.factlstamp.HeaderText = "factlstamp";
            this.factlstamp.Name = "factlstamp";
            this.factlstamp.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(859, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 59);
            this.panel2.TabIndex = 27;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTotal.Location = new System.Drawing.Point(3, 13);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(240, 34);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClosePanelMenu
            // 
            this.btnClosePanelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btnClosePanelMenu.FlatAppearance.BorderSize = 0;
            this.btnClosePanelMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClosePanelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePanelMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePanelMenu.ForeColor = System.Drawing.Color.White;
            this.btnClosePanelMenu.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.btnClosePanelMenu.Location = new System.Drawing.Point(1052, 7);
            this.btnClosePanelMenu.Name = "btnClosePanelMenu";
            this.btnClosePanelMenu.Size = new System.Drawing.Size(24, 24);
            this.btnClosePanelMenu.TabIndex = 34;
            this.btnClosePanelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePanelMenu.UseVisualStyleBackColor = false;
            this.btnClosePanelMenu.Click += new System.EventHandler(this.btnClosePanelMenu_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.btnPagar);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(2, 561);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1110, 36);
            this.panel5.TabIndex = 28;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::DMZ.UI.Properties.Resources.FindCliente_25px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(1052, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 29);
            this.button5.TabIndex = 53;
            this.button5.Text = "F9";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dmzToolTip1.SetToolTip(this.button5, "Fechar o Sistema");
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::DMZ.UI.Properties.Resources.Settings_25px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(690, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 29);
            this.button4.TabIndex = 52;
            this.button4.Text = "F3";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dmzToolTip1.SetToolTip(this.button4, "Funções POS");
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::DMZ.UI.Properties.Resources.Caixa_25px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(747, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 29);
            this.button3.TabIndex = 51;
            this.button3.Text = "F4";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dmzToolTip1.SetToolTip(this.button3, "Caixa Diária");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::DMZ.UI.Properties.Resources.Gabinet_25px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(120, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 29);
            this.button2.TabIndex = 50;
            this.button2.Text = "F9";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dmzToolTip1.SetToolTip(this.button2, "Fechar o Sistema");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Image = global::DMZ.UI.Properties.Resources.Transaction_25px;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.Location = new System.Drawing.Point(64, 5);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(55, 29);
            this.btnPagar.TabIndex = 49;
            this.btnPagar.Text = "F2";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dmzToolTip1.SetToolTip(this.btnPagar, "Pagamento");
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::DMZ.UI.Properties.Resources.Create_25px;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 29);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "F1";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dmzToolTip1.SetToolTip(this.btnAdd, "Nova Venda ");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtSubTotal);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtPreco);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtQuant);
            this.panel6.Controls.Add(this.txtDescricao);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(859, 104);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 348);
            this.panel6.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.txtSubTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtSubTotal.Location = new System.Drawing.Point(22, 188);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(214, 30);
            this.txtSubTotal.TabIndex = 7;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.txtPreco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtPreco.Location = new System.Drawing.Point(22, 137);
            this.txtPreco.Multiline = true;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(214, 30);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // txtQuant
            // 
            this.txtQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.txtQuant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtQuant.Location = new System.Drawing.Point(22, 87);
            this.txtQuant.Multiline = true;
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(214, 30);
            this.txtQuant.TabIndex = 2;
            this.txtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtDescricao.Location = new System.Drawing.Point(22, 38);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(214, 23);
            this.txtDescricao.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(50, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel7.Controls.Add(this.btnPagamento);
            this.panel7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(859, 458);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(253, 101);
            this.panel7.TabIndex = 29;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPagamento.FlatAppearance.BorderSize = 0;
            this.btnPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.Color.White;
            this.btnPagamento.Image = global::DMZ.UI.Properties.Resources.Money_Bag_25px;
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagamento.Location = new System.Drawing.Point(64, 33);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(132, 41);
            this.btnPagamento.TabIndex = 54;
            this.btnPagamento.Text = "Processar (F10)";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Controls.Add(this.posButtomGroup1);
            this.panel9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(-1, 51);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(854, 65);
            this.panel9.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.tbTeste);
            this.panel8.Controls.Add(this.tbNumero);
            this.panel8.Controls.Add(this.tbCaixa);
            this.panel8.Controls.Add(this.tbPosto);
            this.panel8.Controls.Add(this.tbCliente);
            this.panel8.Location = new System.Drawing.Point(284, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(570, 59);
            this.panel8.TabIndex = 1;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // tbTeste
            // 
            this.tbTeste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTeste.BackColor = System.Drawing.SystemColors.Control;
            this.tbTeste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTeste.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbTeste.Location = new System.Drawing.Point(267, 34);
            this.tbTeste.Multiline = true;
            this.tbTeste.Name = "tbTeste";
            this.tbTeste.Size = new System.Drawing.Size(103, 20);
            this.tbTeste.TabIndex = 15;
            this.tbTeste.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbNumero
            // 
            this.tbNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumero.BackColor = System.Drawing.SystemColors.Control;
            this.tbNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbNumero.Location = new System.Drawing.Point(397, 29);
            this.tbNumero.Multiline = true;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(168, 25);
            this.tbNumero.TabIndex = 12;
            this.tbNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCaixa
            // 
            this.tbCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCaixa.BackColor = System.Drawing.SystemColors.Control;
            this.tbCaixa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCaixa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbCaixa.Location = new System.Drawing.Point(283, 3);
            this.tbCaixa.Multiline = true;
            this.tbCaixa.Name = "tbCaixa";
            this.tbCaixa.Size = new System.Drawing.Size(282, 20);
            this.tbCaixa.TabIndex = 11;
            this.tbCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPosto
            // 
            this.tbPosto.BackColor = System.Drawing.SystemColors.Control;
            this.tbPosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPosto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbPosto.Location = new System.Drawing.Point(3, 33);
            this.tbPosto.Multiline = true;
            this.tbPosto.Name = "tbPosto";
            this.tbPosto.Size = new System.Drawing.Size(211, 20);
            this.tbPosto.TabIndex = 10;
            // 
            // tbCliente
            // 
            this.tbCliente.BackColor = System.Drawing.SystemColors.Control;
            this.tbCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbCliente.Location = new System.Drawing.Point(3, 4);
            this.tbCliente.Multiline = true;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(282, 20);
            this.tbCliente.TabIndex = 9;
            // 
            // posButtomGroup1
            // 
            this.posButtomGroup1.Codigo = false;
            this.posButtomGroup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posButtomGroup1.Location = new System.Drawing.Point(-1, 3);
            this.posButtomGroup1.Name = "posButtomGroup1";
            this.posButtomGroup1.Size = new System.Drawing.Size(279, 58);
            this.posButtomGroup1.TabIndex = 0;
            this.posButtomGroup1.RefreshControls += new DMZ.UI.UC.PosButtomGroup.Refrescar(this.posButtomGroup1_RefreshControls);
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Software";
            // 
            // FrmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1114, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPOS_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.panel9, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUI1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private UC.BarraText barraText1;
        private Generic.GridUi gridUI1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Button btnClosePanelMenu;
        private System.Windows.Forms.Panel panelMenu;
        private UC.BarraText barraText3;
        private UC.BarraText barraText2;
        private UC.PosButtomGroup posButtomGroup1;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnPagar;
        private Generic.DMZToolTip dmzToolTip1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.TextBox tbPosto;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbCaixa;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbTeste;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewImageColumn del;
        private System.Windows.Forms.DataGridViewTextBoxColumn factlstamp;
        public System.Windows.Forms.Button btnPagamento;
    }
}
