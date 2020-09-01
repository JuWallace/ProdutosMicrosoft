using ProjetoVendas.model;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ProjetoVendas.dal
{
    class VendaDAO
    {
        private static List<Venda> vendas = new List<Venda>();
        public static void CadastrarVenda(Venda v) => vendas.Add(v);
        public static List<Venda> Listar() => vendas;
        public static List<Venda> ListarVendasPorCliente(string cpf)
        {
            List<Venda> aux = new List<Venda>();
            foreach (Venda vendaCadastrada in vendas)
            {
                if (vendaCadastrada.Cliente.Cpf.Equals(cpf))
                {
                    aux.Add(vendaCadastrada);
                }
            }
            return aux;
        }

    }
    
}
