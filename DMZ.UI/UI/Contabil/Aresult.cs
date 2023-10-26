using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using Microsoft.Reporting.WinForms;

namespace DMZ.UI.UI.Contabil
{
    public partial class Aresult : FrmClasse2
    {
        public Aresult()
        {
            InitializeComponent();
        }
        private DataTable _dtApuras;
        private DataTable _dtMlApura;
        private DataTable _dtMlApura1;
        private DataTable dtPgc;
        private void Aresult_Load(object sender, EventArgs e)
        {
            AnoCont = Pbl.AnoContabil();
            cbSequenc.Checked=true;
            cbIRPC.Checked = true;
            foreach (DataGridViewColumn col in dgvML.Columns)
            {
                col.ReadOnly=true;
            }
        }

        void LoadMethod()
        {
            _dtApuras = SQL.GetGen2DT(@"select ltrim(rtrim(str(sequec)))+'-'+ltrim(rtrim(descricao)) as fase, * from apparam
                                    where origem = 'RES' order by sequec");
           _dtMlApura = SQL.GetGen2DT("   select conta,descricao,deb,cre,cast(0 as decimal) sequec," +
                                                   "cast(0 as decimal) pai,cast(0 as decimal)tipo from ml where 1=2");

            _dtMlApura1 = SQL.GetGen2DT("   select conta,descricao,deb,cre,cast(0 as decimal) sequec," +
                                                     "cast(0 as decimal) pai,cast(0 as decimal)tipo from ml where 1=2");
            dgvML.SetDataSource(_dtMlApura);
            dtPgc = SQL.GetGen2DT(@"  select conta,descricao,deb,cre,integracao=cast(0 as bit),cast(0 as decimal) sequec," +
                                  "cast(0 as decimal) pai,cast(0 as decimal)tipo  from ml where 1=0");
        }
        private void Processar()
        {
            dtPgc = _dtMlApura1= _dtMlApura = null;
            LoadMethod();
            if (cbSequenc.Checked)
            {
                for (var i = 1; i <= _dtApuras.Rows.Count; i++)
                {

                    if (i <= 3)
                    {
                        var dr = _dtApuras.GetFirstOrDefault($"Sequec={i}");
                        ExecProcess(dr);
                    }
                    else
                    {
                        switch (i)
                        {
                            case 4:
                                {
                                    Docase(i);
                                    if (cbIRPC.Checked)
                                    {
                                        var dr = _dtMlApura.GetFirstOrDefault($"Sequec={i}");
                                        var dr441 = _dtMlApura.NewRow();
                                        var dt441 = SQL.GetGen2DT("select ContaIrps,ContaIrpsdesc from param");
                                        dr441["conta"] = dt441.Rows[0]["ContaIrps"];
                                        dr441["descricao"] = dt441.Rows[0]["ContaIrpsdesc"];
                                        dr441["cre"] = dr["cre"].ToDecimal() == 0 ? dr["deb"].ToDecimal() * 32 / 100 : dr["cre"].ToDecimal() * 32 / 100;
                                        dr441["Sequec"] = 4;
                                        _dtMlApura.Rows.Add(dr441);
                                        var dr44185 = _dtMlApura.NewRow();
                                        var deccorre = _dtMlApura.GetTable($"conta='831' and sequec={i}");
                                        dr44185["conta"] = "85";
                                        dr44185["descricao"] = dt441.Rows[0]["ContaIrpsdesc"];
                                        //dr44185["cre"] = dr["cre"].ToDecimal() == 0 ? dr["deb"].ToDecimal() * 32 / 100 : dr["cre"].ToDecimal() * 32 / 100;
                                        dr44185["cre"] = deccorre.RowZero("cre").ToDecimal() == 0 ? deccorre.RowZero("deb").ToDecimal() * 32 / 100 : deccorre.RowZero("cre").ToDecimal() * 32 / 100;
                                        //dr44185["cre"] = valor * 32 / 100 ;
                                        dr44185["Sequec"] = 6;
                                        decimal resu = dr44185["cre"].ToDecimal();
                                        _dtMlApura.Rows.Add(dr44185);
                                    }

                                    break;
                                }
                            case 5:
                                Docase(i);
                                break;
                        }
                    }
                }

            }
            else
            {
                if (cmbFase.Text2.ToDecimal() > 0)
                {
                    var linha = _dtApuras.GetFirstOrDefault($"conta='{cmbFase.Text2.Trim()}'");
                    if (linha != null)
                    {
                        ExecProcess(linha);
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "Deve inivar o mês de apuramento!");
                }
            }
            //var dr4411 = _dtMlApura.NewRow();
            //dr4411["conta"] = "";
            //dr4411["descricao"] ="Totais........................";
            //decimal totaldeb = 0;
            //decimal totalcre = 0;
            //for (int j = 0; j < _dtMlApura.Rows.Count; j++)
            //{
            //    totaldeb += _dtMlApura.Rows[j]["deb"].ToDecimal();
            //    totalcre += _dtMlApura.Rows[j]["deb"].ToDecimal();
            //}
            //dr4411["cre"] = totaldeb;
            //dr4411["deb"] = totalcre;
            //dr4411["Sequec"] = 0;
            //_dtMlApura.Rows.Add(dr4411);
            
            _dtMlApura= _dtMlApura.GetTable("conta<>'441'");
            foreach (DataRow dr in _dtMlApura.Rows)
            {
                //881
                if (dr["conta"].ToString().Length == 2 || 
                    dr["conta"].ToString().Equals("881") || dr["conta"].ToString().Equals("59")||dr["conta"].ToString().Equals("81") || dr["conta"].ToString().Equals("821") 
                    || dr["conta"].ToString().Equals("831") || dr["conta"].ToString().Equals("85"))
                {
                    DataRow dr1 = _dtMlApura1.NewRow();
                    foreach (DataColumn column in _dtMlApura.Columns)
                    {
                        if (!_dtMlApura1.Columns.Contains(column.ColumnName))
                        {
                            _dtMlApura1.Columns.Add(column.ColumnName);
                        }
                        dr1[column.ColumnName] = dr[column.ColumnName];
                    }
                    _dtMlApura1.Rows.Add(dr1);
                }
                if (dr["conta"].ToString().Length==2|| dr["conta"].ToString().Equals("881") || dr["conta"].ToString().Equals("821") || dr["conta"].ToString().Equals("831"))
                {
                    
                }
            }

            if (tbDoisDigitos.Checked)
            {
                dgvML.SetDataSource(_dtMlApura1);
            }
            else if (!tbDoisDigitos.Checked)
            {
                dgvML.SetDataSource(_dtMlApura);
            }
        }

        private String removeLastChar(string s)
        {
            //returns the string after removing the last character  
            return s.Substring(0, s.Length - 1);
        }

        //private bool Tudocredito;
        private string contacorrente = string.Empty;
        private void Docase(int i)
        {
            var str = $@"select * from(select apivliq.Conta,apivliq.Descricao,Apparam.conta as conta1,Apparam.Descricao as Descricao1 ,Sequec from apivliq join 
                Apparam on Apparam.Apparamstamp=apivliq.Apparamstamp where sequec ={i} 
                union all 
                select Apivded.Conta,Apivded.Descricao,Apparam.conta as conta1,Apparam.Descricao as Descricao1 ,Sequec from Apivded join 
                Apparam on Apparam.Apparamstamp=Apivded.Apparamstamp where sequec ={i})temp order by Conta asc";
            var tabela = SQL.GetGen2DT(str);
            if (tabela?.Rows.Count == 0) return;
            decimal saldo1 = 0;
            decimal saldo2 = 0;
            for (var j = 0; j < tabela.Rows.Count; j++)
            {
                var rt = tabela.Rows[j]["Conta"].ToString().Trim();
                var linha = _dtMlApura.GetFirstOrDefault($"conta='{tabela.Rows[j]["Conta"].ToString().Trim()}'");
                var dd = _dtMlApura.GetTable($"conta='81'");
                if (linha == null) continue;
                if (i == 4)
                {
                    contacorrente = rt;
                    switch (j)
                    {
                        case 0:
                            //Se saldo1 for negativo significa que o valor esta em credito 
                            saldo1 = linha["deb"].ToDecimal() - linha["cre"].ToDecimal();

                            break;
                        case 1:
                            //Se saldo2 for negativo significa que o valor esta em credito
                            saldo2 = linha["deb"].ToDecimal() - linha["cre"].ToDecimal();
                            break;
                    }
                }
                else
                {
                    if (j == 0)
                    {
                        saldo1 = linha["deb"].ToDecimal() - linha["cre"].ToDecimal();
                    }
                }
            }

            if (i == 4)
            {
                decimal saldo;
                var drn = _dtMlApura.NewRow();
                drn["conta"] = tabela.Rows[0]["conta1"];
                drn["descricao"] = tabela.Rows[0]["Descricao1"];
                var dd = drn["descricao"].ToString();
                if (saldo1 < 0 && saldo2 < 0)
                {
                    saldo = saldo1 * -1 + saldo2 * -1;
                    drn["deb"] = saldo;
                    drn["cre"] = 0;
                }
                else if (saldo1 > 0 && saldo2 > 0)
                {
                    saldo = saldo1 + saldo2;
                    drn["cre"] = saldo;
                    drn["deb"] = 0;
                }
                else
                {
                    //saldo1 equivale 81, se for negativo o valor esta em credito 
                    //saldo2 equivale 821, se for negativo o valor esta em credito 

                    var saldo11 = saldo1.IsNegative() ? saldo1 * -1 : saldo1;
                    var saldo22 = saldo2.IsNegative() ? saldo2 * -1 : saldo2;

                    if (saldo11 < 0 && saldo22 > 0)
                    {
                        saldo = saldo22 - saldo11;
                        if (saldo1.IsNegative())
                        {
                            drn["cre"] = saldo;
                        }
                        else
                        {
                            drn["deb"] = saldo;
                        }

                    }
                    else if (saldo11 > 0 && saldo22 <= 0)
                    {
                        saldo = saldo11 - saldo22;
                        if (saldo22.IsNegative())
                        {
                            drn["cre"] = saldo;
                        }
                        else
                        {
                            drn["deb"] = saldo;
                        }
                    }
                    else if (saldo11 <= 0 && saldo22 >= 0)
                    {
                        saldo = saldo11 - saldo22;
                        if (saldo11.IsNegative())
                        {
                            drn["deb"] = saldo;
                        }
                        else
                        {
                            drn["cre"] = saldo;
                        }
                    }
                    else if (saldo11 > 0 && saldo22 > 0)
                    {
                        saldo = saldo22 - saldo11;
                        if (saldo1.IsNegative())
                        {
                            drn["cre"] = saldo;
                            drn["deb"] = 0;
                        }
                        else
                        {
                            drn["deb"] = saldo;
                            drn["cre"] = 0;
                        }

                    }
                }
                drn["Sequec"] = tabela.Rows[0]["Sequec"];
                _dtMlApura.Rows.Add(drn);
            }

            if (i == 5)
            {
                // and conta='{contacorrente}'
                var dt4 = _dtMlApura.GetTable($"Sequec=4");
                if (dt4.HasRows())
                {

                    var deccorre = _dtMlApura.GetTable($"conta='831' and sequec=4");
                    decimal valorcorrente = deccorre.RowZero("cre").ToDecimal() == 0 ? deccorre.RowZero("deb").ToDecimal() : deccorre.RowZero("cre").ToDecimal();

                    decimal saldo;
                    if (cbIRPC.Checked)
                    {
                        //saldo1 = dt4.Rows[0]["cre"].ToDecimal().ToRound((int)Pbl.Param.Aredondamento) - dt4.Rows[1]["cre"].ToDecimal().ToRound((int)Pbl.Param.Aredondamento);
                        //saldo2 = dt4.Rows[0]["deb"].ToDecimal().ToRound((int)Pbl.Param.Aredondamento) - dt4.Rows[1]["deb"].ToDecimal().ToRound((int)Pbl.Param.Aredondamento);
                        //saldo1 = Math.Abs(dt4.Rows[0]["cre"].ToDecimal() - dt4.Rows[1]["cre"].ToDecimal());
                        //saldo2 = Math.Abs(dt4.Rows[0]["deb"].ToDecimal() - dt4.Rows[1]["deb"].ToDecimal());
                        //saldo = saldo1 - saldo2;

                        var dt4ss = _dtMlApura.GetTable($"Sequec=6 and conta='85'");
                        decimal valorIRC = dt4ss.RowZero("cre").ToDecimal();
                       
                        saldo=(valorcorrente- valorIRC).ToRound((int)Pbl.Param.Aredondamento);


                        // saldo = (dt4.Rows[0]["deb"].ToDecimal() - dt4.Rows[0]["cre"].ToDecimal()).ToRound((int)Pbl.Param.Aredondamento);
                    }
                    else
                    {
                        saldo = valorcorrente;//(dt4.Rows[0]["deb"].ToDecimal() - dt4.Rows[0]["cre"].ToDecimal()).ToRound((int)Pbl.Param.Aredondamento);
                    }
                    var drn = _dtMlApura.NewRow();
                    drn["conta"] = tabela.Rows[0]["conta1"];
                    drn["descricao"] = tabela.Rows[0]["Descricao1"];
                    var dr831 = dt4.AsEnumerable().FirstOrDefault(x => x.Field<string>("conta").Contains("83"));
                    if (dr831 != null)
                    {
                        if (dr831["deb"].ToDecimal().IsZero())
                        {
                            drn["cre"] = 0;
                            drn["deb"] = saldo.IsNegative() ? saldo * -1 : saldo;
                        }
                        else
                        {
                            drn["cre"] = saldo.IsNegative() ? saldo * -1 : saldo;
                            drn["deb"] = 0;
                            var vl = drn["cre"].ToDecimal();
                        }
                    }
                    //drn["deb"] = saldo < 0 ? saldo * -1 : 0;
                    //drn["cre"] = saldo > 0 ? saldo : 0;
                    //se 831 estiver do lado credito, o 881 fica do mesmo lado depois de subtrair com a 441
                    //se 831 estiver do lado de debito, o 881 fica do mesmo lado depois de susbtrarir 0 441

                    drn["Sequec"] = tabela.Rows[0]["Sequec"];
                    _dtMlApura.Rows.Add(drn);
                }

            }
        }

