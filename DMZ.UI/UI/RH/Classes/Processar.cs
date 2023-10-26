using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.RH.Classes
{
    public static class Processar
    {
        static decimal Diastrab, valMin, nTotSub,DiasFaltas, nTotDesc,TotalAliment, TotalHextra,TotalFaltas,TotalSindicato,SegSocfunc,SegSocEmp,TotalIrps,TotalEmprestimo;
        static string _obsinss,_tipoEvento,_erros,_errosl;
        static Proces _proces;
        static DataTable _qryPrc;
        private static DataTable dtSubfixo;
        private static DataRow rowVenc;
        private static DateTime data;
        private static DataTable dtDescFixo;

        public static void Process(Proces p,DataTable listadepessoas,DataTable Prc)
        {
            if (p.Processado==2)
            {
                MsBox.Show("Desculpe mas o Processamento Seleccionado já está Fechado.");
            }
            else
            {
                _proces=p;
                _qryPrc = Prc;
                Diastrab = Pbl.Param.Diastrab;
                valMin =SQL.GetValue("select min(ValMin) ValMin  from Tirps join Tirpsl on Tirps.Tirpsstamp=Tirpsl.Tirps_Tirpsstamp where Padrao=1 and ValMin>0").ToDecimal();
                dtSubfixo = SQL.GetGen2DT("Select Codigo,Descricao,Valor,Tipo,tiposub from sub where SubFixo=1");
                rowVenc = SQL.GetRow("Select Codigo,Descricao from sub where Tiposub=4");
                data = new DateTime((int)_proces.Ano, (int)_proces.Nrmes, Pbl.SqlDate.Day);
                dtDescFixo = SQL.GetGen2DT("select Codigo,Descricao,Valor,Tipo,Tipodesc from Desconto where Descfixo=1");
                Helper.DoProgressProcess(listadepessoas, RecebeDados,"nome","Processando salário");
            }
        }

        private static decimal GetToatalValue(DataTable qryPrc,string campo)
        {
            return qryPrc.AsEnumerable().Where(x => x.Field<bool>("Linhatotal").ToBool().Equals(true)).Sum(x => x.Field<decimal>($"{campo}"));
        }

        static void RecebeDados(DataRow pessoa,bool fim)
        {
            nTotDesc = 0;
            nTotSub = 0;
            TotalAliment = 0;
            TotalSindicato = 0;
            SegSocfunc = 0;
            SegSocEmp = 0;
            TotalIrps = 0;
            TotalEmprestimo = 0;
            TotalHextra=0;
            TotalFaltas=0;
            DiasFaltas=0;
            _obsinss="";
            _tipoEvento="";
                #region Subsidio
            /*------------------------------------Subsidios---------------------------------------------*/
            /*---------------InicioSubVencim----------------*/
            if (rowVenc != null)
            {
                var rowvencimento = PrcInicial(_proces, _qryPrc, pessoa,0, rowVenc,true);               
                _qryPrc.Rows.Add(rowvencimento);

                /*---------------InicioSubFixo----------------*/

                if (dtSubfixo.HasRows())
                {
                    foreach (var rsub in dtSubfixo.AsEnumerable())
                    {
                        if (rsub == null) continue;
                        var r = SetData(_proces, _qryPrc, pessoa, rsub);
                        nTotSub += r["valor"].ToDecimal();
                        if (rsub["Tiposub"].ToDecimal().Equals(3))
                        {
                            TotalAliment += r["valor"].ToDecimal();
                        }
                        _obsinss = string.IsNullOrEmpty(_obsinss) ? $" {rsub["descricao"]}" : $"{_obsinss}, {rsub["descricao"]}";
                        _qryPrc.Rows.Add(r);
                    }
                }
                /*---------------InicioSubFixo----------------*/

                var str = $"Select p.Codigo,p.Descricao,p.Valor,p.Tipo,sub.tiposub from pesub p join sub on p.Codigo=Sub.Codigo  where LTRIM(RTRIM(p.pestamp))='{pessoa["pestamp"].ToString().Trim()}' and datafim>='{data.ToSqlDate()}' ";
                var dtSubPe = SQL.GetGen2DT(str);
                if (dtSubPe.HasRows())
                {
                    foreach (var rsub in dtSubPe.AsEnumerable())
                    {
                        if (rsub == null) continue;
                        var r = SetData(_proces, _qryPrc, pessoa, rsub);
                        nTotSub += r["valor"].ToDecimal();
                        if (rsub["Tiposub"].ToDecimal().Equals(3))
                        {
                            TotalAliment += r["valor"].ToDecimal();
                            r["Alimentacao"] = true;
                        }
                        _obsinss = _obsinss.IsNullOrEmpty() ? $" {rsub["descricao"]}" : $"{_obsinss}, {rsub["descricao"]}";
                        _qryPrc.Rows.Add(r);
                    }
                }

                #region Horas Extras...

                /*---------------------------------Horas Extras---------------------------------*/
                var pehextra = SQL.GetGen2DT($"select * from Pehextra where Pestamp='{pessoa["Pestamp"]}' and ExcluiProc=0 and Pehextrastamp not in (select Pehextrastamp from prc)");
                if (pehextra.HasRows())
                {
                    foreach (var horaextra in pehextra.AsEnumerable())
                    {
                        if (horaextra == null) continue;
                        var r = PrcInicial(_proces, _qryPrc, pessoa, 1, horaextra);
                        switch (horaextra["Tipo"].ToDecimal())
                        {
                            case 1:
                                var salhora = GetSalHora(pessoa);
                                r["valor"] = salhora * horaextra["Horas"].ToDecimal() * horaextra["valor"].ToDecimal() / 100; //Calcular percenta  ;
                                r["Taxa"] = horaextra["Valor"];
                                break;
                            case 2:
                                r["valor"] = horaextra["Horas"].ToDecimal() * horaextra["valor"].ToDecimal();
                                r["Taxa"] = 0;
                                break;
                            case 3:
                                r["valor"] = horaextra["valor"].ToDecimal();
                                r["Taxa"] = 0;
                                break;
                        }
                        TotalHextra += r["Valor"].ToDecimal();
                        nTotSub += r["Valor"].ToDecimal();
                        r["Pehextrastamp"] = horaextra["Pehextrastamp"];
                        r["Quant"] = horaextra["Horas"].ToDecimal();
                        _obsinss = string.IsNullOrEmpty(_obsinss) ? $" {horaextra["descricao"]}" : $"{_obsinss}, {horaextra["descricao"]}";
                        _qryPrc.Rows.Add(r);
                    }
                }
                /*---------------------------------End Horas Extras---------------------------------*/

                #endregion
                /*------------------------------------End Subsidio---------------------------------------------*/
                #endregion

                #region Descontos ....

                /*---------------------------------Desconto---------------------------------*/
                /*Inicio de Descontos fixos */

                if (dtDescFixo.HasRows())
                {
                    foreach (var row in dtDescFixo.AsEnumerable())
                    {
                        if (row == null) continue;
                        //Calculo do IRPS
                        if (!pessoa["NaoIRPS"].ToBool())
                        {
                            if (row["Tipodesc"].ToDecimal().Equals(2))//Indica que é IRPS
                            {
                                #region IRPS
                                var total = pessoa["ValBasico"].ToDecimal() + nTotSub;                             
                                if (total>=valMin)
                                {
                                    var tmpIrps = SQL.GetGen2DT($"Select * from tirpsl where {total} between valMin and valMax and Tirps_Tirpsstamp='{pessoa["Tirpsstamp"].ToString().Trim()}' "); //Pbl.DtTirps.Select($" {total} between valMin and valMax and Tirps_Tirpsstamp='{pessoa["Tirpsstamp"].ToString().Trim()}'").CopyToDataTable();// SQL.GetRowToEnt<Tirpsl>($"{total} between valMin and valMax and Tirps_Tirpsstamp='{pessoa["Tirpsstamp"].ToString().Trim()}'");                                                                              
                                    if (tmpIrps.HasRows())
                                    {
                                        decimal nValIRPS = 0;
                                        var valMin = tmpIrps.RowZero("ValMin").ToDecimal();
                                        var nBaseTaxa = total - valMin;
                                        var nTaxaIRPS = tmpIrps.RowZero("Percentagem").ToDecimal()/100;
                                        var Dep00 = tmpIrps.RowZero("Dep00").ToDecimal();
                                        var Dep01 = tmpIrps.RowZero("Dep01").ToDecimal();
                                        var Dep02 = tmpIrps.RowZero("Dep02").ToDecimal();
                                        var Dep03 = tmpIrps.RowZero("Dep03").ToDecimal();
                                        var Dep04 = tmpIrps.RowZero("Dep04").ToDecimal();
                                        var dep = pessoa["NrDepend"].ToDecimal();
                                        if (dep > 4)
                                        {
                                            dep = 4;
                                        }
                                        var baseIrps = nBaseTaxa * nTaxaIRPS;
                                        switch (dep)
                                        {
                                            case 0:
                                                nValIRPS = (baseIrps + Dep00).ToDecimal().ToRound(1);
                                                break;
                                            case 1:
                                                nValIRPS = (baseIrps + Dep01).ToDecimal().ToRound(1);
                                                break;
                                            case 2:
                                                nValIRPS = (baseIrps + Dep02).ToDecimal().ToRound(1);
                                                break;
                                            case 3:
                                                nValIRPS = (baseIrps + Dep03).ToDecimal().ToRound(1);
                                                break;
                                            case 4:
                                                nValIRPS = (baseIrps + Dep04).ToDecimal().ToRound(1);
                                                break;
                                        }
                                        
                                        var r2 = PrcInicial(_proces, _qryPrc, pessoa, 2, row);
                                        r2["valor"] = nValIRPS;
                                        r2["taxa"] = nTaxaIRPS;
                                        _qryPrc.Rows.Add(r2);
                                        nTotDesc += nValIRPS;
                                        TotalIrps += nValIRPS;
                                    } 
                                }
                                #endregion
                            }
                        }
                        //Calculo do INSS 
                        if (!pessoa["NaoInss"].ToBool())
                        {
                            if (row["Tipodesc"].ToDecimal().Equals(7))
                            {
                                for (var i = 0; i < 2; i++)
                                {
                                    switch (i)
                                    {
                                        case 0:
                                            {
                                                var r2 = PrcInicial(_proces, _qryPrc, pessoa, 2, row);
                                                r2["valor"] = (pessoa["ValBasico"].ToDecimal() + nTotSub) * Pbl.Param.TaxaInsspe / 100;
                                                r2["taxa"] = Pbl.Param.TaxaInsspe;
                                                _qryPrc.Rows.Add(r2);
                                                nTotDesc += r2["valor"].ToDecimal();
                                                SegSocfunc += r2["valor"].ToDecimal();
                                                break;
                                            }
                                        case 1:
                                            {
                                                var r = PrcInicial(_proces, _qryPrc, pessoa, 5, row);
                                                r["valor"] = (pessoa["ValBasico"].ToDecimal() + nTotSub) * Pbl.Param.TaxaInssemp / 100;
                                                SegSocEmp += r["valor"].ToDecimal();
                                                r["taxa"] = Pbl.Param.TaxaInssemp;
                                                _qryPrc.Rows.Add(r);
                                                break;
                                            }
                                    }
                                }
                            }

                        }

                        if (!row["Tipodesc"].ToDecimal().Equals(7) && !row["Tipodesc"].ToDecimal().Equals(2))
                        {
                            nTotDesc = SetDesc(_proces, _qryPrc, pessoa, row, nTotDesc);
                            _tipoEvento = _tipoEvento.IsNullOrEmpty() ? $"{row["Codigo"]}-{row["descricao"]} " : $" {_tipoEvento}, {row["Codigo"]}-{row["descricao"]} ";
                        }
                        //Faz somatorio de Sindicato
                        if (row["Tipodesc"].ToDecimal().Equals(9))
                        {
                            TotalSindicato += row["valor"].ToDecimal();
                        }
                        //
                    }
                }
                /*Fim de descontos fixos */
                /*Inicio de descontos na ficha da pessoa */

                var dtDescpe = SQL.GetGen2DT($"select p.Codigo,p.Descricao,p.Valor,p.Tipo,d.Tipodesc  from pedesc p join desconto d on p.Codigo=d.Codigo where ltrim(rtrim(p.pestamp)) ='{pessoa["pestamp"].ToString().Trim()}' and year(datafim)>={_proces.Ano} and month(datafim)>={_proces.Nrmes}");
                if (dtDescpe.HasRows())
                {
                    foreach (var row in dtDescpe.AsEnumerable())
                    {
                        if (row == null) continue;
                        nTotDesc = SetDesc(_proces, _qryPrc, pessoa, row, nTotDesc);
                        //Faz somatorio de Sindicato
                        if (row["Tipodesc"].ToDecimal().Equals(9))
                        {
                            TotalSindicato += row["valor"].ToDecimal();
                        }
                        //Faz somatorio de Emprestimo
                        if (row["Tipodesc"].ToDecimal().Equals(10))
                        {
                            TotalEmprestimo += row["valor"].ToDecimal();
                        }
                    }
                }
                /*fim de descontos na ficha da pessoa*/
                #region Faltas

                /*---------------------------------Faltas---------------------------------*/
                var pefalta = SQL.GetGen2DT($"select * from Pefalta where ExcluiProc=0 and  Pestamp='{pessoa["Pestamp"]}' and Pefaltastamp not in (select Pefaltastamp from prc)");
                if (pefalta.HasRows())
                {
                    foreach (var row in pefalta.AsEnumerable())
                    {
                        if (row == null) continue;
                        var r = PrcInicial(_proces, _qryPrc, pessoa, 2, row);
                        r["Taxa"] = 0;
                        var valor = row["Horas"].ToDecimal() * GetSalHora(pessoa);
                        if (row["DescontaRem"].ToBool())//Desconta alimentacao 
                        {
                            var salhora= GetSalHora(pessoa);
                            var linhaAlimenta = _qryPrc.AsEnumerable().FirstOrDefault(x => x.Field<bool>("Alimentacao").Equals(true) && x.Field<string>("pestamp").Trim().Equals(pessoa["pestamp"].ToString().Trim()));
                            if (linhaAlimenta !=null)//
                            {
                                TotalAliment = TotalAliment- salhora;
                                nTotSub= nTotSub - salhora;
                                linhaAlimenta["valor"] = linhaAlimenta["valor"].ToDecimal() - salhora;
                            }
                        }
                        r["Valor"] = valor;
                        TotalFaltas += r["Valor"].ToDecimal();
                        if (pessoa["Horasdia"].ToDecimal() != 0)
                        {
                            r["quant"] = row["Horas"].ToDecimal() / pessoa["Horasdia"].ToDecimal();
                        }
                        else
                        {
                            r["quant"] = row["Horas"].ToDecimal() / 8;
                        }
                        DiasFaltas = DiasFaltas = r["quant"].ToDecimal();
                        nTotDesc += r["valor"].ToDecimal();
                        r["Pefaltastamp"] = row["Pefaltastamp"].ToString();
                        _qryPrc.Rows.Add(r);
                        _tipoEvento = _tipoEvento.IsNullOrEmpty() ? $"{row["Codigo"]}-{row["descricao"]} " : $" {_tipoEvento}, {row["Codigo"]}-{row["descricao"]} ";
                    }
                    _obsinss = _obsinss.IsNullOrEmpty() ? $" Faltou {DiasFaltas} Dia(s)" : $" {_obsinss}, Faltou {DiasFaltas} Dia(s)";
                }
                /*---------------------------------Faltas---------------------------------*/


                #endregion
                /*---------------------------------End Desconto---------------------------------*/

                #endregion

                /*---------------------------------End Processar---------------------------------*/

                var linhaTotal = _qryPrc.AsEnumerable().FirstOrDefault(x => x.Field<bool>("Linhatotal").Equals(true) && x.Field<string>("pestamp").Trim().Equals(pessoa["pestamp"].ToString().Trim()));
                if (linhaTotal != null)
                {
                    if (_obsinss.IsNullOrEmpty())
                    {
                        _obsinss = "INSS";
                    }
                    linhaTotal["TotalAbonus"] = nTotSub;
                    linhaTotal["TotalDescontos"] = nTotDesc;
                    linhaTotal["TotalAliment"] = TotalAliment;
                    linhaTotal["TotalSindicato"] = TotalSindicato;
                    linhaTotal["TotalSegSocfunc"] = SegSocfunc;
                    linhaTotal["TotalSegSocEmp"] = SegSocEmp;
                    linhaTotal["TotalIrps"] = TotalIrps;
                    linhaTotal["TotalHextra"] = TotalHextra;
                    linhaTotal["TotalFaltas"] = TotalFaltas;
                    linhaTotal["DiasPrc"] = linhaTotal["Diassal"].ToDecimal() - DiasFaltas;
                    linhaTotal["Quant"] = DiasFaltas;
                    linhaTotal["Obsinss"] = _obsinss;//TipoEvento
                    linhaTotal["TipoEvento"] = _tipoEvento;//
                    linhaTotal["TaxaSegSocial"] = Pbl.Param.TaxaInssemp + Pbl.Param.TaxaInsspe;
                    linhaTotal["TotalSegSocial"] = SegSocfunc + SegSocEmp;
                    linhaTotal["TipoEvento"] = _tipoEvento;
                    linhaTotal["totalemprestimo"] = TotalEmprestimo;//Emprestismo
                    linhaTotal["TotalVencimento"] = nTotSub + pessoa["ValBasico"].ToDecimal();
                    linhaTotal["TotalLiquido"] = Math.Round(linhaTotal["TotalVencimento"].ToDecimal() - linhaTotal["TotalDescontos"].ToDecimal(), 3);
                }

                if (!fim) return;
                if (!(_qryPrc?.Rows.Count > 0)) return;
                _proces.TotalDesconto = GetToatalValue(_qryPrc, "TotalDescontos");
                _proces.TotalAliment = GetToatalValue(_qryPrc, "TotalAliment");
                _proces.TotalSindicato = GetToatalValue(_qryPrc, "TotalSindicato");
                _proces.TotalIrps = GetToatalValue(_qryPrc, "TotalIrps");
                _proces.TotalSubsidio = GetToatalValue(_qryPrc, "TotalAbonus");
                _proces.TotalFaltas = GetToatalValue(_qryPrc, "TotalFaltas");
                _proces.TotalHextra = GetToatalValue(_qryPrc, "TotalHextra");
                _proces.TotalSegSocEmp = GetToatalValue(_qryPrc, "TotalSegSocEmp");
                _proces.TotalSegSocfunc = GetToatalValue(_qryPrc, "TotalSegSocfunc");//TotalBaseVencimento
                _proces.TotalBaseVencimento = GetToatalValue(_qryPrc, "BaseVencimento");//
                _proces.Totalliquido = GetToatalValue(_qryPrc, "TotalLiquido");
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+"Desculpe mas a Remuneração do tipo vencimento não está configurado\r\nDeve ser do tipo 4!");
            }
            /*---------------FimSubVencim----------------*/

        }

        private static decimal GetSalHora(DataRow pessoa)
        {
            decimal ValBasico;
            decimal diasmes;
            if (pessoa["Diasmes"].ToDecimal() > 0 && pessoa["Diasmes"].ToDecimal() < Diastrab)
            {
                ValBasico = (pessoa["ValBasico"].ToDecimal() / Diastrab * pessoa["Diasmes"].ToDecimal()).ToRound(1);
                if (pessoa["Diasmes"].ToDecimal() > 0)
                {
                    diasmes = pessoa["Diasmes"].ToDecimal();
                }
                else
                {
                    diasmes = Diastrab;
                }
            }
            else
            {
                ValBasico = pessoa["ValBasico"].ToDecimal();
                diasmes = Diastrab;
            }
            if (Pbl.Param.Horastrab.IsZero())
            {
                return ValBasico / diasmes / 8;
            }
            else
            {
                return ValBasico / diasmes / Pbl.Param.Horastrab;
            }
            
        }

        private static decimal SetDesc(Proces proces, DataTable qryPrc, DataRow pessoa, DataRow row, decimal nTotDesc)
        {
            var r2 = PrcInicial(proces, qryPrc, pessoa, 2, row);
            if (row["Tipo"].ToDecimal().Equals(1))
            {
                r2["valor"] = pessoa["ValBasico"].ToDecimal() * row["valor"].ToDecimal() / 100;
                r2["taxa"] = row["valor"].ToDecimal();
            }
            else if (row["Tipo"].ToDecimal().Equals(2))
            {
                r2["valor"] = row["valor"].ToDecimal();
                r2["taxa"] = 0;
            }

            qryPrc.Rows.Add(r2);
            nTotDesc += r2["valor"].ToDecimal();
            return nTotDesc;
        }

        private static DataRow SetData(Proces proces, DataTable qryPrc, DataRow pessoa, DataRow rsub)
        {
            var r = PrcInicial(proces, qryPrc, pessoa, 1, rsub);
            if (rsub["Tipo"].ToDecimal() == 2)
            {
                r["valor"] = rsub["valor"].ToDecimal();
                r["Taxa"] = 0;
            }
            else if (rsub["Valor"].ToDecimal() == 1)
            {
                r["valor"] = pessoa["Valorbasico"].ToDecimal() * rsub["Valor"].ToDecimal() / 100; //Calcular percenta  ;
                r["Taxa"] = rsub["Valor"];
            }
            
            return r;
        }

        private static DataRow PrcInicial(Proces proces, DataTable qryPrc, DataRow pessoa,decimal tipo, DataRow dr,bool addVencbasico=false)
        {
            var r = qryPrc.NewRow().Inicialize();
            r["Processtamp"] = proces.Processtamp;
            r["mes"] = proces.Nrmes;
            r["Mesesstamp"] = proces.Mesesstamp;
            r["Ano"] = proces.Ano;
            r["Data"] = proces.Data;
            r["no"] = pessoa["no"];
            r["nome"] = pessoa["nome"];
            if (Diastrab>0)
            {
                if (addVencbasico)
                {
                    if (pessoa["Diasmes"].ToDecimal()>0 && pessoa["Diasmes"].ToDecimal()<Diastrab)
                    {
                        var valbase = (pessoa["ValBasico"].ToDecimal()/Diastrab*pessoa["Diasmes"].ToDecimal()).ToRound(1);
                        r["BaseVencimento"] = addVencbasico? valbase:0;
                        pessoa["ValBasico"]=valbase;
                    }
                    else
                    {
                        r["BaseVencimento"] =pessoa["ValBasico"];
                    }
                }
                else
                {
                    r["BaseVencimento"] =0;
                }
            }
            if (pessoa["Diasmes"].ToDecimal()==0)
            {
                r["Diassal"] = Diastrab;
            }
            else
            {
                r["Diassal"] = pessoa["Diasmes"];
            }            
            r["Linhatotal"] = addVencbasico;
            r["SegSocial"] =  pessoa["Nrinss"];
            r["Tipo"] = tipo;
            r["Descricao"] = dr["Descricao"];
            r["Referenc"] = dr["codigo"];
            r["codsit"] = pessoa["Codsit"];
            r["Periodo"] = proces.Periodo;
            r["Departamento"] = pessoa["Depart"];
            r["SalarioHora"] = pessoa["SalHora"];
            r["CCusto"] = pessoa["CCusto"];
            r["Tipoproces"] = proces.Tipoproces;
            r["moeda"] = "MZN";//pessoa["moeda"];
            r["TabIrps"] = pessoa["TabIrps"];//Codsind
            r["Codsit"] = pessoa["Situacao"];//
            r["pestamp"] = pessoa["pestamp"];//
            r["obs"] = $"SALÁRIO {proces.Mes.ToUpper()} {proces.Data.Year}";
            return r;
        }
    }
}
