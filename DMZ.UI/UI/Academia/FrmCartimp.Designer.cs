namespace DMZ.UI.UI.Academia
{
    partial class FrmCartimp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCartimp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.tbProcura = new System.Windows.Forms.TextBox();
            this.gridUiAlunos = new DMZ.UI.Generic.GridUi();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataemissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.QrCode = new System.Windows.Forms.DataGridViewImageColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewImageColumn();
            this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Clstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(936, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(904, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(238, 16);
            this.label1.Text = "Cartões de estudades para impressão";
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnProcess.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcess.Image = global::DMZ.UI.Properties.Resources.Print_22px;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.Location = new System.Drawing.Point(795, 2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(123, 32);
            this.btnProcess.TabIndex = 94;
            this.btnProcess.Text = "PROCESSAR";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 489);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnProcess);
            this.tabPage1.Controls.Add(this.cbDefault1);
            this.tabPage1.Controls.Add(this.tbProcura);
            this.tabPage1.Controls.Add(this.gridUiAlunos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(923, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alunos ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbDefault1
            // 
            this.cbDefault1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDefault1.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "Selecçionar todos";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(424, 7);
            this.cbDefault1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = true;
            this.cbDefault1.Size = new System.Drawing.Size(143, 24);
            this.cbDefault1.TabIndex = 94;
            this.cbDefault1.Value = null;
            this.cbDefault1.Value2 = null;
            // 
            // tbProcura
            // 
            this.tbProcura.BackColor = System.Drawing.Color.Snow;
            this.tbProcura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProcura.Location = new System.Drawing.Point(6, 7);
            this.tbProcura.Name = "tbProcura";
            this.tbProcura.Size = new System.Drawing.Size(412, 23);
            this.tbProcura.TabIndex = 93;
            // 
            // gridUiAlunos
            // 
            this.gridUiAlunos.AddButtons = false;
            this.gridUiAlunos.AllowUserToAddRows = false;
            this.gridUiAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUiAlunos.AutoIncrimento = false;
            this.gridUiAlunos.BackgroundColor = System.Drawing.Color.Beige;
            this.gridUiAlunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUiAlunos.CampoCodigo = null;
            this.gridUiAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUiAlunos.Codigo = null;
            this.gridUiAlunos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUiAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUiAlunos.ColumnHeadersHeight = 30;
            this.gridUiAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUiAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CodigoCart,
            this.dataGridViewTextBoxColumn2,
            this.curso,
            this.dataemissao,
            this.validade,
            this.Imagem,
            this.QrCode,
            this.Barcode,
            this.sel,
            this.Clstamp});
            this.gridUiAlunos.Condicao = null;
            this.gridUiAlunos.CorPreto = true;
            this.gridUiAlunos.CurrentColumnName = null;
            this.gridUiAlunos.DefacolumnName = null;
            this.gridUiAlunos.DellGridRow = null;
            this.gridUiAlunos.DtDS = null;
            this.gridUiAlunos.EnableHeadersVisualStyles = false;
            this.gridUiAlunos.GenerateColumns = false;
            this.gridUiAlunos.GridColor = System.Drawing.Color.White;
            this.gridUiAlunos.GridFilha = true;
            this.gridUiAlunos.GridFilhaSecundaria = false;
            this.gridUiAlunos.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUiAlunos.HeadersHeight = 30;
            this.gridUiAlunos.HeadersVisible = false;
            this.gridUiAlunos.Location = new System.Drawing.Point(6, 36);
            this.gridUiAlunos.Name = "gridUiAlunos";
            this.gridUiAlunos.OrderbyCampos = null;
            this.gridUiAlunos.Origem = null;
            this.gridUiAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUiAlunos.RowHeadersVisible = false;
            this.gridUiAlunos.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridUiAlunos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUiAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUiAlunos.Size = new System.Drawing.Size(913, 417);
            this.gridUiAlunos.StampCabecalho = "Turmastamp";
            this.gridUiAlunos.StampLocal = "Turmalstamp";
            this.gridUiAlunos.TabelaSql = "Turmal";
            this.gridUiAlunos.TabIndex = 1;
            this.gridUiAlunos.TbCodigo = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "no";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Aluno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // CodigoCart
            // 
            this.CodigoCart.DataPropertyName = "codigo";
            this.CodigoCart.HeaderText = "Código Cartão";
            this.CodigoCart.Name = "CodigoCart";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 7.874008F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // curso
            // 
            this.curso.DataPropertyName = "curso";
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.Width = 230;
            // 
            // dataemissao
            // 
            this.dataemissao.DataPropertyName = "data";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            this.dataemissao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataemissao.HeaderText = "Data Emissao";
            this.dataemissao.Name = "dataemissao";
            // 
            // validade
            // 
            this.validade.DataPropertyName = "datavenc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            this.validade.DefaultCellStyle = dataGridViewCellStyle3;
            this.validade.HeaderText = "Validade";
            this.validade.Name = "validade";
            this.validade.Width = 90;
            // 
            // Imagem
            // 
            this.Imagem.DataPropertyName = "Imagem";
            this.Imagem.HeaderText = "Fotografia";
            this.Imagem.Name = "Imagem";
            this.Imagem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagem.Visible = false;
            // 
            // QrCode
            // 
            this.QrCode.DataPropertyName = "codigoqr";
            this.QrCode.HeaderText = "Qr Code";
            this.QrCode.Name = "QrCode";
            this.QrCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QrCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QrCode.Visible = false;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Codigobarra";
            this.Barcode.HeaderText = "Barcode ";
            this.Barcode.Name = "Barcode";
            this.Barcode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Barcode.Visible = false;
            // 
            // sel
            // 
            this.sel.DataPropertyName = "sel";
            this.sel.HeaderText = "...";
            this.sel.Name = "sel";
            this.sel.ToolTipText = "Seleccionar o aluno";
            this.sel.Width = 30;
            // 
            // Clstamp
            // 
            this.Clstamp.DataPropertyName = "Clstamp";
            this.Clstamp.HeaderText = "Clstamp";
            this.Clstamp.Name = "Clstamp";
            this.Clstamp.Visible = false;
            // 
            // FrmCartimp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(937, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCartimp";
            this.Load += new System.EventHandler(this.FrmCartimp_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.CbDefault cbDefault1;
        private System.Windows.Forms.TextBox tbProcura;
        private Generic.GridUi gridUiAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataemissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
        private System.Windows.Forms.DataGridViewImageColumn Imagem;
        private System.Windows.Forms.DataGridViewImageColumn QrCode;
        private System.Windows.Forms.DataGridViewImageColumn Barcode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clstamp;
    }
}
