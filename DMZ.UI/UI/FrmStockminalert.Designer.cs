
namespace DMZ.UI.UI
{
    partial class FrmStockminalert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.Configuracao = new DMZ.UI.UC.DMZContextMenuStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.câmbioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeIVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosGeraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.viturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDaViaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCombustivelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.companhiasDeLeasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companhiasDeSegurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Referenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stockactual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.Configuracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(584, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(552, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.Text = "Alerta de Stock min";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.gridUi1);
            this.panel1.Location = new System.Drawing.Point(2, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 506);
            this.panel1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Image = global::DMZ.UI.Properties.Resources.Print_20px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(510, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 35);
            this.button1.TabIndex = 116;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMenu.Image = global::DMZ.UI.Properties.Resources.Downloading_Updates_25px;
            this.btnMenu.Location = new System.Drawing.Point(545, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 35);
            this.btnMenu.TabIndex = 115;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            this.gridUi1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.Color.White;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referenc,
            this.Descricao,
            this.stocmin,
            this.Stockactual});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.White;
            this.gridUi1.GridFilha = false;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(3, 39);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            this.gridUi1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUi1.Size = new System.Drawing.Size(574, 461);
            this.gridUi1.StampCabecalho = null;
            this.gridUi1.StampLocal = null;
            this.gridUi1.TabelaSql = null;
            this.gridUi1.TabIndex = 0;
            this.gridUi1.TbCodigo = null;
            // 
            // Configuracao
            // 
            this.Configuracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Configuracao.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Configuracao.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Configuracao.ForeColor = System.Drawing.Color.White;
            this.Configuracao.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Configuracao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.câmbioToolStripMenuItem,
            this.tabelaDeIVAToolStripMenuItem,
            this.parametrosGeraisToolStripMenuItem,
            this.toolStripSeparator3,
            this.modulosToolStripMenuItem,
            this.toolStripSeparator12,
            this.bancosToolStripMenuItem,
            this.toolStripSeparator21,
            this.viturasToolStripMenuItem});
            this.Configuracao.Name = "dmzContextMenuStrip1";
            this.Configuracao.Size = new System.Drawing.Size(164, 184);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // câmbioToolStripMenuItem
            // 
            this.câmbioToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Currency_Exchange_32px;
            this.câmbioToolStripMenuItem.Name = "câmbioToolStripMenuItem";
            this.câmbioToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.câmbioToolStripMenuItem.Text = "Câmbio";
            // 
            // tabelaDeIVAToolStripMenuItem
            // 
            this.tabelaDeIVAToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Transaction_List_32px;
            this.tabelaDeIVAToolStripMenuItem.Name = "tabelaDeIVAToolStripMenuItem";
            this.tabelaDeIVAToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.tabelaDeIVAToolStripMenuItem.Text = "Tabela de IVA";
            // 
            // parametrosGeraisToolStripMenuItem
            // 
            this.parametrosGeraisToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Administrative_Tools_32px1;
            this.parametrosGeraisToolStripMenuItem.Name = "parametrosGeraisToolStripMenuItem";
            this.parametrosGeraisToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.parametrosGeraisToolStripMenuItem.Text = "Parametros  ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Accounting_32px;
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.modulosToolStripMenuItem.Text = "Módulos";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(160, 6);
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Building_32px_11;
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            this.bancosToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.bancosToolStripMenuItem.Text = "Bancos";
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(160, 6);
            // 
            // viturasToolStripMenuItem
            // 
            this.viturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corDaViaturaToolStripMenuItem,
            this.tiposDeFiltrosToolStripMenuItem,
            this.tipoDeCombustivelToolStripMenuItem1,
            this.companhiasDeLeasingToolStripMenuItem,
            this.companhiasDeSegurosToolStripMenuItem});
            this.viturasToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Viatura;
            this.viturasToolStripMenuItem.Name = "viturasToolStripMenuItem";
            this.viturasToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.viturasToolStripMenuItem.Text = "Vituras";
            // 
            // corDaViaturaToolStripMenuItem
            // 
            this.corDaViaturaToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Color_Mode_25px;
            this.corDaViaturaToolStripMenuItem.Name = "corDaViaturaToolStripMenuItem";
            this.corDaViaturaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.corDaViaturaToolStripMenuItem.Text = "Cor da viatura ";
            // 
            // tiposDeFiltrosToolStripMenuItem
            // 
            this.tiposDeFiltrosToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Filter_25px;
            this.tiposDeFiltrosToolStripMenuItem.Name = "tiposDeFiltrosToolStripMenuItem";
            this.tiposDeFiltrosToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.tiposDeFiltrosToolStripMenuItem.Text = "Tipos de filtros ";
            // 
            // tipoDeCombustivelToolStripMenuItem1
            // 
            this.tipoDeCombustivelToolStripMenuItem1.Image = global::DMZ.UI.Properties.Resources.Petrol_25px;
            this.tipoDeCombustivelToolStripMenuItem1.Name = "tipoDeCombustivelToolStripMenuItem1";
            this.tipoDeCombustivelToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.tipoDeCombustivelToolStripMenuItem1.Text = "Tipo de combustivel";
            // 
            // companhiasDeLeasingToolStripMenuItem
            // 
            this.companhiasDeLeasingToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Organization_25px;
            this.companhiasDeLeasingToolStripMenuItem.Name = "companhiasDeLeasingToolStripMenuItem";
            this.companhiasDeLeasingToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.companhiasDeLeasingToolStripMenuItem.Text = "Companhias de leasing";
            // 
            // companhiasDeSegurosToolStripMenuItem
            // 
            this.companhiasDeSegurosToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Department_25px;
            this.companhiasDeSegurosToolStripMenuItem.Name = "companhiasDeSegurosToolStripMenuItem";
            this.companhiasDeSegurosToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.companhiasDeSegurosToolStripMenuItem.Text = "Companhias de Seguros ";
            // 
            // Referenc
            // 
            this.Referenc.DataPropertyName = "ref";
            this.Referenc.HeaderText = "Referência";
            this.Referenc.Name = "Referenc";
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // stocmin
            // 
            this.stocmin.DataPropertyName = "StockMin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.stocmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.stocmin.HeaderText = "Stock Min.";
            this.stocmin.Name = "stocmin";
            this.stocmin.Width = 90;
            // 
            // Stockactual
            // 
            this.Stockactual.DataPropertyName = "Stock";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Stockactual.DefaultCellStyle = dataGridViewCellStyle3;
            this.Stockactual.HeaderText = "Stock Actual";
            this.Stockactual.Name = "Stockactual";
            // 
            // FrmStockminalert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 541);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStockminalert";
            this.Text = "FrmStockminalert";
            this.Load += new System.EventHandler(this.FrmStockminalert_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.Configuracao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Generic.GridUi gridUi1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnMenu;
        private UC.DMZContextMenuStrip Configuracao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem câmbioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeIVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosGeraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripMenuItem viturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corDaViaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeFiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCombustivelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem companhiasDeLeasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companhiasDeSegurosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stockactual;
    }
}