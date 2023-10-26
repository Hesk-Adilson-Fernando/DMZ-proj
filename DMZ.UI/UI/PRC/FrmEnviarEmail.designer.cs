
namespace DMZ.UI.UI.PRC
{
    partial class FrmEnviarEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnviarEmail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.grpMensagem = new System.Windows.Forms.GroupBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gridUIFt1 = new DMZ.UI.Generic.GridUi();
            this.cbkxTodosProdutos = new DMZ.UI.UC.CbDefault();
            this.chkbxTodosFnc = new DMZ.UI.UC.CbDefault();
            this.dataGridViewFnc = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicio = new DMZ.UI.Generic.DateTimePickerColumn();
            this.Termino = new DMZ.UI.Generic.DateTimePickerColumn();
            this.Duracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivainc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.valival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nofor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fncstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ststamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selects = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fncstamp1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpMensagem.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUIFt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFnc)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(741, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(709, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.Text = "Envio de Email";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Image = global::DMZ.UI.Properties.Resources.email_send_20px;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(603, 595);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(117, 35);
            this.btnEnviar.TabIndex = 114;
            this.btnEnviar.TabStop = false;
            this.btnEnviar.Text = " &Enviar [ F5 ]";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnAnexar
            // 
            this.btnAnexar.BackColor = System.Drawing.Color.White;
            this.btnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexar.Image = global::DMZ.UI.Properties.Resources.analyze_20px;
            this.btnAnexar.Location = new System.Drawing.Point(14, 187);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(129, 35);
            this.btnAnexar.TabIndex = 1;
            this.btnAnexar.TabStop = false;
            this.btnAnexar.Text = " &Anexar [ F9 ]";
            this.btnAnexar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnexar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnexar.UseVisualStyleBackColor = false;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // txtAnexo
            // 
            this.txtAnexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAnexo.Enabled = false;
            this.txtAnexo.Location = new System.Drawing.Point(152, 138);
            this.txtAnexo.Multiline = true;
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(426, 146);
            this.txtAnexo.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 537);
            this.tabControl1.TabIndex = 118;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpMensagem);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mensagens";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAssunto);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 184);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assunto";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(16, 22);
            this.txtAssunto.Multiline = true;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(637, 149);
            this.txtAssunto.TabIndex = 3;
            this.txtAssunto.Text = "EXCIA, EM PRIMEIRO LUGAR QUEIRAM RECEBER AS NOSSAS SAUDAÇÕES!";
            this.txtAssunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpMensagem
            // 
            this.grpMensagem.Controls.Add(this.txtMensagem);
            this.grpMensagem.Location = new System.Drawing.Point(12, 299);
            this.grpMensagem.Name = "grpMensagem";
            this.grpMensagem.Size = new System.Drawing.Size(683, 184);
            this.grpMensagem.TabIndex = 117;
            this.grpMensagem.TabStop = false;
            this.grpMensagem.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(6, 19);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(653, 156);
            this.txtMensagem.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gridUIFt1);
            this.tabPage4.Controls.Add(this.cbkxTodosProdutos);
            this.tabPage4.Controls.Add(this.chkbxTodosFnc);
            this.tabPage4.Controls.Add(this.dataGridViewFnc);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(704, 511);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Destinatário/Produtos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gridUIFt1
            // 
            this.gridUIFt1.AddButtons = false;
            this.gridUIFt1.AllowUserToAddRows = false;
            this.gridUIFt1.AutoIncrimento = false;
            this.gridUIFt1.BackgroundColor = System.Drawing.Color.White;
            this.gridUIFt1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUIFt1.CampoCodigo = null;
            this.gridUIFt1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUIFt1.Codigo = null;
            this.gridUIFt1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUIFt1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUIFt1.ColumnHeadersHeight = 30;
            this.gridUIFt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUIFt1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ref,
            this.descricao,
            this.inicio,
            this.Termino,
            this.Duracao,
            this.Quant,
            this.Preco,
            this.subtotall,
            this.perdesc,
            this.descontol,
            this.tabiva,
            this.txiva,
            this.ivainc,
            this.valival,
            this.totall,
            this.nomefor,
            this.nofor,
            this.fncstamp,
            this.ststamp,
            this.email1,
            this.selects});
            this.gridUIFt1.Condicao = null;
            this.gridUIFt1.CorPreto = true;
            this.gridUIFt1.CurrentColumnName = null;
            this.gridUIFt1.DefacolumnName = null;
            this.gridUIFt1.DellGridRow = null;
            this.gridUIFt1.DtDS = null;
            this.gridUIFt1.EnableHeadersVisualStyles = false;
            this.gridUIFt1.GenerateColumns = false;
            this.gridUIFt1.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUIFt1.GridFilha = true;
            this.gridUIFt1.GridFilhaSecundaria = false;
            this.gridUIFt1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUIFt1.HeadersHeight = 30;
            this.gridUIFt1.HeadersVisible = false;
            this.gridUIFt1.Location = new System.Drawing.Point(7, 38);
            this.gridUIFt1.Name = "gridUIFt1";
            this.gridUIFt1.OrderbyCampos = "";
            this.gridUIFt1.Origem = null;
            this.gridUIFt1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUIFt1.RowHeadersVisible = false;
            this.gridUIFt1.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridUIFt1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUIFt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUIFt1.Size = new System.Drawing.Size(691, 219);
            this.gridUIFt1.StampCabecalho = "Procurmstamp";
            this.gridUIFt1.StampLocal = "Procurmlstamp";
            this.gridUIFt1.TabelaSql = "Procurml";
            this.gridUIFt1.TabIndex = 75;
            this.gridUIFt1.TbCodigo = null;
            // 
            // cbkxTodosProdutos
            // 
            this.cbkxTodosProdutos.BackColor = System.Drawing.Color.Transparent;
            this.cbkxTodosProdutos.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbkxTodosProdutos.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbkxTodosProdutos.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkxTodosProdutos.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbkxTodosProdutos.CbText = "Seleccionar todos Produtos";
            this.cbkxTodosProdutos.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbkxTodosProdutos.Imagem = ((System.Drawing.Image)(resources.GetObject("cbkxTodosProdutos.Imagem")));
            this.cbkxTodosProdutos.IsOptionGroup = false;
            this.cbkxTodosProdutos.IsReadOnly = false;
            this.cbkxTodosProdutos.IsRequered = false;
            this.cbkxTodosProdutos.Location = new System.Drawing.Point(9, 10);
            this.cbkxTodosProdutos.Name = "cbkxTodosProdutos";
            this.cbkxTodosProdutos.OnlyCheckBox = true;
            this.cbkxTodosProdutos.Size = new System.Drawing.Size(228, 22);
            this.cbkxTodosProdutos.TabIndex = 4;
            this.cbkxTodosProdutos.Value = null;
            this.cbkxTodosProdutos.Value2 = null;
            this.cbkxTodosProdutos.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbkxTodosProdutos_CheckedChangeds);
            // 
            // chkbxTodosFnc
            // 
            this.chkbxTodosFnc.BackColor = System.Drawing.Color.Transparent;
            this.chkbxTodosFnc.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbxTodosFnc.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbxTodosFnc.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxTodosFnc.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.chkbxTodosFnc.CbText = "Enviar Para Todos Fornecedores";
            this.chkbxTodosFnc.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkbxTodosFnc.Imagem = ((System.Drawing.Image)(resources.GetObject("chkbxTodosFnc.Imagem")));
            this.chkbxTodosFnc.IsOptionGroup = false;
            this.chkbxTodosFnc.IsReadOnly = false;
            this.chkbxTodosFnc.IsRequered = false;
            this.chkbxTodosFnc.Location = new System.Drawing.Point(9, 283);
            this.chkbxTodosFnc.Name = "chkbxTodosFnc";
            this.chkbxTodosFnc.OnlyCheckBox = true;
            this.chkbxTodosFnc.Size = new System.Drawing.Size(228, 22);
            this.chkbxTodosFnc.TabIndex = 4;
            this.chkbxTodosFnc.Value = null;
            this.chkbxTodosFnc.Value2 = null;
            this.chkbxTodosFnc.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.chkbxTodosFnc_CheckedChangeds);
            // 
            // dataGridViewFnc
            // 
            this.dataGridViewFnc.AllowUserToAddRows = false;
            this.dataGridViewFnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFnc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Email,
            this.select,
            this.No,
            this.fncstamp1});
            this.dataGridViewFnc.Location = new System.Drawing.Point(14, 325);
            this.dataGridViewFnc.Name = "dataGridViewFnc";
            this.dataGridViewFnc.RowHeadersVisible = false;
            this.dataGridViewFnc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFnc.Size = new System.Drawing.Size(684, 163);
            this.dataGridViewFnc.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLimpar);
            this.tabPage2.Controls.Add(this.btnAnexar);
            this.tabPage2.Controls.Add(this.txtAnexo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mais  Anexos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(584, 214);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 24);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Ref
            // 
            this.Ref.DataPropertyName = "ref";
            this.Ref.HeaderText = "Referência";
            this.Ref.MinimumWidth = 6;
            this.Ref.Name = "Ref";
            this.Ref.Width = 80;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "descricao";
            this.descricao.MinimumWidth = 300;
            this.descricao.Name = "descricao";
            // 
            // inicio
            // 
            this.inicio.DataPropertyName = "inicio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            this.inicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.inicio.HeaderText = "Lançamento";
            this.inicio.IsDateTime = false;
            this.inicio.Name = "inicio";
            this.inicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inicio.Visible = false;
            this.inicio.Width = 110;
            // 
            // Termino
            // 
            this.Termino.DataPropertyName = "termino";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd-MM-yyyy HH:mm";
            this.Termino.DefaultCellStyle = dataGridViewCellStyle3;
            this.Termino.HeaderText = "Data/Hora de Abertura";
            this.Termino.IsDateTime = false;
            this.Termino.MinimumWidth = 250;
            this.Termino.Name = "Termino";
            this.Termino.ReadOnly = true;
            this.Termino.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Termino.Visible = false;
            this.Termino.Width = 250;
            // 
            // Duracao
            // 
            this.Duracao.DataPropertyName = "duracao";
            this.Duracao.HeaderText = "Duracao";
            this.Duracao.Name = "Duracao";
            this.Duracao.Visible = false;
            this.Duracao.Width = 65;
            // 
            // Quant
            // 
            this.Quant.DataPropertyName = "quant";
            this.Quant.HeaderText = "Quant";
            this.Quant.Name = "Quant";
            this.Quant.Visible = false;
            this.Quant.Width = 60;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "preco";
            this.Preco.HeaderText = "Preco";
            this.Preco.Name = "Preco";
            this.Preco.Visible = false;
            // 
            // subtotall
            // 
            this.subtotall.DataPropertyName = "subtotall";
            this.subtotall.HeaderText = "Subtotal";
            this.subtotall.Name = "subtotall";
            this.subtotall.Visible = false;
            // 
            // perdesc
            // 
            this.perdesc.DataPropertyName = "perdesc";
            this.perdesc.HeaderText = "% Desc";
            this.perdesc.Name = "perdesc";
            this.perdesc.Visible = false;
            // 
            // descontol
            // 
            this.descontol.DataPropertyName = "descontol";
            this.descontol.HeaderText = "Desconto";
            this.descontol.Name = "descontol";
            this.descontol.Visible = false;
            // 
            // tabiva
            // 
            this.tabiva.DataPropertyName = "tabiva";
            this.tabiva.HeaderText = "Tab Iva";
            this.tabiva.Name = "tabiva";
            this.tabiva.Visible = false;
            // 
            // txiva
            // 
            this.txiva.DataPropertyName = "txiva";
            this.txiva.HeaderText = "IVA";
            this.txiva.Name = "txiva";
            this.txiva.Visible = false;
            // 
            // ivainc
            // 
            this.ivainc.DataPropertyName = "ivainc";
            this.ivainc.HeaderText = "Iva Inc";
            this.ivainc.Name = "ivainc";
            this.ivainc.Visible = false;
            // 
            // valival
            // 
            this.valival.DataPropertyName = "valival";
            this.valival.HeaderText = "Valor Iva";
            this.valival.Name = "valival";
            this.valival.ReadOnly = true;
            this.valival.Visible = false;
            // 
            // totall
            // 
            this.totall.DataPropertyName = "totall";
            this.totall.HeaderText = "Total";
            this.totall.Name = "totall";
            this.totall.ReadOnly = true;
            this.totall.Visible = false;
            // 
            // nomefor
            // 
            this.nomefor.DataPropertyName = "nome";
            this.nomefor.HeaderText = "Fornecedor";
            this.nomefor.Name = "nomefor";
            this.nomefor.Visible = false;
            // 
            // nofor
            // 
            this.nofor.DataPropertyName = "no";
            this.nofor.HeaderText = "No";
            this.nofor.Name = "nofor";
            this.nofor.Visible = false;
            // 
            // fncstamp
            // 
            this.fncstamp.DataPropertyName = "fncstamp";
            this.fncstamp.HeaderText = "fncstamp";
            this.fncstamp.Name = "fncstamp";
            this.fncstamp.Visible = false;
            // 
            // ststamp
            // 
            this.ststamp.DataPropertyName = "ststamp";
            this.ststamp.HeaderText = "ststamp";
            this.ststamp.Name = "ststamp";
            this.ststamp.Visible = false;
            // 
            // email1
            // 
            this.email1.DataPropertyName = "email";
            this.email1.HeaderText = "Email";
            this.email1.Name = "email1";
            this.email1.Visible = false;
            // 
            // selects
            // 
            this.selects.DataPropertyName = "select";
            this.selects.HeaderText = "Escolher";
            this.selects.MinimumWidth = 100;
            this.selects.Name = "selects";
            this.selects.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selects.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "nome";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle5;
            this.Nome.HeaderText = "Fornecedor";
            this.Nome.MinimumWidth = 303;
            this.Nome.Name = "Nome";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 303;
            this.Email.Name = "Email";
            this.Email.Visible = false;
            // 
            // select
            // 
            this.select.DataPropertyName = "select";
            this.select.HeaderText = "Escolher";
            this.select.MinimumWidth = 100;
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // No
            // 
            this.No.DataPropertyName = "no";
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Visible = false;
            // 
            // fncstamp1
            // 
            this.fncstamp1.DataPropertyName = "fncstamp";
            this.fncstamp1.HeaderText = "fncstamp";
            this.fncstamp1.Name = "fncstamp1";
            this.fncstamp1.Visible = false;
            // 
            // FrmEnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 638);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnEnviar);
            this.Name = "FrmEnviarEmail";
            this.Text = "FrmEmail";
            this.Load += new System.EventHandler(this.FrmEnviarEmail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEnviarEmail_KeyDown);
            this.Controls.SetChildIndex(this.btnEnviar, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMensagem.ResumeLayout(false);
            this.grpMensagem.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUIFt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFnc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewFnc;
        private UC.CbDefault chkbxTodosFnc;
        private System.Windows.Forms.Button btnLimpar;
        private UC.CbDefault cbkxTodosProdutos;
        public Generic.GridUi gridUIFt1;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpMensagem;
        public System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private Generic.DateTimePickerColumn inicio;
        private Generic.DateTimePickerColumn Termino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotall;
        private System.Windows.Forms.DataGridViewTextBoxColumn perdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn txiva;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ivainc;
        private System.Windows.Forms.DataGridViewTextBoxColumn valival;
        private System.Windows.Forms.DataGridViewTextBoxColumn totall;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nofor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fncstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ststamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn fncstamp1;
    }
}