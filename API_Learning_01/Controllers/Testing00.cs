using Microsoft.AspNetCore.Mvc;

namespace API_Learning_01.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Testing00 : ControllerBase
    {
        [HttpGet("hello")]
        public object GetHello()
        {
            return new
            {
                message = "Hello",
                status = 200
            };
        }

        [HttpPost("create")]
        public IActionResult CreateUser([FromBody] User user)
        {
            return Ok(new
            {
                message = "Successfully created",
                data = user
            });
        }
    }
}