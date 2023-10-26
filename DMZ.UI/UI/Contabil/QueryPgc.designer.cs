using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    partial class QueryPgc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryPgc));
            this.dgvContas = new DMZ.UI.Generic.GridUi();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtFindByRef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(639, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(607, 2);
            // 
            // dgvContas
            // 
            this.dgvContas.AddButtons = false;
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.AutoIncrimento = false;
            this.dgvContas.BackgroundColor = System.Drawing.Color.White;
            this.dgvContas.CampoCodigo = null;
            this.dgvContas.Codigo = null;
            this.dgvContas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContas.ColumnHeadersHeight = 30;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conta,
            this.descricao});
            this.dgvContas.Condicao = null;
            this.dgvContas.CorPreto = false;
            this.dgvContas.CurrentColumnName = null;
            this.dgvContas.DefacolumnName = null;
            this.dgvContas.DtDS = null;
            this.dgvContas.EnableHeadersVisualStyles = false;
            this.dgvContas.GenerateColumns = false;
            this.dgvContas.GridColor = System.Drawing.Color.White;
            this.dgvContas.GridFilha = false;
            this.dgvContas.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvContas.HeadersHeight = 30;
            this.dgvContas.HeadersVisible = false;
            this.dgvContas.Location = new System.Drawing.Point(1, 62);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.RowHeadersWidth = 15;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvContas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContas.Size = new System.Drawing.Size(640, 304);
            this.dgvContas.StampCabecalho = null;
            this.dgvContas.StampLocal = null;
            this.dgvContas.TabelaSql = null;
            this.dgvContas.TabIndex = 0;
            this.dgvContas.TbCodigo = null;
            this.dgvContas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_CellDoubleClick);
            this.dgvContas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvContas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(213, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descrição (F3)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.Move += new System.EventHandler(this.textBox1_Move);
            // 
            // txtFindByRef
            // 
            this.txtFindByRef.Location = new System.Drawing.Point(78, 36);
            this.txtFindByRef.Name = "txtFindByRef";
            this.txtFindByRef.Size = new System.Drawing.Size(120, 20);
            this.txtFindByRef.TabIndex = 11;
            this.txtFindByRef.TextChanged += new System.EventHandler(this.txtFindByRef_TextChanged);
            this.txtFindByRef.Enter += new System.EventHandler(this.txtFindByRef_Enter);
            this.txtFindByRef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFindByRef_KeyDown);
            this.txtFindByRef.Leave += new System.EventHandler(this.txtFindByRef_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Conta (F2)";
            // 
            // conta
            // 
            this.conta.DataPropertyName = "conta";
            this.conta.HeaderText = "Conta";
            this.conta.Name = "conta";
            this.conta.ReadOnly = true;
            this.conta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.conta.Width = 120;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QueryPgc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtFindByRef);
            this.Controls.Add(this.dgvContas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryPgc";
            this.Text = "Pequisa de Contas";
            this.Load += new System.EventHandler(this.QueryPgc_Load);
            this.Controls.SetChildIndex(this.dgvContas, 0);
            this.Controls.SetChildIndex(this.txtFindByRef, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TextBox txtFindByRef;
        private System.Windows.Forms.Label label3;
        private GridUi dgvContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}