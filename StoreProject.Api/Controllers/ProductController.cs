using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Constants;
using StoreProject.Application.DTOs.Product;
using StoreProject.Application.DTOs.ProductItem;
using StoreProject.Application.Features.ProductItems.Requests.Commands;
using StoreProject.Application.Features.ProductItems.Requests.Queries;
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
        public async Task<ActionResult<List<ProductDto>>> Get([FromQuery] string? SearchTerm, [FromQuery] string? SortName,
            [FromQuery] int Page, [FromQuery] int PageSize, [FromQuery] int? CategoryId)
        {   
            var result = await _mediator.Send(new GetProductListRequest() 
            {
                Page = Page ,
                PageSize = PageSize,
                SearchTerm = SearchTerm,
                SortName = SortName,
				CategoryId = CategoryId
			});

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {
            var product = await _mediator.Send(new GetProductRequest { Id = id });

            return Ok(product);
        }

        [HttpPost]
        [Authorize(Roles = Role.RoleAdmin)]
        public async Task<ActionResult> Post([FromBody] CreateProductDto product)
        {
            var command = new CreateProductCommand { ProductDto = product };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPatch]
        [Authorize(Roles = Role.RoleAdmin)]
        public async Task<ActionResult> Patch([FromBody] UpdateProductDto product)
        {
            var command = new UpdateProductCommand { ProductDto = product };
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = Role.RoleAdmin)]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteProductCommand { Id = id };
            await _mediator.Send(command);

            return NoContent();
        }


        //Product Item
        [HttpGet]
        [Route("productitem")]
        [Authorize(Roles = Role.RoleAdmin)]
        public async Task<ActionResult<List<ProductItemDto>>> GetProductTags()
        {
            var tags = await _mediator.Send(new GetProductItemListRequest());
            return Ok(tags);
        }

        [HttpGet]
        [Route("productitem/{id}")]
        [Authorize(Roles = Role.RoleAdmin)]
        public async Task<ActionResult<ProductItemDto>> GetProductItemById(int id)
        {
            var tag = await _mediator.Send(new GetProductItemRequest { Id = id });

            return Ok(tag);
        }

        [HttpPost]
        [Route("productitem")]
        [Authorize(Roles = Role.RoleAdmin)]
        public async Task<ActionResult> Post([FromBody] CreateProductItemDto productItem)
        {
            var command = new CreateProductItemCommand { ProductItemDto = productItem };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPut]
        [Route("productitem")]
        [Authorize(Roles = Role.RoleAdmin)]
        public async Task<ActionResult> Put([FromBody] UpdateProductItemDto productItem)
        {
            var command = new UpdateProductItemCommand { ProductItemDto = productItem };
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("productitem/{id}")]
        [Authorize(Roles = Role.RoleAdmin)]
        public async Task<ActionResult> DeleteProductItem(int id)
        {
            var command = new DeleteProductItemCommand { Id = id };
            await _mediator.Send(command);

            return NoContent();
        }
    }

}