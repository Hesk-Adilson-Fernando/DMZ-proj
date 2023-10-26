namespace DMZ.UI.UC
{
    partial class GridTool
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
            this.panelText = new System.Windows.Forms.Panel();
            this.lblCodArmaz = new System.Windows.Forms.Label();
            this.tbArmazem = new System.Windows.Forms.TextBox();
            this.btnArmaz = new System.Windows.Forms.Button();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.labelArmazem = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dmzContextMenuStrip1 = new DMZContextMenuStrip();
            this.inserirLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarParaExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarParaWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.panelText.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dmzContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelText
            // 
            this.panelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panelText.Controls.Add(this.lblCodArmaz);
            this.panelText.Controls.Add(this.tbArmazem);
            this.panelText.Controls.Add(this.btnArmaz);
            this.panelText.Controls.Add(this.dtpData2);
            this.panelText.Controls.Add(this.label4);
            this.panelText.Controls.Add(this.label3);
            this.panelText.Controls.Add(this.dtpData1);
            this.panelText.Controls.Add(this.labelArmazem);
            this.panelText.Controls.Add(this.btnCalcular);
            this.panelText.Controls.Add(this.button1);
            this.panelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelText.Location = new System.Drawing.Point(0, 30);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(797, 39);
            this.panelText.TabIndex = 73;
            // 
            // lblCodArmaz
            // 
            this.lblCodArmaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodArmaz.AutoSize = true;
            this.lblCodArmaz.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodArmaz.ForeColor = System.Drawing.Color.White;
            this.lblCodArmaz.Location = new System.Drawing.Point(542, -2);
            this.lblCodArmaz.Name = "lblCodArmaz";
            this.lblCodArmaz.Size = new System.Drawing.Size(14, 16);
            this.lblCodArmaz.TabIndex = 42;
            this.lblCodArmaz.Text = "0";
            // 
            // tbArmazem
            // 
            this.tbArmazem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArmazem.Location = new System.Drawing.Point(509, 13);
            this.tbArmazem.Multiline = true;
            this.tbArmazem.Name = "tbArmazem";
            this.tbArmazem.Size = new System.Drawing.Size(170, 24);
            this.tbArmazem.TabIndex = 41;
            this.tbArmazem.Text = "Todos Armazens";
            // 
            // btnArmaz
            // 
            this.btnArmaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArmaz.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnArmaz.FlatAppearance.BorderSize = 0;
            this.btnArmaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnArmaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArmaz.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmaz.ForeColor = System.Drawing.Color.White;
            this.btnArmaz.Image = global::DMZ.UI.Properties.Resources.Hangar_20px;
            this.btnArmaz.Location = new System.Drawing.Point(484, 13);
            this.btnArmaz.Name = "btnArmaz";
            this.btnArmaz.Size = new System.Drawing.Size(25, 24);
            this.btnArmaz.TabIndex = 40;
            this.btnArmaz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dmzToolTip1.SetToolTip(this.btnArmaz, "Calcular");
            this.btnArmaz.UseVisualStyleBackColor = false;
            this.btnArmaz.Click += new System.EventHandler(this.btnArmaz_Click);
            // 
            // dtpData2
            // 
            this.dtpData2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpData2.CalendarForeColor = System.Drawing.Color.White;
            this.dtpData2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dtpData2.CalendarTitleBackColor = System.Drawing.Color.DarkGoldenrod;
            this.dtpData2.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpData2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData2.Location = new System.Drawing.Point(378, 17);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(97, 20);
            this.dtpData2.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(375, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Data Final:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(272, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Data Inicial:";
            // 
            // dtpData1
            // 
            this.dtpData1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpData1.CalendarForeColor = System.Drawing.Color.White;
            this.dtpData1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dtpData1.CalendarTitleBackColor = System.Drawing.Color.DarkGoldenrod;
            this.dtpData1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpData1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData1.Location = new System.Drawing.Point(275, 17);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(97, 20);
            this.dtpData1.TabIndex = 35;
            // 
            // labelArmazem
            // 
            this.labelArmazem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArmazem.AutoSize = true;
            this.labelArmazem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArmazem.ForeColor = System.Drawing.Color.White;
            this.labelArmazem.Location = new System.Drawing.Point(482, -3);
            this.labelArmazem.Name = "labelArmazem";
            this.labelArmazem.Size = new System.Drawing.Size(65, 16);
            this.labelArmazem.TabIndex = 34;
            this.labelArmazem.Text = "Armazem -";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Image = global::DMZ.UI.Properties.Resources.Suporte;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(680, 13);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 25);
            this.btnCalcular.TabIndex = 32;
            this.btnCalcular.Text = "   Executar";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dmzToolTip1.SetToolTip(this.btnCalcular, "Calcular");
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.button1.Location = new System.Drawing.Point(773, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 29);
            this.panel1.TabIndex = 75;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.txtDescricao.Location = new System.Drawing.Point(119, 3);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(310, 22);
            this.txtDescricao.TabIndex = 76;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.txtCodigo.Location = new System.Drawing.Point(13, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::DMZ.UI.Properties.Resources.Printer_Maintenance_25px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(762, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(33, 25);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dmzToolTip1.SetToolTip(this.btnPrint, "Imprimir");
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dmzContextMenuStrip1
            // 
            this.dmzContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzContextMenuStrip1.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.dmzContextMenuStrip1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dmzContextMenuStrip1.ForeColor = System.Drawing.Color.White;
            this.dmzContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirLinhaToolStripMenuItem,
            this.apagarLinhaToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportarParaExcelToolStripMenuItem,
            this.exportarParaWordToolStripMenuItem});
            this.dmzContextMenuStrip1.Name = "dmzContextMenuStrip1";
            this.dmzContextMenuStrip1.Size = new System.Drawing.Size(184, 98);
            // 
            // inserirLinhaToolStripMenuItem
            // 
            this.inserirLinhaToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Printer_Maintenance_25px;
            this.inserirLinhaToolStripMenuItem.Name = "inserirLinhaToolStripMenuItem";
            this.inserirLinhaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.inserirLinhaToolStripMenuItem.Text = "Imprimir ";
            // 
            // apagarLinhaToolStripMenuItem
            // 
            this.apagarLinhaToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.ApagarLinha;
            this.apagarLinhaToolStripMenuItem.Name = "apagarLinhaToolStripMenuItem";
            this.apagarLinhaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.apagarLinhaToolStripMenuItem.Text = "Apagar Linha";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // exportarParaExcelToolStripMenuItem
            // 
            this.exportarParaExcelToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Microsoft_Excel_25px;
            this.exportarParaExcelToolStripMenuItem.Name = "exportarParaExcelToolStripMenuItem";
            this.exportarParaExcelToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportarParaExcelToolStripMenuItem.Text = "Exportar para excel";
            this.exportarParaExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarParaExcelToolStripMenuItem_Click);
            // 
            // exportarParaWordToolStripMenuItem
            // 
            this.exportarParaWordToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Microsoft_Word_25px;
            this.exportarParaWordToolStripMenuItem.Name = "exportarParaWordToolStripMenuItem";
            this.exportarParaWordToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportarParaWordToolStripMenuItem.Text = "Exportar para word";
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "Infordata Software";
            // 
            // GridTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelText);
            this.Name = "GridTool";
            this.Size = new System.Drawing.Size(797, 73);
            this.Load += new System.EventHandler(this.GridTool_Load);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dmzContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelText;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnPrint;
        private DMZContextMenuStrip dmzContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirLinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarLinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportarParaExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaWordToolStripMenuItem;
        private Generic.DMZToolTip dmzToolTip1;
        public System.Windows.Forms.Button btnCalcular;
        public System.Windows.Forms.Label labelArmazem;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox tbArmazem;
        public System.Windows.Forms.Button btnArmaz;
        public System.Windows.Forms.Label lblCodArmaz;
    }
}
