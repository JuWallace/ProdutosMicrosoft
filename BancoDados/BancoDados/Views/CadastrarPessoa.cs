using BancoDados.Dal;
using BancoDados.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace BancoDados.Views
{
    [Table("Pessoa")]
    class CadastrarPessoa
    {
        public static void Renderizar()
        {
            //Context ctx = new Context();
            //ctx.Pessoas.Add(
            //new Pessoa
            //{
            //    Nome = "Juliano Wallace",
            //    Email = "juliano@positivo.com.br"
            //});
            //ctx.SaveChanges();
            //===================================================================================
            //Pessoa pessoa = new Pessoa();
            //Console.Clear();
            //Console.WriteLine(" --  CADASTRAR PESSOA -- \n");
            //Console.WriteLine("Digite o Nome:");
            //pessoa.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o E-mail:");
            //pessoa.Email = Console.ReadLine();

            //PessoaDAO.CadastrarPessoa(pessoa);

            //Console.WriteLine("Pessoa cadastrada com sucesso!");
            //===================================================================================

            Context ctx = new Context();
            Pessoa pessoa = new Pessoa();
            Console.Clear();
            Console.WriteLine(" --  CADASTRAR PESSOA -- \n");
            Console.WriteLine("Digite o Nome:");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite o E-Mail:");
            pessoa.Email = Console.ReadLine();

            if (PessoaDAO.CadastrarPessoa(pessoa))
            {
                Console.WriteLine("Pessoa cadastrada!!");
            }
            else
            {
                Console.WriteLine("Pessoa não foi cadastrada!!");
            }
            //ctx.Pessoas.Add(new Pessoa - old
            //{
            //    Nome = pessoa.Nome,
            //    Email = pessoa.Email
            //});
            ctx.SaveChanges();
            //Console.WriteLine("Pessoa cadastrada com sucesso!");

        }
    }
}
