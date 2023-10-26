namespace DMZ.UI.UI
{
    partial class FrmRelatorios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XX = new DMZ.UI.Generic.TextAndImageColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCcusto = new DMZ.UI.UC.Procura();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelFiltro = new System.Windows.Forms.FlowLayoutPanel();
            this.Moeda = new DMZ.UI.UC.Procura();
            this.tbCliente = new DMZ.UI.UC.Procura();
            this.tbPj = new DMZ.UI.UC.Procura();
            this.Formasp = new DMZ.UI.UC.Procura();
            this.tbTurma = new DMZ.UI.UC.Procura();
            this.Tesouraria = new DMZ.UI.UC.Procura();
            this.Process = new DMZ.UI.UC.Procura();
            this.tbPlano = new DMZ.UI.UC.Procura();
            this.tbEtapa = new DMZ.UI.UC.Procura();
            this.tbDisciplina = new DMZ.UI.UC.Procura();
            this.tbAnosem = new DMZ.UI.UC.Procura();
            this.tbProf = new DMZ.UI.UC.Procura();
            this.tbCurso = new DMZ.UI.UC.Procura();
            this.tbUsr = new DMZ.UI.UC.Procura();
            this.dmzData1 = new DMZ.UI.UC.DMZData();
            this.dmzEntreAnos1 = new DMZ.UI.UC.DmzEntreAnos();
            this.dmzDdN1 = new DMZ.UI.UC.DmzDdN();
            this.dmzEntreDatas1 = new DMZ.UI.UC.DMZEntreDatas();
            this.tbCorredor = new DMZ.UI.UC.Procura();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntpm = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageMapa = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gridUiMapa = new DMZ.UI.Generic.GridUi();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbCarreira = new DMZ.UI.UC.Procura();
            this.tbSentido = new DMZ.UI.UC.Procura();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelFiltro.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Size = new System.Drawing.Size(793, 26);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnRefresh, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(766, 1);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.Text = "Relatórios";
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            this.gridUi1.AllowUserToDeleteRows = false;
            this.gridUi1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.Color.Beige;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.XX,
            this.Descricao});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUi1.GridFilha = false;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(8, 7);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.ReadOnly = true;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            this.gridUi1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUi1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi1.Size = new System.Drawing.Size(406, 441);
            this.gridUi1.StampCabecalho = null;
            this.gridUi1.StampLocal = null;
            this.gridUi1.TabelaSql = null;
            this.gridUi1.TabIndex = 0;
            this.gridUi1.TbCodigo = null;
            this.gridUi1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellClick);
            this.gridUi1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellContentClick);
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numero.DefaultCellStyle = dataGridViewCellStyle2;
            this.numero.HeaderText = ".....";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Visible = false;
            this.numero.Width = 40;
            // 
            // XX
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.XX.DefaultCellStyle = dataGridViewCellStyle3;
            this.XX.HeaderText = "....";
            this.XX.Image = global::DMZ.UI.Properties.Resources.Add_Property_22px;
            this.XX.Name = "XX";
            this.XX.ReadOnly = true;
            this.XX.Width = 25;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "descricao";
            this.Descricao.HeaderText = "RELATÓRIOS";
            this.Descricao.MinimumWidth = 300;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // tbCcusto
            // 
            this.tbCcusto.AutoComplete = false;
            this.tbCcusto.Campo = null;
            this.tbCcusto.Campo1 = null;
            this.tbCcusto.CampoStatus = false;
            this.tbCcusto.ColunaCodigo = "Código";
            this.tbCcusto.ColunaDescricao = "Descrição";
            this.tbCcusto.Condicao = "";
            this.tbCcusto.DependDescricao = null;
            this.tbCcusto.Dependente = false;
            this.tbCcusto.DependenteNome = null;
            this.tbCcusto.Descname = null;
            this.tbCcusto.EnableTb1Field = false;
            this.tbCcusto.ExecMetodo = false;
            this.tbCcusto.FormName = null;
            this.tbCcusto.HideFirstColumn = false;
            this.tbCcusto.InserirNovo = false;
            this.tbCcusto.InvertColuna = false;
            this.tbCcusto.IsLocaDs = false;
            this.tbCcusto.IsRequered = false;
            this.tbCcusto.IsSqlSelect = true;
            this.tbCcusto.Istatus = false;
            this.tbCcusto.IsUnique = false;
            this.tbCcusto.Items = null;
            this.tbCcusto.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCcusto.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCcusto.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCcusto.Label1Text = "Centro de Custo";
            this.tbCcusto.Location = new System.Drawing.Point(3, 3);
            this.tbCcusto.MultDocumento = false;
            this.tbCcusto.Name = "tbCcusto";
            this.tbCcusto.OpenInfo = false;
            this.tbCcusto.ParentFormName = null;
            this.tbCcusto.Pp = null;
            this.tbCcusto.ReturnDt = false;
            this.tbCcusto.Selecionado = "";
            this.tbCcusto.ShowThirdColumn = false;
            this.tbCcusto.Size = new System.Drawing.Size(327, 40);
            this.tbCcusto.SqlComandText = "\r\nselect Ccustamp,Descricao from ccu ";
            this.tbCcusto.Tabela = "";
            this.tbCcusto.TabIndex = 78;
            this.tbCcusto.TbCkUpdate = false;
            this.tbCcusto.TbClear = false;
            this.tbCcusto.TbUpDate = null;
            this.tbCcusto.Text2 = null;
            this.tbCcusto.Text3 = null;
            this.tbCcusto.Text4 = null;
            this.tbCcusto.Text5 = null;
            this.tbCcusto.Text6 = null;
            this.tbCcusto.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbCcusto.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCcusto.Titulo = "Procurar";
            this.tbCcusto.TmpFound = null;
            this.tbCcusto.UpdateTextBox = null;
            this.tbCcusto.Value = "";
            this.tbCcusto.Value2 = "";
            this.tbCcusto.Value3 = null;
            this.tbCcusto.Value4 = null;
            this.tbCcusto.Value5 = null;
            this.tbCcusto.Value6 = null;
            this.tbCcusto.Values = new string[] {
        ""};
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessar.FlatAppearance.BorderSize = 0;
            this.btnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.Location = new System.Drawing.Point(672, -1);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(110, 38);
            this.btnProcessar.TabIndex = 66;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Location = new System.Drawing.Point(418, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 29);
            this.panel1.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(84, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "OPÇÕES DO RELATÓRIO";
            // 
            // PanelFiltro
            // 
            this.PanelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFiltro.AutoScroll = true;
            this.PanelFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFiltro.Controls.Add(this.tbCcusto);
            this.PanelFiltro.Controls.Add(this.Moeda);
            this.PanelFiltro.Controls.Add(this.tbCliente);
            this.PanelFiltro.Controls.Add(this.tbPj);
            this.PanelFiltro.Controls.Add(this.Formasp);
            this.PanelFiltro.Controls.Add(this.tbTurma);
            this.PanelFiltro.Controls.Add(this.Tesouraria);
            this.PanelFiltro.Controls.Add(this.Process);
            this.PanelFiltro.Controls.Add(this.tbPlano);
            this.PanelFiltro.Controls.Add(this.tbEtapa);
            this.PanelFiltro.Controls.Add(this.tbDisciplina);
            this.PanelFiltro.Controls.Add(this.tbAnosem);
            this.PanelFiltro.Controls.Add(this.tbProf);
            this.PanelFiltro.Controls.Add(this.tbCurso);
            this.PanelFiltro.Controls.Add(this.tbUsr);
            this.PanelFiltro.Controls.Add(this.dmzData1);
            this.PanelFiltro.Controls.Add(this.dmzEntreAnos1);
            this.PanelFiltro.Controls.Add(this.dmzDdN1);
            this.PanelFiltro.Controls.Add(this.dmzEntreDatas1);
            this.PanelFiltro.Controls.Add(this.tbCorredor);
            this.PanelFiltro.Controls.Add(this.tbCarreira);
            this.PanelFiltro.Controls.Add(this.tbSentido);
            this.PanelFiltro.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelFiltro.Location = new System.Drawing.Point(418, 35);
            this.PanelFiltro.Name = "PanelFiltro";
            this.PanelFiltro.Size = new System.Drawing.Size(345, 413);
            this.PanelFiltro.TabIndex = 81;
            this.PanelFiltro.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFiltro_Paint);
            // 
            // Moeda
            // 
            this.Moeda.AutoComplete = false;
            this.Moeda.Campo = null;
            this.Moeda.Campo1 = null;
            this.Moeda.CampoStatus = false;
            this.Moeda.ColunaCodigo = "Código";
            this.Moeda.ColunaDescricao = "Descrição";
            this.Moeda.Condicao = "";
            this.Moeda.DependDescricao = null;
            this.Moeda.Dependente = false;
            this.Moeda.DependenteNome = null;
            this.Moeda.Descname = null;
            this.Moeda.EnableTb1Field = false;
            this.Moeda.ExecMetodo = false;
            this.Moeda.FormName = null;
            this.Moeda.HideFirstColumn = false;
            this.Moeda.InserirNovo = false;
            this.Moeda.InvertColuna = false;
            this.Moeda.IsLocaDs = false;
            this.Moeda.IsRequered = false;
            this.Moeda.IsSqlSelect = true;
            this.Moeda.Istatus = false;
            this.Moeda.IsUnique = false;
            this.Moeda.Items = null;
            this.Moeda.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Moeda.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moeda.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Moeda.Label1Text = "Moeda";
            this.Moeda.Location = new System.Drawing.Point(3, 49);
            this.Moeda.MultDocumento = false;
            this.Moeda.Name = "Moeda";
            this.Moeda.OpenInfo = false;
            this.Moeda.ParentFormName = null;
            this.Moeda.Pp = null;
            this.Moeda.ReturnDt = false;
            this.Moeda.Selecionado = "";
            this.Moeda.ShowThirdColumn = false;
            this.Moeda.Size = new System.Drawing.Size(327, 40);
            this.Moeda.SqlComandText = "select Descricao,moeda from moedas ";
            this.Moeda.Tabela = "";
            this.Moeda.TabIndex = 79;
            this.Moeda.TbCkUpdate = false;
            this.Moeda.TbClear = false;
            this.Moeda.TbUpDate = null;
            this.Moeda.Text2 = null;
            this.Moeda.Text3 = null;
            this.Moeda.Text4 = null;
            this.Moeda.Text5 = null;
            this.Moeda.Text6 = null;
            this.Moeda.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.Moeda.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.Moeda.Titulo = "Procurar";
            this.Moeda.TmpFound = null;
            this.Moeda.UpdateTextBox = null;
            this.Moeda.Value = "";
            this.Moeda.Value2 = "";
            this.Moeda.Value3 = null;
            this.Moeda.Value4 = null;
            this.Moeda.Value5 = null;
            this.Moeda.Value6 = null;
            this.Moeda.Values = new string[] {
        ""};
            // 
            // tbCliente
            // 
            this.tbCliente.AutoComplete = false;
            this.tbCliente.Campo = null;
            this.tbCliente.Campo1 = null;
            this.tbCliente.CampoStatus = false;
            this.tbCliente.ColunaCodigo = "Código";
            this.tbCliente.ColunaDescricao = "Descrição";
            this.tbCliente.Condicao = "";
            this.tbCliente.DependDescricao = null;
            this.tbCliente.Dependente = false;
            this.tbCliente.DependenteNome = null;
            this.tbCliente.Descname = null;
            this.tbCliente.EnableTb1Field = false;
            this.tbCliente.ExecMetodo = false;
            this.tbCliente.FormName = null;
            this.tbCliente.HideFirstColumn = false;
            this.tbCliente.InserirNovo = false;
            this.tbCliente.InvertColuna = false;
            this.tbCliente.IsLocaDs = false;
            this.tbCliente.IsRequered = false;
            this.tbCliente.IsSqlSelect = true;
            this.tbCliente.Istatus = false;
            this.tbCliente.IsUnique = false;
            this.tbCliente.Items = null;
            this.tbCliente.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCliente.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCliente.Label1Text = "Aluno";
            this.tbCliente.Location = new System.Drawing.Point(3, 95);
            this.tbCliente.MultDocumento = false;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.OpenInfo = false;
            this.tbCliente.ParentFormName = null;
            this.tbCliente.Pp = null;
            this.tbCliente.ReturnDt = false;
            this.tbCliente.Selecionado = "";
            this.tbCliente.ShowThirdColumn = false;
            this.tbCliente.Size = new System.Drawing.Size(327, 40);
            this.tbCliente.SqlComandText = "select Descricao,moeda from moedas ";
            this.tbCliente.Tabela = "";
            this.tbCliente.TabIndex = 80;
            this.tbCliente.TbCkUpdate = false;
            this.tbCliente.TbClear = false;
            this.tbCliente.TbUpDate = null;
            this.tbCliente.Text2 = null;
            this.tbCliente.Text3 = null;
            this.tbCliente.Text4 = null;
            this.tbCliente.Text5 = null;
            this.tbCliente.Text6 = null;
            this.tbCliente.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbCliente.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCliente.Titulo = "Procurar";
            this.tbCliente.TmpFound = null;
            this.tbCliente.UpdateTextBox = null;
            this.tbCliente.Value = "";
            this.tbCliente.Value2 = "";
            this.tbCliente.Value3 = null;
            this.tbCliente.Value4 = null;
            this.tbCliente.Value5 = null;
            this.tbCliente.Value6 = null;
            this.tbCliente.Values = new string[] {
        ""};
            this.tbCliente.Visible = false;
            // 
            // tbPj
            // 
            this.tbPj.AutoComplete = false;
            this.tbPj.Campo = null;
            this.tbPj.Campo1 = null;
            this.tbPj.CampoStatus = false;
            this.tbPj.ColunaCodigo = "Código";
            this.tbPj.ColunaDescricao = "Descrição";
            this.tbPj.Condicao = "";
            this.tbPj.DependDescricao = null;
            this.tbPj.Dependente = false;
            this.tbPj.DependenteNome = null;
            this.tbPj.Descname = null;
            this.tbPj.EnableTb1Field = false;
            this.tbPj.ExecMetodo = false;
            this.tbPj.FormName = null;
            this.tbPj.HideFirstColumn = false;
            this.tbPj.InserirNovo = false;
            this.tbPj.InvertColuna = false;
            this.tbPj.IsLocaDs = false;
            this.tbPj.IsRequered = false;
            this.tbPj.IsSqlSelect = true;
            this.tbPj.Istatus = false;
            this.tbPj.IsUnique = false;
            this.tbPj.Items = null;
            this.tbPj.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPj.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPj.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbPj.Label1Text = "Nível Académico";
            this.tbPj.Location = new System.Drawing.Point(3, 141);
            this.tbPj.MultDocumento = false;
            this.tbPj.Name = "tbPj";
            this.tbPj.OpenInfo = false;
            this.tbPj.ParentFormName = null;
            this.tbPj.Pp = null;
            this.tbPj.ReturnDt = false;
            this.tbPj.Selecionado = "";
            this.tbPj.ShowThirdColumn = false;
            this.tbPj.Size = new System.Drawing.Size(327, 40);
            this.tbPj.SqlComandText = "select descricao  Codigo,descricao from PeAuxiliar where tabela =11 and Descricao" +
    " in (\'Bacharelato\',\'Licenciatura\',\'Mestrado\',\'Doutoramento\') order by codigo\r\n";
            this.tbPj.Tabela = "";
            this.tbPj.TabIndex = 81;
            this.tbPj.TbCkUpdate = false;
            this.tbPj.TbClear = false;
            this.tbPj.TbUpDate = null;
            this.tbPj.Text2 = null;
            this.tbPj.Text3 = null;
            this.tbPj.Text4 = null;
            this.tbPj.Text5 = null;
            this.tbPj.Text6 = null;
            this.tbPj.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbPj.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPj.Titulo = "Procurar";
            this.tbPj.TmpFound = null;
            this.tbPj.UpdateTextBox = null;
            this.tbPj.Value = "";
            this.tbPj.Value2 = "";
            this.tbPj.Value3 = null;
            this.tbPj.Value4 = null;
            this.tbPj.Value5 = null;
            this.tbPj.Value6 = null;
            this.tbPj.Values = new string[] {
        ""};
            this.tbPj.Visible = false;
            // 
            // Formasp
            // 
            this.Formasp.AutoComplete = false;
            this.Formasp.Campo = null;
            this.Formasp.Campo1 = null;
            this.Formasp.CampoStatus = false;
            this.Formasp.ColunaCodigo = "Código";
            this.Formasp.ColunaDescricao = "Descrição";
            this.Formasp.Condicao = "";
            this.Formasp.DependDescricao = null;
            this.Formasp.Dependente = false;
            this.Formasp.DependenteNome = null;
            this.Formasp.Descname = null;
            this.Formasp.EnableTb1Field = false;
            this.Formasp.ExecMetodo = false;
            this.Formasp.FormName = null;
            this.Formasp.HideFirstColumn = false;
            this.Formasp.InserirNovo = false;
            this.Formasp.InvertColuna = false;
            this.Formasp.IsLocaDs = false;
            this.Formasp.IsRequered = false;
            this.Formasp.IsSqlSelect = true;
            this.Formasp.Istatus = false;
            this.Formasp.IsUnique = false;
            this.Formasp.Items = null;
            this.Formasp.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Formasp.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formasp.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Formasp.Label1Text = "Forma de pagamento";
            this.Formasp.Location = new System.Drawing.Point(3, 187);
            this.Formasp.MultDocumento = false;
            this.Formasp.Name = "Formasp";
            this.Formasp.OpenInfo = false;
            this.Formasp.ParentFormName = null;
            this.Formasp.Pp = null;
            this.Formasp.ReturnDt = false;
            this.Formasp.Selecionado = "";
            this.Formasp.ShowThirdColumn = false;
            this.Formasp.Size = new System.Drawing.Size(327, 40);
            this.Formasp.SqlComandText = "select Descricao from Fpagam";
            this.Formasp.Tabela = "";
            this.Formasp.TabIndex = 82;
            this.Formasp.TbCkUpdate = false;
            this.Formasp.TbClear = false;
            this.Formasp.TbUpDate = null;
            this.Formasp.Text2 = null;
            this.Formasp.Text3 = null;
            this.Formasp.Text4 = null;
            this.Formasp.Text5 = null;
            this.Formasp.Text6 = null;
            this.Formasp.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.Formasp.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.Formasp.Titulo = "Procurar";
            this.Formasp.TmpFound = null;
            this.Formasp.UpdateTextBox = null;
            this.Formasp.Value = "";
            this.Formasp.Value2 = "";
            this.Formasp.Value3 = null;
            this.Formasp.Value4 = null;
            this.Formasp.Value5 = null;
            this.Formasp.Value6 = null;
            this.Formasp.Values = new string[] {
        ""};
            this.Formasp.Visible = false;
            // 
            // tbTurma
            // 
            this.tbTurma.AutoComplete = false;
            this.tbTurma.Campo = null;
            this.tbTurma.Campo1 = null;
            this.tbTurma.CampoStatus = false;
            this.tbTurma.ColunaCodigo = "Código";
            this.tbTurma.ColunaDescricao = "Descrição";
            this.tbTurma.Condicao = "";
            this.tbTurma.DependDescricao = null;
            this.tbTurma.Dependente = false;
            this.tbTurma.DependenteNome = null;
            this.tbTurma.Descname = null;
            this.tbTurma.EnableTb1Field = false;
            this.tbTurma.ExecMetodo = false;
            this.tbTurma.FormName = null;
            this.tbTurma.HideFirstColumn = false;
            this.tbTurma.InserirNovo = false;
            this.tbTurma.InvertColuna = false;
            this.tbTurma.IsLocaDs = false;
            this.tbTurma.IsRequered = false;
            this.tbTurma.IsSqlSelect = true;
            this.tbTurma.Istatus = false;
            this.tbTurma.IsUnique = false;
            this.tbTurma.Items = null;
            this.tbTurma.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTurma.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTurma.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbTurma.Label1Text = "Turma";
            this.tbTurma.Location = new System.Drawing.Point(3, 233);
            this.tbTurma.MultDocumento = false;
            this.tbTurma.Name = "tbTurma";
            this.tbTurma.OpenInfo = false;
            this.tbTurma.ParentFormName = null;
            this.tbTurma.Pp = null;
            this.tbTurma.ReturnDt = false;
            this.tbTurma.Selecionado = "";
            this.tbTurma.ShowThirdColumn = false;
            this.tbTurma.Size = new System.Drawing.Size(327, 40);
            this.tbTurma.SqlComandText = "select Turmastamp,Codigo+\' - \'+Descanoaem as Turma from Turma";
            this.tbTurma.Tabela = "";
            this.tbTurma.TabIndex = 94;
            this.tbTurma.TbCkUpdate = false;
            this.tbTurma.TbClear = false;
            this.tbTurma.TbUpDate = null;
            this.tbTurma.Text2 = null;
            this.tbTurma.Text3 = null;
            this.tbTurma.Text4 = null;
            this.tbTurma.Text5 = null;
            this.tbTurma.Text6 = null;
            this.tbTurma.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbTurma.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbTurma.Titulo = "Procurar";
            this.tbTurma.TmpFound = null;
            this.tbTurma.UpdateTextBox = null;
            this.tbTurma.Value = "";
            this.tbTurma.Value2 = "";
            this.tbTurma.Value3 = null;
            this.tbTurma.Value4 = null;
            this.tbTurma.Value5 = null;
            this.tbTurma.Value6 = null;
            this.tbTurma.Values = new string[] {
        ""};
            this.tbTurma.Visible = false;
            // 
            // Tesouraria
            // 
            this.Tesouraria.AutoComplete = false;
            this.Tesouraria.Campo = null;
            this.Tesouraria.Campo1 = null;
            this.Tesouraria.CampoStatus = false;
            this.Tesouraria.ColunaCodigo = "Código";
            this.Tesouraria.ColunaDescricao = "Descrição";
            this.Tesouraria.Condicao = "";
            this.Tesouraria.DependDescricao = null;
            this.Tesouraria.Dependente = false;
            this.Tesouraria.DependenteNome = null;
            this.Tesouraria.Descname = null;
            this.Tesouraria.EnableTb1Field = false;
            this.Tesouraria.ExecMetodo = false;
            this.Tesouraria.FormName = null;
            this.Tesouraria.HideFirstColumn = false;
            this.Tesouraria.InserirNovo = false;
            this.Tesouraria.InvertColuna = false;
            this.Tesouraria.IsLocaDs = false;
            this.Tesouraria.IsRequered = false;
            this.Tesouraria.IsSqlSelect = true;
            this.Tesouraria.Istatus = false;
            this.Tesouraria.IsUnique = false;
            this.Tesouraria.Items = null;
            this.Tesouraria.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tesouraria.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tesouraria.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Tesouraria.Label1Text = "Tesouraria";
            this.Tesouraria.Location = new System.Drawing.Point(3, 279);
            this.Tesouraria.MultDocumento = false;
            this.Tesouraria.Name = "Tesouraria";
            this.Tesouraria.OpenInfo = false;
            this.Tesouraria.ParentFormName = null;
            this.Tesouraria.Pp = null;
            this.Tesouraria.ReturnDt = false;
            this.Tesouraria.Selecionado = "";
            this.Tesouraria.ShowThirdColumn = false;
            this.Tesouraria.Size = new System.Drawing.Size(327, 40);
            this.Tesouraria.SqlComandText = "select * from GetContas()";
            this.Tesouraria.Tabela = "";
            this.Tesouraria.TabIndex = 83;
            this.Tesouraria.TbCkUpdate = false;
            this.Tesouraria.TbClear = false;
            this.Tesouraria.TbUpDate = null;
            this.Tesouraria.Text2 = null;
            this.Tesouraria.Text3 = null;
            this.Tesouraria.Text4 = null;
            this.Tesouraria.Text5 = null;
            this.Tesouraria.Text6 = null;
            this.Tesouraria.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.Tesouraria.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.Tesouraria.Titulo = "Procurar";
            this.Tesouraria.TmpFound = null;
            this.Tesouraria.UpdateTextBox = null;
            this.Tesouraria.Value = "";
            this.Tesouraria.Value2 = "";
            this.Tesouraria.Value3 = null;
            this.Tesouraria.Value4 = null;
            this.Tesouraria.Value5 = null;
            this.Tesouraria.Value6 = null;
            this.Tesouraria.Values = new string[] {
        ""};
            this.Tesouraria.Visible = false;
            // 
            // Process
            // 
            this.Process.AutoComplete = false;
            this.Process.Campo = null;
            this.Process.Campo1 = null;
            this.Process.CampoStatus = false;
            this.Process.ColunaCodigo = "Código";
            this.Process.ColunaDescricao = "Descrição";
            this.Process.Condicao = "";
            this.Process.DependDescricao = null;
            this.Process.Dependente = false;
            this.Process.DependenteNome = null;
            this.Process.Descname = null;
            this.Process.EnableTb1Field = false;
            this.Process.ExecMetodo = false;
            this.Process.FormName = null;
            this.Process.HideFirstColumn = false;
            this.Process.InserirNovo = false;
            this.Process.InvertColuna = false;
            this.Process.IsLocaDs = false;
            this.Process.IsRequered = false;
            this.Process.IsSqlSelect = true;
            this.Process.Istatus = false;
            this.Process.IsUnique = false;
            this.Process.Items = null;
            this.Process.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Process.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Process.Label1Text = "Processamento de salário";
            this.Process.Location = new System.Drawing.Point(3, 325);
            this.Process.MultDocumento = false;
            this.Process.Name = "Process";
            this.Process.OpenInfo = false;
            this.Process.ParentFormName = null;
            this.Process.Pp = null;
            this.Process.ReturnDt = false;
            this.Process.Selecionado = "";
            this.Process.ShowThirdColumn = false;
            this.Process.Size = new System.Drawing.Size(327, 40);
            this.Process.SqlComandText = "select * from GetContas()";
            this.Process.Tabela = "";
            this.Process.TabIndex = 84;
            this.Process.TbCkUpdate = false;
            this.Process.TbClear = false;
            this.Process.TbUpDate = null;
            this.Process.Text2 = null;
            this.Process.Text3 = null;
            this.Process.Text4 = null;
            this.Process.Text5 = null;
            this.Process.Text6 = null;
            this.Process.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.Process.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.Process.Titulo = "Procurar";
            this.Process.TmpFound = null;
            this.Process.UpdateTextBox = null;
            this.Process.Value = "";
            this.Process.Value2 = "";
            this.Process.Value3 = null;
            this.Process.Value4 = null;
            this.Process.Value5 = null;
            this.Process.Value6 = null;
            this.Process.Values = new string[] {
        ""};
            this.Process.Visible = false;
            // 
            // tbPlano
            // 
            this.tbPlano.AutoComplete = false;
            this.tbPlano.Campo = null;
            this.tbPlano.Campo1 = null;
            this.tbPlano.CampoStatus = false;
            this.tbPlano.ColunaCodigo = "Código";
            this.tbPlano.ColunaDescricao = "Descrição";
            this.tbPlano.Condicao = "";
            this.tbPlano.DependDescricao = null;
            this.tbPlano.Dependente = false;
            this.tbPlano.DependenteNome = null;
            this.tbPlano.Descname = null;
            this.tbPlano.EnableTb1Field = false;
            this.tbPlano.ExecMetodo = false;
            this.tbPlano.FormName = null;
            this.tbPlano.HideFirstColumn = false;
            this.tbPlano.InserirNovo = false;
            this.tbPlano.InvertColuna = false;
            this.tbPlano.IsLocaDs = false;
            this.tbPlano.IsRequered = false;
            this.tbPlano.IsSqlSelect = true;
            this.tbPlano.Istatus = false;
            this.tbPlano.IsUnique = false;
            this.tbPlano.Items = null;
            this.tbPlano.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlano.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlano.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbPlano.Label1Text = "Plano Curricular";
            this.tbPlano.Location = new System.Drawing.Point(336, 3);
            this.tbPlano.MultDocumento = false;
            this.tbPlano.Name = "tbPlano";
            this.tbPlano.OpenInfo = false;
            this.tbPlano.ParentFormName = null;
            this.tbPlano.Pp = null;
            this.tbPlano.ReturnDt = false;
            this.tbPlano.Selecionado = "";
            this.tbPlano.ShowThirdColumn = false;
            this.tbPlano.Size = new System.Drawing.Size(327, 40);
            this.tbPlano.SqlComandText = "select Gradestamp,Descricao from Grade";
            this.tbPlano.Tabela = "";
            this.tbPlano.TabIndex = 97;
            this.tbPlano.TbCkUpdate = false;
            this.tbPlano.TbClear = false;
            this.tbPlano.TbUpDate = null;
            this.tbPlano.Text2 = null;
            this.tbPlano.Text3 = null;
            this.tbPlano.Text4 = null;
            this.tbPlano.Text5 = null;
            this.tbPlano.Text6 = null;
            this.tbPlano.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbPlano.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPlano.Titulo = "Procurar";
            this.tbPlano.TmpFound = null;
            this.tbPlano.UpdateTextBox = null;
            this.tbPlano.Value = "";
            this.tbPlano.Value2 = "";
            this.tbPlano.Value3 = null;
            this.tbPlano.Value4 = null;
            this.tbPlano.Value5 = null;
            this.tbPlano.Value6 = null;
            this.tbPlano.Values = new string[] {
        ""};
            this.tbPlano.Visible = false;
            // 
            // tbEtapa
            // 
            this.tbEtapa.AutoComplete = false;
            this.tbEtapa.Campo = null;
            this.tbEtapa.Campo1 = null;
            this.tbEtapa.CampoStatus = false;
            this.tbEtapa.ColunaCodigo = "Código";
            this.tbEtapa.ColunaDescricao = "Descrição";
            this.tbEtapa.Condicao = "";
            this.tbEtapa.DependDescricao = null;
            this.tbEtapa.Dependente = false;
            this.tbEtapa.DependenteNome = null;
            this.tbEtapa.Descname = null;
            this.tbEtapa.EnableTb1Field = false;
            this.tbEtapa.ExecMetodo = false;
            this.tbEtapa.FormName = null;
            this.tbEtapa.HideFirstColumn = false;
            this.tbEtapa.InserirNovo = false;
            this.tbEtapa.InvertColuna = false;
            this.tbEtapa.IsLocaDs = false;
            this.tbEtapa.IsRequered = false;
            this.tbEtapa.IsSqlSelect = true;
            this.tbEtapa.Istatus = false;
            this.tbEtapa.IsUnique = false;
            this.tbEtapa.Items = null;
            this.tbEtapa.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEtapa.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEtapa.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbEtapa.Label1Text = "Etapa ou Semestre";
            this.tbEtapa.Location = new System.Drawing.Point(336, 49);
            this.tbEtapa.MultDocumento = false;
            this.tbEtapa.Name = "tbEtapa";
            this.tbEtapa.OpenInfo = false;
            this.tbEtapa.ParentFormName = null;
            this.tbEtapa.Pp = null;
            this.tbEtapa.ReturnDt = false;
            this.tbEtapa.Selecionado = "";
            this.tbEtapa.ShowThirdColumn = false;
            this.tbEtapa.Size = new System.Drawing.Size(327, 48);
            this.tbEtapa.SqlComandText = "select Semstamp,Codigo from Sem order by Ordem";
            this.tbEtapa.Tabela = "";
            this.tbEtapa.TabIndex = 98;
            this.tbEtapa.TbCkUpdate = false;
            this.tbEtapa.TbClear = false;
            this.tbEtapa.TbUpDate = null;
            this.tbEtapa.Text2 = null;
            this.tbEtapa.Text3 = null;
            this.tbEtapa.Text4 = null;
            this.tbEtapa.Text5 = null;
            this.tbEtapa.Text6 = null;
            this.tbEtapa.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbEtapa.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbEtapa.Titulo = "Procurar";
            this.tbEtapa.TmpFound = null;
            this.tbEtapa.UpdateTextBox = null;
            this.tbEtapa.Value = "";
            this.tbEtapa.Value2 = "";
            this.tbEtapa.Value3 = null;
            this.tbEtapa.Value4 = null;
            this.tbEtapa.Value5 = null;
            this.tbEtapa.Value6 = null;
            this.tbEtapa.Values = new string[] {
        ""};
            this.tbEtapa.Visible = false;
            // 
            // tbDisciplina
            // 
            this.tbDisciplina.AutoComplete = false;
            this.tbDisciplina.Campo = null;
            this.tbDisciplina.Campo1 = null;
            this.tbDisciplina.CampoStatus = false;
            this.tbDisciplina.ColunaCodigo = "Código";
            this.tbDisciplina.ColunaDescricao = "Descrição";
            this.tbDisciplina.Condicao = "";
            this.tbDisciplina.DependDescricao = null;
            this.tbDisciplina.Dependente = false;
            this.tbDisciplina.DependenteNome = null;
            this.tbDisciplina.Descname = null;
            this.tbDisciplina.EnableTb1Field = false;
            this.tbDisciplina.ExecMetodo = false;
            this.tbDisciplina.FormName = null;
            this.tbDisciplina.HideFirstColumn = false;
            this.tbDisciplina.InserirNovo = false;
            this.tbDisciplina.InvertColuna = false;
            this.tbDisciplina.IsLocaDs = false;
            this.tbDisciplina.IsRequered = false;
            this.tbDisciplina.IsSqlSelect = true;
            this.tbDisciplina.Istatus = false;
            this.tbDisciplina.IsUnique = false;
            this.tbDisciplina.Items = null;
            this.tbDisciplina.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDisciplina.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisciplina.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDisciplina.Label1Text = "Disciplina";
            this.tbDisciplina.Location = new System.Drawing.Point(336, 103);
            this.tbDisciplina.MultDocumento = false;
            this.tbDisciplina.Name = "tbDisciplina";
            this.tbDisciplina.OpenInfo = false;
            this.tbDisciplina.ParentFormName = null;
            this.tbDisciplina.Pp = null;
            this.tbDisciplina.ReturnDt = false;
            this.tbDisciplina.Selecionado = "";
            this.tbDisciplina.ShowThirdColumn = false;
            this.tbDisciplina.Size = new System.Drawing.Size(327, 40);
            this.tbDisciplina.SqlComandText = "select Ststamp,Descricao from st ";
            this.tbDisciplina.Tabela = "";
            this.tbDisciplina.TabIndex = 96;
            this.tbDisciplina.TbCkUpdate = false;
            this.tbDisciplina.TbClear = false;
            this.tbDisciplina.TbUpDate = null;
            this.tbDisciplina.Text2 = null;
            this.tbDisciplina.Text3 = null;
            this.tbDisciplina.Text4 = null;
            this.tbDisciplina.Text5 = null;
            this.tbDisciplina.Text6 = null;
            this.tbDisciplina.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDisciplina.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbDisciplina.Titulo = "Procurar";
            this.tbDisciplina.TmpFound = null;
            this.tbDisciplina.UpdateTextBox = null;
            this.tbDisciplina.Value = "";
            this.tbDisciplina.Value2 = "";
            this.tbDisciplina.Value3 = null;
            this.tbDisciplina.Value4 = null;
            this.tbDisciplina.Value5 = null;
            this.tbDisciplina.Value6 = null;
            this.tbDisciplina.Values = new string[] {
        ""};
            this.tbDisciplina.Visible = false;
            // 
            // tbAnosem
            // 
            this.tbAnosem.AutoComplete = false;
            this.tbAnosem.Campo = null;
            this.tbAnosem.Campo1 = null;
            this.tbAnosem.CampoStatus = false;
            this.tbAnosem.ColunaCodigo = "Código";
            this.tbAnosem.ColunaDescricao = "Descrição";
            this.tbAnosem.Condicao = "";
            this.tbAnosem.DependDescricao = null;
            this.tbAnosem.Dependente = false;
            this.tbAnosem.DependenteNome = null;
            this.tbAnosem.Descname = null;
            this.tbAnosem.EnableTb1Field = false;
            this.tbAnosem.ExecMetodo = false;
            this.tbAnosem.FormName = null;
            this.tbAnosem.HideFirstColumn = false;
            this.tbAnosem.InserirNovo = false;
            this.tbAnosem.InvertColuna = false;
            this.tbAnosem.IsLocaDs = false;
            this.tbAnosem.IsRequered = false;
            this.tbAnosem.IsSqlSelect = true;
            this.tbAnosem.Istatus = false;
            this.tbAnosem.IsUnique = false;
            this.tbAnosem.Items = null;
            this.tbAnosem.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnosem.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnosem.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbAnosem.Label1Text = "Ano Semestre";
            this.tbAnosem.Location = new System.Drawing.Point(336, 149);
            this.tbAnosem.MultDocumento = false;
            this.tbAnosem.Name = "tbAnosem";
            this.tbAnosem.OpenInfo = false;
            this.tbAnosem.ParentFormName = null;
            this.tbAnosem.Pp = null;
            this.tbAnosem.ReturnDt = false;
            this.tbAnosem.Selecionado = "";
            this.tbAnosem.ShowThirdColumn = false;
            this.tbAnosem.Size = new System.Drawing.Size(327, 40);
            this.tbAnosem.SqlComandText = "select AnoSemstamp,Codigo from AnoSem";
            this.tbAnosem.Tabela = "";
            this.tbAnosem.TabIndex = 95;
            this.tbAnosem.TbCkUpdate = false;
            this.tbAnosem.TbClear = false;
            this.tbAnosem.TbUpDate = null;
            this.tbAnosem.Text2 = null;
            this.tbAnosem.Text3 = null;
            this.tbAnosem.Text4 = null;
            this.tbAnosem.Text5 = null;
            this.tbAnosem.Text6 = null;
            this.tbAnosem.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbAnosem.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAnosem.Titulo = "Procurar";
            this.tbAnosem.TmpFound = null;
            this.tbAnosem.UpdateTextBox = null;
            this.tbAnosem.Value = "";
            this.tbAnosem.Value2 = "";
            this.tbAnosem.Value3 = null;
            this.tbAnosem.Value4 = null;
            this.tbAnosem.Value5 = null;
            this.tbAnosem.Value6 = null;
            this.tbAnosem.Values = new string[] {
        ""};
            this.tbAnosem.Visible = false;
            // 
            // tbProf
            // 
            this.tbProf.AutoComplete = false;
            this.tbProf.Campo = null;
            this.tbProf.Campo1 = null;
            this.tbProf.CampoStatus = false;
            this.tbProf.ColunaCodigo = "Código";
            this.tbProf.ColunaDescricao = "Descrição";
            this.tbProf.Condicao = "";
            this.tbProf.DependDescricao = null;
            this.tbProf.Dependente = false;
            this.tbProf.DependenteNome = null;
            this.tbProf.Descname = null;
            this.tbProf.EnableTb1Field = false;
            this.tbProf.ExecMetodo = false;
            this.tbProf.FormName = null;
            this.tbProf.HideFirstColumn = false;
            this.tbProf.InserirNovo = false;
            this.tbProf.InvertColuna = false;
            this.tbProf.IsLocaDs = false;
            this.tbProf.IsRequered = false;
            this.tbProf.IsSqlSelect = true;
            this.tbProf.Istatus = false;
            this.tbProf.IsUnique = false;
            this.tbProf.Items = null;
            this.tbProf.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProf.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProf.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbProf.Label1Text = "Professor";
            this.tbProf.Location = new System.Drawing.Point(336, 195);
            this.tbProf.MultDocumento = false;
            this.tbProf.Name = "tbProf";
            this.tbProf.OpenInfo = false;
            this.tbProf.ParentFormName = null;
            this.tbProf.Pp = null;
            this.tbProf.ReturnDt = false;
            this.tbProf.Selecionado = "";
            this.tbProf.ShowThirdColumn = false;
            this.tbProf.Size = new System.Drawing.Size(327, 40);
            this.tbProf.SqlComandText = "select Pestamp,Nome from pe ";
            this.tbProf.Tabela = "";
            this.tbProf.TabIndex = 93;
            this.tbProf.TbCkUpdate = false;
            this.tbProf.TbClear = false;
            this.tbProf.TbUpDate = null;
            this.tbProf.Text2 = null;
            this.tbProf.Text3 = null;
            this.tbProf.Text4 = null;
            this.tbProf.Text5 = null;
            this.tbProf.Text6 = null;
            this.tbProf.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbProf.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbProf.Titulo = "Procurar";
            this.tbProf.TmpFound = null;
            this.tbProf.UpdateTextBox = null;
            this.tbProf.Value = "";
            this.tbProf.Value2 = "";
            this.tbProf.Value3 = null;
            this.tbProf.Value4 = null;
            this.tbProf.Value5 = null;
            this.tbProf.Value6 = null;
            this.tbProf.Values = new string[] {
        ""};
            this.tbProf.Visible = false;
            // 
            // tbCurso
            // 
            this.tbCurso.AutoComplete = false;
            this.tbCurso.Campo = null;
            this.tbCurso.Campo1 = null;
            this.tbCurso.CampoStatus = false;
            this.tbCurso.ColunaCodigo = "Código";
            this.tbCurso.ColunaDescricao = "Descrição";
            this.tbCurso.Condicao = "";
            this.tbCurso.DependDescricao = null;
            this.tbCurso.Dependente = false;
            this.tbCurso.DependenteNome = null;
            this.tbCurso.Descname = null;
            this.tbCurso.EnableTb1Field = false;
            this.tbCurso.ExecMetodo = false;
            this.tbCurso.FormName = null;
            this.tbCurso.HideFirstColumn = false;
            this.tbCurso.InserirNovo = false;
            this.tbCurso.InvertColuna = false;
            this.tbCurso.IsLocaDs = false;
            this.tbCurso.IsRequered = false;
            this.tbCurso.IsSqlSelect = true;
            this.tbCurso.Istatus = false;
            this.tbCurso.IsUnique = false;
            this.tbCurso.Items = null;
            this.tbCurso.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurso.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurso.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCurso.Label1Text = "Curso";
            this.tbCurso.Location = new System.Drawing.Point(336, 241);
            this.tbCurso.MultDocumento = false;
            this.tbCurso.Name = "tbCurso";
            this.tbCurso.OpenInfo = false;
            this.tbCurso.ParentFormName = null;
            this.tbCurso.Pp = null;
            this.tbCurso.ReturnDt = false;
            this.tbCurso.Selecionado = "";
            this.tbCurso.ShowThirdColumn = false;
            this.tbCurso.Size = new System.Drawing.Size(327, 40);
            this.tbCurso.SqlComandText = "select Cursostamp,Desccurso from curso ";
            this.tbCurso.Tabela = "";
            this.tbCurso.TabIndex = 92;
            this.tbCurso.TbCkUpdate = false;
            this.tbCurso.TbClear = false;
            this.tbCurso.TbUpDate = null;
            this.tbCurso.Text2 = null;
            this.tbCurso.Text3 = null;
            this.tbCurso.Text4 = null;
            this.tbCurso.Text5 = null;
            this.tbCurso.Text6 = null;
            this.tbCurso.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbCurso.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCurso.Titulo = "Procurar";
            this.tbCurso.TmpFound = null;
            this.tbCurso.UpdateTextBox = null;
            this.tbCurso.Value = "";
            this.tbCurso.Value2 = "";
            this.tbCurso.Value3 = null;
            this.tbCurso.Value4 = null;
            this.tbCurso.Value5 = null;
            this.tbCurso.Value6 = null;
            this.tbCurso.Values = new string[] {
        ""};
            this.tbCurso.Visible = false;
            // 
            // tbUsr
            // 
            this.tbUsr.AutoComplete = false;
            this.tbUsr.Campo = null;
            this.tbUsr.Campo1 = null;
            this.tbUsr.CampoStatus = false;
            this.tbUsr.ColunaCodigo = "Código";
            this.tbUsr.ColunaDescricao = "Descrição";
            this.tbUsr.Condicao = "";
            this.tbUsr.DependDescricao = null;
            this.tbUsr.Dependente = false;
            this.tbUsr.DependenteNome = null;
            this.tbUsr.Descname = null;
            this.tbUsr.EnableTb1Field = false;
            this.tbUsr.ExecMetodo = false;
            this.tbUsr.FormName = null;
            this.tbUsr.HideFirstColumn = false;
            this.tbUsr.InserirNovo = false;
            this.tbUsr.InvertColuna = false;
            this.tbUsr.IsLocaDs = false;
            this.tbUsr.IsRequered = false;
            this.tbUsr.IsSqlSelect = true;
            this.tbUsr.Istatus = false;
            this.tbUsr.IsUnique = false;
            this.tbUsr.Items = null;
            this.tbUsr.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsr.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsr.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbUsr.Label1Text = "Utilizador";
            this.tbUsr.Location = new System.Drawing.Point(336, 287);
            this.tbUsr.MultDocumento = false;
            this.tbUsr.Name = "tbUsr";
            this.tbUsr.OpenInfo = false;
            this.tbUsr.ParentFormName = null;
            this.tbUsr.Pp = null;
            this.tbUsr.ReturnDt = false;
            this.tbUsr.Selecionado = "";
            this.tbUsr.ShowThirdColumn = false;
            this.tbUsr.Size = new System.Drawing.Size(327, 40);
            this.tbUsr.SqlComandText = " select Usrstamp,Nome from usr ";
            this.tbUsr.Tabela = "";
            this.tbUsr.TabIndex = 87;
            this.tbUsr.TbCkUpdate = false;
            this.tbUsr.TbClear = false;
            this.tbUsr.TbUpDate = null;
            this.tbUsr.Text2 = null;
            this.tbUsr.Text3 = null;
            this.tbUsr.Text4 = null;
            this.tbUsr.Text5 = null;
            this.tbUsr.Text6 = null;
            this.tbUsr.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbUsr.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbUsr.Titulo = "Procurar";
            this.tbUsr.TmpFound = null;
            this.tbUsr.UpdateTextBox = null;
            this.tbUsr.Value = "";
            this.tbUsr.Value2 = "";
            this.tbUsr.Value3 = null;
            this.tbUsr.Value4 = null;
            this.tbUsr.Value5 = null;
            this.tbUsr.Value6 = null;
            this.tbUsr.Values = new string[] {
        ""};
            this.tbUsr.Visible = false;
            // 
            // dmzData1
            // 
            this.dmzData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzData1.Label3Color = System.Drawing.SystemColors.ControlText;
            this.dmzData1.Label3Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dmzData1.Label3Text = "Data";
            this.dmzData1.Location = new System.Drawing.Point(343, 333);
            this.dmzData1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dmzData1.Name = "dmzData1";
            this.dmzData1.Panel1BackColor = System.Drawing.Color.Beige;
            this.dmzData1.Size = new System.Drawing.Size(150, 51);
            this.dmzData1.TabIndex = 90;
            // 
            // dmzEntreAnos1
            // 
            this.dmzEntreAnos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzEntreAnos1.Label3Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzEntreAnos1.Label3Text = "Intervalo de anos ";
            this.dmzEntreAnos1.Location = new System.Drawing.Point(676, 3);
            this.dmzEntreAnos1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dmzEntreAnos1.Name = "dmzEntreAnos1";
            this.dmzEntreAnos1.Panel1BackColor = System.Drawing.Color.WhiteSmoke;
            this.dmzEntreAnos1.Size = new System.Drawing.Size(172, 61);
            this.dmzEntreAnos1.TabIndex = 89;
            // 
            // dmzDdN1
            // 
            this.dmzDdN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzDdN1.DdNTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dmzDdN1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzDdN1.Label1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzDdN1.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzDdN1.Label1TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dmzDdN1.Label3Text = "Ano";
            this.dmzDdN1.Location = new System.Drawing.Point(676, 70);
            this.dmzDdN1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dmzDdN1.Name = "dmzDdN1";
            this.dmzDdN1.Panel1BackColor = System.Drawing.Color.WhiteSmoke;
            this.dmzDdN1.Size = new System.Drawing.Size(150, 51);
            this.dmzDdN1.TabIndex = 86;
            // 
            // dmzEntreDatas1
            // 
            this.dmzEntreDatas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzEntreDatas1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzEntreDatas1.HideShowDt2 = true;
            this.dmzEntreDatas1.Label3Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzEntreDatas1.Label3ForeColor = System.Drawing.SystemColors.ControlText;
            this.dmzEntreDatas1.LabelText = "Entre datas";
            this.dmzEntreDatas1.Location = new System.Drawing.Point(676, 128);
            this.dmzEntreDatas1.Margin = new System.Windows.Forms.Padding(10, 4, 3, 4);
            this.dmzEntreDatas1.Name = "dmzEntreDatas1";
            this.dmzEntreDatas1.Panel1BackColor = System.Drawing.SystemColors.ControlLight;
            this.dmzEntreDatas1.Size = new System.Drawing.Size(174, 70);
            this.dmzEntreDatas1.TabIndex = 99;
            // 
            // tbCorredor
            // 
            this.tbCorredor.AutoComplete = false;
            this.tbCorredor.Campo = null;
            this.tbCorredor.Campo1 = null;
            this.tbCorredor.CampoStatus = false;
            this.tbCorredor.ColunaCodigo = "Código";
            this.tbCorredor.ColunaDescricao = "Descrição";
            this.tbCorredor.Condicao = "";
            this.tbCorredor.DependDescricao = null;
            this.tbCorredor.Dependente = false;
            this.tbCorredor.DependenteNome = null;
            this.tbCorredor.Descname = null;
            this.tbCorredor.EnableTb1Field = false;
            this.tbCorredor.ExecMetodo = false;
            this.tbCorredor.FormName = null;
            this.tbCorredor.HideFirstColumn = false;
            this.tbCorredor.InserirNovo = false;
            this.tbCorredor.InvertColuna = false;
            this.tbCorredor.IsLocaDs = false;
            this.tbCorredor.IsRequered = false;
            this.tbCorredor.IsSqlSelect = true;
            this.tbCorredor.Istatus = false;
            this.tbCorredor.IsUnique = false;
            this.tbCorredor.Items = null;
            this.tbCorredor.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCorredor.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorredor.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCorredor.Label1Text = "Corredor";
            this.tbCorredor.Location = new System.Drawing.Point(669, 205);
            this.tbCorredor.MultDocumento = false;
            this.tbCorredor.Name = "tbCorredor";
            this.tbCorredor.OpenInfo = false;
            this.tbCorredor.ParentFormName = null;
            this.tbCorredor.Pp = null;
            this.tbCorredor.ReturnDt = false;
            this.tbCorredor.Selecionado = "";
            this.tbCorredor.ShowThirdColumn = false;
            this.tbCorredor.Size = new System.Drawing.Size(327, 40);
            this.tbCorredor.SqlComandText = "select Familiastamp,descricao from Familia";
            this.tbCorredor.Tabela = "";
            this.tbCorredor.TabIndex = 100;
            this.tbCorredor.TbCkUpdate = false;
            this.tbCorredor.TbClear = false;
            this.tbCorredor.TbUpDate = null;
            this.tbCorredor.Text2 = null;
            this.tbCorredor.Text3 = null;
            this.tbCorredor.Text4 = null;
            this.tbCorredor.Text5 = null;
            this.tbCorredor.Text6 = null;
            this.tbCorredor.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbCorredor.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCorredor.Titulo = "Procurar";
            this.tbCorredor.TmpFound = null;
            this.tbCorredor.UpdateTextBox = null;
            this.tbCorredor.Value = "";
            this.tbCorredor.Value2 = "";
            this.tbCorredor.Value3 = null;
            this.tbCorredor.Value4 = null;
            this.tbCorredor.Value5 = null;
            this.tbCorredor.Value6 = null;
            this.tbCorredor.Values = new string[] {
        ""};
            this.tbCorredor.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btntpm);
            this.panel2.Controls.Add(this.btnProcessar);
            this.panel2.Location = new System.Drawing.Point(8, 535);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 38);
            this.panel2.TabIndex = 80;
            // 
            // btntpm
            // 
            this.btntpm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btntpm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btntpm.ForeColor = System.Drawing.Color.Goldenrod;
            this.btntpm.Location = new System.Drawing.Point(0, 0);
            this.btntpm.Name = "btntpm";
            this.btntpm.Size = new System.Drawing.Size(73, 36);
            this.btntpm.TabIndex = 67;
            this.btntpm.Text = "Refresh";
            this.btntpm.UseVisualStyleBackColor = false;
            this.btntpm.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRefresh.Image = global::DMZ.UI.Properties.Resources.Refresh_18px;
            this.btnRefresh.Location = new System.Drawing.Point(737, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 21);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageMapa);
            this.tabControl1.Location = new System.Drawing.Point(4, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 478);
            this.tabControl1.TabIndex = 82;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.gridUi1);
            this.tabPage2.Controls.Add(this.PanelFiltro);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Gerais ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageMapa
            // 
            this.tabPageMapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageMapa.Controls.Add(this.btnPrint);
            this.tabPageMapa.Controls.Add(this.button3);
            this.tabPageMapa.Controls.Add(this.btnExcel);
            this.tabPageMapa.Controls.Add(this.button1);
            this.tabPageMapa.Controls.Add(this.gridUiMapa);
            this.tabPageMapa.Location = new System.Drawing.Point(4, 22);
            this.tabPageMapa.Name = "tabPageMapa";
            this.tabPageMapa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMapa.Size = new System.Drawing.Size(780, 452);
            this.tabPageMapa.TabIndex = 2;
            this.tabPageMapa.Text = "Mapa";
            this.tabPageMapa.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.Location = new System.Drawing.Point(467, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 28);
            this.btnPrint.TabIndex = 81;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button3.Image = global::DMZ.UI.Properties.Resources.Edit_Property_22px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(618, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 28);
            this.button3.TabIndex = 69;
            this.button3.Text = "Word";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnExcel.Image = global::DMZ.UI.Properties.Resources.edit_property_21px;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Location = new System.Drawing.Point(538, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(74, 28);
            this.btnExcel.TabIndex = 68;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button1.Image = global::DMZ.UI.Properties.Resources.pdf_22px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(700, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 67;
            this.button1.Text = "PDF";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridUiMapa
            // 
            this.gridUiMapa.AddButtons = false;
            this.gridUiMapa.AllowUserToAddRows = false;
            this.gridUiMapa.AllowUserToDeleteRows = false;
            this.gridUiMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUiMapa.AutoIncrimento = false;
            this.gridUiMapa.BackgroundColor = System.Drawing.Color.Beige;
            this.gridUiMapa.CampoCodigo = null;
            this.gridUiMapa.Codigo = null;
            this.gridUiMapa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUiMapa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridUiMapa.ColumnHeadersHeight = 30;
            this.gridUiMapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUiMapa.Condicao = null;
            this.gridUiMapa.CorPreto = false;
            this.gridUiMapa.CurrentColumnName = null;
            this.gridUiMapa.DefacolumnName = null;
            this.gridUiMapa.DellGridRow = null;
            this.gridUiMapa.DtDS = null;
            this.gridUiMapa.EnableHeadersVisualStyles = false;
            this.gridUiMapa.GenerateColumns = false;
            this.gridUiMapa.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUiMapa.GridFilha = false;
            this.gridUiMapa.GridFilhaSecundaria = false;
            this.gridUiMapa.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUiMapa.HeadersHeight = 30;
            this.gridUiMapa.HeadersVisible = false;
            this.gridUiMapa.Location = new System.Drawing.Point(6, 33);
            this.gridUiMapa.Name = "gridUiMapa";
            this.gridUiMapa.OrderbyCampos = null;
            this.gridUiMapa.Origem = null;
            this.gridUiMapa.ReadOnly = true;
            this.gridUiMapa.RowHeadersVisible = false;
            this.gridUiMapa.RowHeadersWidth = 30;
            this.gridUiMapa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gridUiMapa.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridUiMapa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUiMapa.Size = new System.Drawing.Size(769, 406);
            this.gridUiMapa.StampCabecalho = null;
            this.gridUiMapa.StampLocal = null;
            this.gridUiMapa.TabelaSql = null;
            this.gridUiMapa.TabIndex = 1;
            this.gridUiMapa.TbCodigo = null;
            // 
            // tbCarreira
            // 
            this.tbCarreira.AutoComplete = false;
            this.tbCarreira.Campo = null;
            this.tbCarreira.Campo1 = null;
            this.tbCarreira.CampoStatus = false;
            this.tbCarreira.ColunaCodigo = "Código";
            this.tbCarreira.ColunaDescricao = "Descrição";
            this.tbCarreira.Condicao = "";
            this.tbCarreira.DependDescricao = null;
            this.tbCarreira.Dependente = false;
            this.tbCarreira.DependenteNome = null;
            this.tbCarreira.Descname = null;
            this.tbCarreira.EnableTb1Field = false;
            this.tbCarreira.ExecMetodo = false;
            this.tbCarreira.FormName = null;
            this.tbCarreira.HideFirstColumn = false;
            this.tbCarreira.InserirNovo = false;
            this.tbCarreira.InvertColuna = false;
            this.tbCarreira.IsLocaDs = false;
            this.tbCarreira.IsRequered = false;
            this.tbCarreira.IsSqlSelect = true;
            this.tbCarreira.Istatus = false;
            this.tbCarreira.IsUnique = false;
            this.tbCarreira.Items = null;
            this.tbCarreira.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCarreira.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarreira.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCarreira.Label1Text = "Carreira";
            this.tbCarreira.Location = new System.Drawing.Point(669, 251);
            this.tbCarreira.MultDocumento = false;
            this.tbCarreira.Name = "tbCarreira";
            this.tbCarreira.OpenInfo = false;
            this.tbCarreira.ParentFormName = null;
            this.tbCarreira.Pp = null;
            this.tbCarreira.ReturnDt = false;
            this.tbCarreira.Selecionado = "";
            this.tbCarreira.ShowThirdColumn = false;
            this.tbCarreira.Size = new System.Drawing.Size(327, 40);
            this.tbCarreira.SqlComandText = "select Familiastamp,descricao from Familia";
            this.tbCarreira.Tabela = "";
            this.tbCarreira.TabIndex = 101;
            this.tbCarreira.TbCkUpdate = false;
            this.tbCarreira.TbClear = false;
            this.tbCarreira.TbUpDate = null;
            this.tbCarreira.Text2 = null;
            this.tbCarreira.Text3 = null;
            this.tbCarreira.Text4 = null;
            this.tbCarreira.Text5 = null;
            this.tbCarreira.Text6 = null;
            this.tbCarreira.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbCarreira.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCarreira.Titulo = "Procurar";
            this.tbCarreira.TmpFound = null;
            this.tbCarreira.UpdateTextBox = null;
            this.tbCarreira.Value = "";
            this.tbCarreira.Value2 = "";
            this.tbCarreira.Value3 = null;
            this.tbCarreira.Value4 = null;
            this.tbCarreira.Value5 = null;
            this.tbCarreira.Value6 = null;
            this.tbCarreira.Values = new string[] {
        ""};
            this.tbCarreira.Visible = false;
            // 
            // tbSentido
            // 
            this.tbSentido.AutoComplete = false;
            this.tbSentido.Campo = null;
            this.tbSentido.Campo1 = null;
            this.tbSentido.CampoStatus = false;
            this.tbSentido.ColunaCodigo = "Código";
            this.tbSentido.ColunaDescricao = "Descrição";
            this.tbSentido.Condicao = "";
            this.tbSentido.DependDescricao = null;
            this.tbSentido.Dependente = false;
            this.tbSentido.DependenteNome = null;
            this.tbSentido.Descname = null;
            this.tbSentido.EnableTb1Field = false;
            this.tbSentido.ExecMetodo = false;
            this.tbSentido.FormName = null;
            this.tbSentido.HideFirstColumn = false;
            this.tbSentido.InserirNovo = false;
            this.tbSentido.InvertColuna = false;
            this.tbSentido.IsLocaDs = false;
            this.tbSentido.IsRequered = false;
            this.tbSentido.IsSqlSelect = true;
            this.tbSentido.Istatus = false;
            this.tbSentido.IsUnique = false;
            this.tbSentido.Items = null;
            this.tbSentido.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSentido.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSentido.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbSentido.Label1Text = "Sentido";
            this.tbSentido.Location = new System.Drawing.Point(669, 297);
            this.tbSentido.MultDocumento = false;
            this.tbSentido.Name = "tbSentido";
            this.tbSentido.OpenInfo = false;
            this.tbSentido.ParentFormName = null;
            this.tbSentido.Pp = null;
            this.tbSentido.ReturnDt = false;
            this.tbSentido.Selecionado = "";
            this.tbSentido.ShowThirdColumn = false;
            this.tbSentido.Size = new System.Drawing.Size(327, 40);
            this.tbSentido.SqlComandText = "select Familiastamp,descricao from Familia";
            this.tbSentido.Tabela = "";
            this.tbSentido.TabIndex = 102;
            this.tbSentido.TbCkUpdate = false;
            this.tbSentido.TbClear = false;
            this.tbSentido.TbUpDate = null;
            this.tbSentido.Text2 = null;
            this.tbSentido.Text3 = null;
            this.tbSentido.Text4 = null;
            this.tbSentido.Text5 = null;
            this.tbSentido.Text6 = null;
            this.tbSentido.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbSentido.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSentido.Titulo = "Procurar";
            this.tbSentido.TmpFound = null;
            this.tbSentido.UpdateTextBox = null;
            this.tbSentido.Value = "";
            this.tbSentido.Value2 = "";
            this.tbSentido.Value3 = null;
            this.tbSentido.Value4 = null;
            this.tbSentido.Value5 = null;
            this.tbSentido.Value6 = null;
            this.tbSentido.Values = new string[] {
        ""};
            this.tbSentido.Visible = false;
            // 
            // FrmRelatorios
            // 
            this.AcceptButton = this.btnProcessar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(794, 581);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmRelatorios";
            this.Load += new System.EventHandler(this.FrmRelatorios_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelFiltro.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPageMapa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUiMapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Generic.GridUi gridUi1;
        public System.Windows.Forms.Button btnProcessar;
        private UC.Procura tbCcusto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel PanelFiltro;
        private UC.Procura Moeda;
        private UC.Procura tbCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private Generic.TextAndImageColumn XX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private UC.Procura tbPj;
        private UC.Procura Formasp;
        private UC.Procura Tesouraria;
        public System.Windows.Forms.Button btnRefresh;
        private UC.Procura Process;
        private UC.DmzDdN dmzDdN1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageMapa;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnExcel;
        public System.Windows.Forms.Button button1;
        private Generic.GridUi gridUiMapa;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private UC.Procura tbUsr;
        private UC.DmzEntreAnos dmzEntreAnos1;
        private UC.DMZData dmzData1;
        private UC.Procura tbCurso;
        private UC.Procura tbTurma;
        private UC.Procura tbProf;
        private UC.Procura tbAnosem;
        private UC.Procura tbDisciplina;
        private UC.Procura tbPlano;
        private UC.Procura tbEtapa;
        public System.Windows.Forms.Button btnPrint;
        private UC.DMZEntreDatas dmzEntreDatas1;
        private System.Windows.Forms.Button btntpm;
        private UC.Procura tbCorredor;
        private UC.Procura tbCarreira;
        private UC.Procura tbSentido;
    }
}
