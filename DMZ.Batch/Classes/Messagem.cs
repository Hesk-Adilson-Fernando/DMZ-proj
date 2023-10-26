using System.Windows.Forms;

namespace DMZ.Batch.Classes
{
    public static class Messagem
    {
        public static void DoDontPrintMessagem()
        {
            MessageBox.Show($"{ParteInicial()} O Documento está em criação. \r\nNão é possivel Imprimir, Grave primeiro!");
        }

        public static void DoNothingPrintMensagem()
        {
            MessageBox.Show("Estimado(a), Não temos nada para imprimir!");
        }

        public static string ParteInicial()
        {
            //return $"Estimado(a): {Pbl.Usr.Nome},\r\n";
            return "";
        }

        public static void DoEmptyMoedaVenda()
        {
            MessageBox.Show($"{ParteInicial()} a moeda de venda não pode estar vazia. \r\nNão é possivel executar o cambio!");
        }

        public static string NaoTemConta(string inicial,string nome)
        {
            return $"{inicial}: {nome} não tem conta criada na contabilidade.\r\nNão é possivel integrar o documento!";
        }

        internal static string NaoExisteDocumentos()
        {
            return ParteInicial() +" Desculpe, não tem permissão para ver nenhum documento deste grupo, Contacte o administrador!";
        }

        internal static string NaoTemAcesso()
        {
            return ParteInicial() + "Desculpa não tem acesso. contacte administrator!";
        }
    }
}
