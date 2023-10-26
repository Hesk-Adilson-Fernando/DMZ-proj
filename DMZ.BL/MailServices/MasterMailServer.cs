using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
namespace DMZ.BL.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient()
        {
            smtpClient= new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail,password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;

        }

        public void SendMail(string subject,string body,List<string> mailsAdress)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.Body = body;
                mailMessage.Subject = subject;
                foreach (var adress in mailsAdress)
                {
                    mailMessage.To.Add(adress);
                }
                mailMessage.Priority = MailPriority.Normal;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
