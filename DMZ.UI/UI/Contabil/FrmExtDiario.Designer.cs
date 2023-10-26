
using System.Data;

namespace DMZ.UI.UI.Contabil
{
    partial class FrmExtDiario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExtDiario));
            this.gridDiarios = new DMZ.UI.Generic.GridUi();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrLanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPeriodo = new DMZ.UI.UC.CbDefault();
            this.cbDiario = new DMZ.UI.UC.DmzProcura();
            this.dmzEntreDatas1 = new DMZ.UI.UC.DMZEntreDatas();
            this.radOpSaldo = new System.Windows.Forms.GroupBox();
            this.rbSsaldosPer = new DMZ.UI.UC.CbDefault();
            this.rbSsaldosAc = new DMZ.UI.UC.CbDefault();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.radOpSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(887, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(855, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.Text = "Extrato de Diários";
            // 
            // gridDiarios
            // 
            this.gridDiarios.AddButtons = false;
            this.gridDiarios.AllowUserToAddRows = false;
            this.gridDiarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDiarios.AutoIncrimento = false;
            this.gridDiarios.BackgroundColor = System.Drawing.Color.White;
            this.gridDiarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDiarios.CampoCodigo = null;
            this.gridDiarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridDiarios.Codigo = null;
            this.gridDiarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDiarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridDiarios.ColumnHeadersHeight = 30;
            this.gridDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDiarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Diario,
            this.Doc,
            this.Descricao,
            this.NrLanc,
            this.Conta,
            this.Debito,
            this.Credito,
            this.nrdoc});
            this.gridDiarios.Condicao = null;
            this.gridDiarios.CorPreto = true;
            this.gridDiarios.CurrentColumnName = null;
            this.gridDiarios.DefacolumnName = null;
            this.gridDiarios.DellGridRow = null;
            this.gridDiarios.DtDS = null;
            this.gridDiarios.EnableHeadersVisualStyles = false;
            this.gridDiarios.GenerateColumns = false;
            this.gridDiarios.GridColor = System.Drawing.Color.SteelBlue;
            this.gridDiarios.GridFilha = true;
            this.gridDiarios.GridFilhaSecundaria = false;
            this.gridDiarios.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDiarios.HeadersHeight = 30;
            this.gridDiarios.HeadersVisible = false;
            this.gridDiarios.Location = new System.Drawing.Point(4, 141);
            this.gridDiarios.Name = "gridDiarios";
            this.gridDiarios.OrderbyCampos = null;
            this.gridDiarios.Origem = null;
            this.gridDiarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDiarios.RowHeadersVisible = false;
            this.gridDiarios.RowHeadersWidth = 30;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.gridDiarios.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridDiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDiarios.Size = new System.Drawing.Size(879, 371);
            this.gridDiarios.StampCabecalho = "Ststamp";
            this.gridDiarios.StampLocal = "StPrecostamp";
            this.gridDiarios.TabelaSql = "StPrecos";
            this.gridDiarios.TabIndex = 483;
            this.gridDiarios.TbCodigo = null;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            dataGridViewCellStyle7.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle7;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 80;
            // 
            // Diario
            // 
            this.Diario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diario.DataPropertyName = "diario";
            this.Diario.HeaderText = "Diário";
            this.Diario.Name = "Diario";
            // 
            // Doc
            // 
            this.Doc.DataPropertyName = "documento";
            this.Doc.HeaderText = "Documento";
            this.Doc.Name = "Doc";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "adoc";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // NrLanc
            // 
            this.NrLanc.DataPropertyName = "dilno";
            this.NrLanc.HeaderText = "Nº Lanç.";
            this.NrLanc.Name = "NrLanc";
            // 
            // Conta
            // 
            this.Conta.DataPropertyName = "conta";
            this.Conta.HeaderText = "Conta";
            this.Conta.Name = "Conta";
            this.Conta.Width = 120;
            // 
            // Debito
            // 
            this.Debito.DataPropertyName = "deb";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.Debito.DefaultCellStyle = dataGridViewCellStyle8;
            this.Debito.HeaderText = "Débito";
            this.Debito.Name = "Debito";
            // 
            // Credito
            // 
            this.Credito.DataPropertyName = "cre";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.Credito.DefaultCellStyle = dataGridViewCellStyle9;
            this.Credito.HeaderText = "Crédito";
            this.Credito.Name = "Credito";
            // 
            // nrdoc
            // 
            this.nrdoc.DataPropertyName = "nrdoc";
            this.nrdoc.HeaderText = "Nº Doc.";
            this.nrdoc.Name = "nrdoc";
            this.nrdoc.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProcessar);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.radOpSaldo);
            this.panel1.Location = new System.Drawing.Point(4, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 97);
            this.panel1.TabIndex = 482;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnProcessar.FlatAppearance.BorderSize = 0;
            this.btnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.Location = new System.Drawing.Point(768, 21);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(104, 32);
            this.btnProcessar.TabIndex = 459;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(768, 59);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 32);
            this.btnPrint.TabIndex = 82;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cbPeriodo);
            this.groupBox1.Controls.Add(this.cbDiario);
            this.groupBox1.Controls.Add(this.dmzEntreDatas1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(8, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 92);
            this.groupBox1.TabIndex = 458;
            this.groupBox1.TabStop = false;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.cbPeriodo.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPeriodo.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPeriodo.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodo.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbPeriodo.CbText = "Período específico";
            this.cbPeriodo.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPeriodo.Imagem = ((System.Drawing.Image)(resources.GetObject("cbPeriodo.Imagem")));
            this.cbPeriodo.IsOptionGroup = false;
            this.cbPeriodo.IsReadOnly = false;
            this.cbPeriodo.IsRequered = false;
            this.cbPeriodo.Location = new System.Drawing.Point(6, 60);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.OnlyCheckBox = true;
            this.cbPeriodo.Size = new System.Drawing.Size(146, 22);
            this.cbPeriodo.TabIndex = 498;
            this.cbPeriodo.Value = null;
            this.cbPeriodo.Value2 = null;
            // 
            // cbDiario
            // 
            this.cbDiario.BtnEnabled = true;
            this.cbDiario.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDiario.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDiario.Condicao = null;
            this.cbDiario.ExecMetodo = false;
            this.cbDiario.HideFirstColumn = false;
            this.cbDiario.InvertColuna = false;
            this.cbDiario.IsLocaDs = false;
            this.cbDiario.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiario.Label1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiario.Label1Text = "Diário";
            this.cbDiario.Location = new System.Drawing.Point(5, 8);
            this.cbDiario.MySQLQuerry = null;
            this.cbDiario.Name = "cbDiario";
            this.cbDiario.Pp = null;
            this.cbDiario.Size = new System.Drawing.Size(361, 39);
            this.cbDiario.SqlComandText = "select dino,Descricao from Diario";
            this.cbDiario.TabIndex = 497;
            this.cbDiario.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiario.Tb1Multiline = false;
            this.cbDiario.Text2 = null;
            this.cbDiario.Text3 = null;
            // 
            // dmzEntreDatas1
            // 
            this.dmzEntreDatas1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzEntreDatas1.HideShowDt2 = true;
            this.dmzEntreDatas1.Location = new System.Drawing.Point(159, 43);
            this.dmzEntreDatas1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dmzEntreDatas1.Name = "dmzEntreDatas1";
            this.dmzEntreDatas1.Size = new System.Drawing.Size(207, 44);
            this.dmzEntreDatas1.TabIndex = 496;
            // 
            // radOpSaldo
            // 
            this.radOpSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radOpSaldo.Controls.Add(this.rbSsaldosPer);
            this.radOpSaldo.Controls.Add(this.rbSsaldosAc);
            this.radOpSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radOpSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radOpSaldo.Location = new System.Drawing.Point(432, 12);
            this.radOpSaldo.Name = "radOpSaldo";
            this.radOpSaldo.Size = new System.Drawing.Size(321, 79);
            this.radOpSaldo.TabIndex = 456;
            this.radOpSaldo.TabStop = false;
            this.radOpSaldo.Text = "Opções de saldo";
            // 
            // rbSsaldosPer
            // 
            this.rbSsaldosPer.BackColor = System.Drawing.Color.Transparent;
            this.rbSsaldosPer.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSsaldosPer.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSsaldosPer.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSsaldosPer.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbSsaldosPer.CbText = "Só saldo do período";
            this.rbSsaldosPer.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbSsaldosPer.Imagem = ((System.Drawing.Image)(resources.GetObject("rbSsaldosPer.Imagem")));
            this.rbSsaldosPer.IsOptionGroup = false;
            this.rbSsaldosPer.IsReadOnly = false;
            this.rbSsaldosPer.IsRequered = false;
            this.rbSsaldosPer.Location = new System.Drawing.Point(6, 41);
            this.rbSsaldosPer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSsaldosPer.Name = "rbSsaldosPer";
            this.rbSsaldosPer.OnlyCheckBox = true;
            this.rbSsaldosPer.Size = new System.Drawing.Size(290, 27);
            this.rbSsaldosPer.TabIndex = 497;
            this.rbSsaldosPer.Value = null;
            this.rbSsaldosPer.Value2 = null;
            // 
            // rbSsaldosAc
            // 
            this.rbSsaldosAc.BackColor = System.Drawing.Color.Transparent;
            this.rbSsaldosAc.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSsaldosAc.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSsaldosAc.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSsaldosAc.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.rbSsaldosAc.CbText = "Só os saldos acumulados ";
            this.rbSsaldosAc.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbSsaldosAc.Imagem = ((System.Drawing.Image)(resources.GetObject("rbSsaldosAc.Imagem")));
            this.rbSsaldosAc.IsOptionGroup = false;
            this.rbSsaldosAc.IsReadOnly = false;
            this.rbSsaldosAc.IsRequered = false;
            this.rbSsaldosAc.Location = new System.Drawing.Point(6, 19);
            this.rbSsaldosAc.Name = "rbSsaldosAc";
            this.rbSsaldosAc.OnlyCheckBox = true;
            this.rbSsaldosAc.Size = new System.Drawing.Size(249, 22);
            this.rbSsaldosAc.TabIndex = 496;
            this.rbSsaldosAc.Value = null;
            this.rbSsaldosAc.Value2 = null;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 517);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(888, 5);
            this.panel6.TabIndex = 484;
            // 
            // FrmExtDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(888, 522);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.gridDiarios);
            this.Controls.Add(this.panel1);
            this.Name = "FrmExtDiario";
            this.Load += new System.EventHandler(this.FrmExtDiario_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridDiarios, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.radOpSaldo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Generic.GridUi gridDiarios;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnProcessar;
        public System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox radOpSaldo;
        private UC.CbDefault rbSsaldosPer;
        private UC.CbDefault rbSsaldosAc;
        private UC.DmzProcura cbDiario;
        private UC.DMZEntreDatas dmzEntreDatas1;
        private UC.CbDefault cbPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrLanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrdoc;
        private System.Windows.Forms.Panel panel6;
    }
}