        private string _contaCustos = string.Empty;
        private string _contaCustosssss = string.Empty;

        //private string _contaCustos = string.Empty;

        private string _contaProveitos = string.Empty;
        private void ExecProcess(DataRow dataRow,bool t=true)
        {
            AnoCont = Pbl.AnoContabil();
            var dt = Ct.GetDt(dataRow["apparamstamp"].ToString().Trim());
            if (!dt.HasRows()) return;
            if (dtPgc.HasRows())
            {
                dtPgc.Rows.Clear();
            }

            _contaCustosssss = _contaProveitos= _contaCustos = string.Empty;
            if (dt.HasRows())
            {
                foreach (var dr in dt.AsEnumerable())
                {
                    var tab = SQL.GetGen2DT($"select conta, descricao,integracao from pgc where ano =(select ano from param) and conta like('{dr["conta"].ToTrim()}%') order by Conta asc");
                    if (tab.HasRows())
                    {
                       
                        InsertRows(tab, dtPgc, dr["tipo"].ToDecimal());
                    }
                }
            }
            if (dtPgc.HasRows())
            {
                int rowcount = 0;
                //,decimal sequec, decimal pai, decimal tipo
                foreach (var dr2 in dtPgc.AsEnumerable())
                {
                    if (dr2.DataRowIsNull()) continue;
                    var cond = dr2["integracao"].ToBool() ? $"conta like('{dr2["conta"].ToTrim()}%')" : $"conta ='{dr2["conta"].ToTrim()}'";
                    var r = SQL.GetRow($"select isnull(sum(deb),0) deb,isnull(sum(cre),0) cre from ml where {cond}");
                    var cc = dr2["tipo"].ToTrim().ToInt32();
                    if (dr2["conta"].ToTrim().Length==2 && dr2["tipo"].ToTrim().ToInt32()==1)//Custos
                    {
                        if (string.IsNullOrEmpty(_contaCustos))
                        {
                            _contaCustos = $"{dr2["conta"].ToTrim()}";
                        }
                        else
                        {
                            _contaCustos += $",{dr2["conta"].ToTrim()}";
                        }
                    }
                    if (dr2["conta"].ToTrim().Length == 2 && dr2["tipo"].ToTrim().ToInt32() == 2)//Proveitos
                    {
                        if (string.IsNullOrEmpty(_contaProveitos))
                        {
                            _contaProveitos = $"{dr2["conta"].ToTrim()}";
                        }
                        else
                        {
                            _contaProveitos += $",{dr2["conta"].ToTrim()}";
                        }
                    }
                    rowcount += 1;

                    if (cbContamov.Checked)
                    {
                        if (!r["cre"].ToDecimal().IsZero() || !r["deb"].ToDecimal().IsZero())
                        {
                            if (!r.DataRowIsNull())
                            {
                                AddMlRow(r, dr2, dataRow["sequec"].ToDecimal(), 1, dr2["tipo"].ToDecimal());
                            }
                        }
                    }
                    else
                    {
                        if (!r.DataRowIsNull())
                        {
                            AddMlRow(r, dr2, dataRow["sequec"].ToDecimal(), 0, dr2["tipo"].ToDecimal());
                        }
                    }
                }
            }
            var saldo = CalculaSaldo(dataRow["Sequec"].ToDecimal());
            var rn = _dtMlApura.NewRow();
            rn["conta"] = dataRow["conta"].ToString();
            rn["descricao"] = dataRow["descricao"].ToString().ToUpper();
            var sss = rn["descricao"].ToString();
            rn["deb"] = saldo < 0 ? saldo * -1 : 0;
            rn["cre"] = saldo > 0 ? saldo : 0;
            rn["Sequec"] = dataRow["Sequec"];
            rn["pai"] = 1;
            _dtMlApura.Rows.Add(rn);
        }

