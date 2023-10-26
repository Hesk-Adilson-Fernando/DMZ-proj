namespace DMZ.UI.UI
{
    partial class FrmCodtz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.grident = new DMZ.UI.Generic.GridUi();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arm = new DMZ.UI.Generic.TextAndImageColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridPanel22 = new DMZ.UI.UC.GridPanel2();
            this.gridsaida = new DMZ.UI.Generic.GridUi();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textAndImageColumn1 = new DMZ.UI.Generic.TextAndImageColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grident)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gridPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridsaida)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(475, 26);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(446, 1);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.Text = "Código de Movimento de Tesouraria";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 383);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.gridPanel21);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entrada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridPanel21
            // 
            this.gridPanel21.AddControls = false;
            this.gridPanel21.Callform = false;
            this.gridPanel21.Controls.Add(this.grident);
            this.gridPanel21.DefaultColumn = null;
            this.gridPanel21.Gridnome = "gridDeb";
            this.gridPanel21.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.gridPanel21.Label1Color = System.Drawing.Color.White;
            this.gridPanel21.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel21.Label1Text = "Código de entrada";
            this.gridPanel21.Location = new System.Drawing.Point(7, 6);
            this.gridPanel21.MostraGravar = true;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.Bulleted_List_20px;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(435, 349);
            this.gridPanel21.TabIndex = 78;
            this.gridPanel21.TipoMenu = false;
            this.gridPanel21.UsaNomeGrid = false;
            // 
            // grident
            // 
            this.grident.AddButtons = false;
            this.grident.AllowUserToAddRows = false;
            this.grident.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grident.AutoIncrimento = true;
            this.grident.BackgroundColor = System.Drawing.Color.White;
            this.grident.CampoCodigo = "";
            this.grident.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grident.Codigo = "Codigo";
            this.grident.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grident.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grident.ColumnHeadersHeight = 30;
            this.grident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grident.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.arm});
            this.grident.Condicao = "Codigo<50";
            this.grident.CorPreto = true;
            this.grident.CurrentColumnName = null;
            this.grident.DefacolumnName = null;
            this.grident.DellGridRow = null;
            this.grident.DtDS = null;
            this.grident.EnableHeadersVisualStyles = false;
            this.grident.GenerateColumns = false;
            this.grident.GridColor = System.Drawing.Color.SteelBlue;
            this.grident.GridFilha = false;
            this.grident.GridFilhaSecundaria = false;
            this.grident.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grident.HeadersHeight = 30;
            this.grident.HeadersVisible = false;
            this.grident.Location = new System.Drawing.Point(0, 27);
            this.grident.Name = "grident";
            this.grident.OrderbyCampos = null;
            this.grident.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grident.RowHeadersVisible = false;
            this.grident.RowHeadersWidth = 30;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.grident.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grident.Size = new System.Drawing.Size(435, 319);
            this.grident.StampCabecalho = "";
            this.grident.StampLocal = "codtzstamp";
            this.grident.TabelaSql = "codtz";
            this.grident.TabIndex = 73;
            this.grident.TbCodigo = "";
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
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.arm.DefaultCellStyle = dataGridViewCellStyle8;
            this.arm.HeaderText = "Descrição";
            this.arm.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.arm.Name = "arm";
            this.arm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.gridPanel22);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saida";
            // 
            // gridPanel22
            // 
            this.gridPanel22.AddControls = false;
            this.gridPanel22.Callform = false;
            this.gridPanel22.Controls.Add(this.gridsaida);
            this.gridPanel22.DefaultColumn = null;
            this.gridPanel22.Gridnome = "gridUi1";
            this.gridPanel22.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.gridPanel22.Label1Color = System.Drawing.Color.White;
            this.gridPanel22.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel22.Label1Text = "Código de saida";
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
            // gridsaida
            // 
            this.gridsaida.AddButtons = false;
            this.gridsaida.AllowUserToAddRows = false;
            this.gridsaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridsaida.AutoIncrimento = true;
            this.gridsaida.BackgroundColor = System.Drawing.Color.White;
            this.gridsaida.CampoCodigo = "";
            this.gridsaida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridsaida.Codigo = "Codigo";
            this.gridsaida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridsaida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridsaida.ColumnHeadersHeight = 30;
            this.gridsaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridsaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.textAndImageColumn1});
            this.gridsaida.Condicao = "Codigo>50";
            this.gridsaida.CorPreto = true;
            this.gridsaida.CurrentColumnName = null;
            this.gridsaida.DefacolumnName = null;
            this.gridsaida.DellGridRow = null;
            this.gridsaida.DtDS = null;
            this.gridsaida.EnableHeadersVisualStyles = false;
            this.gridsaida.GenerateColumns = false;
            this.gridsaida.GridColor = System.Drawing.Color.SteelBlue;
            this.gridsaida.GridFilha = false;
            this.gridsaida.GridFilhaSecundaria = false;
            this.gridsaida.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridsaida.HeadersHeight = 30;
            this.gridsaida.HeadersVisible = false;
            this.gridsaida.Location = new System.Drawing.Point(0, 27);
            this.gridsaida.Name = "gridsaida";
            this.gridsaida.OrderbyCampos = null;
            this.gridsaida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridsaida.RowHeadersVisible = false;
            this.gridsaida.RowHeadersWidth = 30;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.gridsaida.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridsaida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridsaida.Size = new System.Drawing.Size(435, 319);
            this.gridsaida.StampCabecalho = "";
            this.gridsaida.StampLocal = "codtzstamp";
            this.gridsaida.TabelaSql = "codtz";
            this.gridsaida.TabIndex = 74;
            this.gridsaida.TbCodigo = "";
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
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.textAndImageColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.textAndImageColumn1.HeaderText = "Descrição";
            this.textAndImageColumn1.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.textAndImageColumn1.Name = "textAndImageColumn1";
            this.textAndImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmCodtz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(476, 430);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCodtz";
            this.Load += new System.EventHandler(this.FrmCodtz_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grident)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gridPanel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridsaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.GridPanel2 gridPanel21;
        private Generic.GridUi grident;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Generic.TextAndImageColumn arm;
        private System.Windows.Forms.TabPage tabPage2;
        private UC.GridPanel2 gridPanel22;
        private Generic.GridUi gridsaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Generic.TextAndImageColumn textAndImageColumn1;
    }
}
