using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Models
{
    [Table("Medicos")]
    public class Medico : Pessoa
    {
        public string CRM { get; set; }
        public string Especialidade { get; set; }

    }
}
