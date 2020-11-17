using Microsoft.EntityFrameworkCore;
using VendasWEB.Models;

namespace VendasWEB.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


    }
}
