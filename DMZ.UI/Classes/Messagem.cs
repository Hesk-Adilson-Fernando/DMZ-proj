using DMZ.BL.Classes;
using DMZ.UI.Generic;
using System;
using System.Windows.Forms;

namespace DMZ.UI.Classes
{
    public static class Messagem
    {
        public static void DoDontPrintMessagem()
        {
            MsBox.Show($"{ParteInicial()} O Documento está em criação. \r\nNão é possivel Imprimir, Grave primeiro!");
        }

        public static void DoNothingPrintMensagem()
        {
            MsBox.Show("Estimado(a), Não temos nada para imprimir!");
        }

        public static string ParteInicial()
        {
            //return $"Estimado(a): {Pbl.Usr.Nome},\r\n";
            return "";
        }

        public static void DoEmptyMoedaVenda()
        {
            MsBox.Show($"{ParteInicial()} a moeda de venda não pode estar vazia. \r\nNão é possivel executar o cambio!");
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
