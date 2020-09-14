using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace ProjetoVendas.model
{
    class Produto
    {
        public Produto() => CriadoEm = DateTime.Now;

        [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QtdeProduto { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | Quantidade: {QtdeProduto} | Preço: {Preco.ToString("F2", CultureInfo.InvariantCulture)} un | Criado em: {CriadoEm}.";
        }
    }
}
