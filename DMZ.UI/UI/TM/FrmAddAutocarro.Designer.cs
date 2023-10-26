namespace DMZ.UI.TM
{
    partial class FrmAddAutocarro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.gridAuto = new DMZ.UI.Generic.GridUi();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turmadiscstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ststamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(445, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(413, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.Text = "Adicionar Carro";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 397);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.gridPanel21);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 371);
            this.tabPage1.TabIndex = 0;
            // 
            // gridPanel21
            // 
            this.gridPanel21.AddControls = false;
            this.gridPanel21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel21.Callform = false;
            this.gridPanel21.Controls.Add(this.gridAuto);
            this.gridPanel21.DefaultColumn = null;
            this.gridPanel21.Gridnome = "gridDeb";
            this.gridPanel21.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.Label1Color = System.Drawing.Color.White;
            this.gridPanel21.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel21.Label1Text = "";
            this.gridPanel21.Location = new System.Drawing.Point(7, 9);
            this.gridPanel21.MostraGravar = true;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.scorecard_21px;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(421, 361);
            this.gridPanel21.TabIndex = 78;
            this.gridPanel21.TipoMenu = false;
            this.gridPanel21.UsaNomeGrid = false;
            this.gridPanel21.BeforeAddLineEvent += new DMZ.UI.UC.GridPanel2.BeforeAddLineDelegate(this.gridPanel21_BeforeAddLineEvent);
            // 
            // gridAuto
            // 
            this.gridAuto.AddButtons = false;
            this.gridAuto.AllowUserToAddRows = false;
            this.gridAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridAuto.AutoIncrimento = false;
            this.gridAuto.BackgroundColor = System.Drawing.Color.Snow;
            this.gridAuto.CampoCodigo = "";
            this.gridAuto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridAuto.Codigo = "";
            this.gridAuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAuto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAuto.ColumnHeadersHeight = 30;
            this.gridAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Descviatura,
            this.pestamp,
            this.Turmadiscstamp,
            this.Ststamp});
            this.gridAuto.Condicao = null;
            this.gridAuto.CorPreto = true;
            this.gridAuto.CurrentColumnName = null;
            this.gridAuto.DefacolumnName = null;
            this.gridAuto.DellGridRow = null;
            this.gridAuto.DtDS = null;
            this.gridAuto.EnableHeadersVisualStyles = false;
            this.gridAuto.GenerateColumns = false;
            this.gridAuto.GridColor = System.Drawing.Color.White;
            this.gridAuto.GridFilha = false;
            this.gridAuto.GridFilhaSecundaria = false;
            this.gridAuto.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridAuto.HeadersHeight = 30;
            this.gridAuto.HeadersVisible = false;
            this.gridAuto.Location = new System.Drawing.Point(0, 27);
            this.gridAuto.Name = "gridAuto";
            this.gridAuto.OrderbyCampos = null;
            this.gridAuto.Origem = null;
            this.gridAuto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridAuto.RowHeadersVisible = false;
            this.gridAuto.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.gridAuto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAuto.RowTemplate.Height = 25;
            this.gridAuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAuto.Size = new System.Drawing.Size(420, 331);
            this.gridAuto.StampCabecalho = "Familiacarstamp";
            this.gridAuto.StampLocal = "Familiacarlstamp";
            this.gridAuto.TabelaSql = "Familiacarl";
            this.gridAuto.TabIndex = 73;
            this.gridAuto.TbCodigo = "";
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.Width = 150;
            // 
            // Descviatura
            // 
            this.Descviatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descviatura.DataPropertyName = "Descviatura";
            this.Descviatura.HeaderText = "Descrição";
            this.Descviatura.Name = "Descviatura";
            // 
            // pestamp
            // 
            this.pestamp.DataPropertyName = "pestamp";
            this.pestamp.HeaderText = "Pestamp";
            this.pestamp.Name = "pestamp";
            this.pestamp.Visible = false;
            // 
            // Turmadiscstamp
            // 
            this.Turmadiscstamp.DataPropertyName = "Turmadiscstamp";
            this.Turmadiscstamp.HeaderText = "Turmadiscstamp";
            this.Turmadiscstamp.Name = "Turmadiscstamp";
            this.Turmadiscstamp.Visible = false;
            // 
            // Ststamp
            // 
            this.Ststamp.DataPropertyName = "Ststamp";
            this.Ststamp.HeaderText = "Ststamp";
            this.Ststamp.Name = "Ststamp";
            this.Ststamp.Visible = false;
            // 
            // FrmAddAutocarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(446, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAddAutocarro";
            this.Load += new System.EventHandler(this.FrmAddAutocarro_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAuto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public UC.GridPanel2 gridPanel21;
        private Generic.GridUi gridAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descviatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn pestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turmadiscstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ststamp;
    }
}