        private void InsertRows(DataTable tab, DataTable dtPgc, decimal tipo)
        {
            foreach (var r in tab.AsEnumerable())
            {
                if (r == null) continue;
                var dr = dtPgc.NewRow();
                dr["conta"] = r["conta"];
                dr["descricao"] = r["descricao"];
                dr["tipo"] = tipo;
                dr["integracao"] = r["integracao"];
                dtPgc.AddRow(dr);
            }
        }

        public decimal AnoCont { get; set; }

        private void AddMlRow(DataRow r, DataRow dr2, decimal sequec, decimal pai, decimal tipo)
        {
            var drn = _dtMlApura.NewRow();
            drn["conta"] = dr2["conta"];
            drn["descricao"] = dr2["descricao"];
            decimal totalcre = 0;
            decimal totaldeb = 0;
            if (r["deb"].ToDecimal() > r["cre"].ToDecimal())
            {
                if (r["cre"].ToDecimal() > 0)
                {
                    totaldeb= 0;
                    totalcre = r["deb"].ToDecimal() - r["cre"].ToDecimal();
                }
                if (r["cre"].ToDecimal() == 0)
                {
                    totaldeb = r["cre"].ToDecimal();
                    totalcre = r["deb"].ToDecimal();
                }
                if (r["cre"].ToDecimal() < 0)
                {
                    totaldeb = 0;
                    totalcre = r["deb"].ToDecimal() + r["cre"].ToDecimal();
                }
            }
            if (r["deb"].ToDecimal() < r["cre"].ToDecimal())
            {
                if (r["deb"].ToDecimal() > 0)
                {
                     totalcre = 0;//r["deb"].ToDecimal();
                     totaldeb = r["cre"].ToDecimal() - r["deb"].ToDecimal();
                }
                if (r["deb"].ToDecimal() == 0)
                {
                     totalcre = r["deb"].ToDecimal();
                     totaldeb = r["cre"].ToDecimal();
                }
                if (r["deb"].ToDecimal() < 0)
                {

                     totalcre = 0;
                     totaldeb = r["cre"].ToDecimal() + r["deb"].ToDecimal();
                }
            }
            if (r["deb"].ToDecimal() == r["cre"].ToDecimal())
            {
                if (r["deb"].ToDecimal() > 0)
                {
                    totaldeb = r["cre"].ToDecimal() - r["deb"].ToDecimal();
                     totalcre = r["deb"].ToDecimal() - r["cre"].ToDecimal();
                }
            }

            drn["deb"] = totaldeb;
            drn["cre"] = totalcre;
            drn["Sequec"] = sequec;
            drn["pai"] = pai;
            drn["tipo"] = tipo;
            if (!_dtMlApura.Columns.Contains("integracao"))
            {
                _dtMlApura.Columns.Add("integracao", typeof(bool));
            }
            drn["integracao"] = dr2["integracao"];
            _dtMlApura.Rows.Add(drn);
        }
        private decimal CalculaSaldo(decimal i)
        {
            decimal contProveitosdeb = 0;
           decimal cont6Crecustos = 0;

           #region Custos
            var subs = _contaCustos.Split(',');
            for (var ii = 0; ii < subs.Length; ii++)
            {
                var dtr = _dtMlApura.GetTable($"Sequec='{i}' and conta = '{subs[ii]}'");
                if (dtr != null)
                {
                    //contCustossdeb += dtr
                    //    .Compute("sum(deb)", string.Empty)
                    //    .ToDecimal();
                    cont6Crecustos += dtr.Compute("sum(cre)", string.Empty)
                        .ToDecimal();
                } 
            }
            #endregion

            #region Proveitos
            var subsprove = _contaProveitos.Split(',');
            for (var ii = 0; ii < subsprove.Length; ii++)
            {
                var dtr = _dtMlApura.GetTable($"Sequec='{i}' and conta = '{subsprove[ii]}'");
                if (dtr != null)
                {
                    contProveitosdeb += dtr
                        .Compute("sum(deb)", string.Empty)
                        .ToDecimal();
                    //cont7Creproveitos += dtr.Compute("sum(cre)", string.Empty)
                    //    .ToDecimal();
                }
            } 
            #endregion
            //var liquid = (contCustossdeb- cont6Crecustos).ToDecimal()-(contProveitosdeb - cont7Creproveitos).ToDecimal();

            var liquid = (-cont6Crecustos).ToDecimal() +contProveitosdeb.ToDecimal();
            return liquid;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            Processar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_dtMlApura?.Rows.Count > 0)
            {
                //var titulo1 = "Apuramento de Resultados";
                //var titulo2 = cmbFase.tb1.Text;
                //var listParam = new List<ReportParameter>();
                //var rp1 = new ReportParameter("rpTitulo1", titulo1);
                //listParam.Add(rp1);
                //var rp2 = new ReportParameter("rpTitulo2", titulo2);
                //listParam.Add(rp2);
                //var pr = new RpvPrint(_dtMlApura)
                //{
                //    Origem = 5,
                //    Titulo = titulo1,
                //    DtParam1 = _dtMlApura,
                //    paramList = listParam
                //};
                //pr.ShowDialog();
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Não temos nada para imprimir!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_dtMlApura?.Rows.Count > 0)
            {
                var codigomes = cbMeses.Text2.ToDecimal();
                if (codigomes > 0)
                {
                    if (codigomes == 14)
                    {
                        Apura(codigomes);
                    }
                    else
                    {
                        var dialog = MsBox.Show("Estimado(a), o apuramento de resultados é feito no mês 14! Podemos avançar? ", DResult.YesNo);
                        if (dialog.DialogResult == DialogResult.Yes)
                        {
                            Apura(codigomes);
                        }
                    }
                }
                else
                {
                    MsBox.Show("Estimado(a), não pode deixar o mês vazio!");
                }
            }
            else
            {
                MsBox.Show("Estimado(a), Deve apurar Resultados, clicando no botão processar!");
            }
        }

