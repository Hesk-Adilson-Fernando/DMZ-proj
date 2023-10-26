namespace DMZ.UI.UI
{
    partial class FrmViewDocs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid = new DMZ.UI.Generic.GridUi();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new DMZ.UI.Generic.TextAndImageColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origem = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(403, 28);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(373, 1);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.Text = "Documentos ";
            // 
            // Grid
            // 
            this.Grid.AddButtons = false;
            this.Grid.AllowUserToAddRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoIncrimento = false;
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.CampoCodigo = "ref";
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Grid.Codigo = null;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeight = 30;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nome,
            this.Quant,
            this.distamp,
            this.Origem});
            this.Grid.Condicao = null;
            this.Grid.CorPreto = true;
            this.Grid.CurrentColumnName = null;
            this.Grid.DefacolumnName = null;
            this.Grid.DtDS = null;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GenerateColumns = false;
            this.Grid.GridColor = System.Drawing.Color.SteelBlue;
            this.Grid.GridFilha = true;
            this.Grid.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.HeadersHeight = 30;
            this.Grid.HeadersVisible = false;
            this.Grid.Location = new System.Drawing.Point(7, 39);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(390, 281);
            this.Grid.StampCabecalho = "Ststamp";
            this.Grid.StampLocal = "Starmstamp";
            this.Grid.TabelaSql = "Starm";
            this.Grid.TabIndex = 25;
            this.Grid.TbCodigo = "tbReferenc";
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Nº Doc.";
            this.numero.Name = "numero";
            this.numero.Width = 50;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.nome.HeaderText = "Entidade";
            this.nome.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.nome.Name = "nome";
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Quant
            // 
            this.Quant.DataPropertyName = "Quant";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.Quant.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quant.HeaderText = "Quant.";
            this.Quant.Name = "Quant";
            this.Quant.ReadOnly = true;
            this.Quant.Width = 80;
            // 
            // distamp
            // 
            this.distamp.DataPropertyName = "distamp";
            this.distamp.HeaderText = "distamp";
            this.distamp.Name = "distamp";
            this.distamp.Visible = false;
            // 
            // Origem
            // 
            this.Origem.HeaderText = "...";
            this.Origem.Image = global::DMZ.UI.Properties.Resources.Right_28px;
            this.Origem.Name = "Origem";
            this.Origem.Width = 30;
            // 
            // FrmViewDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(404, 332);
            this.Controls.Add(this.Grid);
            this.Name = "FrmViewDocs";
            this.Load += new System.EventHandler(this.FrmViewDocs_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.Grid, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Generic.GridUi Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private Generic.TextAndImageColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn distamp;
        private System.Windows.Forms.DataGridViewImageColumn Origem;
    }
}
