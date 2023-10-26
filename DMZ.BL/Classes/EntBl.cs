using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DMZ.BL.Classes
{
    public static class EntBl
    {
        //Esta classe contem os metodos de negocios:
        //clientes, fornecedores e entidades, RH
        #region Extrato de conta corrente de cliente e fornecedor  
        public static DataTable GetExtrato(string clstamp,DateTime dData1, DateTime dData2,string moeda, string ccTabela,string rclTabela)
        {
            //string condicao ="";
            //if (!string.IsNullOrEmpty(moeda))
            //{
            //    if (!moeda.Equals(Pbl.MoedaBase))
            //    {
            //        condicao=$" and cc.moeda ='{moeda}'";
            //    }             
            //}
            //condicao=condicao.
            //if (!string.IsNullOrEmpty(condicao))
            //{
            //    condicao= $" where {condicao} ";
            //}
            var str =$"select * from ClExtrato() ";
   //         var str =$@"Select *, sum(credito-debito) over(order by documento,nrdoc  rows unbounded preceding) as saldo from (
			//Select documento,{ccTabela}.nrdoc,{ccTabela}.numinterno,{ccTabela}.data,vencim,{ccTabela}.moeda,
			//debito=iif('{moeda}'=dbo.Moedanacional(),debito,debitom),credito=iif('{moeda}'=dbo.Moedanacional(),credito,creditom),{ccTabela}.{ccTabela}stamp,{ccTabela}.origem,oristamp,-2 AS Ordem,{ccTabela}.data as data1,no
			//from {ccTabela} left join {rclTabela} on {ccTabela}.{ccTabela}stamp = {rclTabela}.{ccTabela}stamp where no ='{no}'  AND CONVERT(date, {ccTabela}.data)>='{dData1.ToSqlDate()}' AND CONVERT(date, {ccTabela}.data)<='{dData2.ToSqlDate()}' {condicao}
			//group by documento,{ccTabela}.nrdoc,{ccTabela}.data,{ccTabela}.{ccTabela}stamp,{ccTabela}.data,{ccTabela}.credito, {ccTabela}.debito,{ccTabela}.creditom,{ccTabela}.debitom,{ccTabela}.moeda,{ccTabela}.origem,oristamp,{ccTabela}.numinterno,{ccTabela}.Moeda,{ccTabela}.vencim,{ccTabela}.no
			//	)tmp3 where debito -credito <>0 order by documento,nrdoc";

   //                     var str =$@"Select *, sum(credito-debito) over(order by documento,nrdoc  rows unbounded preceding) as saldo from (
			//Select documento,cc.nrdoc,cc.numinterno,cc.data,vencim,cc.moeda,
			//debito=iif(moeda=dbo.Moedanacional(),debito,debitom),credito=iif(moeda=dbo.Moedanacional(),credito,creditom),cc.ccstamp,cc.origem,oristamp,-2 AS Ordem,cc.data as data1,no
			//from cc left joinrcl on cc.ccstamp = rcll.ccstamp where no ='{no}'  AND CONVERT(date, cc.data)>='{dData1.ToSqlDate()}' AND CONVERT(date, {ccTabela}.data)<='{dData2.ToSqlDate()}' {condicao}
			//group by documento,cc.nrdoc,cc.data,cc.ccstamp,cc.data,cc.credito,cc.debito,cc.creditom,cc.debitom,cc.moeda,cc.origem,oristamp,cc.numinterno,cc.Moeda,cc.vencim,cc.no
			//	)tmp3 where debito -credito <>0 order by documento,nrdoc";
            return SQL.GetGen2DT(str);
        }
        public static DataTable GetExtrato(string no,string moeda,string condicao,bool cl,string siglas)
        {
            DataTable dt = null;
            if (cl)
            {
                var str=$@"Select *,pendente=isnull((debito-credito),0),numero=isnull((SELECT STUFF((SELECT ',' +  
                             ltrim(rtrim(Convert(char,Numero)))  from rcll join rcl on rcl.Rclstamp = rcll.Rclstamp where Ccstamp =tmp3.ccstamp order by numero
                            FOR XML PATH('')), 1, 1,'')),'') 
                            from ( Select documento =documento+' '+Convert(char,cc.nrdoc),cc.nrdoc,cc.data,cc.vencim,cc.moeda,
		                            debito=iif('{moeda}'=dbo.MoedaNacional(),debito,debitom),credito =iif('{moeda}'=dbo.MoedaNacional(),sum(isnull(RCLL.Valorreg,0)),sum(isnull(RCLL.mValorreg,0))),DATEDIFF(day,cc.data,getdate()) as Dias,cc.ccstamp,cc.origem,oristamp
		                            from cc left join rcll on cc.ccstamp = rcll.ccstamp where no ='{no}' and cc.origem in ({siglas}) 
		                            group by documento,cc.nrdoc,cc.data,cc.ccstamp,cc.data,cc.credito,cc.debito,cc.creditom,cc.debitom,cc.moeda,oristamp,cc.Moeda,cc.vencim,cc.origem
			                            )tmp3 where isnull((debito-credito),0)<> 0 {condicao} order by nrdoc";
                //return SQL.SqlSP("GetClCCFT", lista);
                dt= SQL.GetGen2DT(str);  
            }
            else
            {
                //return SQL.SqlSP("GetFncCCFT", lista);
            }
            return dt;
        }
        #endregion

        public static DataTable GetProdutosVendidos(decimal no, DateTime dData1, DateTime dData2)
        {
            var lista = new List<SqlParameter>();
            var _dData1 = new SqlParameter("@data1", SqlDbType.DateTime) {Value = dData1};
            lista.Add(_dData1);
            var _dData2 = new SqlParameter("@data2", SqlDbType.DateTime) {Value = dData2};
            lista.Add(_dData2);
            var p = new SqlParameter("@no", SqlDbType.Int) {Value = no};
            lista.Add(p);
            return SQL.SqlSP("GetClProdutoVendidos", lista);
        }

        public static DataTable GetProdVend(string dData1, string dData2,string cond,string origem)
        {
            var qry =string.Format(SQL.GetValue($"select querry from rltsql where origem ='{origem}'"),dData1,dData2,cond);
            return SQL.GetGen2DT(qry);
        }
    }
}
