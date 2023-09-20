using Common.Application.Commands;
using ESCMB.Application.Repositories.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Application.UseCases.Account.Commands.RegisterAccount
{
    internal class RegisterAccountHandler : IRequestCommandHandler<RegisterAccountCommand, string>
    {
        private readonly IEventPublisher _eventPublisher;
        private readonly IAccountRepository _clientRepository;

        public RegisterAccountHandler(IEventPublisher eventPublisher , IAccountRepository clientRepository) 
        { 
            _eventPublisher = eventPublisher ?? throw new ArgumentNullException(nameof(eventPublisher));
        }

        public Task<string> Handle(RegisterAccountCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
