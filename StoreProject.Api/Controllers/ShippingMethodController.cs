using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.DTOs.ShippingMethod;

using StoreProject.Application.Features.ShippingMethods.Requests.Commands;
using StoreProject.Application.Features.ShippingMethods.Requests.Queries;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingMethodController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ShippingMethodController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet]
        public async Task<ActionResult<List<ShippingMethodDto>>> Get()
        {
            var shippingMethods = await _mediator.Send(new GetShippingMethodListRequest());
            return Ok(shippingMethods);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ShippingMethodDto>> Get(int id)
        {
            var shippingMethod = await _mediator.Send(new GetShippingMethodRequest { Id = id });

            return Ok(shippingMethod);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateShippingMethodDto productItem)
        {
            var command = new CreateShippingMethodCommand { ShippingMethodDto = productItem };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateShippingMethodDto productItem)
        {
            var command = new UpdateShippingMethodCommand { ShippingMethodDto = productItem };
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteShippingMethodCommand { Id = id };
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
    