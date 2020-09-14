using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using ProjetoVendas.dal;
using ProjetoVendas.model;

namespace ProjetoVendas.view
{
    [Table("Produto")]
    class CadastrarProduto
    {
        public static void ExecCadastrarProduto()
        {
            Produto p = new Produto();
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|         Cadastro de Produtos         |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            Console.WriteLine("Digite o Nome do Produto");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Preço do Produto");
            p.Preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a Quantidade do Produto");
            p.QtdeProduto = Convert.ToInt32(Console.ReadLine());

            if (ProdutoDAO.CadastrarProduto(p))
            {
                Console.WriteLine("Produto cadastrado!");
            }
            else
            {
                Console.WriteLine("Produto já existe!");
            }
        }
    }
}
