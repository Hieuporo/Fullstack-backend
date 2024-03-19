using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace StoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        public UserController()
        {
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok();
        }
    }
}
