
namespace DMZ.UI.UI
{
    partial class FrmAcessos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcessos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ver = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Intro = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Apagar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Usracessostamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbDefault6 = new DMZ.UI.UC.CbDefault();
            this.cbDefault5 = new DMZ.UI.UC.CbDefault();
            this.cbDefault4 = new DMZ.UI.UC.CbDefault();
            this.cbDefault3 = new DMZ.UI.UC.CbDefault();
            this.cbDefault2 = new DMZ.UI.UC.CbDefault();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.button3 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAddprocess = new System.Windows.Forms.Button();
            this.tbProcura = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbDefault7 = new DMZ.UI.UC.CbDefault();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(811, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(779, 2);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Location = new System.Drawing.Point(129, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 37);
            this.panel1.TabIndex = 25;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(253, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(39, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "USER";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gridUi1);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.panel2.Location = new System.Drawing.Point(2, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 438);
            this.panel2.TabIndex = 27;
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.Color.White;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxColumn,
            this.descricao,
            this.ecran,
            this.sigla,
            this.ver,
            this.Intro,
            this.Alterar,
            this.Apagar,
            this.Anular,
            this.Imprimir,
            this.Usracessostamp});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUi1.GridFilha = true;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(0, 0);
            this.gridUi1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
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
            this.gridUi1.Size = new System.Drawing.Size(809, 436);
            this.gridUi1.StampCabecalho = "Usrstamp";
            this.gridUi1.StampLocal = "Usrmodulostamp";
            this.gridUi1.TabelaSql = "Usrmodulo";
            this.gridUi1.TabIndex = 28;
            this.gridUi1.TbCodigo = null;
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.HeaderText = "....";
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.Width = 30;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 250;
            this.descricao.Name = "descricao";
            // 
            // ecran
            // 
            this.ecran.DataPropertyName = "ecran";
            this.ecran.HeaderText = "Ecran";
            this.ecran.Name = "ecran";
            this.ecran.Width = 60;
            // 
            // sigla
            // 
            this.sigla.DataPropertyName = "Origem";
            this.sigla.HeaderText = "Origem";
            this.sigla.Name = "sigla";
            this.sigla.Width = 60;
            // 
            // ver
            // 
            this.ver.DataPropertyName = "ver";
            this.ver.HeaderText = "Ver";
            this.ver.Name = "ver";
            this.ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ver.Width = 50;
            // 
            // Intro
            // 
            this.Intro.DataPropertyName = "intro";
            this.Intro.HeaderText = "Introd.";
            this.Intro.Name = "Intro";
            this.Intro.Width = 70;
            // 
            // Alterar
            // 
            this.Alterar.DataPropertyName = "altera";
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Name = "Alterar";
            this.Alterar.Width = 60;
            // 
            // Apagar
            // 
            this.Apagar.DataPropertyName = "apaga";
            this.Apagar.HeaderText = "Apagar";
            this.Apagar.Name = "Apagar";
            this.Apagar.Width = 60;
            // 
            // Anular
            // 
            this.Anular.DataPropertyName = "anula";
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.Width = 70;
            // 
            // Imprimir
            // 
            this.Imprimir.DataPropertyName = "imprimir";
            this.Imprimir.HeaderText = "Imprimir";
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Width = 60;
            // 
            // Usracessostamp
            // 
            this.Usracessostamp.DataPropertyName = "Usracessostamp";
            this.Usracessostamp.HeaderText = "Usracessstamp";
            this.Usracessostamp.Name = "Usracessostamp";
            this.Usracessostamp.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbDefault6);
            this.panel3.Controls.Add(this.cbDefault5);
            this.panel3.Controls.Add(this.cbDefault4);
            this.panel3.Controls.Add(this.cbDefault3);
            this.panel3.Controls.Add(this.cbDefault2);
            this.panel3.Controls.Add(this.cbDefault1);
            this.panel3.Location = new System.Drawing.Point(438, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 20);
            this.panel3.TabIndex = 77;
            // 
            // cbDefault6
            // 
            this.cbDefault6.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault6.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault6.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault6.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault6.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault6.CbText = "checkBox2";
            this.cbDefault6.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault6.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault6.Imagem")));
            this.cbDefault6.IsOptionGroup = false;
            this.cbDefault6.IsReadOnly = false;
            this.cbDefault6.IsRequered = false;
            this.cbDefault6.Location = new System.Drawing.Point(323, 0);
            this.cbDefault6.Name = "cbDefault6";
            this.cbDefault6.OnlyCheckBox = true;
            this.cbDefault6.Size = new System.Drawing.Size(26, 22);
            this.cbDefault6.TabIndex = 5;
            this.cbDefault6.Value = null;
            this.cbDefault6.Value2 = null;
            this.cbDefault6.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault6_CheckedChangeds);
            // 
            // cbDefault5
            // 
            this.cbDefault5.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault5.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault5.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault5.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault5.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault5.CbText = "checkBox2";
            this.cbDefault5.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault5.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault5.Imagem")));
            this.cbDefault5.IsOptionGroup = false;
            this.cbDefault5.IsReadOnly = false;
            this.cbDefault5.IsRequered = false;
            this.cbDefault5.Location = new System.Drawing.Point(257, 0);
            this.cbDefault5.Name = "cbDefault5";
            this.cbDefault5.OnlyCheckBox = true;
            this.cbDefault5.Size = new System.Drawing.Size(26, 22);
            this.cbDefault5.TabIndex = 4;
            this.cbDefault5.Value = null;
            this.cbDefault5.Value2 = null;
            this.cbDefault5.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault5_CheckedChangeds);
            // 
            // cbDefault4
            // 
            this.cbDefault4.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault4.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault4.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault4.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault4.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault4.CbText = "checkBox2";
            this.cbDefault4.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault4.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault4.Imagem")));
            this.cbDefault4.IsOptionGroup = false;
            this.cbDefault4.IsReadOnly = false;
            this.cbDefault4.IsRequered = false;
            this.cbDefault4.Location = new System.Drawing.Point(195, 0);
            this.cbDefault4.Name = "cbDefault4";
            this.cbDefault4.OnlyCheckBox = true;
            this.cbDefault4.Size = new System.Drawing.Size(26, 22);
            this.cbDefault4.TabIndex = 3;
            this.cbDefault4.Value = null;
            this.cbDefault4.Value2 = null;
            this.cbDefault4.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault4_CheckedChangeds);
            // 
            // cbDefault3
            // 
            this.cbDefault3.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault3.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault3.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault3.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault3.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault3.CbText = "checkBox2";
            this.cbDefault3.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault3.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault3.Imagem")));
            this.cbDefault3.IsOptionGroup = false;
            this.cbDefault3.IsReadOnly = false;
            this.cbDefault3.IsRequered = false;
            this.cbDefault3.Location = new System.Drawing.Point(140, 0);
            this.cbDefault3.Name = "cbDefault3";
            this.cbDefault3.OnlyCheckBox = true;
            this.cbDefault3.Size = new System.Drawing.Size(26, 22);
            this.cbDefault3.TabIndex = 2;
            this.cbDefault3.Value = null;
            this.cbDefault3.Value2 = null;
            this.cbDefault3.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault3_CheckedChangeds);
            // 
            // cbDefault2
            // 
            this.cbDefault2.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault2.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault2.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault2.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault2.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault2.CbText = "checkBox2";
            this.cbDefault2.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault2.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault2.Imagem")));
            this.cbDefault2.IsOptionGroup = false;
            this.cbDefault2.IsReadOnly = false;
            this.cbDefault2.IsRequered = false;
            this.cbDefault2.Location = new System.Drawing.Point(71, 0);
            this.cbDefault2.Name = "cbDefault2";
            this.cbDefault2.OnlyCheckBox = true;
            this.cbDefault2.Size = new System.Drawing.Size(26, 22);
            this.cbDefault2.TabIndex = 1;
            this.cbDefault2.Value = null;
            this.cbDefault2.Value2 = null;
            this.cbDefault2.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault2_CheckedChangeds);
            // 
            // cbDefault1
            // 
            this.cbDefault1.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "checkBox2";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(11, 0);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = true;
            this.cbDefault1.Size = new System.Drawing.Size(26, 22);
            this.cbDefault1.TabIndex = 0;
            this.cbDefault1.Value = null;
            this.cbDefault1.Value2 = null;
            this.cbDefault1.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault1_CheckedChangeds);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Image = global::DMZ.UI.Properties.Resources.Sync_Settings_20px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(682, 548);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 34);
            this.button3.TabIndex = 94;
            this.button3.Text = "PROCESSAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 583);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(813, 5);
            this.panel7.TabIndex = 101;
            // 
            // btnAddprocess
            // 
            this.btnAddprocess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddprocess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnAddprocess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddprocess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddprocess.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddprocess.ForeColor = System.Drawing.Color.White;
            this.btnAddprocess.Image = global::DMZ.UI.Properties.Resources.Process_25px;
            this.btnAddprocess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddprocess.Location = new System.Drawing.Point(660, 34);
            this.btnAddprocess.Name = "btnAddprocess";
            this.btnAddprocess.Size = new System.Drawing.Size(152, 40);
            this.btnAddprocess.TabIndex = 102;
            this.btnAddprocess.Text = "INSERIR ACESSOS";
            this.btnAddprocess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddprocess.UseVisualStyleBackColor = false;
            this.btnAddprocess.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // tbProcura
            // 
            this.tbProcura.BackColor = System.Drawing.Color.Snow;
            this.tbProcura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProcura.Location = new System.Drawing.Point(3, 79);
            this.tbProcura.Name = "tbProcura";
            this.tbProcura.Size = new System.Drawing.Size(408, 23);
            this.tbProcura.TabIndex = 103;
            this.tbProcura.TextChanged += new System.EventHandler(this.tbProcura_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDelete.Image = global::DMZ.UI.Properties.Resources.Trash_25px_1;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(2, 548);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 34);
            this.btnDelete.TabIndex = 104;
            this.btnDelete.Text = "ELIMINAR";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbDefault7
            // 
            this.cbDefault7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDefault7.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault7.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault7.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault7.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault7.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault7.CbText = "Selecçionar todos";
            this.cbDefault7.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault7.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault7.Imagem")));
            this.cbDefault7.IsOptionGroup = false;
            this.cbDefault7.IsReadOnly = false;
            this.cbDefault7.IsRequered = false;
            this.cbDefault7.Location = new System.Drawing.Point(106, 551);
            this.cbDefault7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDefault7.Name = "cbDefault7";
            this.cbDefault7.OnlyCheckBox = true;
            this.cbDefault7.Size = new System.Drawing.Size(143, 24);
            this.cbDefault7.TabIndex = 105;
            this.cbDefault7.Value = null;
            this.cbDefault7.Value2 = null;
            this.cbDefault7.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault7_CheckedChangeds);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Image = global::DMZ.UI.Properties.Resources.Refresh_25px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(5, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 106;
            this.button1.Text = "Actualizar ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmAcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDefault7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbProcura);
            this.Controls.Add(this.btnAddprocess);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAcessos";
            this.Text = "FrmAcessos";
            this.Load += new System.EventHandler(this.FrmAcessos_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.btnAddprocess, 0);
            this.Controls.SetChildIndex(this.tbProcura, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.cbDefault7, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblUser;
        public Generic.GridUi gridUi1;
        private System.Windows.Forms.Panel panel3;
        private UC.CbDefault cbDefault6;
        private UC.CbDefault cbDefault5;
        private UC.CbDefault cbDefault4;
        private UC.CbDefault cbDefault3;
        private UC.CbDefault cbDefault2;
        private UC.CbDefault cbDefault1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Button btnAddprocess;
        private System.Windows.Forms.TextBox tbProcura;
        private System.Windows.Forms.Button btnDelete;
        private UC.CbDefault cbDefault7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecran;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ver;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Intro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Alterar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Apagar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usracessostamp;
        private System.Windows.Forms.Button button1;
    }
}