using ProjetoVendas.dal;
using ProjetoVendas.Dal;
using ProjetoVendas.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVendas.view
{
    class CadastrarVenda
    {
        public static void ExecCadastrarVenda()
        {
            Venda venda = new Venda();
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();
            ItemVenda iv = new ItemVenda();

           
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|            Registrar Venda           |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            //Cliente
            Console.WriteLine("Digite o CPF do Cliente");
            c.Cpf = Console.ReadLine();
            c = ClienteDAO.BuscarCliente(c.Cpf);

            if (c != null)
            {
                venda.Cliente = c;

                //Vendedor
                Console.WriteLine("Digite o CPF do Vendedor");
                v.Cpf = Console.ReadLine();
                v = VendedorDAO.BuscarVendedor(v.Cpf);
                if (v != null)
                {
                    venda.Vendedor = v;

                    //Produto
                    //Console.WriteLine("Digite o Nome do Produto");
                    //p.Nome = Console.ReadLine();
                    //p = ProdutoDAO.BuscarProduto(p.Nome);
                    //if (p != null)
                    //{
                    //    venda.Produto = p;
                    //    Console.WriteLine("Digite a Quantidade do Produto:");
                    //    venda.Quantidade = Convert.ToInt32(Console.ReadLine());

                    //    VendaDAO.CadastrarVenda(venda);
                    //    Console.WriteLine("Venda cadastrada!!");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Produto não encontrado!");
                    //}

                    do
                    {
                        p = new Produto();
                        iv = new ItemVenda();
                        Console.WriteLine("\t========================================\t");
                        Console.WriteLine("\t|          Adicionar Produtos          |\t");
                        Console.WriteLine("\t========================================\t");
                        Console.WriteLine();
                        Console.Clear();
                        Console.WriteLine("Nome do Produto:");
                        p.Nome = Console.ReadLine();
                        p = ProdutoDAO.BuscarProdutoPorNome(p);
                        if (p != null)
                        {
                            iv.Produto = p;
                            iv.Preco = p.Preco;
                            Console.WriteLine("Quantidade do Produto:");
                            iv.Quantidade = Convert.ToInt32(Console.ReadLine());
                            venda.Itens.Add(iv);
                            Console.WriteLine("Produto Adicionado!!");
                        }
                        else
                        {
                            Console.WriteLine("Produto não existe!");
                        }
                        Console.WriteLine("\nDeseja Adicionar mais Produto? (S)sim |(N)não");
                    } while (Console.ReadLine().ToUpper().Equals("S"));
                    VendaDAO.CadastrarVenda(venda);
                    Console.WriteLine("Venda registrada!");
                }
                else
                {
                    Console.WriteLine("Vendedor não encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
            
        }
    }
}
