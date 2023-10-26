using System.Windows.Forms;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    partial class Aresult
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbFase = new DMZ.UI.UC.DmzProcura();
            this.cbMeses = new DMZ.UI.UC.DmzProcura();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLancar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.dgvML = new DMZ.UI.Generic.GridUi();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debitosaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbContamov = new System.Windows.Forms.CheckBox();
            this.cbIRPC = new System.Windows.Forms.CheckBox();
            this.tbDoisDigitos = new System.Windows.Forms.CheckBox();
            this.cbSequenc = new System.Windows.Forms.CheckBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvML)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Size = new System.Drawing.Size(848, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnPrint, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(816, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.Text = "APURAMENTO DE RESULTADOS ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbDoisDigitos);
            this.panel1.Controls.Add(this.cbIRPC);
            this.panel1.Controls.Add(this.cbContamov);
            this.panel1.Controls.Add(this.cmbFase);
            this.panel1.Controls.Add(this.cbMeses);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cbSequenc);
            this.panel1.Location = new System.Drawing.Point(6, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 109);
            this.panel1.TabIndex = 434;
            // 
            // cmbFase
            // 
            this.cmbFase.BtnEnabled = true;
            this.cmbFase.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbFase.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbFase.Condicao = null;
            this.cmbFase.ExecMetodo = false;
            this.cmbFase.HideFirstColumn = false;
            this.cmbFase.InvertColuna = false;
            this.cmbFase.IsLocaDs = false;
            this.cmbFase.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFase.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFase.Label1Text = "Ordem de apuramento";
            this.cmbFase.Location = new System.Drawing.Point(3, 5);
            this.cmbFase.MySQLQuerry = null;
            this.cmbFase.Name = "cmbFase";
            this.cmbFase.Pp = null;
            this.cmbFase.Size = new System.Drawing.Size(290, 39);
            this.cmbFase.SqlComandText = "select conta,ltrim(rtrim(str(sequec)))+\'-\'+ltrim(rtrim(descricao)) as descricao f" +
    "rom apparam\r\n                                    where origem = \'RES\' order by s" +
    "equec";
            this.cmbFase.TabIndex = 454;
            this.cmbFase.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFase.Tb1Multiline = false;
            this.cmbFase.Text2 = null;
            this.cmbFase.Text3 = null;
            this.cmbFase.Text4 = null;
            // 
            // cbMeses
            // 
            this.cbMeses.BtnEnabled = true;
            this.cbMeses.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMeses.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMeses.Condicao = null;
            this.cbMeses.ExecMetodo = false;
            this.cbMeses.HideFirstColumn = false;
            this.cbMeses.InvertColuna = false;
            this.cbMeses.IsLocaDs = false;
            this.cbMeses.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMeses.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMeses.Label1Text = "Mês de apuramento";
            this.cbMeses.Location = new System.Drawing.Point(3, 48);
            this.cbMeses.MySQLQuerry = null;
            this.cbMeses.Name = "cbMeses";
            this.cbMeses.Pp = null;
            this.cbMeses.Size = new System.Drawing.Size(290, 39);
            this.cbMeses.SqlComandText = "select codigo,ltrim(rtrim(mes)) as descricao from mescont order by Convert(decima" +
    "l,codigo)";
            this.cbMeses.TabIndex = 456;
            this.cbMeses.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMeses.Tb1Multiline = false;
            this.cbMeses.Text2 = null;
            this.cbMeses.Text3 = null;
            this.cbMeses.Text4 = null;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Image = global::DMZ.UI.Properties.Resources.Automatic_251px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(750, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 50);
            this.button2.TabIndex = 452;
            this.button2.Text = "Processar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLancar);
            this.panel2.Location = new System.Drawing.Point(5, 554);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 38);
            this.panel2.TabIndex = 435;
            // 
            // btnLancar
            // 
            this.btnLancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnLancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLancar.Image = global::DMZ.UI.Properties.Resources.loading_25px;
            this.btnLancar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLancar.Location = new System.Drawing.Point(706, 3);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(132, 30);
            this.btnLancar.TabIndex = 453;
            this.btnLancar.Text = "Lançamento";
            this.btnLancar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(753, -3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(29, 32);
            this.btnPrint.TabIndex = 82;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.Image = global::DMZ.UI.Properties.Resources.Maximize_Window_25px;
            this.btnMaxMin.Location = new System.Drawing.Point(788, 3);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 86;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // dgvML
            // 
            this.dgvML.AddButtons = false;
            this.dgvML.AllowUserToAddRows = false;
            this.dgvML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvML.AutoIncrimento = false;
            this.dgvML.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvML.CampoCodigo = null;
            this.dgvML.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvML.Codigo = null;
            this.dgvML.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvML.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvML.ColumnHeadersHeight = 30;
            this.dgvML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvML.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conta,
            this.descricao,
            this.deb,
            this.Cre,
            this.Debitosaldo});
            this.dgvML.Condicao = null;
            this.dgvML.CorPreto = true;
            this.dgvML.CurrentColumnName = null;
            this.dgvML.DefacolumnName = null;
            this.dgvML.DellGridRow = null;
            this.dgvML.DtDS = null;
            this.dgvML.EnableHeadersVisualStyles = false;
            this.dgvML.GenerateColumns = false;
            this.dgvML.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvML.GridFilha = true;
            this.dgvML.GridFilhaSecundaria = false;
            this.dgvML.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvML.HeadersHeight = 30;
            this.dgvML.HeadersVisible = false;
            this.dgvML.Location = new System.Drawing.Point(6, 154);
            this.dgvML.Name = "dgvML";
            this.dgvML.OrderbyCampos = null;
            this.dgvML.Origem = null;
            this.dgvML.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvML.RowHeadersVisible = false;
            this.dgvML.RowHeadersWidth = 30;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvML.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvML.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvML.Size = new System.Drawing.Size(843, 399);
            this.dgvML.StampCabecalho = "Ststamp";
            this.dgvML.StampLocal = "StPrecostamp";
            this.dgvML.TabelaSql = "StPrecos";
            this.dgvML.TabIndex = 486;
            this.dgvML.TbCodigo = null;
            this.dgvML.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvML_CellFormatting);
            // 
            // conta
            // 
            this.conta.DataPropertyName = "conta";
            this.conta.HeaderText = "Conta";
            this.conta.Name = "conta";
            this.conta.Width = 130;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // deb
            // 
            this.deb.DataPropertyName = "deb";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.deb.DefaultCellStyle = dataGridViewCellStyle7;
            this.deb.HeaderText = "Débito";
            this.deb.Name = "deb";
            this.deb.Width = 120;
            // 
            // Cre
            // 
            this.Cre.DataPropertyName = "cre";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.Cre.DefaultCellStyle = dataGridViewCellStyle8;
            this.Cre.HeaderText = "Crédito";
            this.Cre.Name = "Cre";
            this.Cre.Width = 120;
            // 
            // Debitosaldo
            // 
            this.Debitosaldo.DataPropertyName = "sequec";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.Debitosaldo.DefaultCellStyle = dataGridViewCellStyle9;
            this.Debitosaldo.HeaderText = "Ordem";
            this.Debitosaldo.Name = "Debitosaldo";
            this.Debitosaldo.Width = 50;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 593);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(852, 5);
            this.panel6.TabIndex = 490;
            // 
            // cbContamov
            // 
            this.cbContamov.AutoSize = true;
            this.cbContamov.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbContamov.Location = new System.Drawing.Point(377, 5);
            this.cbContamov.Name = "cbContamov";
            this.cbContamov.Size = new System.Drawing.Size(271, 25);
            this.cbContamov.TabIndex = 457;
            this.cbContamov.Text = "Apenas contas movimentadas";
            this.cbContamov.UseVisualStyleBackColor = true;
            // 
            // cbIRPC
            // 
            this.cbIRPC.AutoSize = true;
            this.cbIRPC.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbIRPC.Location = new System.Drawing.Point(377, 41);
            this.cbIRPC.Name = "cbIRPC";
            this.cbIRPC.Size = new System.Drawing.Size(343, 25);
            this.cbIRPC.TabIndex = 457;
            this.cbIRPC.Text = "Processar o Imposto sobre o Rendimento";
            this.cbIRPC.UseVisualStyleBackColor = true;
            // 
            // tbDoisDigitos
            // 
            this.tbDoisDigitos.AutoSize = true;
            this.tbDoisDigitos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbDoisDigitos.Location = new System.Drawing.Point(377, 77);
            this.tbDoisDigitos.Name = "tbDoisDigitos";
            this.tbDoisDigitos.Size = new System.Drawing.Size(180, 25);
            this.tbDoisDigitos.TabIndex = 457;
            this.tbDoisDigitos.Text = "Só contas Principais";
            this.tbDoisDigitos.UseVisualStyleBackColor = true;
            // 
            // cbSequenc
            // 
            this.cbSequenc.AutoSize = true;
            this.cbSequenc.Checked = true;
            this.cbSequenc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSequenc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbSequenc.Location = new System.Drawing.Point(377, 46);
            this.cbSequenc.Name = "cbSequenc";
            this.cbSequenc.Size = new System.Drawing.Size(237, 25);
            this.cbSequenc.TabIndex = 457;
            this.cbSequenc.Text = "Apuramento sequenciado";
            this.cbSequenc.UseVisualStyleBackColor = true;
            this.cbSequenc.Visible = false;
            // 
            // Aresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 598);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dgvML);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Aresult";
            this.Text = "Apuramento de Resultados";
            this.Load += new System.EventHandler(this.Aresult_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.dgvML, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvML)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Button btnLancar;
        public Button btnMaxMin;
        private UC.DmzProcura cbMeses;
        private UC.DmzProcura cmbFase;
        private GridUi dgvML;
        private Panel panel6;
        private DataGridViewTextBoxColumn conta;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn deb;
        private DataGridViewTextBoxColumn Cre;
        private DataGridViewTextBoxColumn Debitosaldo;
        private CheckBox tbDoisDigitos;
        private CheckBox cbIRPC;
        private CheckBox cbContamov;
        private CheckBox cbSequenc;
    }
}