using DMZ.BL.Classes;
using DMZ.Model.Model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;

namespace DMZ.UI.UI.PRC
{
    public class EnviarEmail
    {
        public class EnviaEmail
        {
            /// <summary>
            /// Transmite uma mensagem de email sem anexos
            /// </summary>
            /// <param name="Destinatario">Destinatario (Recipient)</param>
            /// <param name="Remetente">Remetente (Sender)</param>
            /// <param name="Assunto">Assunto da mensagem (Subject)</param>
            /// <param name="enviaMensagem">Corpo da mensagem(Body)</param>
            /// <returns>Status da mensagem</returns>
            public static string EnviaMensagemEmail(string Destinatario, string Remetente,
                string Assunto, string enviaMensagem)
            {
                try
                {
                    try
                    {
                        Destinatario = Destinatario.Replace(",", ";");
                        var emails = Destinatario.Split(';');
                        for (int k = 0; k < emails.Length; k++)
                        {
                            try
                            {
                                var ss = emails[k].Trim();
                                if (!string.IsNullOrEmpty(emails[k].Trim()))
                                {
                                    // valida o email
                                    bool bValidaEmail = ValidaEnderecoEmail(emails[k].Trim());

                                    // Se o email não é validao retorna uma mensagem
                                    if (bValidaEmail == false)
                                        return "Email do destinatário inválido:" + emails[k].Trim();

                                    // Cria uma mensagem
                                    MailMessage mensagemEmail = new MailMessage(
                                        Pbl.Param.Outgoingemail,
                                        emails[k].Trim(),
                                        Assunto,
                                        enviaMensagem);
                                    SmtpConfig(mensagemEmail);
                                    return "Mensagem enviada para  " + Destinatario + " às " + DateTime.Now + ".";
                                }
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                        }
                        // valida o email

                        return "Mensagem enviada para " + Destinatario + " às " + DateTime.Now + ".";
                    }
                    catch (Exception ex)
                    {
                        //string erro = ex.Message;
                        return ex.Message;
                    }




                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            /// <summary>
            /// Transmite uma mensagem de email com um anexo
            /// </summary>
            /// <param name="Destinatario">Destinatario (Recipient)</param>
            /// <param name="Remetente">Remetente (Sender)</param>
            /// <param name="Assunto">Assunto da mensagem (Subject)</param>
            /// <param name="enviaMensagem">Corpo da mensagem(Body)</param>
            /// <param name="anexos">Um array de strings apontando para a localização de cada anexo</param>
            /// <returns>Status da mensagem</returns>
            #region Comentado Envio de Email
            public static string EnviaMensagemComAnexos(string Destinatario, string Remetente,
               string Assunto, string enviaMensagem, ArrayList anexos)
            {
                try
                {
                    Destinatario = Destinatario.Replace(",", ";");
                    var emails = Destinatario.Split(';');
                    for (int k = 0; k < emails.Length; k++)
                    {
                        try
                        {
                            var ss = emails[k].Trim();
                            if (!string.IsNullOrEmpty(emails[k].Trim()))
                            {
                                bool bValidaEmail = ValidaEnderecoEmail(emails[k].Trim());

                                if (bValidaEmail == false)
                                    return "Email do destinatário inválido:" + emails[k].Trim();

                                // Cria uma mensagem
                                MailMessage mensagemEmail = new MailMessage(
                                    Pbl.Param.Outgoingemail,
                                    emails[k].Trim(),
                                    Assunto,
                                    enviaMensagem);

                                foreach (string anexo in anexos)
                                {
                                    Attachment anexado = new Attachment(anexo, MediaTypeNames.Application.Octet);
                                    mensagemEmail.Attachments.Add(anexado);
                                }
                                SmtpConfig(mensagemEmail);
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    // valida o email

                    return "Mensagem enviada para " + Destinatario + " às " + DateTime.Now + ".";
                }
                catch (Exception ex)
                {
                    //string erro = ex.Message;
                    return ex.Message;
                }
            }


            static void SmtpConfig(MailMessage mensagemEmail)
            {
                SmtpClient client = new SmtpClient($@"{Pbl.Param.Smtpserver}", Pbl.Param.Smtpport.ToInt());
                client.EnableSsl = true;
                NetworkCredential cred = new NetworkCredential($@"{Pbl.Param.Outgoingemail}", $"{Pbl.Param.Outgoingpassword}");
                client.Credentials = cred;
                // envia a mensagem
                client.Send(mensagemEmail);
            }
            #endregion
















            /// <summary>
            /// Confirma a validade de um email
            /// </summary>
            /// <param name="enderecoEmail">Email a ser validado</param>
            /// <returns>Retorna True se o email for valido</returns>
            public static bool ValidaEnderecoEmail(string enderecoEmail)
            {
                try
                {
                    //define a expressão regulara para validar o email
                    string texto_Validar = enderecoEmail;
                    Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                    // testa o email com a expressão
                    if (expressaoRegex.IsMatch(texto_Validar))
                    {
                        // o email é valido
                        return true;
                    }
                    // o email é inválido
                    return false;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
