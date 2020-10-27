using System.Collections.Generic;
using System.Linq;
using VendasWEB.Models;

namespace VendasWEB.Dal
{
    public class ProdutoDAO
    {
        private readonly Context _context;
        public ProdutoDAO(Context context) => _context = context;

        public List<Produto> Listar() => _context.Produtos.ToList();
    }
}
