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

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmIntegradoc : FrmClasse2
    {
        public FrmIntegradoc()
        {
            InitializeComponent();
        }

        List<Mov> Lista;

        private void FrmIntegradoc_Load(object sender, EventArgs e)
        {
            var d = new DateTime(Pbl.SqlDate.Year, Pbl.SqlDate.Month==1?Pbl.SqlDate.Month:Pbl.SqlDate.Month - 1, Pbl.SqlDate.Day);
            data1.Value = d;
            //data1.Value.PrevMonth();
        }

        private void cbDefault2_Load(object sender, EventArgs e)
        {

        }

        private void TipoDoc_RefreshControls()
        {
            if (GridDocumentos == null) return;
            switch (Tabela)
            {
                case "Fact":
                    SetData("Facturação","Nome de cliente");
                    break;
                case "Rcl":
                    SetData("Recibos","Nome de cliente");
                    break;
                case "Facc":
                    SetData("Facturação","Nome de fornecedor");
                    break;
                case "Pgf":
                    SetData("Pagementos","Nome de fornecedor");
                    break;
            }

        }

        private void SetData(string empty, string s)
        {
            barraText1.label1.Text = $@"{empty}: {TipoDoc.tb1.Text.Trim()}";
            GridDocumentos.Columns["nome"].HeaderText = s;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            Processar();
        }

        private void Processar(bool origem=false)
        {
            if (!string.IsNullOrEmpty(TipoDoc.tb1.Text))
            {
                var qry = $@"select no,nome,Numero,Total,{Ocampos}{Tabela}stamp as localstamp,cast(0 as bit) as OK from 
                            {Tabela} where {Tabela}stamp  not in (select oristamp from Lcont) and convert(date,data)>'{data1.Value.ToSqlDate()}' and convert(date,data)<='{data2.Value.ToSqlDate()}' and numdoc={TipoDoc.Text2.ToInt32()} order by Convert(decimal,numero)";
                var dt = SQL.GetGen2DT(qry);
                if (origem)
                {
                    GridDocumentos.Invokex(x=>x.DataSource=null);
                    GridDocumentos.Invokex(x=>x.AutoGenerateColumns=false);
                    GridDocumentos.Invokex(x=>x.DataSource = dt);
                    if (dt?.Rows.Count > 0)
                    {
                        if (Tabela.ToLower().Equals("rcl") || Tabela.ToLower().Equals("pgf"))
                        {
                            GridDocumentos.Invokex(x=>x.Columns["Subtotal"].Visible = false);
                            GridDocumentos.Invokex(x=>x.Columns["Totaliva"].Visible = false);
                            GridDocumentos.Invokex(x=>x.Columns["desconto"].Visible = false);
                        }
                        barraText1.label1.Invokex(x=>x.Text = $"São {dt.Rows.Count.ToString()} {TipoDoc.tb1.Text.Trim()} encontradas!");
                    }
                    if (gridUi1?.Rows.Count > 0)
                    {
                        gridUi1.Invokex(x=>x.DataSource=null);
                    }
                }
                else
                {
                    GridDocumentos.DataSource = null;
                    GridDocumentos.AutoGenerateColumns = false;
                    GridDocumentos.DataSource = dt;
                    if (dt?.Rows.Count > 0)
                    {
                        if (Tabela.ToLower().Equals("rcl") || Tabela.ToLower().Equals("pgf"))
                        {
                            GridDocumentos.Columns["Subtotal"].Visible = false;
                            GridDocumentos.Columns["Totaliva"].Visible = false;
                            GridDocumentos.Columns["desconto"].Visible = false;
                        }
                        barraText1.label1.Text = $"São {dt.Rows.Count.ToString()} {TipoDoc.tb1.Text.Trim()} encontradas!";
                    }
                    if (gridUi1?.Rows.Count > 0)
                    {
                        gridUi1?.Rows.Clear();
                    }
                }

            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Deve indicar o tipo de documento!");
            }
        }

        public string Ocampos { get; set; }
        public string Tabela { get; set; }
        private void cbDefault1_CheckedChangeds()
        {
            GridDocumentos.CheckUncheckAll("Status",cbDefault1.cb1.Checked);
        }

        private void GridDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDocumentos.CurrentRow == null)return;
            if (GridDocumentos.CurrentCell.OwningColumn.Name.Equals("origem"))
            {
                switch (Tabela.ToLower())
                {
                    case "fact":
                            var (valido, lista) = Helper.GetUsrAcessosList("tdoc");
                            if (valido)
                            {
                                Helper.CallForm("fact", "FrmFt", GridDocumentos, this, lista);
                            }
                        break;
                    case "rcl":
                            var xx = Helper.GetUsrAcessosList("trcl");
                            if (xx.valido)
                            {
                                Helper.CallForm("Rcl", "FrmRcl", GridDocumentos, this, xx.lista);
                            }
                        break;
                    case "facc":
                            var x = Helper.GetUsrAcessosList("tdocf");
                            if (x.valido)
                            {
                                Helper.CallForm("facc", "FrmCp", GridDocumentos, this, x.lista);
                            }
                        break;
                    case "pgf":
                            var tpgf = Helper.GetUsrAcessosList("tpgf");
                            if (tpgf.valido)
                            {
                                Helper.CallForm("facc", "FrmCp", GridDocumentos, this, tpgf.lista);
                            }
                        break;
                }

            }
            if (GridDocumentos.CurrentCell.OwningColumn.Name.Equals("preview"))
            {
                if (GridDocumentos.CurrentRow == null) return;
                var stamp = GridDocumentos.CurrentRow.Cells["localstamp"].Value.ToString().Trim();
                switch (Tabela.ToLower())
                {
                    case "fact":
                        GeracontasFact(stamp,true);
                        break;
                    case "rcl":
                        GeracontasRcl(stamp,true);
                        break;
                    case "facc":
                        GeracontasFacc(stamp,true);
                        break;
                    case "pgf":
                        GeracontasPgf(stamp,true);
                        break;
                }
            }
        }

        private bool GeracontasPgf(string stamp, bool bindgrid =false)
        {
            var valido = IsValido(stamp,"pgf","tpgf");
            if (!valido.valido) return valido.valido;
            if (CriaMovClFnc(valido.rc, valido.tdoc,false))
            {
                if (CriaMovTzCl(valido.rc, valido.tdoc,false))
                {
                    if (bindgrid)
                    {
                        BindGridMov();
                    }
                }
                else
                {
                    valido.valido = false;  
                }
            }
            else
            {
                valido.valido = false;
            }
            return valido.valido;
        }

        private bool GeracontasFacc(string stamp, bool bindgrid = false)
        {
            var valido = IsValido(stamp,"facc","tdocf");
            if (!valido.valido) return valido.valido;
            var factl = SQL.GetGen2DT($"select * from faccl where faccstamp='{valido.rc["Faccstamp"].ToString().Trim()}'");
            if (valido.tdoc["Ft"].ToBool()|| valido.tdoc["Nd"].ToBool())
            {
                if (!CriaMovClFnc(valido.rc, valido.tdoc,false)) return false;
                if (factl.Rows.Count > 0)
                {
                    TupleValue2(factl, valido,false);
                    if (bindgrid)
                    {
                        BindGridMov();
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "O documento não tem linhas");
                    Lista = null;
                }
            }

            if (valido.tdoc["Vd"].ToBool())
            {
                if (factl.Rows.Count > 0)
                {
                    TupleValue2(factl, valido,false);
                    if (bindgrid)
                    {
                        BindGridMov();
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "O documento não tem linhas");
                    Lista = null;
                }
            }
            if (valido.tdoc["Nc"].ToBool())
            {
                if (valido.rc["movcc"].ToBool())
                {
                    if (!CriaMovClFnc(valido.rc, valido.tdoc,true)) return false;
                }

                if (factl.Rows.Count > 0)
                {
                    TupleValue2(factl, valido,true);
                    if (bindgrid)
                    {
                        BindGridMov();
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "O documento não tem linhas");
                    Lista = null;
                }
            }
            return valido.valido; 
        }

        private void TupleValue2(DataTable factl, (DataRow rc, DataRow tdoc, bool valido) valido,bool nc)
        {
            foreach (var row in factl.AsEnumerable())
            {
                if (row["tabiva"].ToDecimal() > 0)
                {
                    var cpoc = SQL.GetGen2DT($"select Tabiva,ValCompra as ValVenda,Iva,Codcpoc from cpoc join CpocCompra on Cpoc.Cpocstamp = CpocCompra.Cpocstamp where Codcpoc={row["cpoc"].ToDecimal()} and tabiva ={row["tabiva"].ToDecimal()}");
                    if (cpoc.HasRows())
                    {
                        if (Lista != null)
                        {
                            if (!Lista.Any(x => x.Conta.Trim().Equals(cpoc.Rows[0]["ValVenda"].ToString().Trim())))
                            {
                                CriaMovMercadoriaServico(row, valido.rc, valido.tdoc, cpoc,nc);
                            }
                            else
                            {
                                var xx = Lista.Where(x => x.Conta.Trim().Equals(cpoc.Rows[0]["ValVenda"].ToString().Trim())).FirstOrDefault();
                                xx.Credito = xx.Credito + row["subtotall"].ToDecimal();
                            }
                            if (!Lista.Any(x => x.Conta.Trim().Equals(cpoc.Rows[0]["Iva"].ToString().Trim())))
                            {
                                if (factl.TableName.Equals("faccl"))
                                {
                                    if (row["Gasoleo"].ToBool())
                                    {                                      
                                        CriaMovIva2(valido.rc, valido.tdoc, cpoc.Rows[0]["Iva"].ToString().Trim(),row["valival"].ToDecimal(),nc);
                                        var conta2 = SQL.GetValue("Contaiva85","param");
                                        CriaMovIva2(valido.rc, valido.tdoc, conta2.Trim(),row["valival"].ToDecimal(),nc);
                                    }
                                    else
                                    {
                                        CriaMovIva(valido.rc, valido.tdoc, cpoc.Rows[0]["Iva"].ToString().Trim(),row["valival"].ToDecimal(),nc);
                                    }                                
                                }
                                else
                                {
                                    CriaMovIva(valido.rc, valido.tdoc, cpoc.Rows[0]["Iva"].ToString().Trim(),row["valival"].ToDecimal(),nc);
                                }                               
                            }
                            else
                            {
                                var xx = Lista.Where(x => x.Conta.Trim().Equals(cpoc.Rows[0]["Iva"].ToString().Trim())).FirstOrDefault();
                                xx.Credito = xx.Credito + row["valival"].ToDecimal();
                            }
                        }
                        else
                        {
                            CriaMovMercadoriaServico(row, valido.rc, valido.tdoc, cpoc,nc);
                            CriaMovIva(valido.rc, valido.tdoc, cpoc.Rows[0]["Iva"].ToString().Trim(),
                                row["valival"].ToDecimal(),nc);
                        }

                        if (!nc)
                        {
                            if (!valido.tdoc["Movtz"].ToBool()) continue;
                            if (!CriaMovTzCl(valido.rc, valido.tdoc,nc)) break;
                        }
                        else
                        {
                            if (!valido.rc["Movtz"].ToBool()) continue;
                            if (!CriaMovTzCl(valido.rc, valido.tdoc,nc)) break;
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() +
                                   $"O artigo {row["descricao"]} não possui o código de integração definido. \r\n O Software não consegue integrar artigos sem codigo CPOC");
                        Lista = null;
                        break;
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + $"O artigo {row["descricao"]} não possui o tabela de IVA definida. \r\n O Software não consegue integrar artigos sem tabela configurada");
                    Lista = null;
                    break;
                }
            }
        }

        private (DataRow rc, DataRow tdoc, bool valido) IsValido(string stamp,string tabela,string tdoctab)
        {
            (DataRow rc, DataRow tdoc, bool valido) ret = (null, null, false);
            if (!string.IsNullOrEmpty(stamp))
            {
                Lista = new List<Mov>();
                var rc =SQL.GetRow(tabela,$"{tabela.Trim()}stamp='{stamp.Trim()}'") ;
                if (rc != null)
                {
                    var tdoc =SQL.GetRow(tdoctab,$"Numdoc={rc["Numdoc"].ToDecimal()}");
                    if (tdoc != null)
                    {
                        ret = (rc, tdoc, true);
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Não foi encontrado o tipo de documento!");
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "O documento a Integrar não existe!");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "O documento a Integrar não tem stamp válido");
            }

            return ret;
        }
        private bool GeracontasRcl(string stamp, bool bindgrid = false)
        {
            var valido = IsValido(stamp,"Rcl","Trcl");
            if (!valido.valido) return valido.valido;
            if (CriaMovClFnc(valido.rc, valido.tdoc,false))
            {
                if (CriaMovTzCl(valido.rc, valido.tdoc,false))
                {
                    if (bindgrid)
                    {
                        BindGridMov();
                    }
                }
                else
                {
                    valido.valido = false;  
                }
            }
            else
            {
                valido.valido = false;
            }
            return valido.valido;
        }
        private bool GeracontasFact(string stamp,bool bindgrid=false)
        {
            var valido = IsValido(stamp,"fact","tdoc");
            if (!valido.valido) return valido.valido;
            DateTime data;
            data =cbData.cb1.Checked?dataLanc.Value:valido.rc["data"].ToDateTimeValue();
            var str = $"SELECT dbo.func_GenNumber({valido.tdoc["NoDiario"].ToDecimal()},{data.Month},{data.Year})";
            NrLacamento = SQL.SQLExecScalar(str).ToString().ToDecimal();
            var factl = SQL.GetGen2DT($"select * from factl where factstamp='{valido.rc["Factstamp"].ToString().Trim()}'");
            if (valido.tdoc["Ft"].ToBool() || valido.tdoc["Nd"].ToBool())
            {
                CriaMovClFnc(valido.rc, valido.tdoc,false);
                if (factl.Rows.Count > 0)
                {
                    valido = ValueTuple(bindgrid, factl, valido,false);
                    if (bindgrid)
                    {
                        BindGridMov();
                    }
                    valido.valido = true;
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "O documento não tem linhas");
                    Lista = null;
                } 
            }
            if (valido.tdoc["Nc"].ToBool())
            {
                if (valido.rc["Movcc"].ToBool())
                {
                    if (!CriaMovClFnc(valido.rc, valido.tdoc,true)) return false;
                }
                if (factl.Rows.Count > 0)
                {
                    valido = ValueTuple(bindgrid, factl, valido,true);
                    if (bindgrid)
                    {
                        BindGridMov();
                    }
                    valido.valido = true;
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "O documento não tem linhas");
                    Lista = null;
                }  
            }
            if (valido.tdoc["Vd"].ToBool())
            {
                if (factl.Rows.Count > 0)
                {
                    valido = ValueTuple(bindgrid, factl, valido,false);
                    if (bindgrid)
                    {
                        BindGridMov();
                    }
                    valido.valido = true;
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "O documento não tem linhas");
                    Lista = null;
                }  
            }
            return valido.valido; 
        }

        private (DataRow rc, DataRow tdoc, bool valido) ValueTuple(bool bindgrid, DataTable factl, (DataRow rc, DataRow tdoc, bool valido) valido,bool nc)
        {
            foreach (var row in factl.AsEnumerable())
            {
                if (row["tabiva"].ToDecimal() > 0)
                {
                    var cpoc = SQL.GetGen2DT($"select Tabiva,ValVenda,Iva,Codcpoc,Desconto from cpoc join CpocVend on Cpoc.Cpocstamp = CpocVend.Cpocstamp where Codcpoc={row["cpoc"].ToDecimal()} and tabiva ={row["tabiva"].ToDecimal()}");
                    if (cpoc?.Rows.Count > 0)
                    {
                        if (Lista != null)
                        {
                            if (!Lista.Any(x => x.Conta.Trim().Equals(cpoc.Rows[0]["ValVenda"].ToString().Trim())))
                            {
                                CriaMovMercadoriaServico(row, valido.rc, valido.tdoc, cpoc, nc);
                            }
                            else
                            {
                                var xx = Lista.Where(x => x.Conta.Trim().Equals(cpoc.Rows[0]["ValVenda"].ToString().Trim())).FirstOrDefault();
                                xx.Credito = xx.Credito + row["subtotall"].ToDecimal();
                            }

                            if (!Lista.Any(x => x.Conta.Trim().Equals(cpoc.Rows[0]["Iva"].ToString().Trim())))
                            {
                                if (row["tabiva"].ToDecimal() > 1)
                                {
                                    CriaMovIva(valido.rc, valido.tdoc, cpoc.Rows[0]["Iva"].ToString().Trim(),row["valival"].ToDecimal(), nc);
                                }
                            }
                            else
                            {
                                var xx = Lista.Where(x => x.Conta.Trim().Equals(cpoc.Rows[0]["Iva"].ToString().Trim())).FirstOrDefault();
                                xx.Credito = xx.Credito + row["valival"].ToDecimal();
                            }

                            if (!Lista.Any(x => x.Conta.Trim().Equals(cpoc.Rows[0]["Desconto"].ToString().Trim())))
                            {
                                if (row["descontol"].ToDecimal() > 1)
                                {
                                    CriaDesconto(valido.rc, valido.tdoc, cpoc.Rows[0]["Desconto"].ToString().Trim(),row["descontol"].ToDecimal(), nc);
                                }
                            }
                            else
                            {
                                var xx = Lista.Where(x => x.Conta.Trim().Equals(cpoc.Rows[0]["Desconto"].ToString().Trim())).FirstOrDefault();
                                xx.Debito = xx.Debito + row["descontol"].ToDecimal();
                            }
                        }
                        else
                        {
                            CriaMovMercadoriaServico(row, valido.rc, valido.tdoc, cpoc, nc);
                            CriaMovIva(valido.rc, valido.tdoc, cpoc.Rows[0]["Iva"].ToString().Trim(),
                                row["valival"].ToDecimal(), nc);
                        }

                        if (!nc)
                        {
                            if (!valido.tdoc["Movtz"].ToBool()) continue;
                            if (!CriaMovTzCl(valido.rc, valido.tdoc, nc)) break;
                        }
                        else
                        {
                            if (!valido.rc["Movtz"].ToBool()) continue;
                            if (!CriaMovTzCl(valido.rc, valido.tdoc, nc)) break;
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() +$"O artigo {row["descricao"]} não possui o código de integração definido. \r\n O Software não consegue integrar artigos sem codigo CPOC");
                        Lista = null;
                        break;
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() +$"O artigo {row["descricao"]} não possui o tabela de IVA definida. \r\n O Software não consegue integrar artigos sem tabela configurada");
                    Lista = null;
                    break;
                }
            }

            if (bindgrid)
            {
                BindGridMov();
            }

            valido.valido = true;
            return valido;
        }

        private void CriaDesconto(DataRow ft, DataRow tdoc, string contadesconto, decimal valdesconto, bool nc)
        {
            var mviva = new Mov();
            mviva.Conta = contadesconto;
            mviva.Descr = SQL.GetValue($"select descricao from  pgc where conta ='{contadesconto.Trim()}'");
            if (nc)
            {
                mviva.Debito = ft.Table.TableName.ToLower().Equals("fact")?0: valdesconto;
                mviva.Credito = ft.Table.TableName.ToLower().Equals("fact")? valdesconto:0;
            }
            else
            {
                mviva.Debito = ft.Table.TableName.ToLower().Equals("fact")? valdesconto:0;
                mviva.Credito = ft.Table.TableName.ToLower().Equals("fact")?0: valdesconto;
            }
            // ;
            Filldata(mviva,ft,tdoc);
            Lista.Add(mviva);
        }

        private bool CriaMovTzCl(DataRow ft, DataRow tdoc,bool nc)
        {
            var formasp = SQL.GetGen2DT($"select Codtz,Valor,Contatesoura,Contasstamp from Formasp where {ft.Table.TableName.Trim()}stamp='{ft[$"{ft.Table.TableName.Trim()}stamp"].ToString().Trim()}'");
            if (formasp?.Rows.Count > 0)
            {
                foreach (var fp in formasp.AsEnumerable())
                {
                    var drConta = SQL.GetRow($"select conta,Descricao,Pgcstamp from pgc where oristamp='{fp["Contasstamp"]}' and ano= {Pbl.Param.Ano}");
                    if (drConta != null)
                    {
                        if (Lista == null)
                        {
                            NewMethod(drConta, fp, ft, tdoc,nc);
                        }
                        else
                        {
                            if (Lista.Any(x => x.Conta.Trim().Equals(drConta["conta"].ToString().Trim())))
                            {
                                var xx = Lista.Where(x => x.Conta.Trim().Equals(drConta["conta"].ToString().Trim())).FirstOrDefault();
                                xx.Debito = fp["Valor"].ToDecimal();
                            }
                            else
                            {
                                NewMethod(drConta, fp, ft, tdoc,nc);
                            }
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + Messagem.NaoTemConta("A Conta", fp["Contatesoura"].ToString()));
                        Lista = null;
                        return false;
                    }
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Não foi encontrado nenhuma forma de pagamento para este documento!");
                Lista = null;
                return false;
            }

            return true;
        }

        private void NewMethod(DataRow conta, DataRow fp, DataRow ft, DataRow tdoc,bool nc)
        {
            var mov = new Mov
            {
                Conta = conta["conta"].ToString().Trim(), Descr = conta["descricao"].ToString().Trim()
            };
            mov.Pgcstamp = conta["Pgcstamp"].ToString().Trim();
            if (!nc)
            {
                switch (ft.Table.TableName.ToLower())
                {
                    case "fact":
                        if (!tdoc["Vd"].ToBool())
                        {
                            mov.Debito = 0;
                            mov.Credito = ft["Total"].ToDecimal(); 
                        }
                        else
                        {
                            mov.Debito = ft["Total"].ToDecimal();
                            mov.Credito = 0; 
                        }
                        break;
                    case "facc": 
                            //mov.Debito = ft["Total"].ToDecimal();
                            //mov.Credito =0; 
                        if (!tdoc["Vd"].ToBool())
                        {
                            mov.Debito = ft["Total"].ToDecimal();
                            mov.Credito = 0; 
                        }
                        else
                        {
                            mov.Debito = 0;
                            mov.Credito = ft["Total"].ToDecimal(); 
                        }
                        break;
                    case "rcl": 
                            mov.Debito = ft["Total"].ToDecimal();
                            mov.Credito =0; 
                        break;
                    case "pgf": 
                            mov.Debito = 0;
                            mov.Credito = ft["Total"].ToDecimal(); 
                        break;
                }
            }
            else
            {
                switch (ft.Table.TableName.ToLower())
                {
                    case "fact": 
                            mov.Debito = 0;
                            mov.Credito = ft["Total"].ToDecimal(); 
                        break;
                    case "facc": 
                            mov.Debito = ft["Total"].ToDecimal();
                            mov.Credito =0; 
                        break;
                }
            }
            Filldata(mov, ft, tdoc);
            Lista.Add(mov);
        }

        private void CriaMovMercadoriaServico(DataRow row, DataRow ft, DataRow tdoc, DataTable cpoc, bool nc)
        {
            var mv1 = new Mov();
            var drConta = SQL.GetRow($"select Conta,Descricao,Pgcstamp from pgc where conta='{cpoc.Rows[0]["ValVenda"].ToString().Trim()}' and ano ={Pbl.Param.Ano}");
            if (drConta !=null)
            {
                mv1.Conta = drConta["Conta"].ToString().Trim();
                mv1.Descr = drConta["Descricao"].ToString().Trim();
                mv1.Pgcstamp = drConta["Pgcstamp"].ToString().Trim();
                if (!nc)
                {
                    mv1.Debito = ft.Table.TableName.ToLower().Equals("fact") ? 0 : row["subtotall"].ToDecimal();
                    mv1.Credito = ft.Table.TableName.ToLower().Equals("fact") ? row["subtotall"].ToDecimal() : 0;
                }
                else
                {
                    mv1.Debito = ft.Table.TableName.ToLower().Equals("fact") ? row["subtotall"].ToDecimal() : 0;
                    mv1.Credito = ft.Table.TableName.ToLower().Equals("fact") ? 0 : row["subtotall"].ToDecimal();
                }
                Filldata(mv1, ft, tdoc);
                Lista.Add(mv1);
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+$"A conta {cpoc.Rows[0]["ValVenda"]} não existe no plano de contas {Pbl.Param.Ano}\n\rPor favor verifique!");
            }
        }

        private void Filldata(Mov mv,DataRow rc,DataRow tdoc)
        {
            mv.Diario = tdoc["Diario"].ToString();
            mv.NoDiario = tdoc["Nodiario"].ToDecimal();
            mv.Doc = tdoc["DescDocCont"].ToString();
            mv.NoDoc = tdoc["NdocCont"].ToString();
            mv.Nuit = SQL.GetValue("nuit","cl",$"no ='{rc["No"].ToString().Trim()}'" );
            mv.Numdoc = rc["Numdoc"].ToDecimal();
            mv.Nomedoc = rc["Nomedoc"].ToString();
            mv.Docstamp = rc[$"{rc.Table.TableName.Trim()}stamp"].ToString();
            mv.Doclstamp = "";
            mv.Numero =rc["Numero"].ToString();
            mv.Moeda2 = rc["Moeda2"].ToString();
            mv.Moeda = rc["Moeda"].ToString();
            mv.NrLacamento = NrLacamento;
            if (cbData.cb1.Checked)
            {
                mv.Datadoc=dataLanc.Value;
            }
            else
            {
                mv.Datadoc=rc["Data"].ToDateTimeValue();
            }
           // mv.Cambio = rc.Rows[0]["Cambiousd"].ToDecimal();
        }

        private void BindGridMov()
        {
            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = Lista;
        }

        private void CriaMovIva(DataRow ft,DataRow tdoc, string contaiva,decimal valival,bool nc)
        {
            var drConta = SQL.GetRow($"select Conta,Descricao,Pgcstamp from pgc where conta='{contaiva.Trim()}' and ano ={Pbl.Param.Ano}");
            if (drConta != null)
            {
                var mviva = new Mov();
                mviva.Conta = drConta["Conta"].ToString().Trim();
                mviva.Descr = drConta["Descricao"].ToString().Trim();
                mviva.Pgcstamp = drConta["Pgcstamp"].ToString().Trim();
                if (!nc)
                {
                    mviva.Debito = ft.Table.TableName.ToLower().Equals("fact") ? 0 : valival;
                    mviva.Credito = ft.Table.TableName.ToLower().Equals("fact") ? valival : 0;
                }
                else
                {
                    mviva.Debito = ft.Table.TableName.ToLower().Equals("fact") ? valival : 0;
                    mviva.Credito = ft.Table.TableName.ToLower().Equals("fact") ? 0 : valival;
                }
                // ;
                Filldata(mviva, ft, tdoc);
                Lista.Add(mviva);
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + $"A conta {contaiva} não existe no plano de contas {Pbl.Param.Ano}\n\rPor favor verifique!");
            }
        }
        private void CriaMovIva2(DataRow ft,DataRow tdoc, string contaiva,decimal valival,bool nc)
        {
            var mviva = new Mov();
            mviva.Datadoc=ft["Data"].ToDateTimeValue();
            mviva.Conta = contaiva;
            mviva.Descr = SQL.GetValue($"select descricao from  pgc where conta ='{contaiva.Trim()}'");
            mviva.Debito = valival/2;
            mviva.Credito = 0;

            //if (!nc)
            //{
            //    mviva.Debito = ft.Table.TableName.ToLower().Equals("fact")?0: valival;
            //    mviva.Credito = ft.Table.TableName.ToLower().Equals("fact")? valival:0;
            //}
            //else
            //{
            //    mviva.Debito = ft.Table.TableName.ToLower().Equals("fact")? valival:0;
            //    mviva.Credito = ft.Table.TableName.ToLower().Equals("fact")?0: valival;
            //}
            // ;
            Filldata(mviva,ft,tdoc);
            Lista.Add(mviva);
        }

        private bool CriaMovClFnc(DataRow ft,DataRow tdoc,bool nc)
        {
            var ret = false;
            var nometab = ft.Table.TableName.ToLower();
            //var conta = "";
            DataRow drConta = null;
            var nome = "";
            if (nometab.Equals("pgf") || nometab.Equals("facc"))
            {
                //conta = SQL.GetValue($@"select conta from fncct where contacc=1 and fncstamp=(select fncstamp from fnc where no='{ft["No"]}')");
                drConta = SQL.GetRow($"select Conta,Descricao,Pgcstamp from pgc where oristamp='{ft["fncstamp"]}' and ano ={Pbl.Param.Ano} and SUBSTRING(Conta,0,4)='421'");
                nome = "Fornecedor";
            }
            if (nometab.Equals("rcl") || nometab.Equals("fact"))
            {
                //conta = SQL.GetValue($@"select conta from clct where contacc=1 and clstamp=(select clstamp from cl where no='{ft["No"]}')");
                drConta = SQL.GetRow($"select Conta,Descricao,Pgcstamp from pgc where oristamp='{ft["clstamp"]}' and ano ={Pbl.Param.Ano} and SUBSTRING(Conta,0,4)='411'");
                
                nome = "Cliente";
            }
            if (drConta != null)
            {
                if (nometab.Equals("pgf")||nometab.Equals("rcl"))
                {
                    Criarconta(ft, tdoc, drConta, nc);
                    ret = true;

                }
                else if(nometab.Equals("fact")||nometab.Equals("facc"))
                {
                    if (tdoc["Movcc"].ToBool())
                    {
                        Criarconta(ft, tdoc, drConta, nc);
                        ret = true;
                    }   
                }
            }
            else
            {
                
                MsBox.Show(Messagem.ParteInicial() + Messagem.NaoTemConta($"O {nome} ",ft["Nome"].ToString()));
            }
            return ret;
        }
        private void Criarconta(DataRow ft, DataRow tdoc, DataRow conta,bool nc)
        {
            var mov = new Mov {Conta = conta["Conta"].ToString(), Descr = conta["Descricao"].ToString(), Datadoc=ft["Data"].ToDateTimeValue()};
            mov.Pgcstamp = conta["Pgcstamp"].ToString();
            if (!nc)
            {
                switch (ft.Table.TableName.ToLower())
                {
                    case "fact":
                            mov.Debito = ft["Total"].ToDecimal();
                            mov.Credito = 0; 
                        break;
                    case "facc": 
                            mov.Debito = 0;
                            mov.Credito = ft["Total"].ToDecimal(); 
                        break;
                    case "rcl": 
                            mov.Debito = 0;
                            mov.Credito =ft["Total"].ToDecimal(); 
                        break;
                    case "pgf": 
                            mov.Debito = ft["Total"].ToDecimal();
                            mov.Credito =0; 
                        break;
                }
            }
            else
            {
                switch (ft.Table.TableName.ToLower())
                {
                    case "fact": 
                            mov.Debito = 0;
                            mov.Credito = ft["Total"].ToDecimal(); 
                        break;
                    case "facc": 
                            mov.Debito = ft["Total"].ToDecimal();
                            mov.Credito =0; 
                        break;
                }
            }
            Filldata(mov, ft, tdoc);
            Lista = new List<Mov> {mov};
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }
        public bool Maximizado { get; set; }
        private void Maximizar()
        {
            NSize = Size;
            NLocation = Location;
            if (MdiParent != null)
            {
                var height = MdiParent.Size.Height;
                var width = MdiParent.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = MdiParent.Location.X;
                var y = MdiParent.Location.Y;
                Location = new Point(x + 175, y + 110);
                Maximizado = true;
                var lista = Application.OpenForms;
                foreach (Form frm in lista)
                {
                    if (frm == null) continue;
                    if (frm.IsMdiContainer)
                    {
                        if (frm is DemoMdi)
                        {
                            if (((DemoMdi) frm).Ocultado)
                            {
                                MoveUp();
                            }
                        }
                        else
                        {
                            MoveUp();
                        }
                    }
                }
            }
            else
            {
                var height = Screen.PrimaryScreen.WorkingArea.Size.Height;
                var width = Screen.PrimaryScreen.WorkingArea.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = Screen.PrimaryScreen.WorkingArea.Location.X;
                var y = Screen.PrimaryScreen.WorkingArea.Location.Y;
                Location = new Point(x + 175, y + 110);    
            }
        }
        public void MoveUp()
        {
            NSize = Size;
            NLocation = Location;
            var height = MdiParent.Size.Height;
            var width = MdiParent.Size.Width;
            Size = new Size(width - 70, height - 165);
            var x = MdiParent.Location.X;
            var y = MdiParent.Location.Y;
            Location = new Point(48, y + 110);
        }
        public void MoveDow()
        {
            Size = NSize;
            Location = NLocation;
        }
        public void Minimizar()
        {
            Size = NSize;
            Location = NLocation;
            Maximizado = false;
        }
        public Size NSize { get; set; }
        public Point NLocation { get; set; }
        public string Maximo { get;  set; }
        public decimal NrLacamento { get; private set; }
        private List<string> Lancamentos;

        bool breakvalue = false;
        private void btnIntegrar_Click(object sender, EventArgs e)
        {
            var dt = GridDocumentos.DataSource as DataTable;
            if (dt == null || !dt.AsEnumerable().Any(x => x.Field<bool>("OK").Equals(true))) return;
            dt = dt.AsEnumerable().Where(x => x.Field<bool>("OK").Equals(true)).CopyToDataTable();
            if (dt == null) return;
            Lancamentos = new List<string>();
            Helper.DoProgressProcess(dt, RecebeDados);
        }

        private void RecebeDados(DataRow row, bool fim)
        {
                if (row!=null)
                {
                    breakvalue = true;
                    switch (Tabela.ToLower())
                    {
                        case "fact":
                            if (GeracontasFact(row["localstamp"].ToString()))
                            {
                                IntegraDocumento();
                                breakvalue = false;
                            }
                            break;
                        case "rcl":
                            if (GeracontasRcl(row["localstamp"].ToString()))
                            {
                                IntegraDocumento();
                                breakvalue = false;
                            }
                            break;
                        case "pgf":
                            if (GeracontasPgf(row["localstamp"].ToString()))
                            {
                                IntegraDocumento();
                                breakvalue = false;
                            }
                            break;
                        case "facc":
                            if (GeracontasFacc(row["localstamp"].ToString()))
                            {
                                IntegraDocumento();
                                breakvalue = false;
                            }
                            break;
                    }
                }
                if(fim)
                { 
                    var str = "";
                    foreach (string item in Lancamentos)
                    {
                        if (string.IsNullOrEmpty(str))
                        {
                            str=item.Trim();
                        }
                        else
                        {
                            str=$"{str},\r\n{item.Trim()}";
                        }
                    }
                    MsBox.Show(Messagem.ParteInicial() + $"Lançamento foi executado com sucesso, Nº(s): {str}");
                    Processar(true);
                }
        }

        private void IntegraDocumento()
        {
            if (Lista == null) return;
            var data = Pbl.DataContabil();
            var lc = new Lcont
            {
                Lcontstamp = Pbl.Stamp(),
                Data =data,
                Ano = data.Year,
                Crefin = Lista.Sum(x => x.Credito),
                Debfin = Lista.Sum(x => x.Debito)
            };
            var str = $"SELECT dbo.func_GenNumber({Lista.FirstOrDefault().NoDiario},{data.Month},{data.Year})";
            Maximo = SQL.SQLExecScalar(str).ToString();
            lc.Dilno = Maximo.ToDecimal();
            lc.Mes = data.Month;
            lc.Dia = data.Day;
            lc.Ano = Pbl.Param.Ano;
            lc.Moeda = Lista.First().Moeda;
            lc.Moeda2 = Lista.First().Moeda2;
            lc.Cambio = Lista.First().Cambio;
            lc.Dino = Lista.First().NoDiario;
            lc.Dinome = Lista.First().Diario;
            lc.Docnome = Lista.First().Doc;
            lc.Docno = Lista.First().NoDoc.ToDecimal();
            lc.Adoc=Lista.First().Nomedoc+"-"+Lista.First().Numero;
            lc.Oristamp = Lista.First().Docstamp;
            lc.Diariostamp = SQL.GetValue($"select Diariostamp  from diario where dino={Lista.First().NoDiario}");
            var dt = SQL.Initialize("ml");
            var max = 1;
            foreach(var c in Lista) 
            {
                if (c==null) continue;
                if (max==1)
                {
                    NewRow(dt, lc, c, max);
                }
                else
                {
                    
                    if (dt?.Rows.Count>0)
                    {
                        if (dt.AsEnumerable().Any(x => x.Field<string>("Conta").Trim().Equals(c.Conta.Trim())))
                        {
                            var dr = dt.AsEnumerable().Where(x => x.Field<string>("Conta").Trim().Equals(c.Conta.Trim())).First();
                            if (dr != null)
                            {
                                dr["deb"] = dr["deb"].ToDecimal()+c.Debito;
                                dr["cre"] =  dr["cre"].ToDecimal()+c.Credito;
                            }
                            else
                            {
                                NewRow(dt, lc, c, max);
                            }
                        } 
                        else
                        {
                            NewRow(dt, lc, c, max);
                        }
                    }                        
                    else
                    {
                        NewRow(dt, lc, c, max);
                    }
                }
                max++;
            }
            if (lc.Debfin==lc.Crefin)
            {
                if (EF.Save(lc).ret==1)
                {
                     Lancamentos.Add(lc.Dilno.ToString());
                    SQL.Save(dt,"ml",true,lc.Lcontstamp,"Lcont");   
                }                            
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() +$"Não podemos gravar o documento: {lc.Adoc}, porque o débito não é igual a Crédito.");
            }
        }

        private static void NewRow(DataTable dt, Lcont lc, Mov c, int max)
        {
            var dr = dt.NewRow().Inicialize();
            dr["lcontstamp"] = lc.Lcontstamp;
            dr["Conta"] = c.Conta;
            dr["descricao"] = c.Descr;
            dr["mes"] = lc.Data.Month;
            dr["dia"] = lc.Data.Day;
            dr["data"] = lc.Data;
            dr["deb"] = c.Debito;
            dr["cre"] = c.Credito;
            dr["descritivo"] = lc.Adoc;
            dr["ordem"] = max;
            dr["oristamp"] = lc.Oristamp;
            dr["Dinome"] = lc.Dinome;
            dr["Ano"] = lc.Ano;
            dr["Dino"] = lc.Dino;
            dr["Dilno"] = lc.Dilno;
            dr["Docnome"] = lc.Docnome;//Oristampl
            dr["Pgcstamp"] = c.Pgcstamp;//
            dr["Oristampl"] = c.Oristampl;//
            dt.Rows.Add(dr);
        }
    }
}
