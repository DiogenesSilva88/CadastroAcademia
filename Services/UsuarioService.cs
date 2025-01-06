using CadastroAcademia.Data;
using CadastroAcademia.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroAcademia.Services
{
    public class UsuarioService
    {
        private readonly ApplicationDbContext _context;

        public UsuarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create
        public async Task<Usuario> CriarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        // Read
        public async Task<Usuario> ObterUsuarioPorId(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<List<Usuario>> ObterTodosUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        // Update
        public async Task<Usuario> AtualizarUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return usuario;
        }

        // Delete
        public async Task<bool> ExcluirUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
