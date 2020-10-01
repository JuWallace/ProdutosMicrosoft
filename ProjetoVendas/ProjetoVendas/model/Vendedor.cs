using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoVendas.model
{
    class Vendedor
    {
        public Vendedor() => CriadoEm = DateTime.Now;

        [Key]
        public int VendedorId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() => $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        

    }
}
