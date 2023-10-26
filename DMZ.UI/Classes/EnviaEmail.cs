using System;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.Classes
{
    public class EnviarEmail
    {
            public static string EnviaMensagemEmail(string destinatario, string remetente,
                string assunto, string enviaMensagem, string senhaEmailremetente)
            {
                try
                {
                    // valida o email
                    var bValidaEmail = ValidaEnderecoEmail(destinatario);
                    // Se o email não é validao retorna uma mensagem
                    if (bValidaEmail == false)
                    {
                        return "Email do destinatário inválido: " + destinatario;
                    }
                    // cria uma mensagem
                    var mensagemEmail = new MailMessage(remetente, destinatario, assunto, enviaMensagem);
                    using (var client = new SmtpClient())
                    {
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential($"{remetente}", $"{senhaEmailremetente}");

                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        // envia a mensagem
                        client.Send(mensagemEmail);
                    }
                   // client.Send(mensagemEmail);
                   return "Mensagem enviada para  " + destinatario + " às " + DateTime.Now + ".";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            public static string EnviaEmail(string destinatario, 
                string assunto, string enviaMensagem, ArrayList anexos=null, string senhaEmailremetente = null,string remetente=null)
            {
                try
                {
                    // valida o email
                    var bValidaEmail = ValidaEnderecoEmail(destinatario);
                    if (bValidaEmail == false)
                    {
                        return "Email do destinatário inválido:" + destinatario;
                    }

                    if (string.IsNullOrEmpty(remetente))
                    {
                        remetente = SQL.GetValue("Outgoingemail", "Param"); 
                    }
                    // Cria uma mensagem
                    var mensagemEmail = new MailMessage(
                        remetente,
                        destinatario,
                        assunto,
                        enviaMensagem);

                    if (anexos !=null)
                    {
                        foreach (string anexo in anexos)
                        {
                            var anexado = new Attachment(anexo, MediaTypeNames.Application.Octet);
                            mensagemEmail.Attachments.Add(anexado);
                        }
                    }

                    if (string.IsNullOrEmpty(senhaEmailremetente))
                    {
                        senhaEmailremetente = SQL.GetValue("Outgoingpassword", "Param"); 
                    }
                    using (var client = new SmtpClient())
                    {
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential($"{remetente}", $"{senhaEmailremetente}");
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.Send(mensagemEmail);
                    }
                    // envia a mensagem
                    // client.Send(mensagemEmail);
                    return "Mensagem enviada para " + destinatario + " às " + DateTime.Now + ".";
                }
                catch (Exception ex)
                {
                    // string erro = ex.InnerException.ToString();
                    return ex.Message ;
                }
            }
            public static string EnviaMensagemComAnexos(string destinatario, string remetente,
                string assunto, string enviaMensagem, ArrayList anexos, string senhaEmailremetente)
            {
                try
                {
                    // valida o email
                    var bValidaEmail = ValidaEnderecoEmail(destinatario);
                    if (bValidaEmail == false)
                        return "Email do destinatário inválido:" + destinatario;
                    // Cria uma mensagem
                    var mensagemEmail = new MailMessage(
                       remetente,
                       destinatario,
                       assunto,
                       enviaMensagem);
                    
                    foreach (string anexo in anexos)
                    {
                        var anexado = new Attachment(anexo, MediaTypeNames.Application.Octet);
                        mensagemEmail.Attachments.Add(anexado);
                    }
                    using (var client = new SmtpClient())
                    {
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential($"{remetente}", $"{senhaEmailremetente}");
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.Send(mensagemEmail);
                    }
                    // envia a mensagem
                   // client.Send(mensagemEmail);
                   return "Mensagem enviada para " + destinatario + " às " + DateTime.Now + ".";
                }
                catch (Exception ex)
                {
                   // string erro = ex.InnerException.ToString();
                    return ex.Message ;
                }
            }
            public static bool ValidaEnderecoEmail(string enderecoEmail)
            {
                //define a expressão regulara para validar o email
                var textoValidar = enderecoEmail;
                var expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");
                // testa o email com a expressão
                return expressaoRegex.IsMatch(textoValidar);
                // o email é inválido
            }
    }
}
