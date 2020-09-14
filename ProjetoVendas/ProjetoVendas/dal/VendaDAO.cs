using ProjetoVendas.model;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoVendas.dal
{
    class VendaDAO
    {
        //private static Context ctx = SingletonContext.GetInstance();
        private static List<Venda> vendas = new List<Venda>();

        public static void CadastrarVenda(Venda v) => vendas.Add(v);

        public static List<Venda> ListarVenda() => vendas;
        //public static List<Venda> ListarVenda()
        //{
        //    return ctx.Vendas.ToList();
        //}


        public static List<Venda> ListarVendasPorCliente(string cpf)
        {
            List<Venda> aux = new List<Venda>();
            foreach (Venda vendaCadastrada in vendas)
            {
                if (vendaCadastrada.Cliente.Cpf.Equals(cpf))
                {
                    aux.Add(vendaCadastrada);
                    //ctx.Vendas.Add(vendaCadastrada);
                }

            }
            return aux;
            
        }

        

    }
    
}
