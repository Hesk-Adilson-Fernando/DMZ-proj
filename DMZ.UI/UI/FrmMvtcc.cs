using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmMvtcc : FrmClasse2
    {
        public FrmMvtcc()
        {
            InitializeComponent();
        }
        //public decimal Codlocal { get; set; }
        public string Contasstamp { get; set; }
        private DataTable _dt;
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (dr != null)
            {
                var dData1 = dtpData1.Value;
                var dData2 = dtpData2.Value;
                _dt = SQL.GetGen2DT("Select Titulo,numtitulo,Banco,data='',Documento,nrdoc,entrada,saida,localstamp='', Cast(0 as decimal) saldo,descricao,origem,ordem=0 from mvt where 1=0");
                if (cbTodas.cb1.Checked)
                {
                    int i;
                    foreach (var rows in DtContas.AsEnumerable())
                    {
                        if (rows == null) continue;
                        Contasstamp = rows["Contasstamp"].ToString();
                        BuilQuerry(dData1, dData2, cbSaldoanterior.cb1.Checked, dr["Querry"].ToString());
                        var mov = SQL.GetGen2DT(BuilQuerry(dData1, dData2, cbSaldoanterior.cb1.Checked, dr["Querry"].ToString()));
                        if (!mov.HasRows()) continue;
                        i = 0;
                        var dr3 = _dt.NewRow();
                        decimal entrada, saida;
                        foreach (var dr in mov.AsEnumerable())
                        {
                            if (dr == null) continue;
                            if (i == 0)
                            {
                                dr3["titulo"] = rows["nome"];
                                dr3["numtitulo"] = "";
                                dr3["Banco"] = "";
                                dr3["data"] = "";
                                dr3["Documento"] = "";
                                dr3["nrdoc"] = 0;
                                dr3["entrada"] = 0;
                                dr3["saida"] = 0;
                                dr3["saldo"] = 0;
                                dr3["descricao"] = "";
                                dr3["origem"] = "";
                                dr3["ordem"] = "-4";
                                _dt.Rows.Add(dr3);
                            }
                            else
                            {
                                var dr2 = _dt.NewRow();
                                dr2["titulo"] = dr["titulo"];
                                dr2["numtitulo"] = dr["numtitulo"];
                                dr2["Banco"] = dr["Banco"];
                                dr2["data"] = dr["data"];
                                dr2["Documento"] = dr["Documento"];
                                dr2["nrdoc"] = dr["nrdoc"];
                                dr2["entrada"] = dr["entrada"];
                                dr2["saida"] = dr["saida"];
                                dr2["saldo"] = dr["saldo"];
                                dr2["descricao"] = dr["descricao"];
                                dr2["origem"] = dr["origem"];
                                dr2["ordem"] = dr["ordem"];
                                _dt.Rows.Add(dr2);
                            }
                            i++;
                        }
                        entrada = mov.Select().Where(x => x.Field<string>("titulo").Trim() != "Total").Sum(x => x.Field<decimal>("entrada"));
                        saida = mov.Select().Where(x => x.Field<string>("titulo").Trim() != "Total").Sum(x => x.Field<decimal>("saida"));
                        dr3["entrada"] = entrada;
                        dr3["saida"] = saida;
                        dr3["saldo"] = entrada - saida;
                    }
                }
                else
                {
                    Contasstamp = cbConta.SelectedValue.ToString();
                    var mov = SQL.GetGen2DT(BuilQuerry(dData1, dData2, cbSaldoanterior.cb1.Checked, dr["Querry"].ToString() ));
                    if (!(mov?.Rows.Count > 0)) return;
                    foreach (var dr in mov.AsEnumerable())
                    {
                        if (dr == null) continue;
                        var dr2 = _dt.NewRow();
                        dr2["titulo"] = dr["titulo"];
                        dr2["numtitulo"] = dr["numtitulo"];
                        dr2["Banco"] = dr["Banco"];
                        dr2["data"] = dr["data"];
                        dr2["Documento"] = dr["Documento"];
                        dr2["nrdoc"] = dr["nrdoc"];
                        dr2["entrada"] = dr["entrada"];
                        dr2["saida"] = dr["saida"];
                        dr2["saldo"] = dr["saldo"];
                        dr2["descricao"] = dr["descricao"];
                        dr2["origem"] = dr["origem"];
                        dr2["ordem"] = dr["ordem"];
                        dr2["localstamp"] = dr["localstamp"];
                        _dt.Rows.Add(dr2);
                    }
                }
                gridUi1.DataSource = null;
                gridUi1.AutoGenerateColumns = false;
                gridUi1.DataSource = _dt;
                foreach (DataGridViewRow row in gridUi1.Rows)
                {
                    if (row == null) continue;
                    if (row.Cells["Titulo"].Value.ToString().Trim().Equals("Total"))
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkGoldenrod;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    if (row.Cells["Titulo"].Value.ToString().Trim().Equals("-3"))
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkBlue;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    }
                    if (row.Cells["ordem"].Value.ToString().Trim().Equals("-4"))
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkCyan;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    }
                }
            }
        }

        private string BuilQuerry(DateTime dData1, DateTime dData2,bool saldoanter, string querry)
        {
            string qry;
            if (saldoanter)
            {
                qry = string.Format(querry, Contasstamp, dData1.ToSqlDate(), dData2.ToSqlDate(), ""); //$@"select * from ContasMovs('{Contasstamp}','{dData1.ToSqlDate()}','{dData2.ToSqlDate()}') order by ordem,data";  
            }
            else
            {
                qry = string.Format(querry, Contasstamp, dData1.ToSqlDate(), dData2.ToSqlDate(), "where ordem <>-3");
                //qry = $@"select * from ContasMovs('{Contasstamp}','{dData1.ToSqlDate()}','{dData2.ToSqlDate()}') where ordem <>-3 order by ordem,data";    
            }
            return qry;
        }
        //order by ordem,data1
        public DataTable DtContas;
        public string Moeda { get; set; }
        private void FrmMvtcc_Load(object sender, EventArgs e)
        {
            DtContas = SQL.GetGen2DT("select nome=sigla+' - '+Convert(char,Numero),Contasstamp from contas order by nome ");
            cbConta.DataSource = null;
            cbConta.DataSource = DtContas;
            cbConta.DisplayMember = "nome";
            cbConta.ValueMember = "Contasstamp";
            dtpData1.Value = Pbl.PrevMonthData();
            dr = SQL.GetRow("select Xmlstring,Querry from Rdlcxml where Rdlcname='RptExtConta'");
        }
        bool IsTheSameCellValue(int column, int row)
        {
            var cell1 =gridUi1[column, row];
            var cell2 = gridUi1[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }
        DataRow dr;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            if (dr != null)
            {
               // var qry = string.Format(dr["Querry"].ToString().Trim(), Proces.Processtamp);
                if (!dr["Xmlstring"].ToString().IsNullOrEmpty())
                {
                    //var f = new FrmReport
                    //{
                    //    Origem = "RLT",
                    //    Dt = _dt,
                    //    TabelaName = "DMZ",
                    //    ReportName = "",
                    //    RDLCXML = dr["Xmlstring"].ToString(),
                    //    Filtro = $"Conta: {cbConta.Text} \r\n Período: {dtpData1.Value.Date.ToShortDateString()} -{dtpData2.Value.Date.ToShortDateString()}",
                    //    CTituloRelatorio = "Extrato de Conta(s)".ToUpper()
                    //};
                    //f.ShowForm(this);

                    DS ds = new DS();
                    var ret = Imprimir.FillData(null, _dt, null, ds.DMZ, null);
                    Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "","" , "Caixa", this, dr["Xmlstring"].ToString(), false, ds, $"Conta: {cbConta.Text} \r\n Período: {dtpData1.Value.Date.ToShortDateString()} -{dtpData2.Value.Date.ToShortDateString()}", "Extrato de Conta(s)".ToUpper());
                    //Doform(qry, dr["DESCRICAO"].ToString().ToLower().Trim(), dr["Reportname"].ToString().Trim());
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + $"Software não encontrou nenhum ficheiro de Impressão ");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + $"Software não encontrou nenhum QUERY");
            }
        }

        private void gridUi1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            //if (e.RowIndex < 1 || e.ColumnIndex < 0)
            //    return;
            //if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            //}
            //else
            //{
            //    e.AdvancedBorderStyle.Top = gridUi1.AdvancedCellBorderStyle.Top;
            //} 
        }

        private void gridUi1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.RowIndex == 0)
            //    return;
            //if (!IsTheSameCellValue(e.ColumnIndex, e.RowIndex)) return;
            //e.Value = "";
            //e.FormattingApplied = true;
        }

        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!gridUi1.CurrentCell.OwningColumn.Name.Equals("Origem")) return;
            if (gridUi1.CurrentRow == null) return;
            var tabela = gridUi1.CurrentRow.Cells["Origem2"].Value.ToString();
            if (!string.IsNullOrEmpty(tabela))
            {
                List<Usracessos> listaUsracessos;
                switch (tabela.ToLower())
                {
                    case "fact":
                        listaUsracessos = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals("tdoc")).ToList();
                        Helper.CallForm("fact", "FrmFt", gridUi1, ParentForm, listaUsracessos);
                        break;
                    case "Pjdi":
                        listaUsracessos = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals("tdi")).ToList();
                        Helper.CallForm("di", "FrmPjdi", gridUi1, ParentForm, listaUsracessos);
                        break;
                    case "di":
                        listaUsracessos = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals("tdi")).ToList();
                        Helper.CallForm("di", "Frmdi", gridUi1, ParentForm, listaUsracessos);
                        break;
                    case "facc":
                        listaUsracessos = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals("tdocf")).ToList();
                        Helper.CallForm("facc", "FrmCp", gridUi1, ParentForm, listaUsracessos);
                        break;
                    case "rcl":
                        listaUsracessos = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals("trcl")).ToList();
                        Helper.CallForm("rcl", "FrmRcl", gridUi1, ParentForm, listaUsracessos);
                        break;
                    case "pgf":
                        listaUsracessos = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals("tpgf")).ToList();
                        Helper.CallForm("pgf", "FrmPgf", gridUi1, ParentForm, listaUsracessos);
                        break;
                }
            }
            else
            {
                MsBox.Show("Parametros não configurado!");
            }
        }
    }
}