        private void Apura(decimal codigomes)
        {
            var lcontstamp = SQL.GetValue("lcontstamp", "lcont", $"Apurares=1 and ano= (select ano from param) and mes = {codigomes}");
            if (string.IsNullOrEmpty(lcontstamp))
            {
                ChamaFrmLcont(codigomes);
            }
            else
            {
                var result = MsBox.Show($"Estimado(a), já exite um apuramento de resultados no mês de: {codigomes}/{Pbl.AnoContabil()} \r\n Deseja Recriar o Movimento ?", DResult.YesNo);
                if (result.DialogResult == DialogResult.Yes)
                {
                    SQL.Apagar("lcont", lcontstamp.Trim());
                    ChamaFrmLcont(codigomes);
                }
            }
        }

        private void ChamaFrmLcont(decimal codigomes)
        {
            var w = new FrmLContab();
            w.ShowForm(this);
            w.btnNovo.PerformClick();
            w.Lc.Apuraiva = true;
            w.Lc.Mes = codigomes;
            w.Lc.Ano = Pbl.AnoContabil();
            w.dtData.dt1.Value = Pbl.DataContabil();
            var d = SQL.GetRowToEnt<Diario>($"Apura =1 and Diano={Pbl.Param.Ano}"); //EF.GetEnt<Diario>(x => x.Apura && x.Diano == Pbl.AnoContabil());
            if (d != null)
            {
                w.ucDiario.tb1.Text = d.Descricao;
                w.ucDiario.Text2 = d.Dino.ToString(CultureInfo.InvariantCulture);
                w.ucDiario.Text3 = d.Diariostamp;
                var doc = SQL.GetRowToEnt<Dc>($"Apurares =1"); ;//EF.GetEnt<Dc>(x => x.Apurares);
                if (doc != null)
                {
                    w.ucDoc.tb1.Text = doc.Docnome;
                    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
                    w.ucDoc.Text2 = doc.Docno.ToString();
                    w.ucDoc.Text3 = doc.Dcstamp;
                    w.ucMoeda.tb1.Text = "MZN";
                    w.tbAdoc.tb1.Text = "ARES" + cbMeses.tb1.Text;
                    var str = $"SELECT dbo.func_GenNumber({d.Dino},{Pbl.SqlDate.Month},{Pbl.SqlDate.Year})";
                    var maximo = SQL.SQLExecScalar(str);
                    w.tbNumero.tb1.Text = maximo.ToString();
                    GerarLancamento(w);
                }
                else
                {
                    MsBox.Show("Estimado(a), não foi encotrado o documento de apuramentos resultados, vai criá-lo e depois continuar!");
                }
            }
            else
            {
                MsBox.Show("Estimado(a), não foi encotrado o diário de apuramentos, vai criá-lo e depois continuar!");
            }
        }

