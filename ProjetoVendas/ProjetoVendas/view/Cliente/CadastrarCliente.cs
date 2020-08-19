using System;
using ProjetoVendas.Dal;
using ProjetoVendas.model;


namespace ProjetoVendas.view
{
    class CadastrarCliente
    {
        public static void ExecCadastrarCliente()
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

            //VALIDAÇÃO DO CPF
            if (ValidaCPF.ValidarCPF(c.Cpf))
            {
                if (ClienteDAO.Cadastrar(c))
                {
                    Console.WriteLine("Cliente Cadastrado!");
                }
                else
                {
                    Console.WriteLine("Cliente já existe.");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }
        }   
    }
}
