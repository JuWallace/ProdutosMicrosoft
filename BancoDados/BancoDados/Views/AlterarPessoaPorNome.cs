using BancoDados.Dal;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDados.Views
{
    class AlterarPessoaPorNome
    {
        public static void Renderizar()
        {
            Pessoa pessoa = new Pessoa();
            Console.Clear();
            Console.WriteLine(" --  ALTERAR PESSOA POR NOME -- \n");
            Console.WriteLine("Digite o Nome:");
            pessoa.Nome = Console.ReadLine();
            pessoa = PessoaDAO.BuscarPessoaPorNome(pessoa.Nome);
            if (pessoa != null)
            {
                Console.WriteLine("\nNome: " + pessoa.Nome);
                Console.WriteLine("E-Mail: " + pessoa.Email + "\n");
                Console.WriteLine("Deseja realmente ALTERAR esse registro? | [S]-Sim:[N]-Não");
                if (Console.ReadLine().ToUpper().Equals("S"))
                {
                    Console.WriteLine("Informe o novo Nome:");
                    pessoa.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o novo E-Mail:");
                    pessoa.Email = Console.ReadLine();

                    PessoaDAO.AlterarPessoa(pessoa);
                    Console.WriteLine("Pessoa ALTERADA!");
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
