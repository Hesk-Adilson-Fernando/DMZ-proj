
namespace DMZ.UI.UI.Contabil
{
    partial class FrmDetalhes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbValorReg = new System.Windows.Forms.TextBox();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.label2 = new System.Windows.Forms.Label();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valordoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewdoc = new DMZ.UI.Generic.TextAndImageColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(513, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(481, 2);
            // 
            // tbValorReg
            // 
            this.tbValorReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorReg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorReg.ForeColor = System.Drawing.Color.Maroon;
            this.tbValorReg.Location = new System.Drawing.Point(278, 552);
            this.tbValorReg.Multiline = true;
            this.tbValorReg.Name = "tbValorReg";
            this.tbValorReg.ReadOnly = true;
            this.tbValorReg.Size = new System.Drawing.Size(228, 26);
            this.tbValorReg.TabIndex = 217;
            this.tbValorReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.gridUi1.BackgroundColor = System.Drawing.Color.Linen;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.Sigla,
            this.numero,
            this.Data,
            this.Valordoc,
            this.localstamp,
            this.viewdoc});
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
            this.gridUi1.Location = new System.Drawing.Point(6, 35);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridUi1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi1.Size = new System.Drawing.Size(504, 511);
            this.gridUi1.StampCabecalho = null;
            this.gridUi1.StampLocal = null;
            this.gridUi1.TabelaSql = null;
            this.gridUi1.TabIndex = 215;
            this.gridUi1.TbCodigo = null;
            this.gridUi1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 226;
            this.label2.Text = "Total";
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Documento.DataPropertyName = "documento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Documento.DefaultCellStyle = dataGridViewCellStyle3;
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 150;
            this.Documento.Name = "Documento";
            // 
            // Sigla
            // 
            this.Sigla.DataPropertyName = "Sigla";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sigla.DefaultCellStyle = dataGridViewCellStyle4;
            this.Sigla.HeaderText = "Sigla";
            this.Sigla.Name = "Sigla";
            this.Sigla.Visible = false;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "nrdoc";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numero.DefaultCellStyle = dataGridViewCellStyle5;
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.Visible = false;
            this.numero.Width = 90;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "dd-MM-yyyy";
            dataGridViewCellStyle6.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Valordoc
            // 
            this.Valordoc.DataPropertyName = "valordoc";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.Valordoc.DefaultCellStyle = dataGridViewCellStyle7;
            this.Valordoc.HeaderText = "Valor Doc.";
            this.Valordoc.Name = "Valordoc";
            this.Valordoc.Width = 150;
            // 
            // localstamp
            // 
            this.localstamp.DataPropertyName = "localstamp";
            this.localstamp.HeaderText = "localstamp";
            this.localstamp.Name = "localstamp";
            this.localstamp.Visible = false;
            // 
            // viewdoc
            // 
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.viewdoc.DefaultCellStyle = dataGridViewCellStyle8;
            this.viewdoc.HeaderText = ".....";
            this.viewdoc.Image = global::DMZ.UI.Properties.Resources.Right_28px;
            this.viewdoc.Name = "viewdoc";
            this.viewdoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viewdoc.Width = 30;
            // 
            // FrmDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbValorReg);
            this.Controls.Add(this.gridUi1);
            this.Name = "FrmDetalhes";
            this.Text = "FrmDetalhes";
            this.Load += new System.EventHandler(this.FrmDetalhes_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.gridUi1, 0);
            this.Controls.SetChildIndex(this.tbValorReg, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbValorReg;
        private Generic.GridUi gridUi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valordoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn localstamp;
        private Generic.TextAndImageColumn viewdoc;
    }
}