namespace DMZ.UI.UI
{
    partial class FrmReserva
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.Cliente = new DMZ.UI.UC.Procura();
            this.button2 = new System.Windows.Forms.Button();
            this.gridDeb = new DMZ.UI.Generic.GridUi();
            this.arm = new DMZ.UI.Generic.TextAndImageColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horafim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(886, 30);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-36, 3);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(855, 1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.Text = "Reserva de mesas ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridPanel21);
            this.panel1.Controls.Add(this.Cliente);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(2, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 357);
            this.panel1.TabIndex = 129;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // gridPanel21
            // 
            this.gridPanel21.AddControls = false;
            this.gridPanel21.Callform = false;
            this.gridPanel21.Controls.Add(this.gridDeb);
            this.gridPanel21.DefaultColumn = null;
            this.gridPanel21.Gridnome = "gridDeb";
            this.gridPanel21.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.Label1Color = System.Drawing.Color.White;
            this.gridPanel21.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel21.Label1Text = "Lista de mesas reservadas ";
            this.gridPanel21.Location = new System.Drawing.Point(8, 49);
            this.gridPanel21.MostraGravar = true;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.Bulleted_List_20px;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(645, 259);
            this.gridPanel21.TabIndex = 118;
            this.gridPanel21.TipoMenu = false;
            this.gridPanel21.UsaNomeGrid = false;
            // 
            // Cliente
            // 
            this.Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cliente.AutoComplete = false;
            this.Cliente.BackColor = System.Drawing.Color.Transparent;
            this.Cliente.Campo = null;
            this.Cliente.Campo1 = null;
            this.Cliente.CampoStatus = false;
            this.Cliente.ColunaCodigo = "Código";
            this.Cliente.ColunaDescricao = "Descrição";
            this.Cliente.Condicao = "DeficilCobrar=0";
            this.Cliente.DependDescricao = null;
            this.Cliente.Dependente = false;
            this.Cliente.DependenteNome = null;
            this.Cliente.Descname = "nome";
            this.Cliente.EnableTb1Field = true;
            this.Cliente.ExecMetodo = false;
            this.Cliente.FormName = "FrmCL";
            this.Cliente.HideFirstColumn = false;
            this.Cliente.InserirNovo = false;
            this.Cliente.InvertColuna = false;
            this.Cliente.IsLocaDs = false;
            this.Cliente.IsRequered = true;
            this.Cliente.IsSqlSelect = true;
            this.Cliente.Istatus = false;
            this.Cliente.IsUnique = false;
            this.Cliente.Items = null;
            this.Cliente.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cliente.label1Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.label1ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.Cliente.Label1Text = "Nome do cliente ";
            this.Cliente.Location = new System.Drawing.Point(2, 2);
            this.Cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cliente.MultDocumento = false;
            this.Cliente.Name = "Cliente";
            this.Cliente.OpenInfo = false;
            this.Cliente.ParentFormName = null;
            this.Cliente.Pp = null;
            this.Cliente.ReturnDt = false;
            this.Cliente.Selecionado = "no,nome";
            this.Cliente.ShowThirdColumn = false;
            this.Cliente.Size = new System.Drawing.Size(375, 39);
            this.Cliente.SqlComandText = "select no,nome,clstamp from cl where DeficilCobrar=0";
            this.Cliente.Tabela = "cl";
            this.Cliente.TabIndex = 117;
            this.Cliente.TbCkUpdate = false;
            this.Cliente.TbClear = false;
            this.Cliente.TbUpDate = null;
            this.Cliente.Text2 = null;
            this.Cliente.Text3 = null;
            this.Cliente.Text4 = null;
            this.Cliente.TextBoxBackColor = System.Drawing.SystemColors.Window;
            this.Cliente.TextBoxForeColor = System.Drawing.SystemColors.WindowText;
            this.Cliente.Titulo = "Procurar";
            this.Cliente.TmpFound = null;
            this.Cliente.UpdateTextBox = null;
            this.Cliente.Value = "nome";
            this.Cliente.Value2 = "no";
            this.Cliente.Value3 = "clstamp";
            this.Cliente.Value4 = null;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(535, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 38);
            this.button2.TabIndex = 116;
            this.button2.Text = "Processar ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // gridDeb
            // 
            this.gridDeb.AddButtons = false;
            this.gridDeb.AllowUserToAddRows = false;
            this.gridDeb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDeb.AutoIncrimento = true;
            this.gridDeb.BackgroundColor = System.Drawing.Color.White;
            this.gridDeb.CampoCodigo = "";
            this.gridDeb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridDeb.Codigo = "codigo";
            this.gridDeb.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDeb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDeb.ColumnHeadersHeight = 30;
            this.gridDeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDeb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arm,
            this.Data,
            this.HoraIn,
            this.Horafim,
            this.clstamp});
            this.gridDeb.Condicao = null;
            this.gridDeb.CorPreto = true;
            this.gridDeb.CurrentColumnName = null;
            this.gridDeb.DefacolumnName = null;
            this.gridDeb.DellGridRow = null;
            this.gridDeb.DtDS = null;
            this.gridDeb.EnableHeadersVisualStyles = false;
            this.gridDeb.GenerateColumns = false;
            this.gridDeb.GridColor = System.Drawing.Color.SlateGray;
            this.gridDeb.GridFilha = false;
            this.gridDeb.GridFilhaSecundaria = false;
            this.gridDeb.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDeb.HeadersHeight = 30;
            this.gridDeb.HeadersVisible = false;
            this.gridDeb.Location = new System.Drawing.Point(10, 30);
            this.gridDeb.Name = "gridDeb";
            this.gridDeb.OrderbyCampos = null;
            this.gridDeb.Origem = null;
            this.gridDeb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDeb.RowHeadersVisible = false;
            this.gridDeb.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridDeb.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDeb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDeb.Size = new System.Drawing.Size(644, 229);
            this.gridDeb.StampCabecalho = "";
            this.gridDeb.StampLocal = "codccstamp";
            this.gridDeb.TabelaSql = "codcc";
            this.gridDeb.TabIndex = 74;
            this.gridDeb.TbCodigo = "";
            // 
            // arm
            // 
            this.arm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arm.DataPropertyName = "descricao";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.arm.DefaultCellStyle = dataGridViewCellStyle2;
            this.arm.HeaderText = "Mesa";
            this.arm.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.arm.Name = "arm";
            this.arm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // HoraIn
            // 
            this.HoraIn.DataPropertyName = "Horain";
            this.HoraIn.HeaderText = "Hora In.";
            this.HoraIn.Name = "HoraIn";
            // 
            // Horafim
            // 
            this.Horafim.DataPropertyName = "Horafim";
            this.Horafim.HeaderText = "Horas Fim";
            this.Horafim.Name = "Horafim";
            // 
            // clstamp
            // 
            this.clstamp.DataPropertyName = "clstamp";
            this.clstamp.HeaderText = "clstamp";
            this.clstamp.Name = "clstamp";
            this.clstamp.Visible = false;
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(887, 555);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReserva";
            this.Load += new System.EventHandler(this.FrmReserva_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button2;
        public UC.Procura Cliente;
        private UC.GridPanel2 gridPanel21;
        private Generic.GridUi gridDeb;
        private Generic.TextAndImageColumn arm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horafim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clstamp;
    }
}
