namespace DMZ.UI.UC
{
    partial class GridPanel2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panelText = new System.Windows.Forms.Panel();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dmzContextMenuStrip1 = new DMZ.UI.UC.DMZContextMenuStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarParaExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.importarDeExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.dmzContextMenuStrip2 = new DMZ.UI.UC.DMZContextMenuStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panelText.SuspendLayout();
            this.dmzContextMenuStrip1.SuspendLayout();
            this.dmzContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grid";
            // 
            // panelText
            // 
            this.panelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panelText.Controls.Add(this.btnGravar);
            this.panelText.Controls.Add(this.btnDell);
            this.panelText.Controls.Add(this.button2);
            this.panelText.Controls.Add(this.button1);
            this.panelText.Controls.Add(this.btnNovo);
            this.panelText.Controls.Add(this.label1);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelText.Location = new System.Drawing.Point(0, 0);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(684, 25);
            this.panelText.TabIndex = 72;
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Image = global::DMZ.UI.Properties.Resources.Save_as_23px;
            this.btnGravar.Location = new System.Drawing.Point(586, 1);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(22, 22);
            this.btnGravar.TabIndex = 35;
            this.dmzToolTip1.SetToolTip(this.btnGravar, "Gravar ");
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnDell
            // 
            this.btnDell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnDell.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDell.FlatAppearance.BorderSize = 0;
            this.btnDell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDell.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDell.ForeColor = System.Drawing.Color.White;
            this.btnDell.Image = global::DMZ.UI.Properties.Resources.Trash_252px;
            this.btnDell.Location = new System.Drawing.Point(634, 2);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(22, 22);
            this.btnDell.TabIndex = 34;
            this.dmzToolTip1.SetToolTip(this.btnDell, "Eliminar linha");
            this.btnDell.UseVisualStyleBackColor = false;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::DMZ.UI.Properties.Resources.Plus_23px_1;
            this.button2.Location = new System.Drawing.Point(612, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 33;
            this.dmzToolTip1.SetToolTip(this.button2, "Adicionar linha");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.button1.Location = new System.Drawing.Point(660, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 31;
            this.dmzToolTip1.SetToolTip(this.button1, "Opções da Grelha");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Black;
            this.btnNovo.Image = global::DMZ.UI.Properties.Resources.Settings_25px;
            this.btnNovo.Location = new System.Drawing.Point(3, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(22, 22);
            this.btnNovo.TabIndex = 30;
            this.dmzToolTip1.SetToolTip(this.btnNovo, "Inserir Linhas na grelha");
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dmzContextMenuStrip1
            // 
            this.dmzContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzContextMenuStrip1.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzContextMenuStrip1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dmzContextMenuStrip1.ForeColor = System.Drawing.Color.White;
            this.dmzContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exportarParaExcelToolStripMenuItem,
            this.toolStripSeparator4,
            this.importarDeExcelToolStripMenuItem});
            this.dmzContextMenuStrip1.Name = "dmzContextMenuStrip1";
            this.dmzContextMenuStrip1.Size = new System.Drawing.Size(182, 60);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // exportarParaExcelToolStripMenuItem
            // 
            this.exportarParaExcelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.pDFToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.exportarParaExcelToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Export_25px;
            this.exportarParaExcelToolStripMenuItem.Name = "exportarParaExcelToolStripMenuItem";
            this.exportarParaExcelToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportarParaExcelToolStripMenuItem.Text = "Exportar para excel";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.excelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.wordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.pDFToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.xMLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // importarDeExcelToolStripMenuItem
            // 
            this.importarDeExcelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem1,
            this.xMLToolStripMenuItem1,
            this.jsonToolStripMenuItem});
            this.importarDeExcelToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Import_25px;
            this.importarDeExcelToolStripMenuItem.Name = "importarDeExcelToolStripMenuItem";
            this.importarDeExcelToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.importarDeExcelToolStripMenuItem.Text = "Importar de Excel";
            // 
            // excelToolStripMenuItem1
            // 
            this.excelToolStripMenuItem1.BackColor = System.Drawing.Color.SaddleBrown;
            this.excelToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.excelToolStripMenuItem1.Name = "excelToolStripMenuItem1";
            this.excelToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.excelToolStripMenuItem1.Text = "Excel";
            this.excelToolStripMenuItem1.Click += new System.EventHandler(this.excelToolStripMenuItem1_Click);
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.xMLToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.jsonToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jsonToolStripMenuItem.Text = "Json";
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "Infordata Software";
            // 
            // dmzContextMenuStrip2
            // 
            this.dmzContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzContextMenuStrip2.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzContextMenuStrip2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dmzContextMenuStrip2.ForeColor = System.Drawing.Color.White;
            this.dmzContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripSeparator3});
            this.dmzContextMenuStrip2.Name = "dmzContextMenuStrip1";
            this.dmzContextMenuStrip2.Size = new System.Drawing.Size(182, 60);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::DMZ.UI.Properties.Resources.Microsoft_Excel_25px;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem3.Text = "Exportar para excel";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::DMZ.UI.Properties.Resources.Microsoft_Word_25px;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem4.Text = "Exportar para word";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // GridPanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelText);
            this.Name = "GridPanel2";
            this.Size = new System.Drawing.Size(684, 314);
            this.Load += new System.EventHandler(this.GridPanel_Load);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.dmzContextMenuStrip1.ResumeLayout(false);
            this.dmzContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelText;
        private Generic.DMZToolTip dmzToolTip1;
        public System.Windows.Forms.Button btnNovo;
        private DMZContextMenuStrip dmzContextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportarParaExcelToolStripMenuItem;
        public System.Windows.Forms.Button button1;
        private DMZContextMenuStrip dmzContextMenuStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.Button btnDell;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem importarDeExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
    }
}
