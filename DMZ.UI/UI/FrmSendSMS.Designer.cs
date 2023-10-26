namespace DMZ.UI.UI
{
    partial class FrmSendSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSendSMS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchAlunos = new System.Windows.Forms.Button();
            this.gridUiHorarios = new DMZ.UI.Generic.GridUi();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraText3 = new DMZ.UI.UC.BarraText();
            this.btnConnect = new System.Windows.Forms.Button();
            this.barraText2 = new DMZ.UI.UC.BarraText();
            this.cmbCOM = new System.Windows.Forms.ComboBox();
            this.barraText1 = new DMZ.UI.UC.BarraText();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(586, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(554, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.Text = "Enviar SMS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearchAlunos);
            this.panel1.Controls.Add(this.gridUiHorarios);
            this.panel1.Controls.Add(this.barraText3);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.barraText2);
            this.panel1.Controls.Add(this.cmbCOM);
            this.panel1.Controls.Add(this.barraText1);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 536);
            this.panel1.TabIndex = 25;
            // 
            // btnSearchAlunos
            // 
            this.btnSearchAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnSearchAlunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSearchAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAlunos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSearchAlunos.Image = global::DMZ.UI.Properties.Resources.user_201px;
            this.btnSearchAlunos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchAlunos.Location = new System.Drawing.Point(478, 58);
            this.btnSearchAlunos.Name = "btnSearchAlunos";
            this.btnSearchAlunos.Size = new System.Drawing.Size(88, 25);
            this.btnSearchAlunos.TabIndex = 121;
            this.btnSearchAlunos.Text = "Alunos";
            this.btnSearchAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchAlunos.UseVisualStyleBackColor = false;
            this.btnSearchAlunos.Click += new System.EventHandler(this.btnSearchAlunos_Click);
            // 
            // gridUiHorarios
            // 
            this.gridUiHorarios.AddButtons = false;
            this.gridUiHorarios.AllowUserToAddRows = false;
            this.gridUiHorarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUiHorarios.AutoIncrimento = false;
            this.gridUiHorarios.BackgroundColor = System.Drawing.Color.White;
            this.gridUiHorarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUiHorarios.CampoCodigo = null;
            this.gridUiHorarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUiHorarios.Codigo = null;
            this.gridUiHorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUiHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUiHorarios.ColumnHeadersHeight = 30;
            this.gridUiHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUiHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Telefone});
            this.gridUiHorarios.Condicao = null;
            this.gridUiHorarios.CorPreto = true;
            this.gridUiHorarios.CurrentColumnName = null;
            this.gridUiHorarios.DefacolumnName = null;
            this.gridUiHorarios.DellGridRow = null;
            this.gridUiHorarios.DtDS = null;
            this.gridUiHorarios.EnableHeadersVisualStyles = false;
            this.gridUiHorarios.GenerateColumns = false;
            this.gridUiHorarios.GridColor = System.Drawing.Color.White;
            this.gridUiHorarios.GridFilha = false;
            this.gridUiHorarios.GridFilhaSecundaria = false;
            this.gridUiHorarios.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUiHorarios.HeadersHeight = 30;
            this.gridUiHorarios.HeadersVisible = false;
            this.gridUiHorarios.Location = new System.Drawing.Point(11, 83);
            this.gridUiHorarios.Name = "gridUiHorarios";
            this.gridUiHorarios.OrderbyCampos = null;
            this.gridUiHorarios.Origem = null;
            this.gridUiHorarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUiHorarios.RowHeadersVisible = false;
            this.gridUiHorarios.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridUiHorarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUiHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUiHorarios.Size = new System.Drawing.Size(556, 236);
            this.gridUiHorarios.StampCabecalho = "";
            this.gridUiHorarios.StampLocal = "";
            this.gridUiHorarios.TabelaSql = "";
            this.gridUiHorarios.TabIndex = 120;
            this.gridUiHorarios.TbCodigo = null;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefone.FillWeight = 7.874008F;
            this.Telefone.HeaderText = "Número de Telefone";
            this.Telefone.MinimumWidth = 250;
            this.Telefone.Name = "Telefone";
            // 
            // barraText3
            // 
            this.barraText3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraText3.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText3.Label1ForeColor = System.Drawing.Color.White;
            this.barraText3.Label1Text = "Selecçionar a porta";
            this.barraText3.Location = new System.Drawing.Point(9, 56);
            this.barraText3.Name = "barraText3";
            this.barraText3.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText3.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText3.PictureBox1Image")));
            this.barraText3.Size = new System.Drawing.Size(471, 30);
            this.barraText3.TabIndex = 77;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnConnect.Image = global::DMZ.UI.Properties.Resources.connect_25px;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.Location = new System.Drawing.Point(479, 1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 49);
            this.btnConnect.TabIndex = 75;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // barraText2
            // 
            this.barraText2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraText2.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText2.Label1ForeColor = System.Drawing.Color.White;
            this.barraText2.Label1Text = "Selecçionar a porta";
            this.barraText2.Location = new System.Drawing.Point(9, -1);
            this.barraText2.Name = "barraText2";
            this.barraText2.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText2.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText2.PictureBox1Image")));
            this.barraText2.Size = new System.Drawing.Size(471, 30);
            this.barraText2.TabIndex = 76;
            // 
            // cmbCOM
            // 
            this.cmbCOM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCOM.FormattingEnabled = true;
            this.cmbCOM.Location = new System.Drawing.Point(11, 29);
            this.cmbCOM.Name = "cmbCOM";
            this.cmbCOM.Size = new System.Drawing.Size(466, 21);
            this.cmbCOM.TabIndex = 24;
            // 
            // barraText1
            // 
            this.barraText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraText1.Label1Font = new System.Drawing.Font("Century Gothic", 9F);
            this.barraText1.Label1ForeColor = System.Drawing.Color.White;
            this.barraText1.Label1Text = "Digitar a mensagem ";
            this.barraText1.Location = new System.Drawing.Point(4, 329);
            this.barraText1.Name = "barraText1";
            this.barraText1.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.barraText1.PictureBox1Image = ((System.Drawing.Image)(resources.GetObject("barraText1.PictureBox1Image")));
            this.barraText1.Size = new System.Drawing.Size(564, 30);
            this.barraText1.TabIndex = 74;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSend.Image = global::DMZ.UI.Properties.Resources.Send_Email_20px;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.Location = new System.Drawing.Point(458, 491);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(109, 34);
            this.btnSend.TabIndex = 73;
            this.btnSend.Text = "Send SMS";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(6, 360);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(560, 124);
            this.txtMessage.TabIndex = 26;
            // 
            // FrmSendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(587, 575);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSendSMS";
            this.Load += new System.EventHandler(this.FrmSendSMS_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUiHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCOM;
        private System.Windows.Forms.TextBox txtMessage;
        public System.Windows.Forms.Button btnConnect;
        private UC.BarraText barraText2;
        private UC.BarraText barraText1;
        public System.Windows.Forms.Button btnSend;
        private UC.BarraText barraText3;
        private Generic.GridUi gridUiHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        public System.Windows.Forms.Button btnSearchAlunos;
    }
}
