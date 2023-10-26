namespace DMZ.UI.IMB
{
    partial class FrmDep
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dmzOptionGroup2 = new DMZ.UI.UC.DmzOptionGroup();
            this.cbQuotas = new DMZ.UI.UC.CbDefault();
            this.cbDuod = new DMZ.UI.UC.CbDefault();
            this.dmzOptionGroup1 = new DMZ.UI.UC.DmzOptionGroup();
            this.cbContabilistico = new DMZ.UI.UC.CbDefault();
            this.cbFiscal = new DMZ.UI.UC.CbDefault();
            this.txtPercentagem = new DMZ.UI.UC.DMZTexBoxX();
            this.dtDataFiscal = new DMZ.UI.UC.DtDefault();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.dmzOptionGroup2.SuspendLayout();
            this.dmzOptionGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(316, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(284, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.Text = "Processamento de depreciações ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dmzOptionGroup2);
            this.panel1.Controls.Add(this.dmzOptionGroup1);
            this.panel1.Controls.Add(this.txtPercentagem);
            this.panel1.Controls.Add(this.dtDataFiscal);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 338);
            this.panel1.TabIndex = 25;
            // 
            // dmzOptionGroup2
            // 
            this.dmzOptionGroup2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzOptionGroup2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzOptionGroup2.ButtonCount = 0;
            this.dmzOptionGroup2.Controls.Add(this.cbQuotas);
            this.dmzOptionGroup2.Controls.Add(this.cbDuod);
            this.dmzOptionGroup2.Imagem = global::DMZ.UI.Properties.Resources.Bulleted_List_20px;
            this.dmzOptionGroup2.IsRequered = false;
            this.dmzOptionGroup2.Label1Text = "Método de depreciações";
            this.dmzOptionGroup2.Location = new System.Drawing.Point(14, 213);
            this.dmzOptionGroup2.Name = "dmzOptionGroup2";
            this.dmzOptionGroup2.PanelBackColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzOptionGroup2.Size = new System.Drawing.Size(275, 80);
            this.dmzOptionGroup2.TabIndex = 101;
            this.dmzOptionGroup2.Value = "tipofilter";
            // 
            // cbQuotas
            // 
            this.cbQuotas.BackColor = System.Drawing.Color.Transparent;
            this.cbQuotas.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbQuotas.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbQuotas.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuotas.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbQuotas.CbText = "Quotas Constantes";
            this.cbQuotas.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbQuotas.Enabled = false;
            this.cbQuotas.Imagem = global::DMZ.UI.Properties.Resources.Circle_23px1;
            this.cbQuotas.IsOptionGroup = false;
            this.cbQuotas.IsReadOnly = true;
            this.cbQuotas.IsRequered = false;
            this.cbQuotas.Location = new System.Drawing.Point(6, 50);
            this.cbQuotas.Name = "cbQuotas";
            this.cbQuotas.OnlyCheckBox = false;
            this.cbQuotas.Size = new System.Drawing.Size(177, 22);
            this.cbQuotas.TabIndex = 80;
            this.cbQuotas.Value = null;
            this.cbQuotas.Value2 = "2";
            // 
            // cbDuod
            // 
            this.cbDuod.BackColor = System.Drawing.Color.Transparent;
            this.cbDuod.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDuod.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDuod.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuod.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDuod.CbText = "Duodécimos";
            this.cbDuod.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDuod.Enabled = false;
            this.cbDuod.Imagem = global::DMZ.UI.Properties.Resources.Circle_23px1;
            this.cbDuod.IsOptionGroup = false;
            this.cbDuod.IsReadOnly = true;
            this.cbDuod.IsRequered = false;
            this.cbDuod.Location = new System.Drawing.Point(6, 27);
            this.cbDuod.Name = "cbDuod";
            this.cbDuod.OnlyCheckBox = false;
            this.cbDuod.Size = new System.Drawing.Size(177, 22);
            this.cbDuod.TabIndex = 79;
            this.cbDuod.Value = "Tipodoc";
            this.cbDuod.Value2 = "1";
            // 
            // dmzOptionGroup1
            // 
            this.dmzOptionGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzOptionGroup1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzOptionGroup1.ButtonCount = 0;
            this.dmzOptionGroup1.Controls.Add(this.cbContabilistico);
            this.dmzOptionGroup1.Controls.Add(this.cbFiscal);
            this.dmzOptionGroup1.Imagem = global::DMZ.UI.Properties.Resources.Bulleted_List_20px;
            this.dmzOptionGroup1.IsRequered = false;
            this.dmzOptionGroup1.Label1Text = "Tipo de depreciação";
            this.dmzOptionGroup1.Location = new System.Drawing.Point(14, 122);
            this.dmzOptionGroup1.Name = "dmzOptionGroup1";
            this.dmzOptionGroup1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dmzOptionGroup1.Size = new System.Drawing.Size(275, 80);
            this.dmzOptionGroup1.TabIndex = 100;
            this.dmzOptionGroup1.Value = "tipofilter";
            // 
            // cbContabilistico
            // 
            this.cbContabilistico.BackColor = System.Drawing.Color.Transparent;
            this.cbContabilistico.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbContabilistico.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbContabilistico.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContabilistico.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbContabilistico.CbText = "Contabilístico";
            this.cbContabilistico.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbContabilistico.Imagem = global::DMZ.UI.Properties.Resources.Circle_23px1;
            this.cbContabilistico.IsOptionGroup = true;
            this.cbContabilistico.IsReadOnly = false;
            this.cbContabilistico.IsRequered = false;
            this.cbContabilistico.Location = new System.Drawing.Point(6, 50);
            this.cbContabilistico.Name = "cbContabilistico";
            this.cbContabilistico.OnlyCheckBox = false;
            this.cbContabilistico.Size = new System.Drawing.Size(177, 22);
            this.cbContabilistico.TabIndex = 80;
            this.cbContabilistico.Value = null;
            this.cbContabilistico.Value2 = "2";
            // 
            // cbFiscal
            // 
            this.cbFiscal.BackColor = System.Drawing.Color.Transparent;
            this.cbFiscal.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFiscal.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFiscal.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiscal.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbFiscal.CbText = "Fiscal";
            this.cbFiscal.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbFiscal.Imagem = global::DMZ.UI.Properties.Resources.Circle_23px1;
            this.cbFiscal.IsOptionGroup = true;
            this.cbFiscal.IsReadOnly = false;
            this.cbFiscal.IsRequered = false;
            this.cbFiscal.Location = new System.Drawing.Point(6, 27);
            this.cbFiscal.Name = "cbFiscal";
            this.cbFiscal.OnlyCheckBox = false;
            this.cbFiscal.Size = new System.Drawing.Size(177, 22);
            this.cbFiscal.TabIndex = 79;
            this.cbFiscal.Value = "Tipodoc";
            this.cbFiscal.Value2 = "1";
            // 
            // txtPercentagem
            // 
            this.txtPercentagem.AutoComplete = false;
            this.txtPercentagem.AutoIncrimento = false;
            this.txtPercentagem.Condicao = "";
            this.txtPercentagem.InPutMask = false;
            this.txtPercentagem.IsEmail = false;
            this.txtPercentagem.IsMatricula = false;
            this.txtPercentagem.IsMaxLength = false;
            this.txtPercentagem.IsNuit = false;
            this.txtPercentagem.IsNumeric = false;
            this.txtPercentagem.IsReadOnly = false;
            this.txtPercentagem.IsTelephone = false;
            this.txtPercentagem.IsUnique = false;
            this.txtPercentagem.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPercentagem.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentagem.label1ForeColor = System.Drawing.Color.Black;
            this.txtPercentagem.Label1Text = "Taxa";
            this.txtPercentagem.Label1Text2 = null;
            this.txtPercentagem.Location = new System.Drawing.Point(8, 73);
            this.txtPercentagem.MaxLength = 0;
            this.txtPercentagem.MultDocumento = false;
            this.txtPercentagem.MultiLinhas = false;
            this.txtPercentagem.Name = "txtPercentagem";
            this.txtPercentagem.Nome = "DMZTexBoxX";
            this.txtPercentagem.Obrigatorio = false;
            this.txtPercentagem.Selected = null;
            this.txtPercentagem.Size = new System.Drawing.Size(294, 43);
            this.txtPercentagem.Tabela = null;
            this.txtPercentagem.TabIndex = 98;
            this.txtPercentagem.Tb1Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentagem.Tb1IsPassword = false;
            this.txtPercentagem.Tb1TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPercentagem.Text2 = "";
            this.txtPercentagem.Text3 = "";
            this.txtPercentagem.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPercentagem.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.txtPercentagem.TextBoxForeColor = System.Drawing.Color.Black;
            this.txtPercentagem.TextBoxScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPercentagem.Titulo = null;
            this.txtPercentagem.ToUpperCase = false;
            this.txtPercentagem.Value = null;
            this.txtPercentagem.Value2 = null;
            this.txtPercentagem.ValueChange = false;
            // 
            // dtDataFiscal
            // 
            this.dtDataFiscal.BackColor = System.Drawing.Color.Transparent;
            this.dtDataFiscal.Dt1Value = new System.DateTime(2022, 5, 28, 0, 0, 0, 0);
            this.dtDataFiscal.DtCustomFormat = null;
            this.dtDataFiscal.DtFormat = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataFiscal.DtShowUpDown = false;
            this.dtDataFiscal.DtSize = new System.Drawing.Size(105, 20);
            this.dtDataFiscal.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataFiscal.label1ForeColor = System.Drawing.Color.Black;
            this.dtDataFiscal.Label1Text = "Data";
            this.dtDataFiscal.Location = new System.Drawing.Point(14, 34);
            this.dtDataFiscal.Name = "dtDataFiscal";
            this.dtDataFiscal.Size = new System.Drawing.Size(123, 42);
            this.dtDataFiscal.TabIndex = 97;
            this.dtDataFiscal.TextBox1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataFiscal.Value = null;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Image = global::DMZ.UI.Properties.Resources.Sync_Settings_20px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(181, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 32);
            this.button3.TabIndex = 94;
            this.button3.Text = "PROCESSAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 375);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(314, 5);
            this.panel6.TabIndex = 103;
            // 
            // FrmDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 380);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDep";
            this.Load += new System.EventHandler(this.FrmDep_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.dmzOptionGroup2.ResumeLayout(false);
            this.dmzOptionGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button3;
        public UC.DMZTexBoxX txtPercentagem;
        public UC.DtDefault dtDataFiscal;
        private UC.DmzOptionGroup dmzOptionGroup1;
        private UC.CbDefault cbContabilistico;
        private UC.CbDefault cbFiscal;
        private UC.DmzOptionGroup dmzOptionGroup2;
        public UC.CbDefault cbQuotas;
        public UC.CbDefault cbDuod;
    }
}