using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // Buscar usuarios
        [HttpGet]
        public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios() // endpoint
        {
            return Ok();
        }
    }
}
