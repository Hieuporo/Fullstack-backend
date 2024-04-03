using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.DTOs.Product;
using StoreProject.Application.Products.Commands.CreateProduct;
using StoreProject.Application.Products.Commands.DeleteProduct;
using StoreProject.Application.Products.Commands.UpdateProduct;
using StoreProject.Application.Products.Queries.GetProducts;
using StoreProject.Domain.Enums;
using StoreProject.Infrastructure.Authentication;

namespace StoreProject.Api.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var result = await _mediator.Send(new GetProductsQuery());

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {
            var result = await _mediator.Send(new GetProductsQuery());

            return Ok(result);
        }

        [HttpPost]
        [HasPermission(PermissionList.CreateProduct)]
        public async Task<ActionResult> CreateProduct(CreateProductCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        [HasPermission(PermissionList.UpdateProduct)]
        public async Task<ActionResult> Patch(UpdateProductCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        [HasPermission(PermissionList.DeleteProduct)]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteProductCommand() { Id = id });

            return NoContent();
        }


    }

}