using ProjetoVendas.model;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoVendas.dal
{
    class VendedorDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        private static List<Vendedor> vendedores = new List<Vendedor>();

        //LISTA GERAL
        //public static List<Vendedor> Listar() => vendedores;
        public static List<Vendedor> ListarVendedor()
        {
            return ctx.Vendedores.ToList();
        }

        //BUSCA POR CPF
        public static Vendedor BuscarVendedorPorCpf(string cpf)
        {
            foreach (Vendedor vendedorCadastrado in vendedores)
            {
                //if(vendedorCadastrado.Cpf == cpf)
                //{
                //    return vendedorCadastrado;
                //}
                return ctx.Vendedores.FirstOrDefault(x => x.Cpf.Equals(cpf));
            }
            return null;
        }

        //CADASTRAR
        public static bool CadastrarVendedor(Vendedor v)
        {
            if(BuscarVendedorPorCpf(v.Cpf) == null)
            {
                ctx.Vendedores.Add(v);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
