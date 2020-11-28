using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Models
{
    public class Consulta : BaseModel
    {
        public Consulta() 
        {
            Paciente = new Paciente(); 
            Medico = new Medico();
        }

        [ForeignKey("PacienteId")]
        public Paciente Paciente { get; set; }
        public int PacienteId { get; set; }

        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
        public int MedicoId { get; set; }

        public DateTime DataConsulta { get; set; }
        public DateTime HoraConsulta { get; set; }

    }
}
