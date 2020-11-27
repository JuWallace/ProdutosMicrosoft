using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Models
{
    public class Paciente : BaseModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Fone { get; set; }

    }
}
