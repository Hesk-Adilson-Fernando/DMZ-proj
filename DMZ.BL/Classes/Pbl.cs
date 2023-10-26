
using DMZ.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;

namespace DMZ.BL.Classes
{
    public static class Pbl
     {
        #region Região de Definição de Propriedades Públicas 
        public static string Keys { get; set; } = "MAKV2SPBNI99212DMZ18356Hoje";
        public static string Encrypta(string encodeMe)
        {
            encodeMe = Keys + encodeMe;
            byte[] encoded = Encoding.UTF8.GetBytes(encodeMe);
            return Convert.ToBase64String(encoded);
        }
        public static string Decrypta(string decodeMe)
        {
            if (string.IsNullOrEmpty(decodeMe))
            {
                decodeMe = "10sdmz";
            }
            byte[] encoded = Convert.FromBase64String(decodeMe);
            var getter = Encoding.UTF8.GetString(encoded).Replace(Keys, "");
            return getter;
        }
        public static DateTime DataContabil() => new DateTime((int)Param.Ano,SqlDate.Month,SqlDate.Day);
        public static string ToSqlDate(this DateTime value)
        {
            var sqldata = value.ToString("yyyy-MM-dd");
            return sqldata.Trim();//2019-05-01
        }
        public static string ToSqlDate104(this DateTime value)
        {
            var sqldata = value.ToString("dd.MM.yyyy");
            return sqldata.Trim();
        }
        public static DateTime LastDayOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
        }
        #endregion
        public static string Info2 = "DMZ SOFTWARE 2023";
        public static string Info = "DMZ Software v.2023";

        public static bool MYSQLMode;
        public static string Stamp(string origem = "DMZ")
        {
            Thread.Sleep(10);
            var moment = DateTime.Now;
            // Year gets 1999.
            var year = moment.Year;
            // Month gets 1 (January).
            var month = moment.Month;
            // Day gets 13.
            var day = moment.Day;
            // Hour gets 3.
            var hour = moment.Hour;
            // Minute gets 57.
            var minute = moment.Minute;
            // Second gets 32.
            var second = moment.Second;
            // Millisecond gets 11.
            var millisecond = moment.Millisecond;

            var stamp = millisecond + "D" + year + month + origem + day + hour + minute + second;
            return stamp;
        }

        public static string Rdlcstamp()
        {
            Thread.Sleep(10);
            var moment = DateTime.Now;
            // Year gets 1999.
            var year = moment.Year;
            // Month gets 1 (January).
            var month = moment.Month;
            // Day gets 13.
            var day = moment.Day;
            // Second gets 32.
            var second = moment.Second;
            // Millisecond gets 11.
            var millisecond = moment.Millisecond;

            var stamp = millisecond + "" + year + month + day + second;
            return stamp;
        }
        public static DateTime SqlDate { get; set; }
        public static Empresa Empresa { get; set; }
        public static string MoedaBase { get; set; }
        public static bool CtExpirado { get; set; }
        //public static bool GesExpirado { get; set; } 
        public static bool RhsExpirado { get; set; } 
        public static string VersaoActivo { get; set; }
        public static decimal URh { get; set; }
        public static decimal UCt { get; set; }
        public static decimal UGes { get; set; }
        public static Usr Usr { get; set; }
        public static List<Usracessos> Usracessos { get; set; }
        public static Param Param { get; set; }
        public static Cl CL { get; set; }
        public static CCu CCu { get; set; }
        public static DataTable DtContas { get; set; }
        public static DataTable Impressoras { get; set; }
        public static DataTable DtTirps { get; set; }
        public static DataTable ContasEmpresa { get; set; }
        public static bool Academia { get; set; }
        public static DataTable PlanoAvaliacao { get; set; }
        public static string MyPathName { get; set; }
        public static UsrlogSect UsrlogSect { get; internal set; }

        public static decimal AnoContabil()
        {
            return SQL.GetValue("select ano from param").ToDecimal();
        }
        public static DateTime GetDate(int i)
        {
            var dt = SqlDate.AddDays(i);
            return dt; 
        }
        public static DateTime PrevMonthData()
        {
            var mes = 1;
            if (SqlDate.Month > 1)
            {
                mes = SqlDate.Month-1;
            }
            var diasMesAnterior = DateTime.DaysInMonth(SqlDate.Year, mes);
            var diasMesActual = DateTime.DaysInMonth(SqlDate.Year, SqlDate.Month);
            var dia = diasMesAnterior < diasMesActual ? 28 : SqlDate.Day;
            var dt = new DateTime(SqlDate.Year, mes, dia);
            return dt;
        }

        public static void FillContasEmpresa()
        {
            var cond = "";
            if (!Param.MostraTodasContas)
            {
                cond = $" and Ccustamp ='{Usr.Ccustamp.Trim()}'";
            }
            ContasEmpresa = SQL.GetGen2DT($"select Banco,Numero,nib,Iban,Moeda,swift from contas where VernaFactura=1 {cond}");
        }
    }
}
