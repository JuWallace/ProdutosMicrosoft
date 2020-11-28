using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Models
{
    public class Paciente : BaseModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Fone { get; set; }

        [ForeignKey("PlanoSaudeId")]
        public PlanoSaude PlanoSaude { get; set; }
        public int PlanoSaudeId { get; set; }

    }
}
