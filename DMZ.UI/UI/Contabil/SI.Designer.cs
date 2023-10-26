namespace DMZ.UI.UI.Contabil
{
    partial class SI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLancar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.documento = new DMZ.UI.UC.DmzProcura();
            this.mes = new DMZ.UI.UC.DmzProcura();
            this.dia = new DMZ.UI.UC.DmzProcura();
            this.label2 = new System.Windows.Forms.Label();
            this.nContOri = new System.Windows.Forms.NumericUpDown();
            this.radCheckBox2 = new DMZ.UI.UC.CbDefault();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.ClnConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nContOri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(849, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(817, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.Text = "Saldos Iniciais";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radCheckBox2);
            this.panel2.Controls.Add(this.btnLancar);
            this.panel2.Location = new System.Drawing.Point(8, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 40);
            this.panel2.TabIndex = 96;
            // 
            // btnLancar
            // 
            this.btnLancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnLancar.FlatAppearance.BorderSize = 0;
            this.btnLancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLancar.Image = global::DMZ.UI.Properties.Resources.Automatic_251px;
            this.btnLancar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLancar.Location = new System.Drawing.Point(660, 1);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(175, 35);
            this.btnLancar.TabIndex = 90;
            this.btnLancar.Text = "Lançar movimento";
            this.btnLancar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProcessar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbDescricao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.documento);
            this.panel1.Controls.Add(this.mes);
            this.panel1.Controls.Add(this.dia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nContOri);
            this.panel1.Location = new System.Drawing.Point(8, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 98);
            this.panel1.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.Location = new System.Drawing.Point(419, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 95;
            this.label5.Text = "Número";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(422, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(419, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "Descrição do movimento";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescricao.Location = new System.Drawing.Point(422, 67);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(305, 20);
            this.tbDescricao.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.Location = new System.Drawing.Point(198, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 91;
            this.label3.Text = "Data ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 90;
            // 
            // documento
            // 
            this.documento.BtnEnabled = true;
            this.documento.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.documento.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.documento.Condicao = null;
            this.documento.ExecMetodo = false;
            this.documento.HideFirstColumn = false;
            this.documento.InvertColuna = false;
            this.documento.IsLocaDs = false;
            this.documento.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documento.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documento.Label1Text = "Documento";
            this.documento.Location = new System.Drawing.Point(192, 3);
            this.documento.MySQLQuerry = null;
            this.documento.Name = "documento";
            this.documento.Pp = null;
            this.documento.Size = new System.Drawing.Size(211, 39);
            this.documento.SqlComandText = "select no,nome from cl order by no";
            this.documento.TabIndex = 89;
            this.documento.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documento.Tb1Multiline = false;
            this.documento.Text2 = null;
            this.documento.Text3 = null;
            // 
            // mes
            // 
            this.mes.BtnEnabled = true;
            this.mes.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.mes.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.mes.Condicao = null;
            this.mes.ExecMetodo = false;
            this.mes.HideFirstColumn = false;
            this.mes.InvertColuna = false;
            this.mes.IsLocaDs = false;
            this.mes.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mes.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes.Label1Text = "Mês";
            this.mes.Location = new System.Drawing.Point(3, 3);
            this.mes.MySQLQuerry = null;
            this.mes.Name = "mes";
            this.mes.Pp = null;
            this.mes.Size = new System.Drawing.Size(183, 39);
            this.mes.SqlComandText = "select no,nome from cl order by no";
            this.mes.TabIndex = 88;
            this.mes.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mes.Tb1Multiline = false;
            this.mes.Text2 = null;
            this.mes.Text3 = null;
            // 
            // dia
            // 
            this.dia.BtnEnabled = true;
            this.dia.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dia.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dia.Condicao = null;
            this.dia.ExecMetodo = false;
            this.dia.HideFirstColumn = false;
            this.dia.InvertColuna = false;
            this.dia.IsLocaDs = false;
            this.dia.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dia.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia.Label1Text = "Diário";
            this.dia.Location = new System.Drawing.Point(3, 48);
            this.dia.MySQLQuerry = null;
            this.dia.Name = "dia";
            this.dia.Pp = null;
            this.dia.Size = new System.Drawing.Size(183, 39);
            this.dia.SqlComandText = "select no,nome from cl order by no";
            this.dia.TabIndex = 87;
            this.dia.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dia.Tb1Multiline = false;
            this.dia.Text2 = null;
            this.dia.Text3 = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(323, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Ano";
            // 
            // nContOri
            // 
            this.nContOri.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.nContOri.Location = new System.Drawing.Point(326, 67);
            this.nContOri.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nContOri.Name = "nContOri";
            this.nContOri.Size = new System.Drawing.Size(77, 21);
            this.nContOri.TabIndex = 83;
            this.nContOri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox2.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radCheckBox2.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.radCheckBox2.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckBox2.CbForeColor = System.Drawing.Color.Black;
            this.radCheckBox2.CbText = "Não incluir contas da classe 9";
            this.radCheckBox2.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radCheckBox2.Imagem = ((System.Drawing.Image)(resources.GetObject("radCheckBox2.Imagem")));
            this.radCheckBox2.IsOptionGroup = false;
            this.radCheckBox2.IsReadOnly = false;
            this.radCheckBox2.IsRequered = false;
            this.radCheckBox2.Location = new System.Drawing.Point(3, 14);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.OnlyCheckBox = true;
            this.radCheckBox2.Size = new System.Drawing.Size(334, 22);
            this.radCheckBox2.TabIndex = 97;
            this.radCheckBox2.Value = null;
            this.radCheckBox2.Value2 = null;
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnConta,
            this.descricao,
            this.deb,
            this.cre});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.White;
            this.gridUi1.GridFilha = true;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(8, 139);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUi1.Size = new System.Drawing.Size(839, 342);
            this.gridUi1.StampCabecalho = "Dcstamp";
            this.gridUi1.StampLocal = "Dclistamp";
            this.gridUi1.TabelaSql = "Dcli";
            this.gridUi1.TabIndex = 97;
            this.gridUi1.TbCodigo = null;
            // 
            // ClnConta
            // 
            this.ClnConta.DataPropertyName = "conta";
            this.ClnConta.HeaderText = "Conta";
            this.ClnConta.MinimumWidth = 100;
            this.ClnConta.Name = "ClnConta";
            this.ClnConta.Width = 150;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 150;
            this.descricao.Name = "descricao";
            // 
            // deb
            // 
            this.deb.DataPropertyName = "deb";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.deb.DefaultCellStyle = dataGridViewCellStyle2;
            this.deb.HeaderText = "Débito";
            this.deb.Name = "deb";
            this.deb.Width = 120;
            // 
            // cre
            // 
            this.cre.DataPropertyName = "cre";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cre.DefaultCellStyle = dataGridViewCellStyle3;
            this.cre.HeaderText = "Crédito";
            this.cre.Name = "cre";
            this.cre.Width = 120;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Sync_Settings_20px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcessar.Location = new System.Drawing.Point(743, 22);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(88, 65);
            this.btnProcessar.TabIndex = 96;
            this.btnProcessar.Text = "PROCESSAR";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcessar.UseVisualStyleBackColor = false;
            // 
            // SI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(850, 533);
            this.Controls.Add(this.gridUi1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SI";
            this.Load += new System.EventHandler(this.SI_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.gridUi1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nContOri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nContOri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private UC.DmzProcura documento;
        private UC.DmzProcura mes;
        private UC.DmzProcura dia;
        private UC.CbDefault radCheckBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private Generic.GridUi gridUi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn deb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cre;
        private System.Windows.Forms.Button btnProcessar;
    }
}
