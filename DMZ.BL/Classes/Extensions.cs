using System;
using System.Globalization;

namespace DMZ.BL.Classes
{
    public static class Extensions
    {
        public static decimal ToRound(this decimal valor)
        {
            return Pbl.Param.Naoaredonda ? ToTruncate(valor) : Math.Round(valor, (int)Pbl.Param.Aredondamento);
        }
        public static decimal ToTruncate(this decimal valor)
        {
            return valor.ToString("0.00").ToDecimal();
        }
        public static int ToInt(this decimal valor)
        {
            return valor>0 ? valor.ToString(CultureInfo.InvariantCulture).ToInt32() : 0;
        }
        public static decimal ToRound(this decimal valor,int casas)
        {
            return Math.Round(valor,casas);
        }
        public static int ToInt(this string str) => CToI(str);
        public static decimal ToDecimal(this string str) => CToD(str);//ToMask()
        public static string ToMask(this decimal str) => str.ToString("N2");
        public static decimal ToDecimal(this object str) => CToD(str);
        public static int ToInt(this object str) => CToI(str.ToString());
        public static DateTime ToDateTimeValue(this object str)
        {
            DateTime saida;
            try
            {
                saida = Convert.ToDateTime(str);
            }
            catch (Exception)
            {
                saida = new DateTime(1900, 1, 1);
            }
            return saida;
        }
        public static int ToInt32(this string txt)
        {
            var saida = 0;
            if (!string.IsNullOrEmpty(txt))
            {
                int.TryParse(txt, out saida);
            }
            return saida;
        }
        public static int ToInt(this bool valor) => valor ? 1:0;

        public static bool   ToBool(this object str)
        {
            bool saida;
            if (str==null)
            {
                saida = false;
            }
            else
            {
                bool.TryParse(str.ToString(), out saida);
            }
            
            return saida;
        }

        public static string SetMask( this string txt)
        {
            var valor = CToD(txt);
            var formatedString = $"{valor:#,###,###,###,###,0.00}";
            if (formatedString == "0.00")
            {
                formatedString = "";
            }
            return formatedString;
        }
        public static decimal CToD(object obj)
        {
            decimal saida;
            if (obj !=null)
            {
                decimal.TryParse(obj.ToString(), out saida);
            }
            else
            {
                saida = 0;     
            }
            return saida;
        }

        public static int CToI(string txt)
        {
            int saida = 0;
            if (!string.IsNullOrEmpty(txt))
            {
                int.TryParse(txt, out saida);
            }
            return saida;
        }

        public static bool ToBool( this string txt)
        {
            var saida = false;
            if (!string.IsNullOrEmpty(txt))
            {
                bool.TryParse(txt, out saida);
            }
            return saida;
        }

        public static double ToDouble(this string txt)
        {
            double saida = 0;
            if (!string.IsNullOrEmpty(txt))
            {
                double.TryParse(txt, out saida);
            }
            return saida;
        }
    }
}
