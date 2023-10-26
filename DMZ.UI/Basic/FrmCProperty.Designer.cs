
namespace DMZ.UI.Basic
{
    partial class FrmCProperty
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
            this.gridPreco = new DMZ.UI.Generic.GridUi();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(222, 29);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(190, 2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.Text = "Class Properties";
            // 
            // gridPreco
            // 
            this.gridPreco.AddButtons = false;
            this.gridPreco.AllowUserToAddRows = false;
            this.gridPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPreco.AutoIncrimento = false;
            this.gridPreco.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridPreco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPreco.CampoCodigo = null;
            this.gridPreco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridPreco.Codigo = null;
            this.gridPreco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPreco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPreco.ColumnHeadersHeight = 30;
            this.gridPreco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPreco.Condicao = null;
            this.gridPreco.CorPreto = true;
            this.gridPreco.CurrentColumnName = null;
            this.gridPreco.DefacolumnName = null;
            this.gridPreco.DtDS = null;
            this.gridPreco.EnableHeadersVisualStyles = false;
            this.gridPreco.GenerateColumns = false;
            this.gridPreco.GridColor = System.Drawing.Color.SteelBlue;
            this.gridPreco.GridFilha = true;
            this.gridPreco.GridFilhaSecundaria = false;
            this.gridPreco.GridUIBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPreco.HeadersHeight = 30;
            this.gridPreco.HeadersVisible = false;
            this.gridPreco.Location = new System.Drawing.Point(2, 30);
            this.gridPreco.Name = "gridPreco";
            this.gridPreco.OrderbyCampos = null;
            this.gridPreco.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridPreco.RowHeadersVisible = false;
            this.gridPreco.RowHeadersWidth = 30;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridPreco.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPreco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPreco.Size = new System.Drawing.Size(222, 321);
            this.gridPreco.StampCabecalho = "clstamp";
            this.gridPreco.StampLocal = "ClContactstamp";
            this.gridPreco.TabelaSql = "ClContact";
            this.gridPreco.TabIndex = 25;
            this.gridPreco.TbCodigo = null;
            // 
            // FrmCProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(223, 354);
            this.Controls.Add(this.gridPreco);
            this.Name = "FrmCProperty";
            this.Load += new System.EventHandler(this.FrmCProperty_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.gridPreco, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Generic.GridUi gridPreco;
    }
}
