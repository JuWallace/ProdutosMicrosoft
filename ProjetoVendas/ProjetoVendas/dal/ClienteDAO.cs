using ProjetoVendas.model;
using System.Collections.Generic;


namespace ProjetoVendas.Dal
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();

     //PRIMEIRO DESENVOLVER O MÉTODO LISTAR
        //public static List<Cliente> ListarClientes()
        //{
        //    return clientes;
        //}
        public static List<Cliente> Listar() => clientes;

     //SEGUNDO DESENVOLVER O MÉTODO BUSCAR
        //public static Cliente BuscarClienteCpf(Cliente c)
        //{
        //    foreach (Cliente clienteCadastrado in clientes)
        //    {
        //        if (clienteCadastrado.Cpf.Equals(c.Cpf))
        //        {
        //            return clienteCadastrado;
        //        }
        //    }
        //    return null;
        //}
        public static Cliente BuscarCliente(string cpf)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if (clienteCadastrado.Cpf == cpf)
                {
                    return clienteCadastrado;
                }
            }
            return null;
        }

     //TERCEIRO DESENVOLVER O MÉTODO CADASTRAR
        //public static bool CadastrarCliente(Cliente c)
        //{
        //    if(BuscarClienteCpf(c) != null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        clientes.Add(c);
        //        return true;
        //    }
        //}
        public static bool Cadastrar(Cliente c)
        {
            if (BuscarCliente(c.Cpf) == null)
            {
                clientes.Add(c);
                return true;
            }
            return false;
        }
    }
}
