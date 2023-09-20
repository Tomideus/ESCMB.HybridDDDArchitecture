using Common.Application.Commands;
using ESCMB.Application.UseCases.Account.Commands.RegisterAccount;
using ESCMB.Application.UseCases.DummyEntity.Commands.CreateDummyEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ESCMB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : BaseController
    {
        private readonly IEventPublisher _commandQueryBus;

        public AccountsController(IEventPublisher commandQueryBus)
        {
            _commandQueryBus = commandQueryBus ?? throw new ArgumentNullException(nameof(commandQueryBus));

        }

        [HttpPost("api/v1/[Controller]")]
        public async Task<IActionResult> RegisterAccount(RegisterAccountCommand command)
        {
            if (command is null) return BadRequest();

            var id = await _commandQueryBus.Send(command);

            return Created($"api/[Controller]/{id}", new { Id = id });
        }

    }
}
