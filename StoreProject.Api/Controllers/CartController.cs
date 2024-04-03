using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Carts.Commands.AddCartItem;
using StoreProject.Application.Carts.Commands.MinusProduct;
using StoreProject.Application.Carts.Commands.PlusProduct;
using StoreProject.Application.Carts.Queries.GetCart;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Enums;
using StoreProject.Infrastructure.Authentication;


namespace StoreProject.Api.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;


        public CartController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [HasPermission(PermissionList.Client)]
        public async Task<ActionResult> GetCart()
        {
            var result = await _mediator.Send(new GetCartQuery());

            return Ok(result);
        }

        [HttpPost]
        [HasPermission(PermissionList.Client)]
        public async Task<ActionResult> AddToCart(AddCartItemCommand command)
        {

            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        [Route("minus-item")]
        [HasPermission(PermissionList.Client)]
        public async Task<ActionResult> Minus(MinusProductCommand command)
        {

            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        [Route("plus-item")]
        [HasPermission(PermissionList.Client)]
        public async Task<ActionResult> Plus(PlusProductCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

    }
}
