using Common.Domain.Validators;
using ESCMB.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Domain.Validators
{
    public class Clientvalidator: EntityValidator<Client>
    {
        public Clientvalidator()
        {
            RuleFor(x=>x.Email).NotNull().NotEmpty().WithMessage(Constants.NOTNULL_OR_EMPTY);
        
        }
    }
}
