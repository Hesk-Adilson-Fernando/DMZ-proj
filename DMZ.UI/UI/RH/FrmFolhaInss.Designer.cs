
namespace DMZ.UI.UI.RH
{
    partial class FrmFolhaInss
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFicheiro = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAddprocess = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Mes = new DMZ.UI.UC.DmzProcura();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.gridProcessdetails = new DMZ.UI.Generic.GridUi();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasPrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAbonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incapacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obsinss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcessdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Size = new System.Drawing.Size(828, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(796, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(314, 17);
            this.label1.Text = "Folha de Remunerações para Segurança Social";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFicheiro);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.btnAddprocess);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 40);
            this.panel1.TabIndex = 26;
            // 
            // btnFicheiro
            // 
            this.btnFicheiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFicheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnFicheiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFicheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFicheiro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFicheiro.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFicheiro.Image = global::DMZ.UI.Properties.Resources.certification_28px;
            this.btnFicheiro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFicheiro.Location = new System.Drawing.Point(499, 2);
            this.btnFicheiro.Name = "btnFicheiro";
            this.btnFicheiro.Size = new System.Drawing.Size(102, 31);
            this.btnFicheiro.TabIndex = 84;
            this.btnFicheiro.Text = "Ficheiro";
            this.btnFicheiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFicheiro.UseVisualStyleBackColor = false;
            this.btnFicheiro.Click += new System.EventHandler(this.btnFicheiro_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.print_281px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(607, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 31);
            this.btnPrint.TabIndex = 82;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.numericUpDown1.Location = new System.Drawing.Point(4, 7);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 26);
            this.numericUpDown1.TabIndex = 68;
            // 
            // btnAddprocess
            // 
            this.btnAddprocess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddprocess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnAddprocess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddprocess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddprocess.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddprocess.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddprocess.Image = global::DMZ.UI.Properties.Resources.process_32px;
            this.btnAddprocess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddprocess.Location = new System.Drawing.Point(712, 2);
            this.btnAddprocess.Name = "btnAddprocess";
            this.btnAddprocess.Size = new System.Drawing.Size(102, 31);
            this.btnAddprocess.TabIndex = 67;
            this.btnAddprocess.Text = "Processar";
            this.btnAddprocess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dmzToolTip1.SetToolTip(this.btnAddprocess, "Processar");
            this.btnAddprocess.UseVisualStyleBackColor = false;
            this.btnAddprocess.Click += new System.EventHandler(this.btnAddprocess_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.gridProcessdetails);
            this.panel2.Location = new System.Drawing.Point(3, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 468);
            this.panel2.TabIndex = 27;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 74);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.Mes);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbNumero);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 48);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais ";
            // 
            // Mes
            // 
            this.Mes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mes.BtnEnabled = false;
            this.Mes.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Mes.Button1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Mes.IsLocaDs = false;
            this.Mes.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mes.Label1Text = "Mês ";
            this.Mes.Location = new System.Drawing.Point(-1, 2);
            this.Mes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mes.Name = "Mes";
            this.Mes.Pp = null;
            this.Mes.Size = new System.Drawing.Size(728, 38);
            this.Mes.SqlComandText = "select Codigo,Descricao from Meses order by codigo";
            this.Mes.TabIndex = 84;
            this.Mes.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mes.Tb1Multiline = true;
            this.Mes.Text2 = null;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(732, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 82;
            this.label6.Text = "Número";
            // 
            // tbNumero
            // 
            this.tbNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbNumero.Location = new System.Drawing.Point(733, 19);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(67, 21);
            this.tbNumero.TabIndex = 81;
            // 
            // gridProcessdetails
            // 
            this.gridProcessdetails.AddButtons = false;
            this.gridProcessdetails.AllowUserToAddRows = false;
            this.gridProcessdetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProcessdetails.AutoIncrimento = false;
            this.gridProcessdetails.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridProcessdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProcessdetails.CampoCodigo = null;
            this.gridProcessdetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridProcessdetails.Codigo = null;
            this.gridProcessdetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProcessdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProcessdetails.ColumnHeadersHeight = 40;
            this.gridProcessdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProcessdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.SegSocial,
            this.nome,
            this.data,
            this.DiasPrc,
            this.BaseVencimento,
            this.comissao,
            this.TotalAbonus,
            this.prof,
            this.Incapacidade,
            this.Obsinss});
            this.gridProcessdetails.Condicao = null;
            this.gridProcessdetails.CorPreto = true;
            this.gridProcessdetails.CurrentColumnName = null;
            this.gridProcessdetails.DefacolumnName = null;
            this.gridProcessdetails.DellGridRow = null;
            this.gridProcessdetails.DtDS = null;
            this.gridProcessdetails.EnableHeadersVisualStyles = false;
            this.gridProcessdetails.GenerateColumns = false;
            this.gridProcessdetails.GridColor = System.Drawing.Color.SteelBlue;
            this.gridProcessdetails.GridFilha = true;
            this.gridProcessdetails.GridFilhaSecundaria = false;
            this.gridProcessdetails.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProcessdetails.HeadersHeight = 30;
            this.gridProcessdetails.HeadersVisible = false;
            this.gridProcessdetails.Location = new System.Drawing.Point(-5, 80);
            this.gridProcessdetails.Name = "gridProcessdetails";
            this.gridProcessdetails.OrderbyCampos = "";
            this.gridProcessdetails.Origem = null;
            this.gridProcessdetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridProcessdetails.RowHeadersVisible = false;
            this.gridProcessdetails.RowHeadersWidth = 30;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.gridProcessdetails.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridProcessdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProcessdetails.Size = new System.Drawing.Size(818, 383);
            this.gridProcessdetails.StampCabecalho = "Ststamp";
            this.gridProcessdetails.StampLocal = "StPrecostamp";
            this.gridProcessdetails.TabelaSql = "StPrecos";
            this.gridProcessdetails.TabIndex = 29;
            this.gridProcessdetails.TbCodigo = null;
            // 
            // no
            // 
            this.no.DataPropertyName = "numero";
            this.no.HeaderText = "Ordem";
            this.no.Name = "no";
            this.no.Width = 80;
            // 
            // SegSocial
            // 
            this.SegSocial.DataPropertyName = "SegSocial";
            this.SegSocial.HeaderText = "Nº Benefeciário";
            this.SegSocial.Name = "SegSocial";
            this.SegSocial.Width = 110;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 250;
            this.nome.Name = "nome";
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.HeaderText = "Data Rem.";
            this.data.Name = "data";
            // 
            // DiasPrc
            // 
            this.DiasPrc.DataPropertyName = "DiasPrc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.DiasPrc.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiasPrc.HeaderText = "Dias";
            this.DiasPrc.Name = "DiasPrc";
            this.DiasPrc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DiasPrc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DiasPrc.Width = 50;
            // 
            // BaseVencimento
            // 
            this.BaseVencimento.DataPropertyName = "BaseVencimento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.BaseVencimento.DefaultCellStyle = dataGridViewCellStyle4;
            this.BaseVencimento.HeaderText = "Base Vencimento";
            this.BaseVencimento.Name = "BaseVencimento";
            this.BaseVencimento.Width = 130;
            // 
            // comissao
            // 
            this.comissao.DataPropertyName = "comissao";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.comissao.DefaultCellStyle = dataGridViewCellStyle5;
            this.comissao.HeaderText = "Comissões e Bonus Indem.";
            this.comissao.Name = "comissao";
            this.comissao.Width = 120;
            // 
            // TotalAbonus
            // 
            this.TotalAbonus.DataPropertyName = "TotalAbonus";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.TotalAbonus.DefaultCellStyle = dataGridViewCellStyle6;
            this.TotalAbonus.HeaderText = "Sub. Férias";
            this.TotalAbonus.Name = "TotalAbonus";
            // 
            // prof
            // 
            this.prof.DataPropertyName = "prof";
            this.prof.HeaderText = "Grupo de Escala";
            this.prof.Name = "prof";
            // 
            // Incapacidade
            // 
            this.Incapacidade.DataPropertyName = "Incapacidade";
            this.Incapacidade.HeaderText = "Incapacidade ou Acidente do Trabalho";
            this.Incapacidade.Name = "Incapacidade";
            this.Incapacidade.Width = 150;
            // 
            // Obsinss
            // 
            this.Obsinss.DataPropertyName = "Obsinss";
            this.Obsinss.HeaderText = "Observação";
            this.Obsinss.Name = "Obsinss";
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ SOFTWARE 2021";
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.Image = global::DMZ.UI.Properties.Resources.Maximize_Window_25px;
            this.btnMaxMin.Location = new System.Drawing.Point(771, 2);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 88;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // FrmFolhaInss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(829, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFolhaInss";
            this.Load += new System.EventHandler(this.FrmFolhaInss_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcessdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnFicheiro;
        public System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Button btnAddprocess;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.DmzProcura Mes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumero;
        private Generic.GridUi gridProcessdetails;
        private Generic.DMZToolTip dmzToolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasPrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAbonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn Incapacidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obsinss;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Button btnMaxMin;
    }
}
