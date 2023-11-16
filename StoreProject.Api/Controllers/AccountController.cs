using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Contracts.Infrastructure.Identity;
using StoreProject.Application.Features.Carts.Requests.Commands;
using StoreProject.Application.Models.Identity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IMediator _mediator;

        public AccountController(IAuthService authService, IMediator mediator)
        {
            _authService = authService;
            _mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(AuthRequest request)
        {
            return Ok(await _authService.Login(request));
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(RegistrationRequest request)
        {
            var responseLogin = await _authService.Register(request);
            await _mediator.Send(new CreateCartCommand { UserId = responseLogin.UserId }); 

            return Ok(responseLogin);
        }
    }
}
