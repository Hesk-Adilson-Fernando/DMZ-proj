using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using DMZ.BL.Classes;

namespace DMZ.Batch.Classes
{
    public static class Email
    {
        public static void SendEmail(string emailToAddress, string body, string subject)
        {
            var param = Pbl.Param;
            using (var mail = new MailMessage())
            {
                mail.From = new MailAddress(param.Outgoingemail);
                mail.To.Add(emailToAddress);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                using (var smtp = new SmtpClient(param.Smtpserver, (int) param.Smtpport))
                {
                    smtp.Credentials = new NetworkCredential(param.Outgoingemail, param.Outgoingpassword);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }

        private static DataTable dt =null;
        public static void SendEmail( string htmlstring,string email)
        {

            var param = Pbl.Param;
            //var Param = EF.GetEnt<Paramemail>();
            bool aa = false;
            try 
            {
           
                using (var message = new MailMessage())
                {
                    // MailMessage message = new MailMessage();

                    //Attachment anexar = new Attachment(anexo);
                    //message.Attachments.Add(anexar);
                    message.From = new MailAddress(param.Outgoingemail);
                    message.To.Add(new MailAddress(email));
                    message.Subject =param.Subjemail;
                    message.IsBodyHtml = true;
                    message.Body = htmlstring;

                    using (var smtp = new SmtpClient(param.Smtpserver, (int)param.Smtpport))
                    {
                        //smtp.Port = 587;
                        //smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(param.Outgoingemail, param.Outgoingpassword);
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(message);
                        aa = true;
                        if (true)
                        {
                            MessageBox.Show("Email enviado com sucesso");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na Conexão, Email não enviado");
            }
        }

    }
}
