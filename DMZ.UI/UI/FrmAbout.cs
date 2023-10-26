using System;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmAbout : FrmClasse2
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            About();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            tbAbout.Text = "";
            About();
        }

        private void About()
        {
            tbAbout.Text = "QUEM SOMOS" +
                           "\r\n" +
                           "\r\nDMZ SISTEMAS: Uma empresa moçambicana de produção de softwares de gestão, que busca constantemente pela satisfação de clientes, através da qualidade de software e da sua facilidade de utilização. Dedicámo-nos em exclusivo a desenvolver ferramentas inovadoras de gestão." +
                           "\r\n….somos arrojados…" +
                           "\r\n" +
                           "\r\nMISSÃO" +
                           "\r\nCriar soluções de gestão inteligentes que proporcionam flexibilidade, rapidez e sucesso no negócio." +
                           "\r\n" +
                           "\r\nVISÃO" +
                           "\r\nAcreditamos que um gestor precisa de um software espetacular para o seu apoio. " +
                           "\r\n" +
                           "\r\nVALORES" +
                           "\r\n	>Inovação" +
                           "\r\n	>Confiança " +
                           "\r\n	>Coesão " +
                           "\r\n	>Arrojados" +
                           "\r\n	>Paixão por excelência" +
                           "\r\n" +
                           "\r\n" +
                           "DMZ Software é um produto da DMZ Sistemas desenhado, criado e desenvolvido em moçambique, usando as mais modernas tecnologias de engenharia de software.";

        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            tbAbout.Text = "DMZ SISTEMAS, LDA | Rua do Jardim, Nº. 297/50 RC" +
                           "\r\n" +
                           "Telefone: 840515627/847028510" +
                           "\r\n" +
                           "Email: comercial@dmzsoftware.co.mz";
        }
    }
}
