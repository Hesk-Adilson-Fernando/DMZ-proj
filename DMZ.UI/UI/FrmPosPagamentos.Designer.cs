namespace DMZ.UI.UI
{
    partial class FrmPosPagamentos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPw = new System.Windows.Forms.Button();
            this.lblData = new DMZ.UI.UC.DmzImgLabel();
            this.lblHora = new DMZ.UI.UC.DmzImgLabel();
            this.dmzImgLabel1 = new DMZ.UI.UC.DmzImgLabel();
            this.lblCcusto = new DMZ.UI.UC.DmzImgLabel();
            this.lblcaixa = new DMZ.UI.UC.DmzImgLabel();
            this.Empresa = new DMZ.UI.UC.DmzImgLabel();
            this.lblDoc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuPrincipal = new DMZ.UI.UC.DMZContextMenuStrip();
            this.aberturaDoCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folhaDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblTerminal = new DMZ.UI.UC.DmzImgLabel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_info_caixa = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridUI1 = new DMZ.UI.Generic.GridUi();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ccstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factstamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.btnDocs = new System.Windows.Forms.Button();
            this.btnFolhaCaixa = new System.Windows.Forms.Button();
            this.tbnAbertura = new System.Windows.Forms.Button();
            this.btnFechocaixa = new System.Windows.Forms.Button();
            this.btnCaixaPrint = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MenuPrincipal.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel_info_caixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUI1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCaixaPrint);
            this.panel4.Controls.Add(this.btnDocs);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.btnFolhaCaixa);
            this.panel4.Controls.Add(this.tbnAbertura);
            this.panel4.Controls.Add(this.btnFechocaixa);
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Controls.Add(this.lblDoc);
            this.panel4.Size = new System.Drawing.Size(1390, 37);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel4.Controls.SetChildIndex(this.btnClose, 0);
            this.panel4.Controls.SetChildIndex(this.lblDoc, 0);
            this.panel4.Controls.SetChildIndex(this.btnMinimize, 0);
            this.panel4.Controls.SetChildIndex(this.btnFechocaixa, 0);
            this.panel4.Controls.SetChildIndex(this.tbnAbertura, 0);
            this.panel4.Controls.SetChildIndex(this.btnFolhaCaixa, 0);
            this.panel4.Controls.SetChildIndex(this.panel12, 0);
            this.panel4.Controls.SetChildIndex(this.btnDocs, 0);
            this.panel4.Controls.SetChildIndex(this.btnCaixaPrint, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMZ.UI.Properties.Resources.Facturacao;
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnClose.Image = global::DMZ.UI.Properties.Resources.Close_Window_28px;
            this.btnClose.Location = new System.Drawing.Point(1341, 2);
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.Text = "DMZ SOFTWARE - POS v.2020\r\n";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.btnPw);
            this.panel5.Controls.Add(this.lblData);
            this.panel5.Controls.Add(this.lblHora);
            this.panel5.Controls.Add(this.dmzImgLabel1);
            this.panel5.Controls.Add(this.lblCcusto);
            this.panel5.Controls.Add(this.lblcaixa);
            this.panel5.Controls.Add(this.Empresa);
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 637);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1387, 39);
            this.panel5.TabIndex = 98;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1383, 3);
            this.panel3.TabIndex = 103;
            // 
            // btnPw
            // 
            this.btnPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnPw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPw.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPw.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPw.Image = global::DMZ.UI.Properties.Resources.Key_20px;
            this.btnPw.Location = new System.Drawing.Point(1351, 7);
            this.btnPw.Name = "btnPw";
            this.btnPw.Size = new System.Drawing.Size(30, 28);
            this.btnPw.TabIndex = 99;
            this.btnPw.UseVisualStyleBackColor = false;
            this.btnPw.Click += new System.EventHandler(this.btnPw_Click);
            // 
            // lblData
            // 
            this.lblData.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lblData.LabelFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.LabelForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblData.LabelText = "label1";
            this.lblData.Location = new System.Drawing.Point(121, 12);
            this.lblData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblData.Name = "lblData";
            this.lblData.PicImage = global::DMZ.UI.Properties.Resources.Calendar_20px;
            this.lblData.PicSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.lblData.Size = new System.Drawing.Size(146, 29);
            this.lblData.TabIndex = 85;
            // 
            // lblHora
            // 
            this.lblHora.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lblHora.LabelFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.LabelForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblHora.LabelText = "label1";
            this.lblHora.Location = new System.Drawing.Point(3, 12);
            this.lblHora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHora.Name = "lblHora";
            this.lblHora.PicImage = global::DMZ.UI.Properties.Resources.Clock_20px;
            this.lblHora.PicSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.lblHora.Size = new System.Drawing.Size(111, 29);
            this.lblHora.TabIndex = 84;
            // 
            // dmzImgLabel1
            // 
            this.dmzImgLabel1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.dmzImgLabel1.LabelFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmzImgLabel1.LabelForeColor = System.Drawing.Color.DarkGoldenrod;
            this.dmzImgLabel1.LabelText = "Utilizador";
            this.dmzImgLabel1.Location = new System.Drawing.Point(538, 12);
            this.dmzImgLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dmzImgLabel1.Name = "dmzImgLabel1";
            this.dmzImgLabel1.PicImage = global::DMZ.UI.Properties.Resources.Male_User_20px;
            this.dmzImgLabel1.PicSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.dmzImgLabel1.Size = new System.Drawing.Size(278, 29);
            this.dmzImgLabel1.TabIndex = 83;
            // 
            // lblCcusto
            // 
            this.lblCcusto.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lblCcusto.LabelFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCcusto.LabelForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCcusto.LabelText = "Centro de Custo";
            this.lblCcusto.Location = new System.Drawing.Point(1035, 12);
            this.lblCcusto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblCcusto.Name = "lblCcusto";
            this.lblCcusto.PicImage = global::DMZ.UI.Properties.Resources.DOT_25px;
            this.lblCcusto.PicSizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblCcusto.Size = new System.Drawing.Size(247, 30);
            this.lblCcusto.TabIndex = 82;
            // 
            // lblcaixa
            // 
            this.lblcaixa.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lblcaixa.LabelFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaixa.LabelForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblcaixa.LabelText = "Caixa";
            this.lblcaixa.Location = new System.Drawing.Point(822, 12);
            this.lblcaixa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblcaixa.Name = "lblcaixa";
            this.lblcaixa.PicImage = global::DMZ.UI.Properties.Resources.Cash_Register_20px;
            this.lblcaixa.PicSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.lblcaixa.Size = new System.Drawing.Size(207, 29);
            this.lblcaixa.TabIndex = 80;
            // 
            // Empresa
            // 
            this.Empresa.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.Empresa.LabelFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empresa.LabelForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Empresa.LabelText = "Empresa";
            this.Empresa.Location = new System.Drawing.Point(285, 12);
            this.Empresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Empresa.Name = "Empresa";
            this.Empresa.PicImage = global::DMZ.UI.Properties.Resources.Company_20px;
            this.Empresa.PicSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.Empresa.Size = new System.Drawing.Size(239, 29);
            this.Empresa.TabIndex = 79;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.ForeColor = System.Drawing.Color.White;
            this.lblDoc.Location = new System.Drawing.Point(572, 7);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(35, 13);
            this.lblDoc.TabIndex = 84;
            this.lblDoc.Text = "label3";
            this.lblDoc.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(637, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 49);
            this.panel2.TabIndex = 99;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel10.Location = new System.Drawing.Point(0, 44);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(750, 5);
            this.panel10.TabIndex = 101;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTotal.Location = new System.Drawing.Point(255, 4);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(483, 39);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "TOTAL:";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimize.Image = global::DMZ.UI.Properties.Resources.Minimize_Window_28px;
            this.btnMinimize.Location = new System.Drawing.Point(1309, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(39, 29);
            this.btnMinimize.TabIndex = 85;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.MenuPrincipal.ContextBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.MenuPrincipal.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.MenuPrincipal.ForeColor = System.Drawing.Color.White;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aberturaDoCaixaToolStripMenuItem,
            this.folhaDeCaixaToolStripMenuItem,
            this.fechoDeCaixaToolStripMenuItem,
            this.fichaDeClientesToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.documentosToolStripMenuItem});
            this.MenuPrincipal.Name = "dmzContextMenuStrip1";
            this.MenuPrincipal.Size = new System.Drawing.Size(176, 136);
            // 
            // aberturaDoCaixaToolStripMenuItem
            // 
            this.aberturaDoCaixaToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Open_Door_28px;
            this.aberturaDoCaixaToolStripMenuItem.Name = "aberturaDoCaixaToolStripMenuItem";
            this.aberturaDoCaixaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.aberturaDoCaixaToolStripMenuItem.Text = "Abertura do caixa";
            this.aberturaDoCaixaToolStripMenuItem.Click += new System.EventHandler(this.aberturaDoCaixaToolStripMenuItem_Click);
            // 
            // folhaDeCaixaToolStripMenuItem
            // 
            this.folhaDeCaixaToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Data_Sheet_28px;
            this.folhaDeCaixaToolStripMenuItem.Name = "folhaDeCaixaToolStripMenuItem";
            this.folhaDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.folhaDeCaixaToolStripMenuItem.Text = "Folha de caixa";
            this.folhaDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.folhaDeCaixaToolStripMenuItem_Click);
            // 
            // fechoDeCaixaToolStripMenuItem
            // 
            this.fechoDeCaixaToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Close_Sign_28px;
            this.fechoDeCaixaToolStripMenuItem.Name = "fechoDeCaixaToolStripMenuItem";
            this.fechoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fechoDeCaixaToolStripMenuItem.Text = "Fecho de caixa";
            this.fechoDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.fechoDeCaixaToolStripMenuItem_Click);
            // 
            // fichaDeClientesToolStripMenuItem
            // 
            this.fichaDeClientesToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Customer_28px;
            this.fichaDeClientesToolStripMenuItem.Name = "fichaDeClientesToolStripMenuItem";
            this.fichaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fichaDeClientesToolStripMenuItem.Text = "Ficha de clientes ";
            this.fichaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.fichaDeClientesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::DMZ.UI.Properties.Resources.Shutdown_28px;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel7.Controls.Add(this.btnRefrescar);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.lblTerminal);
            this.panel7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(0, 44);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(631, 45);
            this.panel7.TabIndex = 105;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRefrescar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRefrescar.Image = global::DMZ.UI.Properties.Resources.Synchronize_28px;
            this.btnRefrescar.Location = new System.Drawing.Point(594, 4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(32, 33);
            this.btnRefrescar.TabIndex = 105;
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dmzToolTip1.SetToolTip(this.btnRefrescar, "Actualizar a lista");
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel11.Location = new System.Drawing.Point(1, 42);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(629, 5);
            this.panel11.TabIndex = 102;
            // 
            // lblTerminal
            // 
            this.lblTerminal.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lblTerminal.LabelFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminal.LabelForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTerminal.LabelText = "Caixa";
            this.lblTerminal.Location = new System.Drawing.Point(12, 12);
            this.lblTerminal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.PicImage = global::DMZ.UI.Properties.Resources.Cash_Register_20px;
            this.lblTerminal.PicSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.lblTerminal.Size = new System.Drawing.Size(330, 20);
            this.lblTerminal.TabIndex = 106;
            this.lblTerminal.Visible = false;
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel15.BackgroundImage = global::DMZ.UI.Properties.Resources.pexels_oleg_magni_1005638;
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel15.Location = new System.Drawing.Point(637, 91);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(746, 543);
            this.panel15.TabIndex = 108;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.Panel_info_caixa);
            this.panel1.Controls.Add(this.gridUI1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 545);
            this.panel1.TabIndex = 109;
            // 
            // Panel_info_caixa
            // 
            this.Panel_info_caixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_info_caixa.BackColor = System.Drawing.Color.White;
            this.Panel_info_caixa.Controls.Add(this.label7);
            this.Panel_info_caixa.Controls.Add(this.label8);
            this.Panel_info_caixa.Location = new System.Drawing.Point(-1, 31);
            this.Panel_info_caixa.Name = "Panel_info_caixa";
            this.Panel_info_caixa.Size = new System.Drawing.Size(628, 545);
            this.Panel_info_caixa.TabIndex = 109;
            this.Panel_info_caixa.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(175, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(315, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "REALIZE ABERTURA DO CAIXA";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(82, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(469, 61);
            this.label8.TabIndex = 1;
            this.label8.Text = "CAIXA FECHADO";
            // 
            // gridUI1
            // 
            this.gridUI1.AddButtons = true;
            this.gridUI1.AllowUserToAddRows = false;
            this.gridUI1.AutoIncrimento = false;
            this.gridUI1.BackgroundColor = System.Drawing.Color.White;
            this.gridUI1.CampoCodigo = null;
            this.gridUI1.Codigo = null;
            this.gridUI1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUI1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUI1.ColumnHeadersHeight = 30;
            this.gridUI1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUI1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.debito,
            this.Pagar,
            this.ccstamp,
            this.factstamp});
            this.gridUI1.Condicao = null;
            this.gridUI1.CorPreto = true;
            this.gridUI1.CurrentColumnName = null;
            this.gridUI1.DefacolumnName = null;
            this.gridUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUI1.DtDS = null;
            this.gridUI1.EnableHeadersVisualStyles = false;
            this.gridUI1.GenerateColumns = false;
            this.gridUI1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.gridUI1.GridFilha = true;
            this.gridUI1.GridFilhaSecundaria = false;
            this.gridUI1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridUI1.HeadersHeight = 30;
            this.gridUI1.HeadersVisible = false;
            this.gridUI1.Location = new System.Drawing.Point(0, 0);
            this.gridUI1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridUI1.Name = "gridUI1";
            this.gridUI1.OrderbyCampos = null;
            this.gridUI1.RowHeadersVisible = false;
            this.gridUI1.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.gridUI1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUI1.RowTemplate.Height = 30;
            this.gridUI1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUI1.Size = new System.Drawing.Size(631, 545);
            this.gridUI1.StampCabecalho = "";
            this.gridUI1.StampLocal = "";
            this.gridUI1.TabelaSql = "";
            this.gridUI1.TabIndex = 108;
            this.gridUI1.TbCodigo = null;
            this.gridUI1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUI1_CellClick);
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "DESCRIÇÃO";
            this.nome.Name = "nome";
            // 
            // debito
            // 
            this.debito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.debito.DataPropertyName = "debito";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.debito.DefaultCellStyle = dataGridViewCellStyle2;
            this.debito.HeaderText = "TOTAL";
            this.debito.Name = "debito";
            this.debito.ReadOnly = true;
            // 
            // Pagar
            // 
            this.Pagar.HeaderText = ".....";
            this.Pagar.Image = global::DMZ.UI.Properties.Resources.POS_Terminal_28px;
            this.Pagar.Name = "Pagar";
            this.Pagar.Width = 35;
            // 
            // ccstamp
            // 
            this.ccstamp.DataPropertyName = "ccstamp";
            this.ccstamp.HeaderText = "ccstamp";
            this.ccstamp.Name = "ccstamp";
            this.ccstamp.Visible = false;
            // 
            // factstamp
            // 
            this.factstamp.DataPropertyName = "factstamp";
            this.factstamp.HeaderText = "factstamp";
            this.factstamp.Name = "factstamp";
            this.factstamp.Visible = false;
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Master 20";
            // 
            // btnDocs
            // 
            this.btnDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDocs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnDocs.FlatAppearance.BorderSize = 0;
            this.btnDocs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocs.ForeColor = System.Drawing.Color.White;
            this.btnDocs.Image = global::DMZ.UI.Properties.Resources.Document_28px;
            this.btnDocs.Location = new System.Drawing.Point(1248, 1);
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Size = new System.Drawing.Size(32, 33);
            this.btnDocs.TabIndex = 109;
            this.dmzToolTip1.SetToolTip(this.btnDocs, "Documentos Internos");
            this.btnDocs.UseVisualStyleBackColor = false;
            this.btnDocs.Click += new System.EventHandler(this.btnDocs_Click);
            // 
            // btnFolhaCaixa
            // 
            this.btnFolhaCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolhaCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnFolhaCaixa.FlatAppearance.BorderSize = 0;
            this.btnFolhaCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolhaCaixa.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnFolhaCaixa.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFolhaCaixa.Image = global::DMZ.UI.Properties.Resources.Dollar_Bitcoin_Exchange_28px;
            this.btnFolhaCaixa.Location = new System.Drawing.Point(1179, 1);
            this.btnFolhaCaixa.Name = "btnFolhaCaixa";
            this.btnFolhaCaixa.Size = new System.Drawing.Size(32, 33);
            this.btnFolhaCaixa.TabIndex = 108;
            this.btnFolhaCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dmzToolTip1.SetToolTip(this.btnFolhaCaixa, "Folha do caixa");
            this.btnFolhaCaixa.UseVisualStyleBackColor = false;
            this.btnFolhaCaixa.Click += new System.EventHandler(this.btnFolhaCaixa_Click);
            // 
            // tbnAbertura
            // 
            this.tbnAbertura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbnAbertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbnAbertura.FlatAppearance.BorderSize = 0;
            this.tbnAbertura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tbnAbertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnAbertura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnAbertura.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.tbnAbertura.Image = global::DMZ.UI.Properties.Resources.Open_Door_281px;
            this.tbnAbertura.Location = new System.Drawing.Point(1277, 1);
            this.tbnAbertura.Name = "tbnAbertura";
            this.tbnAbertura.Size = new System.Drawing.Size(32, 33);
            this.tbnAbertura.TabIndex = 106;
            this.dmzToolTip1.SetToolTip(this.tbnAbertura, "Abertura de caixa ");
            this.tbnAbertura.UseVisualStyleBackColor = false;
            this.tbnAbertura.Click += new System.EventHandler(this.tbnAbertura_Click);
            // 
            // btnFechocaixa
            // 
            this.btnFechocaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechocaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnFechocaixa.FlatAppearance.BorderSize = 0;
            this.btnFechocaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFechocaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechocaixa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechocaixa.ForeColor = System.Drawing.Color.White;
            this.btnFechocaixa.Image = global::DMZ.UI.Properties.Resources.Closed_Window_28px;
            this.btnFechocaixa.Location = new System.Drawing.Point(1215, 1);
            this.btnFechocaixa.Name = "btnFechocaixa";
            this.btnFechocaixa.Size = new System.Drawing.Size(32, 33);
            this.btnFechocaixa.TabIndex = 105;
            this.dmzToolTip1.SetToolTip(this.btnFechocaixa, "Fecho do caixa");
            this.btnFechocaixa.UseVisualStyleBackColor = false;
            this.btnFechocaixa.Click += new System.EventHandler(this.btnFechocaixa_Click);
            // 
            // btnCaixaPrint
            // 
            this.btnCaixaPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaixaPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnCaixaPrint.FlatAppearance.BorderSize = 0;
            this.btnCaixaPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixaPrint.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCaixaPrint.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCaixaPrint.Image = global::DMZ.UI.Properties.Resources.Print_28px;
            this.btnCaixaPrint.Location = new System.Drawing.Point(1141, 1);
            this.btnCaixaPrint.Name = "btnCaixaPrint";
            this.btnCaixaPrint.Size = new System.Drawing.Size(32, 33);
            this.btnCaixaPrint.TabIndex = 110;
            this.btnCaixaPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dmzToolTip1.SetToolTip(this.btnCaixaPrint, "Folha do caixa");
            this.btnCaixaPrint.UseVisualStyleBackColor = false;
            this.btnCaixaPrint.Click += new System.EventHandler(this.btnCaixaPrint_Click);
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel12.Location = new System.Drawing.Point(1309, 3);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 32);
            this.panel12.TabIndex = 107;
            // 
            // FrmPosPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1386, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Name = "FrmPosPagamentos";
            this.Load += new System.EventHandler(this.FrmPosPagamentos_Load);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.panel15, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MenuPrincipal.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Panel_info_caixa.ResumeLayout(false);
            this.Panel_info_caixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUI1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private UC.DmzImgLabel dmzImgLabel1;
        public UC.DmzImgLabel lblCcusto;
        public UC.DmzImgLabel lblcaixa;
        private UC.DmzImgLabel Empresa;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Timer timer1;
        private UC.DMZContextMenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem aberturaDoCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folhaDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel11;
        public UC.DmzImgLabel lblTerminal;
        private UC.DmzImgLabel lblData;
        private UC.DmzImgLabel lblHora;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_info_caixa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public Generic.GridUi gridUI1;
        private System.Windows.Forms.Button btnRefrescar;
        private Generic.DMZToolTip dmzToolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn debito;
        private System.Windows.Forms.DataGridViewImageColumn Pagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccstamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn factstamp;
        public System.Windows.Forms.Button btnPw;
        public System.Windows.Forms.Button btnDocs;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnFolhaCaixa;
        public System.Windows.Forms.Button tbnAbertura;
        public System.Windows.Forms.Button btnFechocaixa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCaixaPrint;
    }
}
