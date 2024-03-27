using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Categories.Commands.Create;
using StoreProject.Application.Categories.Commands.Delete;
using StoreProject.Application.Categories.Commands.Update;
using StoreProject.Application.Categories.Queries.GetCategoryById;
using StoreProject.Application.Categories.Queries.GetListCategory;
using StoreProject.Domain.Enums;
using StoreProject.Infrastructure.Authentication;

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
        public async Task<ActionResult> GetCategories()
        {
            var result = await _mediator.Send(new GetListCategoryQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetCategoryById(int id)
        {
            var result = await _mediator.Send(new GetCategoryByIdQuery() { Id = id});
            return Ok(result);
        }

        [HttpPost]
        [HasPermission(PermissionList.CreateCategory)]
        public async Task<ActionResult> CreateCategory(CreateCategoryCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        [HasPermission(PermissionList.UpdateCategory)]
        public async Task<ActionResult> UpdateCategory(UpdateCategoryCommand command)
        {

            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        [HasPermission(PermissionList.DeleteCategory)]
        public async Task<ActionResult> DeleteCategory(int id)
        {

            await _mediator.Send(new DeleteCategoryCommand {Id = id});
            return NoContent();
        }
    }
}
