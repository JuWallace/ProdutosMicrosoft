using Microsoft.EntityFrameworkCore;


namespace ProjetoVendas.model
{
    class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        //public DbSet<Venda> Vendas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
                                          Database=dbVendas;
                                          Trusted_Connection=True");

        }
    }
}
