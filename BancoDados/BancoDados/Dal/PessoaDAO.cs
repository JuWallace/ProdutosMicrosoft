using BancoDados.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BancoDados.Dal
{
    class PessoaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        //private static Context ctx = new Context();
        //private static List<Pessoa> pessoas = new List<Pessoa>();

        //Metodo Listar
        //public static List<Pessoa> ListarPessoa() => pessoas; - old
        public static List<Pessoa> ListarPessoa() => ctx.Pessoas.ToList();
        //{
        //    return ctx.Pessoas.ToList();
        //}

        //Metodo Buscar
        //public static Pessoa BuscarPessoa(string nome)
        //{
        //    foreach (Pessoa pessoaCadastrada in pessoas)
        //    {
        //        if (pessoaCadastrada.Nome == nome)
        //        {
        //            return pessoaCadastrada;
        //        }
        //    }
        //    return null;
        //}
        public static Pessoa BuscarPorId(int _id) => ctx.Pessoas.Find(_id);
        public static Pessoa BuscarPessoaPorNome(string nome) => ctx.Pessoas.FirstOrDefault(x => x.Nome.Equals(nome));
        //{
            //foreach (Pessoa pessoaCadastrada in pessoas) - old
            //{
            //    if(pessoaCadastrada.Nome == nome)
            //    {
            //        return pessoaCadastrada;
            //    }
            //}
            //return null;

            //FirstOrDefault busca apenas um objeto 
            //com base na expressão LAMBDA
            //return ctx.Pessoas.FirstOrDefault(x => x.Nome.Equals(nome));
        //}
        public static Pessoa BuscarPessoaPorEmail(string email) => ctx.Pessoas.FirstOrDefault(x => x.Email.Equals(email));
        
        public static Pessoa BuscarPessoaPorEmailUnico(string email)
        {
            try
            {
                //Com o SingleOrDefaul se ouver mais de um registro irá estourar excessão
                return ctx.Pessoas.SingleOrDefault(x => x.Email.Equals(email));
            }
            catch (global::System.Exception)
            {

                throw new Exception("Existem mais de um registro na busca!"); 
            }
        }

        public static List<Pessoa> FiltrarPorParteNome(string partNome) => 
            ctx.Pessoas.Where(x => x.Nome.Contains(partNome)).ToList();
        
        //{
        //foreach (Pessoa pessoaCadastrada in pessoas) - old
        //{
        //    if (pessoaCadastrada.Email == email)
        //    {
        //        return pessoaCadastrada;
        //    }
        //}
        //return null;

        //FirstOrDefault busca apenas um objeto 
        //com base na expressão LAMBDA
        //    return ctx.Pessoas.FirstOrDefault(x => x.Email.Equals(email));
        //}

        //Metodo Cadastrar
        public static bool CadastrarPessoa(Pessoa p)
        {
            //if(BuscarPessoa(p.Email) == null) - old
            //{
            //    pessoas.Add(p);
            //    return true;
            //}
            //return false;

            if (BuscarPessoaPorEmail(p.Email) == null)
            {
                ctx.Pessoas.Add(p);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static void AlterarPessoa(Pessoa p)
        {
            //ctx.Entry(p).State = EntityState.Modified;
            //ctx.SaveChanges();

            ctx.Pessoas.Update(p);
            ctx.SaveChanges();
        }

        public static void RemoverPessoa(Pessoa p)
        {
            ctx.Pessoas.Remove(p);
            ctx.SaveChanges();
        }

    }
}
