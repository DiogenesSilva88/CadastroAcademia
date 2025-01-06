using CadastroAcademia.Models;
using CadastroAcademia.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAcademia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: api/usuario
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetUsuarios()
        {
            var usuarios = await _usuarioService.ObterTodosUsuarios();
            return Ok(usuarios);
        }

        // GET: api/usuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _usuarioService.ObterUsuarioPorId(id);
            if (usuario == null)
                return NotFound();
            return Ok(usuario);
        }

        // POST: api/usuario
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            var novoUsuario = await _usuarioService.CriarUsuario(usuario);
            return CreatedAtAction(nameof(GetUsuario), new { id = novoUsuario.Id }, novoUsuario);
        }

        // PUT: api/usuario/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
                return BadRequest();

            await _usuarioService.AtualizarUsuario(usuario);
            return NoContent();
        }

        // DELETE: api/usuario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var deleted = await _usuarioService.ExcluirUsuario(id);
            if (!deleted)
                return NotFound();
            return NoContent();
        }
    }
}
