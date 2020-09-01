using ProjetoVendas.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVendas.dal
{
    class ProdutoDAO
    {
        private ProdutoDAO() { }
        private static List<Produto> produtos = new List<Produto>();

        //LISTAR
        public static List<Produto> Listar() => produtos;
        
        //BUSCAR
        public static Produto BuscarProduto(string nome)
        {
            foreach (Produto produdoCadastrado in produtos)
            {
                if(produdoCadastrado.Nome == nome)
                {
                    return produdoCadastrado;
                }
            }
            return null;
        }
        public static Produto BuscarProdutoPorNome(Produto p)
        {
            foreach (Produto produtoCadastrado in produtos)
            {
                if (produtoCadastrado.Nome.Equals(p.Nome))
                {
                    return produtoCadastrado;
                }
            }
            return null;
        }

        public static bool Cadastrar(Produto p)
         {
            if(BuscarProduto(p.Nome) == null)
            {
                produtos.Add(p);
                return true;
            }
            return false;
        }

    }
}
