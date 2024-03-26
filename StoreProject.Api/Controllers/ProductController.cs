//using MediatR;
//using Microsoft.AspNetCore.Mvc;
//using StoreProject.Application.DTOs.Product;

//namespace StoreProject.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : ControllerBase
//    {
//        private readonly IMediator _mediator;
//        public ProductController(IMediator mediator)
//        {
//            _mediator = mediator;
//        }

//        [HttpGet]
//        public async Task<ActionResult> Get()
//        {
//            return Ok();
//        }

//        [HttpGet]
//        [Route("{id}")]
//        public async Task<ActionResult<ProductDto>> Get(int id)
//        {
//            return Ok();
//        }

//        [HttpPost]
//        public async Task<ActionResult> Post()
//        {

//            return Ok();
//        }

//        [HttpPatch]
//        public async Task<ActionResult> Patch()
//        {

//            return NoContent();
//        }

//        [HttpDelete]
//        [Route("{id}")]
//        public async Task<ActionResult> Delete(int id)
//        {
//            return NoContent();
//        }

     
//    }

//}