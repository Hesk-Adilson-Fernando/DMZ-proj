namespace DMZ.UI.UI.Academia
{
    partial class FrmRemoverDisc
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
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnRemoveFact = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.gridUiAlunos = new DMZ.UI.Generic.GridUi();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turmastamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cursostamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anosem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurmeroRepeticoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(798, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(766, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.Text = "Remover diciplina repetidas";
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
            this.btnProcurar.Location = new System.Drawing.Point(630, 35);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(158, 32);
            this.btnProcurar.TabIndex = 98;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnRemoveFact
            // 
            this.btnRemoveFact.Location = new System.Drawing.Point(615, 418);
            this.btnRemoveFact.Name = "btnRemoveFact";
            this.btnRemoveFact.Size = new System.Drawing.Size(173, 28);
            this.btnRemoveFact.TabIndex = 97;
            this.btnRemoveFact.Text = "Remover facturas duplicadas";
            this.btnRemoveFact.UseVisualStyleBackColor = true;
            this.btnRemoveFact.Click += new System.EventHandler(this.btnRemoveFact_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.tbTotal);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.groupBox5.Location = new System.Drawing.Point(12, 404);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(146, 42);
            this.groupBox5.TabIndex = 99;
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
            this.Descricao,
            this.Anosem,
            this.NurmeroRepeticoes,
            this.activo});
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
            this.gridUiAlunos.Location = new System.Drawing.Point(12, 73);
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
            this.gridUiAlunos.Size = new System.Drawing.Size(776, 327);
            this.gridUiAlunos.StampCabecalho = "Turmastamp";
            this.gridUiAlunos.StampLocal = "Turmalstamp";
            this.gridUiAlunos.TabelaSql = "Turmal";
            this.gridUiAlunos.TabIndex = 100;
            this.gridUiAlunos.TbCodigo = null;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "AlunoNome";
            this.nome.FillWeight = 7.874008F;
            this.nome.HeaderText = "Nome Completo";
            this.nome.MinimumWidth = 100;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
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
            this.clstamp.DataPropertyName = "Alunostamp";
            this.clstamp.HeaderText = "Alunostamp";
            this.clstamp.Name = "clstamp";
            this.clstamp.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Coddis";
            this.Descricao.HeaderText = "Disciplina";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Anosem
            // 
            this.Anosem.DataPropertyName = "Anosem";
            this.Anosem.HeaderText = "AnoSem";
            this.Anosem.Name = "Anosem";
            this.Anosem.ReadOnly = true;
            // 
            // NurmeroRepeticoes
            // 
            this.NurmeroRepeticoes.DataPropertyName = "NurmeroRepeticoes";
            this.NurmeroRepeticoes.HeaderText = "No.Repetições";
            this.NurmeroRepeticoes.Name = "NurmeroRepeticoes";
            this.NurmeroRepeticoes.ReadOnly = true;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            // 
            // FrmRemoverDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridUiAlunos);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnRemoveFact);
            this.Name = "FrmRemoverDisc";
            this.Text = "FrmRemoverDisc";
            this.Load += new System.EventHandler(this.FrmRemoverDisc_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.btnRemoveFact, 0);
            this.Controls.SetChildIndex(this.btnProcurar, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.gridUiAlunos, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnRemoveFact;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbTotal;
        private Generic.GridUi gridUiAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turmastamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursostamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anosem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurmeroRepeticoes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
    }
}