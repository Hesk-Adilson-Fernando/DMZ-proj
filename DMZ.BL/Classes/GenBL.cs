﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using DMZ.Model.Model;

namespace DMZ.BL.Classes
{
	public static class GenBl
    {
        //DMZ.BL.Classes.GenBl Descricaodocs
        private static List<PropertyInfo> props;

        public static string Descricaodocs(string docdesc)
        {
            var ret ="";

            switch (docdesc.ToLower().Trim())
            {
                case "factura":
                    ret="Invoice";
                    break;
                case "cotação":
                    ret="Quotation";
                    break;
                case "venda a dinheiro":
                    ret="Cash Sale";
                    break;
            }
            return ret;

        }
		public static (bool Correcto, string Messagem) CheckTesoura(DataTable formaspdt,decimal tbTotal,bool movtz)
		{
			if (!movtz) return (true, "");
			if (!(formaspdt?.Rows.Count > 0)) return (false,"Deve indicar o tipo de movimento");
			foreach (var r in formaspdt.AsEnumerable())
			{
				if (r == null) continue;
				var f = r.DrToEntity<Formasp>();
				if (string.IsNullOrEmpty(f.Contatesoura))
				{
					return (false, "Por favor indica o local de Tesouraria");
				}
                var contadesc = SQL.GetValue($"select contas from GetContas() where Contasstamp='{f.Contasstamp.Trim()}'");
                if (string.IsNullOrEmpty(contadesc))
                {
                    return (false, "A conta de tesouraria indicada não existe, verifique!");
                }
                if (!f.Contatesoura.Trim().Equals(contadesc.Trim()))
                {
                    return (false, "A conta de tesouraria indicada não existe, verifique!");
                }
                if (string.IsNullOrEmpty(f.Titulo))
				{
					return (false, "Por favor indica o tipo de movimento");
				}
				if (string.IsNullOrEmpty(f.Banco) && f.Numer)
				{
					return (false, "Desculpe mas tem que indicar o Banco");
				}
				if (string.IsNullOrEmpty(f.Numtitulo) && f.ObgTitulo)
				{
					return (false, $"Desculpe mas Tem que indicar o Número de { f.Titulo}");
				}

                var valor = f.Moeda.ToLower().Equals(Pbl.MoedaBase.ToLower()) ? formaspdt.AsEnumerable().Sum(x => x.Field<decimal>("Valor")).ToDecimal() : formaspdt.AsEnumerable().Sum(x => x.Field<decimal>("mValor")).ToDecimal();
                return (valor,1) == (tbTotal,1) ? (true,"") : (false,$@"Desculpe mas o valor do Documento tem que ser igual ao valor total das formas de pagamento.
								Valor do Documento: {tbTotal}
								Total Pagamentos: {valor}
								Por favor verifique !!");
			}
			return (true,"");
		}
		public static (bool StkExiste, string Messagem) CheckStock<T>(T entity, DataTable dt,bool usalote, bool pos = false) where T : class
        {
            _props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			string filhastamp;
			var movstk =GetValue("Movstk", entity).ToBool(); //Utilities.GetProperty("Movstk", entity).GetValue(entity, null).ToBool();
			var codmovstk = GetValue("Codmovstk", entity).ToDecimal(); //Utilities.GetProperty("Codmovstk", entity).GetValue(entity, null).ToDecimal();
            var ccusto = "";
            if (pos)
            {
                ccusto = GetValue("Ccusto", entity)==null?"":GetValue("Ccusto", entity).ToString();  
            }
                
			if (!movstk) return (true, "");
			foreach (var r in dt.AsEnumerable())
			{
				if (r == null) continue;
                if (r.RowState== DataRowState.Deleted) continue;
				filhastamp = r[0].ToString();
				if (r["Servico"].ToBool()) continue;
				if (string.IsNullOrEmpty(r["ststamp"].ToString())) continue;
                if (r["Armazem"].ToDecimal() == 0)
                {
                    return (false, $"O artigo:{r["descricao"]} tem armazem vazio. Verifique ");
                }
				if (codmovstk > 50)
				{
					string querry;
                    querry =$@"Select * from STExtratoficha('{r["ststamp"].ToString().Trim()}') where Armazemstamp='{r["Armazemstamp"].ToString().Trim()}'"; 
					var crTst = SQL.GetGen2DT(querry);
					if (crTst?.Rows.Count > 0)
					{
						var stock = crTst.Rows[0]["stock"].ToDecimal();
                        var quant = r["Quant"].ToDecimal();
                        if (r.RowState == DataRowState.Modified)
                        {
                            var quant2 = SQL.GetValue($"select quant from {dt.TableName.Trim()} where {dt.TableName.Trim()}stamp ='{filhastamp.Trim()}'").ToDecimal();
                            quant = (quant2 > quant) ? quant2-quant : quant-quant2;  
                        }

						if (stock < quant)
						{
							if (usalote && r["Usalote"].ToBool() && !string.IsNullOrEmpty(r["Lote"].ToString()))
							{
								return (false, $"Desculpe mas o artigo: {r["Descricao"]} lote {r["Lote"]} não tem stock suficiente. \r\n Stock existente: {stock} \r\n Não pode gravar!");
							}
                            if (pos)
                            {
                                var verificar = SQL.GetGen2DT($"select Ccu_Arm.codarm from Ccu_Arm inner join CCu on Ccu_Arm.Ccustamp = CCu.Ccustamp where ccu.Descricao='{ccusto}'");
                                if (!(verificar?.Rows.Count > 0)) continue;
                                var arm = "";
                                for (var i = 0; i < verificar.Rows.Count; i++)
                                {
                                    if (i == 0)
                                    {
                                        arm = $"'{verificar.Rows[i]["codarm"]}'";
                                    }
                                    else
                                    {
                                        arm = arm + $",'{verificar.Rows[i]["codarm"]}'";
                                    }
                                }
                                var xx = $"select top 1 Stock,Codarm,Descricao from Starm where Stock>0 and ltrim(rtrim(Ref))='{r["ref"].ToString().Trim()}' and Starm.codarm in ({arm})";
                                var starm = SQL.GetGen2DT(xx);
                                if (starm?.Rows.Count > 0)
                                {
                                    if (starm.Rows[0]["Stock"].ToDecimal()>r["Quant"].ToDecimal())
                                    {
                                        r["armazem"] = starm.Rows[0]["Codarm"];
                                        r["Descarm"] = starm.Rows[0]["Descricao"];
                                    }
                                    else
                                    {
                                        return (false, $"Desculpe mas o artigo: {r["Descricao"]} não tem stock suficiente. \r\n {starm.Rows[0]["Stock"]} Unidades de stock existente \r\n Não pode gravar!");    
                                    }
                                }
                                else
                                {
                                    return (false, $"Desculpe mas o artigo: {r["Descricao"]} não tem stock suficiente. \r\n {stock} Unidades de stock existente \r\n Não pode gravar!");
                                }
                            }
                            else
                            {
                                return (false, $"Desculpe mas o artigo: {r["Descricao"]} não tem stock suficiente. \r\n {stock} Unidades de stock existente \r\n Não pode gravar!");      
                            }
							
						}
                    }
                    else
                    {
                        return (false, $"Desculpe mas o artigo: {r["Descricao"]} não tem stock.\r\n Não pode gravar!");
                    }
                }
            }
			return (true, "");
		}

        public static (bool StkExiste, string Messagem) CheckStock(DataTable dt)
        {
            foreach (var r in dt.AsEnumerable())
            {
                if (r == null) continue;
                if (r["Servico"].ToBool()) continue;
                if (string.IsNullOrEmpty(r["Ref"].ToString())) continue;
                if (r["Armazem"].ToDecimal() == 0)
                {
                    return (false, "O armazem está vazio. Verifique ");
                }
                var querry = $@"select (Stock-Reserva) as StockPermitido from 
                                Starm where ref='{r["Ref"].ToString().Trim()}' and Codarm={r["Armazem"].ToDecimal()}";//

                var crTst = SQL.GetGen2DT(querry);
                if (!(crTst?.Rows.Count > 0)) continue;
                var stock = crTst.Rows[0]["StockPermitido"].ToDecimal();
                if (stock < r["Quant"].ToDecimal())
                {
                    return (false, $"Desculpe mas o artigo: {r["Descricao"]} não tem stock suficiente. \r\n {stock} Unidades de stock existente \r\n Não pode gravar!");
                }
            }
            return (true, "");
		}
        public static void TotaisLinhas(Factl ftl, bool ivaIncluso = false)
        {
            if (ftl == null) return;
            var ivc = ivaIncluso || ftl.Ivainc;
            decimal valorIva = 0;
            decimal mvalorIva = 0;
            if (ivc)
            {
                valorIva = ftl.Preco - ftl.Preco / (1 + ftl.Txiva / 100);
                ftl.Subtotall = (ftl.Quant * ftl.Preco / (1 + ftl.Txiva / 100)).ToRound();

                mvalorIva = ftl.Mpreco - ftl.Mpreco / (1 + ftl.Txiva / 100);
                ftl.Msubtotall = (ftl.Quant * ftl.Mpreco / (1 + ftl.Txiva / 100)).ToRound();
            }
            else
            {
                ftl.Subtotall = (ftl.Quant * ftl.Preco).ToRound();
                ftl.Msubtotall = (ftl.Quant * ftl.Mpreco).ToRound();
            }
            var subtotal = ftl.Subtotall;
            var msubtotal = ftl.Msubtotall;
            if (ftl.Perdesc > 0)
            {
                if (ivc)
                {
                    ftl.Descontol = ((subtotal - valorIva) * ftl.Perdesc / 100).ToRound();
                    ftl.Mdescontol = ((msubtotal - mvalorIva) * ftl.Perdesc / 100).ToRound();
                    ftl.Subtotall = ftl.Subtotall - ftl.Descontol;
                    ftl.Mdescontol = ftl.Mdescontol - ftl.Mdescontol;
                }
                else
                {
                    ftl.Descontol = (subtotal * ftl.Perdesc / 100).ToRound();
                    ftl.Mdescontol = (msubtotal * ftl.Perdesc / 100).ToRound();
                    ftl.Subtotall = ftl.Subtotall - ftl.Descontol;
                    ftl.Mdescontol = ftl.Mdescontol - ftl.Mdescontol;
                }
            }
            else if (ftl.Descontol > 0)
            {
                if (ivc)
                {
                    ftl.Perdesc = (ftl.Descontol / (subtotal - valorIva).ToDecimal() * 100).ToDecimal().ToRound();
                    ftl.Mdescontol = ((msubtotal - mvalorIva) * ftl.Perdesc / 100).ToRound();
                    ftl.Subtotall = ftl.Subtotall - ftl.Descontol;
                    ftl.Msubtotall = ftl.Msubtotall - ftl.Mdescontol;
                }
                else
                {
                    ftl.Perdesc = (ftl.Descontol / subtotal * 100).ToRound();
                    ftl.Mdescontol = (msubtotal * ftl.Perdesc / 100).ToRound();
                    ftl.Subtotall = ftl.Subtotall - ftl.Descontol;
                    ftl.Msubtotall = ftl.Msubtotall - ftl.Msubtotall;
                }
            }
            ftl.Valival = ((subtotal - ftl.Descontol) * ftl.Txiva / 100).ToRound();
            ftl.Totall = (subtotal - ftl.Descontol + ftl.Valival).ToRound();
            ftl.Mtotall = (msubtotal - ftl.Mdescontol + ftl.Mvalival).ToRound();
        }

        public static void TotaisLinhas(DataRow dr,bool ivaIncluso =false)
		{
            if (dr==null) return;
			if (dr.RowState == DataRowState.Deleted) return;
            var ivc = ivaIncluso || dr["Ivainc"].ToBool();
            decimal valorIva = 0;
            decimal mvalorIva = 0;
            if (ivc)
            {
                valorIva = dr["Preco"].ToDecimal()-dr["Preco"].ToDecimal() / (1 + dr["Txiva"].ToDecimal() / 100);
                dr["Subtotall"] = (dr["Quant"].ToDecimal() * dr["Preco"].ToDecimal() / (1 + dr["Txiva"].ToDecimal() / 100)).ToRound();

                 mvalorIva = dr["mPreco"].ToDecimal()-dr["mPreco"].ToDecimal() / (1 + dr["Txiva"].ToDecimal() / 100);
                dr["mSubtotall"] = (dr["Quant"].ToDecimal() * dr["mPreco"].ToDecimal() / (1 + dr["Txiva"].ToDecimal() / 100)).ToRound();
            }
            else
            {
                dr["Subtotall"] = (dr["Quant"].ToDecimal() * dr["Preco"].ToDecimal()).ToRound();
                dr["mSubtotall"] = (dr["Quant"].ToDecimal() * dr["mPreco"].ToDecimal()).ToRound();
            }
			var subtotal = dr["Subtotall"].ToDecimal();
            var msubtotal = dr["mSubtotall"].ToDecimal();
            if (dr["perdesc"].ToDecimal() >0)
            {
                if (ivc)
                {
                    dr["Descontol"] = ((subtotal-valorIva) * dr["Perdesc"].ToDecimal() / 100).ToRound(); 
                     dr["mDescontol"] = ((msubtotal-mvalorIva) * dr["Perdesc"].ToDecimal() / 100).ToRound(); 
                    dr["Subtotall"]=dr["Subtotall"].ToDecimal()-dr["Descontol"].ToDecimal();
                    dr["mSubtotall"]=dr["mSubtotall"].ToDecimal()-dr["mDescontol"].ToDecimal();
                }
                else
                {
                    dr["Descontol"] = (subtotal * dr["Perdesc"].ToDecimal() / 100).ToRound(); 
                    dr["mDescontol"] = (msubtotal * dr["Perdesc"].ToDecimal() / 100).ToRound();
                    dr["Subtotall"]=dr["Subtotall"].ToDecimal()-dr["Descontol"].ToDecimal();
                    dr["mSubtotall"]=dr["mSubtotall"].ToDecimal()-dr["mDescontol"].ToDecimal();
                }
            }
            else if (dr["Descontol"].ToDecimal() >0)
            {
                if (ivc)
                {
                    dr["Perdesc"]=(dr["Descontol"].ToDecimal()/(subtotal-valorIva).ToDecimal()*100).ToDecimal().ToRound(); 
                    dr["mDescontol"] = ((msubtotal-mvalorIva) * dr["Perdesc"].ToDecimal() / 100).ToRound(); 
                    dr["Subtotall"]=dr["Subtotall"].ToDecimal()-dr["Descontol"].ToDecimal();
                    dr["mSubtotall"]=dr["mSubtotall"].ToDecimal()-dr["mDescontol"].ToDecimal();
                }
                else
                {
                    dr["Perdesc"]=(dr["Descontol"].ToDecimal()/subtotal*100).ToRound(); 
                    dr["mDescontol"] = (msubtotal * dr["Perdesc"].ToDecimal() / 100).ToRound();
                    dr["Subtotall"]=dr["Subtotall"].ToDecimal()-dr["Descontol"].ToDecimal();
                    dr["mSubtotall"]=dr["mSubtotall"].ToDecimal()-dr["mDescontol"].ToDecimal();
                }
            }
            var ivaposdesconto = SQL.GetField("Ivaposdesconto", "param").ToBool();
            if (ivaposdesconto)
            {
                dr["valival"] = ((subtotal-dr["Descontol"].ToDecimal()) * dr["Txiva"].ToDecimal() / 100).ToRound();
                dr["mvalival"] = ((msubtotal-dr["mDescontol"].ToDecimal()) * dr["Txiva"].ToDecimal() / 100).ToRound();
            }
            else
            {
                dr["valival"] = (subtotal * dr["Txiva"].ToDecimal() / 100).ToRound(); 
                dr["mvalival"] = (msubtotal * dr["Txiva"].ToDecimal() / 100).ToRound();
            }
            dr["Totall"] = (subtotal - dr["Descontol"].ToDecimal() + dr["valival"].ToDecimal()).ToRound();
            dr["mTotall"] = (msubtotal - dr["mDescontol"].ToDecimal() + dr["mvalival"].ToDecimal()).ToRound();
		}
        public static void TotaisLinhasItem(DataRow dr)
        {
            if (dr == null) return;
            if (dr.RowState == DataRowState.Deleted) return;
            var quant = dr["Quant"].ToDecimal();
            var preco = dr["Preco"].ToDecimal();
            var txiva = dr["Txiva"].ToDecimal();
            var perdesc = dr["Perdesc"].ToDecimal();
            var ivc = dr["Ivainc"].ToBool();
            dr["Subtotall"] = ivc ? (quant * preco / (1 + txiva / 100), 1) : (quant * preco, 1);
            var subtotal = dr["Subtotall"].ToDecimal();
            dr["Descontol"] = (subtotal * perdesc / 100, 1);
            var descontol = dr["Descontol"].ToDecimal();
            dr["valival"] = ((subtotal - descontol) * txiva / 100, 1);
            var valiva = dr["valival"].ToDecimal();
            dr["Totall"] = (subtotal - descontol + valiva, 1);
        }

        private static PropertyInfo[] _props;
		public static void SetLineValues<T>(DataRow dr, St st, T ent,bool compra,DataRow row,bool nc,string moedavenda,string moedacambio,string Entidadestamp) where T : class
		{
            if (dr==null) return;
            var nomeEntidade = typeof(T).Name;
            _props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StPrecos tmpValor = null;
            var Sempreconamoedadevenda=false;
            if (row == null)
            {
                var drstprecos = SQL.GetRow($"select * from stprecos where ltrim(rtrim(ststamp)) ='{st.Ststamp.Trim()}' and Ccustamp='{Pbl.Usr.Ccustamp.Trim()}' and moeda ='{moedavenda}'");
                if (drstprecos != null)
                {
                    tmpValor = drstprecos.DrToEntity<StPrecos>();
                }
                else
                {
                    var drstpreco = SQL.GetRow($"select * from stprecos where ltrim(rtrim(ststamp)) ='{st.Ststamp.Trim()}' and Ccustamp='{Pbl.Usr.Ccustamp.Trim()}' ");
                    tmpValor = drstpreco.DrToEntity<StPrecos>();
                    Sempreconamoedadevenda=true;
                }              
            }
			decimal valor = 0;
			var vainc = false;
			if (tmpValor != null)
			{
				valor = compra ? tmpValor.PrecoCompra : tmpValor.Preco;
				vainc = tmpValor.Ivainc;
			}
            else
            {
                if (row != null) 
                    valor = row["preco"].ToDecimal();
            }
            if (row == null)
            {
                if (dr["Quant"].ToDecimal()==0)
                {
                    dr["Quant"] = nc ? -1:1;
                }
            }
            else
            {
                dr["Quant"] = row["Quant"].ToDecimal();
            }
            dr["activo"] = st.Activo;
            dr["Ststamp"] = st.Ststamp;
			dr["Perdesc"] = 0;
			dr["Descontol"] = 0;
			dr["Valival"] = 0;
			dr["Descricao"] = st.Descricao.Trim();
			dr["Ref"] = st.Referenc.Trim();
            dr["Refornec"] = st.Refornec.Trim();
            dr["Oristamp"] = st.Ststamp;
			dr["Ivainc"] =vainc;
			dr["Txiva"] = st.Txiva;
			dr["Tabiva"] = st.Tabiva;
            dr["Usaquant2"] = st.Usaquant2;
            dr["codccu"] = Pbl.Usr.Codccu;
			dr["ccusto"] = Pbl.Usr.Ccusto;
            dr["Composto"] = st.Composto;
            
            //dr["Preco"] =valor;
            dr["Entidadestamp"]=Entidadestamp;
            dr["Preco"] = valor;
            var aredondamento=SQL.GetField("Aredondamento","param").ToDecimal();
            if (!moedavenda.ToLower().Equals(Pbl.MoedaBase.ToLower()))
            {
                NewMethod(dr, moedavenda, Sempreconamoedadevenda, valor, aredondamento);
                dr["moeda"] = moedavenda;
                dr["moeda2"] = Pbl.MoedaBase;
            }
            else if (moedacambio.ToLower().Equals(Pbl.MoedaBase.ToLower()))
            {
                NewMethod(dr, moedavenda, Sempreconamoedadevenda, valor, aredondamento);
                dr["moeda"] = moedavenda;
                dr["moeda2"] = Pbl.MoedaBase;
            }
            else if (!moedacambio.ToLower().Equals(Pbl.MoedaBase.ToLower()))
            {
                if (!string.IsNullOrEmpty(moedacambio))
                {
                    NewMethod(dr, moedacambio, Sempreconamoedadevenda, valor, aredondamento);
                    dr["moeda"] = moedavenda;
                    dr["moeda2"] = moedacambio;
                }
            }
            else
            {
                dr["moeda"] =moedavenda;
                dr["moeda2"] ="";
                dr["Cambiousd"] =0;
                dr["Preco"] =valor;
                dr["mpreco"] =0;
            }
            dr["Mvalival"] =0;
            dr["Mdescontol"] =0;
            dr["Msubtotall"] =0;
            dr["Mtotall"] =0;
			dr["Servico"] = st.Servico;
			dr["Unidade"] = st.Unidade;
            var tbname=dr.Table.TableName.ToLower();
            if (tbname.Equals("factl")||tbname.Equals("faccl")||tbname.Equals("dil"))
            {
                dr["Gasoleo"] = st.Gasoleo;
                dr["Numdoc"] = GetValue("numdoc",ent);
                dr["Sigla"] = GetValue("Sigla",ent);
                dr["Tit"] = st.Composto;
                dr["status"] =false;
                dr["Cpoc"] =st.Cpoc.ToDecimal();
            }
			if (st.Servico) return;
            dr["Armazem"] = Pbl.Usr.Codarm;
			dr["descarm"] = Pbl.Usr.Armazem;
            dr["Armazemstamp"] = Pbl.Usr.Armazemstamp;
            var tmpFnc = SQL.GetGen2DT($"select Codigo,Reffnc from StFnc where Ststamp='{st.Ststamp.Trim()}' and Padrao=1");
			if (!(tmpFnc?.Rows.Count > 0)) return;
			if (nomeEntidade.Equals("Facc"))
			{
				dr["Reffornecl"] = tmpFnc.Rows[0]["Reffnc"];
			}
		}

        private static void NewMethod(DataRow dr, string moedavenda, bool Sempreconamoedadevenda, decimal valor, decimal aredondamento)
        {
            var txcambio = SQL.ExecCambio(moedavenda);
            if (!Sempreconamoedadevenda)
            {
                dr["Preco"] = valor;
                if (txcambio > 0)
                {
                    dr["mpreco"] = (valor / txcambio).ToRound();
                }
            }
            else
            {
                dr["Preco"] = (valor * txcambio).ToRound();
                dr["mpreco"] = valor;
            }
            dr["Cambiousd"] = txcambio;
        }

        private static object GetValue<T>(string campo, T ent) where T : class
        {
            object valor = null;
            var p = _props.ToList().FirstOrDefault(x => x.Name.ToLower().Equals(campo.ToLower()));
            if (p!=null)
            {
                valor= p.GetValue(ent, null);
            }

            return valor;
        }
        private static string GetPropName(string campo,string nomeclasse = null)
        {
            if (nomeclasse==null)
            {
                return _props.ToList().FirstOrDefault(x => x.Name.ToLower().Contains(campo.ToLower()) && x.Name.Trim().ToLower().Contains(nomeclasse.ToLower().Trim())).Name;
            }
            return _props.ToList().FirstOrDefault(x => x.Name.ToLower().Contains(campo.ToLower())).Name;
        }

        public static void ArtigoCompost<T>(St tmpFound, DataTable factl, T ent, bool nc =false) where T : class
		{
            var nomeEntidade = typeof(T).Name;
            _props = typeof(T).GetProperties();
			var tmpCp = SQL.GetGenDT(" stcp (nolock) inner join st on st.ststamp=stcp.ststamp ",
				$"where LTRIM(RTRIM(stcp.ststamp))= '{tmpFound.Ststamp.Trim()}'", "*");
			if (tmpCp.Rows.Count == 0) return;
			{
				{
					foreach (var row in tmpCp.AsEnumerable())
					{
						var nMaxOrdem = factl.Rows.Count;
						nMaxOrdem += 1;
						var cStampLinha = Pbl.Stamp();
						var dr2 = factl.NewRow();
						dr2["ordem"] = nMaxOrdem;
						var nome =factl.TableName;
						switch (nome.ToLower())
						{
						   case"factl":
								dr2["Factlstamp"] = cStampLinha;
								break;
								case"dil":
								dr2["dilstamp"] = cStampLinha;
								break;
								case"faccl":
								dr2["Facclstamp"] = cStampLinha;
								break;
						}
                        var stamp = GetPropName("stamp",nomeEntidade);
						dr2[stamp] = GetValue(stamp,ent);
						dr2["Titstamp"] = cStampLinha;
						dr2["ref"] = row["refcp"].ToString().Trim();
						dr2["descricao"] = row["descricao"].ToString().Trim();
						dr2["quant"] =nc? -1*row["quantcp"].ToString().ToDecimal():row["quantcp"].ToString().ToDecimal();
						dr2["Preco"] = row["precocp"].ToDecimal();
						dr2["servico"] = row["servico"].ToBool();
						dr2["Numdoc"] =GetValue("Numdoc",ent);
						dr2["Sigla"] = GetValue("Sigla",ent);
                        dr2["Oristamp"] = tmpFound.Ststamp;
			            dr2["Ivainc"] =row["Ivainc"].ToBool();;
			            dr2["Txiva"] = tmpFound.Txiva;
			            dr2["Tabiva"] = tmpFound.Tabiva;
                        dr2["codccu"] = Pbl.Usr.Codccu;
			            dr2["ccusto"] = Pbl.Usr.Ccusto;//ststamp
                        dr2["ststamp"] = row["Oristamp"].ToString().Trim();
                        dr2["Mvalival"] =0;
                        dr2["Mdescontol"] =0;
                        dr2["Msubtotall"] =0;
                        dr2["Mtotall"] =0;
			            if (!row["servico"].ToBool())
                        {
                            dr2["Armazem"] = Pbl.Usr.Codarm;
			                dr2["descarm"] = Pbl.Usr.Armazem;
                            dr2["Armazemstamp"] = Pbl.Usr.Armazemstamp;
                        }
						TotaisLinhas(dr2);
						factl.Rows.Add(dr2);
					}
					tmpCp.Dispose();
				}
			}
			//*----------------
		}
		public static (bool Correcto, string Messagem) CheckSaldo(DataTable formaspdt)
		{
			(bool Correcto, string Messagem) vals = (false, "Deve inserir a tesouraria!");
			if (formaspdt == null) return vals;
			var val = formaspdt.AsEnumerable().Sum(x => x.Field<decimal>("Valor")).ToDecimal();
			foreach (var r in formaspdt.AsEnumerable())
			{
				if (r == null) continue;
                var contasstamp = r["Contasstamp"].ToString().Trim();
                var conta = r["Contatesoura"].ToString();
				var dt = SQL.GetGen2DT($"select saldo,Noneg from contas where ltrim(rtrim(Contasstamp))='{contasstamp}'");
				if (dt?.Rows.Count == 0) continue;
                var saldo = dt.Rows[0]["saldo"].ToDecimal();
                if (saldo < val)
                {
                    if (dt.Rows[0]["Noneg"].ToBool())
                    {
                        vals.Correcto = false;
                        vals.Messagem = $"A conta {conta} não tem saldo suficiente! \r\n Saldo disponínel é: {saldo} meticais! ";
                        return vals;
                    }
                }
                vals.Correcto = true;
                vals.Messagem = "";
            }
            return vals;
		}
        public static DataTable ClCc2(string no)
        {            
            var dt = SQL.GetGen2DT($"select * from Clccf() where Clstamp='{no}' order by Convert(decimal,nrdoc) asc,Convert(date,data)");
            return dt;
        }
		public static DataTable PosCc()
        {
            string qry;
            string addcond="";
            if (Pbl.Usr.Supervisor)
            {
                addcond = "" ;
            }
            else
            {
                if (Pbl.Usr.Tipousr==1)
                {
                    addcond = "";
                }
                if (Pbl.Usr.Tipousr==2)
                {
                    addcond = $"and Usrstamp='{Pbl.Usr.Usrstamp.Trim()}'";
                }
            }
            //qry = $@"select nome,debito,cc.ccstamp,Factstamp,no,Clstamp,Usrstamp from  cc  where (select pos from cl where Clstamp=cc.Clstamp)=1  and debito-debitof>0 {addcond} order by nrdoc";
            qry = $@"select nome,valorpreg as debito,ccstamp,ccstamp as Factstamp,no,Clstamp,Usrstamp,nrdoc from ClCCF() where pos=1 {addcond} order by nrdoc ";
            return SQL.GetGen2DT(qry);
		}
		public static decimal MesaValor(decimal no)
		{
			 decimal valor = 0;
			 var qry = $@"select debito from  cc left join rcll on 
						cc.ccstamp = rcll.ccstamp where no ={no} 
						and cc.origem in ('FT') and debito-debitof>0 order by no";
			 var dt = SQL.GetGen2DT(qry);
			 if (dt?.Rows.Count>0)
			 {
				 valor = dt.Rows[0]["debito"].ToDecimal();
			 }
			 return valor;
		}
		public static DataTable ExtratoProduto(string dData1, string dData2, string chkArmazem,string referec)
		{
            var qry =$"select * from STExtrato('{referec}','{dData1}','{dData2}') where saldo<>0  {chkArmazem} order by ordem, dataordem ";
			return SQL.GetGen2DT(qry);
		}
        public static DataTable ExtratoProdutoFam(DateTime dData1, DateTime dData2, string familia)
        {
           var qry = $@"SELECT iif(year(data2)='1900',CONVERT(char(12), 0, 104),CONVERT(char(12), data2, 104)) as data,ref,descricao,descmovstk,nrdoc,entrada,saida,saldo from (
	                SELECT *,sum(entrada-saida) over(PARTITION BY ref  order by tmp2.data2 rows unbounded preceding) as saldo,Familia=(SELECT top 1 dbo.st.Familia FROM st WHERE Referenc =tmp2.ref) FROM (
	                select * from (
		                Select 0 as data2,ref,descricao,descmovstk='Saldo Alterior',nrdoc=0,isnull(SUM(entrada),0) entrada,isnull(SUM(saida),0) saida,ordem=1 from mstk where CONVERT(date, data) < '{dData1.Date.ToSqlDate()}' GROUP BY ref,descricao
		                union ALL
		                Select data as data2,ref,descricao,descmovstk,nrdoc,entrada,saida,ordem=2  from mstk	where CONVERT(date, data) >= '{dData1.Date.ToSqlDate()}' and CONVERT(date, data)<='{dData2.Date.ToSqlDate()}'
	                )tmp1)tmp2)tmp3 where  tmp3.Familia ='{familia}' ORDER BY tmp3.Ref,tmp3.ordem";

            return SQL.GetGen2DT(qry);
        }
		public static DataTable DiTrf(string distamp)
		{
			var qry = $@"select Referenc =ref,Descricao,Quant,totall as Valor,
                        Convert(varchar,di.data,103) as Data,di.descarm as Saida,descarm2 as Entrada,Nome,numero,Ccusto
                        from di join dil on di.Distamp=dil.Distamp where trf=1 and di.Distamp='{distamp.Trim()}'";
			return SQL.GetGen2DT(qry);
		}
		public static DataTable DiMstk(string distamp)
		{
			var qry = $@"select Ref,descricao,quant=IIF( Entrada=0, Saida,Entrada),
						data=Convert(varchar,data,103),Nome,
						Armazem=(select descricao from Armazem where Codigo=Codarm),
						Ccusto=(select Ccusto from di where Distamp=Mstk.Distamp),Nrdoc as numero,Documento
						from Mstk where Origem='DI' and distamp='{distamp.Trim()}'";

			return SQL.GetGen2DT(qry);
		}
		public static DataTable DiMvt(string distamp)
		{
			var qry = $@"mvt.Titulo,Local,Dcheque,valor =iif(Entrada=0,Saida,entrada),mvt.Banco,Nrdoc,Ccusto,Distamp,
						 Numero from mvt join Formasp on mvt.Formaspstamp=formasp.Formaspstamp 
						 where mvt.Origem='DI' and Distamp='{distamp.Trim()}'";
			return SQL.GetGen2DT(qry);
		}
		public static Caixa GetCaixa(DateTime data,string Usrstamp)
		{
            // and Convert(date,Data)='{data.ToSqlDate()}' order by numero
            return SQL.GetRowToEnt<Caixa>($@"fechado = 0 and Usrstamp='{Usrstamp.Trim()}'");
        }
        public static DataTable PrintCaixa( DateTime dDatCaixa,decimal nNumCaixa)
        {
            var qry = $@"SELECT grupo,ordem,consumo,ref,descricao,SUM(quant) Qtt,Preco,perdesc,SUM(totall) Totall FROM (
 	                         Select grupo=1,ordem=0,consumo='',ref='',descricao='Saldo Inicial',quant=0,Preco=0,perdesc=0,totall=inicial
 	                          from Caixa where data='{dDatCaixa.ToSqlDate()}' and numero={nNumCaixa}
	                          union all 
	                        Select grupo=1,ordem=1,consumo='Normal',Factl.ref,Factl.descricao,Factl.quant,Factl.Preco,factl.perdesc,Factl.totall
 	                         from factl inner join (Select ccstamp from RCLL inner join mvt on rcll.rclstamp=mvt.rclstamp 
 	                        where mvt.datcaixa='{dDatCaixa.ToSqlDate()}' and mvt.numcaixa={nNumCaixa}) tmp1 on Factl.Factstamp=tmp1.ccstamp and factl.perdesc=0
	                        union all
	                        Select grupo=1,ordem=2,consumo='Com Desconto',Factl.ref,Factl.descricao,Factl.quant,Factl.Preco,factl.perdesc,Factl.totall
 	                         from factl inner join (Select ccstamp from RCLL inner join mvt on rcll.rclstamp=mvt.rclstamp 
 	                        where mvt.datcaixa='{dDatCaixa.ToSqlDate()}' and mvt.numcaixa={nNumCaixa})tmp1
 	                         on Factl.Factstamp=tmp1.ccstamp and factl.perdesc between 1 and 99
	                        union all  
	                        Select grupo=1,ordem=3,consumo='Consumo Interno',Factl.ref,Factl.descricao,Factl.quant,Preco=0,factl.perdesc,totall=0
 	                         from factl inner join (Select ccstamp from RCLL inner join mvt on rcll.rclstamp=mvt.rclstamp 
 	                        where mvt.datcaixa='{dDatCaixa.ToSqlDate()}' and mvt.numcaixa={nNumCaixa})tmp1
 	                         on Factl.Factstamp=tmp1.ccstamp and factl.perdesc=100
	                         union all
	                         select grupo=1,ordem=4,consumo='Saidas',ref='',descricao,quant=0,Preco=0,perdesc=0,totall=(saida*-1)
	                         from mvt where saida<>0 and mvt.datcaixa='{dDatCaixa.ToSqlDate()}' and mvt.numcaixa={nNumCaixa}
	                         union all
	                         select grupo=2,ordem=5,consumo='',ref='',descricao='',quant=0,Preco=0,perdesc=0,totall=0
                             union all
	                         select grupo=2,ordem=6,consumo='',ref='',descricao='',quant=0,Preco=0,perdesc=0,totall=0
	                         union all
	                         select grupo=2,ordem=7,consumo='Formas de Pagamento',ref='',ftpagar.descricao,quant=0,Preco=0,perdesc=0, totall=SUM(ftpagar.valor2)
	                         from mvt inner join ftpagar on mvt.rclstamp=ftpagar.rclstamp 
	                         where mvt.datcaixa='{dDatCaixa.ToSqlDate()}' and mvt.numcaixa={nNumCaixa} and ftpagar.valor <> 0 
	                         group by ftpagar.descricao	 	 
 	                        )tmp1 group by consumo,ref,descricao,Preco,perdesc,grupo,ordem order by grupo,ordem";
            return SQL.GetGen2DT(qry);
        }
        public static DataTable PrintPos(string factstamp,decimal no)
        {
            var querry = $@"Select fact.Nomedoc,Fact.data,fact.sigla,Fact.NO,Fact.dataven,fact.nome,fact.Morada,fact.nuit,fact.Moeda,fact.subtotal,
			    fact.totaliva,fact.total,fact.perdesc,fact.obs,Factl.Preco,Factl.perdesc as Perdescl,factl.unidade,factl.subtotall,factl.totall,
			    factl.quant,factl.descricao,factl.ref,factl.txiva,factl.valival,factl.composto, fact.Anulado,fact.numero,fact.coment,fact.desconto,
			    factl.tit,factl.ivainc from Fact left join Factl on Fact.factstamp = Factl.factstamp WHERE
                    Fact.mesa={no} and Fact.factstamp ='{factstamp}'
                 Order By Fact.numero,Factl.Ordem";
            return SQL.GetGen2DT(querry);
        }

