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
            Cliente c;
            List<Cliente> clientes = new List<Cliente>(); 
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
                        c = new Cliente();
                        Console.WriteLine("\t========================================\t");
                        Console.WriteLine("\t|         Cadastro de Clientes         |\t");
                        Console.WriteLine("\t========================================\t");
                        Console.WriteLine();

                       //Adiciona o item à lista
                       Console.WriteLine("Digite o nome do Cliente: ");
                       c.Nome = Console.ReadLine();
                       Console.WriteLine("Digite o CPF do Cliente: ");
                       c.Cpf = Console.ReadLine();

                        //VERIFICAÇÃO DO CPF
                        if (model.ValidaCPF.IsCpf(c.Cpf))
                        {
                            if(clientes.Count == 0)
                            {
                                clientes.Add(c);
                                Console.WriteLine("Cliente salvo com sucesso!");
                            }
                            else
                            {
                                //for (int i = 0; i < clientes.Count; i++)
                                //{
                                //    if (clientes[i].Cpf == c.Cpf)
                                //    {
                                //        Console.WriteLine("CPF já existente.");
                                //    }
                                //    else
                                //    {
                                //        clientes.Add(c);
                                //        Console.WriteLine("Cliente salvo com sucesso!");
                                //    }
                                //}

                                bool encontrado = false;
                                foreach (Cliente clienteCadastrado in clientes)
                                {
                                    if (clienteCadastrado.Cpf == c.Cpf)
                                    {
                                        
                                        encontrado = true;
                                    }
                                }
                                if (!encontrado)
                                {
                                    //Permitir o cadastro
                                    clientes.Add(c);
                                    Console.WriteLine("Cliente salvo com sucesso!");
                                }
                                else
                                {
                                    //Não permitir o cadastro
                                    Console.WriteLine("CPF já existente.");
                                    
                                }


                            }
                            
                        }
                            break;
                    case 2:
                        Console.WriteLine("\t========================================\t");
                        Console.WriteLine("\t|           Lista de Clientes          |\t");
                        Console.WriteLine("\t========================================\t");
                        Console.WriteLine();

                        //ORDENA LISTA
                        //lst.Sort();
                        //Console.WriteLine("A lista tem " + lst.Count + " itens:");
                        ////Imprime cada item da lista
                        //lst.ForEach(i => Console.WriteLine(i));
                        //Console.WriteLine("NOME:         CPF:");
                        //foreach (Cliente alst in lstCliente)
                        //{
                        //    Console.Write($"{alst} |  ");
                        //}
                        for (int i = 0; i < clientes.Count; i++)
                        {
                            Console.WriteLine(clientes[i]);
                        }

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
