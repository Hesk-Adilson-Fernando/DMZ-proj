
namespace DMZ.UI.UI
{
    partial class FrmFormList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFormList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.btnformularios = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.Ecran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(546, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(514, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.Text = "Formulários e documentos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbDefault1);
            this.panel1.Controls.Add(this.btnformularios);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.gridUi1);
            this.panel1.Location = new System.Drawing.Point(2, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 447);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbDefault1
            // 
            this.cbDefault1.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "Selecionar tudo?";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(399, 7);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = true;
            this.cbDefault1.Size = new System.Drawing.Size(167, 22);
            this.cbDefault1.TabIndex = 84;
            this.cbDefault1.Value = null;
            this.cbDefault1.Value2 = null;
            this.cbDefault1.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault1_CheckedChangeds);
            // 
            // btnformularios
            // 
            this.btnformularios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnformularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnformularios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnformularios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnformularios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnformularios.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnformularios.Image = global::DMZ.UI.Properties.Resources.select_yes_25px;
            this.btnformularios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnformularios.Location = new System.Drawing.Point(443, 410);
            this.btnformularios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnformularios.Name = "btnformularios";
            this.btnformularios.Size = new System.Drawing.Size(96, 31);
            this.btnformularios.TabIndex = 83;
            this.btnformularios.Text = "Aceitar";
            this.btnformularios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnformularios.UseVisualStyleBackColor = false;
            this.btnformularios.Click += new System.EventHandler(this.btnformularios_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbSearch.Location = new System.Drawing.Point(3, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(390, 27);
            this.tbSearch.TabIndex = 82;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
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
            this.gridUi1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ecran,
            this.descricao,
            this.Origem1,
            this.ok});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUi1.GridFilha = true;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(2, 34);
            this.gridUi1.Margin = new System.Windows.Forms.Padding(3, 59, 3, 59);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            this.gridUi1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi1.Size = new System.Drawing.Size(538, 373);
            this.gridUi1.StampCabecalho = "Modulosstamp";
            this.gridUi1.StampLocal = "Modulosfrmdocstamp";
            this.gridUi1.TabelaSql = "Modulosfrmdoc";
            this.gridUi1.TabIndex = 81;
            this.gridUi1.TbCodigo = null;
            // 
            // Ecran
            // 
            this.Ecran.DataPropertyName = "Ecran";
            this.Ecran.HeaderText = "Ecran";
            this.Ecran.Name = "Ecran";
            this.Ecran.Width = 70;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 250;
            this.descricao.Name = "descricao";
            // 
            // Origem1
            // 
            this.Origem1.DataPropertyName = "origem";
            this.Origem1.HeaderText = "Origem";
            this.Origem1.Name = "Origem1";
            // 
            // ok
            // 
            this.ok.DataPropertyName = "ok";
            this.ok.HeaderText = "....";
            this.ok.Name = "ok";
            this.ok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ok.Width = 30;
            // 
            // FrmFormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 480);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFormList";
            this.Text = "FrmFormList";
            this.Load += new System.EventHandler(this.FrmFormList_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnformularios;
        private System.Windows.Forms.TextBox tbSearch;
        public Generic.GridUi gridUi1;
        private UC.CbDefault cbDefault1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ecran;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ok;
    }
}