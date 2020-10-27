using Microsoft.EntityFrameworkCore;

namespace AgendaMedica_WEB.Models.conex
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
