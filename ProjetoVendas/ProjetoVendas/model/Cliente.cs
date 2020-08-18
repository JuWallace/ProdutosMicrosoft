using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVendas.model
{
    class Cliente
    {
        //CONSTRUTOR
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }

        //Atributos, propriedades e Caracteristicas
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | Cpf: {Cpf} | Criado em: {CriadoEm}";
        }


    }
}
