
namespace DMZ.UI.UI
{
    partial class FrmMoradas
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
            this.gridUi3 = new DMZ.UI.Generic.GridUi();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sel = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(583, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(554, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.Text = "Moradas ";
            // 
            // gridUi3
            // 
            this.gridUi3.AddButtons = false;
            this.gridUi3.AllowUserToAddRows = false;
            this.gridUi3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUi3.AutoIncrimento = false;
            this.gridUi3.BackgroundColor = System.Drawing.Color.White;
            this.gridUi3.CampoCodigo = null;
            this.gridUi3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUi3.Codigo = null;
            this.gridUi3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi3.ColumnHeadersHeight = 30;
            this.gridUi3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Contacto,
            this.Cel,
            this.sel});
            this.gridUi3.Condicao = null;
            this.gridUi3.CorPreto = true;
            this.gridUi3.CurrentColumnName = null;
            this.gridUi3.DefacolumnName = null;
            this.gridUi3.DtDS = null;
            this.gridUi3.EnableHeadersVisualStyles = false;
            this.gridUi3.GenerateColumns = false;
            this.gridUi3.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUi3.GridFilha = true;
            this.gridUi3.GridFilhaSecundaria = false;
            this.gridUi3.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUi3.HeadersHeight = 30;
            this.gridUi3.HeadersVisible = false;
            this.gridUi3.Location = new System.Drawing.Point(2, 30);
            this.gridUi3.Name = "gridUi3";
            this.gridUi3.OrderbyCampos = null;
            this.gridUi3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUi3.RowHeadersVisible = false;
            this.gridUi3.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi3.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi3.Size = new System.Drawing.Size(582, 283);
            this.gridUi3.StampCabecalho = "clstamp";
            this.gridUi3.StampLocal = "ClMoradastamp";
            this.gridUi3.TabelaSql = "ClMorada";
            this.gridUi3.TabIndex = 25;
            this.gridUi3.TbCodigo = null;
            this.gridUi3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi3_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "zona";
            this.dataGridViewTextBoxColumn8.HeaderText = "Zona";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "morada";
            this.dataGridViewTextBoxColumn9.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Contacto
            // 
            this.Contacto.DataPropertyName = "Pessoa";
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.Width = 150;
            // 
            // Cel
            // 
            this.Cel.DataPropertyName = "Telefone";
            this.Cel.HeaderText = "Telefone";
            this.Cel.Name = "Cel";
            // 
            // sel
            // 
            this.sel.HeaderText = "....";
            this.sel.Image = global::DMZ.UI.Properties.Resources.Proforma_Invoice_22px;
            this.sel.Name = "sel";
            this.sel.Width = 30;
            // 
            // FrmMoradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 325);
            this.Controls.Add(this.gridUi3);
            this.Name = "FrmMoradas";
            this.Load += new System.EventHandler(this.FrmMoradas_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.gridUi3, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Generic.GridUi gridUi3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cel;
        private System.Windows.Forms.DataGridViewImageColumn sel;
    }
}
