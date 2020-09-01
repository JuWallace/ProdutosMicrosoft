using ProjetoVendas.Dal;
using ProjetoVendas.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVendas.dal
{
    class DadosEntrada
    {
        public static void Carregar()
        {
            Cliente c = new Cliente()
            {
                Nome = "Cliente1", 
                Cpf  = "258.851.570-30",
                CriadoEm = DateTime.Now

                //Nome = "Cliente2",
                //Cpf  = "166.500.300-66",
                //Nome = "Cliente3",
                //Cpf  = "01.492.470-01"
            };
            ClienteDAO.Cadastrar(c);

            Vendedor v = new Vendedor()
            {
                Nome = "Vendedor1",
                Cpf = "137.376.690-58",
                CriadoEm = DateTime.Now
            };
            VendedorDAO.Cadastrar(v);

            Produto p = new Produto()
            {
                Nome = "Bolacha",
                QtdeProduto = 100,
                Preco = 3.5,
                CriadoEm = DateTime.Now
            };
            ProdutoDAO.Cadastrar(p);
        }
    }
}
