using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Models
{
    [Table("Pacientes")]
    public class Paciente : Pessoa
    {
        [ForeignKey("PlanoSaudeId")]
        public PlanoSaude PlanoSaude { get; set; }
        public int PlanoSaudeId { get; set; }
    }
}
