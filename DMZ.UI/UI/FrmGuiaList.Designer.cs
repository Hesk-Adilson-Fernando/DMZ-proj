
namespace DMZ.UI.UI
{
    partial class FrmGuiaList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridItems = new DMZ.UI.Generic.GridUi();
            this.refere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Armazem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnProcess = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(661, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(635, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.Text = "DMZ Software ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GridItems);
            this.panel1.Location = new System.Drawing.Point(2, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 406);
            this.panel1.TabIndex = 25;
            // 
            // GridItems
            // 
            this.GridItems.AddButtons = false;
            this.GridItems.AllowUserToAddRows = false;
            this.GridItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridItems.AutoIncrimento = false;
            this.GridItems.BackgroundColor = System.Drawing.Color.White;
            this.GridItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridItems.CampoCodigo = "ref";
            this.GridItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.GridItems.Codigo = null;
            this.GridItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridItems.ColumnHeadersHeight = 30;
            this.GridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refere,
            this.descricao,
            this.Armazem,
            this.quant,
            this.preco,
            this.dataGridViewTextBoxColumn5});
            this.GridItems.Condicao = null;
            this.GridItems.CorPreto = true;
            this.GridItems.CurrentColumnName = null;
            this.GridItems.DefacolumnName = null;
            this.GridItems.DellGridRow = null;
            this.GridItems.DtDS = null;
            this.GridItems.EnableHeadersVisualStyles = false;
            this.GridItems.GenerateColumns = false;
            this.GridItems.GridColor = System.Drawing.Color.SteelBlue;
            this.GridItems.GridFilha = true;
            this.GridItems.GridFilhaSecundaria = false;
            this.GridItems.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridItems.HeadersHeight = 30;
            this.GridItems.HeadersVisible = false;
            this.GridItems.Location = new System.Drawing.Point(0, 0);
            this.GridItems.Name = "GridItems";
            this.GridItems.OrderbyCampos = null;
            this.GridItems.Origem = null;
            this.GridItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridItems.RowHeadersVisible = false;
            this.GridItems.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.GridItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridItems.Size = new System.Drawing.Size(648, 404);
            this.GridItems.StampCabecalho = "Ststamp";
            this.GridItems.StampLocal = "Starmstamp";
            this.GridItems.TabelaSql = "Starm";
            this.GridItems.TabIndex = 1;
            this.GridItems.TbCodigo = "tbReferenc";
            // 
            // refere
            // 
            this.refere.DataPropertyName = "ref";
            this.refere.HeaderText = "Referência";
            this.refere.Name = "refere";
            this.refere.Width = 110;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // Armazem
            // 
            this.Armazem.DataPropertyName = "Armazem";
            this.Armazem.HeaderText = "Armazem";
            this.Armazem.Name = "Armazem";
            this.Armazem.Width = 120;
            // 
            // quant
            // 
            this.quant.DataPropertyName = "quant";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.quant.DefaultCellStyle = dataGridViewCellStyle2;
            this.quant.HeaderText = "Quant.";
            this.quant.Name = "quant";
            this.quant.Width = 70;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.preco.DefaultCellStyle = dataGridViewCellStyle3;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ok";
            this.dataGridViewTextBoxColumn5.HeaderText = "...";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.Width = 30;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcess.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.Location = new System.Drawing.Point(526, 467);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(125, 33);
            this.btnProcess.TabIndex = 34;
            this.btnProcess.Text = "Processar";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // FrmGuiaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(662, 505);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGuiaList";
            this.Load += new System.EventHandler(this.FrmGuiaList_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnProcess, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Generic.GridUi GridItems;
        public System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn refere;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Armazem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn5;
    }
}
