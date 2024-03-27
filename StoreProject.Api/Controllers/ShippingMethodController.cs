using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.DTOs.ShippingMethod;
using StoreProject.Application.ShippingMethods.Command.Create;
using StoreProject.Application.ShippingMethods.Command.Delete;
using StoreProject.Application.ShippingMethods.Command.Update;
using StoreProject.Application.ShippingMethods.Queries.GetShippingMethod;
using StoreProject.Application.ShippingMethods.Queries.GetShippingMethods;


namespace StoreProject.Api.Controllers
{
    [Route("api/shipping")]
    [ApiController]
    public class ShippingMethodController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ShippingMethodController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _mediator.Send(new GetShippingMethodsQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetShippingMethodQuery() { Id = id});
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> CreateShippingMethod(CreateShippingMethodCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateShippingMethod(UpdateShippingMethodCommand command)
        {

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteShippingMethodCommand() { Id = id} );
            return Ok(result);
        }
    }
}
