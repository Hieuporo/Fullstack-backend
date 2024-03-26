//using AutoMapper;
//using MediatR;
//using Microsoft.AspNetCore.Mvc;
//using StoreProject.Application.Contracts.IReposiotry;
//using StoreProject.Domain.Enums;
//using StoreProject.Infrastructure.Authentication;


//namespace StoreProject.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CartController : ControllerBase
//    {
//        private readonly IMediator _mediator;


//        public CartController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _mediator = mediator;
//        }

//        [HttpGet]
//        [HasPermission(PermissionList.Client)]
//        public async Task<ActionResult> GetCart()
//        {

//            return Ok();
//        }

//        [HttpPost]
//        [HasPermission(PermissionList.Client)]
//        public async Task<ActionResult> AddToCart()
//        {
//            return Ok();
//        }

//        [HttpPut]
//        [Route("minus-item")]
//        [HasPermission(PermissionList.Client)]
//        public async Task<ActionResult> Minus()
//        {

//            return Ok();
//        }

//        [HttpPut]
//        [Route("plus-item")]
//        [HasPermission(PermissionList.Client)]
//        public async Task<ActionResult> Plus()
//        {
//            return Ok();
//        }
       
//    }
//}
