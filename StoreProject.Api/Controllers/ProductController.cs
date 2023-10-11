using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.DTOs.Product;
using StoreProject.Application.Features.Products.Requests.Commands;
using StoreProject.Application.Features.Products.Requests.Queries;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> Get()
        {
            var coupons = await _mediator.Send(new GetProductListRequest());
            return Ok(coupons);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {
            var coupon = await _mediator.Send(new GetProductRequest { Id = id });

            return Ok(coupon);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateProductDto product)
        {
            var command = new CreateProductCommand { ProductDto = product };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateProductDto product)
        {
            var command = new UpdateProductCommand { ProductDto = product };
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteProductCommand { Id = id };
            await _mediator.Send(command);

            return NoContent();
        }
    }

}