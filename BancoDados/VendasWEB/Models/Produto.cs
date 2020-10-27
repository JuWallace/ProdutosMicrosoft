using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWEB.Models
{
    [Table("Produtos")]
    public class Produto : BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        

    }
}
