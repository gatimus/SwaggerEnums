using Microsoft.AspNetCore.Mvc;
using SwaggerEnums.Models;

namespace SwaggerEnums.Controllers
{
    [Route("api/[controller]")]
    public class MyController : Controller
    {

        [HttpGet]
        [Route("a")]
        [ProducesResponseType(typeof(ModelA), 200)]
        public IActionResult GetA()
        {
            return Ok(new ModelA());
        }

        [HttpPost]
        [Route("a")]
        [ProducesResponseType(204)]
        public IActionResult PostA(ModelA value)
        {
            return NoContent();
        }

        [HttpGet]
        [Route("b")]
        [ProducesResponseType(typeof(ModelB), 200)]
        public IActionResult GetB()
        {
            return Ok(new ModelB());
        }

        [HttpPost]
        [Route("b")]
        [ProducesResponseType(204)]
        public IActionResult PostB(ModelB value)
        {
            return NoContent();
        }

    }
}