        private void GerarLancamento(FrmLContab w)
        {
            var dt = w.GridMovim.DtDS;
            var max = 0;
            foreach (var drap in _dtMlApura.AsEnumerable())
            {
                if (drap["descricao"].ToString().ToLower().Contains("totais...")) continue;
                if (drap["deb"].ToDecimal() + drap["cre"].ToDecimal() == 0) continue;
                var dr = dt.NewRow();
                dr["lcontstamp"] = w.CLocalStamp;
                dr["Conta"] = drap["conta"];
                dr["descricao"] = drap["descricao"];
                dr["descritivo"] = "";
                dr["mes"] = w.dtData.dt1.Value.Month;
                dr["dia"] = w.dtData.dt1.Value.Day;
                dr["data"] = w.dtData.dt1.Value;
                dr["deb"] = drap["deb"];
                dr["cre"] = drap["cre"];
                var b = max + 1;
                dr["ordem"] = b;
                dr["Descritivo"] = "ARES" + cbMeses.Text+ b;
                dt.Rows.Add(dr);
                max++;
            }
            w.Totais();
            w.Refresh();
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

        #region Região de maximizar 

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
                            if (((DemoMdi)frm).Ocultado)
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

        #endregion
        

        private void dgvML_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvML == null) return;
            var ro = dgvML[dgvML.Columns["descricao"].Index, e.RowIndex];
            var cell1 = dgvML[dgvML.Columns["conta"].Index, e.RowIndex];
            if (cell1.Value.ToString().Equals("831") || cell1.Value.ToString().Equals("59") || cell1.Value.ToString().Equals("85") || cell1.Value.ToString().Equals("881") || cell1.Value.ToString().Equals("821") || cell1.Value.ToString().Equals("81"))
            {
#pragma warning disable CA1304 // Specify CultureInfo
                ro.Value= ro.Value.ToString().ToUpper();
#pragma warning restore CA1304 // Specify CultureInfo
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.Crimson;
            }
        }
        
    }
}
