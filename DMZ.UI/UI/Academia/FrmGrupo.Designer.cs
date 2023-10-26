namespace DMZ.UI.UI.Academia
{
    partial class FrmGrupo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.gridUI1 = new DMZ.UI.Generic.GridUi();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbCodigo = new DMZ.UI.UC.TbDefault();
            this.tbDescricao = new DMZ.UI.UC.TbDefault();
            this.imgGroup1 = new DMZ.UI.UC.ImgGroup();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdf = new DMZ.UI.Generic.TextAndImageColumn();
            this.anexo = new System.Windows.Forms.DataGridViewImageColumn();
            this.ver = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMessageShow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUI1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Size = new System.Drawing.Size(645, 30);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.Text = "Grupos Científicos";
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(562, 2);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(601, 36);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(601, 370);
            // 
            // panelMessageShow
            // 
            this.panelMessageShow.Location = new System.Drawing.Point(226, 3);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefresh.Location = new System.Drawing.Point(536, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(4, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 436);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.gridPanel21);
            this.tabPage1.Controls.Add(this.barraText1);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais ";
            // 
            // gridPanel21
            // 
            this.gridPanel21.AddControls = false;
            this.gridPanel21.Callform = false;
            this.gridPanel21.Controls.Add(this.gridUI1);
            this.gridPanel21.DefaultColumn = null;
            this.gridPanel21.Gridnome = "gridUI1";
            this.gridPanel21.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.Label1Color = System.Drawing.Color.White;
            this.gridPanel21.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel21.Label1Text = "Subgrupos";
            this.gridPanel21.Location = new System.Drawing.Point(7, 185);
            this.gridPanel21.MostraGravar = false;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.Activo;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(570, 216);
            this.gridPanel21.TabIndex = 76;
            this.gridPanel21.TipoMenu = false;
            this.gridPanel21.UsaNomeGrid = false;
            // 
            // gridUI1
            // 
            this.gridUI1.AddButtons = false;
            this.gridUI1.AllowUserToAddRows = false;
            this.gridUI1.AutoIncrimento = false;
            this.gridUI1.BackgroundColor = System.Drawing.Color.Snow;
            this.gridUI1.CampoCodigo = null;
            this.gridUI1.Codigo = null;
            this.gridUI1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUI1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUI1.ColumnHeadersHeight = 30;
            this.gridUI1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUI1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.descricao,
            this.pdf,
            this.anexo,
            this.ver});
            this.gridUI1.Condicao = null;
            this.gridUI1.CorPreto = true;
            this.gridUI1.CurrentColumnName = null;
            this.gridUI1.DefacolumnName = null;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUI1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridUI1.DellGridRow = null;
            this.gridUI1.DtDS = null;
            this.gridUI1.EnableHeadersVisualStyles = false;
            this.gridUI1.GenerateColumns = false;
            this.gridUI1.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUI1.GridFilha = true;
            this.gridUI1.GridFilhaSecundaria = false;
            this.gridUI1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUI1.HeadersHeight = 30;
            this.gridUI1.HeadersVisible = false;
            this.gridUI1.Location = new System.Drawing.Point(0, 25);
            this.gridUI1.Name = "gridUI1";
            this.gridUI1.OrderbyCampos = null;
            this.gridUI1.Origem = null;
            this.gridUI1.RowHeadersVisible = false;
            this.gridUI1.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUI1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridUI1.RowTemplate.Height = 60;
            this.gridUI1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUI1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUI1.Size = new System.Drawing.Size(570, 191);
            this.gridUI1.StampCabecalho = "grupostamp";
            this.gridUI1.StampLocal = "Subgrupostamp";
            this.gridUI1.TabelaSql = "Subgrupo";
            this.gridUI1.TabIndex = 75;
            this.gridUI1.TbCodigo = null;
            this.gridUI1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUI1_CellClick);
            // 
            // barraText1
            // 
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.White;
            this.barraText1.Label1Text = "Dados do grupo";
            this.barraText1.Location = new System.Drawing.Point(5, 8);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(577, 30);
            this.barraText1.TabIndex = 74;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tbCodigo);
            this.panel6.Controls.Add(this.tbDescricao);
            this.panel6.Controls.Add(this.imgGroup1);
            this.panel6.Location = new System.Drawing.Point(6, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(572, 140);
            this.panel6.TabIndex = 73;
            // 
            // tbCodigo
            // 
            this.tbCodigo.AutoComplete = false;
            this.tbCodigo.AutoIncrimento = true;
            this.tbCodigo.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbCodigo.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigo.Condicao = "";
            this.tbCodigo.InPutMask = false;
            this.tbCodigo.IsEmail = false;
            this.tbCodigo.IsMatricula = false;
            this.tbCodigo.IsMaxLength = false;
            this.tbCodigo.IsNuit = false;
            this.tbCodigo.IsNumeric = false;
            this.tbCodigo.IsReadOnly = false;
            this.tbCodigo.IsTelephone = false;
            this.tbCodigo.IsUnique = false;
            this.tbCodigo.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCodigo.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbCodigo.Label1Text = "Código";
            this.tbCodigo.Label1Text2 = null;
            this.tbCodigo.Location = new System.Drawing.Point(3, 7);
            this.tbCodigo.MaxLength = 0;
            this.tbCodigo.MultDocumento = false;
            this.tbCodigo.MultiLinhas = false;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Nome = "TbDefault";
            this.tbCodigo.Obrigatorio = false;
            this.tbCodigo.Selected = null;
            this.tbCodigo.Size = new System.Drawing.Size(129, 42);
            this.tbCodigo.Tabela = null;
            this.tbCodigo.TabIndex = 0;
            this.tbCodigo.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Tb1IsPassword = false;
            this.tbCodigo.Tb1MaxLength = 1000000;
            this.tbCodigo.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCodigo.Text2 = "";
            this.tbCodigo.Text3 = "";
            this.tbCodigo.Text4 = "";
            this.tbCodigo.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigo.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbCodigo.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbCodigo.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCodigo.Titulo = null;
            this.tbCodigo.ToUpperCase = false;
            this.tbCodigo.Value = "codigo";
            this.tbCodigo.Value2 = null;
            this.tbCodigo.Value3 = null;
            this.tbCodigo.Value4 = null;
            this.tbCodigo.ValueChange = false;
            // 
            // tbDescricao
            // 
            this.tbDescricao.AutoComplete = false;
            this.tbDescricao.AutoIncrimento = false;
            this.tbDescricao.btnProcura2ForeColor = System.Drawing.Color.Transparent;
            this.tbDescricao.ButtonAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricao.Condicao = "";
            this.tbDescricao.InPutMask = false;
            this.tbDescricao.IsEmail = false;
            this.tbDescricao.IsMatricula = false;
            this.tbDescricao.IsMaxLength = false;
            this.tbDescricao.IsNuit = false;
            this.tbDescricao.IsNumeric = false;
            this.tbDescricao.IsReadOnly = false;
            this.tbDescricao.IsTelephone = false;
            this.tbDescricao.IsUnique = false;
            this.tbDescricao.Label1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescricao.label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDescricao.Label1Text = "Descrição";
            this.tbDescricao.Label1Text2 = null;
            this.tbDescricao.Location = new System.Drawing.Point(3, 55);
            this.tbDescricao.MaxLength = 0;
            this.tbDescricao.MultDocumento = false;
            this.tbDescricao.MultiLinhas = false;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Nome = "TbDefault";
            this.tbDescricao.Obrigatorio = true;
            this.tbDescricao.Selected = null;
            this.tbDescricao.Size = new System.Drawing.Size(399, 42);
            this.tbDescricao.Tabela = null;
            this.tbDescricao.TabIndex = 1;
            this.tbDescricao.Tb1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Tb1IsPassword = false;
            this.tbDescricao.Tb1MaxLength = 1000000;
            this.tbDescricao.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDescricao.Text2 = "";
            this.tbDescricao.Text3 = "";
            this.tbDescricao.Text4 = "";
            this.tbDescricao.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricao.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbDescricao.TextBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.tbDescricao.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescricao.Titulo = null;
            this.tbDescricao.ToUpperCase = false;
            this.tbDescricao.Value = "descricao";
            this.tbDescricao.Value2 = null;
            this.tbDescricao.Value3 = null;
            this.tbDescricao.Value4 = null;
            this.tbDescricao.ValueChange = false;
            // 
            // imgGroup1
            // 
            this.imgGroup1.BackColor = System.Drawing.Color.Transparent;
            this.imgGroup1.Location = new System.Drawing.Point(408, 3);
            this.imgGroup1.Name = "imgGroup1";
            this.imgGroup1.SetWhitePicture = false;
            this.imgGroup1.Size = new System.Drawing.Size(158, 129);
            this.imgGroup1.TabIndex = 55;
            this.imgGroup1.TiffImage = false;
            this.imgGroup1.Value = "Imagem";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 120;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 280;
            this.descricao.Name = "descricao";
            // 
            // pdf
            // 
            this.pdf.DataPropertyName = "Imagem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pdf.DefaultCellStyle = dataGridViewCellStyle2;
            this.pdf.HeaderText = "...";
            this.pdf.Image = global::DMZ.UI.Properties.Resources.External_Link_251px;
            this.pdf.Name = "pdf";
            this.pdf.Visible = false;
            this.pdf.Width = 30;
            // 
            // anexo
            // 
            this.anexo.HeaderText = "...";
            this.anexo.Image = global::DMZ.UI.Properties.Resources.Attach_20px;
            this.anexo.Name = "anexo";
            this.anexo.ToolTipText = "Anexar documento/Imagem";
            this.anexo.Width = 30;
            // 
            // ver
            // 
            this.ver.HeaderText = "...";
            this.ver.Image = global::DMZ.UI.Properties.Resources.view_21px;
            this.ver.Name = "ver";
            this.ver.ToolTipText = "ver";
            this.ver.Width = 30;
            // 
            // FrmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(645, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmGrupo";
            this.Text = "Form Classe";
            this.Load += new System.EventHandler(this.FrmGrupo_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panelTitulo, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMessageShow.ResumeLayout(false);
            this.panelMessageShow.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUI1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.GridPanel2 gridPanel21;
        private Generic.GridUi gridUI1;
        private UC.BarraText barraText1;
        private System.Windows.Forms.Panel panel6;
        private UC.TbDefault tbCodigo;
        private UC.TbDefault tbDescricao;
        private UC.ImgGroup imgGroup1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private Generic.TextAndImageColumn pdf;
        private System.Windows.Forms.DataGridViewImageColumn anexo;
        private System.Windows.Forms.DataGridViewImageColumn ver;
    }
}
