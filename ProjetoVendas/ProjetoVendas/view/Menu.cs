using System;


namespace ProjetoVendas.view
{
    class Menu
    {
        public static void ExecMenu()
        {
            int opcao;
       
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
                        CadastrarCliente.ExecCadastrarCliente();
                        break;
                    case 2:
                        ListarCliente.ExecListarClientes();
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
