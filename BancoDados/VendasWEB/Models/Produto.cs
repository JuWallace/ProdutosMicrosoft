using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasWEB.Models
{
    [Table("Produtos")]
    public class Produto : BaseModel
    {
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MinLength(5, ErrorMessage ="Mínimo 5 Caracteres!")]
        [MaxLength(100, ErrorMessage = "Máximo 5 Caracteres!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Range(1, 200, ErrorMessage = "Valores entre 1 e 200!")]
        public double Preco { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int Quantidade { get; set; }

        public string Imagem { get; set; }
        
        public int CategoriaId { get; set; }
        
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
        

    }
}
