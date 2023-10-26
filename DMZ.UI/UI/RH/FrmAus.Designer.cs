
namespace DMZ.UI.UI.RH
{
    partial class FrmAus
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
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.grident = new DMZ.UI.Generic.GridUi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datain = new DMZ.UI.Generic.DateTimePickerColumn();
            this.Datater = new DMZ.UI.Generic.DateTimePickerColumn();
            this.Pcrocessa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grident)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(778, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(746, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.Text = "Ausenças Prolongadas ";
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
            this.gridPanel21.Label1Text = "";
            this.gridPanel21.Location = new System.Drawing.Point(2, 94);
            this.gridPanel21.MostraGravar = true;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.Bulleted_List_20px;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(776, 374);
            this.gridPanel21.TabIndex = 79;
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
            this.grident.AutoIncrimento = false;
            this.grident.BackgroundColor = System.Drawing.Color.White;
            this.grident.CampoCodigo = "";
            this.grident.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grident.Codigo = "";
            this.grident.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grident.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grident.ColumnHeadersHeight = 30;
            this.grident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grident.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.nome,
            this.Tipo,
            this.Datain,
            this.Datater,
            this.Pcrocessa,
            this.pestamp});
            this.grident.Condicao = "";
            this.grident.CorPreto = false;
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
            this.grident.Origem = null;
            this.grident.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grident.RowHeadersVisible = false;
            this.grident.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.grident.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grident.Size = new System.Drawing.Size(776, 344);
            this.grident.StampCabecalho = "";
            this.grident.StampLocal = "Peausstamp";
            this.grident.TabelaSql = "Peaus";
            this.grident.TabIndex = 73;
            this.grident.TbCodigo = "";
            this.grident.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grident_CellClick);
            this.grident.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grident_CellEndEdit);
            this.grident.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grident_EditingControlShowing);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 54);
            this.panel1.TabIndex = 80;
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "Número";
            this.no.Name = "no";
            this.no.Width = 60;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.nome.HeaderText = "Nome ";
            this.nome.Name = "nome";
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "descricao";
            this.Tipo.HeaderText = "Tipo de ausênca";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 150;
            // 
            // Datain
            // 
            this.Datain.DataPropertyName = "Datain";
            this.Datain.HeaderText = "Data Início";
            this.Datain.IsDateTime = false;
            this.Datain.Name = "Datain";
            this.Datain.Width = 90;
            // 
            // Datater
            // 
            this.Datater.HeaderText = "Data Término";
            this.Datater.IsDateTime = false;
            this.Datater.Name = "Datater";
            this.Datater.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Pcrocessa
            // 
            this.Pcrocessa.DataPropertyName = "processsa";
            this.Pcrocessa.HeaderText = "Processar";
            this.Pcrocessa.Name = "Pcrocessa";
            this.Pcrocessa.Width = 65;
            // 
            // pestamp
            // 
            this.pestamp.DataPropertyName = "pestamp";
            this.pestamp.HeaderText = "pestamp";
            this.pestamp.Name = "pestamp";
            this.pestamp.Visible = false;
            // 
            // FrmAus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(779, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridPanel21);
            this.Name = "FrmAus";
            this.Load += new System.EventHandler(this.FrmAus_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.gridPanel21, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grident)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.GridPanel2 gridPanel21;
        private Generic.GridUi grident;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private Generic.DateTimePickerColumn Datain;
        private Generic.DateTimePickerColumn Datater;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pcrocessa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pestamp;
    }
}
