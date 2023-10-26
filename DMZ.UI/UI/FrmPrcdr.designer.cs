
namespace DMZ.UI.UI.RH
{
    partial class FrmPrcdr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrcdr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.GridProcess = new DMZ.UI.Generic.GridUi();
            this.Referenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ststamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbMes = new DMZ.UI.UC.DmzProcura();
            this.barraText3 = new DMZ.UI.UC.BarraText();
            this.tbTipoProces = new DMZ.UI.UC.DmzProcura();
            this.tbCCusto = new DMZ.UI.UC.DmzProcura();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tbdepartamento = new DMZ.UI.UC.DmzProcura();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcess)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.panel4.Size = new System.Drawing.Size(675, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(649, 2);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.Text = "Dados do processamento";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbDefault1);
            this.panel1.Controls.Add(this.GridProcess);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(2, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 363);
            this.panel1.TabIndex = 25;
            // 
            // cbDefault1
            // 
            this.cbDefault1.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "Selecçionar todos";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(532, 4);
            this.cbDefault1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = true;
            this.cbDefault1.Size = new System.Drawing.Size(143, 24);
            this.cbDefault1.TabIndex = 75;
            this.cbDefault1.Value = null;
            this.cbDefault1.Value2 = null;
            this.cbDefault1.CheckedChangeds += new DMZ.UI.UC.CbDefault.CBCheckedChanged(this.cbDefault1_CheckedChangeds);
            this.cbDefault1.Load += new System.EventHandler(this.cbDefault1_Load);
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
            this.GridProcess.ColumnHeadersHeight = 35;
            this.GridProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referenc,
            this.descricao,
            this.Status,
            this.Ststamp});
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
            this.GridProcess.Location = new System.Drawing.Point(2, 34);
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
            this.GridProcess.Size = new System.Drawing.Size(666, 324);
            this.GridProcess.StampCabecalho = "Ststamp";
            this.GridProcess.StampLocal = "Starmstamp";
            this.GridProcess.TabelaSql = "Starm";
            this.GridProcess.TabIndex = 29;
            this.GridProcess.TbCodigo = "tbReferenc";
            // 
            // Referenc
            // 
            this.Referenc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Referenc.DataPropertyName = "Referenc";
            this.Referenc.HeaderText = "Referencia";
            this.Referenc.MinimumWidth = 6;
            this.Referenc.Name = "Referenc";
            this.Referenc.Width = 83;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 250;
            this.descricao.Name = "descricao";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "....";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 30;
            // 
            // Ststamp
            // 
            this.Ststamp.DataPropertyName = "Ststamp";
            this.Ststamp.HeaderText = "Ststamp";
            this.Ststamp.MinimumWidth = 6;
            this.Ststamp.Name = "Ststamp";
            this.Ststamp.Visible = false;
            this.Ststamp.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 175);
            this.panel2.TabIndex = 26;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 173);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.tbMes);
            this.tabPage2.Controls.Add(this.barraText3);
            this.tabPage2.Controls.Add(this.tbTipoProces);
            this.tabPage2.Controls.Add(this.tbCCusto);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.tbdepartamento);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Principais";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tbMes
            // 
            this.tbMes.BtnEnabled = true;
            this.tbMes.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMes.Button1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMes.Condicao = null;
            this.tbMes.IsLocaDs = false;
            this.tbMes.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMes.Label1Text = "Mês ";
            this.tbMes.Location = new System.Drawing.Point(306, 63);
            this.tbMes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMes.MySQLQuerry = null;
            this.tbMes.Name = "tbMes";
            this.tbMes.Pp = null;
            this.tbMes.Size = new System.Drawing.Size(253, 38);
            this.tbMes.SqlComandText = "select Codigo,Descricao from Meses order by codigo";
            this.tbMes.TabIndex = 94;
            this.tbMes.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMes.Tb1Multiline = true;
            this.tbMes.Text2 = null;
            // 
            // barraText3
            // 
            this.barraText3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraText3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.barraText3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barraText3.Label1Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.barraText3.Label1ForeColor = System.Drawing.Color.Black;
            this.barraText3.Label1Text = "Filtragem e Verificação do Activo";
            this.barraText3.Location = new System.Drawing.Point(-1, -1);
            this.barraText3.Name = "barraText3";
            this.barraText3.PanelBackColor = System.Drawing.Color.DarkGoldenrod;
            this.barraText3.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText3.PictureBox1Image")));
            this.barraText3.Size = new System.Drawing.Size(738, 28);
            this.barraText3.TabIndex = 92;
            // 
            // tbTipoProces
            // 
            this.tbTipoProces.BtnEnabled = true;
            this.tbTipoProces.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTipoProces.Button1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTipoProces.Condicao = null;
            this.tbTipoProces.IsLocaDs = false;
            this.tbTipoProces.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTipoProces.Label1Text = "Tipo de Depreciação";
            this.tbTipoProces.Location = new System.Drawing.Point(306, 26);
            this.tbTipoProces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTipoProces.MySQLQuerry = null;
            this.tbTipoProces.Name = "tbTipoProces";
            this.tbTipoProces.Pp = null;
            this.tbTipoProces.Size = new System.Drawing.Size(253, 38);
            this.tbTipoProces.SqlComandText = "select Descricao from PeAuxiliar where tabela =23";
            this.tbTipoProces.TabIndex = 91;
            this.tbTipoProces.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTipoProces.Tb1Multiline = true;
            this.tbTipoProces.Text2 = null;
            // 
            // tbCCusto
            // 
            this.tbCCusto.BtnEnabled = true;
            this.tbCCusto.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCCusto.Button1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCCusto.Condicao = null;
            this.tbCCusto.IsLocaDs = false;
            this.tbCCusto.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCCusto.Label1Text = "Centro de Custo";
            this.tbCCusto.Location = new System.Drawing.Point(6, 63);
            this.tbCCusto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCCusto.MySQLQuerry = null;
            this.tbCCusto.Name = "tbCCusto";
            this.tbCCusto.Pp = null;
            this.tbCCusto.Size = new System.Drawing.Size(263, 38);
            this.tbCCusto.SqlComandText = "select Descricao from ccu ";
            this.tbCCusto.TabIndex = 89;
            this.tbCCusto.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCCusto.Tb1Multiline = true;
            this.tbCCusto.Text2 = null;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(581, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 69);
            this.panel5.TabIndex = 80;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Image = global::DMZ.UI.Properties.Resources.process_manual_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 69);
            this.button2.TabIndex = 79;
            this.button2.Text = "Verificar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dmzToolTip1.SetToolTip(this.button2, "Selecionar Funcionários");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbdepartamento
            // 
            this.tbdepartamento.BtnEnabled = true;
            this.tbdepartamento.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbdepartamento.Button1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbdepartamento.Condicao = null;
            this.tbdepartamento.IsLocaDs = false;
            this.tbdepartamento.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbdepartamento.Label1Text = "Localização";
            this.tbdepartamento.Location = new System.Drawing.Point(6, 26);
            this.tbdepartamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbdepartamento.MySQLQuerry = null;
            this.tbdepartamento.Name = "tbdepartamento";
            this.tbdepartamento.Pp = null;
            this.tbdepartamento.Size = new System.Drawing.Size(263, 38);
            this.tbdepartamento.SqlComandText = "select Sigla,Descricao from Empresadep order by Sigla";
            this.tbdepartamento.TabIndex = 77;
            this.tbdepartamento.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbdepartamento.Tb1Multiline = true;
            this.tbdepartamento.Text2 = null;
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ SOFTWARE 2021";
            // 
            // FrmPrcdr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrcdr";
            this.Text = "FrmAddProcess";
            this.Load += new System.EventHandler(this.FrmPrcdr_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProcess)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Generic.GridUi GridProcess;
        private UC.CbDefault cbDefault1;
        private UC.DmzProcura tbdepartamento;
        private Generic.DMZToolTip dmzToolTip1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private UC.DmzProcura tbCCusto;
        private UC.DmzProcura tbTipoProces;
        private UC.DmzProcura tbMes;
        private UC.BarraText barraText3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ststamp;
    }
}