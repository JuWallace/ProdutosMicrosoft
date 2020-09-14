using ProjetoVendas.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoVendas.dal
{
    class ProdutoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        private static List<Produto> produtos = new List<Produto>();

        //LISTAR
        //public static List<Produto> Listar() => produtos;
        public static List<Produto> ListarProduto()
        {
            return ctx.Produtos.ToList();
        }
        
        //BUSCAR
        //public static Produto BuscarProduto(string nome)
        //{
        //    foreach (Produto produdoCadastrado in produtos)
        //    {
        //        if(produdoCadastrado.Nome == nome)
        //        {
        //            return produdoCadastrado;
        //        }
        //    }
        //    return null;
        //}
        public static Produto BuscarProdutoPorNome(Produto p)
        {
            //foreach (Produto produtoCadastrado in produtos)
            //{
            //    if (produtoCadastrado.Nome.Equals(p.Nome))
            //    {
            //        return produtoCadastrado;
            //    }
            //}
            //return null;
            return ctx.Produtos.FirstOrDefault(x => x.Nome.Equals(p));
        }

        public static bool CadastrarProduto(Produto p)
         {
            if(BuscarProdutoPorNome(p) == null)
            {
                ctx.Produtos.Add(p);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
