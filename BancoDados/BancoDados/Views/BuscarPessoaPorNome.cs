using BancoDados.Dal;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDados.Views
{
    class BuscarPessoaPorNome
    {
        public static void Renderizar()
        {
            Pessoa pessoa = new Pessoa();
            Console.Clear();
            Console.WriteLine(" --  BUSCAR PESSOA POR NOME -- \n");
            Console.WriteLine("Digite o nome:");
            pessoa.Nome = Console.ReadLine();
            pessoa = PessoaDAO.BuscarPessoaPorNome(pessoa.Nome);
            if (pessoa != null)
            {
                Console.WriteLine("Nome: " + pessoa.Nome);
                Console.WriteLine("E-Mail: " + pessoa.Email);
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada!");
            }
        }
    }
}
