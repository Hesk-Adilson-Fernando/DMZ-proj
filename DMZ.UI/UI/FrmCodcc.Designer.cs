namespace DMZ.UI.UI
{
    partial class FrmCodcc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.gridDeb = new DMZ.UI.Generic.GridUi();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arm = new DMZ.UI.Generic.TextAndImageColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridPanel22 = new DMZ.UI.UC.GridPanel2();
            this.gridCre = new DMZ.UI.Generic.GridUi();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textAndImageColumn1 = new DMZ.UI.Generic.TextAndImageColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeb)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gridPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(478, 26);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(448, 1);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(285, 17);
            this.label1.Text = "Código de Movimento de Conta Corrente";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 385);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridPanel21);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Débito ";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.gridPanel21.Label1Text = "Código de Débito";
            this.gridPanel21.Location = new System.Drawing.Point(7, 6);
            this.gridPanel21.MostraGravar = true;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.Bulleted_List_20px;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(435, 349);
            this.gridPanel21.TabIndex = 78;
            this.gridPanel21.TipoMenu = false;
            this.gridPanel21.UsaNomeGrid = false;
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
            this.dataGridViewTextBoxColumn1,
            this.arm});
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
            this.gridDeb.Location = new System.Drawing.Point(0, 27);
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
            this.gridDeb.Size = new System.Drawing.Size(435, 319);
            this.gridDeb.StampCabecalho = "";
            this.gridDeb.StampLocal = "codccstamp";
            this.gridDeb.TabelaSql = "codcc";
            this.gridDeb.TabIndex = 73;
            this.gridDeb.TbCodigo = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // arm
            // 
            this.arm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arm.DataPropertyName = "descricao";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.arm.DefaultCellStyle = dataGridViewCellStyle2;
            this.arm.HeaderText = "Descrição";
            this.arm.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.arm.Name = "arm";
            this.arm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridPanel22);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Credito";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridPanel22
            // 
            this.gridPanel22.AddControls = false;
            this.gridPanel22.Callform = false;
            this.gridPanel22.Controls.Add(this.gridCre);
            this.gridPanel22.DefaultColumn = null;
            this.gridPanel22.Gridnome = "gridUi1";
            this.gridPanel22.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.gridPanel22.Label1Color = System.Drawing.Color.White;
            this.gridPanel22.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel22.Label1Text = "Código de Débito";
            this.gridPanel22.Location = new System.Drawing.Point(6, 5);
            this.gridPanel22.MostraGravar = true;
            this.gridPanel22.Name = "gridPanel22";
            this.gridPanel22.NotAddLine = false;
            this.gridPanel22.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.gridPanel22.PictureBox1Image = global::DMZ.UI.Properties.Resources.Bulleted_List_20px;
            this.gridPanel22.ShowColNames = false;
            this.gridPanel22.Size = new System.Drawing.Size(435, 349);
            this.gridPanel22.TabIndex = 79;
            this.gridPanel22.TipoMenu = false;
            this.gridPanel22.UsaNomeGrid = false;
            // 
            // gridCre
            // 
            this.gridCre.AddButtons = false;
            this.gridCre.AllowUserToAddRows = false;
            this.gridCre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCre.AutoIncrimento = true;
            this.gridCre.BackgroundColor = System.Drawing.Color.White;
            this.gridCre.CampoCodigo = "ref";
            this.gridCre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridCre.Codigo = "codigo";
            this.gridCre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCre.ColumnHeadersHeight = 30;
            this.gridCre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.textAndImageColumn1});
            this.gridCre.Condicao = null;
            this.gridCre.CorPreto = true;
            this.gridCre.CurrentColumnName = null;
            this.gridCre.DefacolumnName = null;
            this.gridCre.DellGridRow = null;
            this.gridCre.DtDS = null;
            this.gridCre.EnableHeadersVisualStyles = false;
            this.gridCre.GenerateColumns = false;
            this.gridCre.GridColor = System.Drawing.Color.SteelBlue;
            this.gridCre.GridFilha = false;
            this.gridCre.GridFilhaSecundaria = false;
            this.gridCre.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridCre.HeadersHeight = 30;
            this.gridCre.HeadersVisible = false;
            this.gridCre.Location = new System.Drawing.Point(0, 27);
            this.gridCre.Name = "gridCre";
            this.gridCre.OrderbyCampos = null;
            this.gridCre.Origem = null;
            this.gridCre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridCre.RowHeadersVisible = false;
            this.gridCre.RowHeadersWidth = 30;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gridCre.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridCre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCre.Size = new System.Drawing.Size(435, 319);
            this.gridCre.StampCabecalho = "";
            this.gridCre.StampLocal = "codccstamp";
            this.gridCre.TabelaSql = "codcc";
            this.gridCre.TabIndex = 74;
            this.gridCre.TbCodigo = "";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // textAndImageColumn1
            // 
            this.textAndImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textAndImageColumn1.DataPropertyName = "descricao";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.textAndImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.textAndImageColumn1.HeaderText = "Descrição";
            this.textAndImageColumn1.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.textAndImageColumn1.Name = "textAndImageColumn1";
            this.textAndImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmCodcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(479, 439);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCodcc";
            this.Load += new System.EventHandler(this.FrmCodcc_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeb)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gridPanel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UC.GridPanel2 gridPanel21;
        private UC.GridPanel2 gridPanel22;
        private Generic.GridUi gridDeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Generic.TextAndImageColumn arm;
        private Generic.GridUi gridCre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Generic.TextAndImageColumn textAndImageColumn1;
    }
}
