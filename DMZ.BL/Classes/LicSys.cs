using System;

namespace DMZ.BL.Classes
{
    public static class LicSys
    {
        public static Tuple<bool, string> CheckDate(string ctTabela, decimal nLimitacao,string ctCondicao,string ctCampo,DateTime chkDiaCompara)
        {

            if (nLimitacao !=0)
            {
                var cSelect = $@"select Count({ctCampo}) as Count from {ctTabela} where {ctCondicao}";
                var dt = SQL.GetGenDT(cSelect);
                if (dt?.Rows.Count>0)
                {
                    if (dt.Rows[0]["Count"].ToDecimal()>=nLimitacao)
                    {
                        var cExpLicDemo ="ATENÇÃO:  \r\n Atingiu limite Máximo de registos permetidos na versão Demonstrção. \r\n Por favor contacte o seu vendedor para adquirir a Licença definitiva.";
                        return Tuple.Create(false, cExpLicDemo);
                    } 
                }
            }
            else
            {
  
            }
            return Tuple.Create(false, "");
        }
    }
}
