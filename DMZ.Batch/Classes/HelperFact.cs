using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.Batch.Classes
{
    public static class HelperFact
    {
        public static void SetDefaultValues(Fact _ft,Tdoc TmpTdoc)
        {
            _ft.Nc = TmpTdoc.Nc;
            _ft.Vd = TmpTdoc.Vd;
            _ft.Nd = TmpTdoc.Nd;
            _ft.Ft = TmpTdoc.Ft;
            _ft.Sigla = TmpTdoc.Sigla;
            _ft.Tdocstamp = TmpTdoc.Tdocstamp;
            _ft.Numdoc = TmpTdoc.Numdoc;
            _ft.Nomedoc = TmpTdoc.Descricao;
            _ft.Movtz = TmpTdoc.Movtz;
            _ft.Movstk = TmpTdoc.Movstk;
            _ft.Descmovstk = TmpTdoc.Descmovstk;
            _ft.Codmovstk = TmpTdoc.Codmovstk;
            _ft.Movcc = TmpTdoc.Movcc;
            _ft.Descmovcc = TmpTdoc.Descmovcc;
            _ft.Codmovcc = TmpTdoc.Codmovcc;
            _ft.Moeda = Pbl.MoedaBase;
            _ft.Ccusto = Pbl.Usr.Ccusto;
            _ft.Usrstamp = Pbl.Usr.Usrstamp;
            _ft.Inscricao = TmpTdoc.Inscricao;
        }
        public static void FillFactura(Fact _ft, Cl cl, DateTime data,Tdoc TmpTdoc,DataRowView Dtv2, DataRowView Dtv,string Numinterno)
        {
            _ft.Usrstamp = Pbl.Usr.Usrstamp;
            _ft.Inscricao = TmpTdoc.Inscricao;
            _ft.Clstamp = cl.Clstamp;
            _ft.Morada = cl.Morada;
            _ft.Data = Pbl.SqlDate;
            _ft.Dataven =data;
            _ft.Localidade2 = cl.Localidade;
            _ft.Nuit = cl.Nuit;
            _ft.Nome = cl.Nome;
            _ft.No = cl.No;
            _ft.Entidadebanc = Dtv2["Entidadebanc"].ToString();
            _ft.Campo1 = Dtv2["Contasstamp"].ToString();
            var max = SQL.VMax("fact", TmpTdoc.Numdoc, _ft.Data.Year);
            _ft.Numero = max.ToString();
            _ft.Numinterno = Numinterno;
            _ft.Referencia = cl.No.Trim() + Helper.GetReferencia(max.ToString());
            if (Dtv !=null)
            {
                _ft.Turmastamp = Dtv["Turmastamp"].ToString().Trim();
                _ft.Descturma = Dtv["Codigo"].ToString().Trim();
                _ft.Cursostamp = Dtv["Cursostamp"].ToString().Trim();
                _ft.Desccurso = Dtv["Descurso"].ToString().Trim();
                _ft.Anosem = Dtv["Descanoaem"].ToString().Trim();
                _ft.Etapa = Dtv["Etapa"].ToString().Trim(); 
            }
            SetDefaultValues(_ft, TmpTdoc);
        }
        public static void TotaisFt(Fact ft, DataTable Factl)
        {
            if (ft!=null)
            {
                var tbDesconto = Factl.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("Descontol")).ToString().SetMask();
                var tbSubTotal = Factl.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("Subtotall")).ToString().SetMask();
                var total = Math.Round(Factl.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal>("Totall")), 0).ToString().SetMask();
                var tbTotalIva = Factl.AsEnumerable().Where(k => k.RowState != DataRowState.Deleted).Sum(x => x.Field<decimal?>("valival")).ToString().SetMask();
                ft.Desconto = tbDesconto.ToDecimal();
                ft.Subtotal = tbSubTotal.ToDecimal();
                ft.Totaliva = tbTotalIva.ToDecimal();
                ft.Total = total.ToDecimal();
            }
        }
        internal static void FillFactl(DataRow item, DataRow dr,string Factstamp)
        {
            dr["Factstamp"] = Factstamp;
            dr["quant"] = 1;
            dr["codccu"] = Pbl.Usr.Codccu;
            dr["ccusto"] = Pbl.Usr.Ccusto;
            dr["Txiva"] = 0;
            dr["Tabiva"] = 1;
            dr["moeda"] = Pbl.MoedaBase;
            dr["Servico"] = true;
            if (item != null)
            {
                dr["Ststamp"] = item["Planopagpstamp"];
                dr["descricao"] = item["descricao"];
                dr["ref"] = $"P{item["Parecela"].ToInt()}";
                dr["Preco"] = item["ValorTotal"];
            }
            GenBl.TotaisLinhas(dr);
        }
    }
}
