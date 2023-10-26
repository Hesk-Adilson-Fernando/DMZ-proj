using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.UC;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using DataTable = System.Data.DataTable;
namespace DMZ.UI.UI
{
    public partial class FrmRelatorios : Basic.FrmClasse2
    {
        public FrmRelatorios()
        {
            InitializeComponent();
        }
        private Rlt _rlt;
        private FrmReport _f;
        private DataTable _dt;
        private void FrmRelatorios_Load(object sender, EventArgs e)
        {
            btntpm.Visible = Pbl.Param.Modulos==1;
            BindGrid();
            PanelFiltro.Controls.Clear();
            if (Pbl.Param.Usacademia)
            {
                tbCliente.label1.Text = "Aluno";
                tbCcusto.label1.Text = "Unidade de Ensino";
            }
        }
        DataTable DtDados { get; set; }
        private void BindGrid()
        {
            var xxx = $@" select rlt.* from rlt right  join rltcc on rlt.Rltstamp =rltcc.Rltstamp 
                                                right join rltusr on rlt.Rltstamp = Rltusr.Rltstamp
                                                join Docmodulo on Rlt.Rltstamp = Docmodulo.Rltstamp
                                                where rltcc.ccusto='{Pbl.Usr.Ccusto}' and rltcc.estado=1 and 
                                                rltusr.Login='{Pbl.Usr.Login}' and Rltusr.Status=1 and Docmodulo.Codigo='{Modulo}' {CondicaoOrigem} order by numero";
           var dt = SQL.GetGen2DT(xxx);
           if (dt.HasRows())
           {
               gridUi1.SetDataSource(dt);
               EditMode = true;
               tbCcusto.Text2 = Pbl.Usr.Ccustamp;
               tbCcusto.tb1.Text = Pbl.Usr.Ccusto;
           }
        }
        public string Modulo { get; set; }
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (_rlt != null)
            {
                CTituloRelatorio = _rlt.Descricao;
                Condicao = string.Empty;
                Filtrado = string.Empty;
                switch (_rlt.Tipofilter)
                {
                    case 1:
                        SetFiltroData();
                        break;
                    case 2:
                        SetFiltroEntreDatas();
                        break;
                    case 3:
                        SetFiltroAno();
                        break;
                    case 4:
                        SetFiltroAno();
                        SetFiltroEntreDatas();
                        break;
                    case 5:
                        SetFiltroEntreAnos();
                        break;
                }

                if (!string.IsNullOrEmpty(_rlt.ComboQry1))
                {
                    if (!string.IsNullOrEmpty(tbCcusto.tb1.Text))
                    {
                        string cc;
                        if (_rlt.ComboQry1.ToLower().Contains("stamp"))
                        {
                            cc = string.Format(_rlt.ComboQry1, tbCcusto.Text2.Trim());
                        }
                        else
                        {
                            cc = string.Format(_rlt.ComboQry1, tbCcusto.tb1.Text.Trim());
                        }
                        Condicao = BuildFiltro(Condicao, cc);
                        Filtrado = BuildFiltrado(Filtrado, $"Centro de Custo: {tbCcusto.tb1.Text.Trim()}");
                    }
                }
                if (!string.IsNullOrEmpty(Moeda.tb1.Text))
                {
                    if (!_rlt.NaoMostraM)
                    {
                        if (!_rlt.ComboQry3.IsNullOrEmpty())
                        {
                            var tabela = _rlt.ComboQry3.Trim();
                            Condicao = Condicao.IsNullOrEmpty() ? $"{tabela}.moeda ='{Moeda.tb1.Text.Trim()}'" : $"{Condicao} and {tabela}.moeda ='{Moeda.tb1.Text.Trim()}'";
                            Filtrado = BuildFiltrado(Filtrado, $"Moeda: {Moeda.tb1.Text.Trim()}");
                        }
                        else
                        {
                            Condicao = Condicao.IsNullOrEmpty() ? $"moeda ='{Moeda.tb1.Text.Trim()}'" : $"{Condicao} and moeda ='{Moeda.tb1.Text.Trim()}'";
                            Filtrado = BuildFiltrado(Filtrado, $"Moeda: {Moeda.tb1.Text.Trim()}");
                        }
                    }
                }

                if (!string.IsNullOrEmpty(tbCliente.tb1.Text))
                {
                    switch (_rlt.Mostracfe)
                    {
                        case 1:
                            if (Pbl.Param.Usacademia)
                            {
                                BindCliente("Aluno", "cl");
                            }
                            else
                            {
                                BindCliente("Cliente", "cl");
                            }
                            break;
                        case 2:
                            BindCliente("Fornecedor", "fnc");
                            break;

                        case 3:
                            BindCliente("Entidade", "entidade");
                            break;

                        case 4:
                            BindCliente("Funcionário", "pe");
                            break;
                    }
                }

                if (_rlt.Mostrafp)
                {
                    if (!Formasp.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"titulo ='{Formasp.tb1.Text.Trim()}'" : $"{Condicao} and titulo ='{Formasp.tb1.Text.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Forma de pagamento: {Formasp.tb1.Text.Trim()}");
                    }
                }
                //Adcionar o Nível académico/Projecto 
                if (_rlt.Mostrapj)
                {
                    if (!tbPj.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"Nivelac ='{tbPj.tb1.Text.Trim()}'" : $"{Condicao} and Nivelac ='{tbPj.tb1.Text.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Nível Académico: {tbPj.tb1.Text.Trim()}");
                    }
                }
                //Adcionar o Utilizador 
                if (_rlt.Mostrausr)
                {
                    if (!tbUsr.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"Usrstamp ='{tbUsr.Text2.Trim()}'" : $"{Condicao} and Usrstamp ='{tbUsr.Text2.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Utilizador: {tbUsr.tb1.Text.Trim()}");
                    }
                }
                #region Bloco de Academia ........
                //Adcionar o Curso 
                if (_rlt.Mostracurso)
                {
                    if (!tbCurso.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"Cursostamp ='{tbCurso.Text2.Trim()}'" : $"{Condicao} and Cursostamp ='{tbCurso.Text2.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Curso: {tbCurso.tb1.Text.Trim()}");
                    }
                }
                //Fim 

                if (_rlt.Mostraturma)
                {
                    if (!tbTurma.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"Turmastamp ='{tbTurma.Text2.Trim()}'" : $"{Condicao} and Turmastamp ='{tbTurma.Text2.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Turma: {tbTurma.tb1.Text.Trim()}");
                    }
                }
                if (_rlt.Mostraprof)
                {
                    if (!tbProf.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"pestamp ='{tbProf.Text2.Trim()}'" : $"{Condicao} and Turmastamp ='{tbProf.Text2.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Professor: {tbProf.tb1.Text.Trim()}");
                    }
                }
                if (_rlt.MostraCorredor)
                {
                    if (!tbCorredor.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"Campo1 ='{tbCorredor.Text2.Trim()}'" : $"{Condicao} and Campo1 ='{tbCorredor.Text2.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Corredor: {tbCorredor.tb1.Text.Trim()}");
                    }
                }
                if (_rlt.Mostraanosem)
                {
                    if (!tbAnosem.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"AnoSemstamp ='{tbAnosem.Text2.Trim()}'" : $"{Condicao} and AnoSemstamp ='{tbAnosem.Text2.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"AnoSem: {tbAnosem.tb1.Text.Trim()}");
                    }
                }
                if (_rlt.Mostradisciplina)
                {
                    if (!tbDisciplina.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"Ststamp ='{tbDisciplina.Text2.Trim()}'" : $"{Condicao} and Ststamp ='{tbDisciplina.Text2.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Disciplina: {tbDisciplina.tb1.Text.Trim()}");
                    }
                }

                if (_rlt.Mostraplanocur)
                {
                    if (!tbPlano.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"Gradestamp ='{tbPlano.Text2.Trim()}'" : $"{Condicao} and Gradestamp ='{tbPlano.Text2.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Plano Curricular: {tbPlano.tb1.Text.Trim()}");
                    }
                }
                if (_rlt.Mostraetapasem)
                {
                    if (!tbEtapa.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"Semstamp ='{tbEtapa.Text2.Trim()}'" : $"{Condicao} and Semstamp ='{tbEtapa.Text2.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Etapa/Semestre: {tbEtapa.tb1.Text.Trim()}");
                    }
                }
                #endregion

                if (_rlt.MostraTesoura)
                {
                    if (!Tesouraria.tb1.Text.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"Contatesoura ='{Tesouraria.tb1.Text.Trim()}'" : $"{Condicao} and Contatesoura ='{Tesouraria.tb1.Text.Trim()}'";
                        Filtrado = BuildFiltrado(Filtrado, $"Conta: {Tesouraria.tb1.Text.Trim()}");
                    }
                }
                if (_rlt.Tipofilter==3)
                {
                    if (_rlt.ComboQry2.IsNullOrEmpty())
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"ano ={dmzDdN1.ano.Value}" : $"{Condicao} and ano ={dmzDdN1.ano.Value}";
                    }
                    else
                    {
                        Condicao = Condicao.IsNullOrEmpty() ? $"{_rlt.ComboQry2} ={dmzDdN1.ano.Value}" : $"{Condicao} and {_rlt.ComboQry2} ={dmzDdN1.ano.Value}";
                    }
                    Filtrado = BuildFiltrado(Filtrado, $"Ano: {dmzDdN1.ano.Value}");
                }
                var str = _rlt.CrQuery;
                if (Condicao.IsNullOrEmpty())
                {
                    //
                    if (str.Contains("where"))
                    {
                        str = str.Replace("where", "");
                    }
                    if (str.Contains("{0}"))
                    {
                        str = str.Replace("{0}", "");
                    }
                    if (str.Contains("{1}"))
                    {
                        str = str.Replace("{1}", "");
                    }
                    if (_rlt.CrQuery.ToLower().Contains("SUM(CASE WHEN Mediafinal >9.5  THEN 1 ELSE 0 END)".ToLower()))
                    {
                        str = _rlt.CrQuery;
                        if (!Condicao.IsNullOrEmpty() && !Condicao.Contains("where"))
                        {
                            Condicao = $@" where {Condicao}";
                        }
                    }

                    if (_rlt.CrQuery.ToLower().Contains("where Clstamp  is not null {0} order by Curso,nome".ToLower()))
                    {
                        str = _rlt.CrQuery;
                        if (!Condicao.IsNullOrEmpty() && !Condicao.Contains("where"))
                        {
                            Condicao = $@" where {Condicao}";
                        }
                    }
                }

                if (_rlt.CrQuery.ToLower().
                    Contains("matric  is not null {0} group by num_row,curso".ToLower())
                    ||_rlt.ClnTab.Equals("RptMapanaoinscrito")
                    ||_rlt.CrQuery.ToLower().Contains("matric  is null {0}  group by num_row,curso,Cursostamp".ToLower()))
                {
                    str = _rlt.CrQuery;
                    if (!Condicao.IsNullOrEmpty() && !Condicao.Contains("and"))
                    {
                        Condicao = $@" and {Condicao}";
                    }

                    if (!Condicao.TrimStart().StartsWith("and"))
                    {
                        Condicao = $@" and {Condicao}";
                    }
                    //Copia este u
                }
  
                var sqlQuerry = string.Format(str, Condicao, Moeda.tb1.Text.Trim());
                sqlQuerry =sqlQuerry.Replace("{0}", "").Replace("{1}", "")
                    .Replace("matric  is not null  and  group by num_row,curso", "matric  is not null group by num_row,curso")
                    .Replace("matric  is null  and   group by num_row,curso", "matric  is null group by num_row,curso")
                    .Replace("is not null   and  group", "is not null  group").
                    Replace("''Clstamp", $@"'{tbCliente.Text2}'Clstamp").
                    Replace("''Turmastamp", $@"'{tbTurma.Text2}'Turmastamp").
                    Replace("''Ccusto", $@"'{tbCcusto.tb1.Text}'Ccusto").
                    Replace("''Cursostamp", $@"'{tbCurso.Text2}'Cursostamp").
                    Replace("''No", $@"'{tbCliente.Text3}'No").
                    Replace("''Nome", $@"'{tbCliente.tb1.Text}'Nome");
                if (sqlQuerry.Contains("rcl.ccusto"))
                {
                    sqlQuerry=sqlQuerry.Replace("and moeda =", "and rcl.moeda =");
                }
                DtDados= _dt = SQL.GetGenDT(sqlQuerry);
                if (!_rlt.Geramapa)
                {
                    if (_dt.HasRows())
                    {
                        Options(_rlt.Tabela.Trim(), _rlt.ClnTab.Trim(), _rlt.XmlString);
                    }
                    else
                    {
                        MsBox.Show("O Software não encontrou nada para o(s) parâmentro(s) indicado(s)");
                    }
                }
                else
                {
                    var dt = SQL.GetGen2DT($"select * from Rltmapa where rltstamp='{_rlt.Rltstamp.Trim()}'");
                    if (!dt.HasRows()) return;
                    foreach (var dr in dt.AsEnumerable())
                    {
                        DataGridViewColumn col = null;
                        switch (dr["ColumnType"].ToString().Trim())
                        {
                            case "DataGridViewTextBoxColumn":
                                col = new DataGridViewTextBoxColumn();
                                break;
                            case "DataGridViewCheckBoxColumn":
                                col = new DataGridViewCheckBoxColumn();
                                break;
                            case "DataGridViewButtonColumn":
                                col = new DataGridViewButtonColumn();
                                break;
                            case "DataGridViewLinkColumn":
                                col = new DataGridViewLinkColumn();
                                break;
                        }
                        col.DataPropertyName = dr["DataPropertyName"].ToString();
                        col.HeaderText = dr["nome"].ToString();
                        col.DefaultCellStyle.Format = dr["Formatacao"].ToString();
                        switch (dr["Col1"].ToString().Trim())
                        {
                            case "AllCells":
                                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;
                            case "Fill":
                                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                break;
                            case "None":
                                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                                break;
                            case "ColumnHeader":
                                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                                break;
                            case "DisplayedCells":
                                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                                break;
                        }
                        switch (dr["Formatacao"].ToString())
                        {
                            case "MiddleLeft":
                                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                                break;
                            case "MiddleRight":
                                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                break;
                            case "BottomCenter":
                                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                                break;
                            case "MiddleCenter":
                                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                break;
                            case "TopRight":
                                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                                break;
                            case "TopLeft":
                                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                                break;
                            default:
                                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;
                                break;
                        }
                        col.Width = dr["Tamanho"].ToInt();
                        gridUiMapa.Columns.Add(col);
                    }

                    gridUiMapa.SetDataSource(_dt);
                    tabControl1.SelectTab(tabPageMapa);
                }
            }
            else
            {
                MsBox.Show("Deve selecionar a linha desejada na tabela!..");
            }
        }
        private void SetFiltroData()
        {
            if (dmzData1.checkBox1.Checked)
            {
                string data;
                if (_rlt.FiltroData.IsNullOrEmpty())
                {
                    data = $" CONVERT(date, data) = '{dmzData1.dt1.Value.Date.ToSqlDate()}' ";
                }
                else
                {
                    data = string.Format(_rlt.FiltroData, dmzData1.dt1.Value.Date.ToSqlDate());
                }
                Condicao = BuildFiltro(Condicao, data);
                Filtrado = BuildFiltrado(Filtrado, $"Data: {dmzData1.dt1.Value.Date.ToShortDateString()} "); 
            }
        }

        private void SetFiltroEntreAnos()
        {
            if (dmzEntreAnos1.checkBox1.Checked)
            {
                string entreanos;
                if (string.IsNullOrEmpty(_rlt.FiltroEntreAnos))
                {
                    entreanos = $"ano >= {dmzEntreAnos1.numericUpDown1.Value} and ano <= {dmzEntreAnos1.numericUpDown2.Value}";
                }
                else
                {
                    entreanos = string.Format(_rlt.FiltroEntreAnos, dmzEntreAnos1.numericUpDown1.Value, dmzEntreAnos1.numericUpDown2.Value);
                }
                Condicao = BuildFiltro(Condicao, entreanos);
                Filtrado = BuildFiltrado(Filtrado, $"Anos: {dmzEntreAnos1.numericUpDown1.Value} - {dmzEntreAnos1.numericUpDown2.Value}"); 
            }
        }

        private void SetFiltroEntreDatas()
        {
            if (dmzEntreDatas1.checkBox1.Checked)
            {
                string entredatas;
                if (string.IsNullOrEmpty(_rlt.FiltroEntreDatas))
                {
                    entredatas = $"CONVERT(date, data) >= '{dmzEntreDatas1.dt1.Value.Date.ToSqlDate()}' and CONVERT(date, data)<= '{dmzEntreDatas1.dt2.Value.Date.ToSqlDate()}'";
                }
                else
                {
                    entredatas = string.Format(_rlt.FiltroEntreDatas, dmzEntreDatas1.dt1.Value.Date.ToSqlDate(), dmzEntreDatas1.dt2.Value.Date.ToSqlDate());
                }
                Condicao = BuildFiltro(Condicao, entredatas);
                Filtrado = BuildFiltrado(Filtrado, $"Período: {dmzEntreDatas1.dt1.Value.Date.ToShortDateString()} -{dmzEntreDatas1.dt2.Value.Date.ToShortDateString()} "); 
            }
        }

        private void SetFiltroAno()
        {
            if (dmzDdN1.checkBox1.Checked)
            {
                string ano;
                if (_rlt.FiltroAno.IsNullOrEmpty())
                {
                    ano = $" ano = {dmzDdN1.ano.Value} ";
                }
                else
                {
                    ano = string.Format(_rlt.FiltroAno, dmzDdN1.ano.Value);
                }
                Condicao = BuildFiltro(Condicao, ano);
                Filtrado = BuildFiltrado(Filtrado, $"Ano: {dmzDdN1.ano.Value} "); 
            }
        }

        private void BindCliente(string descricao, string tabela)
        {
            if (!tbCliente.Text2.IsNullOrEmpty())
            {
                Condicao = Condicao.IsNullOrEmpty() ? $" {tabela}stamp ='{tbCliente.Text2.Trim()}'" : $"{Condicao} and {tabela}stamp ='{tbCliente.Text2.Trim()}'";
            
            
                Filtrado = BuildFiltrado(Filtrado, $"{descricao}: {tbCliente.tb1.Text.Trim()}");
            }
        }

        public string Filtrado { get; set; }

        private string BuildFiltrado(string filtro, string subfiltro)
        {
            if (string.IsNullOrEmpty(filtro))
            {
                filtro = subfiltro;
            }
            else
            {
                filtro = filtro + "\r\n" + subfiltro;
            }

            return filtro;
        }

        private string BuildFiltro(string filtro, string subfiltro)
        {
            if (string.IsNullOrEmpty(filtro))
            {
                filtro = subfiltro;
            }
            else
            {
                filtro =filtro+" and "+ subfiltro;
            }

            return filtro;
        }

        public string Condicao { get; set; }

        private void Options(string tabela,string reportname,string xml="")
        {
            DS ds = new DS();
            var ret = Imprimir.FillDataEnt(null, _dt, null, ds.DMZ, null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, "", false, label1.Text, "", reportname, "RLT", this, xml, true, ds, Filtrado, CTituloRelatorio);
        }

        public string CTituloRelatorio { get; set; }
        public string Origem { get; set; }
        public string CondicaoOrigem { get;  set; }
        

        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi1.SelectedRows.Count==0)return;
           var dr = gridUi1.SelectedRows[0].ToDataRow();
           _rlt = dr.DrToEntity<Rlt>();
            if (_rlt == null) return;
            PanelFiltro.Controls.Clear();
            if (!_rlt.ComboQry1.IsNullOrEmpty())
            {
                tbCcusto.Visible=true;
                PanelFiltro.Controls.Add(tbCcusto);
            }
            if (_rlt.Mostracfe>0)
            {
                switch (_rlt.Mostracfe)
                {
                    case 1:
                        if (Pbl.Param.Usacademia)
                        {
                            ShowCliente("cl", "Aluno");
                        }
                        else
                            ShowCliente("cl","Cliente");
                        break;
                    case 2:
                        ShowCliente("fnc","Fornecedor");
                    break;

                    case 3:
                        ShowCliente("Ent","Entidade");
                    break;
                    case 4:
                        ShowCliente("pe", "Funcionário");
                        break;
                    case 5:
                        ShowCliente("tur", "Turma");
                        break;
                }
            }
            if (_rlt.Mostrafp)
            {
                Formasp.Visible = _rlt.Mostrafp;
                PanelFiltro.Controls.Add(Formasp);
            }
            if (_rlt.MostraCorredor)
            {
                tbCorredor.Visible = _rlt.MostraCorredor;
                PanelFiltro.Controls.Add(tbCorredor);
            }
            
            //Mostra Tesouraria 
            if (_rlt.MostraTesoura)
            {
                Tesouraria.Visible = _rlt.MostraTesoura;
                PanelFiltro.Controls.Add(Tesouraria);
            }
            //Mostra Utilizador 
            if (_rlt.Mostrausr)
            {
                tbUsr.Visible = _rlt.Mostrausr;
                PanelFiltro.Controls.Add(tbUsr);
            }
            //Mostra Projecto
            if (_rlt.Mostrapj)
            {
                tbPj.Visible = _rlt.Mostrapj;
                PanelFiltro.Controls.Add(tbPj);
            }

            if (_rlt.Mostraprc)
            {
                Process.Visible = _rlt.Mostraprc;
                PanelFiltro.Controls.Add(Process);
                dmzDdN1.ano.Value = Pbl.SqlDate.Year;
                Process.SqlComandText = $@"select Processtamp,Descricao=Descricao+ ' '+ ltrim(rtrim(convert(char,codigo)))+'/'+ltrim(rtrim(convert(char,ano)))+' - '+ Mes from proces 
                where ano ={dmzDdN1.ano.Value}";
            }
            if (!_rlt.NaoMostraM)
            {
                Moeda.Visible = true;
                PanelFiltro.Controls.Add(Moeda);
                Moeda.tb1.Text=Pbl.MoedaBase;
            }
            #region Bloco de controls da academia......
            if (_rlt.Mostracurso)//Mostra curso 
            {
                tbCurso.Visible = _rlt.Mostracurso;
                PanelFiltro.Controls.Add(tbCurso);
            }
            if (_rlt.Mostraturma)//Mostra Turma 
            {
                tbTurma.Visible = _rlt.Mostraturma;
                PanelFiltro.Controls.Add(tbTurma);
            }
            if (_rlt.Mostraplanocur)
            {
                tbPlano.Visible = _rlt.Mostraplanocur;
                PanelFiltro.Controls.Add(tbPlano);
            }
            if (_rlt.Mostraetapasem)
            {
                tbEtapa.Visible = _rlt.Mostraetapasem;
                PanelFiltro.Controls.Add(tbEtapa);
            }
            if (_rlt.Mostradisciplina)
            {
                tbDisciplina.Visible = _rlt.Mostradisciplina;
                PanelFiltro.Controls.Add(tbDisciplina);
            }
            if (_rlt.Mostraprof) 
            {
                tbProf.Visible = _rlt.Mostraprof;
                PanelFiltro.Controls.Add(tbProf);
            }
            if (_rlt.Mostraanosem)
            {
                tbAnosem.Visible = _rlt.Mostraanosem;
                PanelFiltro.Controls.Add(tbAnosem);
            }
            #endregion
            switch (_rlt.Tipofilter)
            {
                case 1:
                    if (!_rlt.DescFiltroData.IsNullOrEmpty())
                    {
                        dmzData1.Label3Text = _rlt.DescFiltroData;
                    }
                    dmzData1.dt1.Value= Pbl.SqlDate;
                    PanelFiltro.Controls.Add(dmzData1);
                    break;
                case 2:
                    if (!_rlt.DescFiltroEntreDatas.IsNullOrEmpty())
                    {
                        dmzEntreDatas1.LabelText = _rlt.DescFiltroEntreDatas;
                    }
                    dmzEntreDatas1.dt1.Value = Pbl.SqlDate;
                    dmzEntreDatas1.dt2.Value = Pbl.SqlDate;
                    PanelFiltro.Controls.Add(dmzEntreDatas1);
                    break;
                case 3:
                    if (!_rlt.DescFiltroAno.IsNullOrEmpty())
                    {
                        dmzDdN1.Label3Text = _rlt.DescFiltroAno;
                    }
                    dmzDdN1.ano.Value = Pbl.SqlDate.Year;
                    PanelFiltro.Controls.Add(dmzDdN1);
                    break;
                case 4:
                    if (!_rlt.DescFiltroEntreDatas.IsNullOrEmpty())
                    {
                        dmzEntreDatas1.LabelText = _rlt.DescFiltroEntreDatas;
                    }
                    dmzEntreDatas1.dt1.Value = Pbl.SqlDate;
                    dmzEntreDatas1.dt2.Value = Pbl.SqlDate;
                    PanelFiltro.Controls.Add(dmzEntreDatas1);
                    dmzDdN1.ano.Value = Pbl.SqlDate.Year;
                    PanelFiltro.Controls.Add(dmzDdN1);
                    break;
                case 5:
                    if (!_rlt.DescFiltroEntreAnos.IsNullOrEmpty())
                    {
                        dmzEntreAnos1.Label3Text = _rlt.DescFiltroEntreAnos;
                    }
                    dmzEntreAnos1.numericUpDown1.Value = Pbl.SqlDate.Year-1;
                    dmzEntreAnos1.numericUpDown2.Value = Pbl.SqlDate.Year;
                    PanelFiltro.Controls.Add(dmzEntreAnos1);
                    break;
            }
        }

        private void ShowCliente(string tabela, string descricao)
        {
            tbCliente.Visible = true;
            tbCliente.SqlComandText=$"select {tabela}stamp,nome from {tabela}";
            tbCliente.label1.Text=descricao;
            tbCliente.tb1.Text = "";
            tbCliente.Text2 = "";
            PanelFiltro.Controls.Add(tbCliente);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Title = "Exportar para Excel";
            sfd.Filter = "Para Excel (Xlsx)|*.xlsx";
            sfd.FileName = "Mapa";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Helper.Export_DataGridView_To_Excel(gridUiMapa, sfd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Title = "Exportar para word";
            sfd.Filter = "Para Microsoft word (doc)|*.doc";
            sfd.FileName = "Mapa";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WriteDocumento(WdSaveFormat.wdFormatRTF, sfd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Title = "Exportar para pdf";
            sfd.Filter = "Para pdf (pdf)|*.pdf";
            sfd.FileName = "Mapa";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WriteDocumento(WdSaveFormat.wdFormatPDF, sfd.FileName);
            }            
        }
        private void WriteDocumento(WdSaveFormat wdSave, string fileName)
        {
            if (_rlt!=null)
            {
                //Table start.

                //html = $"<img src={"E:\\Photo\\m1.jpg"}  width={"50"} height={"60"}";
                //Image image = Util.ByteToImage(Pbl.Empresa.Logo);

                //var spathfile = System.Windows.Forms.Application.StartupPath + "\\Logo";
                //try
                //{
                //    if (!Directory.Exists(spathfile))
                //    {
                //        Directory.CreateDirectory(spathfile);
                //    }
                //    spathfile = spathfile + $"\\logoempresa.jpg";
                //    //File.WriteAllBytes(spathfile, anexo);
                //    image.Save($"{spathfile}", ImageFormat.Jpeg);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString());
                //}
                // 
                string html = "";
                html = $"<h2 style='font-family:Century Gothic'>{Pbl.Empresa.Nome.ToUpper()}</h2>";
                //html = $"<img src={"E:\\Projectos\\DMZ NET6\\DMZ.UI\\bin\\Debug\\logoempresa.jpg"}  width={"70"} height={"60"}";
                html += $"<hr>";
                html += $"<h4 style='font-family:Century Gothic'>{_rlt.Descricao.ToUpper()}</h4>";
                html += "<table cellpadding='5' cellspacing='0' style='border: 0.5px solid #ccc;font-size: 9pt;font-family:arial'>";
                html += "<tr>";
                foreach (DataGridViewColumn column in gridUiMapa.Columns)
                {
                    html += "<th style='background-color: #B8DBFD;border: 0.5px solid #ccc'>" + column.HeaderText + "</th>";
                }
                html += "</tr>";
                //Adding DataRow.
                foreach (DataGridViewRow row in gridUiMapa.Rows)
                {
                    html += "<tr>";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        html += $"<td style='width:{cell.OwningColumn.Width}px;border: 0.5px solid #ccc'>" + cell.Value + "</td>";
                    }
                    html += "</tr>";
                }

                //Table end.
                html += "</table>";

                html += $@"<footer style='font-size: 7pt;font-family:Century Gothic'><p> <hr>{Pbl.Info}<p> </footer > ";
                var extension = wdSave == WdSaveFormat.wdFormatPDF ? "pdf" : "docx";
                var htmlFilePath = System.Windows.Forms.Application.StartupPath + "\\DataGridView2.htm";// @"E:\DataGridView2.htm";
                File.WriteAllText(htmlFilePath, html);
                var word = new Application();//
                                             // Paragraph   
                                             //word.pa
                _Document wordDoc = word.Documents.Open(FileName: htmlFilePath, ReadOnly: false);
                // wordDoc.SaveAs(FileName: $@"E:\DataGridView.{extension}", FileFormat: wdSave);
                wordDoc.SaveAs(FileName: fileName, FileFormat: wdSave);
                wordDoc.Close();
                word.Quit();
                File.Delete(htmlFilePath); 
            }
        }

        private void gridUi1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoPrin(string tabela, string reportname, string xml = "")
        {
            _dt=gridUi1.GetBindedTable();

            DS ds = new DS();
            var ret = Imprimir.FillData(null, DtDados, null, ds.DMZ, null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, "", false, label1.Text, "", reportname, "RLT", this, xml, true, ds, Filtrado, CTituloRelatorio);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DoPrin("DMZ", "","xml");
        }

        private void PanelFiltro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecebeDados(DataRow dr, bool fim)
        {
            if (dr != null)
            {
                var ftl = _factldt.NewRow().Inicialize();// Helper.DoAddline<Factl>();
                try
                {
                    if (!SQL.CheckExist($@"select Factstamp from factl where Factstamp='{dr["Factstamp"].ToString().ToTrim()}' "))
                    {
                        ftl["Factstamp"] = dr["Factstamp"].ToString();
                        var quer1 = $@"select top 1 Descricao from St inner join 
StPrecos on st.Ststamp=StPrecos.Ststamp where
Codfam='{dr["corredorstamp"]}' and Codsubfam='{dr["sentidostamp"]}'
and stprecos.preco={dr["total"]}";
                        var firt = SQL.GetFirstRow(quer1);
                        if (firt != null)
                        {
                            ftl["Descricao"] = firt["Descricao"].ToString();
                            // ftl.Ref = firt["Referenc"].ToString();
                        }
                        else
                        {
                            quer1 = $@"select top 1 Descricao from St inner join 
StPrecos on st.Ststamp=StPrecos.Ststamp where
Codfam='{dr["corredorstamp"]}'  and Codsubfam='{dr["sentidostamp"]}'";
                            var r2 = SQL.GetFirstRow(quer1);
                            ftl["Descricao"]  = r2["Descricao"].ToString();

                        }
                        ftl["Preco"] = dr["Total"].ToDecimal();
                        ftl["Quant"] = 1;
                        ftl["Servico"] = true;
                        GenBl.TotaisLinhas(ftl, true);
                        _factldt.Rows.Add(ftl);

                        //var ret = EF.Save(ftl).ret;
                        
                    }
                    if (fim)
                    {
                        SQL.Save(_factldt, "factl", true, "", "");
                    }
                }
                catch (Exception ex)
                {
                    //
                }
                if (fim)
                {
                    MsBox.Show($@"{Messagem.ParteInicial()} Dados actualizado com sucesso!");
                }
            }
        }
        public decimal? Price { get; set; }
        public string Stamp { get; set; } = "";


        DataTable _factldt;
        private void button2_Click(object sender, EventArgs e)
        {
            Stamp = "";
            var quer = $@"select Factstamp,total,
pjstamp as sentidostamp,campo1 as corredorstamp  from fact
where Factstamp not in(select Factstamp from factl)
and Total>0";
            var _dt = SQL.GetGenDT(quer);
            if (_dt.HasRows())
            {
                _factldt=SQL.Initialize("factl");
                Helper.DoProgressProcess(_dt, RecebeDados);
               
//                var qur = $@"select Factstamp,COUNT(Factstamp) Total from (
//select  fact.total,Usrstamp,Data,fact.Factstamp  from fact inner join factl on fact.factstamp=factl.Factstamp  
// )tmp1 --where factstamp in ({Stamp})
//GROUP BY Factstamp
//HAVING COUNT(Factstamp) > 1";
//                var dta = SQL.GetGenDT(qur).DtToList<FactView>();
//                var qu = "";
//                foreach (var ite in dta)
//                {
//                    var top = ite.Total - 1;
//                    qur = $@"select top {top} Factlstamp from factl where Factstamp='{ite.Factstamp}'";
//                    qu += $"\r\ndelete factl where Factlstamp in({qur})";
//                    //SQL.SqlCmd($"delete factl where Factlstamp in({qur})");
//                }
//                if (!string.IsNullOrEmpty(qu))
//                {
//                    SQL.SqlCmd(qu);
//                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Não existem diferenças entre as vendas!");
            }
        }

       
    }

    public class FactView
    {
        public string Factstamp { get; set; }
        public string Usrstamp { get; set; }
        public decimal Total { get; set; }
    }
}
