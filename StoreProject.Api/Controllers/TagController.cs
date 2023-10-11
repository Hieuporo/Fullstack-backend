using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Application.DTOs.Tag;

using StoreProject.Application.Features.Tags.Requests.Commands;
using StoreProject.Application.Features.Tags.Requests.Queries;

namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TagController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet]
        public async Task<ActionResult<List<TagDto>>> Get()
        {
            var tags = await _mediator.Send(new GetTagListRequest());
            return Ok(tags);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<TagDto>> Get(int id)
        {
            var tag = await _mediator.Send(new GetTagRequest { Id = id });

            return Ok(tag);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateTagDto tag)
        {
            var command = new CreateTagCommand { TagDto = tag };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateTagDto tag)
        {
            var command = new UpdateTagCommand { TagDto = tag };
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteTagCommand { Id = id };
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
    