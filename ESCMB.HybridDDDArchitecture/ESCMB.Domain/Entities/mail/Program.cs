using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESCMB.Domain.Entities.mail;
{
    static void Main()
    {
        MailSender mailSender = new ConfirmationMailSender();
        //string toEmail = get mail from user
        // string randomToken = get token from email;


        mailSender.SendConfirmationEmail("oviedohectorm@gmail.com", TokenCreator.GenerateRandomToken(10));



        /*
        tring emailToken = ObtenerTokenDelCorreoElectronico();
        string userToken = ObtenerTokenDelUsuario();

        TokenVerifier tokenVerifier = new TokenVerifier();
        bool tokensIguales = tokenVerifier.VerifyToken(emailToken, userToken);

        if (tokensIguales)
        {
            // El token del correo electrónico es válido, puedes marcar el correo como confirmado
            MarcarCorreoComoConfirmado();
        }
        else
        {
            // Los tokens no coinciden, muestra un mensaje de error o toma la acción adecuada
            MostrarMensajeDeError();
        }
        */
    }
}
