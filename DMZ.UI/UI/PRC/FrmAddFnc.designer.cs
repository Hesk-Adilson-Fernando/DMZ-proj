
namespace DMZ.UI.UI.PRC
{
    partial class FrmAddFnc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbProdMesasProc = new System.Windows.Forms.TextBox();
            this.btnAddprocess = new System.Windows.Forms.Button();
            this.GridProcess = new DMZ.UI.Generic.GridUi();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjescstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(541, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(511, 2);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbProdMesasProc);
            this.panel1.Controls.Add(this.btnAddprocess);
            this.panel1.Controls.Add(this.GridProcess);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 477);
            this.panel1.TabIndex = 27;
            // 
            // tbProdMesasProc
            // 
            this.tbProdMesasProc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProdMesasProc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbProdMesasProc.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.tbProdMesasProc.Location = new System.Drawing.Point(8, 15);
            this.tbProdMesasProc.Multiline = true;
            this.tbProdMesasProc.Name = "tbProdMesasProc";
            this.tbProdMesasProc.Size = new System.Drawing.Size(518, 30);
            this.tbProdMesasProc.TabIndex = 77;
            this.tbProdMesasProc.TextChanged += new System.EventHandler(this.tbProdMesasProc_TextChanged);
            // 
            // btnAddprocess
            // 
            this.btnAddprocess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddprocess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddprocess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddprocess.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddprocess.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddprocess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddprocess.Location = new System.Drawing.Point(408, 436);
            this.btnAddprocess.Name = "btnAddprocess";
            this.btnAddprocess.Size = new System.Drawing.Size(123, 35);
            this.btnAddprocess.TabIndex = 76;
            this.btnAddprocess.Text = "Processar";
            this.btnAddprocess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddprocess.UseVisualStyleBackColor = false;
            this.btnAddprocess.Click += new System.EventHandler(this.btnAddprocess_Click);
            // 
            // GridProcess
            // 
            this.GridProcess.AddButtons = false;
            this.GridProcess.AllowUserToAddRows = false;
            this.GridProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridProcess.AutoIncrimento = false;
            this.GridProcess.BackgroundColor = System.Drawing.Color.White;
            this.GridProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridProcess.CampoCodigo = "ref";
            this.GridProcess.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.GridProcess.Codigo = null;
            this.GridProcess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProcess.ColumnHeadersHeight = 30;
            this.GridProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.no,
            this.pjescstamp,
            this.familia,
            this.Status});
            this.GridProcess.Condicao = null;
            this.GridProcess.CorPreto = true;
            this.GridProcess.CurrentColumnName = null;
            this.GridProcess.DefacolumnName = null;
            this.GridProcess.DellGridRow = null;
            this.GridProcess.DtDS = null;
            this.GridProcess.EnableHeadersVisualStyles = false;
            this.GridProcess.GenerateColumns = false;
            this.GridProcess.GridColor = System.Drawing.Color.SteelBlue;
            this.GridProcess.GridFilha = true;
            this.GridProcess.GridFilhaSecundaria = false;
            this.GridProcess.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridProcess.HeadersHeight = 30;
            this.GridProcess.HeadersVisible = false;
            this.GridProcess.Location = new System.Drawing.Point(5, 51);
            this.GridProcess.Name = "GridProcess";
            this.GridProcess.OrderbyCampos = null;
            this.GridProcess.Origem = null;
            this.GridProcess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridProcess.RowHeadersVisible = false;
            this.GridProcess.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.GridProcess.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProcess.Size = new System.Drawing.Size(525, 379);
            this.GridProcess.StampCabecalho = "Ststamp";
            this.GridProcess.StampLocal = "Starmstamp";
            this.GridProcess.TabelaSql = "Starm";
            this.GridProcess.TabIndex = 29;
            this.GridProcess.TbCodigo = "tbReferenc";
            this.GridProcess.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProcess_CellDoubleClick);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Fornecedor";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "no";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Visible = false;
            // 
            // pjescstamp
            // 
            this.pjescstamp.DataPropertyName = "Procurmlstamp";
            this.pjescstamp.HeaderText = "pjescstamp";
            this.pjescstamp.Name = "pjescstamp";
            this.pjescstamp.Visible = false;
            // 
            // familia
            // 
            this.familia.DataPropertyName = "familia";
            this.familia.HeaderText = "familia";
            this.familia.Name = "familia";
            this.familia.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "ok";
            this.Status.HeaderText = "....";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 30;
            // 
            // FrmAddFnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 515);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddFnc";
            this.Text = "FrmAddFnc";
            this.Load += new System.EventHandler(this.FrmAddFnc_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnAddprocess;
        private Generic.GridUi GridProcess;
        private System.Windows.Forms.TextBox tbProdMesasProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn pjescstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn familia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}