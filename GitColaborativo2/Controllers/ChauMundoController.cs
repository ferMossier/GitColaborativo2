using Microsoft.AspNetCore.Mvc;

namespace GitColaborativo2.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class ChauMundoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetChauMundo()
        {
            return Ok( new { Data = "Chau Mundo" } );
        }
    }
}
