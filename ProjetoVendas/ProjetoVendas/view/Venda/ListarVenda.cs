using ProjetoVendas.dal;
using ProjetoVendas.model;
using System;
using System.Collections.Generic;

namespace ProjetoVendas.view
{
    class ListarVenda
    {
        public static void ExecListarVenda(List<Venda> vendas)
        {
            //double totalGeral = 0, totalVenda = 0, totalItem = 0;
            //Console.WriteLine("\t========================================\t");
            //Console.WriteLine("\t|             Listar Venda             |\t");
            //Console.WriteLine("\t========================================\t");
            //Console.WriteLine();
            //foreach (Venda vendaCadastrada in VendaDAO.Listar())
            //{
            //    totalVenda = 0;
            //    Console.WriteLine($"Cliente: {vendaCadastrada.Cliente.Nome}");
            //    Console.WriteLine($"Vendedor: {vendaCadastrada.Vendedor.Nome}");
            //    Console.WriteLine("\n ---- ITENS DA VENDA ---- \n");
            //    Console.WriteLine($"\t{vendaCadastrada.Produto.Nome}");
            //    totalItem = vendaCadastrada.Produto.Preco * vendaCadastrada.Quantidade;
            //    Console.WriteLine
            //        ($"\t{vendaCadastrada.Produto.Preco:C2} x " +
            //            $"{vendaCadastrada.Quantidade} = {totalItem:C2}");
            //    totalVenda += totalItem;
            //    Console.WriteLine($"\n\tTotal da venda: {totalVenda:C2}");
            //    totalGeral += totalVenda;
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Total geral: {totalGeral:C2}");

            double subtotal, totalVenda = 0, totalGeral = 0;
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|            Itens da Venda            |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();
            foreach (Venda vendaCadastrada in vendas)
            {
                //VENDA
                Console.WriteLine($"Data: {vendaCadastrada.CriadoEm.ToLongDateString()}");
                Console.WriteLine($"Cliente: {vendaCadastrada.Cliente.Nome}");
                Console.WriteLine($"Vendedor: {vendaCadastrada.Vendedor.Nome}");
                Console.WriteLine("\n -- ITENS -- ");
                //ITENS DA VENDA
                foreach (ItemVenda itemCadastrado in vendaCadastrada.Itens)
                {
                    Console.WriteLine("\t" + itemCadastrado.Produto.Nome);
                    subtotal = itemCadastrado.Quantidade * itemCadastrado.Preco;
                    Console.WriteLine("\t" + itemCadastrado.Quantidade + 
                        " x " + itemCadastrado.Preco.ToString("C2") +
                        " = " + subtotal.ToString("C2"));
                    totalVenda += subtotal;
                }
                Console.WriteLine("\nTotal da venda: " + totalVenda.ToString("C2") + "\n");
                totalGeral += totalVenda;
            }
            Console.WriteLine("\nTotal geral: " + totalGeral.ToString("C2"));
        }
    }
}
