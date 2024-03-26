//using MediatR;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using StoreProject.Application.DTOs.ShippingMethod;


//namespace StoreProject.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ShippingMethodController : ControllerBase
//    {
//        private readonly IMediator _mediator;
//        public ShippingMethodController(IMediator mediator)
//        {
//            _mediator = mediator;
//        }



//        [HttpGet]
//        public async Task<ActionResult<List<ShippingMethodDto>>> Get()
//        {
//            return Ok();
//        }

//        [HttpGet]
//        [Route("{id}")]
//        public async Task<ActionResult<ShippingMethodDto>> Get(int id)
//        {
//            return Ok();
//        }

//        [HttpPost]
//        public async Task<ActionResult> Post()
//        {
//            return Ok();
//        }

//        [HttpPut]
//        public async Task<ActionResult> Put()
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
