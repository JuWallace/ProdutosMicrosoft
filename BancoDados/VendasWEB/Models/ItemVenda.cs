using System.ComponentModel.DataAnnotations.Schema;


namespace VendasWEB.Models
{
    [Table("ItensVenda")]
    public class ItemVenda : BaseModel
    {
        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string CarrinhoId { get; set; }
    }
}
