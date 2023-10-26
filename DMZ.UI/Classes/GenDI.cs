using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.UC;
using System;

namespace DMZ.UI.Classes
{
    public class GenDi
    {
        internal static void SetEntidade(Tdi tmpTdi, Procura tbEntidade)
        {
            var qry = "";
            switch (tmpTdi.Tiposigla)
            {
                case "CL":
                    qry = "select no,nome,clstamp,Morada,nuit from cl where pos=0";
                    break;
                case "ET":
                    qry = "select no,nome,Entstamp,Morada,nuit from Ent ";
                    break;
                case "FL":
                    qry = "select no,nome,fncstamp,Morada,nuit from fnc ";
                    break;
                case "MT":
                    qry = "select no,nome,pestamp,bairro,nuit from pe where ltrim(rtrim(tipo))='Motorista'";
                    break;
                case "MC":
                    qry = "select no,nome,pestamp,bairro,nuit from pe where ltrim(rtrim(tipo))='Mecânico'";
                    break;
                case "FN":
                    qry = "select no,nome,pestamp,bairro,nuit from pe";
                    break;
            }

            tbEntidade.Label1Text = tmpTdi.Desctipo;
            tbEntidade.SqlComandText = qry;
            tbEntidade.IsSqlSelect = true;
        }

        internal static Di SetDiDefaultValues(Di di, FrmClasse frm, Tdi TmpTdi)
        {
            di = frm.DoAddline<Di>();
            frm.Noneg = TmpTdi.Noneg;
            FillDi(di,TmpTdi);
           // var m = SQL.GetRowToEnt<Moedas>($"Princip=1");// EF.GetEnt<Moedas>(p=>p.Princip.Equals(true));

            ((Procura)frm.Controls.Find("tbEntidade",true)[0]).Visible =!TmpTdi.Noentid;
            ((Procura)frm.Controls.Find("tbCcusto",true)[0]).tb1.Text = string.IsNullOrEmpty(TmpTdi.Ccusto)? Pbl.Usr.Ccusto:TmpTdi.Ccusto;
            ((Procura) frm.Controls.Find("tbCcusto", true)[0]).Text2 = Pbl.Usr.Codccu;
            ((Procura)frm.Controls.Find("ucMoeda",true)[0]).tb1.Text = Pbl.MoedaBase.Trim();
           // ((Procura)frm.Controls.Find("ucMoeda",true)[0]).Text2 = m.Descricao.Trim();
            ((DtDefault)frm.Controls.Find("dtVencimento",true)[0]).dt1.Value = di.Dataven;
            return di;
        }

        public static void FillDi(Di di, Tdi TmpTdi)
        {
            di.Sigla = TmpTdi.Sigla;
            di.Tdistamp=TmpTdi.Tdistamp;
            di.Usrstamp = Pbl.Usr.Usrstamp;
            di.Dataven = Pbl.GetDate(30);
            di.Numdoc = TmpTdi.Numdoc;
            di.Nomedoc = TmpTdi.Descricao;
            di.Movtz = TmpTdi.Movtz;//Indica o movimento da tesouraria 
            di.Entidade = TmpTdi.Tipo;
            di.Movstk = TmpTdi.Movstk;
            di.Obs = TmpTdi.Obs;
            #region Codigo de movimento de stock
            di.Descmovstk = TmpTdi.Descmovstk;
            di.Codmovstk = TmpTdi.Codmovstk;
            di.Descmovstk2 = TmpTdi.Descmovstk2;
            di.Codmovstk2 = TmpTdi.Codmovstk2;
            #endregion
            #region Codigos de movimento de tesouraria
            di.Descmovtz = TmpTdi.Descmovtz;
            di.Codmovtz = TmpTdi.Codmovtz;
            di.Descmovtz2 = TmpTdi.Descmovtz2;
            di.Codmovtz2 = TmpTdi.Codmovtz2;
            #endregion

            #region Conta padrão a movimentar
            di.Codtz = TmpTdi.Codtz;
            di.Contatesoura = TmpTdi.Contastesoura;
            #endregion
            di.Trf = TmpTdi.Trf;//Transferencia entre armazens 
            di.TrfConta = TmpTdi.TrfConta;//Transferencia entre contas.. 
            di.Vendido = TmpTdi.Vendido;//Movimenta a saida do Produto Vendido
            di.Comprado = TmpTdi.Comprado;//Movimento a entrada do produto comprado
            di.Encomenda = TmpTdi.Encomenda;//Cria uma encomenda de produtos a fornecdor colocando as quantidades nas encomendas 
            di.Reserva = TmpTdi.Reserva;//Cria Reserva de Produtos apartir de pedido do cliente...
            di.Estorno = TmpTdi.Estorno;
        }

        internal static void SetEntidade1(Tdi TmpTdi, Procura tbEntidade)
        {
            var qry = "";
            switch (TmpTdi.Tiposigla)
            {
                /* case "CL":
                     qry = "select no,nome from cl where pos=0";
                     break;
                 case "ET":
                     qry = "select no,nome from Ent ";
                     break;
                 case "FL":
                     qry = "select no,nome from fnc ";
                     break;*/
                case "MT":
                    qry = "select nome from St where viatura = 1 AND Ligaprojecto=1";
                    break;
                case "VT":
                    qry = "select no,nome from pjvt ";
                    break;
                case "ET":
                    qry = "select no,nome from pjpe ";
                    break;
            }

            tbEntidade.Label1Text = TmpTdi.Desctipo;
            tbEntidade.SqlComandText = qry;
            tbEntidade.IsSqlSelect = true;
        }

    }
}
