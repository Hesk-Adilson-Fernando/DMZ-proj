namespace DMZ.UI.UI.Academia
{
    partial class FrmAddalunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbTotalPorInserir = new System.Windows.Forms.TextBox();
            this.gridUiAlunos = new DMZ.UI.Generic.GridUi();
            this.ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbDisciplina = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTurma = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCurso = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gridUiAlInseridos = new DMZ.UI.Generic.GridUi();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnUpdateProf = new System.Windows.Forms.Button();
            this.tbProfPrincipal = new DMZ.UI.UC.DmzProcura();
            this.tbProfauxiliar = new DMZ.UI.UC.DmzProcura();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlunos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlInseridos)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(580, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(548, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.Text = "Inserir alunos";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 498);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.gridUiAlunos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alunos por inserir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Image = global::DMZ.UI.Properties.Resources.Sync_Settings_20px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(440, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 32);
            this.button3.TabIndex = 94;
            this.button3.Text = "PROCESSAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.checkBox2.Location = new System.Drawing.Point(15, 53);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 122;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbTotalPorInserir);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.groupBox4.Location = new System.Drawing.Point(8, -2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 42);
            this.groupBox4.TabIndex = 121;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total de alunos";
            // 
            // tbTotalPorInserir
            // 
            this.tbTotalPorInserir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalPorInserir.Enabled = false;
            this.tbTotalPorInserir.Location = new System.Drawing.Point(10, 15);
            this.tbTotalPorInserir.Name = "tbTotalPorInserir";
            this.tbTotalPorInserir.Size = new System.Drawing.Size(287, 21);
            this.tbTotalPorInserir.TabIndex = 0;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUiAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUiAlunos.ColumnHeadersHeight = 30;
            this.gridUiAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUiAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ok,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
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
            this.gridUiAlunos.Location = new System.Drawing.Point(6, 44);
            this.gridUiAlunos.Name = "gridUiAlunos";
            this.gridUiAlunos.OrderbyCampos = null;
            this.gridUiAlunos.Origem = null;
            this.gridUiAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUiAlunos.RowHeadersVisible = false;
            this.gridUiAlunos.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridUiAlunos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUiAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUiAlunos.Size = new System.Drawing.Size(557, 420);
            this.gridUiAlunos.StampCabecalho = "Turmastamp";
            this.gridUiAlunos.StampLocal = "Turmalstamp";
            this.gridUiAlunos.TabelaSql = "Turmal";
            this.gridUiAlunos.TabIndex = 1;
            this.gridUiAlunos.TbCodigo = null;
            // 
            // ok
            // 
            this.ok.DataPropertyName = "ok";
            this.ok.HeaderText = "";
            this.ok.Name = "ok";
            this.ok.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "no";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
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
            // Clstamp
            // 
            this.Clstamp.DataPropertyName = "Clstamp";
            this.Clstamp.HeaderText = "Clstamp";
            this.Clstamp.Name = "Clstamp";
            this.Clstamp.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Snow;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Professores da disciplina";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbDisciplina);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.groupBox3.Location = new System.Drawing.Point(11, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 48);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disciplina";
            // 
            // tbDisciplina
            // 
            this.tbDisciplina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDisciplina.Location = new System.Drawing.Point(6, 19);
            this.tbDisciplina.Name = "tbDisciplina";
            this.tbDisciplina.Size = new System.Drawing.Size(358, 21);
            this.tbDisciplina.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTurma);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.groupBox2.Location = new System.Drawing.Point(11, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turma";
            // 
            // tbTurma
            // 
            this.tbTurma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTurma.Location = new System.Drawing.Point(6, 19);
            this.tbTurma.Name = "tbTurma";
            this.tbTurma.Size = new System.Drawing.Size(358, 21);
            this.tbTurma.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCurso);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curso";
            // 
            // tbCurso
            // 
            this.tbCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurso.Location = new System.Drawing.Point(6, 19);
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.Size = new System.Drawing.Size(358, 21);
            this.tbCurso.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.gridUiAlInseridos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(571, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Alunos inseridos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.checkBox1.Location = new System.Drawing.Point(14, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 121;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbTotal);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.groupBox5.Location = new System.Drawing.Point(6, -2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 42);
            this.groupBox5.TabIndex = 120;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total de alunos";
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(10, 15);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(354, 21);
            this.tbTotal.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDelete.Image = global::DMZ.UI.Properties.Resources.Trash_Can_20px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(481, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 32);
            this.btnDelete.TabIndex = 95;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridUiAlInseridos
            // 
            this.gridUiAlInseridos.AddButtons = false;
            this.gridUiAlInseridos.AllowUserToAddRows = false;
            this.gridUiAlInseridos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUiAlInseridos.AutoIncrimento = false;
            this.gridUiAlInseridos.BackgroundColor = System.Drawing.Color.Snow;
            this.gridUiAlInseridos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUiAlInseridos.CampoCodigo = null;
            this.gridUiAlInseridos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUiAlInseridos.Codigo = null;
            this.gridUiAlInseridos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUiAlInseridos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridUiAlInseridos.ColumnHeadersHeight = 30;
            this.gridUiAlInseridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUiAlInseridos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gridUiAlInseridos.Condicao = null;
            this.gridUiAlInseridos.CorPreto = true;
            this.gridUiAlInseridos.CurrentColumnName = null;
            this.gridUiAlInseridos.DefacolumnName = null;
            this.gridUiAlInseridos.DellGridRow = null;
            this.gridUiAlInseridos.DtDS = null;
            this.gridUiAlInseridos.EnableHeadersVisualStyles = false;
            this.gridUiAlInseridos.GenerateColumns = false;
            this.gridUiAlInseridos.GridColor = System.Drawing.Color.White;
            this.gridUiAlInseridos.GridFilha = true;
            this.gridUiAlInseridos.GridFilhaSecundaria = false;
            this.gridUiAlInseridos.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUiAlInseridos.HeadersHeight = 30;
            this.gridUiAlInseridos.HeadersVisible = false;
            this.gridUiAlInseridos.Location = new System.Drawing.Point(6, 41);
            this.gridUiAlInseridos.Name = "gridUiAlInseridos";
            this.gridUiAlInseridos.OrderbyCampos = null;
            this.gridUiAlInseridos.Origem = null;
            this.gridUiAlInseridos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUiAlInseridos.RowHeadersVisible = false;
            this.gridUiAlInseridos.RowHeadersWidth = 30;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gridUiAlInseridos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridUiAlInseridos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUiAlInseridos.Size = new System.Drawing.Size(557, 423);
            this.gridUiAlInseridos.StampCabecalho = "Turmastamp";
            this.gridUiAlInseridos.StampLocal = "Turmalstamp";
            this.gridUiAlInseridos.TabelaSql = "Turmal";
            this.gridUiAlInseridos.TabIndex = 2;
            this.gridUiAlInseridos.TbCodigo = null;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "ok";
            this.Status.HeaderText = "";
            this.Status.Name = "Status";
            this.Status.Width = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "no";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AlunoNome";
            this.dataGridViewTextBoxColumn4.FillWeight = 7.874008F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Alunostamp";
            this.dataGridViewTextBoxColumn5.HeaderText = "Clstamp";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbProfauxiliar);
            this.groupBox8.Controls.Add(this.tbProfPrincipal);
            this.groupBox8.Controls.Add(this.btnUpdateProf);
            this.groupBox8.Location = new System.Drawing.Point(11, 186);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(376, 178);
            this.groupBox8.TabIndex = 97;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Professores da disciplina";
            // 
            // btnUpdateProf
            // 
            this.btnUpdateProf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnUpdateProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProf.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnUpdateProf.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdateProf.Image = global::DMZ.UI.Properties.Resources.Save_20px;
            this.btnUpdateProf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateProf.Location = new System.Drawing.Point(231, 140);
            this.btnUpdateProf.Name = "btnUpdateProf";
            this.btnUpdateProf.Size = new System.Drawing.Size(133, 32);
            this.btnUpdateProf.TabIndex = 99;
            this.btnUpdateProf.Text = "Trocar Professor";
            this.btnUpdateProf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProf.UseVisualStyleBackColor = false;
            this.btnUpdateProf.Click += new System.EventHandler(this.btnUpdateProf_Click);
            // 
            // tbProfPrincipal
            // 
            this.tbProfPrincipal.BtnEnabled = true;
            this.tbProfPrincipal.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbProfPrincipal.Button1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbProfPrincipal.Condicao = null;
            this.tbProfPrincipal.ExecMetodo = false;
            this.tbProfPrincipal.HideFirstColumn = false;
            this.tbProfPrincipal.InvertColuna = false;
            this.tbProfPrincipal.IsLocaDs = false;
            this.tbProfPrincipal.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfPrincipal.Label1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfPrincipal.Label1Text = "Professor Principal";
            this.tbProfPrincipal.Location = new System.Drawing.Point(11, 36);
            this.tbProfPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbProfPrincipal.MySQLQuerry = null;
            this.tbProfPrincipal.Name = "tbProfPrincipal";
            this.tbProfPrincipal.Pp = null;
            this.tbProfPrincipal.Size = new System.Drawing.Size(353, 38);
            this.tbProfPrincipal.SqlComandText = "";
            this.tbProfPrincipal.TabIndex = 100;
            this.tbProfPrincipal.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfPrincipal.Tb1Multiline = true;
            this.tbProfPrincipal.Text2 = null;
            this.tbProfPrincipal.Text3 = null;
            this.tbProfPrincipal.Text4 = null;
            // 
            // tbProfauxiliar
            // 
            this.tbProfauxiliar.BtnEnabled = true;
            this.tbProfauxiliar.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbProfauxiliar.Button1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbProfauxiliar.Condicao = null;
            this.tbProfauxiliar.ExecMetodo = false;
            this.tbProfauxiliar.HideFirstColumn = false;
            this.tbProfauxiliar.InvertColuna = false;
            this.tbProfauxiliar.IsLocaDs = false;
            this.tbProfauxiliar.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfauxiliar.Label1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfauxiliar.Label1Text = "Professor Auxiliar";
            this.tbProfauxiliar.Location = new System.Drawing.Point(11, 86);
            this.tbProfauxiliar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbProfauxiliar.MySQLQuerry = null;
            this.tbProfauxiliar.Name = "tbProfauxiliar";
            this.tbProfauxiliar.Pp = null;
            this.tbProfauxiliar.Size = new System.Drawing.Size(353, 38);
            this.tbProfauxiliar.SqlComandText = "";
            this.tbProfauxiliar.TabIndex = 101;
            this.tbProfauxiliar.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfauxiliar.Tb1Multiline = true;
            this.tbProfauxiliar.Text2 = null;
            this.tbProfauxiliar.Text3 = null;
            this.tbProfauxiliar.Text4 = null;
            // 
            // FrmAddalunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(581, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAddalunos";
            this.Load += new System.EventHandler(this.FrmAddalunos_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlunos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiAlInseridos)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Generic.GridUi gridUiAlunos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbDisciplina;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTurma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCurso;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbTotalPorInserir;
        private System.Windows.Forms.TabPage tabPage3;
        private Generic.GridUi gridUiAlInseridos;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clstamp;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnUpdateProf;
        private UC.DmzProcura tbProfauxiliar;
        private UC.DmzProcura tbProfPrincipal;
    }
}
