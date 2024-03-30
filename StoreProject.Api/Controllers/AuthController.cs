using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Auth.Commands.CreatePassword;
using StoreProject.Application.Auth.Commands.Login;
using StoreProject.Application.Auth.Commands.RefreshToken;
using StoreProject.Application.Auth.Commands.Register;
using StoreProject.Application.Auth.Commands.RevokeToken;
using StoreProject.Application.Auth.Queries.CheckValidToken;
using StoreProject.Application.Auth.Queries.GetMe;
using StoreProject.Domain.Constants;
using StoreProject.Domain.Enums;
using StoreProject.Infrastructure.Authentication;

namespace StoreProject.Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPost("register")]

        public async Task<ActionResult> Register(RegisterCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpGet("check-otp")]
        public async Task<ActionResult> CheckToken([FromQuery] CheckValidTokenRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("create-password")]
        public async Task<ActionResult> CreatePassword(CreatePasswordCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }


        [HttpPost("logout")]
        [HasPermission(PermissionList.All)]
        public async Task<ActionResult> Logout()
		{
            var response = await _mediator.Send(new RevokeTokenCommand());

            return Ok(response);
		}


        [HttpPost("refresh")]
        [HasPermission(PermissionList.All)]
        public async Task<ActionResult> Refresh(RefreshTokenCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("me")]
        [HasPermission(PermissionList.All)]
        public async Task<ActionResult> GetMe()
        {
            var response = await _mediator.Send(new GetMeQuery());

            return Ok(response);
        }


        //[HttpPost("forgot-password")]
        //public async Task<ActionResult> ForgotPassword()
        //{
        //    return Ok();
        //}

        //[HttpPatch("update-password")]
        //[HasPermission(PermissionList.All)]
        //public async Task<ActionResult> UpdatePassword()
        //{
        //    return Ok();
        //}
    }
}
