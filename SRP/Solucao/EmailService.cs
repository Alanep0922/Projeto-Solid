using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Solid.SRP.Solucao
{
    public class EmailService
    {
        public void Enviar(string rementente, string destinario, string assunto, string corpo)
        {
            try
            {
                SmtpClient clienteSmtp = new SmtpClient("smtp.servidor.com")
                {
                    Port = 25,
                    Credentials = new NetworkCredential("seu-email@dominio.com", "sua-senha"),
                    EnableSsl = true,
                };

                MailMessage mensagem = new MailMessage(rementente, destinario, assunto, corpo)
                {
                    IsBodyHtml = true
                };

                clienteSmtp.Send(mensagem);

                Console.WriteLine("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao enviar e-mail: {ex.Message}");
            }
        }
    }
}