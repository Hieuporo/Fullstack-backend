using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.DTOs.ProductItem;

using StoreProject.Application.Features.ProductItems.Requests.Commands;
using StoreProject.Application.Features.ProductItems.Requests.Queries;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductItemController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductItemController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet]
        public async Task<ActionResult<List<ProductItemDto>>> Get()
        {
            var tags = await _mediator.Send(new GetProductItemListRequest());
            return Ok(tags);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProductItemDto>> Get(int id)
        {
            var tag = await _mediator.Send(new GetProductItemRequest { Id = id });

            return Ok(tag);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateProductItemDto productItem)
        {
            var command = new CreateProductItemCommand { ProductItemDto = productItem };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateProductItemDto productItem)
        {
            var command = new UpdateProductItemCommand { ProductItemDto = productItem };
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteProductItemCommand { Id = id };
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
    