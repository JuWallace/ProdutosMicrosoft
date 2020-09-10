using BancoDados.Dal;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDados.Views
{
    class ListarPessoa
    {
        public static void Renderizar()
        {
            Console.Clear();
            Console.WriteLine(" -- LISTAR PESSOAS -- \n");
            foreach (Pessoa pessoaCadastrada in PessoaDAO.ListarPessoa())
            {
                Console.WriteLine($"{pessoaCadastrada}");
            }



        }
    }
}
