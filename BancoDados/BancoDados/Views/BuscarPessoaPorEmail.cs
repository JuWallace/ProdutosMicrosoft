using BancoDados.Dal;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDados.Views
{
    class BuscarPessoaPorEmail
    {
        public static void Renderizar()
        {
            Pessoa pessoa = new Pessoa();
            Console.Clear();
            Console.WriteLine(" --  BUSCAR PESSOA POR EMAIL -- \n");
            Console.WriteLine("Digite o E-Mail:");
            pessoa.Email = Console.ReadLine();
            pessoa = PessoaDAO.BuscarPessoaPorEmail(pessoa.Email);
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
