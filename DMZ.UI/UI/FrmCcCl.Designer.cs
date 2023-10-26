
namespace DMZ.UI.UI
{
    partial class FrmCcCl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valordoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorporReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValRegularizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recibos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oristamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPENDENTE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTOTPAGO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTOTDOCS = new System.Windows.Forms.TextBox();
            this.Moeda = new DMZ.UI.UC.Procura();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(832, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(800, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.Text = "conta corrente do cliente ";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_25px1;
            this.btnPrint.Location = new System.Drawing.Point(791, 37);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(38, 35);
            this.btnPrint.TabIndex = 87;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.Color.White;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.numero,
            this.Data,
            this.vencim,
            this.Valordoc,
            this.ValorporReg,
            this.ValRegularizado,
            this.Dias,
            this.validade,
            this.Recibos,
            this.ccstamp,
            this.Origem,
            this.oristamp});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = false;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.White;
            this.gridUi1.GridFilha = false;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(3, 75);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridUi1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi1.Size = new System.Drawing.Size(827, 366);
            this.gridUi1.StampCabecalho = null;
            this.gridUi1.StampLocal = null;
            this.gridUi1.TabelaSql = null;
            this.gridUi1.TabIndex = 86;
            this.gridUi1.TbCodigo = null;
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Documento.DataPropertyName = "documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 150;
            this.Documento.Name = "Documento";
            // 
            // numero
            // 
            this.numero.DataPropertyName = "nrdoc";
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.Width = 60;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle3;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 80;
            // 
            // vencim
            // 
            this.vencim.DataPropertyName = "vencim";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.vencim.DefaultCellStyle = dataGridViewCellStyle4;
            this.vencim.HeaderText = "Vencimento";
            this.vencim.Name = "vencim";
            this.vencim.Width = 80;
            // 
            // Valordoc
            // 
            this.Valordoc.DataPropertyName = "debito";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Valordoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.Valordoc.HeaderText = "Valor Doc.";
            this.Valordoc.Name = "Valordoc";
            this.Valordoc.Width = 120;
            // 
            // ValorporReg
            // 
            this.ValorporReg.DataPropertyName = "credito";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.ValorporReg.DefaultCellStyle = dataGridViewCellStyle6;
            this.ValorporReg.HeaderText = "Valor Pago";
            this.ValorporReg.Name = "ValorporReg";
            this.ValorporReg.Width = 120;
            // 
            // ValRegularizado
            // 
            this.ValRegularizado.DataPropertyName = "pendente";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.ValRegularizado.DefaultCellStyle = dataGridViewCellStyle7;
            this.ValRegularizado.HeaderText = "Pendente";
            this.ValRegularizado.Name = "ValRegularizado";
            this.ValRegularizado.Width = 120;
            // 
            // Dias
            // 
            this.Dias.DataPropertyName = "Dias";
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            this.Dias.Width = 30;
            // 
            // validade
            // 
            this.validade.DataPropertyName = "Validade";
            this.validade.HeaderText = "Validade";
            this.validade.Name = "validade";
            // 
            // Recibos
            // 
            this.Recibos.DataPropertyName = "numero";
            this.Recibos.HeaderText = "Recibos";
            this.Recibos.Name = "Recibos";
            // 
            // ccstamp
            // 
            this.ccstamp.DataPropertyName = "ccstamp";
            this.ccstamp.HeaderText = "ccstamp";
            this.ccstamp.Name = "ccstamp";
            this.ccstamp.Visible = false;
            // 
            // Origem
            // 
            this.Origem.DataPropertyName = "origem";
            this.Origem.HeaderText = "Origem";
            this.Origem.Name = "Origem";
            this.Origem.Visible = false;
            // 
            // oristamp
            // 
            this.oristamp.HeaderText = "oristamp";
            this.oristamp.Name = "oristamp";
            this.oristamp.Visible = false;
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(332, 45);
            this.tbNumero.Multiline = true;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ReadOnly = true;
            this.tbNumero.Size = new System.Drawing.Size(92, 26);
            this.tbNumero.TabIndex = 100;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(3, 45);
            this.tbNome.Multiline = true;
            this.tbNome.Name = "tbNome";
            this.tbNome.ReadOnly = true;
            this.tbNome.Size = new System.Drawing.Size(323, 26);
            this.tbNome.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbPENDENTE);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbTOTPAGO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbTOTDOCS);
            this.panel1.Location = new System.Drawing.Point(3, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 39);
            this.panel1.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(554, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 111;
            this.label6.Text = "TOTAL PENDENTE";
            // 
            // tbPENDENTE
            // 
            this.tbPENDENTE.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPENDENTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbPENDENTE.Location = new System.Drawing.Point(663, 8);
            this.tbPENDENTE.Multiline = true;
            this.tbPENDENTE.Name = "tbPENDENTE";
            this.tbPENDENTE.ReadOnly = true;
            this.tbPENDENTE.Size = new System.Drawing.Size(160, 26);
            this.tbPENDENTE.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(286, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 109;
            this.label5.Text = "TOTAL PAGO";
            // 
            // tbTOTPAGO
            // 
            this.tbTOTPAGO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTOTPAGO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTOTPAGO.Location = new System.Drawing.Point(376, 7);
            this.tbTOTPAGO.Multiline = true;
            this.tbTOTPAGO.Name = "tbTOTPAGO";
            this.tbTOTPAGO.ReadOnly = true;
            this.tbTOTPAGO.Size = new System.Drawing.Size(160, 26);
            this.tbTOTPAGO.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "TOTAL DOCS";
            // 
            // tbTOTDOCS
            // 
            this.tbTOTDOCS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTOTDOCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTOTDOCS.Location = new System.Drawing.Point(116, 7);
            this.tbTOTDOCS.Multiline = true;
            this.tbTOTDOCS.Name = "tbTOTDOCS";
            this.tbTOTDOCS.ReadOnly = true;
            this.tbTOTDOCS.Size = new System.Drawing.Size(160, 26);
            this.tbTOTDOCS.TabIndex = 106;
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
            this.Moeda.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Moeda.Label1Text = "Moeda";
            this.Moeda.Location = new System.Drawing.Point(430, 31);
            this.Moeda.MultDocumento = false;
            this.Moeda.Name = "Moeda";
            this.Moeda.OpenInfo = false;
            this.Moeda.ParentFormName = null;
            this.Moeda.Pp = null;
            this.Moeda.ReturnDt = false;
            this.Moeda.Selecionado = "";
            this.Moeda.ShowThirdColumn = false;
            this.Moeda.Size = new System.Drawing.Size(185, 40);
            this.Moeda.SqlComandText = "select Descricao,moeda from moedas ";
            this.Moeda.Tabela = "";
            this.Moeda.TabIndex = 102;
            this.Moeda.TbCkUpdate = false;
            this.Moeda.TbClear = false;
            this.Moeda.TbUpDate = null;
            this.Moeda.Text2 = null;
            this.Moeda.Text3 = null;
            this.Moeda.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.Moeda.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.Moeda.Titulo = "Procurar";
            this.Moeda.TmpFound = null;
            this.Moeda.UpdateTextBox = null;
            this.Moeda.Value = "";
            this.Moeda.Value2 = "";
            this.Moeda.Value3 = null;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Sync_Settings_20px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.Location = new System.Drawing.Point(686, 37);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(101, 35);
            this.btnProcessar.TabIndex = 103;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // FrmCcCl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 489);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.Moeda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gridUi1);
            this.Name = "FrmCcCl";
            this.Text = "FrmCcCl";
            this.Load += new System.EventHandler(this.FrmCcCl_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.gridUi1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.tbNome, 0);
            this.Controls.SetChildIndex(this.tbNumero, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.Moeda, 0);
            this.Controls.SetChildIndex(this.btnProcessar, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPrint;
        private Generic.GridUi gridUi1;
        public System.Windows.Forms.TextBox tbNumero;
        public System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbPENDENTE;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbTOTPAGO;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbTOTDOCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valordoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorporReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValRegularizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn oristamp;
        public System.Windows.Forms.Button btnProcessar;
        public UC.Procura Moeda;
    }
}