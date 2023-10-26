
namespace DMZ.UI.UI
{
    partial class FrmPosPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPosPrint));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cbNumero = new DMZ.UI.UC.CbDefault();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.gridProdutos = new DMZ.UI.Generic.GridUi();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.print2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.factstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(735, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(703, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.Text = "Facturas ";
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.cbNumero);
            this.panel15.Controls.Add(this.dateTimePicker1);
            this.panel15.Controls.Add(this.btnRefrescar);
            this.panel15.Controls.Add(this.textBox2);
            this.panel15.Controls.Add(this.panel11);
            this.panel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.panel15.Location = new System.Drawing.Point(3, 33);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(733, 502);
            this.panel15.TabIndex = 96;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            // 
            // cbNumero
            // 
            this.cbNumero.BackColor = System.Drawing.Color.Transparent;
            this.cbNumero.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumero.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbNumero.CbText = "Pelo número documento";
            this.cbNumero.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNumero.Imagem = ((System.Drawing.Image)(resources.GetObject("cbNumero.Imagem")));
            this.cbNumero.IsOptionGroup = false;
            this.cbNumero.IsReadOnly = false;
            this.cbNumero.IsRequered = false;
            this.cbNumero.Location = new System.Drawing.Point(3, 5);
            this.cbNumero.Name = "cbNumero";
            this.cbNumero.OnlyCheckBox = true;
            this.cbNumero.Size = new System.Drawing.Size(195, 25);
            this.cbNumero.TabIndex = 108;
            this.cbNumero.Value = null;
            this.cbNumero.Value2 = null;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(587, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 21);
            this.dateTimePicker1.TabIndex = 107;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRefrescar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRefrescar.Image = global::DMZ.UI.Properties.Resources.Synchronize_28px;
            this.btnRefrescar.Location = new System.Drawing.Point(694, -1);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(32, 33);
            this.btnRefrescar.TabIndex = 106;
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(723, 29);
            this.textBox2.TabIndex = 96;
            this.textBox2.Tag = "Escreva a descricao do artigo";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Controls.Add(this.gridProdutos);
            this.panel11.Location = new System.Drawing.Point(5, 63);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(722, 428);
            this.panel11.TabIndex = 92;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProdutos.ColumnHeadersHeight = 30;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referencia,
            this.nome,
            this.preco,
            this.print2,
            this.factstamp});
            this.gridProdutos.Condicao = null;
            this.gridProdutos.CorPreto = true;
            this.gridProdutos.CurrentColumnName = null;
            this.gridProdutos.DefacolumnName = null;
            this.gridProdutos.DtDS = null;
            this.gridProdutos.EnableHeadersVisualStyles = false;
            this.gridProdutos.GenerateColumns = false;
            this.gridProdutos.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.gridProdutos.GridFilha = true;
            this.gridProdutos.GridFilhaSecundaria = false;
            this.gridProdutos.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridProdutos.HeadersHeight = 30;
            this.gridProdutos.HeadersVisible = false;
            this.gridProdutos.Location = new System.Drawing.Point(3, 4);
            this.gridProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.OrderbyCampos = null;
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gridProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProdutos.RowTemplate.Height = 28;
            this.gridProdutos.Size = new System.Drawing.Size(716, 421);
            this.gridProdutos.StampCabecalho = "";
            this.gridProdutos.StampLocal = "";
            this.gridProdutos.TabelaSql = "";
            this.gridProdutos.TabIndex = 74;
            this.gridProdutos.TbCodigo = null;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
            // 
            // referencia
            // 
            this.referencia.DataPropertyName = "numero";
            this.referencia.HeaderText = "Número";
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome do cliente ";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.preco.DefaultCellStyle = dataGridViewCellStyle2;
            this.preco.HeaderText = "Valor ";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 150;
            // 
            // print2
            // 
            this.print2.HeaderText = "....";
            this.print2.Image = global::DMZ.UI.Properties.Resources.Print_25px;
            this.print2.Name = "print2";
            this.print2.ReadOnly = true;
            this.print2.Width = 30;
            // 
            // factstamp
            // 
            this.factstamp.DataPropertyName = "factstamp";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.factstamp.DefaultCellStyle = dataGridViewCellStyle3;
            this.factstamp.HeaderText = "stamp";
            this.factstamp.Name = "factstamp";
            this.factstamp.ReadOnly = true;
            this.factstamp.Visible = false;
            // 
            // FrmPosPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(736, 541);
            this.Controls.Add(this.panel15);
            this.Name = "FrmPosPrint";
            this.Load += new System.EventHandler(this.FrmPosPrint_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel15, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel11;
        public Generic.GridUi gridProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewImageColumn print2;
        private System.Windows.Forms.DataGridViewTextBoxColumn factstamp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRefrescar;
        private UC.CbDefault cbNumero;
    }
}
