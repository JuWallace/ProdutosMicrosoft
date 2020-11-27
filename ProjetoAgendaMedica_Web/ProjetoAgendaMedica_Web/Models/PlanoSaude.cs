using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Models
{
    public class PlanoSaude : BaseModel
    {
        public String Plano { get; set; }
        public String Codigo { get; set; }
    }
}
