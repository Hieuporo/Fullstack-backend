using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.Discounts.Handlers.Create;
using StoreProject.Application.Discounts.Handlers.Delete;
using StoreProject.Application.Discounts.Handlers.Update;
using StoreProject.Application.Discounts.Requests.GetAvailableDiscounts;
using StoreProject.Application.Discounts.Requests.GetDiscountByCode;
using StoreProject.Application.Discounts.Requests.GetDiscountById;
using StoreProject.Application.Discounts.Requests.GetDiscounts;
using StoreProject.Domain.Enums;
using StoreProject.Infrastructure.Authentication;

namespace StoreProject.Api.Controllers
{
    [Route("api/discount")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DiscountController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        [HasPermission(PermissionList.ViewDiscount)]
        public async Task<ActionResult> GetAllDiscount()
        {
            var result = await _mediator.Send(new GetDiscountsQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("available")]
        [HasPermission(PermissionList.Client)]
        public async Task<ActionResult> GetAvailableDiscounts()
        {
            var result = await _mediator.Send(new GetAvailableDiscountsQuery());

            return Ok(result);
        }


        [HttpGet]
        [Route("{code}")]
        public async Task<ActionResult> GetDiscountByCode(string code)
        {
            var result = await _mediator.Send(new GetDiscountByCodeQuery() {  DiscountCode = code });

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await _mediator.Send(new GetDiscountByIdQuery() { Id = id });

            return Ok(result);
        }

        [HttpPost]
        [HasPermission(PermissionList.CreateDiscount)]
        public async Task<ActionResult> CreateDiscount(CreateDiscountCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        [HasPermission(PermissionList.UpdateDiscount)]
        public async Task<ActionResult> UpdateDiscount(UpdateDiscountCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        [HasPermission(PermissionList.DeleteDiscount)]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleleDiscountCommand() { Id = id});
            return Ok(result);
        }
    }
}
