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
            Context ctx = new Context();
            ctx.Pessoas.Add(
            new Pessoa
            {
                Nome = "Juliano Wallace",
                Email = "juliano@positivo.com.br"
            });
            ctx.SaveChanges();
           
            
            //Pessoa pessoa = new Pessoa();

            //Console.Clear();
            //Console.WriteLine(" --  CADASTRAR PESSOA -- \n");
            //Console.WriteLine("Digite o Nome:");
            //Pessoa.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o E-mail:");
            //pessoa.Email = Console.ReadLine();


            //PessoaDAO.CadastrarPessoa(pessoa);
            Console.WriteLine("Pessoa cadastrada com sucesso!");
        }
    }
}
