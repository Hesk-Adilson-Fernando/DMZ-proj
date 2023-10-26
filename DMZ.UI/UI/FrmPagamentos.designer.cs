namespace DMZ.UI.UI
{
    partial class FrmPagamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamentos));
            this.panel7 = new System.Windows.Forms.Panel();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCinquenta = new System.Windows.Forms.Button();
            this.btnQuinhentos = new System.Windows.Forms.Button();
            this.btnMil = new System.Windows.Forms.Button();
            this.btnCem = new System.Windows.Forms.Button();
            this.btnCincoMil = new System.Windows.Forms.Button();
            this.btnDezmil = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btC = new System.Windows.Forms.Button();
            this.btD = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDivida = new System.Windows.Forms.TextBox();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.tbPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTroco = new System.Windows.Forms.TextBox();
            this.cbImprimir = new DMZ.UI.UC.CbDefault();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbA5 = new DMZ.UI.UC.CbDefault();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbA4 = new DMZ.UI.UC.CbDefault();
            this.cbPOS = new DMZ.UI.UC.CbDefault();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.NrCopias = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NrCopias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(776, 31);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMZ.UI.Properties.Resources.Money_Circulation_20px;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(749, 3);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 6);
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.Text = "Pagamentos";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Snow;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.gridUi1);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(12, 110);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(563, 257);
            this.panel7.TabIndex = 66;
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            this.gridUi1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.forma,
            this.Valor,
            this.image});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.Goldenrod;
            this.gridUi1.GridFilha = false;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(5, 5);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            this.gridUi1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUi1.RowTemplate.Height = 30;
            this.gridUi1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridUi1.Size = new System.Drawing.Size(551, 239);
            this.gridUi1.StampCabecalho = "";
            this.gridUi1.StampLocal = "";
            this.gridUi1.TabelaSql = "";
            this.gridUi1.TabIndex = 1;
            this.gridUi1.TbCodigo = null;
            this.gridUi1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellClick);
            // 
            // forma
            // 
            this.forma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.forma.DataPropertyName = "descricao";
            this.forma.HeaderText = "Tipo de Movimento";
            this.forma.MinimumWidth = 160;
            this.forma.Name = "forma";
            this.forma.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 150;
            // 
            // image
            // 
            this.image.HeaderText = "....";
            this.image.Image = global::DMZ.UI.Properties.Resources.Trash_25Black;
            this.image.Name = "image";
            this.image.Width = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(74, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Cliente";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCinquenta);
            this.panel1.Controls.Add(this.btnQuinhentos);
            this.panel1.Controls.Add(this.btnMil);
            this.panel1.Controls.Add(this.btnCem);
            this.panel1.Controls.Add(this.btnCincoMil);
            this.panel1.Controls.Add(this.btnDezmil);
            this.panel1.Location = new System.Drawing.Point(590, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 227);
            this.panel1.TabIndex = 70;
            // 
            // btnCinquenta
            // 
            this.btnCinquenta.BackColor = System.Drawing.Color.Maroon;
            this.btnCinquenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinquenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinquenta.ForeColor = System.Drawing.Color.White;
            this.btnCinquenta.Location = new System.Drawing.Point(3, 187);
            this.btnCinquenta.Name = "btnCinquenta";
            this.btnCinquenta.Size = new System.Drawing.Size(176, 36);
            this.btnCinquenta.TabIndex = 37;
            this.btnCinquenta.Text = "50,00";
            this.btnCinquenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCinquenta.UseVisualStyleBackColor = false;
            this.btnCinquenta.Click += new System.EventHandler(this.btnCinquenta_Click);
            // 
            // btnQuinhentos
            // 
            this.btnQuinhentos.BackColor = System.Drawing.Color.Maroon;
            this.btnQuinhentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuinhentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuinhentos.ForeColor = System.Drawing.Color.White;
            this.btnQuinhentos.Location = new System.Drawing.Point(3, 113);
            this.btnQuinhentos.Name = "btnQuinhentos";
            this.btnQuinhentos.Size = new System.Drawing.Size(176, 36);
            this.btnQuinhentos.TabIndex = 36;
            this.btnQuinhentos.Text = "500,00";
            this.btnQuinhentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuinhentos.UseVisualStyleBackColor = false;
            this.btnQuinhentos.Click += new System.EventHandler(this.btnQuinhentos_Click);
            // 
            // btnMil
            // 
            this.btnMil.BackColor = System.Drawing.Color.Maroon;
            this.btnMil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMil.ForeColor = System.Drawing.Color.White;
            this.btnMil.Location = new System.Drawing.Point(3, 76);
            this.btnMil.Name = "btnMil";
            this.btnMil.Size = new System.Drawing.Size(176, 36);
            this.btnMil.TabIndex = 35;
            this.btnMil.Text = "1.000,00";
            this.btnMil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMil.UseVisualStyleBackColor = false;
            this.btnMil.Click += new System.EventHandler(this.btnMil_Click);
            // 
            // btnCem
            // 
            this.btnCem.BackColor = System.Drawing.Color.Maroon;
            this.btnCem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCem.ForeColor = System.Drawing.Color.White;
            this.btnCem.Location = new System.Drawing.Point(3, 150);
            this.btnCem.Name = "btnCem";
            this.btnCem.Size = new System.Drawing.Size(176, 36);
            this.btnCem.TabIndex = 34;
            this.btnCem.Text = "100,00";
            this.btnCem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCem.UseVisualStyleBackColor = false;
            this.btnCem.Click += new System.EventHandler(this.btnCem_Click);
            // 
            // btnCincoMil
            // 
            this.btnCincoMil.BackColor = System.Drawing.Color.Maroon;
            this.btnCincoMil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCincoMil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCincoMil.ForeColor = System.Drawing.Color.White;
            this.btnCincoMil.Location = new System.Drawing.Point(3, 39);
            this.btnCincoMil.Name = "btnCincoMil";
            this.btnCincoMil.Size = new System.Drawing.Size(176, 36);
            this.btnCincoMil.TabIndex = 32;
            this.btnCincoMil.Text = "5.000,00";
            this.btnCincoMil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCincoMil.UseVisualStyleBackColor = false;
            this.btnCincoMil.Click += new System.EventHandler(this.btnCincoMil_Click);
            // 
            // btnDezmil
            // 
            this.btnDezmil.BackColor = System.Drawing.Color.Maroon;
            this.btnDezmil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDezmil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDezmil.ForeColor = System.Drawing.Color.White;
            this.btnDezmil.Location = new System.Drawing.Point(3, 3);
            this.btnDezmil.Name = "btnDezmil";
            this.btnDezmil.Size = new System.Drawing.Size(176, 36);
            this.btnDezmil.TabIndex = 31;
            this.btnDezmil.Text = "10.000,00";
            this.btnDezmil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDezmil.UseVisualStyleBackColor = false;
            this.btnDezmil.Click += new System.EventHandler(this.btnDezmil_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btC);
            this.panel5.Controls.Add(this.btD);
            this.panel5.Controls.Add(this.b0);
            this.panel5.Controls.Add(this.b9);
            this.panel5.Controls.Add(this.b8);
            this.panel5.Controls.Add(this.b7);
            this.panel5.Controls.Add(this.b6);
            this.panel5.Controls.Add(this.b5);
            this.panel5.Controls.Add(this.b4);
            this.panel5.Controls.Add(this.b3);
            this.panel5.Controls.Add(this.b2);
            this.panel5.Controls.Add(this.b1);
            this.panel5.Location = new System.Drawing.Point(589, 335);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(186, 185);
            this.panel5.TabIndex = 71;
            // 
            // btC
            // 
            this.btC.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.ForeColor = System.Drawing.Color.White;
            this.btC.Location = new System.Drawing.Point(66, 137);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(57, 43);
            this.btC.TabIndex = 49;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = false;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btD
            // 
            this.btD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btD.ForeColor = System.Drawing.Color.White;
            this.btD.Location = new System.Drawing.Point(5, 137);
            this.btD.Name = "btD";
            this.btD.Size = new System.Drawing.Size(57, 43);
            this.btD.TabIndex = 48;
            this.btD.Text = "A";
            this.btD.UseVisualStyleBackColor = false;
            this.btD.Click += new System.EventHandler(this.btD_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.Maroon;
            this.b0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.ForeColor = System.Drawing.Color.White;
            this.b0.Location = new System.Drawing.Point(127, 137);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(57, 43);
            this.b0.TabIndex = 47;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.Maroon;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.ForeColor = System.Drawing.Color.White;
            this.b9.Location = new System.Drawing.Point(127, 93);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(57, 43);
            this.b9.TabIndex = 46;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.Maroon;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.ForeColor = System.Drawing.Color.White;
            this.b8.Location = new System.Drawing.Point(66, 93);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(57, 43);
            this.b8.TabIndex = 45;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.Maroon;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.ForeColor = System.Drawing.Color.White;
            this.b7.Location = new System.Drawing.Point(5, 93);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(57, 43);
            this.b7.TabIndex = 44;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.Maroon;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.ForeColor = System.Drawing.Color.White;
            this.b6.Location = new System.Drawing.Point(127, 48);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(57, 43);
            this.b6.TabIndex = 43;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.Maroon;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.ForeColor = System.Drawing.Color.White;
            this.b5.Location = new System.Drawing.Point(66, 48);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(57, 43);
            this.b5.TabIndex = 42;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Maroon;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.ForeColor = System.Drawing.Color.White;
            this.b4.Location = new System.Drawing.Point(5, 48);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(57, 43);
            this.b4.TabIndex = 41;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Maroon;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.ForeColor = System.Drawing.Color.White;
            this.b3.Location = new System.Drawing.Point(127, 3);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(57, 43);
            this.b3.TabIndex = 40;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Maroon;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.Color.White;
            this.b2.Location = new System.Drawing.Point(66, 3);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(57, 43);
            this.b2.TabIndex = 39;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Maroon;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.Color.White;
            this.b1.Location = new System.Drawing.Point(5, 3);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(57, 43);
            this.b1.TabIndex = 38;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // tbCliente
            // 
            this.tbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCliente.BackColor = System.Drawing.SystemColors.Control;
            this.tbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCliente.Enabled = false;
            this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(143, 42);
            this.tbCliente.Multiline = true;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(429, 26);
            this.tbCliente.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(20, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Valor a pagar";
            // 
            // tbDivida
            // 
            this.tbDivida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDivida.BackColor = System.Drawing.SystemColors.Control;
            this.tbDivida.Enabled = false;
            this.tbDivida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDivida.Location = new System.Drawing.Point(143, 75);
            this.tbDivida.Multiline = true;
            this.tbDivida.Name = "tbDivida";
            this.tbDivida.Size = new System.Drawing.Size(429, 28);
            this.tbDivida.TabIndex = 74;
            this.tbDivida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAceitar
            // 
            this.btnAceitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnAceitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAceitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceitar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAceitar.Image = global::DMZ.UI.Properties.Resources.Transaction_28px;
            this.btnAceitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceitar.Location = new System.Drawing.Point(417, 454);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(155, 65);
            this.btnAceitar.TabIndex = 75;
            this.btnAceitar.Text = "Finalizar (F10)";
            this.btnAceitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceitar.UseVisualStyleBackColor = false;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // tbPago
            // 
            this.tbPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPago.BackColor = System.Drawing.SystemColors.Control;
            this.tbPago.Enabled = false;
            this.tbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPago.Location = new System.Drawing.Point(70, 456);
            this.tbPago.Multiline = true;
            this.tbPago.Name = "tbPago";
            this.tbPago.Size = new System.Drawing.Size(341, 28);
            this.tbPago.TabIndex = 76;
            this.tbPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(1, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 77;
            this.label2.Text = "Trocos";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(3, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 78;
            this.label6.Text = "Pago";
            // 
            // tbTroco
            // 
            this.tbTroco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTroco.BackColor = System.Drawing.SystemColors.Control;
            this.tbTroco.Enabled = false;
            this.tbTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTroco.Location = new System.Drawing.Point(70, 492);
            this.tbTroco.Multiline = true;
            this.tbTroco.Name = "tbTroco";
            this.tbTroco.Size = new System.Drawing.Size(341, 28);
            this.tbTroco.TabIndex = 79;
            this.tbTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbImprimir
            // 
            this.cbImprimir.BackColor = System.Drawing.Color.Transparent;
            this.cbImprimir.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbImprimir.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbImprimir.CbFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImprimir.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbImprimir.CbText = "Imprimir";
            this.cbImprimir.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbImprimir.Imagem = ((System.Drawing.Image)(resources.GetObject("cbImprimir.Imagem")));
            this.cbImprimir.IsOptionGroup = false;
            this.cbImprimir.IsReadOnly = false;
            this.cbImprimir.IsRequered = false;
            this.cbImprimir.Location = new System.Drawing.Point(3, 22);
            this.cbImprimir.Name = "cbImprimir";
            this.cbImprimir.OnlyCheckBox = true;
            this.cbImprimir.Size = new System.Drawing.Size(83, 22);
            this.cbImprimir.TabIndex = 80;
            this.cbImprimir.Value = null;
            this.cbImprimir.Value2 = null;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.cbA5);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbA4);
            this.panel2.Controls.Add(this.cbPOS);
            this.panel2.Controls.Add(this.cbImprimir);
            this.panel2.Location = new System.Drawing.Point(12, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 79);
            this.panel2.TabIndex = 81;
            // 
            // cbA5
            // 
            this.cbA5.BackColor = System.Drawing.Color.Transparent;
            this.cbA5.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbA5.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbA5.CbFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbA5.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbA5.CbText = "A5";
            this.cbA5.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbA5.Imagem = ((System.Drawing.Image)(resources.GetObject("cbA5.Imagem")));
            this.cbA5.IsOptionGroup = false;
            this.cbA5.IsReadOnly = false;
            this.cbA5.IsRequered = false;
            this.cbA5.Location = new System.Drawing.Point(151, 22);
            this.cbA5.Name = "cbA5";
            this.cbA5.OnlyCheckBox = true;
            this.cbA5.Size = new System.Drawing.Size(47, 22);
            this.cbA5.TabIndex = 110;
            this.cbA5.Value = null;
            this.cbA5.Value2 = null;
            this.cbA5.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbA5_CheckedChangeds);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(264, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 21);
            this.comboBox1.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(263, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 109;
            this.label3.Text = "Impressora";
            // 
            // cbA4
            // 
            this.cbA4.BackColor = System.Drawing.Color.Transparent;
            this.cbA4.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbA4.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbA4.CbFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbA4.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbA4.CbText = "A4";
            this.cbA4.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbA4.Imagem = ((System.Drawing.Image)(resources.GetObject("cbA4.Imagem")));
            this.cbA4.IsOptionGroup = false;
            this.cbA4.IsReadOnly = false;
            this.cbA4.IsRequered = false;
            this.cbA4.Location = new System.Drawing.Point(201, 22);
            this.cbA4.Name = "cbA4";
            this.cbA4.OnlyCheckBox = true;
            this.cbA4.Size = new System.Drawing.Size(47, 22);
            this.cbA4.TabIndex = 83;
            this.cbA4.Value = null;
            this.cbA4.Value2 = null;
            this.cbA4.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbA4_CheckedChangeds);
            // 
            // cbPOS
            // 
            this.cbPOS.BackColor = System.Drawing.Color.Transparent;
            this.cbPOS.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPOS.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPOS.CbFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPOS.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbPOS.CbText = "POS";
            this.cbPOS.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPOS.Imagem = ((System.Drawing.Image)(resources.GetObject("cbPOS.Imagem")));
            this.cbPOS.IsOptionGroup = false;
            this.cbPOS.IsReadOnly = false;
            this.cbPOS.IsRequered = false;
            this.cbPOS.Location = new System.Drawing.Point(92, 22);
            this.cbPOS.Name = "cbPOS";
            this.cbPOS.OnlyCheckBox = true;
            this.cbPOS.Size = new System.Drawing.Size(56, 22);
            this.cbPOS.TabIndex = 81;
            this.cbPOS.Value = null;
            this.cbPOS.Value2 = null;
            this.cbPOS.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbPOS_CheckedChangeds);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 522);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 5);
            this.panel3.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(592, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "Nº Cópias";
            // 
            // NrCopias
            // 
            this.NrCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrCopias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.NrCopias.Location = new System.Drawing.Point(592, 77);
            this.NrCopias.Name = "NrCopias";
            this.NrCopias.Size = new System.Drawing.Size(105, 22);
            this.NrCopias.TabIndex = 106;
            this.NrCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(264, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(290, 21);
            this.comboBox2.TabIndex = 111;
            // 
            // FrmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(777, 527);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NrCopias);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbTroco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPago);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.tbDivida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel7);
            this.Name = "FrmPagamentos";
            this.Text = "Formas de pagamento";
            this.Load += new System.EventHandler(this.FrmPagamentos_Load);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.tbCliente, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbDivida, 0);
            this.Controls.SetChildIndex(this.btnAceitar, 0);
            this.Controls.SetChildIndex(this.tbPago, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbTroco, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.NrCopias, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NrCopias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private Generic.GridUi gridUi1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuinhentos;
        private System.Windows.Forms.Button btnMil;
        private System.Windows.Forms.Button btnCem;
        private System.Windows.Forms.Button btnCincoMil;
        private System.Windows.Forms.Button btnDezmil;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btD;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        public System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbDivida;
        public System.Windows.Forms.Button btnAceitar;
        public System.Windows.Forms.TextBox tbPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbTroco;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.Button btnCinquenta;
        public System.Windows.Forms.Panel panel2;
        private UC.CbDefault cbA4;
        public UC.CbDefault cbImprimir;
        public UC.CbDefault cbPOS;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private UC.CbDefault cbA5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NrCopias;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
