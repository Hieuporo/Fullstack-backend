using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Brands.Commands.CreateBrand;
using StoreProject.Domain.Constants;
using StoreProject.Infrastructure.Authentication;
namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }



        //[HttpGet]
        //public async Task<ActionResult<List<BrandDto>>> Get()
        //{
        //    var coupons = await _mediator.Send(new GetBrandListRequest());
        //    return Ok(coupons);
        //}

        //[HttpGet]
        //[Route("{id}")]
        //public async Task<ActionResult<BrandDto>> Get(int id)
        //{
        //    var coupon = await _mediator.Send(new GetBrandRequest { Id = id });

        //    return Ok(coupon);
        //}
        [HttpPost]
        [HasPermission(PermissionList.CreateBrand)]
        public async Task<ActionResult> Post([FromBody] CreateBrandCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        //[HttpPut]
        //[Authorize(Roles = Role.RoleAdmin)]
        //public async Task<ActionResult> Put([FromBody] UpdateBrandDto productItem)
        //{
        //    var command = new UpdateBrandCommand { BrandDto = productItem };
        //    await _mediator.Send(command);

        //    return NoContent();
        //}

        //[HttpDelete]
        //[Route("{id}")]
        //[Authorize(Roles = Role.RoleAdmin)]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var command = new DeleteBrandCommand { Id = id };
        //    await _mediator.Send(command);

        //    return NoContent();
        //}
    }
}
