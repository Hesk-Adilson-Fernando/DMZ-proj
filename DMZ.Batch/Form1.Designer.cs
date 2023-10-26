namespace DMZ.Batch
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEntidade = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbPlanomulta = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcess = new System.Windows.Forms.Button();
            this.gridUiAlunos = new System.Windows.Forms.DataGridView();
            this.ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alunostamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidadebanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbEntidade);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.groupBox1.Location = new System.Drawing.Point(345, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 42);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entidade Bancária";
            // 
            // cbEntidade
            // 
            this.cbEntidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEntidade.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEntidade.FormattingEnabled = true;
            this.cbEntidade.Location = new System.Drawing.Point(7, 15);
            this.cbEntidade.Name = "cbEntidade";
            this.cbEntidade.Size = new System.Drawing.Size(286, 23);
            this.cbEntidade.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbPlanomulta);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.groupBox4.Location = new System.Drawing.Point(3, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 42);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "plano de multa";
            // 
            // cbPlanomulta
            // 
            this.cbPlanomulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlanomulta.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlanomulta.FormattingEnabled = true;
            this.cbPlanomulta.Location = new System.Drawing.Point(7, 15);
            this.cbPlanomulta.Name = "cbPlanomulta";
            this.cbPlanomulta.Size = new System.Drawing.Size(324, 23);
            this.cbPlanomulta.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnProcurar);
            this.panel2.Location = new System.Drawing.Point(460, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 38);
            this.panel2.TabIndex = 36;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnProcurar.ForeColor = System.Drawing.Color.White;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcurar.Location = new System.Drawing.Point(1, 3);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(69, 32);
            this.btnProcurar.TabIndex = 94;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.tbTotal);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.groupBox5.Location = new System.Drawing.Point(3, 294);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 42);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total de documentos";
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(10, 15);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(178, 21);
            this.tbTotal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Location = new System.Drawing.Point(426, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 38);
            this.panel1.TabIndex = 39;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnProcess.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.Location = new System.Drawing.Point(3, 3);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(110, 32);
            this.btnProcess.TabIndex = 94;
            this.btnProcess.Text = "PROCESSAR";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // gridUiAlunos
            // 
            this.gridUiAlunos.AllowUserToAddRows = false;
            this.gridUiAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUiAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUiAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ok,
            this.dataGridViewTextBoxColumn1,
            this.foto,
            this.dataGridViewTextBoxColumn2,
            this.n1,
            this.n2,
            this.data,
            this.Vencim,
            this.dias,
            this.curso,
            this.Alunostamp,
            this.Referencia,
            this.Entidadebanc});
            this.gridUiAlunos.Location = new System.Drawing.Point(3, 60);
            this.gridUiAlunos.Name = "gridUiAlunos";
            this.gridUiAlunos.RowHeadersVisible = false;
            this.gridUiAlunos.RowHeadersWidth = 51;
            this.gridUiAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUiAlunos.Size = new System.Drawing.Size(530, 228);
            this.gridUiAlunos.TabIndex = 41;
            // 
            // ok
            // 
            this.ok.DataPropertyName = "ok";
            this.ok.HeaderText = "...";
            this.ok.MinimumWidth = 6;
            this.ok.Name = "ok";
            this.ok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ok.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "no";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // foto
            // 
            this.foto.HeaderText = "...";
            this.foto.MinimumWidth = 6;
            this.foto.Name = "foto";
            this.foto.Visible = false;
            this.foto.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // n1
            // 
            this.n1.DataPropertyName = "descricao";
            this.n1.HeaderText = "Descrição";
            this.n1.MinimumWidth = 6;
            this.n1.Name = "n1";
            this.n1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.n1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.n1.Width = 120;
            // 
            // n2
            // 
            this.n2.DataPropertyName = "valorpreg";
            this.n2.HeaderText = "Valor";
            this.n2.MinimumWidth = 6;
            this.n2.Name = "n2";
            this.n2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.n2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.n2.Width = 90;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.data.Width = 75;
            // 
            // Vencim
            // 
            this.Vencim.DataPropertyName = "Vencim";
            this.Vencim.HeaderText = "Vencin";
            this.Vencim.MinimumWidth = 6;
            this.Vencim.Name = "Vencim";
            this.Vencim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Vencim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Vencim.Width = 90;
            // 
            // dias
            // 
            this.dias.DataPropertyName = "dias";
            this.dias.HeaderText = "Dia";
            this.dias.MinimumWidth = 6;
            this.dias.Name = "dias";
            this.dias.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dias.Width = 35;
            // 
            // curso
            // 
            this.curso.DataPropertyName = "curso";
            this.curso.HeaderText = "Curso";
            this.curso.MinimumWidth = 6;
            this.curso.Name = "curso";
            this.curso.Width = 200;
            // 
            // Alunostamp
            // 
            this.Alunostamp.DataPropertyName = "clstamp";
            this.Alunostamp.HeaderText = "Alunostamp";
            this.Alunostamp.MinimumWidth = 6;
            this.Alunostamp.Name = "Alunostamp";
            this.Alunostamp.Width = 125;
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "Referencia";
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.MinimumWidth = 6;
            this.Referencia.Name = "Referencia";
            this.Referencia.Width = 125;
            // 
            // Entidadebanc
            // 
            this.Entidadebanc.DataPropertyName = "Entidadebanc";
            this.Entidadebanc.HeaderText = "Entidadebanc";
            this.Entidadebanc.MinimumWidth = 6;
            this.Entidadebanc.Name = "Entidadebanc";
            this.Entidadebanc.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 339);
            this.Controls.Add(this.gridUiAlunos);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEntidade;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbPlanomulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.DataGridView gridUiAlunos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alunostamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidadebanc;
    }
}

