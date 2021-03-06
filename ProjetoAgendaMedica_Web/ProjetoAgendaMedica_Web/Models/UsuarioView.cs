﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetoAgendaMedica_Web.Models
{
    public class UsuarioView : Pessoa
    {
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Senha { get; set; }

        [Display(Name = "Confirmação da senha")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [NotMapped]
        [Compare("Senha", ErrorMessage = "Campos não coincidem!")]
        public string ConfirmacaoSenha { get; set; }

    }
}
