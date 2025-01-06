using CadastroAcademia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CadastroAcademia.Data
{
    public class ApplicationDbContext : DbContext  // Herdando de DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }  // Representa a tabela de usuários no banco de dados

        // Método Entry para obter informações sobre a entidade
        public override EntityEntry Entry(object entity)
        {
            return base.Entry(entity);  // Chama a implementação base do DbContext
        }

        // Método SaveChangesAsync para salvar alterações no banco de dados de forma assíncrona
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);  // Chama a implementação base para salvar as alterações
        }
    }
}
