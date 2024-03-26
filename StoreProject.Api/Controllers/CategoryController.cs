//using MediatR;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using StoreProject.Application.DTOs.Category;
//using StoreProject.Domain.Constants;
//using StoreProject.Domain.Entities;
//using StoreProject.Domain.Enums;
//using StoreProject.Infrastructure.Authentication;

//namespace StoreProject.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CategoryController : ControllerBase
//    {
//        private readonly IMediator _mediator;
//        public CategoryController(IMediator mediator)
//        {
//            _mediator = mediator;
//        }

//        [HttpGet]
//        public async Task<ActionResult> GetCategories()
//        {
//            return Ok();
//        }

//        [HttpGet]
//        [Route("{id}")]
//        public async Task<ActionResult> GetCategoryById(int id)
//        {
//            return Ok();
//        }

//        [HttpPost]
//        [HasPermission(PermissionList.CreateCategory)]
//        public async Task<ActionResult> CreateCategory()
//        {
//            return Ok();
//        }

//        [HttpPut]
//        [HasPermission(PermissionList.UpdateCategory)]
//        public async Task<ActionResult> UpdateCategory()
//        {
          
//            return NoContent();
//        }

//        [HttpDelete]
//        [Route("{id}")]
//        [HasPermission(PermissionList.DeleteCategory)]
//        public async Task<ActionResult> DeleteCategory(int id)
//        {

//            return NoContent();
//        }
//    }
//}
