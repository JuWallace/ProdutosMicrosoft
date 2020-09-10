using System;

namespace BancoDados.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("\t========================================\t");
                Console.WriteLine("\t|            BANCO DE DADOS            |\t");
                Console.WriteLine("\t========================================\t");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar Pessoa");
                Console.WriteLine("2 - Listar Pessoa");
                Console.WriteLine("3 - Buscar Pessoa por Nome");
                Console.WriteLine("4 - Buscar Pessoa por E-Mail");
                Console.WriteLine("5 - Alterar Pessoa por Nome");
                Console.WriteLine("6 - Remover Pessoa por Nome");
                Console.WriteLine("7 - ##");
                Console.WriteLine("8 - ##");
                Console.WriteLine("9 - ##");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nEscolha uma opção:");

                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        CadastrarPessoa.Renderizar();
                        break;
                    case 2:
                        ListarPessoa.Renderizar();
                        break;
                    case 3:
                        BuscarPessoaPorNome.Renderizar();
                        break;
                    case 4:
                        BuscarPessoaPorEmail.Renderizar();
                        break;
                    case 5:
                        AlterarPessoaPorNome.Renderizar();
                        break;
                    case 6:
                        RemoverPessoaPorNome.Renderizar();
                        break;
                    case 7:
                        
                        break;
                    case 8:
                        
                        break;
                    case 9:
                        Console.Clear();
                        break;
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
