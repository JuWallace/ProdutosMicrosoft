using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVendas
{
    class Menu
    {
        public static void ExecMenu()
        {
            int opcao;
            Cliente c = new Cliente();
            List<string> lst = new List<string>(); 
            do
            {
                Console.Clear();
                Console.WriteLine("\t========================================\t");
                Console.WriteLine("\t|            PROJETO VENDAS            |\t");
                Console.WriteLine("\t========================================\t");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Vendedor");
                Console.WriteLine("4 - Listar Vendedores");
                Console.WriteLine("5 - Cadastrar Produto");
                Console.WriteLine("6 - Listar Produtos");
                Console.WriteLine("7 - Registrar Venda");
                Console.WriteLine("8 - Listar Vendas");
                Console.WriteLine("9 - Listar Vendas por Cliente");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nEscolha uma opção:");
                    opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        string op = "1";
                        Console.WriteLine("\t========================================\t");
                        Console.WriteLine("\t|         Cadastro de Clientes         |\t");
                        Console.WriteLine("\t========================================\t");
                        Console.WriteLine();
                        while (op == "1") { 
                            //Adiciona o item à lista
                            Console.WriteLine("Digite o nome do Cliente: ");
                            c.Nome = Console.ReadLine();
                            lst.Add(c.Nome);
                            Console.WriteLine("Digite o CPF do Cliente: ");
                            c.Cpf = Console.ReadLine();
                            lst.Add(c.Cpf);
                            Console.WriteLine("Deseja inserir outro cliente? 1-SIM | 2-NÃO");
                            op = Console.ReadLine();
                        }
                        //Mensagem OK
                        //Console.WriteLine($"Nome cadastrado: {c.Nome} e CPF: {c.Cpf}");

                        //Ordena a lista
                        //lst.Sort();
                        //Console.WriteLine("A lista tem " + lst.Count + " itens:");
                        ////Imprime cada item da lista
                        //lst.ForEach(i => Console.WriteLine(i));
                        foreach (string alst in lst)
                        {
                            Console.WriteLine($"{alst}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("\t========================================\t");
                        Console.WriteLine("\t|           Lista de Clientes           |\t");
                        Console.WriteLine("\t========================================\t");
                        Console.WriteLine();

                        //Console.WriteLine($"{lst(c.Nome)} e {lst(c.Cpf)}");

                        break;
                    //case 3:
                    //    Exercicio03.Exec03();
                    //    break;
                    //case 4:
                    //    Exercicio04.Exec04();
                    //    break;
                    //case 5:
                    //    Exercicio05.Exec05();
                    //    break;
                    //case 6:
                    //    Exercicio06.Exec06();
                    //    break;
                    //case 7:
                    //    Exercicio07.Exec07();
                    //    break;
                    //case 8:
                    //    Exercicio08.Exec08();
                    //    break;
                    //case 9:
                    //    Exercicio09.Exec09();
                    //    break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("\nVolte sempre, aperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
