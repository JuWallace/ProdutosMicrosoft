using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using VendasWEB.Models;

namespace VendasWEB.Dal
{
    [Authorize]
    public class CategoriaDAO
    {
        private readonly Context _context;
        public CategoriaDAO(Context context) => _context = context;
        public List<Categoria> Listar() => _context.Categorias.ToList();
        public Categoria BuscarPorId(int id) => _context.Categorias.Find(id);
    }
}
