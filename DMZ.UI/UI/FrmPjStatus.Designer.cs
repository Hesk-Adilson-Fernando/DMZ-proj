
namespace DMZ.UI.UI
{
    partial class FrmPjStatus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridUi1 = new DMZ.UI.Generic.GridUi();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmzProcura1 = new DMZ.UI.UC.DmzProcura();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.dmzStatus = new DMZ.UI.UC.DmzProcura();
            this.btnSerach = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(545, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(513, 2);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridUi1);
            this.panel1.Location = new System.Drawing.Point(2, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 405);
            this.panel1.TabIndex = 25;
            // 
            // gridUi1
            // 
            this.gridUi1.AddButtons = false;
            this.gridUi1.AllowUserToAddRows = false;
            this.gridUi1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUi1.AutoIncrimento = false;
            this.gridUi1.BackgroundColor = System.Drawing.Color.White;
            this.gridUi1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUi1.CampoCodigo = null;
            this.gridUi1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridUi1.Codigo = null;
            this.gridUi1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUi1.ColumnHeadersHeight = 30;
            this.gridUi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.nome});
            this.gridUi1.Condicao = null;
            this.gridUi1.CorPreto = true;
            this.gridUi1.CurrentColumnName = null;
            this.gridUi1.DefacolumnName = null;
            this.gridUi1.DellGridRow = null;
            this.gridUi1.DtDS = null;
            this.gridUi1.EnableHeadersVisualStyles = false;
            this.gridUi1.GenerateColumns = false;
            this.gridUi1.GridColor = System.Drawing.Color.SteelBlue;
            this.gridUi1.GridFilha = true;
            this.gridUi1.GridFilhaSecundaria = false;
            this.gridUi1.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUi1.HeadersHeight = 30;
            this.gridUi1.HeadersVisible = false;
            this.gridUi1.Location = new System.Drawing.Point(0, 0);
            this.gridUi1.Name = "gridUi1";
            this.gridUi1.OrderbyCampos = null;
            this.gridUi1.Origem = null;
            this.gridUi1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUi1.RowHeadersVisible = false;
            this.gridUi1.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridUi1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridUi1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUi1.Size = new System.Drawing.Size(537, 403);
            this.gridUi1.StampCabecalho = "clstamp";
            this.gridUi1.StampLocal = "Clststamp";
            this.gridUi1.TabelaSql = "Clst";
            this.gridUi1.TabIndex = 1;
            this.gridUi1.TbCodigo = null;
            this.gridUi1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUi1_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Número";
            this.Codigo.MinimumWidth = 100;
            this.Codigo.Name = "Codigo";
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Cliente";
            this.nome.Name = "nome";
            this.nome.Width = 220;
            // 
            // dmzProcura1
            // 
            this.dmzProcura1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzProcura1.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzProcura1.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzProcura1.IsLocaDs = false;
            this.dmzProcura1.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzProcura1.Label1Text = "Cliente";
            this.dmzProcura1.Location = new System.Drawing.Point(-3, 31);
            this.dmzProcura1.Name = "dmzProcura1";
            this.dmzProcura1.Pp = null;
            this.dmzProcura1.Size = new System.Drawing.Size(329, 39);
            this.dmzProcura1.SqlComandText = "select no,nome from cl";
            this.dmzProcura1.TabIndex = 26;
            this.dmzProcura1.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzProcura1.Tb1Multiline = false;
            this.dmzProcura1.Text2 = null;
            this.dmzProcura1.RefreshControls += new DMZ.UI.UC.DmzProcura.Refrescar(this.dmzProcura1_RefreshControls);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblQuantidade);
            this.panel2.Location = new System.Drawing.Point(2, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 25);
            this.panel2.TabIndex = 27;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.lblQuantidade.Location = new System.Drawing.Point(9, 1);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(52, 17);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "label2";
            // 
            // dmzStatus
            // 
            this.dmzStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzStatus.BtnProcAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzStatus.Button1Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.dmzStatus.IsLocaDs = false;
            this.dmzStatus.Label1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzStatus.Label1Text = "Status";
            this.dmzStatus.Location = new System.Drawing.Point(332, 31);
            this.dmzStatus.Name = "dmzStatus";
            this.dmzStatus.Pp = null;
            this.dmzStatus.Size = new System.Drawing.Size(176, 39);
            this.dmzStatus.SqlComandText = "select codigo,descricao from auxiliar where tabela =70";
            this.dmzStatus.TabIndex = 28;
            this.dmzStatus.Tb1Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmzStatus.Tb1Multiline = false;
            this.dmzStatus.Text2 = null;
            // 
            // btnSerach
            // 
            this.btnSerach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnSerach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSerach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerach.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerach.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSerach.Image = global::DMZ.UI.Properties.Resources.Search_20px;
            this.btnSerach.Location = new System.Drawing.Point(509, 46);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(30, 24);
            this.btnSerach.TabIndex = 101;
            this.btnSerach.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSerach.UseVisualStyleBackColor = false;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // FrmPjStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 514);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.dmzStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dmzProcura1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPjStatus";
            this.Text = "FrmPjStatus";
            this.Load += new System.EventHandler(this.FrmPjStatus_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dmzProcura1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dmzStatus, 0);
            this.Controls.SetChildIndex(this.btnSerach, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUi1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Generic.GridUi gridUi1;
        private UC.DmzProcura dmzProcura1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.Label lblQuantidade;
        private UC.DmzProcura dmzStatus;
        public System.Windows.Forms.Button btnSerach;
    }
}