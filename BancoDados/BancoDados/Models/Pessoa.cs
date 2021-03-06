﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BancoDados.Models
{
    class Pessoa
    {
        public Pessoa() => CriadoEm = DateTime.Now;
        
        [Key]
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime CriadoEm { get; set; }


        public override string ToString() => $"Nome: {Nome} | E-Mail: {Email} | Criado em: {CriadoEm}";
        //{
        //    return $"Nome: {Nome} | E-Mail: {Email} | Criado em: {CriadoEm}";
        //}
    }
}
