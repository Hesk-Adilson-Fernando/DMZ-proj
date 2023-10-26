using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.DAL.Migrations;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.Classes;
using Microsoft.Reporting.WinForms;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmBalanco : FrmClasse2
    {

        #region Propriedades e Variaveis
        private static string condMes1, _condMes2, Descricao;
        private static decimal AnoContabil;
        private static DataTable dtbcA, dtbcP, dtResult;
        private static int CodMes { get; set; }

        public int Codmes1 { get; set; }
        public int Codmes2 { get; set; }
        public int Tipo { get; set; } //1-Balanco, 2-Demostracao de Resultados
        #endregion
        public FrmBalanco()
        {
            InitializeComponent();
        }

        private DataTable DtBalanc;
        private DataTable DtBal;
        private void frmBalanco_Load(object sender, EventArgs e)
        {
            Text = Tipo == 1 ? "Balanco-" : "Demostração de Resultados";
            Text = "Impressão de " + (Tipo == 1 ? "Balanço" : "Mapa de Demostaração de Resultados");
            AnoContabil = Pbl.AnoContabil();
            EditMode = true;
            DtBalanc = new DataTable();//ordem
            DtBalanc.Columns.Add(new DataColumn("conta", typeof(string)));
            DtBalanc.Columns.Add(new DataColumn("descricao", typeof(string)));
            DtBalanc.Columns.Add(new DataColumn("saldo", typeof(decimal)));
            DtBalanc.Columns.Add(new DataColumn("saldoAnt", typeof(decimal)));
            DtBalanc.Columns.Add(new DataColumn("integracao", typeof(bool)));
            DtBalanc.Columns.Add(new DataColumn("Numero", typeof(decimal)));
            DtBalanc.Columns.Add(new DataColumn("soma", typeof(bool)));
            DtBalanc.Columns.Add(new DataColumn("Titulo", typeof(bool)));

            DtBalanc.Columns.Add(new DataColumn("TotalAct", typeof(bool)));
            DtBalanc.Columns.Add(new DataColumn("TotalCap", typeof(bool)));
            DtBalanc.Columns.Add(new DataColumn("TotalPas", typeof(bool)));
            DtBalanc.Columns.Add(new DataColumn("TotalPro", typeof(bool)));
            DtBalanc.Columns.Add(new DataColumn("TotalProPass", typeof(bool)));

            DtBalanc.Columns.Add(new DataColumn("esconde", typeof(bool)));
            DtBalanc.Columns.Add(new DataColumn("Linhabranca", typeof(bool)));
            LoadCoantas();
            
        }

        private void LoadCoantas()
        {
            for (var i = 1; i <= 4; i++)
            {
                var dtconta = SQL.GetGen2DT($"select conta from pgc where numero={i} and ano =(select ano from param) order by conta");
                if (!dtconta.HasRows()) continue;
                var totallinhas = dtconta.Rows.Count;
                for (var j = 0; j < totallinhas; j++)
                {
                    var conta = dtconta.Rows[j]["conta"].ToString();
                    if (conta.IsNullOrEmpty()) continue;
                    var dt = SQL.GetGen2DT($"select conta,descricao,integracao,numero={i},saldo=cast(0 as decimal),Titulo=Cast(0 as bit),soma=Cast(0 as bit),Total=Cast(0 as bit) from pgc where conta like('{conta.Trim()}%') and ano =(select ano from param) order by conta");
                    if (dt.HasRows())
                    {
                        switch (i)
                        {
                            case 1 when j == 0:
                                AddRowTitulo(i, "ACTIVOS");
                                AddRowTitulo(i, "ACTIVOS NÃO CORRENTES");
                                break;
                            case 2 when j == 0:
                                AddRowTitulo(i, "ACTIVOS CORRENTES");
                                break;
                            case 3 when j == 0:
                                AddRowTitulo(i, "CAPITAL PRÓPIO E PASSIVO");
                                AddRowTitulo(i, "CAPITAL PRÓPIO");
                                break;
                            case 4 when j == 0:
                                AddRowTitulo(i, "PASSIVO");
                                break;
                        }
                        DtBalanc.AddRows(dt);
                        if (j == totallinhas - 1)
                        {
                            AddRowLinhaBranca();
                        }
                        switch (i)
                        {
                            case 2 when j == totallinhas - 1:
                                AddRowTotal(i, "TOTAL DE ACTIVOS", "TotalAct");
                                AddRowLinhaBranca();
                                break;
                            case 3 when j == totallinhas - 1:
                                AddRowTotal(i, "TOTAL DE CAPITAL PRÓPIO", "TotalPro");
                                AddRowLinhaBranca();
                                break;
                            case 4 when j == totallinhas - 1:
                                AddRowTotal(i, "TOTAL DE PASSIVO", "TotalPas");
                                AddRowTotal(i, "CAPITAL PRÓPIO E PASSIVO", "TotalProPass");
                                break;
                        }
                    }
                }
            }
            AddRowTotal(15, "RESULTADO LÍQUIDO", "TotalAct");
            //AddRowLinhaBranca();
        }

        private void AddRowLinhaBranca()
        {
            var dr = DtBalanc.NewRow().Inicialize();
            dr["Linhabranca"] = true;
            DtBalanc.AddRow(dr);
        }

        private void AddRowTitulo(int i, string descricao)
        {
            var dr = DtBalanc.NewRow().Inicialize();
            dr["descricao"] = descricao;
            dr["Titulo"] = true;
            dr["numero"] = $"{i}";
            DtBalanc.AddRow(dr);
        }

        private void AddRowTotal(int i, string descricao,string campo)
        {
            var dr = DtBalanc.NewRow().Inicialize();
            dr["descricao"] = descricao;
            dr["Titulo"] = true;
            //dr["Total"] = true;
            dr["numero"] = $"{i}";
            dr[campo.Trim()] = true;
            DtBalanc.AddRow(dr);
        }
        private string BuildQueryAct(string p)
        {
            var condInteg = cbIntegApenas.cb1.Checked ? " and pgc.integracao=1" : "";

            return $@"select ordem,conta, descricao,sum(saldo) as saldo,integrador,
                        cnt=cast(iif(len(conta)=1,1,0) as bit),SUBSTRING(conta,1,1) as cnt2 from (

                        select 1 as ordem,pgc.conta, pgc.descricao, integrador=(case when pgc.integracao=1 then 1 else 0 end),  
						(ISNULL(sum(deb),0)-ISNULL(sum(cre),0)) as saldo,ordem2=left(pgc.conta,1)
												 from pgcsa_vw as pgcsa (nolock) inner join pgc (nolock) on  
								 pgcsa.conta=pgc.conta and pgcsa.ano=pgc.ano  and pgcsa.grupo='Activo' {condInteg}
                        {p} group by pgc.conta,pgc.descricao,(case when pgc.integracao=1 then 1 else 0 end)                          
                           
                           UNION  --Totais

                        Select 2 as ordem, '0' as conta,descricao='TOTAIS ACTIVO',integrador=1,
						saldo=((select isnull(sum(deb),0) from pgcsa_vw as pgcsa where {condMes1} and pgcsa.ano={AnoContabil}  and len(conta)=1 and pgcsa.grupo='Activo')-
						(select isnull(sum(cre),0) from pgcsa_vw as pgcsa where  {condMes1} and pgcsa.ano={AnoContabil}  and len(conta)=1 and pgcsa.grupo='Activo')),
                        ordem2=0

                        )tmp1 group by ordem,conta,descricao,integrador,ordem2 order by ordem,ordem2 desc";

        }

        private string BuildQueryPass(string p)
        {
            var condInteg = cbIntegApenas.cb1.Checked ? " and pgc.integracao=1" : "";

            return $@"select ordem,conta, descricao,sum(saldo) as saldo,integrador,
                        cnt=cast(iif(len(conta)=1,1,0) as bit),SUBSTRING(conta,1,1) as cnt2 from (

                        select 1 as ordem,pgc.conta, pgc.descricao, integrador=(case when pgc.integracao=1 then 1 else 0 end),  
						(ISNULL(sum(deb),0)-ISNULL(sum(cre),0)) as saldo
												 from pgcsa_vw as pgcsa (nolock) inner join pgc (nolock) on  
								 pgcsa.conta=pgc.conta and pgcsa.ano=pgc.ano  and pgcsa.grupo='Passivo' {condInteg}
                        {p}  group by pgc.conta,pgc.descricao,(case when pgc.integracao=1 then 1 else 0 end)                          
                           
                           UNION  --Totais

                        Select 2 as ordem, '0' as conta,descricao='TOTAIS PASSIVO E CAP. PROPRIO',integrador=1,
						saldo=((select isnull(sum(deb),0) from pgcsa_vw as pgcsa where {condMes1} and pgcsa.ano={AnoContabil}  and len(conta)=1 and pgcsa.grupo='Passivo')-
						(select isnull(sum(cre),0) from pgcsa_vw as pgcsa where  {condMes1} and pgcsa.ano={AnoContabil}  and len(conta)=1 and pgcsa.grupo='Passivo'))

                        )tmp1 group by ordem,conta,descricao,integrador order by ordem,conta";
        }

        private string BuidQueryResult(string p)
        {
            return $@"select * from (
                --Custos
            select 1 as ordem,pgc.conta, pgc.descricao, integrador=(case when pgc.integracao=1 then 1 else 0 end),  
            (ISNULL(sum(deb),0)-ISNULL(sum(cre),0)) as saldo,grupo='Custos'
            from pgcsa_vw as pgcsa (nolock) inner join pgc (nolock) on pgcsa.conta=pgc.conta and pgcsa.ano=pgc.ano
            {p} and left(pgcsa.conta,2) in('62','63','65','69')
              group by pgc.conta,pgc.descricao,pgc.integracao 
                 UNION  --Totais Custos
             Select 2 as ordem, '0' as conta,descricao='TOTAL DOS CUSTOS',integrador=1,saldo=(
            (isnull(sum(deb),0))-(isnull(sum(cre),0))),grupo='Custos' from pgcsa_vw as pgcsa where left(pgcsa.conta,2) in('62','63','65','69') and len(pgcsa.conta)=2 
            and {condMes1} and pgcsa.ano={AnoContabil} and integracao=0
                 UNION 
              --Proveitos
            select 3 as ordem,pgc.conta, pgc.descricao, integrador=(case when pgc.integracao=1 then 1 else 0 end),  
            (ISNULL(sum(deb),0)-ISNULL(sum(cre),0)) as saldo,grupo='Proveitos'
            from pgcsa_vw as pgcsa (nolock) inner join pgc (nolock) on pgcsa.conta=pgc.conta and pgcsa.ano=pgc.ano
            {p} and left(pgcsa.conta,2) in('71','72') 
              group by pgc.conta,pgc.descricao,pgc.integracao 
                UNION  --Totais Proveitos
             Select 4 as ordem, '0' as conta,descricao='TOTAL DOS PROVEITOS',integrador=1,saldo=(
            (isnull(sum(deb),0))-(isnull(sum(cre),0)))
             ,grupo='Proveitos' from pgcsa_vw as pgcsa where left(pgcsa.conta,2) in('71','72') and len(pgcsa.conta)=2 and 
            {condMes1} and pgcsa.ano={AnoContabil} and integracao=0
                UNION 
              --Apuramentos
            select 3 as ordem,pgc.conta, pgc.descricao, integrador=(case when pgc.integracao=1 then 1 else 0 end),  
            (ISNULL(sum(deb),0)-ISNULL(sum(cre),0)) as saldo,grupo='Resultados'
            from pgcsa_vw as pgcsa (nolock) inner join pgc (nolock) on pgcsa.conta=pgc.conta and pgcsa.ano=pgc.ano
            {p}  and left(pgcsa.conta,2) in('821','831','85','881') 
            group by pgc.conta,pgc.descricao,pgc.integracao 
 
             )tmp1 order by ordem,conta";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string titulo;
            var filtro = "";
            switch (Tipo)
            {
                case 1:
                    titulo = $"BALANÇO {AnoContabil}";
                    break;
                default:
                    titulo = $"DEMOSTRAÇÃO DE RESULTADOS {AnoContabil}";
                    break;
            }

            filtro = $"Ano:{AnoContabil}\r\nMês início:{mesInicio.Value} - Mês fim:{mesFim.Value}";

            if (ContasMov.cb1.Checked)
            {
                filtro =  $"{filtro} \r\nContas Movimentadas ";
            }
            if (tbDoisDigitos.cb1.Checked)
            {
                filtro = $"{filtro} \r\nContas de dois dígitos ";
            }
            if (tbDoisDigitos.cb1.Checked)
            {
                filtro = $"{filtro} \r\nContas de dois dígitos ";
            }
            if (ContaInicio.Value>0&&ContaFim.Value>0)
            {
                filtro = $"{filtro} \r\nConta início:{ContaInicio.Value} - Mês fim:{ContaFim.Value}";
            }
            //if (expr)
            //{
            //    cond = cond.IsNullOrEmpty() ? "" : $"{cond} and ";
            //}
            if (DtBal.HasRows())
            {
                //var f = new FrmReport();
                //f.Origem = "CT";
                //f.Dt = DtBal;
                //f.ReportName = "balanco";
                //f.Filtro = filtro;
                //f.CTituloRelatorio = titulo;
                //f.ShowForm(this);

                DS ds = new DS();
                var ret = Imprimir.FillData(null, DtBal, null, ds.DMZ, null);
                Imprimir.CallForm(ret.dtPrint, ret.fp, "", false, label1.Text, "", "balanco", "CT", this, "", true, ds, filtro, titulo);
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Não tem nada para imprimir!");
            }
        }

        private string cond;
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            TotalProPass = 0;
            _totalActivo = 0;
                cond = "";
            if (gridContas.HasRows())
            {
                DtBal.Rows.Clear();
                gridContas.SetDataSource(DtBal);
            }
            cond = cond.IsNullOrEmpty() ? $" mes>={mesInicio.Value} and mes<={mesFim.Value} " : $" {cond} and mes>={mesInicio.Value} and mes<={mesFim.Value}";
            DtBal= DtBalanc.CopyData();
            if (DtBal.HasRows())
            {
                Helper.DoProgressProcess(DtBal, RecebeDados, "descricao", "Calculando");
            }
        }

        private void RecebeDados(DataRow dr, bool fim)
        {
            if (dr == null) return;
            string condconta;
            if (!dr["integracao"].ToBool())
            {
                condconta = $" ltrim(rtrim(conta)) ='{dr["conta"].ToTrim()}' ";
            }
            else
            {
                condconta = $" conta like('{dr["conta"].ToTrim()}%') ";
            }
            var tab = SQL.GetGen2DT($"select (sum(deb) -sum(cre)) saldo from ml where {condconta} and mes between {mesInicio.Value} and {mesFim.Value} and ano =(select ano from param)");
            
            if (tab.HasRows())
            {
                if (ContasMov.cb1.Checked)
                {
                    var sss = tab.RowZero("saldo").ToDecimal();
                    if (tab.RowZero("saldo").ToDecimal() != 0)
                    {
                        dr["saldo"] = tab.RowZero("saldo");
                    }
                    else
                    {
                        if (!dr["Titulo"].ToBool() && !dr["Linhabranca"].ToBool())
                        {
                            dr["esconde"] = true;
                        }
                    }
                }
                else
                {
                    dr["saldo"] = tab.RowZero("saldo");
                }
            }
            else
            {
                if (ContasMov.cb1.Checked)
                {
                    dr["esconde"] = true;
                }
            }
            if (!fim) return;
            DtBal = DtBal.HasRowsCopyToDataTable("esconde", false);
            if (!DtBal.HasRows()) return;
            //Regiao de somatorios 
            //Totais do grupo Activos 
            Totais("totalact", 1);
            //Totais do grupo Activos 
            Totais("totalact", 2);
            //Totais do grupo Capital Propio
            for (var j = 0; j < DtBal.Rows.Count; j++)
            {
                if (DtBal.Rows[j]["numero"].ToDecimal() == 4 || DtBal.Rows[j]["numero"].ToDecimal() == 3)
                {
                    DtBal.Rows[j]["saldo"] = -1 * DtBal.Rows[j]["saldo"].ToDecimal();
                }
                
            }
            Totais("TotalPro", 3);
            //Totais do grupo Passivos 
           
            Totais("TotalPas", 4);
            Totais("TotalProPass", 10);
            Totais("TotalProPass", 15);
            //Fim 
            if (ContasMov.cb1.Checked)
            {
                foreach (var r in DtBal.AsEnumerable())
                {
                    if (r.DataRowIsNull()) continue;
                    if (r["saldo"].ToDecimal().IsZero()  && !string.IsNullOrEmpty(r["conta"].ToString()))
                    {
                        r.Delete();
                    }
                }
                DtBal.AcceptChanges();
            }
            if (tbDoisDigitos.cb1.Checked)
            {
                foreach (var r in DtBal.AsEnumerable())
                {
                    if (r.DataRowIsNull()) continue;
                    if (r["conta"].ToString().Length != 2 && !string.IsNullOrEmpty(r["conta"].ToString()))
                    {
                        r.Delete();
                    }
                }
                DtBal.AcceptChanges();
            }
            gridContas.SetDataSource(DtBal);
        }

        decimal _totalActivo= 0;
        private void Totais(string campo, int num)
        {
            decimal total = 0;
            //TotalProPass = 0;
            for (var j = 0; j < DtBal.Rows.Count; j++)
            {
                if (DtBal.Rows[j]["numero"].ToDecimal() == num && DtBal.Rows[j]["conta"].ToString().Length==2)
                {
                    total += DtBal.Rows[j]["saldo"].ToDecimal();
                }
            }
            var r1 = DtBal.AsEnumerable().FirstOrDefault(x => x.Field<bool>(campo.Trim()).Equals(true));
            if (num==15)
            {
                _totalActivo = 0;
                for (var j = 0; j < DtBal.Rows.Count; j++)
                {
                    if (DtBal.Rows[j]["numero"].ToDecimal() == 2 && DtBal.Rows[j]["conta"].ToString().Length == 0 && DtBal.Rows[j]["descricao"].ToString().Contains("TOTAL DE ACTIVOS"))
                    {
                        _totalActivo += DtBal.Rows[j]["saldo"].ToDecimal();
                    }
                }
                r1 = DtBal.AsEnumerable().FirstOrDefault(x => x.Field<string>("descricao".Trim()).Equals("RESULTADO LÍQUIDO"));
            }
            if (r1 == null) return;
            if (num == 1 || num == 2)
            {
                var ww = r1["saldo"].ToDecimal() + total;
                r1["saldo"] = r1["saldo"].ToDecimal() + total;
                _totalActivo = r1["saldo"].ToDecimal() + total;
            }
            else
            {
                r1["saldo"] = total;
            }
            switch (num)
            {
                case 3:
                case 4:
                    TotalProPass += total;
                    break;
                case 10:
                    r1["saldo"] = TotalProPass;
                    break;
                case 15:
                    r1["saldo"] = _totalActivo - TotalProPass;
                    break;
            }
        }

        public decimal TotalProPass { get; set; }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridContas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridContas == null) return;
            var cell1 = gridContas[gridContas.Columns["integracao"].Index, e.RowIndex];
            if (cell1.Value.ToBool())
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
            var cell2 = gridContas[gridContas.Columns["Titulo"].Index, e.RowIndex];
            if (cell2.Value.ToBool())
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.Crimson;
            }
        }


        //private void Imprimir()
        //{
        //   // if (rbTodas.cb1.Checked)
        //   // {
        //   //     Descricao = "Acumulado de Todo ano: " + Pbl.AnoContabil();
        //   //     BindReport(1);
        //   // }

        //   // if (rbMes.cb1.Checked)
        //   // {
        //   //     if (rbSsaldosAc.cb1.Checked)
        //   //         Descricao = rbSsaldosAc.cb1.Checked ? $"Acumulado até {cbMeses.Text}" : $"{cbMeses.Text}";
        //   //     else
        //   //        if (rbSsaldosPer.cb1.Checked)
        //   //         Descricao = $"Movimentos de {cbMeses.Text}";

        //   //     CodMes = Convert.ToInt32(cbMeses.SelectedValue);

        //   //     BindReport(2);
        //   // }
        //   //string filtro = $"And pgcsa.ano={AnoContabil}";
        //}
        string condicao = string.Empty;
        private void BindReport(int v)
        {
            switch (v)
            {
                // Todo ano.....
                case 1:
                    condicao = $" ano ={AnoContabil}";
                    condMes1 = " 1=1";
                    _condMes2 = " 1=1 ";
                    break;
                // " De um determinado mes ...";
                case 2:
                    if (rbSsaldosAc.cb1.Checked)
                    {
                        condicao = $" mes<={CodMes} and  ano={AnoContabil}";
                        condMes1 = $" mes={CodMes}";
                        _condMes2 = $" mes <={ CodMes}";
                    }
                    else
                    if (rbSsaldosPer.cb1.Checked)
                    {
                        condicao = $" where mes={CodMes} and  ano={AnoContabil}";
                        condMes1 = $" mes={CodMes}";
                        _condMes2 = $" mes <={ CodMes}";
                    }
                    break;
                case 3: //Entre meses
                    condicao = $" mes>={Codmes1} and mes<={Codmes2} and ano={AnoContabil} and integracao =0 ";
                    condMes1 = $" mes>={Codmes1} and mes<={Codmes2} ";
                    _condMes2 = $" mes <={ CodMes}";
                    break;
            }
            if (cbIntegApenas.cb1.Checked)
            {
                   condicao=condicao.IsNullOrEmpty()?$" mes>={mesInicio.Value} and mes <={mesFim.Value}": $"{condicao} and mes>={mesInicio.Value} and mes <={mesFim.Value}";
            }
            condicao=condicao.IsNullOrEmpty()?$" mes>={mesInicio.Value} and mes <={mesFim.Value}": $"{condicao} and mes>={mesInicio.Value} and mes <={mesFim.Value}";

            if (Tipo == 1)
            {
                dtbcA = SQL.GetGen2DT(BuildQueryAct(condicao));
                dtbcP = SQL.GetGen2DT(BuildQueryPass(condicao));
            }
            if (Tipo == 2)
            {
                dtResult = SQL.GetGen2DT(BuidQueryResult(condicao));
            }
        }
    }
}
