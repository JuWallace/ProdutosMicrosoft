using ProjetoVendas.model;
using System.Collections.Generic;


namespace ProjetoVendas.dal
{
    class VendedorDAO
    {
        private VendedorDAO() { }
        private static List<Vendedor> vendedores = new List<Vendedor>();

        //LISTA GERAL
        public static List<Vendedor> Listar() => vendedores;

        //BUSCA POR CPF
        public static Vendedor BuscarVendedor(string cpf)
        {
            foreach (Vendedor vendedorCadastrado in vendedores)
            {
                if(vendedorCadastrado.Cpf == cpf)
                {
                    return vendedorCadastrado;
                }
            }
            return null;
        }

        //CADASTRAR
        public static bool Cadastrar(Vendedor v)
        {
            if(BuscarVendedor(v.Cpf) == null)
            {
                vendedores.Add(v);
                return true;
            }
            return false;
        }
    }
}
