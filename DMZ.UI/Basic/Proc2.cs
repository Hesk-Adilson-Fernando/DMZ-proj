using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;

using DMZ.UI.Generic;
using System.Drawing;
using Utilities = DMZ.BL.Classes.Utilities;

namespace DMZ.UI.Basic
{
    public partial class Proc2 : FrmClasse2
    {
        public delegate void PassControl(object sender, int posicao);
        public PassControl PControl;
        private readonly string _ctabela;
        private string _campo1;
        private readonly string _campo2;
        private string _type = string.Empty;
        public bool Multidocumento { get; set; }
        public bool Sonumero { get; set; }
        private DataTable _dt;
        public string Campo1Capition { get; set; }
        public string Campo2Capition { get; set; }
        #region Grupo Arastar 

        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }
        #endregion
        public Proc2(string ctabela,string campo,string campo2,string c,string cond)
            {
                _ctabela = ctabela;
                _campo1 = campo;
                _campo2 = campo2;
                Campo = c;
                Condicao1 = cond;
                InitializeComponent();
                Width = 365;
                Height = 126;
            }
        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private string _type2;

        private void Proc2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Visible = Multidocumento;
            numericUpDown1.Value = Pbl.SqlDate.Year;
            cbCcusto.Checked=TodosCentros; 
            _type =SQL.GetTipo(_ctabela ,Campo).Trim();
             _type2 = SQL.GetTipo(_ctabela, DataNome).Trim();
             switch (_type)
            {
                case "text":
                case "nvarchar":
                case "char":
                    tbProc.Text = string.Empty;
                    tbProc.Focus();
                    break;
                case "datetime":
                    tbProc.Visible = false;
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
            cbCcusto.Visible = Pbl.Usr.Usradmin;
            tbProc.Focus();
            dgvProcura.Columns.Clear();
            dgvProcura.Columns.Add(_campo1, Campo1Capition);
            dgvProcura.Columns.Add(_campo2, Campo2Capition);
            dgvProcura.Columns[0].Width = 130;
            dgvProcura.Columns[1].Width = 400;
            dgvProcura.Columns[0].DataPropertyName= _campo1;
            dgvProcura.Columns[1].DataPropertyName = _campo2;
            btnSeach2.Visible = false;
            lblEncontrado.Visible = false;
            WindowState = FormWindowState.Normal;
            var p = MdiParent;
            if (p == null) return;
            if (p.Name == "MdiCont")
            {
                panel4.BackColor = Color.FromArgb(39, 59, 80);
                btnClose.BackColor = Color.FromArgb(39, 59, 80);
                btnSeach2.BackColor = Color.FromArgb(39, 59, 80);
            }
        }       
        private void btnSeach_Click(object sender, EventArgs e)
        {
            Condicao2 = "";
           // Condicao1 = "";
            if (Multidocumento)
            {
                if (!cbCcusto.Checked)
                {
                    if (!Condicao1.IsNullOrEmpty())
                    {
                        Condicao1 = $" {Condicao1} and Ccusto = '{Pbl.Usr.Ccusto.Trim()}'";
                    }
                    else
                    {
                        Condicao1 = $"Ccusto = '{Pbl.Usr.Ccusto.Trim()}'";
                    }

                }
                //MsBox.Show(OldYear.ToString());
                if (string.IsNullOrEmpty(Condicao1))
                {
                    Condicao2 = _type2 == "numeric" ? $" {DataNome} ={numericUpDown1.Value}" : $" year({DataNome}) ={numericUpDown1.Value}";
                    
                }
                else
                {
                    Condicao2 = Condicao1 + $" and year({DataNome}) ={numericUpDown1.Value}";
                   // Condicao2 = Condicao1.Replace($"{OldYear}", $"{numericUpDown1.Value}");// + $" and year({DataNome}) ={numericUpDown1.Value}";
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
                switch (_type)
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
                                MsBox.Show(@"Deve digitar o números apenas!..");
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
        }

        private void Executar( object cond)
        {
            if (Multidocumento)
            {
                Condicao2 = Condicao2.Replace($"{Pbl.SqlDate.Year}", $"{numericUpDown1.Value}");
            }
            var buildCond = Utilities.BuildCond(cond, Campo, _type, Condicao2, cbContido.Checked);
            var camp1tipo = SQL.GetTipo(_ctabela, _campo1);
            switch (camp1tipo)
            {
                //case "nvarchar":
                //case "varchar":
                case "numeric":
                case "decimal":
                {
                    _campo1 = $"convert(decimal,{_campo1})";
                    break;
                }
            }


            if (string.IsNullOrEmpty(OrderByCampos))
            {
                OrderByCampos = $"{_campo1},{_campo2}";
            }
            var sql = $"select * from {_ctabela} where {buildCond} order by {OrderByCampos}";
            
            _dt = SQL.GetGenDT(sql); //_pg.Populate(_ctabela, tbProc.Text, Campo, _campo1, _campo2, _type, Condicao2, cbContido.Checked);
            CarregaGrid(_dt);
        }

        public string Condicao2 { get; set; }
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
                    //btnCancelar.Visible = false;
                    break;
                case 1:
                    PControl.Invoke(dt, 0);
                    Close();
                    break;
                    default:
                    ActualizaGrid(dt);
                    btnSeach2.Visible = true;
                    //btnCancelar.Visible = true;
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
            Width = 457;
            Height = 420;
        }

        private void EnviaDados(int posicao2)
            {
                var data = (DataTable)dgvProcura.DataSource;
                PControl?.Invoke(data, posicao2);
                Sonumero = false;
                _dt.Dispose();
                Close(); 
            }

        public string Campo { get; set; }
        public string Condicao1 { get; set; }
        public string DataNome { get; set; }
        public string OrderByCampos { get; set; }
        public decimal OldYear { get; private set; }
        public bool TodosCentros { get;  set; }=false;

        private void Proc2_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

        private void btnSeach2_Click(object sender, EventArgs e)
        {
            if (dgvProcura.Rows.Count == 0) return;

            EnviaDados(dgvProcura.SelectedRows.Count != 0 ? dgvProcura.CurrentRow.Index : 0);
        }

        private void Proc2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();                
        }

        private void dgvProcura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProcura.Rows.Count == 0) return;
            if (dgvProcura.CurrentRow != null)
                EnviaDados(dgvProcura.CurrentRow.Index);
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            OldYear = numericUpDown1.Value;
        }
    }

    }

