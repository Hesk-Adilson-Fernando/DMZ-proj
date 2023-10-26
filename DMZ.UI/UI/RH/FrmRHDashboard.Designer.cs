namespace DMZ.UI.UI.RH
{
    partial class FrmRHDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRHDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dmzPanel1 = new DMZ.UI.UC.DMZDataDisplay();
            this.gridUi3 = new DMZ.UI.Generic.GridUi();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localtrab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmzPanel2 = new DMZ.UI.UC.DMZDataDisplay();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmzPanel3 = new DMZ.UI.UC.DMZDataDisplay();
            this.gridUi2 = new DMZ.UI.Generic.GridUi();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.dmzPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi3)).BeginInit();
            this.dmzPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.dmzPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Size = new System.Drawing.Size(1040, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(1008, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.Text = "DMZ RH Dashboard";
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.Image = global::DMZ.UI.Properties.Resources.Maximize_Window_25px;
            this.btnMaxMin.Location = new System.Drawing.Point(983, 2);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 88;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Beige;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.dmzPanel1);
            this.flowLayoutPanel1.Controls.Add(this.dmzPanel2);
            this.flowLayoutPanel1.Controls.Add(this.dmzPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1025, 531);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // dmzPanel1
            // 
            this.dmzPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzPanel1.BtnCloseImage = ((System.Drawing.Image)(resources.GetObject("dmzPanel1.BtnCloseImage")));
            this.dmzPanel1.BtnPrintImage = ((System.Drawing.Image)(resources.GetObject("dmzPanel1.BtnPrintImage")));
            this.dmzPanel1.BtnRefreshImage = ((System.Drawing.Image)(resources.GetObject("dmzPanel1.BtnRefreshImage")));
            this.dmzPanel1.Controls.Add(this.gridUi3);
            this.dmzPanel1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzPanel1.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dmzPanel1.label1ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzPanel1.Label1Text = "Funcionários com Contratos  ";
            this.dmzPanel1.Location = new System.Drawing.Point(3, 3);
            this.dmzPanel1.Name = "dmzPanel1";
            this.dmzPanel1.Origem = "FSC";
            this.dmzPanel1.PanelHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dmzPanel1.Size = new System.Drawing.Size(335, 276);
            this.dmzPanel1.SQLQuery = null;
            this.dmzPanel1.TabIndex = 9;
            this.dmzPanel1.BtnRefrescar += new DMZ.UI.UC.DMZDataDisplay.Refrescar(this.dmzPanel1_BtnRefrescar);
            // 
            // gridUi3
            // 
            this.gridUi3.AddButtons = false;
            this.gridUi3.AllowUserToAddRows = false;
            this.gridUi3.AllowUserToDeleteRows = false;
            this.gridUi3.AutoIncrimento = false;
            this.gridUi3.BackgroundColor = System.Drawing.Color.White;
            this.gridUi3.CampoCodigo = null;
            this.gridUi3.Codigo = null;
            this.gridUi3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi3.ColumnHeadersHeight = 30;
            this.gridUi3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn12,
            this.localtrab});
            this.gridUi3.Condicao = null;
            this.gridUi3.CorPreto = false;
            this.gridUi3.CurrentColumnName = null;
            this.gridUi3.DefacolumnName = null;
            this.gridUi3.DellGridRow = null;
            this.gridUi3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridUi3.DtDS = null;
            this.gridUi3.EnableHeadersVisualStyles = false;
            this.gridUi3.GenerateColumns = false;
            this.gridUi3.GridColor = System.Drawing.Color.White;
            this.gridUi3.GridFilha = true;
            this.gridUi3.GridFilhaSecundaria = false;
            this.gridUi3.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi3.HeadersHeight = 30;
            this.gridUi3.HeadersVisible = false;
            this.gridUi3.Location = new System.Drawing.Point(0, 32);
            this.gridUi3.Name = "gridUi3";
            this.gridUi3.OrderbyCampos = null;
            this.gridUi3.Origem = null;
            this.gridUi3.RowHeadersVisible = false;
            this.gridUi3.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi3.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi3.Size = new System.Drawing.Size(333, 242);
            this.gridUi3.StampCabecalho = "Pestamp";
            this.gridUi3.StampLocal = "Pefuncstamp";
            this.gridUi3.TabelaSql = "Pefunc";
            this.gridUi3.TabIndex = 6;
            this.gridUi3.TbCodigo = null;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ProvNasc";
            this.dataGridViewTextBoxColumn12.HeaderText = "Província";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // localtrab
            // 
            this.localtrab.DataPropertyName = "ccusto";
            this.localtrab.HeaderText = "Local";
            this.localtrab.Name = "localtrab";
            // 
            // dmzPanel2
            // 
            this.dmzPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzPanel2.BtnCloseImage = ((System.Drawing.Image)(resources.GetObject("dmzPanel2.BtnCloseImage")));
            this.dmzPanel2.BtnPrintImage = ((System.Drawing.Image)(resources.GetObject("dmzPanel2.BtnPrintImage")));
            this.dmzPanel2.BtnRefreshImage = ((System.Drawing.Image)(resources.GetObject("dmzPanel2.BtnRefreshImage")));
            this.dmzPanel2.Controls.Add(this.gridUi1);
            this.dmzPanel2.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzPanel2.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dmzPanel2.label1ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzPanel2.Label1Text = "Funcionários com Contratos Expirados       ";
            this.dmzPanel2.Location = new System.Drawing.Point(344, 3);
            this.dmzPanel2.Name = "dmzPanel2";
            this.dmzPanel2.Origem = "FCE";
            this.dmzPanel2.PanelHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dmzPanel2.Size = new System.Drawing.Size(335, 276);
            this.dmzPanel2.SQLQuery = null;
            this.dmzPanel2.TabIndex = 10;
            this.dmzPanel2.BtnRefrescar += new DMZ.UI.UC.DMZDataDisplay.Refrescar(this.dmzPanel2_BtnRefrescar);
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.Color.White;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dias});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.White;
            this.gridUi1.GridFilha = true;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(0, 32);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridUi1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi1.Size = new System.Drawing.Size(333, 242);
            this.gridUi1.StampCabecalho = "Pestamp";
            this.gridUi1.StampLocal = "Pefuncstamp";
            this.gridUi1.TabelaSql = "Pefunc";
            this.gridUi1.TabIndex = 7;
            this.gridUi1.TbCodigo = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "termino";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "d";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Término";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProvNasc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Província";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dias
            // 
            this.dias.DataPropertyName = "dias";
            this.dias.HeaderText = "Dias";
            this.dias.Name = "dias";
            this.dias.Width = 35;
            // 
            // dmzPanel3
            // 
            this.dmzPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzPanel3.BtnCloseImage = ((System.Drawing.Image)(resources.GetObject("dmzPanel3.BtnCloseImage")));
            this.dmzPanel3.BtnPrintImage = ((System.Drawing.Image)(resources.GetObject("dmzPanel3.BtnPrintImage")));
            this.dmzPanel3.BtnRefreshImage = ((System.Drawing.Image)(resources.GetObject("dmzPanel3.BtnRefreshImage")));
            this.dmzPanel3.Controls.Add(this.gridUi2);
            this.dmzPanel3.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzPanel3.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dmzPanel3.label1ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzPanel3.Label1Text = "Funcionários com Contratos Expirados       ";
            this.dmzPanel3.Location = new System.Drawing.Point(685, 3);
            this.dmzPanel3.Name = "dmzPanel3";
            this.dmzPanel3.Origem = null;
            this.dmzPanel3.PanelHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dmzPanel3.Size = new System.Drawing.Size(335, 276);
            this.dmzPanel3.SQLQuery = null;
            this.dmzPanel3.TabIndex = 11;
            // 
            // gridUi2
            // 
            this.gridUi2.AddButtons = false;
            this.gridUi2.AllowUserToAddRows = false;
            this.gridUi2.AutoIncrimento = false;
            this.gridUi2.BackgroundColor = System.Drawing.Color.White;
            this.gridUi2.CampoCodigo = null;
            this.gridUi2.Codigo = null;
            this.gridUi2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridUi2.ColumnHeadersHeight = 30;
            this.gridUi2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gridUi2.Condicao = null;
            this.gridUi2.CorPreto = false;
            this.gridUi2.CurrentColumnName = null;
            this.gridUi2.DefacolumnName = null;
            this.gridUi2.DellGridRow = null;
            this.gridUi2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridUi2.DtDS = null;
            this.gridUi2.EnableHeadersVisualStyles = false;
            this.gridUi2.GenerateColumns = false;
            this.gridUi2.GridColor = System.Drawing.Color.White;
            this.gridUi2.GridFilha = true;
            this.gridUi2.GridFilhaSecundaria = false;
            this.gridUi2.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi2.HeadersHeight = 30;
            this.gridUi2.HeadersVisible = false;
            this.gridUi2.Location = new System.Drawing.Point(0, 32);
            this.gridUi2.Name = "gridUi2";
            this.gridUi2.OrderbyCampos = null;
            this.gridUi2.Origem = null;
            this.gridUi2.RowHeadersVisible = false;
            this.gridUi2.RowHeadersWidth = 30;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridUi2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi2.Size = new System.Drawing.Size(333, 242);
            this.gridUi2.StampCabecalho = "Pestamp";
            this.gridUi2.StampLocal = "Pefuncstamp";
            this.gridUi2.TabelaSql = "Pefunc";
            this.gridUi2.TabIndex = 7;
            this.gridUi2.TbCodigo = null;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "funcao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "datain";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "d";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn7.HeaderText = "Término";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Província";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 563);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1031, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmRHDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1041, 596);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRHDashboard";
            this.Load += new System.EventHandler(this.FrmRHDashboard_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.dmzPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUi3)).EndInit();
            this.dmzPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.dmzPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUi2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UC.DMZDataDisplay dmzPanel1;
        private UC.DMZDataDisplay dmzPanel2;
        private Generic.GridUi gridUi3;
        private Generic.GridUi gridUi1;
        private UC.DMZDataDisplay dmzPanel3;
        private Generic.GridUi gridUi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn localtrab;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
