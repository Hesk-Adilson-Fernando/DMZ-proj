
namespace DMZ.UI.UI
{
    partial class FrmRdlcxml
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridPanel21 = new DMZ.UI.UC.GridPanel2();
            this.gridDeb = new DMZ.UI.Generic.GridUi();
            this.Xmlstring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Querry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rdlcname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sel = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gridPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(799, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(767, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.Text = "Configuração de RDLC";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(2, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 554);
            this.panel1.TabIndex = 25;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 552);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.gridPanel21);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuração de RDLC";
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
            this.gridPanel21.Location = new System.Drawing.Point(7, 9);
            this.gridPanel21.MostraGravar = true;
            this.gridPanel21.Name = "gridPanel21";
            this.gridPanel21.NotAddLine = false;
            this.gridPanel21.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.gridPanel21.PictureBox1Image = global::DMZ.UI.Properties.Resources.Telephone_15px;
            this.gridPanel21.ShowColNames = false;
            this.gridPanel21.Size = new System.Drawing.Size(767, 516);
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
            this.gridDeb.BackgroundColor = System.Drawing.Color.Snow;
            this.gridDeb.CampoCodigo = "";
            this.gridDeb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridDeb.Codigo = "";
            this.gridDeb.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDeb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDeb.ColumnHeadersHeight = 30;
            this.gridDeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDeb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xmlstring,
            this.Descricao,
            this.Querry,
            this.Rdlcname,
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
            this.gridDeb.Location = new System.Drawing.Point(0, 27);
            this.gridDeb.Name = "gridDeb";
            this.gridDeb.OrderbyCampos = null;
            this.gridDeb.Origem = null;
            this.gridDeb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDeb.RowHeadersVisible = false;
            this.gridDeb.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.gridDeb.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDeb.RowTemplate.Height = 25;
            this.gridDeb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDeb.Size = new System.Drawing.Size(767, 486);
            this.gridDeb.StampCabecalho = "";
            this.gridDeb.StampLocal = "RdlcxmLstamp";
            this.gridDeb.TabelaSql = "Rdlcxml";
            this.gridDeb.TabIndex = 73;
            this.gridDeb.TbCodigo = "";
            this.gridDeb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeb_CellClick);
            this.gridDeb.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeb_CellDoubleClick);
            // 
            // Xmlstring
            // 
            this.Xmlstring.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Xmlstring.DataPropertyName = "Xmlstring";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Xmlstring.DefaultCellStyle = dataGridViewCellStyle2;
            this.Xmlstring.HeaderText = "RDLC XML";
            this.Xmlstring.Name = "Xmlstring";
            this.Xmlstring.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xmlstring.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Querry
            // 
            this.Querry.DataPropertyName = "Querry";
            this.Querry.HeaderText = "Querry";
            this.Querry.Name = "Querry";
            this.Querry.Width = 400;
            // 
            // Rdlcname
            // 
            this.Rdlcname.DataPropertyName = "Rdlcname";
            this.Rdlcname.HeaderText = "RDLC Nome";
            this.Rdlcname.Name = "Rdlcname";
            // 
            // sel
            // 
            this.sel.HeaderText = "...";
            this.sel.Image = global::DMZ.UI.Properties.Resources.Right_28px;
            this.sel.Name = "sel";
            this.sel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sel.Width = 30;
            // 
            // FrmRdlcxml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRdlcxml";
            this.Text = "FrmRdlcxml";
            this.Load += new System.EventHandler(this.FrmRdlcxml_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gridPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.GridPanel2 gridPanel21;
        private Generic.GridUi gridDeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xmlstring;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Querry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rdlcname;
        private System.Windows.Forms.DataGridViewImageColumn sel;
    }
}