using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using Utilities = DMZ.BL.Classes.Utilities;


namespace DMZ.UI.Basic
{
    public partial class PosProc : FrmClasse2
    {
        private string _type2;

        private DataTable _dt;
        public string Tipodados;
        public string Tabela;
        public string Campo { get; set; }
        public string Condicao1 { get; set; }
        public string DataNome { get; set; }
        public delegate void PassControl(Fact ft,bool origem =false);
        public PassControl PControl;
        //public Action<Fact> PControl;
        private string _campo1;
        private string _campo2;
        public bool Sonumero { get; set; }
        public PosProc()
        {
            InitializeComponent();
            Width = 365;
            Height = 116;
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            if (Multidocumento)
            {
                if (string.IsNullOrEmpty(Condicao1))
                {
                    Condicao2 = _type2 == "numeric" ? $" data ={numericUpDown1.Value}" : $" year({DataNome}) ={numericUpDown1.Value}";
                    
                }
                else
                {
                    Condicao2 = Condicao1 + $" and year(data) ={numericUpDown1.Value}";
                }
            }
            else
            {
                Condicao2 = Condicao1;
            }
            
            if (cbProc.Visible)
            {
               Executar(cbProc.Checked);
            }
            else
            {
                _dt = new DataTable();
                switch (Tipodados)
                {
                    case "numeric":
                    case "decimal":
                    {
                        if (string.IsNullOrEmpty(tbProc.Text))
                        {
                            MsBox.Show(@"Deve digitar o número a procurar");
                            tbProc.Focus();
                        }
                        else
                        {
                            var num = tbProc.Text.ToDecimal();
                            if (num==0)
                            {
                                MsBox.Show(@"Deve digitar números apenas!..");
                            }
                            else
                            {
                                Executar(tbProc.Text);
                            }
                        
                        }

                        break;
                    }
                    case "datetime":
                        // Executar(Pbl.SqlDateFormat(dateTimeInput1.Value));
                        break;
                    default:
                        Executar(tbProc.Text);
                        break;
                }
            }

        }//
        private void Executar( object cond)
        {
            if (Multidocumento)
            {
                Condicao2 = Condicao2.Replace($"{Pbl.SqlDate.Year}", $"{numericUpDown1.Value}");
            }
            var buildCond = Utilities.BuildCond(cond, Campo, Tipodados, Condicao2, cbContido.Checked);
            var sql = $"select * from {Tabela} where {buildCond} ";
            _dt = SQL.GetGenDT(sql); 
            CarregaGrid(_dt);
        }
        private void CarregaGrid(DataTable dt)
        {
            var count = dt.Rows.Count;
            switch (count)
            {
                case 0:
                    MsBox.Show(@"Não foi encontrado nenhum Registo");
                    ActualizaGrid(_dt);
                    Width = 365;
                    Height = 126;
                    btnSeach2.Visible = false;
                    break;
                case 1:
                    PControl?.Invoke(dt.DtToList<Fact>()[0]);
                    Close();
                    break;
                default:
                    ActualizaGrid(dt);
                    btnSeach2.Visible = true;
                    lblEncontrado.Visible = true;
                    break;
            }
        }

        private void ActualizaGrid(DataTable dt)
        {
            dgvProcura.DataSource = null;
            dgvProcura.AutoGenerateColumns = false;
            dgvProcura.DataSource = dt;
            lblEncontrado.Text = dt.Rows.Count + @" Encotrados";
            Width = 400;
            Height = 420;
        }

        private void EnviaDados()
        {
            var data = (DataTable)dgvProcura.DataSource;
            var indice = dgvProcura.SelectedRows[0].Index;
            PControl?.Invoke(data.DtToList<Fact>()[indice]);
            Sonumero = false;
            _dt.Dispose();
            Close(); 
        }
        public bool Multidocumento { get; set; }

        private string Condicao2 { get; set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbProc_Click(object sender, EventArgs e)
        {
            ////Process oskProcess =  Process.Start("OSK");
            //Int32 hWnd = FindWindow("TFirstForm", "hvkFirstForm");
            //PostMessage(hWnd, WM_CSKEYBOARD, 1, 0 ); // Show
        }

        private void POSProc_Load(object sender, EventArgs e)
        {
            //tbProc.GotFocus += textBox1_GotFocus;
            //tbProc.LostFocus += textBox1_LostFocus;

            _campo1 = "Numero";
            _campo2 = "nome";
            numericUpDown1.Visible = Multidocumento;
            numericUpDown1.Value = Pbl.SqlDate.Year;
            switch (Tipodados)
            {
                case "text":
                case "nvarchar":
                case "char":
                    tbProc.Text = string.Empty;
                    tbProc.Focus();
                    break;
                case "datetime":
                    //tbProc.Text = DateTime.Now.ToShortDateString();
                    tbProc.Visible = false;
                  //  dateTimeInput1.Visible = true;
                    break;
                case "bit":
                    cbProc.Visible = true;
                    cbProc.Checked = true;
                    tbProc.ReadOnly = true;
                    break;
                case "numeric":
                case "decimal":
                    //tbProc.WatermarkText = @"Digita apenas números";
                    //tbProc.Focus();
                    break;
            }
            tbProc.Focus();
            dgvProcura.Columns.Clear();
            dgvProcura.Columns.Add(_campo1, "Código");
            dgvProcura.Columns.Add(_campo2, "Descrição");
            dgvProcura.Columns[0].Width = 60;
            dgvProcura.Columns[1].Width = 400;
            dgvProcura.Columns[0].DataPropertyName= _campo1;
            dgvProcura.Columns[1].DataPropertyName = _campo2;
            btnSeach2.Visible = false;
            lblEncontrado.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (tbProc.TabIndex > 0)
            {
                Helper.StartOSK();
            }
        }
        private void tbProc_Enter(object sender, EventArgs e)
        {

        }
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            if (dgvProcura.Rows.Count == 0) return;
            EnviaDados();
        }

        private void btnKeyBoardUsr_Click(object sender, EventArgs e)
        {
            Helper.StartOSK();
        }

        private void tbProc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
