using System;

namespace ProjetoVendas.model
{
    class Cliente
    {
        //CONSTRUTOR VAZIO
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
