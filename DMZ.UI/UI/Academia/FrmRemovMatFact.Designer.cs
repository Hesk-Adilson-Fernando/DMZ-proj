namespace DMZ.UI.UI.Academia
{
    partial class FrmRemovMatFact
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnRemoveFact = new System.Windows.Forms.Button();
            this.gridUiAlunos = new DMZ.UI.Generic.GridUi();
            this.tbCl = new DMZ.UI.UC.Procura();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turmastamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cursostamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anosem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorpreg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurmeroRepeticoes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(797, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(765, 2);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.tbTotal);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.groupBox5.Location = new System.Drawing.Point(3, 400);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(146, 42);
            this.groupBox5.TabIndex = 101;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total linhas duplicadas";
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(10, 15);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(130, 21);
            this.tbTotal.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnProcurar.ForeColor = System.Drawing.Color.White;
            this.btnProcurar.Image = global::DMZ.UI.Properties.Resources.Search_20px;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcurar.Location = new System.Drawing.Point(641, 36);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(158, 32);
            this.btnProcurar.TabIndex = 100;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnRemoveFact
            // 
            this.btnRemoveFact.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveFact.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveFact.Image = global::DMZ.UI.Properties.Resources.Delete_2522px;
            this.btnRemoveFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveFact.Location = new System.Drawing.Point(513, 405);
            this.btnRemoveFact.Name = "btnRemoveFact";
            this.btnRemoveFact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemoveFact.Size = new System.Drawing.Size(286, 41);
            this.btnRemoveFact.TabIndex = 99;
            this.btnRemoveFact.Text = "(ATENÇÃO) Remover facturas seleccionadas";
            this.btnRemoveFact.UseVisualStyleBackColor = false;
            this.btnRemoveFact.Click += new System.EventHandler(this.btnRemoveFact_Click);
            // 
            // gridUiAlunos
            // 
            this.gridUiAlunos.AddButtons = false;
            this.gridUiAlunos.AllowUserToAddRows = false;
            this.gridUiAlunos.AllowUserToDeleteRows = false;
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
            this.nome,
            this.Turmastamp,
            this.Cursostamp,
            this.clstamp,
            this.Anosem,
            this.Descricao,
            this.Valorpreg,
            this.ccstamp,
            this.NurmeroRepeticoes});
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
            this.gridUiAlunos.Location = new System.Drawing.Point(3, 69);
            this.gridUiAlunos.Name = "gridUiAlunos";
            this.gridUiAlunos.OrderbyCampos = null;
            this.gridUiAlunos.Origem = null;
            this.gridUiAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUiAlunos.RowHeadersVisible = false;
            this.gridUiAlunos.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridUiAlunos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUiAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUiAlunos.Size = new System.Drawing.Size(796, 327);
            this.gridUiAlunos.StampCabecalho = "Turmastamp";
            this.gridUiAlunos.StampLocal = "Turmalstamp";
            this.gridUiAlunos.TabelaSql = "Turmal";
            this.gridUiAlunos.TabIndex = 98;
            this.gridUiAlunos.TbCodigo = null;
            this.gridUiAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUiAlunos_CellContentClick);
            // 
            // tbCl
            // 
            this.tbCl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCl.AutoComplete = false;
            this.tbCl.BackColor = System.Drawing.Color.Transparent;
            this.tbCl.Campo = null;
            this.tbCl.Campo1 = null;
            this.tbCl.CampoStatus = false;
            this.tbCl.ColunaCodigo = "Código";
            this.tbCl.ColunaDescricao = "Descrição";
            this.tbCl.Condicao = "DeficilCobrar=0";
            this.tbCl.DependDescricao = null;
            this.tbCl.Dependente = false;
            this.tbCl.DependenteNome = null;
            this.tbCl.Descname = "nome";
            this.tbCl.EnableTb1Field = true;
            this.tbCl.ExecMetodo = false;
            this.tbCl.FormName = "FrmCL";
            this.tbCl.HideFirstColumn = false;
            this.tbCl.InserirNovo = false;
            this.tbCl.InvertColuna = false;
            this.tbCl.IsLocaDs = false;
            this.tbCl.IsRequered = true;
            this.tbCl.IsSqlSelect = true;
            this.tbCl.Istatus = false;
            this.tbCl.IsUnique = false;
            this.tbCl.Items = null;
            this.tbCl.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCl.label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCl.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCl.Label1Text = "Nome do aluno";
            this.tbCl.Location = new System.Drawing.Point(2, 29);
            this.tbCl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCl.MultDocumento = false;
            this.tbCl.Name = "tbCl";
            this.tbCl.OpenInfo = false;
            this.tbCl.ParentFormName = null;
            this.tbCl.Pp = null;
            this.tbCl.ReturnDt = false;
            this.tbCl.Selecionado = "no,nome";
            this.tbCl.ShowThirdColumn = false;
            this.tbCl.Size = new System.Drawing.Size(590, 39);
            this.tbCl.SqlComandText = "select no,nome,clstamp from cl";
            this.tbCl.Tabela = "cl";
            this.tbCl.TabIndex = 121;
            this.tbCl.TbCkUpdate = false;
            this.tbCl.TbClear = false;
            this.tbCl.TbUpDate = null;
            this.tbCl.Text2 = null;
            this.tbCl.Text3 = null;
            this.tbCl.Text4 = null;
            this.tbCl.Text5 = null;
            this.tbCl.Text6 = null;
            this.tbCl.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbCl.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCl.Titulo = "Procurar";
            this.tbCl.TmpFound = null;
            this.tbCl.UpdateTextBox = null;
            this.tbCl.Value = "nome";
            this.tbCl.Value2 = "no";
            this.tbCl.Value3 = "clstamp";
            this.tbCl.Value4 = null;
            this.tbCl.Value5 = null;
            this.tbCl.Value6 = null;
            this.tbCl.Values = new string[] {
        ""};
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "Nome";
            this.nome.FillWeight = 7.874008F;
            this.nome.HeaderText = "Nome Completo";
            this.nome.MinimumWidth = 100;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Visible = false;
            // 
            // Turmastamp
            // 
            this.Turmastamp.DataPropertyName = "Turmastamp";
            this.Turmastamp.HeaderText = "Turmastamp";
            this.Turmastamp.Name = "Turmastamp";
            this.Turmastamp.ReadOnly = true;
            this.Turmastamp.Visible = false;
            // 
            // Cursostamp
            // 
            this.Cursostamp.DataPropertyName = "Cursostamp";
            this.Cursostamp.HeaderText = "Cursostamp";
            this.Cursostamp.Name = "Cursostamp";
            this.Cursostamp.ReadOnly = true;
            this.Cursostamp.Visible = false;
            // 
            // clstamp
            // 
            this.clstamp.DataPropertyName = "Clstamp";
            this.clstamp.HeaderText = "Clstamp";
            this.clstamp.Name = "clstamp";
            this.clstamp.Visible = false;
            // 
            // Anosem
            // 
            this.Anosem.DataPropertyName = "Anosem";
            this.Anosem.HeaderText = "AnoSem";
            this.Anosem.Name = "Anosem";
            this.Anosem.ReadOnly = true;
            this.Anosem.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 50;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Valorpreg
            // 
            this.Valorpreg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Valorpreg.DataPropertyName = "Valorpreg";
            this.Valorpreg.HeaderText = "Valor";
            this.Valorpreg.Name = "Valorpreg";
            this.Valorpreg.ReadOnly = true;
            this.Valorpreg.Width = 55;
            // 
            // ccstamp
            // 
            this.ccstamp.DataPropertyName = "Ccstamp";
            this.ccstamp.HeaderText = "ccstamp";
            this.ccstamp.Name = "ccstamp";
            this.ccstamp.Visible = false;
            // 
            // NurmeroRepeticoes
            // 
            this.NurmeroRepeticoes.DataPropertyName = "ok";
            this.NurmeroRepeticoes.HeaderText = "OK";
            this.NurmeroRepeticoes.Name = "NurmeroRepeticoes";
            this.NurmeroRepeticoes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NurmeroRepeticoes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NurmeroRepeticoes.Width = 50;
            // 
            // FrmRemovMatFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCl);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnRemoveFact);
            this.Controls.Add(this.gridUiAlunos);
            this.Name = "FrmRemovMatFact";
            this.Text = "FrmRemovMat";
            this.Load += new System.EventHandler(this.FrmRemovMat_Load);
            this.Controls.SetChildIndex(this.gridUiAlunos, 0);
            this.Controls.SetChildIndex(this.btnRemoveFact, 0);
            this.Controls.SetChildIndex(this.btnProcurar, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tbCl, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnRemoveFact;
        private Generic.GridUi gridUiAlunos;
        public UC.Procura tbCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turmastamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursostamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anosem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorpreg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccstamp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NurmeroRepeticoes;
    }
}