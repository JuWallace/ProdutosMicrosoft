using BancoDados.Dal;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDados.Views
{
    class RemoverPessoaPorNome
    {
        public static void Renderizar()
        {
            Pessoa pessoa = new Pessoa();
            Console.Clear();
            Console.WriteLine(" --  REMOVER PESSOA POR NOME -- \n");
            Console.WriteLine("Digite o Nome:");
            pessoa.Nome = Console.ReadLine();
            pessoa = PessoaDAO.BuscarPessoaPorNome(pessoa.Nome);
            if (pessoa != null)
            {
                Console.WriteLine("\nNome: " + pessoa.Nome);
                Console.WriteLine("E-Mail: " + pessoa.Email + "\n");
                Console.WriteLine("Deseja realmente REMOVER esse registro? | [S]-Sim:[N]-Não");
                if (Console.ReadLine().ToUpper().Equals("S"))
                {
                    PessoaDAO.RemoverPessoa(pessoa);
                    Console.WriteLine("Pessoa REMOVIDA!");
                }
                else
                {
                    Console.WriteLine("Operação cancelada!");
                }
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada!");
            }
        }
    }
}
