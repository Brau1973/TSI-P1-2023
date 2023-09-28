using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CrudUsuarios.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Agregar Modelos a mapear en la BD (Code First)
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
