using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DMZ.UI.UC
{
    public partial class PosRestButtomGroup : UserControl
    {
        public TextBox txtCodigo;
        public Button btnDescricao;
        public Button btnCodigo;

        public PosRestButtomGroup()
        {
            InitializeComponent();
        }
        public delegate void Refrescar();

        public event Refrescar RefreshControls;
        protected virtual void OnRefreshControls()
        {
            var handler = RefreshControls;
            handler?.Invoke();
        }

        public bool Descricao { get; private set; }
        public bool Codigo { get; set; }
        public bool Barcode { get; private set; }
        
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnDescricao = new System.Windows.Forms.Button();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(2, 29);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(274, 26);
            this.txtCodigo.TabIndex = 36;
            // 
            // btnDescricao
            // 
            this.btnDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnDescricao.FlatAppearance.BorderSize = 0;
            this.btnDescricao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescricao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescricao.ForeColor = System.Drawing.Color.White;
            //this.btnDescricao.Image = global::DMZ.UI.Properties.Resources.Checkmark_25px;
            this.btnDescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescricao.Location = new System.Drawing.Point(139, 4);
            this.btnDescricao.Name = "btnDescricao";
            this.btnDescricao.Size = new System.Drawing.Size(137, 24);
            this.btnDescricao.TabIndex = 34;
            this.btnDescricao.Text = "Descrição";
            this.btnDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescricao.UseVisualStyleBackColor = false;
            this.btnDescricao.Click += new System.EventHandler(this.btnDescricao_Click);
            // 
            // btnCodigo
            // 
            this.btnCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(80)))));
            this.btnCodigo.FlatAppearance.BorderSize = 0;
            this.btnCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.ForeColor = System.Drawing.Color.White;
            //this.btnCodigo.Image = global::DMZ.UI.Properties.Resources.Checkmark_25px;
            this.btnCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodigo.Location = new System.Drawing.Point(2, 4);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(135, 24);
            this.btnCodigo.TabIndex = 33;
            this.btnCodigo.Text = "Código";
            this.btnCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCodigo.UseVisualStyleBackColor = false;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // PosRestButtomGroup
            // 
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnDescricao);
            this.Controls.Add(this.btnCodigo);
            this.Name = "PosRestButtomGroup";
            this.Size = new System.Drawing.Size(279, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnDescricao_Click(object sender, EventArgs e)
        {
            btnDescricao.BackColor = Color.DarkGoldenrod;
            btnDescricao.Image = Properties.Resources.Checkmark_25px;
            btnCodigo.BackColor = Color.FromArgb(39, 59, 80);
            btnCodigo.Image = null;
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            btnCodigo.Image = Properties.Resources.Checkmark_25px;
            btnCodigo.BackColor = Color.DarkGoldenrod;
            btnDescricao.BackColor = Color.FromArgb(39, 59, 80);
            btnDescricao.Image = null;
        }
    }
}
