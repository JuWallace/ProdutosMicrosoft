using ProjetoVendas.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVendas.view
{
    class CadastrarCliente
    {
        public static void ExecCadCliente()
        {
            Cliente c = new Cliente();
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|         Cadastro de Clientes         |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            //Adiciona o item à lista
            Console.WriteLine("Digite o nome do Cliente: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do Cliente: ");
            c.Cpf = Console.ReadLine();
        }   
    }
}
