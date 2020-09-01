using ProjetoVendas.dal;
using ProjetoVendas.model;
using System;


namespace ProjetoVendas.view
{
    public class CadatrarVendedor
    {
        public static void ExecCadastrarVendedor()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|        Cadastro de Vendedores        |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            //Adiciona o item à lista
            Console.WriteLine("Digite o nome do Vendedor: ");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do Vendedor: ");
            v.Cpf = Console.ReadLine();

            //VALIDAÇÃO DO CPF
            if (ValidaCPF.ValidarCPF(v.Cpf))
            {
                if (VendedorDAO.Cadastrar(v))
                {
                    Console.WriteLine("Vendedor cadastrado!");
                }
                else
                {
                    Console.WriteLine("Vendedor já existe.");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }
        }
    }
}
