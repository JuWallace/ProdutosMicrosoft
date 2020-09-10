using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDados.Dal
{
    class PessoaDAO
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();

        //Metodo Listar
        public static List<Pessoa> ListarPessoa() => pessoas;

        //Metodo Buscar
        public static Pessoa BuscarPessoa(string nome)
        {
            foreach (Pessoa pessoaCadastrada in pessoas)
            {
                if (pessoaCadastrada.Nome == nome)
                {
                    return pessoaCadastrada;
                }
            }
            return null;
        }

        public static Pessoa BuscarPessoaPorNome(string nome)
        {
            foreach (Pessoa pessoaCadastrada in pessoas)
            {
                if(pessoaCadastrada.Nome == nome)
                {
                    return pessoaCadastrada;
                }
            }
            return null;
        }

        public static Pessoa BuscarPessoaPorEmail(string email)
        {
            foreach (Pessoa pessoaCadastrada in pessoas)
            {
                if (pessoaCadastrada.Email == email)
                {
                    return pessoaCadastrada;
                }
            }
            return null;
        }

        //Metodo Cadastrar
        public static bool CadastrarPessoa(Pessoa p)
        {
            if(BuscarPessoa(p.Email) == null)
            {
                pessoas.Add(p);
                return true;
            }
            return false;
        }

        //public static void AlterarPessoa(Pessoa p)
        //{
        //    Entry(p).State = EntityState.Modified;
        //    SaveChanges();
        //}

        public static void RemoverPessoa(Pessoa p)
        {
            pessoas.Remove(p);
            //SaveChanges();
        }

    }
}