        public static void ExecAudit<T>(T ft, string name,bool origem=false) where T: class
        { 
            _props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var usr = new UsrAudit {UsrAuditstamp = Pbl.Stamp(), Usrstamp = Pbl.Usr.Usrstamp, FormName = name};
            var prop = GetPropName("stamp", typeof(T).Name);
          usr.Oristamp = GetValue(prop,ft).ToString();
          usr.DataAdd = Pbl.SqlDate;
          usr.DataUpd = Pbl.SqlDate;
          if (!origem)
          {
              usr.DocSigla= GetValue("sigla", ft)==null?"":GetValue("sigla",ft).ToString();
              usr.DocNumero=GetValue("numero",ft).ToDecimal();
              usr.DocName=GetValue("nome",ft).ToString();
              usr.Coment =GetValue("total",ft).ToString();
          }
          else
          {
              if (ft.GetType().Name.Equals("Lcont"))
              {
                  usr.DocSigla="Lcont";
                  usr.DocNumero=GetValue("Dilno",ft).ToDecimal();
                  usr.DocName=GetValue("Dinome",ft).ToString();
                  usr.Coment =$"Dédibo:{GetValue("Debfin",ft)} Crédito:{GetValue("Crefin",ft)}";
              }

              if (ft.GetType().Name.Equals("Pgc"))
              {
                  usr.DocSigla="Pgc";
                  usr.DocNumero=GetValue("conta",ft).ToDecimal();
                  usr.DocName=GetValue("descricao",ft).ToString();
                  usr.Coment ="";
              }
          }
          EF.Save(usr);
        }

