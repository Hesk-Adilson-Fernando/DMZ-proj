namespace DMZ.UI.UI
{
    partial class FrmVtmanunt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVtmanunt));
            this.gridPreco = new DMZ.UI.Generic.GridUi();
            this.codccu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Size = new System.Drawing.Size(600, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnPrint, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(568, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.Text = "Manutenção";
            // 
            // gridPreco
            // 
            this.gridPreco.AddButtons = false;
            this.gridPreco.AllowUserToAddRows = false;
            this.gridPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPreco.AutoIncrimento = false;
            this.gridPreco.BackgroundColor = System.Drawing.Color.White;
            this.gridPreco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPreco.CampoCodigo = null;
            this.gridPreco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridPreco.Codigo = null;
            this.gridPreco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPreco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPreco.ColumnHeadersHeight = 30;
            this.gridPreco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPreco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codccu,
            this.matricula,
            this.km,
            this.Motorista});
            this.gridPreco.Condicao = null;
            this.gridPreco.CorPreto = true;
            this.gridPreco.CurrentColumnName = null;
            this.gridPreco.DefacolumnName = null;
            this.gridPreco.DtDS = null;
            this.gridPreco.EnableHeadersVisualStyles = false;
            this.gridPreco.GenerateColumns = false;
            this.gridPreco.GridColor = System.Drawing.Color.SteelBlue;
            this.gridPreco.GridFilha = true;
            this.gridPreco.GridFilhaSecundaria = false;
            this.gridPreco.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPreco.HeadersHeight = 30;
            this.gridPreco.HeadersVisible = false;
            this.gridPreco.Location = new System.Drawing.Point(3, 68);
            this.gridPreco.Name = "gridPreco";
            this.gridPreco.OrderbyCampos = null;
            this.gridPreco.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridPreco.RowHeadersVisible = false;
            this.gridPreco.RowHeadersWidth = 30;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridPreco.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridPreco.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPreco.RowTemplate.Height = 25;
            this.gridPreco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPreco.Size = new System.Drawing.Size(597, 443);
            this.gridPreco.StampCabecalho = "Ststamp";
            this.gridPreco.StampLocal = "StPrecostamp";
            this.gridPreco.TabelaSql = "StPrecos";
            this.gridPreco.TabIndex = 25;
            this.gridPreco.TbCodigo = null;
            // 
            // codccu
            // 
            this.codccu.DataPropertyName = "data";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.codccu.DefaultCellStyle = dataGridViewCellStyle2;
            this.codccu.HeaderText = "Data";
            this.codccu.Name = "codccu";
            // 
            // matricula
            // 
            this.matricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matricula.DataPropertyName = "matricula";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = null;
            this.matricula.DefaultCellStyle = dataGridViewCellStyle3;
            this.matricula.HeaderText = "Matricula ";
            this.matricula.MinimumWidth = 150;
            this.matricula.Name = "matricula";
            // 
            // km
            // 
            this.km.DataPropertyName = "km";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.km.DefaultCellStyle = dataGridViewCellStyle4;
            this.km.HeaderText = "Kilometragem";
            this.km.Name = "km";
            this.km.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.km.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.km.Width = 110;
            // 
            // Motorista
            // 
            this.Motorista.DataPropertyName = "motorista";
            this.Motorista.HeaderText = "Motorista";
            this.Motorista.Name = "Motorista";
            this.Motorista.Width = 200;
            // 
            // barraText1
            // 
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 10F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.White;
            this.barraText1.Label1Text = "Viaturas e máquinas";
            this.barraText1.Location = new System.Drawing.Point(2, 35);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(601, 30);
            this.barraText1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Location = new System.Drawing.Point(4, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 10);
            this.panel1.TabIndex = 27;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.Location = new System.Drawing.Point(532, -5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(30, 36);
            this.btnPrint.TabIndex = 83;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmVtmanunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(603, 523);
            this.Controls.Add(this.gridPreco);
            this.Controls.Add(this.barraText1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVtmanunt";
            this.Text = "Form Classe";
            this.Load += new System.EventHandler(this.FrmVtmanunt_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.barraText1, 0);
            this.Controls.SetChildIndex(this.gridPreco, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Generic.GridUi gridPreco;
        private UC.BarraText barraText1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codccu;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motorista;
        public System.Windows.Forms.Button btnPrint;
    }
}
