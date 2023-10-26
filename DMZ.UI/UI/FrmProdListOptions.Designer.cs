
namespace DMZ.UI.UI
{
    partial class FrmProdListOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdListOptions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Marca = new DMZ.UI.UC.DmzProcura();
            this.Fabricante = new DMZ.UI.UC.DmzProcura();
            this.Subfamilia = new DMZ.UI.UC.DmzProcura();
            this.Familia = new DMZ.UI.UC.DmzProcura();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridPreco = new DMZ.UI.Generic.GridUi();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbTodas = new DMZ.UI.UC.CbDefault();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(441, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(409, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.Text = "Definições da listagem";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Location = new System.Drawing.Point(2, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 472);
            this.panel1.TabIndex = 25;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 399);
            this.tabControl1.TabIndex = 83;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Marca);
            this.tabPage1.Controls.Add(this.Fabricante);
            this.tabPage1.Controls.Add(this.Subfamilia);
            this.tabPage1.Controls.Add(this.Familia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parametrização";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Marca
            // 
            this.Marca.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.Marca.IsLocaDs = false;
            this.Marca.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Marca.Label1Text = "Marca";
            this.Marca.Location = new System.Drawing.Point(6, 160);
            this.Marca.Name = "Marca";
            this.Marca.Pp = null;
            this.Marca.Size = new System.Drawing.Size(294, 39);
            this.Marca.SqlComandText = "select codigo,Descricao from Auxiliar where Tabela=4";
            this.Marca.TabIndex = 3;
            this.Marca.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Marca.Text2 = null;
            // 
            // Fabricante
            // 
            this.Fabricante.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.Fabricante.IsLocaDs = false;
            this.Fabricante.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fabricante.Label1Text = "Fabricante";
            this.Fabricante.Location = new System.Drawing.Point(6, 115);
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Pp = null;
            this.Fabricante.Size = new System.Drawing.Size(294, 39);
            this.Fabricante.SqlComandText = "select Codigo,descricao from auxiliar where Tabela=3";
            this.Fabricante.TabIndex = 2;
            this.Fabricante.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fabricante.Text2 = null;
            // 
            // Subfamilia
            // 
            this.Subfamilia.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.Subfamilia.IsLocaDs = false;
            this.Subfamilia.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Subfamilia.Label1Text = "Subfamília";
            this.Subfamilia.Location = new System.Drawing.Point(6, 70);
            this.Subfamilia.Name = "Subfamilia";
            this.Subfamilia.Pp = null;
            this.Subfamilia.Size = new System.Drawing.Size(294, 39);
            this.Subfamilia.SqlComandText = "select Codigo,descricao from SubFam";
            this.Subfamilia.TabIndex = 1;
            this.Subfamilia.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Subfamilia.Text2 = null;
            // 
            // Familia
            // 
            this.Familia.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.Familia.IsLocaDs = false;
            this.Familia.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Familia.Label1Text = "Família";
            this.Familia.Location = new System.Drawing.Point(6, 25);
            this.Familia.Name = "Familia";
            this.Familia.Pp = null;
            this.Familia.Size = new System.Drawing.Size(294, 39);
            this.Familia.SqlComandText = "select Codigo,descricao from Familia";
            this.Familia.TabIndex = 0;
            this.Familia.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Familia.Text2 = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbTodas);
            this.tabPage2.Controls.Add(this.gridPreco);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Definição de colunas ";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPreco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPreco.ColumnHeadersHeight = 30;
            this.gridPreco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPreco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.sel});
            this.gridPreco.Condicao = null;
            this.gridPreco.CorPreto = true;
            this.gridPreco.CurrentColumnName = null;
            this.gridPreco.DefacolumnName = null;
            this.gridPreco.DtDS = null;
            this.gridPreco.EnableHeadersVisualStyles = false;
            this.gridPreco.GenerateColumns = false;
            this.gridPreco.GridColor = System.Drawing.Color.SteelBlue;
            this.gridPreco.GridFilha = true;
            this.gridPreco.GridFilhaSecundaria = false;
            this.gridPreco.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPreco.HeadersHeight = 30;
            this.gridPreco.HeadersVisible = false;
            this.gridPreco.Location = new System.Drawing.Point(3, 29);
            this.gridPreco.Name = "gridPreco";
            this.gridPreco.OrderbyCampos = null;
            this.gridPreco.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridPreco.RowHeadersVisible = false;
            this.gridPreco.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridPreco.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPreco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPreco.Size = new System.Drawing.Size(411, 338);
            this.gridPreco.StampCabecalho = "Ststamp";
            this.gridPreco.StampLocal = "StPrecostamp";
            this.gridPreco.TabelaSql = "StPrecos";
            this.gridPreco.TabIndex = 1;
            this.gridPreco.TbCodigo = null;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(357, 408);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 56);
            this.btnPrint.TabIndex = 82;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbTodas
            // 
            this.cbTodas.BackColor = System.Drawing.Color.Transparent;
            this.cbTodas.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTodas.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTodas.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTodas.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbTodas.CbText = "Todas Colunas";
            this.cbTodas.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTodas.Imagem = ((System.Drawing.Image)(resources.GetObject("cbTodas.Imagem")));
            this.cbTodas.IsOptionGroup = false;
            this.cbTodas.IsReadOnly = false;
            this.cbTodas.IsRequered = false;
            this.cbTodas.Location = new System.Drawing.Point(6, 3);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.OnlyCheckBox = true;
            this.cbTodas.Size = new System.Drawing.Size(167, 22);
            this.cbTodas.TabIndex = 2;
            this.cbTodas.Value = null;
            this.cbTodas.Value2 = null;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome da coluna";
            this.nome.Name = "nome";
            // 
            // sel
            // 
            this.sel.DataPropertyName = "sel";
            this.sel.HeaderText = "Incluir";
            this.sel.Name = "sel";
            this.sel.Width = 50;
            // 
            // FrmProdListOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 517);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProdListOptions";
            this.Text = "FrmProdListOptions";
            this.Load += new System.EventHandler(this.FrmProdListOptions_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPreco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.DmzProcura Subfamilia;
        private UC.DmzProcura Familia;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button btnPrint;
        private UC.DmzProcura Marca;
        private UC.DmzProcura Fabricante;
        private Generic.GridUi gridPreco;
        private UC.CbDefault cbTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel;
    }
}