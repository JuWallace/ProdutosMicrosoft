using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoVendas.model
{
    class Cliente
    {
        //CONSTRUTOR VAZIO
        public Cliente() => CriadoEm = DateTime.Now;

        //Atributos, propriedades e Caracteristicas
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() => $"Nome: {Nome} | Cpf: {Cpf} | Criado em: {CriadoEm}";
    }
}
