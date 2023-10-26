namespace DMZ.UI.UC
{
    partial class Procura
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btnProcura2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dmzContextMenuStrip1 = new DMZ.UI.UC.DMZContextMenuStrip();
            this.inserirLinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpneInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.dmzContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "label2";
            // 
            // tb1
            // 
            this.tb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(22, 17);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(189, 20);
            this.tb1.TabIndex = 36;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            this.tb1.MouseLeave += new System.EventHandler(this.tb1_MouseLeave);
            // 
            // btnProcura2
            // 
            this.btnProcura2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcura2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnProcura2.FlatAppearance.BorderSize = 0;
            this.btnProcura2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcura2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcura2.ForeColor = System.Drawing.Color.Transparent;
            this.btnProcura2.Image = global::DMZ.UI.Properties.Resources.Search_19px;
            this.btnProcura2.Location = new System.Drawing.Point(211, 17);
            this.btnProcura2.Name = "btnProcura2";
            this.btnProcura2.Size = new System.Drawing.Size(24, 20);
            this.btnProcura2.TabIndex = 37;
            this.btnProcura2.UseVisualStyleBackColor = false;
            this.btnProcura2.Click += new System.EventHandler(this.btnProcura2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.button1.ContextMenuStrip = this.dmzContextMenuStrip1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::DMZ.UI.Properties.Resources.Menu_Vertical_25px;
            this.button1.Location = new System.Drawing.Point(7, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 20);
            this.button1.TabIndex = 38;
            this.dmzToolTip1.SetToolTip(this.button1, "Clique para procurar");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.radLabel1_Click);
            // 
            // dmzContextMenuStrip1
            // 
            this.dmzContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.dmzContextMenuStrip1.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.dmzContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dmzContextMenuStrip1.ForeColor = System.Drawing.Color.White;
            this.dmzContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirLinhaToolStripMenuItem,
            this.toolStripSeparator1,
            this.btnOpneInfo});
            this.dmzContextMenuStrip1.Name = "dmzContextMenuStrip1";
            this.dmzContextMenuStrip1.Size = new System.Drawing.Size(191, 54);
            // 
            // inserirLinhaToolStripMenuItem
            // 
            this.inserirLinhaToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Automatic_25px;
            this.inserirLinhaToolStripMenuItem.Name = "inserirLinhaToolStripMenuItem";
            this.inserirLinhaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.inserirLinhaToolStripMenuItem.Text = "Inserir / Detalhes ";
            this.inserirLinhaToolStripMenuItem.Visible = false;
            this.inserirLinhaToolStripMenuItem.Click += new System.EventHandler(this.inserirLinhaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // btnOpneInfo
            // 
            this.btnOpneInfo.Image = global::DMZ.UI.Properties.Resources.Table_Properties_25px;
            this.btnOpneInfo.Name = "btnOpneInfo";
            this.btnOpneInfo.Size = new System.Drawing.Size(190, 22);
            this.btnOpneInfo.Text = "Inserir informação aberta";
            this.btnOpneInfo.Click += new System.EventHandler(this.btnOpneInfo_Click);
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Software";
            // 
            // Procura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProcura2);
            this.Name = "Procura";
            this.Size = new System.Drawing.Size(251, 39);
            this.Load += new System.EventHandler(this.Procura_Load);
            this.dmzContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnProcura2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb1;
        public System.Windows.Forms.Button button1;
        private DMZContextMenuStrip dmzContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirLinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnOpneInfo;
        private Generic.DMZToolTip dmzToolTip1;
    }
}
