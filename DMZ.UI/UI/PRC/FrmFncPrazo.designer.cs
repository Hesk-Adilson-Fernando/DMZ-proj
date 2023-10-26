
namespace DMZ.UI.UI.PRC
{
    partial class FrmFncPrazo
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
            this.tbProdMesasProc = new System.Windows.Forms.TextBox();
            this.btnAddprocess = new System.Windows.Forms.Button();
            this.GridProcess = new DMZ.UI.Generic.GridUi();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new DMZ.UI.Generic.TextAndImageColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(517, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(485, 2);
            // 
            // tbProdMesasProc
            // 
            this.tbProdMesasProc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProdMesasProc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbProdMesasProc.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.tbProdMesasProc.Location = new System.Drawing.Point(15, 44);
            this.tbProdMesasProc.Multiline = true;
            this.tbProdMesasProc.Name = "tbProdMesasProc";
            this.tbProdMesasProc.Size = new System.Drawing.Size(491, 30);
            this.tbProdMesasProc.TabIndex = 80;
            // 
            // btnAddprocess
            // 
            this.btnAddprocess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddprocess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddprocess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddprocess.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddprocess.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAddprocess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddprocess.Location = new System.Drawing.Point(383, 516);
            this.btnAddprocess.Name = "btnAddprocess";
            this.btnAddprocess.Size = new System.Drawing.Size(123, 35);
            this.btnAddprocess.TabIndex = 79;
            this.btnAddprocess.Text = "Processar";
            this.btnAddprocess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddprocess.UseVisualStyleBackColor = false;
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
            this.GridProcess.Location = new System.Drawing.Point(12, 80);
            this.GridProcess.Name = "GridProcess";
            this.GridProcess.OrderbyCampos = null;
            this.GridProcess.Origem = null;
            this.GridProcess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridProcess.RowHeadersVisible = false;
            this.GridProcess.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.GridProcess.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProcess.Size = new System.Drawing.Size(494, 430);
            this.GridProcess.StampCabecalho = "Ststamp";
            this.GridProcess.StampLocal = "Starmstamp";
            this.GridProcess.TabelaSql = "Starm";
            this.GridProcess.TabIndex = 78;
            this.GridProcess.TbCodigo = "tbReferenc";
            this.GridProcess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProcess_CellClick);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "nome";
            this.Nome.FillWeight = 108.6294F;
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
            // Status
            // 
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Status.DefaultCellStyle = dataGridViewCellStyle2;
            this.Status.FillWeight = 91.37056F;
            this.Status.HeaderText = "Mais Detalhes";
            this.Status.Image = global::DMZ.UI.Properties.Resources.Right_28px;
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmFncPrazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 563);
            this.Controls.Add(this.tbProdMesasProc);
            this.Controls.Add(this.btnAddprocess);
            this.Controls.Add(this.GridProcess);
            this.Name = "FrmFncPrazo";
            this.Text = "FrmFncPrazo";
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.GridProcess, 0);
            this.Controls.SetChildIndex(this.btnAddprocess, 0);
            this.Controls.SetChildIndex(this.tbProdMesasProc, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProdMesasProc;
        public System.Windows.Forms.Button btnAddprocess;
        private Generic.GridUi GridProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private Generic.TextAndImageColumn Status;
    }
}