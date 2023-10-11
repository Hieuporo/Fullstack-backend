using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Constants;
using StoreProject.Application.DTOs.Brand;
using StoreProject.Application.DTOs.Cart;
using StoreProject.Application.Features.Brands.Requests.Commands;
using StoreProject.Application.Features.Carts.Requests.Commands;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Post()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid);
            var command = new CreateCartCommand { UserId = userId.Value };
            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
