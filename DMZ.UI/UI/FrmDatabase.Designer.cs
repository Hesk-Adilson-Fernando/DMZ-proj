namespace DMZ.UI.UI
{
    partial class FrmDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatabase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBack = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMenssagem = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDBname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.btnProcessBackup = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tabPageRestore = new System.Windows.Forms.TabPage();
            this.tbBD2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMessagem2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelBackup = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dmzToolTip1 = new DMZ.UI.Generic.DMZToolTip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBack.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageRestore.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(597, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(565, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.Text = "Administração da Base de Dados ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(148, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 460);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBack);
            this.tabControl1.Controls.Add(this.tabPageRestore);
            this.tabControl1.Location = new System.Drawing.Point(0, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBack
            // 
            this.tabPageBack.Controls.Add(this.panel3);
            this.tabPageBack.Controls.Add(this.btnOpen);
            this.tabPageBack.Controls.Add(this.label6);
            this.tabPageBack.Controls.Add(this.lblMenssagem);
            this.tabPageBack.Controls.Add(this.progressBar1);
            this.tabPageBack.Controls.Add(this.tbFileName);
            this.tabPageBack.Controls.Add(this.label5);
            this.tabPageBack.Controls.Add(this.tbDBname);
            this.tabPageBack.Controls.Add(this.label4);
            this.tabPageBack.Controls.Add(this.tbEndereco);
            this.tabPageBack.Controls.Add(this.btnProcessBackup);
            this.tabPageBack.Controls.Add(this.panel8);
            this.tabPageBack.Location = new System.Drawing.Point(4, 22);
            this.tabPageBack.Name = "tabPageBack";
            this.tabPageBack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBack.Size = new System.Drawing.Size(442, 432);
            this.tabPageBack.TabIndex = 0;
            this.tabPageBack.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(5, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 174);
            this.panel3.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "O assistente ajuda a ecfectuar cópias de segurança\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(28, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(381, 68);
            this.label7.TabIndex = 36;
            this.label7.Text = "Bem Vindo ao assinstente de cópia de segurança da\r\n Base de Dados ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOpen.Image = global::DMZ.UI.Properties.Resources.Open_in_Popup_25px;
            this.btnOpen.Location = new System.Drawing.Point(407, 324);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(28, 27);
            this.btnOpen.TabIndex = 109;
            this.dmzToolTip1.SetToolTip(this.btnOpen, "Eliminar empresa");
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(6, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 108;
            this.label6.Text = "Directório de backup";
            // 
            // lblMenssagem
            // 
            this.lblMenssagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMenssagem.AutoSize = true;
            this.lblMenssagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.lblMenssagem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenssagem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblMenssagem.Location = new System.Drawing.Point(3, 383);
            this.lblMenssagem.Name = "lblMenssagem";
            this.lblMenssagem.Size = new System.Drawing.Size(17, 17);
            this.lblMenssagem.TabIndex = 107;
            this.lblMenssagem.Text = "%";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.progressBar1.Location = new System.Drawing.Point(3, 403);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(318, 23);
            this.progressBar1.TabIndex = 106;
            // 
            // tbFileName
            // 
            this.tbFileName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbFileName.Location = new System.Drawing.Point(9, 274);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(398, 25);
            this.tbFileName.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(6, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 104;
            this.label5.Text = "Ficheiro de Backup";
            // 
            // tbDBname
            // 
            this.tbDBname.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDBname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbDBname.Location = new System.Drawing.Point(9, 227);
            this.tbDBname.Name = "tbDBname";
            this.tbDBname.ReadOnly = true;
            this.tbDBname.Size = new System.Drawing.Size(398, 25);
            this.tbDBname.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 101;
            this.label4.Text = "Base de Dados ";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbEndereco.Location = new System.Drawing.Point(9, 325);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.ReadOnly = true;
            this.tbEndereco.Size = new System.Drawing.Size(398, 25);
            this.tbEndereco.TabIndex = 92;
            // 
            // btnProcessBackup
            // 
            this.btnProcessBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnProcessBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProcessBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessBackup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessBackup.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProcessBackup.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.btnProcessBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessBackup.Location = new System.Drawing.Point(325, 389);
            this.btnProcessBackup.Name = "btnProcessBackup";
            this.btnProcessBackup.Size = new System.Drawing.Size(111, 40);
            this.btnProcessBackup.TabIndex = 85;
            this.btnProcessBackup.Text = "Executar";
            this.btnProcessBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessBackup.UseVisualStyleBackColor = false;
            this.btnProcessBackup.Click += new System.EventHandler(this.btnProcessBackup_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel8.Location = new System.Drawing.Point(5, 173);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(433, 19);
            this.panel8.TabIndex = 115;
            // 
            // tabPageRestore
            // 
            this.tabPageRestore.Controls.Add(this.tbBD2);
            this.tabPageRestore.Controls.Add(this.label8);
            this.tabPageRestore.Controls.Add(this.labelMessagem2);
            this.tabPageRestore.Controls.Add(this.progressBar2);
            this.tabPageRestore.Controls.Add(this.panel6);
            this.tabPageRestore.Controls.Add(this.label2);
            this.tabPageRestore.Controls.Add(this.btnSelBackup);
            this.tabPageRestore.Controls.Add(this.textBox1);
            this.tabPageRestore.Controls.Add(this.button4);
            this.tabPageRestore.Controls.Add(this.panel7);
            this.tabPageRestore.Location = new System.Drawing.Point(4, 22);
            this.tabPageRestore.Name = "tabPageRestore";
            this.tabPageRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRestore.Size = new System.Drawing.Size(442, 432);
            this.tabPageRestore.TabIndex = 1;
            this.tabPageRestore.UseVisualStyleBackColor = true;
            // 
            // tbBD2
            // 
            this.tbBD2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBD2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.tbBD2.Location = new System.Drawing.Point(9, 223);
            this.tbBD2.Name = "tbBD2";
            this.tbBD2.ReadOnly = true;
            this.tbBD2.Size = new System.Drawing.Size(398, 25);
            this.tbBD2.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(6, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 115;
            this.label8.Text = "Base de Dados ";
            // 
            // labelMessagem2
            // 
            this.labelMessagem2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMessagem2.AutoSize = true;
            this.labelMessagem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.labelMessagem2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessagem2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelMessagem2.Location = new System.Drawing.Point(3, 382);
            this.labelMessagem2.Name = "labelMessagem2";
            this.labelMessagem2.Size = new System.Drawing.Size(17, 17);
            this.labelMessagem2.TabIndex = 113;
            this.labelMessagem2.Text = "%";
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.progressBar2.Location = new System.Drawing.Point(3, 402);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(320, 23);
            this.progressBar2.TabIndex = 112;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(436, 174);
            this.panel6.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label9.Location = new System.Drawing.Point(27, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 68);
            this.label9.TabIndex = 36;
            this.label9.Text = "Bem Vindo ao assinstente de restauração da\r\n Base de Dados ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(6, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Ficheiro de Backup";
            // 
            // btnSelBackup
            // 
            this.btnSelBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnSelBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSelBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelBackup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelBackup.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSelBackup.Image = global::DMZ.UI.Properties.Resources.Opened_Folder_20px;
            this.btnSelBackup.Location = new System.Drawing.Point(403, 275);
            this.btnSelBackup.Name = "btnSelBackup";
            this.btnSelBackup.Size = new System.Drawing.Size(32, 26);
            this.btnSelBackup.TabIndex = 96;
            this.dmzToolTip1.SetToolTip(this.btnSelBackup, "Abrir a localização do ficheiro");
            this.btnSelBackup.UseVisualStyleBackColor = false;
            this.btnSelBackup.Click += new System.EventHandler(this.btnSelBackup_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.textBox1.Location = new System.Drawing.Point(6, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(399, 25);
            this.textBox1.TabIndex = 95;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.Image = global::DMZ.UI.Properties.Resources.Process_251px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(324, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 40);
            this.button4.TabIndex = 90;
            this.button4.Text = "Executar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel7.Location = new System.Drawing.Point(3, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(436, 19);
            this.panel7.TabIndex = 114;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnRestore);
            this.panel2.Controls.Add(this.btnBackup);
            this.panel2.Location = new System.Drawing.Point(6, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 460);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(-15, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(168, 178);
            this.panel5.TabIndex = 86;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel9.Location = new System.Drawing.Point(-110, -9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(388, 19);
            this.panel9.TabIndex = 117;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DMZ.UI.Properties.Resources.DMZ_7;
            this.pictureBox2.Location = new System.Drawing.Point(12, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRestore.Image = global::DMZ.UI.Properties.Resources.Data_Recovery_20px;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.Location = new System.Drawing.Point(3, 35);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(132, 30);
            this.btnRestore.TabIndex = 84;
            this.btnRestore.Text = "Restore";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBackup.Image = global::DMZ.UI.Properties.Resources.Data_Backup_20px;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.Location = new System.Drawing.Point(3, 3);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(132, 30);
            this.btnBackup.TabIndex = 82;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "Process_251px.png");
            // 
            // dmzToolTip1
            // 
            this.dmzToolTip1.BackColor = System.Drawing.Color.DarkCyan;
            this.dmzToolTip1.ForeColor = System.Drawing.Color.White;
            this.dmzToolTip1.OwnerDraw = true;
            this.dmzToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dmzToolTip1.ToolTipTitle = "DMZ Master 20";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDatabase";
            this.Text = "FrmDatabase";
            this.Load += new System.EventHandler(this.FrmDatabase_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBack.ResumeLayout(false);
            this.tabPageBack.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPageRestore.ResumeLayout(false);
            this.tabPageRestore.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBack;
        private System.Windows.Forms.TabPage tabPageRestore;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnProcessBackup;
        public System.Windows.Forms.Button btnRestore;
        public System.Windows.Forms.Button btnBackup;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tbEndereco;
        private Generic.DMZToolTip dmzToolTip1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSelBackup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDBname;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblMenssagem;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelMessagem2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbBD2;
        private System.Windows.Forms.Label label8;
    }
}