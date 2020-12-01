using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace VendasWEB.Models
{
    public class Usuario : IdentityUser
    {
        public Usuario() => CriadoEm = DateTime.Now;
        public DateTime CriadoEm { get; set; }

        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Display(Name = "Rua")]
        public string Rua { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "UF")]
        public string Uf { get; set; }
    }
}
