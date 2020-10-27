
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaMedica_WEB.Models
{
    [Table("Usuarios")]
    public class Usuario : Pessoa
    {
        [DisplayName("Senha:")]
        public string Senha { get; set; }

        [DisplayName("ADM:")]
        public bool Administrador { get; set; }

        [DisplayName("MED:")]
        public bool Medico { get; set; }

        [DisplayName("ATE:")]
        public bool Atendente { get; set; }
    }
}
