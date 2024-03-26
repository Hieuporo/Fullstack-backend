//using MediatR;
//using Microsoft.AspNetCore.Mvc;
//using StoreProject.Domain.Constants;
//using StoreProject.Domain.Enums;
//using StoreProject.Infrastructure.Authentication;

//namespace StoreProject.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class DiscountController : ControllerBase
//    {
//        IMediator _mediator;
//        public DiscountController(IMediator mediator)
//        {
//            _mediator = mediator;
//        }



//        [HttpGet]
//        public async Task<ActionResult> GetAllDiscount()
//        {
//            return Ok();
//        }

//        [HttpGet]
//        [HasPermission(PermissionList.Client)]
//        public async Task<ActionResult> GetDiscountInStrategy()
//        {
//            return Ok();
//        }


//        [HttpGet]
//        [Route("GetCouponByCode/{coupon}")]
//        public async Task<ActionResult> GetCouponByCode()
//        {
//            return Ok();
//        }

//        [HttpGet]
//        [Route("{id}")]
//        public async Task<ActionResult> Get(int id)
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
