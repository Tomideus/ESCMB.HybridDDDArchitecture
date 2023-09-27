using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Domain.Entities.mail
{
    public class ConfirmationMailSender : MailSender
    {
        public void SendConfirmationEmail(string toEmail, string randomToken)
        {
            string confirmationPageUrl = "https://tu-sitio-web.com/confirmacion";

            string body = $@"
            <html>
            <head>
                <style>
                    /* Estilos CSS aquí */
                </style>
            </head>
            <body>
                <div class='container'>
                    <h1>¡Gracias por registrarte!</h1>
                    <p>Por favor, confirma tu correo electrónico haciendo clic en el siguiente botón:</p>
                    <a class='button' href='{confirmationPageUrl}?token={randomToken}&email={toEmail}'>Confirmar Correo</a>
                </div>
            </body>
            </html>
        ";

            // Llamar al método sendMail de la clase base para enviar el correo electrónico
            string result = sendMail(toEmail, "Confirma tu correo electrónico", body);

            Console.WriteLine(result); // Puedes mostrar el resultado en la consola o hacer lo que desees con él
        }
    }
}
