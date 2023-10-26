namespace DMZ.UI.UI
{
    partial class FrmAgruparmesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgruparmesas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMF = new System.Windows.Forms.TabPage();
            this.Cliente = new DMZ.UI.UC.Procura();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.gridMesasF = new DMZ.UI.Generic.GridUi();
            this.tbProcuraMF = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesasF)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(600, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(573, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.Text = "Agrupar mesas ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 497);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageMF);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 453);
            this.tabControl1.TabIndex = 96;
            // 
            // tabPageMF
            // 
            this.tabPageMF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageMF.Controls.Add(this.Cliente);
            this.tabPageMF.Controls.Add(this.barraText1);
            this.tabPageMF.Controls.Add(this.gridMesasF);
            this.tabPageMF.Controls.Add(this.tbProcuraMF);
            this.tabPageMF.Location = new System.Drawing.Point(4, 22);
            this.tabPageMF.Name = "tabPageMF";
            this.tabPageMF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMF.Size = new System.Drawing.Size(581, 427);
            this.tabPageMF.TabIndex = 0;
            this.tabPageMF.Text = "tabPage1";
            this.tabPageMF.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cliente.AutoComplete = false;
            this.Cliente.BackColor = System.Drawing.Color.Transparent;
            this.Cliente.Campo = null;
            this.Cliente.Campo1 = null;
            this.Cliente.CampoStatus = false;
            this.Cliente.ColunaCodigo = "Código";
            this.Cliente.ColunaDescricao = "Descrição";
            this.Cliente.Condicao = "DeficilCobrar=0";
            this.Cliente.DependDescricao = null;
            this.Cliente.Dependente = false;
            this.Cliente.DependenteNome = null;
            this.Cliente.Descname = "nome";
            this.Cliente.EnableTb1Field = true;
            this.Cliente.ExecMetodo = false;
            this.Cliente.FormName = "FrmCL";
            this.Cliente.HideFirstColumn = true;
            this.Cliente.InserirNovo = false;
            this.Cliente.InvertColuna = false;
            this.Cliente.IsLocaDs = false;
            this.Cliente.IsRequered = true;
            this.Cliente.IsSqlSelect = true;
            this.Cliente.Istatus = false;
            this.Cliente.IsUnique = false;
            this.Cliente.Items = null;
            this.Cliente.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cliente.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Cliente.Label1Text = "Mesa Virtual";
            this.Cliente.Location = new System.Drawing.Point(1, 3);
            this.Cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cliente.MultDocumento = false;
            this.Cliente.Name = "Cliente";
            this.Cliente.OpenInfo = false;
            this.Cliente.ParentFormName = null;
            this.Cliente.Pp = null;
            this.Cliente.ReturnDt = false;
            this.Cliente.Selecionado = "no,nome";
            this.Cliente.ShowThirdColumn = false;
            this.Cliente.Size = new System.Drawing.Size(589, 39);
            this.Cliente.SqlComandText = "Select clstamp,UPPER(nome) as nome from cl where Mesavirtual=1 order by Convert(d" +
    "ecimal,no)";
            this.Cliente.Tabela = "cl";
            this.Cliente.TabIndex = 119;
            this.Cliente.TbCkUpdate = false;
            this.Cliente.TbClear = false;
            this.Cliente.TbUpDate = null;
            this.Cliente.Text2 = null;
            this.Cliente.Text3 = null;
            this.Cliente.Text4 = null;
            this.Cliente.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.Cliente.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.Cliente.Titulo = "Procurar";
            this.Cliente.TmpFound = null;
            this.Cliente.UpdateTextBox = null;
            this.Cliente.Value = "nome";
            this.Cliente.Value2 = "";
            this.Cliente.Value3 = "";
            this.Cliente.Value4 = null;
            this.Cliente.Load += new System.EventHandler(this.Cliente_Load);
            // 
            // barraText1
            // 
            this.barraText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.White;
            this.barraText1.Label1Text = "Mesas Físicas";
            this.barraText1.Location = new System.Drawing.Point(1, 45);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(576, 30);
            this.barraText1.TabIndex = 77;
            // 
            // gridMesasF
            // 
            this.gridMesasF.AddButtons = false;
            this.gridMesasF.AllowUserToAddRows = false;
            this.gridMesasF.AllowUserToDeleteRows = false;
            this.gridMesasF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMesasF.AutoIncrimento = false;
            this.gridMesasF.BackgroundColor = System.Drawing.Color.Ivory;
            this.gridMesasF.CampoCodigo = "";
            this.gridMesasF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridMesasF.Codigo = "";
            this.gridMesasF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMesasF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMesasF.ColumnHeadersHeight = 30;
            this.gridMesasF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMesasF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.valor,
            this.ok,
            this.clstamp});
            this.gridMesasF.Condicao = null;
            this.gridMesasF.CorPreto = false;
            this.gridMesasF.CurrentColumnName = null;
            this.gridMesasF.DefacolumnName = null;
            this.gridMesasF.DellGridRow = null;
            this.gridMesasF.DtDS = null;
            this.gridMesasF.EnableHeadersVisualStyles = false;
            this.gridMesasF.GenerateColumns = false;
            this.gridMesasF.GridColor = System.Drawing.Color.SlateGray;
            this.gridMesasF.GridFilha = false;
            this.gridMesasF.GridFilhaSecundaria = false;
            this.gridMesasF.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridMesasF.HeadersHeight = 30;
            this.gridMesasF.HeadersVisible = false;
            this.gridMesasF.Location = new System.Drawing.Point(4, 102);
            this.gridMesasF.Name = "gridMesasF";
            this.gridMesasF.OrderbyCampos = null;
            this.gridMesasF.Origem = null;
            this.gridMesasF.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridMesasF.RowHeadersVisible = false;
            this.gridMesasF.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridMesasF.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridMesasF.RowTemplate.Height = 32;
            this.gridMesasF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMesasF.Size = new System.Drawing.Size(571, 319);
            this.gridMesasF.StampCabecalho = "";
            this.gridMesasF.StampLocal = "";
            this.gridMesasF.TabelaSql = "";
            this.gridMesasF.TabIndex = 75;
            this.gridMesasF.TbCodigo = "";
            // 
            // tbProcuraMF
            // 
            this.tbProcuraMF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProcuraMF.BackColor = System.Drawing.Color.Snow;
            this.tbProcuraMF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProcuraMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProcuraMF.Location = new System.Drawing.Point(3, 76);
            this.tbProcuraMF.Multiline = true;
            this.tbProcuraMF.Name = "tbProcuraMF";
            this.tbProcuraMF.Size = new System.Drawing.Size(571, 25);
            this.tbProcuraMF.TabIndex = 93;
            this.tbProcuraMF.TextChanged += new System.EventHandler(this.tbProcuraMF_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnProcessar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 36);
            this.panel2.TabIndex = 79;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessar.FlatAppearance.BorderSize = 0;
            this.btnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.Location = new System.Drawing.Point(469, 2);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(116, 30);
            this.btnProcessar.TabIndex = 56;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 537);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(601, 5);
            this.panel7.TabIndex = 101;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.nome.HeaderText = "Mesa";
            this.nome.Name = "nome";
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.Visible = false;
            // 
            // ok
            // 
            this.ok.DataPropertyName = "ok";
            this.ok.HeaderText = "  ....";
            this.ok.Name = "ok";
            this.ok.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ok.Width = 40;
            // 
            // clstamp
            // 
            this.clstamp.DataPropertyName = "clstamp";
            this.clstamp.HeaderText = "clstamp";
            this.clstamp.Name = "clstamp";
            this.clstamp.Visible = false;
            // 
            // FrmAgruparmesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(601, 542);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAgruparmesas";
            this.Load += new System.EventHandler(this.FrmAgruparmesas_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMF.ResumeLayout(false);
            this.tabPageMF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesasF)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UC.BarraText barraText1;
        private Generic.GridUi gridMesasF;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.TextBox tbProcuraMF;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMF;
        public UC.Procura Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn clstamp;
    }
}
