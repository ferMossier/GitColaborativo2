namespace GitColaborativo2.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class HolaMundoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHolaMundo( string name )
        {
        //Comentario de prueba
            return Ok( new { data = $"Hola Mundo, soy {name}" } );
        }
    }
}
