using System;
using ProjetoVendas.Dal;
using ProjetoVendas.model;


namespace ProjetoVendas.view
{
    class ListarCliente
    {
        public static void ExecListarClientes()
        {
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|           Lista de Clientes          |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            foreach (Cliente clienteCadastrado in ClienteDAO.Listar())
            {
                Console.WriteLine($"{clienteCadastrado}");
            }
        }
    }
}
