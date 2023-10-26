
namespace DMZ.UI.UI
{
    partial class FrmRltsql
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbProcura = new System.Windows.Forms.TextBox();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.gridDeb = new DMZ.UI.Generic.GridUi();
            this.panel7 = new System.Windows.Forms.Panel();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Querry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reportname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xmlstring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sel = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(798, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(766, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.Text = "Configuração de Mapas e Relatórios";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 565);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.tbProcura);
            this.tabPage1.Controls.Add(this.gridPanel21);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuração de mapas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbProcura
            // 
            this.tbProcura.BackColor = System.Drawing.Color.Snow;
            this.tbProcura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProcura.Location = new System.Drawing.Point(7, 2);
            this.tbProcura.Name = "tbProcura";
            this.tbProcura.Size = new System.Drawing.Size(295, 23);
            this.tbProcura.TabIndex = 94;
            this.tbProcura.TextChanged += new System.EventHandler(this.tbProcura_TextChanged);
            // 
            // gridPanel21
            // 
            this.gridPanel21.AddControls = false;
            this.gridPanel21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel21.Callform = false;
            this.gridPanel21.Controls.Add(this.gridDeb);
            this.gridPanel21.DefaultColumn = null;
            this.gridPanel21.Gridnome = "gridDeb";
            this.gridPanel21.GridpanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.Label1Color = System.Drawing.Color.White;
            this.gridPanel21.Label1Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPanel21.Label1Text = "";
            this.gridPanel21.Location = new System.Drawing.Point(7, 28);
            this.gridPanel21.MostraGravar = true;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.Telephone_15px;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(776, 509);
            this.gridPanel21.TabIndex = 78;
            this.gridPanel21.TipoMenu = false;
            this.gridPanel21.UsaNomeGrid = false;
            // 
            // gridDeb
            // 
            this.gridDeb.AddButtons = false;
            this.gridDeb.AllowUserToAddRows = false;
            this.gridDeb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDeb.AutoIncrimento = false;
            this.gridDeb.BackgroundColor = System.Drawing.Color.White;
            this.gridDeb.CampoCodigo = "";
            this.gridDeb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridDeb.Codigo = "";
            this.gridDeb.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDeb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDeb.ColumnHeadersHeight = 30;
            this.gridDeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDeb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao,
            this.Querry,
            this.origem,
            this.Reportname,
            this.Xmlstring,
            this.Tamanho,
            this.sel});
            this.gridDeb.Condicao = null;
            this.gridDeb.CorPreto = true;
            this.gridDeb.CurrentColumnName = null;
            this.gridDeb.DefacolumnName = null;
            this.gridDeb.DellGridRow = null;
            this.gridDeb.DtDS = null;
            this.gridDeb.EnableHeadersVisualStyles = false;
            this.gridDeb.GenerateColumns = false;
            this.gridDeb.GridColor = System.Drawing.Color.SteelBlue;
            this.gridDeb.GridFilha = false;
            this.gridDeb.GridFilhaSecundaria = false;
            this.gridDeb.GridUIBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridDeb.HeadersHeight = 30;
            this.gridDeb.HeadersVisible = false;
            this.gridDeb.Location = new System.Drawing.Point(0, 25);
            this.gridDeb.Name = "gridDeb";
            this.gridDeb.OrderbyCampos = null;
            this.gridDeb.Origem = null;
            this.gridDeb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDeb.RowHeadersVisible = false;
            this.gridDeb.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.gridDeb.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDeb.RowTemplate.Height = 20;
            this.gridDeb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDeb.Size = new System.Drawing.Size(776, 479);
            this.gridDeb.StampCabecalho = "";
            this.gridDeb.StampLocal = "Rltsqlstamp";
            this.gridDeb.TabelaSql = "Rltsql";
            this.gridDeb.TabIndex = 73;
            this.gridDeb.TbCodigo = "";
            this.gridDeb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeb_CellClick);
            this.gridDeb.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeb_CellDoubleClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 600);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(797, 5);
            this.panel7.TabIndex = 102;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 200;
            // 
            // Querry
            // 
            this.Querry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Querry.DataPropertyName = "Querry";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Querry.DefaultCellStyle = dataGridViewCellStyle2;
            this.Querry.HeaderText = "Querry";
            this.Querry.Name = "Querry";
            this.Querry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // origem
            // 
            this.origem.DataPropertyName = "origem";
            this.origem.HeaderText = "Origem";
            this.origem.Name = "origem";
            this.origem.Width = 80;
            // 
            // Reportname
            // 
            this.Reportname.DataPropertyName = "Reportname";
            this.Reportname.HeaderText = "RDLC Nome";
            this.Reportname.Name = "Reportname";
            // 
            // Xmlstring
            // 
            this.Xmlstring.DataPropertyName = "Xmlstring";
            this.Xmlstring.HeaderText = "Xmlstring";
            this.Xmlstring.Name = "Xmlstring";
            this.Xmlstring.Visible = false;
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "Tamanho";
            this.Tamanho.HeaderText = "Título";
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.Width = 130;
            // 
            // sel
            // 
            this.sel.HeaderText = "....";
            this.sel.Image = global::DMZ.UI.Properties.Resources.Right_28px;
            this.sel.Name = "sel";
            this.sel.Width = 30;
            // 
            // FrmRltsql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 605);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRltsql";
            this.Text = "FrmRltsql";
            this.Load += new System.EventHandler(this.FrmRltsql_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.GridPanel2 gridPanel21;
        private Generic.GridUi gridDeb;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Querry;
        private System.Windows.Forms.DataGridViewTextBoxColumn origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reportname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xmlstring;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewImageColumn sel;
    }
}