        public static DataTable GetCc(string stamp, string nomeFuncao,string tabela)
        {
            var dt = SQL.GetGenDT($"select * from {nomeFuncao.Trim()}() where {tabela.Trim()}stamp='{stamp.Trim()}'  order by origem,nrdoc");
            return dt;
        }
        public static DataTable PeCc(decimal no,string cMoedaBase)
        {
            var lista = new List<SqlParameter>();
            var moeda = new SqlParameter("@cMoedaBase", SqlDbType.Char) {Value = cMoedaBase};
            lista.Add(moeda);
            var p = new SqlParameter("@no", SqlDbType.Int) {Value = no};
            lista.Add(p);
            return SQL.SqlSP("GetPeCC",lista);
        }
        public static Moedas GetDefaultMoeda()
        {
            return SQL.GetRowToEnt<Moedas>(" princip = 1 ");// EF.QEnt<Moedas>(" princip = 1 ");
        }
        public static DataTable GetContas(string usrstamp)
        {
            var str = $@"select descpos as Descricao,Cast(0 as decimal) as valor,conta, cx,conta as contas,Contasstamp,Codtz,Titulo =iif(cx=1,'NUMERARIO','TRANSF. BANCARIA') from Usrcontas where Usrstamp='{usrstamp.Trim()}' order by cx desc ";
            return SQL.GetGen2DT(str);
        }
        public static string GetArmazem()
        {
            var verificar = SQL.GetGen2DT($"select Ccu_Arm.Armazemstamp from Ccu_Arm inner join CCu on Ccu_Arm.Ccustamp = CCu.Ccustamp where ccu.Ccustamp='{Pbl.Usr.Ccustamp}'");
            if (!(verificar?.Rows.Count > 0)) return "";
            var arm = "";
            for (var i=0; i < verificar.Rows.Count; i++)
            {
                if (i == 0)
                {
                    arm = $"'{verificar.Rows[i]["Armazemstamp"]}'";
                }
                else {
                    arm =arm + $",'{verificar.Rows[i]["Armazemstamp"]}'";
                }
            }
            return arm;
        }
        public static DataTable CambiaLinhas(DataTable dt,decimal TaxaCambio,string MoedaCambio,string Moeda)
        {
            foreach (var dr in dt.AsEnumerable())
            {
                if (TaxaCambio>0)
                {
                    dr["mpreco"] =(dr["Preco"].ToDecimal()/TaxaCambio).ToRound();
                }                
                dr["moeda"] =Moeda;
                dr["moeda2"] =MoedaCambio;
                dr["Cambiousd"] =TaxaCambio;
                TotaisLinhas(dr);
            }
            return dt;            
        }
    }
}
