﻿
namespace DMZ.UI.UI.Contabil
{
    partial class FrmSinc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbSel = new DMZ.UI.UC.CbDefault();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbActualiza = new DMZ.UI.UC.CbDefault();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbgrupo = new DMZ.UI.UC.DmzProcura();
            this.btnProcess = new System.Windows.Forms.Button();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.dataGridView1 = new DMZ.UI.Generic.GridUi();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Size = new System.Drawing.Size(559, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(527, 2);
            // 
            // cbSel
            // 
            this.cbSel.BackColor = System.Drawing.Color.Transparent;
            this.cbSel.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSel.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSel.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSel.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbSel.CbText = "Selecionar todos ";
            this.cbSel.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSel.Imagem = ((System.Drawing.Image)(resources.GetObject("cbSel.Imagem")));
            this.cbSel.IsOptionGroup = false;
            this.cbSel.IsReadOnly = false;
            this.cbSel.IsRequered = false;
            this.cbSel.Location = new System.Drawing.Point(2, 131);
            this.cbSel.Name = "cbSel";
            this.cbSel.OnlyCheckBox = true;
            this.cbSel.Size = new System.Drawing.Size(167, 22);
            this.cbSel.TabIndex = 34;
            this.cbSel.Value = null;
            this.cbSel.Value2 = null;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbActualiza);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(4, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 45);
            this.panel2.TabIndex = 33;
            // 
            // cbActualiza
            // 
            this.cbActualiza.BackColor = System.Drawing.Color.Transparent;
            this.cbActualiza.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbActualiza.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbActualiza.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActualiza.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbActualiza.CbText = "Actualizar os números de clientes ";
            this.cbActualiza.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbActualiza.Imagem = ((System.Drawing.Image)(resources.GetObject("cbActualiza.Imagem")));
            this.cbActualiza.IsOptionGroup = false;
            this.cbActualiza.IsReadOnly = false;
            this.cbActualiza.IsRequered = false;
            this.cbActualiza.Location = new System.Drawing.Point(8, 7);
            this.cbActualiza.Name = "cbActualiza";
            this.cbActualiza.OnlyCheckBox = true;
            this.cbActualiza.Size = new System.Drawing.Size(325, 22);
            this.cbActualiza.TabIndex = 30;
            this.cbActualiza.Value = null;
            this.cbActualiza.Value2 = null;
            this.cbActualiza.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdate.Image = global::DMZ.UI.Properties.Resources.Save_as_25px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(339, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(205, 31);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Criar as contas no PGC";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbgrupo);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Location = new System.Drawing.Point(4, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 65);
            this.panel1.TabIndex = 32;
            // 
            // tbgrupo
            // 
            this.tbgrupo.BtnEnabled = true;
            this.tbgrupo.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbgrupo.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbgrupo.Condicao = null;
            this.tbgrupo.ExecMetodo = false;
            this.tbgrupo.HideFirstColumn = false;
            this.tbgrupo.InvertColuna = false;
            this.tbgrupo.IsLocaDs = false;
            this.tbgrupo.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbgrupo.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgrupo.Label1Text = "Grupo";
            this.tbgrupo.Location = new System.Drawing.Point(3, 17);
            this.tbgrupo.MySQLQuerry = null;
            this.tbgrupo.Name = "tbgrupo";
            this.tbgrupo.Pp = null;
            this.tbgrupo.Size = new System.Drawing.Size(472, 39);
            this.tbgrupo.SqlComandText = "select conta, descricao from pgc where ano =(select ano from param) \r\nand conta i" +
    "n (\'411\',\'412\',\'418\',\'419\') order by convert(decimal,conta)";
            this.tbgrupo.TabIndex = 29;
            this.tbgrupo.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbgrupo.Tb1Multiline = false;
            this.tbgrupo.Text2 = null;
            this.tbgrupo.Text3 = null;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcess.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnProcess.Location = new System.Drawing.Point(481, 3);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(64, 53);
            this.btnProcess.TabIndex = 28;
            this.btnProcess.UseVisualStyleBackColor = false;
            // 
            // barraText1
            // 
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.White;
            this.barraText1.Label1Text = "Filtragem";
            this.barraText1.Location = new System.Drawing.Point(2, 34);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(555, 30);
            this.barraText1.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AddButtons = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoIncrimento = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CampoCodigo = null;
            this.dataGridView1.Codigo = null;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.codigo,
            this.nome});
            this.dataGridView1.Condicao = null;
            this.dataGridView1.CorPreto = false;
            this.dataGridView1.CurrentColumnName = null;
            this.dataGridView1.DefacolumnName = null;
            this.dataGridView1.DellGridRow = null;
            this.dataGridView1.DtDS = null;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GenerateColumns = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.GridFilha = false;
            this.dataGridView1.GridFilhaSecundaria = false;
            this.dataGridView1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView1.HeadersHeight = 30;
            this.dataGridView1.HeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.OrderbyCampos = null;
            this.dataGridView1.Origem = null;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(551, 397);
            this.dataGridView1.StampCabecalho = null;
            this.dataGridView1.StampLocal = null;
            this.dataGridView1.TabelaSql = null;
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.TbCodigo = null;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "ok";
            this.Status.HeaderText = ".....";
            this.Status.Name = "Status";
            this.Status.Width = 30;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "no";
            this.codigo.HeaderText = "Núnero";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // FrmSinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 609);
            this.Controls.Add(this.barraText1);
            this.Controls.Add(this.cbSel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSinc";
            this.Text = "FrmSinc";
            this.Load += new System.EventHandler(this.FrmSinc_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.cbSel, 0);
            this.Controls.SetChildIndex(this.barraText1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.CbDefault cbSel;
        private System.Windows.Forms.Panel panel2;
        private UC.CbDefault cbActualiza;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        public UC.DmzProcura tbgrupo;
        private System.Windows.Forms.Button btnProcess;
        private UC.BarraText barraText1;
        private Generic.GridUi dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}