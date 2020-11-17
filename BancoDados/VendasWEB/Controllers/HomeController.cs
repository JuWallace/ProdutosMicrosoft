using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendasWEB.Dal;
using VendasWEB.Models;

namespace VendasWEB.Controllers
{
    public class HomeController  : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        private readonly CategoriaDAO _categoriaDAO;

        public HomeController(ProdutoDAO produtoDAO, CategoriaDAO categoriaDAO)
        {
            _produtoDAO = produtoDAO;
            _categoriaDAO = categoriaDAO;
        }

        public IActionResult Index(int id)
        {
            ViewBag.Categorias = _categoriaDAO.Listar();
            List<Produto> produtos = id == 0 ?
            _produtoDAO.Listar() :
            _produtoDAO.BuscarPorCategoria(id);
            return View(produtos);

            //if (id == 0)
            //{
            //    return View(_produtoDAO.Listar());
            //}
            //return View(_produtoDAO.BuscarPorCategoria(id));
        }

        public IActionResult AdicionarAoCarrinho(int id)
        {

        }
    }
}
