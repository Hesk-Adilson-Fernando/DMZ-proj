
namespace DMZ.UI.UI
{
    partial class FrmSuspensos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridProdutos = new DMZ.UI.Generic.GridUi();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sel = new System.Windows.Forms.DataGridViewImageColumn();
            this.factstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(399, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(374, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.Text = "Facturas suspensas ";
            // 
            // gridProdutos
            // 
            this.gridProdutos.AddButtons = true;
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProdutos.AutoIncrimento = false;
            this.gridProdutos.BackgroundColor = System.Drawing.Color.White;
            this.gridProdutos.CampoCodigo = null;
            this.gridProdutos.Codigo = null;
            this.gridProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProdutos.ColumnHeadersHeight = 30;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.total,
            this.sel,
            this.factstamp});
            this.gridProdutos.Condicao = null;
            this.gridProdutos.CorPreto = true;
            this.gridProdutos.CurrentColumnName = null;
            this.gridProdutos.DefacolumnName = null;
            this.gridProdutos.DtDS = null;
            this.gridProdutos.EnableHeadersVisualStyles = false;
            this.gridProdutos.GenerateColumns = false;
            this.gridProdutos.GridColor = System.Drawing.Color.SteelBlue;
            this.gridProdutos.GridFilha = true;
            this.gridProdutos.GridFilhaSecundaria = false;
            this.gridProdutos.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridProdutos.HeadersHeight = 30;
            this.gridProdutos.HeadersVisible = false;
            this.gridProdutos.Location = new System.Drawing.Point(2, 28);
            this.gridProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.OrderbyCampos = null;
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.RowHeadersVisible = false;
            this.gridProdutos.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.gridProdutos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos.Size = new System.Drawing.Size(399, 440);
            this.gridProdutos.StampCabecalho = "";
            this.gridProdutos.StampLocal = "";
            this.gridProdutos.TabelaSql = "";
            this.gridProdutos.TabIndex = 75;
            this.gridProdutos.TbCodigo = null;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome do cliente ";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle2;
            this.total.HeaderText = "Valor ";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // sel
            // 
            this.sel.HeaderText = "...";
            this.sel.Image = global::DMZ.UI.Properties.Resources.Add_List_23px;
            this.sel.Name = "sel";
            this.sel.ReadOnly = true;
            this.sel.Width = 30;
            // 
            // factstamp
            // 
            this.factstamp.DataPropertyName = "factstamp";
            this.factstamp.HeaderText = "factstamp";
            this.factstamp.Name = "factstamp";
            this.factstamp.ReadOnly = true;
            this.factstamp.Visible = false;
            // 
            // FrmSuspensos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 473);
            this.Controls.Add(this.gridProdutos);
            this.Name = "FrmSuspensos";
            this.Text = "FrmSuspensos";
            this.Load += new System.EventHandler(this.FrmSuspensos_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.gridProdutos, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Generic.GridUi gridProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn factstamp;
    }
}