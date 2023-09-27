using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Domain.Entities.mail
{
    internal class TokenVerifier
    {
        public bool VerifyToken(string emailToken, string userToken)
        {
            // Compara el token del correo electrónico con el token del usuario
            return string.Equals(emailToken, userToken);
        }
    }
}
