
namespace DMZ.UI.Generic
{
    partial class FrmPdfViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPdfViewer));
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbDefault2 = new DMZ.UI.UC.CbDefault();
            this.cbDefault1 = new DMZ.UI.UC.CbDefault();
            this.cbDefault3 = new DMZ.UI.UC.CbDefault();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dmzCMexport = new DMZ.UI.UC.DMZContextMenuStrip();
            this.exportarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarParaWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarParaPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarParaExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.dmzCMexport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMaxMin);
            this.panel4.Size = new System.Drawing.Size(719, 29);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.btnMaxMin, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(687, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.Text = "DMZ PDF Viewer ";
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxMin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaxMin.Image = global::DMZ.UI.Properties.Resources.Maximize_Window_25px;
            this.btnMaxMin.Location = new System.Drawing.Point(658, 3);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(23, 22);
            this.btnMaxMin.TabIndex = 86;
            this.btnMaxMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnOptions);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 44);
            this.panel2.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cbDefault2);
            this.panel5.Controls.Add(this.cbDefault1);
            this.panel5.Controls.Add(this.cbDefault3);
            this.panel5.Location = new System.Drawing.Point(274, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(384, 28);
            this.panel5.TabIndex = 2;
            // 
            // cbDefault2
            // 
            this.cbDefault2.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault2.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault2.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault2.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault2.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault2.CbText = "Duplicado";
            this.cbDefault2.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault2.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault2.Imagem")));
            this.cbDefault2.IsOptionGroup = false;
            this.cbDefault2.IsReadOnly = false;
            this.cbDefault2.IsRequered = false;
            this.cbDefault2.Location = new System.Drawing.Point(85, 3);
            this.cbDefault2.Name = "cbDefault2";
            this.cbDefault2.OnlyCheckBox = false;
            this.cbDefault2.Size = new System.Drawing.Size(90, 22);
            this.cbDefault2.TabIndex = 86;
            this.cbDefault2.Value = null;
            this.cbDefault2.Value2 = null;
            // 
            // cbDefault1
            // 
            this.cbDefault1.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault1.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault1.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault1.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault1.CbText = "Original";
            this.cbDefault1.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault1.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault1.Imagem")));
            this.cbDefault1.IsOptionGroup = false;
            this.cbDefault1.IsReadOnly = false;
            this.cbDefault1.IsRequered = false;
            this.cbDefault1.Location = new System.Drawing.Point(3, 3);
            this.cbDefault1.Name = "cbDefault1";
            this.cbDefault1.OnlyCheckBox = false;
            this.cbDefault1.Size = new System.Drawing.Size(90, 22);
            this.cbDefault1.TabIndex = 85;
            this.cbDefault1.Value = null;
            this.cbDefault1.Value2 = null;
            // 
            // cbDefault3
            // 
            this.cbDefault3.BackColor = System.Drawing.Color.Transparent;
            this.cbDefault3.BtnCheckAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault3.CbAnchorEditor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDefault3.CbFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault3.CbForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.cbDefault3.CbText = "Triplicado";
            this.cbDefault3.CbTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDefault3.Imagem = ((System.Drawing.Image)(resources.GetObject("cbDefault3.Imagem")));
            this.cbDefault3.IsOptionGroup = false;
            this.cbDefault3.IsReadOnly = false;
            this.cbDefault3.IsRequered = false;
            this.cbDefault3.Location = new System.Drawing.Point(181, 3);
            this.cbDefault3.Name = "cbDefault3";
            this.cbDefault3.OnlyCheckBox = false;
            this.cbDefault3.Size = new System.Drawing.Size(90, 22);
            this.cbDefault3.TabIndex = 87;
            this.cbDefault3.Value = null;
            this.cbDefault3.Value2 = null;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 89;
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOptions.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_251px;
            this.btnOptions.Location = new System.Drawing.Point(691, 4);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(21, 34);
            this.btnOptions.TabIndex = 84;
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Print_23px;
            this.btnPrint.Location = new System.Drawing.Point(661, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(28, 34);
            this.btnPrint.TabIndex = 81;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(5, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "Impressora";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(3, 80);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(714, 530);
            this.axAcroPDF1.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 610);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 7);
            this.panel1.TabIndex = 29;
            // 
            // dmzCMexport
            // 
            this.dmzCMexport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzCMexport.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzCMexport.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dmzCMexport.ForeColor = System.Drawing.Color.White;
            this.dmzCMexport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarDocumentoToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripComboBox1});
            this.dmzCMexport.Name = "dmzCMexport";
            this.dmzCMexport.Size = new System.Drawing.Size(182, 59);
            // 
            // exportarDocumentoToolStripMenuItem
            // 
            this.exportarDocumentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarParaWordToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportarParaPDFToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportarParaExcelToolStripMenuItem});
            this.exportarDocumentoToolStripMenuItem.Name = "exportarDocumentoToolStripMenuItem";
            this.exportarDocumentoToolStripMenuItem.ShowShortcutKeys = false;
            this.exportarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportarDocumentoToolStripMenuItem.Text = "Exportar documento";
            // 
            // exportarParaWordToolStripMenuItem
            // 
            this.exportarParaWordToolStripMenuItem.Checked = true;
            this.exportarParaWordToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportarParaWordToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exportarParaWordToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Microsoft_Word_25px;
            this.exportarParaWordToolStripMenuItem.Name = "exportarParaWordToolStripMenuItem";
            this.exportarParaWordToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exportarParaWordToolStripMenuItem.Text = "Word";
            this.exportarParaWordToolStripMenuItem.Click += new System.EventHandler(this.exportarParaWordToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // exportarParaPDFToolStripMenuItem
            // 
            this.exportarParaPDFToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.PDF_25px;
            this.exportarParaPDFToolStripMenuItem.Name = "exportarParaPDFToolStripMenuItem";
            this.exportarParaPDFToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exportarParaPDFToolStripMenuItem.Text = "PDF";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(100, 6);
            // 
            // exportarParaExcelToolStripMenuItem
            // 
            this.exportarParaExcelToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Microsoft_Excel_25px;
            this.exportarParaExcelToolStripMenuItem.Name = "exportarParaExcelToolStripMenuItem";
            this.exportarParaExcelToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exportarParaExcelToolStripMenuItem.Text = "Excel";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Tamanho da Página",
            "100%",
            "150%",
            "200%"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "100%";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandTimeout = 30;
            this.sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // FrmPdfViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(720, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmPdfViewer";
            this.Load += new System.EventHandler(this.FrmPDFViewer_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.axAcroPDF1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.dmzCMexport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        //public AxNitroPDFLib.AxNitroPDF axNitroPDF1;
        public System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private UC.CbDefault cbDefault2;
        private UC.CbDefault cbDefault1;
        private UC.CbDefault cbDefault3;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button btnOptions;
        public System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        public AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Panel panel1;
        private UC.DMZContextMenuStrip dmzCMexport;
        private System.Windows.Forms.ToolStripMenuItem exportarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportarParaPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exportarParaExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
    }
}
