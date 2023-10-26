using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmReg2 : Basic.FrmClasse2
    {
        public FrmReg2()
        {
            InitializeComponent();
        }

        public DataTable Tabela { get; set; }
        public DataTable SelTable { get; set; }
        public delegate void PassParam(DataTable tabela);

        public PassParam SendData;


        public delegate void PassParams(string descr);
        public PassParams Totaissss;
        public bool OrigemDoc { get; set; }
        public int Origemsssss { get; set; }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            if (Tabela == null) return;
            var dt = Tabela.GetTable("ok= 1");
            if (dt.HasRows())
            {
                SendData(dt);
                if (Origemsssss == 1)
                {
                    Totaissss(tbValorReg.Text);
                }
                SelTable.Dispose();
                Close();
            }
            else
            {
                MsBox.Show($"{Messagem.ParteInicial()} nenhuma linha seleccionada!");
            }

        }

        private void gridUi1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridUi1.CurrentRow;
            if (row == null) return;
            if (row.Cells["Documento"].Value.ToString().Contains("Ttl CC")|| row.Cells["Documento"].Value.ToString().ToLower().Contains("Total Geral".ToLower())
                || row.Cells["Documento"].Value.ToString().ToLower().Contains("Ttl CC Cl".ToLower()) || row.Cells["Documento"].Value.ToString().ToLower().Contains("Ttl CC Fnc".ToLower()))
            {
                MsBox.Show($"{Messagem.ParteInicial()} Está a editar numa linha errada!\n\rNão use linha de totais para regulari{tbMoeda.tb1.Text}.");
                return;
            }
            var nome = gridUi1.CurrentCell.OwningColumn.Name;
            if (nome.Equals("OK"))
            {
                UpdateValues();
            }
        }

        private void UpdateValues()
        {
            var nome = gridUi1.CurrentCell.OwningColumn.Name;
            if (nome.Equals("OK"))
            {
                gridUi1.CurrentCell.Value = !(gridUi1.CurrentCell.Value is DBNull) && !Convert.ToBoolean(gridUi1.CurrentCell.Value);//aqui seta o true ou false quando clica manualmente 
                gridUi1.Update();
                if (gridUi1.CurrentCell.Value.ToInt()==1)
                {
                    if (gridUi1.CurrentRow == null) return;
                    SelTable.Rows.Add(gridUi1.CurrentRow.Cells["ValRegularizado"].Value.ToDecimal(), gridUi1.CurrentRow.Index);//
                    Somatorio(SelTable);
                }
                else
                {
                    if (gridUi1.CurrentRow == null) return;
                    var dr = SelTable.Rows.Find($"{gridUi1.CurrentRow.Index}");
                    if (dr == null) return;
                    SelTable.Rows.Remove(dr);
                    Somatorio(SelTable);
                }
            }
            else if (nome.Equals("ValRegularizado"))
            {
                gridUi1.Update();
                if (gridUi1.CurrentRow.Cells["OK"].Value.ToDecimal() == 1)
                {
                    var dr = SelTable.Rows.Find($"{gridUi1.CurrentRow.Index}");
                    if (dr == null) return;

                    dr["Valor"] = gridUi1.CurrentRow.Cells["ValRegularizado"].Value.ToDecimal();

                    Somatorio(SelTable);
                }
                else
                {
                    var dr = SelTable.Rows.Find($"{gridUi1.CurrentRow.Index}");
                    if (dr == null)
                    {
                        SelTable.Rows.Add(gridUi1.CurrentRow.Cells["ValRegularizado"].Value.ToDecimal(), gridUi1.CurrentRow.Index);//
                        gridUi1.CurrentRow.Cells["OK"].Value = true;
                        gridUi1.Refresh();
                        Somatorio(SelTable);
                    }

                }
            }
            decimal dif = 0;
            var dd=Tabela.Clone();
            foreach (DataRow dr in Tabela.Rows)
            {
                var sss = dr["origem"].ToString().TrimStart().TrimEnd();
                if (sss.Equals("PGFA")|| sss.Equals("RCA") || sss.Equals("NC") || sss.Equals("NCF"))
                {
                    if (dr["valorreg"].ToDecimal()>0)
                    {
                        dr["valorreg"] = -1* dr["valorreg"].ToDecimal();
                    }
                }
                if (string.IsNullOrEmpty(dr["ok"].ToString()))
                {
                    dr["ok"] = 0;
                }
                if (Convert.ToBoolean(dr["ok"]))
                {
                    DataRow dataRow = dd.NewRow();
                    foreach (DataColumn col in Tabela.Columns)
                    {
                        dataRow[col.ColumnName]=dr[col.ColumnName];
                    }
                    dd.Rows.Add(dataRow);
                }
            }
            var dst = dd;
            if (Origemsssss != 0)
            {
            if (dst.HasRows())
            {
                var dt = dst;
                var cli = dt.Select("tipo=1");
                decimal ccl = 0;

                decimal fncl = 0;
                if (cli.Length > 0)
                {
                    var ss = cli.CopyToDataTable(); 
                    dif += cli.CopyToDataTable().Compute("sum(valorreg)", string.Empty).ToDecimal();
                    ccl = cli.CopyToDataTable().Compute("sum(valorreg)", string.Empty).ToDecimal();
                }
                var forne = dt.Select("tipo=2");
                if (forne.Length > 0)
                {
                    dif -= forne.CopyToDataTable().Compute("sum(valorreg)", string.Empty).ToDecimal();
                    fncl = forne.CopyToDataTable().Compute("sum(valorreg)", string.Empty).ToDecimal();
                }
                else
                {
                    tbContador.Text = "0";
                    tbValorReg.Text = "0";
                }
                tbContador.Text = (dt.Rows.Count).ToString();
                if (fncl > 0 && ccl > 0)
                {
                    if (dif <= 0)
                    {
                        tbValorReg.Text = $@"Total à pagar ao fornecedor {-dif:N2}";
                    }
                    else if (dif > 0)
                    {
                        tbValorReg.Text = $@"Total à receber do cliente {dif:N2}";
                    }
                }
                if (fncl > 0 && ccl == 0)
                {
                    
                    tbValorReg.Text = $@"Total à pagar ao fornecedor {fncl:N2}";
                }
                if (fncl > 0 && ccl < 0)
                {
                    var totr = fncl + ccl;
                    tbValorReg.Text = $@"Total à pagar ao fornecedor {totr:N2}";
                }
                    if (fncl == 0 && ccl > 0)
                {
                    tbValorReg.Text = $@"Total à receber do cliente {ccl:N2}";
                }
                    if (fncl < 0 && ccl > 0)
                    {
                        var totr = ccl+fncl ;
                        tbValorReg.Text = $@"Total à receber do cliente {totr:N2}";
                    }
                    if (fncl <= 0 && ccl < 0)
                {
                    tbValorReg.Text = $@"Total à pagar ao fornecedor {-ccl:N2}";
                }
                if (fncl < 0 && ccl <= 0)
                {
                    if (ccl==0)
                    {
                        tbValorReg.Text = $@"Total à pagar ao fornecedor {fncl:N2}";
                    }
                    else
                    {
                        tbValorReg.Text = $@"Total à pagar ao fornecedor {-fncl:N2}";
                    }
                }

                if (fncl < 0 && ccl < 0)
                {
                        var totl1 = ccl > fncl ? ccl+fncl * -1 : fncl + ccl * -1;
                       var dfg = totl1 < 0 ? totl1 * -1 : totl1;
                       if (ccl== fncl)
                       {
                           tbValorReg.Text = $@"Total à pagar: {dfg:N2}";
                        }
                       else
                       {
                           tbValorReg.Text = ccl < fncl ? $@"Total à receber do cliente {dfg:N2}" : $@"Total à pagar ao fornecedor {dfg:N2}";
                       }
                }
                if (fncl == 0 && ccl == 0)
                {
                    tbValorReg.Text = $@"Total à pagar: {fncl:N2}";
                }
                }
            }
        }

        private void Somatorio(DataTable selTable)
        {
            if (selTable?.Rows.Count > 0)
            {
                tbContador.Text = selTable.Rows.Count.ToString();
                var valor = selTable.Sum("valor");
                tbValorReg.Text = valor.ToString();
            }
            else
            {
                tbContador.Text = "0";
                tbValorReg.Text = "0";
            }
        }

        private void gridUi1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi1.CurrentRow == null) return;
            var nome = gridUi1.CurrentCell.OwningColumn.Name;
            if (nome.Equals("ValRegularizado"))
            {
                if (gridUi1.CurrentRow.Cells["Origem"].Value.ToString().Trim() == "NC"||
                    gridUi1.CurrentRow.Cells["Origem"].Value.ToString().Trim() == "NCF" || gridUi1.CurrentRow.Cells["Rcladiant"].Value.ToBool())
                {
                    if (gridUi1.CurrentCell.Value.ToDecimal() > 0)
                    {
                        gridUi1.CurrentCell.Value = gridUi1.CurrentCell.Value.ToDecimal() * -1;
                    }
                }
                gridUi1.Update();
                UpdateValues();
            }
        }

        void Metodo()
        {
            foreach (var r in Tabela.AsEnumerable())
            {
                r["valorpreg"] = r["valorpreg"].ToDecimal();
                r["valorreg"] = r["valorreg"].ToDecimal();
                r["valordoc"] = r["valordoc"].ToDecimal();
                if (string.IsNullOrEmpty(r["nrdoc"].ToString()))
                {
                    r["nrdoc"] = r["nrdoc"].ToDecimal();
                }
                if (Tabela.Columns.Contains("deb"))
                {
                    if (string.IsNullOrEmpty(r["deb"].ToString()))
                    {
                        r["deb"] = r["deb"].ToDecimal();
                    }
                }
                if (Tabela.Columns.Contains("cre"))
                {
                    if (string.IsNullOrEmpty(r["cre"].ToString()))
                    {
                        r["cre"] = r["cre"].ToDecimal();
                    }
                }
            }
            gridUi1.SetDataSource(Tabela);
            SelTable = new DataTable();
            SelTable.Columns.Add(new DataColumn("Valor", typeof(decimal)));
            SelTable.Columns.Add(new DataColumn("Rindex", typeof(int)));
            SelTable.PrimaryKey = new[] { SelTable.Columns["Rindex"] };
            tbTotalDocums.Text = Tabela.Sum("valorpreg").ToString();
            tbTotalDocums.Text = $"{tbTotalDocums.Text:N2}";
            SetVisivel();
            if (Origemsssss == 2)
            {
                tbTotalDocums.Visible = tbValorIntrod.Visible = tipo.Visible = deb.Visible = cre.Visible = tipo.Visible = false;
                btnAceitar.Visible = Moeda.Visible = false;
            }
        }
        private void FrmReg2_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in gridUi1.Columns)
            {
                var ca = col.Name.ToLower();
                var regusss = "ValRegularizado".ToLower();
                if (!ca.Equals(regusss) && !col.Name.ToLower().Equals("ok"))
                {
                    col.ReadOnly=true;
                }
            }
            if (Origemsssss == 2)
            {
                tbTotalDocums.Visible = tbValorIntrod.Visible = tipo.Visible = deb.Visible = cre.Visible = tipo.Visible = false;
                btnAceitar.Visible = Moeda.Visible = false;
            }
            else
            {
                Metodo();
                if (Origemsssss == 1)
                {
                    deb.Visible = cre.Visible = tipo.Visible = true;
                    tbTotalDocums.Visible= tbValorIntrod.Visible= Moeda.Visible = tipo.Visible = false;
                }
                if (Origemsssss != 1)
                {
                    tipo.Visible = deb.Visible = cre.Visible = tipo.Visible = false;
                    Moeda.Visible = false;
                }
            }
            OK.Visible= true;
            tbClienteForn.SqlComandText = $"select distinct 1 no,* from (select nome,Fncstamp from fnc union all select nome,clstamp from cl)temp";
        }
        private void SetVisivel()
        {
            tbContador.Visible = OrigemDoc;
            tbTotalDocums.Visible = OrigemDoc;
            tbValorReg.Visible = OrigemDoc;
            btnAceitar.Visible = OrigemDoc;
            tbValorIntrod.Visible = OrigemDoc;
            if (gridUi1 == null) return;
            gridUi1.Columns["ValRegularizado"].Visible = OrigemDoc;
            gridUi1.Columns["OK"].Visible = OrigemDoc; 
            if (Origemsssss == 2)
            {
                btnAceitar.Visible = false;
            }
        }

        private void gridUi1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridUi1==null)return;
            var cell = gridUi1[gridUi1.Columns["tipo"].Index, e.RowIndex];
            if (cell == null) return;
            if (cell.Value == null) return;
            if (cell.Value.ToString().Equals("0"))
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.Crimson;
            }
        }

        private DataTable _dt;
        private FrmReport _f;
        private void Options()
        {
            if (Tabela == null) return;
            var dst = Tabela.GetTable("ok= 1");
            decimal dif = 0;
            if (dst.HasRows())
            {
                var dts = dst;
                if (!dts.Columns.Contains("valordife"))
                {
                    dts.Columns.Add("totaldescricao", typeof(string));
                    dts.Columns.Add("valordife", typeof(string));
                    var cli = dts.GetTable("tipo=1");
                    if (cli.HasRows())
                    {
                        dif += cli.Sum("valorreg").ToDecimal();
                    }
                    var forne = dts.GetTable("tipo=2");
                    //var forne = dts.Select("tipo=2");
                    if (forne.HasRows())
                    {
                        dif -= forne.Sum("valorreg").ToDecimal(); ;
                    }
                    foreach (DataRow r in dts.Rows)
                    {
                        if (dif<0)
                        {
                            r["totaldescricao"] = $@"Total à pagar ao fornecedor ";
                            r["valordife"] = -dif;
                        }
                        else
                        {
                            r["totaldescricao"] = "Total à receber do cliente ";
                            r["valordife"] = dif;
                        }
                    }
                }
                DS ds = new DS();
                 var ret = Imprimir.FillData(null, dts, null, ds.DMZ, null);
                if (dif < 0)
                {
                    dif = -dif;
                }
                var lista = new List<ReportParameter> { new ReportParameter("valorareceber", dif.ToString("N2")) };                
                var xmlrdlc = SQL.GetXmlReport("RptEnctrCntas");
                var filtro = $"Centro de Custo: {Ccusto.tb1.Text}\r\nMoeda: {tbMoeda.tb1.Text}\r\nFornecedor: {tbClienteForn.tb1.Text}";
                Imprimir.CallForm(ret.dtPrint, null, CLocalStamp, false, label1.Text, "", "RptEnctrCntas", "RLTEnctroContas", this,xmlrdlc, true, ds, filtro, "Encontro de contas", lista);
            }
            else
            {
                MsBox.Show($"{Messagem.ParteInicial()} não seleccionaste nenhuma linha!");
            }
        }
        private void Selecting(string condicao = "")
        {
            if (string.IsNullOrEmpty(tbClienteForn.tb1.Text)|| string.IsNullOrEmpty(tbMoeda.tb1.Text)|| string.IsNullOrEmpty(Ccusto.tb1.Text))
            {
                MsBox.Show($"{Messagem.ParteInicial()} preencha todos os parâmentros!");
                return;
            }

            //var qry = $"select* from(select*, novacolun= '', tipo= 1, deb= valorpreg, cre= 0 from clccf() where clstamp= {tbClienteForn.Text3} " +
            //          $" union all select upper('Ttl CC Cl'),'','',sum(valordoc),sum(valorpreg),sum(valorreg),0,'','','','{tbMoeda.tb1.Text}',0,'','',0,'','',''," +
            //          $"'','',tipo = 0,sum(valorpreg),cre = 0 from clccf() where clstamp = {tbClienteForn.Text3} union all select *,'',tipo = 2,deb = 0,cre = valorpreg" +
            //          $" from fncccf() where fncstamp = {tbClienteForn.Text3} union all select upper('Ttl CC Fnc'),'',''," +
            //          $"sum(valordoc),sum(valorpreg),sum(valorreg),0,'','','','{tbMoeda.tb1.Text}',0,'','',0,'','','','','',tipo = 0,deb = 0,cre = sum(valorpreg)" +
            //          $" from fncccf() where fncstamp = {tbClienteForn.Text3} union all select upper('Total Geral'),'','',ss = ((select - (sum(valordoc)) from fncccf()" +
            //          $" where fncstamp = {tbClienteForn.Text3} )+(select sum(valordoc) from clccf() where clstamp = {tbClienteForn.Text3} )),sum(0),sum(0),0,'','',''," +
            //          $" '{tbMoeda.tb1.Text}',0,'','',0,'','','','','',tipo = 0,deb = 0,cre = 0 )temp where moeda = '{tbMoeda.tb1.Text}'; ";


            var qry = $@"
select *
from(select descricao,nrdoc,data,valordoc,valorpreg,valorreg,ok,ccstamp,origem,oristamp,Moeda,Cambiousd,no,nome,Dias,ccusto,Clstamp,vencim,Rcladiant,
Entidadebanc,Referencia, novacolun= '', tipo= 1, deb= valorpreg, cre= 0 from clccf() 
where clstamp= '{tbClienteForn.Text3}' and Moeda= '{tbMoeda.tb1.Text}'  union all 
select upper('Ttl CC Cl') descricao,'' nrdoc,'' data,
sum(valordoc)valordoc,sum(valorpreg) valorpreg,sum(valorreg)valorreg,0 ok,''ccstamp,''origem,''oristamp,'{tbMoeda.tb1.Text}'Moeda,0 Cambiousd,''no,''nome,0 Dias,
'' Ccusto,''Clstamp,''Vencim,0 Rcladiant,''EntidadeBanc,''Referebcia,''novacolum,tipo = 0,sum(valorpreg),
cre = 0 from clccf() where clstamp = '{tbClienteForn.Text3}' and Moeda= '{tbMoeda.tb1.Text}'
union all
select *,'',tipo = 2,deb = 0,cre = valorpreg from fncccf()
where fncstamp = '{tbClienteForn.Text3}' and Moeda= '{tbMoeda.tb1.Text}'
union all
select upper('Ttl CC Fnc')descricao,'' nrdoc,'' data,
sum(valordoc)valordoc,sum(valorpreg) valorpreg,sum(valorreg)valorreg,0 ok,''ccstamp,''origem,''oristamp,'{tbMoeda.tb1.Text}'Moeda,0 Cambiousd,''no,''nome,0 Dias,
'' Ccusto,''Clstamp,''Vencim,0 Rcladiant,''EntidadeBanc,''Referebcia,''novacolum,tipo = 0,deb = 0,
cre = sum(valorpreg) from fncccf() where fncstamp = '{tbClienteForn.Text3}' and Moeda= '{tbMoeda.tb1.Text}'

union all select upper('Total Geral')descricao,''nrdoc,''data,ss = ((select - (sum(valordoc)) from fncccf() where 
fncstamp = '{tbClienteForn.Text3}' and Moeda= '{tbMoeda.tb1.Text}' )+(select sum(valordoc) from clccf() where clstamp = '{tbClienteForn.Text3}' and Moeda= '{tbMoeda.tb1.Text}')),
sum(0),sum(0),0,'','','', '{tbMoeda.tb1.Text}',0 Cambiousd,''no,''nome,0 Dias,
'' Ccusto,''Clstamp,''Vencim,0 Rcladiant,''EntidadeBanc,''Referebcia,''novacolum,tipo = 0,deb = 0,cre = 0 )temp where moeda = '{tbMoeda.tb1.Text}'; ";
            var dtt = SQL.GetGen2DT(qry);
            if (dtt.HasRows())
            {
                _dt = dtt;
                Tabela = _dt;
                OrigemDoc = true;
                Metodo();
                gridUi1.Columns["OK"].Visible = true;
            }
            else
            {
                MsBox.Show($"{Messagem.ParteInicial()} não temos nada para imprimir!");
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_dt.HasRows())
            {
                Options();
            }
        }
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            Selecting();
        }

        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Origemsssss!=2)
            {
                var row = gridUi1.CurrentRow;
                if (row == null) return;
                if (row.Cells["Documento"].Value.ToString().Contains("Ttl CC"))
                {
                    MsBox.Show($"{Messagem.ParteInicial()} Está a editar numa linha errada!\n\rNão use linha de totais para regulari{tbMoeda.tb1.Text}.");
                }
            }
        }

       
    }
}
