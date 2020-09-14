using Microsoft.EntityFrameworkCore;
using ProjetoVendas.dal;
using ProjetoVendas.model;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoVendas.Dal
{
    class ClienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        private static List<Cliente> clientes = new List<Cliente>();

     //PRIMEIRO DESENVOLVER O MÉTODO LISTAR
        //public static List<Cliente> ListarClientes()
        //{
        //    return clientes;
        //}
        //public static List<Cliente> Listar() => clientes;
        public static List<Cliente> ListarCliente()
        {
            return ctx.Clientes.ToList();
        }

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
        public static Cliente BuscarClientePorCPF(string cpf)
        {
            //foreach (Cliente clienteCadastrado in clientes)
            //{
            //    if (clienteCadastrado.Cpf == cpf)
            //    {
            //        return clienteCadastrado;
            //    }
            //}
            //return null;
            //FirstOrDefault busca apenas um objeto 
            //com base na expressão LAMBDA
            return ctx.Clientes.FirstOrDefault(x => x.Cpf.Equals(cpf));
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
        public static bool CadastrarCliente(Cliente c)
        {
            //if (BuscarCliente(c.Cpf) == null)
            //{
            //    clientes.Add(c);
            //    return true;
            //}
            //return false;

            if(BuscarClientePorCPF(c.Cpf) == null)
            {
                ctx.Clientes.Add(c);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static void AlterarCliente(Cliente c)
        {
            ctx.Entry(c).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static void RemoverCliente(Cliente c)
        {
            ctx.Clientes.Remove(c);
            ctx.SaveChanges();
        }

    }
}
