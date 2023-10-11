﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.DTOs.Category;

using StoreProject.Application.Features.Categories.Requests.Commands;
using StoreProject.Application.Features.Categories.Requests.Queries;
using StoreProject.Domain.Entities;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> Get()
        {
            var coupons = await _mediator.Send(new GetCategoryListRequest());
            return Ok(coupons);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<CategoryDto>> Get(int id)
        {
            var coupon = await _mediator.Send(new GetCategoryRequest { Id = id });

            return Ok(coupon);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateCategoryDto productItem)
        {
            var command = new CreateCategoryCommand { CategoryDto = productItem };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateCategoryDto productItem)
        {
            var command = new UpdateCategoryCommand { CategoryDto = productItem };
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCategoryCommand { Id = id };
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
