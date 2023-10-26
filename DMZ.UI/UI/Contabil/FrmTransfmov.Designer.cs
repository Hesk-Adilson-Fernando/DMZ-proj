namespace DMZ.UI.UI.Contabil
{
    partial class FrmTransfmov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransfmov));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbAno = new DMZ.UI.UC.CbDefault();
            this.tbdestino = new DMZ.UI.UC.Procura();
            this.tbOrigem = new DMZ.UI.UC.Procura();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(410, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(378, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.Text = "Transferir movimentos";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 379);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(408, 5);
            this.panel7.TabIndex = 102;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.cbAno);
            this.panel1.Controls.Add(this.tbdestino);
            this.panel1.Controls.Add(this.tbOrigem);
            this.panel1.Controls.Add(this.btnProcessar);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 338);
            this.panel1.TabIndex = 103;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.numericUpDown1.Location = new System.Drawing.Point(22, 189);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 26);
            this.numericUpDown1.TabIndex = 123;
            // 
            // cbAno
            // 
            this.cbAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAno.BackColor = System.Drawing.Color.Transparent;
            this.cbAno.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAno.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAno.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAno.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbAno.CbText = "Apenas movimentos do ano seguinte";
            this.cbAno.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAno.Imagem = ((System.Drawing.Image)(resources.GetObject("cbAno.Imagem")));
            this.cbAno.IsOptionGroup = false;
            this.cbAno.IsReadOnly = false;
            this.cbAno.IsRequered = false;
            this.cbAno.Location = new System.Drawing.Point(17, 158);
            this.cbAno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAno.Name = "cbAno";
            this.cbAno.OnlyCheckBox = true;
            this.cbAno.Size = new System.Drawing.Size(278, 24);
            this.cbAno.TabIndex = 122;
            this.cbAno.Value = null;
            this.cbAno.Value2 = null;
            // 
            // tbdestino
            // 
            this.tbdestino.AutoComplete = false;
            this.tbdestino.Campo = null;
            this.tbdestino.Campo1 = null;
            this.tbdestino.CampoStatus = false;
            this.tbdestino.ColunaCodigo = "Código";
            this.tbdestino.ColunaDescricao = "Descrição";
            this.tbdestino.Condicao = "";
            this.tbdestino.DependDescricao = null;
            this.tbdestino.Dependente = false;
            this.tbdestino.DependenteNome = null;
            this.tbdestino.Descname = null;
            this.tbdestino.EnableTb1Field = false;
            this.tbdestino.ExecMetodo = false;
            this.tbdestino.FormName = null;
            this.tbdestino.HideFirstColumn = false;
            this.tbdestino.InserirNovo = false;
            this.tbdestino.InvertColuna = false;
            this.tbdestino.IsLocaDs = false;
            this.tbdestino.IsRequered = false;
            this.tbdestino.IsSqlSelect = true;
            this.tbdestino.Istatus = false;
            this.tbdestino.IsUnique = false;
            this.tbdestino.Items = null;
            this.tbdestino.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbdestino.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdestino.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbdestino.Label1Text = "Conta Destino";
            this.tbdestino.Location = new System.Drawing.Point(17, 109);
            this.tbdestino.MultDocumento = false;
            this.tbdestino.Name = "tbdestino";
            this.tbdestino.OpenInfo = false;
            this.tbdestino.ParentFormName = null;
            this.tbdestino.Pp = null;
            this.tbdestino.ReturnDt = false;
            this.tbdestino.Selecionado = "Familiastamp,descricao";
            this.tbdestino.ShowThirdColumn = false;
            this.tbdestino.Size = new System.Drawing.Size(321, 42);
            this.tbdestino.SqlComandText = "select conta,Descricao from pgc where ano =(select ano from param)";
            this.tbdestino.Tabela = "familia";
            this.tbdestino.TabIndex = 121;
            this.tbdestino.TbCkUpdate = false;
            this.tbdestino.TbClear = false;
            this.tbdestino.TbUpDate = null;
            this.tbdestino.Text2 = null;
            this.tbdestino.Text3 = null;
            this.tbdestino.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbdestino.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbdestino.Titulo = "Procurar";
            this.tbdestino.TmpFound = null;
            this.tbdestino.UpdateTextBox = null;
            this.tbdestino.Value = "depex";
            this.tbdestino.Value2 = "";
            this.tbdestino.Value3 = null;
            this.tbdestino.Load += new System.EventHandler(this.procura1_Load);
            // 
            // tbOrigem
            // 
            this.tbOrigem.AutoComplete = false;
            this.tbOrigem.Campo = null;
            this.tbOrigem.Campo1 = null;
            this.tbOrigem.CampoStatus = false;
            this.tbOrigem.ColunaCodigo = "Código";
            this.tbOrigem.ColunaDescricao = "Descrição";
            this.tbOrigem.Condicao = "";
            this.tbOrigem.DependDescricao = null;
            this.tbOrigem.Dependente = false;
            this.tbOrigem.DependenteNome = null;
            this.tbOrigem.Descname = null;
            this.tbOrigem.EnableTb1Field = false;
            this.tbOrigem.ExecMetodo = false;
            this.tbOrigem.FormName = null;
            this.tbOrigem.HideFirstColumn = false;
            this.tbOrigem.InserirNovo = false;
            this.tbOrigem.InvertColuna = false;
            this.tbOrigem.IsLocaDs = false;
            this.tbOrigem.IsRequered = false;
            this.tbOrigem.IsSqlSelect = true;
            this.tbOrigem.Istatus = false;
            this.tbOrigem.IsUnique = false;
            this.tbOrigem.Items = null;
            this.tbOrigem.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrigem.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigem.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbOrigem.Label1Text = "Conta Origem ";
            this.tbOrigem.Location = new System.Drawing.Point(17, 61);
            this.tbOrigem.MultDocumento = false;
            this.tbOrigem.Name = "tbOrigem";
            this.tbOrigem.OpenInfo = false;
            this.tbOrigem.ParentFormName = null;
            this.tbOrigem.Pp = null;
            this.tbOrigem.ReturnDt = false;
            this.tbOrigem.Selecionado = "Familiastamp,descricao";
            this.tbOrigem.ShowThirdColumn = false;
            this.tbOrigem.Size = new System.Drawing.Size(321, 42);
            this.tbOrigem.SqlComandText = "select conta,Descricao from pgc where ano =(select ano from param)";
            this.tbOrigem.Tabela = "familia";
            this.tbOrigem.TabIndex = 120;
            this.tbOrigem.TbCkUpdate = false;
            this.tbOrigem.TbClear = false;
            this.tbOrigem.TbUpDate = null;
            this.tbOrigem.Text2 = null;
            this.tbOrigem.Text3 = null;
            this.tbOrigem.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.tbOrigem.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.tbOrigem.Titulo = "Procurar";
            this.tbOrigem.TmpFound = null;
            this.tbOrigem.UpdateTextBox = null;
            this.tbOrigem.Value = "depex";
            this.tbOrigem.Value2 = "";
            this.tbOrigem.Value3 = null;
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
            this.btnProcessar.Location = new System.Drawing.Point(276, 295);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(123, 32);
            this.btnProcessar.TabIndex = 94;
            this.btnProcessar.Text = "PROCESSAR";
            this.btnProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessar.UseVisualStyleBackColor = false;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // FrmTransfmov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Name = "FrmTransfmov";
            this.Text = "FrmTransfmov";
            this.Load += new System.EventHandler(this.FrmTransfmov_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcessar;
        private UC.Procura tbdestino;
        private UC.Procura tbOrigem;
        private UC.CbDefault cbAno;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}