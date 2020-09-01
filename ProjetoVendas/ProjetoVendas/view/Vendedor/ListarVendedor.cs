using ProjetoVendas.dal;
using ProjetoVendas.model;
using System;


namespace ProjetoVendas.View
{
    class ListarVendedor
    {
        public static void ExecListarVendedores()
        {
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|          Lista de Vendedores         |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            foreach (Vendedor vendedorCadastrado in VendedorDAO.Listar())
            {
                Console.WriteLine($"{vendedorCadastrado}");
            }
        }
    }
}
