﻿using AutoMapper;
using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.CartItem;
using StoreProject.Application.Features.CartItems.Requests.Commands;
using StoreProject.Application.Features.Carts.Requests.Queries;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;
  

        public CartController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var cart = await _mediator.Send(new GetCartRequest());

            return Ok(cart);
        }

        [HttpPost]
        public async Task<ActionResult> AddToCart([FromBody] CreateCartItemDto createCartItemDto)
        {
            var cart = await _mediator.Send(new GetCartRequest());
            if(cart.Id != createCartItemDto.CartId)
            {
                return BadRequest("Something went wrong");
            }

            var command = new CreateCartItemCommand { CartItemDto = createCartItemDto };
            var response = await _mediator.Send(command);
           
            return Ok(response);
        }

        [HttpPut]
        [Route("minus")]
        public async Task<ActionResult> Minus([FromBody] UpdateCartItemDto updateCartItemDto)
        {

            var command = new UpdateCartItemCommand { CartItemDto = updateCartItemDto, IsMinus = true };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPut]
        [Route("plus")]
        public async Task<ActionResult> Plus([FromBody] UpdateCartItemDto updateCartItemDto)
        {
            var command = new UpdateCartItemCommand { CartItemDto = updateCartItemDto, IsMinus = false };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCartItemCommand { Id = id };
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
