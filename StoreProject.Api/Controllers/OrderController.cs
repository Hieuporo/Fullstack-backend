//using MediatR;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace StoreProject.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    [Authorize]
//    public class OrderController : ControllerBase
//    {
//        private readonly IMediator _mediator;
//        public OrderController(IMediator mediator)
//        {
//            _mediator = mediator;
//        }

//        [HttpGet]
//        public async Task<ActionResult> GetOrders()
//        {
//            return Ok();
//        }

//        [HttpGet]
//        [Route("{id}")]
//        public async Task<ActionResult> GetOrderById(int id)
//        {
//            return Ok();
//        }


//        [HttpGet]
//        [Route("all-order")]
//        public async Task<ActionResult> GetAllOrder()
//        {
//            return Ok();
//        }

//        [HttpGet]
//        [Route("get-order-detail/{id}")]
//        public async Task<ActionResult> GetOrderDetailById(int id)
//        {
//            return Ok();
//        }




//        [HttpPost]
//        public async Task<ActionResult> CreateOrder()
//        {
//            return Ok();
//        }

//        [HttpPatch]
//        public async Task<ActionResult> UpdateOrder()
//        {

//            return Ok();
//        }

//        [HttpDelete]
//        [Route("delete-order/{id}")]
//        public async Task<ActionResult> DeleteOrder()
//        {
//            return Ok();
//        }

//        [HttpPost]
//        [Route("confirm-payment/{id}")]
//        public async Task<ActionResult> ConfirmPayment(int id)
//        {

//            return Ok();
//        }


//        [HttpPost]
//        [Route("complete-order/{id}")]
//        public async Task<ActionResult> CompleteOrder(int id)
//        {

       
//            return Ok();
//        }


//        [HttpPost]
//        [Route("cancel-order/{id}")]
//        public async Task<ActionResult> CancelOrder(int id)
//        {


//            return Ok();
//        }
//    }
//}
