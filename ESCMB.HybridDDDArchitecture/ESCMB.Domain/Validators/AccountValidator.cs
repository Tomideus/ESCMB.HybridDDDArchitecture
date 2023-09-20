using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain.Validators;
using FluentValidation;

namespace ESCMB.Domain.Validators
{
    public class AccountValidator : EntityValidator<Domain.Entities.Account>
    {

        public AccountValidator()
        {
            RuleFor(x => x.Saldo).NotNull().NotEmpty().WithMessage(Constants.NOTNULL_OR_EMPTY);

        }

    }
}
