using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace ESCMB.Domain.Entities.mail
{
    public class MailSender
    {
        public IConfiguration _configuration;

        public MailSender()
        {
            // Initialize Configuration
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public string sendMail(string to, string asunto, string body)
        {
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde.";

            try
            {
                // Read configuration values from appsettings.json
                string fromAddress = _configuration["EmailConfig:FromAddress"];
                string displayName = _configuration["EmailConfig:DisplayName"];
                string password = _configuration["EmailConfig:Password"];

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromAddress, displayName);
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                client.Credentials = new NetworkCredential(fromAddress, password);
                client.EnableSsl = true;

                client.Send(mail);
                msge = "¡Correo enviado exitosamente! Pronto te contactaremos.";
            }
            catch (Exception ex)
            {
                msge = ex.Message + ". Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.";
            }

            return msge;
        }

        internal void SendConfirmationEmail(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
