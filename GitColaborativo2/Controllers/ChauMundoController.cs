using Microsoft.AspNetCore.Mvc;

namespace GitColaborativo2.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class ChauMundoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetChauMundo( string name )
        {
            return Ok( new { Data = $"Chau Mundo, soy {name} y me tengo que ir" } );
        }
    }
}
