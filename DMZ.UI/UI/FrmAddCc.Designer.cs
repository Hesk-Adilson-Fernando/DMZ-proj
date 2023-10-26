
namespace DMZ.UI.UI
{
    partial class FrmAddCc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dmzProcura2 = new DMZ.UI.UC.DmzProcura();
            this.btnProcura = new System.Windows.Forms.Button();
            this.dmzProcura1 = new DMZ.UI.UC.DmzProcura();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.gridDeb = new DMZ.UI.Generic.GridUi();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nrdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new DMZ.UI.Generic.DateTimePickerColumn();
            this.Vencimento = new DMZ.UI.Generic.DateTimePickerColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oristamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Size = new System.Drawing.Size(796, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(764, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.Text = "Lançar conta corrente ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 481);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.gridPanel21);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dmzProcura2);
            this.panel1.Controls.Add(this.btnProcura);
            this.panel1.Controls.Add(this.dmzProcura1);
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 42);
            this.panel1.TabIndex = 79;
            // 
            // dmzProcura2
            // 
            this.dmzProcura2.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzProcura2.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzProcura2.IsLocaDs = false;
            this.dmzProcura2.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzProcura2.Label1Text = "Centro de Custo";
            this.dmzProcura2.Location = new System.Drawing.Point(372, -2);
            this.dmzProcura2.Name = "dmzProcura2";
            this.dmzProcura2.Pp = null;
            this.dmzProcura2.Size = new System.Drawing.Size(397, 39);
            this.dmzProcura2.SqlComandText = "select CodCcu,Descricao from CCu ";
            this.dmzProcura2.TabIndex = 69;
            this.dmzProcura2.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzProcura2.Tb1Multiline = false;
            this.dmzProcura2.Text2 = null;
            // 
            // btnProcura
            // 
            this.btnProcura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.btnProcura.FlatAppearance.BorderSize = 0;
            this.btnProcura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcura.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcura.Image = global::DMZ.UI.Properties.Resources.select_yes_25px;
            this.btnProcura.Location = new System.Drawing.Point(324, 16);
            this.btnProcura.Name = "btnProcura";
            this.btnProcura.Size = new System.Drawing.Size(26, 21);
            this.btnProcura.TabIndex = 68;
            this.btnProcura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcura.UseVisualStyleBackColor = false;
            this.btnProcura.Click += new System.EventHandler(this.btnProcura_Click);
            // 
            // dmzProcura1
            // 
            this.dmzProcura1.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzProcura1.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzProcura1.IsLocaDs = false;
            this.dmzProcura1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzProcura1.Label1Text = "Cliente";
            this.dmzProcura1.Location = new System.Drawing.Point(0, -1);
            this.dmzProcura1.Name = "dmzProcura1";
            this.dmzProcura1.Pp = null;
            this.dmzProcura1.Size = new System.Drawing.Size(327, 39);
            this.dmzProcura1.SqlComandText = "select no,nome from cl ";
            this.dmzProcura1.TabIndex = 0;
            this.dmzProcura1.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzProcura1.Tb1Multiline = false;
            this.dmzProcura1.Text2 = null;
            // 
            // gridPanel21
            // 
            this.gridPanel21.AddControls = false;
            this.gridPanel21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridPanel21.Callform = false;
            this.gridPanel21.Controls.Add(this.gridDeb);
            this.gridPanel21.DefaultColumn = null;
            this.gridPanel21.Gridnome = "gridDeb";
            this.gridPanel21.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.gridPanel21.Label1Color = System.Drawing.Color.White;
            this.gridPanel21.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel21.Label1Text = "Facturas não regularizadas";
            this.gridPanel21.Location = new System.Drawing.Point(7, 48);
            this.gridPanel21.MostraGravar = true;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.tips_20px;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(774, 398);
            this.gridPanel21.TabIndex = 78;
            this.gridPanel21.TipoMenu = false;
            this.gridPanel21.UsaNomeGrid = false;
            this.gridPanel21.BeforeAddLineEvent += new DMZ.UI.UC.GridPanel2.BeforeAddLineDelegate(this.gridPanel21_BeforeAddLineEvent);
            this.gridPanel21.AfterAddLineEvent += new DMZ.UI.UC.GridPanel2.AfterAddLineDelegate(this.gridPanel21_AfterAddLineEvent);
            this.gridPanel21.SaveEvent += new DMZ.UI.UC.GridPanel2.SaveDelegate(this.gridPanel21_SaveEvent);
            // 
            // gridDeb
            // 
            this.gridDeb.AddButtons = false;
            this.gridDeb.AllowUserToAddRows = false;
            this.gridDeb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDeb.AutoIncrimento = false;
            this.gridDeb.BackgroundColor = System.Drawing.Color.White;
            this.gridDeb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDeb.CampoCodigo = "";
            this.gridDeb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridDeb.Codigo = "";
            this.gridDeb.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDeb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDeb.ColumnHeadersHeight = 30;
            this.gridDeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDeb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.nome,
            this.Nrdoc,
            this.origem,
            this.debito,
            this.Data,
            this.Vencimento,
            this.documento,
            this.ccusto,
            this.Moeda,
            this.Factstamp,
            this.ccstamp,
            this.oristamp});
            this.gridDeb.Condicao = null;
            this.gridDeb.CorPreto = true;
            this.gridDeb.CurrentColumnName = null;
            this.gridDeb.DefacolumnName = null;
            this.gridDeb.DellGridRow = null;
            this.gridDeb.DtDS = null;
            this.gridDeb.EnableHeadersVisualStyles = false;
            this.gridDeb.GenerateColumns = false;
            this.gridDeb.GridColor = System.Drawing.Color.SteelBlue;
            this.gridDeb.GridFilha = false;
            this.gridDeb.GridFilhaSecundaria = false;
            this.gridDeb.GridUIBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDeb.HeadersHeight = 30;
            this.gridDeb.HeadersVisible = false;
            this.gridDeb.Location = new System.Drawing.Point(0, 25);
            this.gridDeb.Name = "gridDeb";
            this.gridDeb.OrderbyCampos = null;
            this.gridDeb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDeb.RowHeadersVisible = false;
            this.gridDeb.RowHeadersWidth = 30;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.gridDeb.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridDeb.RowTemplate.Height = 25;
            this.gridDeb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDeb.Size = new System.Drawing.Size(772, 371);
            this.gridDeb.StampCabecalho = "";
            this.gridDeb.StampLocal = "ccstamp";
            this.gridDeb.TabelaSql = "cc";
            this.gridDeb.TabIndex = 73;
            this.gridDeb.TbCodigo = "";
            this.gridDeb.AfterDeleteLineEvent += new DMZ.UI.Generic.GridUi.AfterdeleteDelegate(this.gridDeb_AfterDeleteLineEvent);
            this.gridDeb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeb_CellClick);
            this.gridDeb.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeb_CellEnter);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.Image = global::DMZ.UI.Properties.Resources.Maximize_Window_25px;
            this.btnMaxMin.Location = new System.Drawing.Point(739, 3);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 86;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.Visible = false;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.nome.HeaderText = "Cliente ";
            this.nome.Name = "nome";
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nrdoc
            // 
            this.Nrdoc.DataPropertyName = "nrdoc";
            this.Nrdoc.HeaderText = "Nº Doc.";
            this.Nrdoc.Name = "Nrdoc";
            // 
            // origem
            // 
            this.origem.DataPropertyName = "origem";
            this.origem.HeaderText = "origem";
            this.origem.Name = "origem";
            this.origem.Visible = false;
            this.origem.Width = 80;
            // 
            // debito
            // 
            this.debito.DataPropertyName = "debito";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.debito.DefaultCellStyle = dataGridViewCellStyle3;
            this.debito.HeaderText = "Valor ";
            this.debito.Name = "debito";
            this.debito.Width = 150;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            dataGridViewCellStyle4.Format = "d";
            this.Data.DefaultCellStyle = dataGridViewCellStyle4;
            this.Data.HeaderText = "Data";
            this.Data.IsDateTime = false;
            this.Data.Name = "Data";
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "vencim";
            dataGridViewCellStyle5.Format = "d";
            this.Vencimento.DefaultCellStyle = dataGridViewCellStyle5;
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.IsDateTime = false;
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "documento";
            this.documento.Name = "documento";
            this.documento.Visible = false;
            // 
            // ccusto
            // 
            this.ccusto.DataPropertyName = "ccusto";
            this.ccusto.HeaderText = "ccusto";
            this.ccusto.Name = "ccusto";
            this.ccusto.Visible = false;
            // 
            // Moeda
            // 
            this.Moeda.DataPropertyName = "Moeda";
            this.Moeda.HeaderText = "Moeda";
            this.Moeda.Name = "Moeda";
            this.Moeda.Visible = false;
            // 
            // Factstamp
            // 
            this.Factstamp.DataPropertyName = "Factstamp";
            this.Factstamp.HeaderText = "Factstamp";
            this.Factstamp.Name = "Factstamp";
            this.Factstamp.Visible = false;
            // 
            // ccstamp
            // 
            this.ccstamp.DataPropertyName = "ccstamp";
            this.ccstamp.HeaderText = "ccstamp";
            this.ccstamp.Name = "ccstamp";
            this.ccstamp.Visible = false;
            // 
            // oristamp
            // 
            this.oristamp.DataPropertyName = "oristamp";
            this.oristamp.HeaderText = "oristamp";
            this.oristamp.Name = "oristamp";
            this.oristamp.Visible = false;
            // 
            // FrmAddCc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAddCc";
            this.Text = "FrmAddCc";
            this.Load += new System.EventHandler(this.FrmAddCc_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.GridPanel2 gridPanel21;
        private Generic.GridUi gridDeb;
        private System.Windows.Forms.Panel panel1;
        private UC.DmzProcura dmzProcura1;
        public System.Windows.Forms.Button btnProcura;
        public System.Windows.Forms.Button btnMaxMin;
        private UC.DmzProcura dmzProcura2;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nrdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn debito;
        private Generic.DateTimePickerColumn Data;
        private Generic.DateTimePickerColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn oristamp;
    }
}