using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Contracts.Infrastructure.Identity;
using StoreProject.Application.Models.Identity;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(AuthRequest request)
        {
            return Ok();
        }

        [HttpPost("Register")]

        public async Task<ActionResult> Register(RegistrationRequest request)
        {
           

            return Ok();
        }


		[HttpPost("ConfirmEmail")]

		public async Task<ActionResult> ConfirmEmail(ConfirmAccountRequest request)
		{
		
            return BadRequest();
		}

		[HttpPost("Refresh")]
		public async Task<ActionResult> Refresh(RefreshRequest request)
		{


			return Ok();
		}

		[HttpPost("Revoke")]
		public async Task<ActionResult> Revoke()
		{
			return Ok();
		}

	}
}
