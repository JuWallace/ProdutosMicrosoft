﻿using Microsoft.EntityFrameworkCore;

namespace BancoDados.Models
{
    class Context : DbContext
    {
        //Mapear as classes que vão virar tabelas no banco de dados
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
                                          Database=dbBancoDados;
                                          Trusted_Connection=True");

        }
    }
}
