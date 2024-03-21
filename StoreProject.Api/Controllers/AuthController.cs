using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Auth.Commands.Login;
using StoreProject.Application.Auth.Commands.Logout;
using StoreProject.Application.Auth.Commands.Register;
using StoreProject.Domain.Constants;
using StoreProject.Domain.Entities;
using StoreProject.Infrastructure.Authentication;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPost("Register")]

        public async Task<ActionResult> Register(RegisterCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }


		[HttpPost("ConfirmEmail")]

		public async Task<ActionResult> ConfirmEmail()
		{
		
            return BadRequest();
		}

		[HttpPost("Refresh")]
		public async Task<ActionResult> Refresh()
		{


			return Ok();
		}

		[HttpPost("Logout")]
        [HasPermission(PermissionList.CreateBrand)]
        public async Task<ActionResult> Logout()
		{


            var response = await _mediator.Send(new LogoutCommand());

            return Ok(response);
		}

	}
}
