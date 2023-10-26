namespace DMZ.UI.UI
{
    partial class FrmCheckCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckCC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcess = new System.Windows.Forms.Button();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.tbProcura = new System.Windows.Forms.TextBox();
            this.dmzEntreDatas1 = new DMZ.UI.UC.DMZEntreDatas();
            this.button3 = new System.Windows.Forms.Button();
            this.dmzProcess = new DMZ.UI.UC.DmzProcura();
            this.GridProcess = new DMZ.UI.Generic.GridUi();
            this.ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorreg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitofin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(706, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(674, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.Text = "Verificação da conta corrente";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Controls.Add(this.cbDefault1);
            this.panel1.Controls.Add(this.tbProcura);
            this.panel1.Controls.Add(this.dmzEntreDatas1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dmzProcess);
            this.panel1.Controls.Add(this.GridProcess);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 546);
            this.panel1.TabIndex = 25;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcess.Image = global::DMZ.UI.Properties.Resources.Approval_28px;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.Location = new System.Drawing.Point(548, 500);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(143, 40);
            this.btnProcess.TabIndex = 106;
            this.btnProcess.Text = "Executar";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // cbDefault1
            // 
            this.cbDefault1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDefault1.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbFont = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "Selecçionar todos";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(567, 84);
            this.cbDefault1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = true;
            this.cbDefault1.Size = new System.Drawing.Size(143, 24);
            this.cbDefault1.TabIndex = 105;
            this.cbDefault1.Value = null;
            this.cbDefault1.Value2 = null;
            this.cbDefault1.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault1_CheckedChangeds);
            this.cbDefault1.Load += new System.EventHandler(this.cbDefault1_Load);
            // 
            // tbProcura
            // 
            this.tbProcura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProcura.BackColor = System.Drawing.Color.Snow;
            this.tbProcura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProcura.Location = new System.Drawing.Point(8, 82);
            this.tbProcura.Name = "tbProcura";
            this.tbProcura.Size = new System.Drawing.Size(559, 23);
            this.tbProcura.TabIndex = 103;
            // 
            // dmzEntreDatas1
            // 
            this.dmzEntreDatas1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzEntreDatas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmzEntreDatas1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzEntreDatas1.HideShowDt2 = true;
            this.dmzEntreDatas1.Label3Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzEntreDatas1.Label3ForeColor = System.Drawing.SystemColors.ControlText;
            this.dmzEntreDatas1.LabelText = "Entre datas";
            this.dmzEntreDatas1.Location = new System.Drawing.Point(392, 6);
            this.dmzEntreDatas1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dmzEntreDatas1.Name = "dmzEntreDatas1";
            this.dmzEntreDatas1.Panel1BackColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzEntreDatas1.Size = new System.Drawing.Size(174, 70);
            this.dmzEntreDatas1.TabIndex = 102;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Image = global::DMZ.UI.Properties.Resources.Sync_Settings_20px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(572, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 32);
            this.button3.TabIndex = 101;
            this.button3.Text = "PROCESSAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dmzProcess
            // 
            this.dmzProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzProcess.BtnEnabled = true;
            this.dmzProcess.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzProcess.Button1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzProcess.Condicao = null;
            this.dmzProcess.ExecMetodo = false;
            this.dmzProcess.HideFirstColumn = true;
            this.dmzProcess.InvertColuna = false;
            this.dmzProcess.IsLocaDs = false;
            this.dmzProcess.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzProcess.Label1Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzProcess.Label1Text = "Cliente";
            this.dmzProcess.Location = new System.Drawing.Point(4, 37);
            this.dmzProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dmzProcess.MySQLQuerry = "select Processtamp,Descricao from Proces";
            this.dmzProcess.Name = "dmzProcess";
            this.dmzProcess.Pp = null;
            this.dmzProcess.Size = new System.Drawing.Size(383, 38);
            this.dmzProcess.SqlComandText = "Select clstamp,nome from cl";
            this.dmzProcess.TabIndex = 100;
            this.dmzProcess.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzProcess.Tb1Multiline = true;
            this.dmzProcess.Text2 = null;
            this.dmzProcess.Text3 = null;
            this.dmzProcess.Text4 = null;
            this.dmzProcess.Load += new System.EventHandler(this.dmzProcess_Load);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProcess.ColumnHeadersHeight = 35;
            this.GridProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ok,
            this.descricao,
            this.Data,
            this.valorreg,
            this.debitofin});
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
            this.GridProcess.Location = new System.Drawing.Point(4, 111);
            this.GridProcess.Name = "GridProcess";
            this.GridProcess.OrderbyCampos = null;
            this.GridProcess.Origem = null;
            this.GridProcess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridProcess.RowHeadersVisible = false;
            this.GridProcess.RowHeadersWidth = 30;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.GridProcess.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProcess.Size = new System.Drawing.Size(687, 380);
            this.GridProcess.StampCabecalho = "Ststamp";
            this.GridProcess.StampLocal = "Starmstamp";
            this.GridProcess.TabelaSql = "Starm";
            this.GridProcess.TabIndex = 93;
            this.GridProcess.TbCodigo = "tbReferenc";
            // 
            // ok
            // 
            this.ok.DataPropertyName = "ok";
            this.ok.HeaderText = "...";
            this.ok.Name = "ok";
            this.ok.Width = 30;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "documento";
            this.descricao.HeaderText = "Documento";
            this.descricao.MinimumWidth = 150;
            this.descricao.Name = "descricao";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 90;
            // 
            // valorreg
            // 
            this.valorreg.DataPropertyName = "debito";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.valorreg.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorreg.HeaderText = "Débito";
            this.valorreg.MinimumWidth = 6;
            this.valorreg.Name = "valorreg";
            this.valorreg.Width = 125;
            // 
            // debitofin
            // 
            this.debitofin.DataPropertyName = "debitof";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.debitofin.DefaultCellStyle = dataGridViewCellStyle4;
            this.debitofin.HeaderText = "Débito Final";
            this.debitofin.Name = "debitofin";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 582);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(707, 5);
            this.panel7.TabIndex = 123;
            // 
            // FrmCheckCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(707, 587);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCheckCC";
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
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
        private Generic.GridUi GridProcess;
        private UC.DMZEntreDatas dmzEntreDatas1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbProcura;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorreg;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitofin;
        private UC.CbDefault cbDefault1;
        public System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel panel7;
        public UC.DmzProcura dmzProcess;
    }
}
