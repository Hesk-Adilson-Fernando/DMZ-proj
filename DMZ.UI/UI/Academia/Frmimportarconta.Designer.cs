namespace DMZ.UI.UI.Academia
{
    partial class Frmimportarconta
    { /// <summary>
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTurma = new System.Windows.Forms.ComboBox();
            this.cbPlanopag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEntidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnProcura = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.dataGridView1 = new DMZ.UI.Generic.GridUi();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descanoaem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turmastamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cursostamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_emolumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_limite_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1037, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(1005, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.Text = "Importar conta corrente";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.cbTurma);
            this.panel8.Controls.Add(this.cbPlanopag);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.cbEntidade);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(8, 481);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(758, 48);
            this.panel8.TabIndex = 183;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 189;
            // 
            // cbTurma
            // 
            this.cbTurma.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Location = new System.Drawing.Point(237, 20);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(81, 23);
            this.cbTurma.TabIndex = 188;
            // 
            // cbPlanopag
            // 
            this.cbPlanopag.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlanopag.FormattingEnabled = true;
            this.cbPlanopag.Location = new System.Drawing.Point(3, 20);
            this.cbPlanopag.Name = "cbPlanopag";
            this.cbPlanopag.Size = new System.Drawing.Size(203, 23);
            this.cbPlanopag.TabIndex = 186;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 187;
            this.label4.Text = "Escolha o plano de Pagamento";
            // 
            // cbEntidade
            // 
            this.cbEntidade.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEntidade.FormattingEnabled = true;
            this.cbEntidade.Location = new System.Drawing.Point(389, 20);
            this.cbEntidade.Name = "cbEntidade";
            this.cbEntidade.Size = new System.Drawing.Size(81, 23);
            this.cbEntidade.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Entidade";
            // 
            // BtnProcura
            // 
            this.BtnProcura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProcura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BtnProcura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcura.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BtnProcura.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnProcura.Image = global::DMZ.UI.Properties.Resources.Synchronize_28px;
            this.BtnProcura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProcura.Location = new System.Drawing.Point(928, 39);
            this.BtnProcura.Name = "BtnProcura";
            this.BtnProcura.Size = new System.Drawing.Size(111, 40);
            this.BtnProcura.TabIndex = 184;
            this.BtnProcura.Text = "PROCURAR";
            this.BtnProcura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProcura.UseVisualStyleBackColor = false;
            this.BtnProcura.Click += new System.EventHandler(this.BtnProcura_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnProcessar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessar.Image = global::DMZ.UI.Properties.Resources.Sync_Settings_20px;
            this.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessar.Location = new System.Drawing.Point(916, 496);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(123, 32);
            this.btnProcessar.TabIndex = 185;
            this.btnProcessar.Text = "PROCESSAR";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AddButtons = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoIncrimento = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CampoCodigo = null;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.Codigo = null;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.nome,
            this.Clstamp,
            this.Descurso,
            this.Codigo,
            this.Descanoaem,
            this.Turmastamp,
            this.id,
            this.Cursostamp,
            this.Etapa,
            this.Morada,
            this.Localidade,
            this.Nuit,
            this.tipo_emolumento,
            this.Referencia,
            this.pago,
            this.debito,
            this.data_limite_pagamento,
            this.data_pagamento});
            this.dataGridView1.Condicao = null;
            this.dataGridView1.CorPreto = true;
            this.dataGridView1.CurrentColumnName = null;
            this.dataGridView1.DefacolumnName = null;
            this.dataGridView1.DellGridRow = null;
            this.dataGridView1.DtDS = null;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GenerateColumns = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.GridFilha = false;
            this.dataGridView1.GridFilhaSecundaria = false;
            this.dataGridView1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.HeadersHeight = 30;
            this.dataGridView1.HeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(1, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.OrderbyCampos = "";
            this.dataGridView1.Origem = null;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 374);
            this.dataGridView1.StampCabecalho = "";
            this.dataGridView1.StampLocal = "";
            this.dataGridView1.TabelaSql = "";
            this.dataGridView1.TabIndex = 186;
            this.dataGridView1.TbCodigo = null;
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "Cód. Aluno";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // Clstamp
            // 
            this.Clstamp.DataPropertyName = "Clstamp";
            this.Clstamp.HeaderText = "Clstamp";
            this.Clstamp.Name = "Clstamp";
            this.Clstamp.ReadOnly = true;
            this.Clstamp.Visible = false;
            // 
            // Descurso
            // 
            this.Descurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descurso.DataPropertyName = "Descurso";
            this.Descurso.HeaderText = "Curso";
            this.Descurso.Name = "Descurso";
            this.Descurso.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Turma";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 61;
            // 
            // Descanoaem
            // 
            this.Descanoaem.DataPropertyName = "Descanoaem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            this.Descanoaem.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descanoaem.HeaderText = "Ano/Sem";
            this.Descanoaem.Name = "Descanoaem";
            this.Descanoaem.ReadOnly = true;
            // 
            // Turmastamp
            // 
            this.Turmastamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Turmastamp.DataPropertyName = "Turmastamp";
            this.Turmastamp.HeaderText = "Turmastamp";
            this.Turmastamp.Name = "Turmastamp";
            this.Turmastamp.ReadOnly = true;
            this.Turmastamp.Visible = false;
            this.Turmastamp.Width = 569;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Cursostamp
            // 
            this.Cursostamp.DataPropertyName = "Cursostamp";
            this.Cursostamp.HeaderText = "Cursostamp";
            this.Cursostamp.Name = "Cursostamp";
            this.Cursostamp.ReadOnly = true;
            this.Cursostamp.Visible = false;
            // 
            // Etapa
            // 
            this.Etapa.DataPropertyName = "Etapa";
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.Name = "Etapa";
            this.Etapa.ReadOnly = true;
            // 
            // Morada
            // 
            this.Morada.DataPropertyName = "Morada";
            this.Morada.HeaderText = "Morada";
            this.Morada.Name = "Morada";
            this.Morada.ReadOnly = true;
            this.Morada.Visible = false;
            // 
            // Localidade
            // 
            this.Localidade.DataPropertyName = "Localidade";
            this.Localidade.HeaderText = "Localidade";
            this.Localidade.Name = "Localidade";
            this.Localidade.ReadOnly = true;
            this.Localidade.Visible = false;
            // 
            // Nuit
            // 
            this.Nuit.DataPropertyName = "Nuit";
            this.Nuit.HeaderText = "Nuit";
            this.Nuit.Name = "Nuit";
            this.Nuit.ReadOnly = true;
            this.Nuit.Visible = false;
            // 
            // tipo_emolumento
            // 
            this.tipo_emolumento.DataPropertyName = "tipo_emolumento";
            this.tipo_emolumento.HeaderText = "Descrição";
            this.tipo_emolumento.Name = "tipo_emolumento";
            this.tipo_emolumento.ReadOnly = true;
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "Referencia";
            this.Referencia.HeaderText = "Referência";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // pago
            // 
            this.pago.DataPropertyName = "pago";
            this.pago.HeaderText = "Situacao";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            this.pago.Visible = false;
            // 
            // debito
            // 
            this.debito.DataPropertyName = "debito";
            this.debito.HeaderText = "Valor";
            this.debito.Name = "debito";
            this.debito.ReadOnly = true;
            // 
            // data_limite_pagamento
            // 
            this.data_limite_pagamento.DataPropertyName = "data_limite_pagamento";
            this.data_limite_pagamento.HeaderText = "Limite";
            this.data_limite_pagamento.Name = "data_limite_pagamento";
            this.data_limite_pagamento.ReadOnly = true;
            // 
            // data_pagamento
            // 
            this.data_pagamento.DataPropertyName = "data_pagamento";
            this.data_pagamento.HeaderText = "Pago em:";
            this.data_pagamento.Name = "data_pagamento";
            this.data_pagamento.ReadOnly = true;
            // 
            // Frmimportarconta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.BtnProcura);
            this.Controls.Add(this.panel8);
            this.Name = "Frmimportarconta";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel8, 0);
            this.Controls.SetChildIndex(this.BtnProcura, 0);
            this.Controls.SetChildIndex(this.btnProcessar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbPlanopag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEntidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTurma;
        private System.Windows.Forms.Button BtnProcura;
        private System.Windows.Forms.Button btnProcessar;
        private Generic.GridUi dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descanoaem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turmastamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursostamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_emolumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_limite_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pagamento;
    }
}