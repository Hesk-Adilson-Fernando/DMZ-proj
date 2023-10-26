namespace DMZ.BL.Classes
{
    public class BlExec
    {
        public static decimal SaldoMvt(int codconta)
        {
            decimal reDecimal = 0;
            var qry = $@"update contas set saldo=tmp2.saldo,saldor=tmp2.saldor from (
		                    Select isnull(SUM(saldo),0) as saldo,isnull(SUM(saldor),0) as saldor,codlocal from (		
			                    select saldo=0,saldor=0,codlocal={codconta}
			                    union all 
			                    SELECT Saldo=isnull(SUM(entrada-saida),0),
			                    saldor=(Case when reconc=1 then isnull(SUM(entrada-saida),0) else 0 end),
			                    codlocal FROM mvt where codlocal={codconta} group by codlocal,reconc
		                    )tmp1 group by 	codlocal
	                    )tmp2 inner join contas on contas.codigo=tmp2.codlocal";
            var dt = SQL.GetGen2DT(qry);

            return reDecimal;
        }
    }
}
