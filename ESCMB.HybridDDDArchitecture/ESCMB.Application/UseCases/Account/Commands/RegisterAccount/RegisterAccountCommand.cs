using Common.Application.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Application.UseCases.Account.Commands.RegisterAccount
{
    public class RegisterAccountCommand: IRequestCommand<string>
    {
     
        [Required]
        public int Saldo { get; set; }
    }


}

  
   