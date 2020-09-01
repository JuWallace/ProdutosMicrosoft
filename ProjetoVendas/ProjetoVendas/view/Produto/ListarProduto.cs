using ProjetoVendas.dal;
using ProjetoVendas.model;
using System;


namespace ProjetoVendas.view
{
    class ListarProduto
    {
        public static void ExecListarProduto()
        {
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|           Lista de Produtos          |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            foreach (Produto produtoEncontrado in ProdutoDAO.Listar())
            {
                Console.WriteLine($"{produtoEncontrado}");
            }
        }
    }
}
