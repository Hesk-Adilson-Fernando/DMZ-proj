

using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.Batch.Classes
{
    public class GenDi
    {
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

      
    }
}
