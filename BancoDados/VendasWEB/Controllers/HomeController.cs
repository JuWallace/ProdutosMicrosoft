using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendasWEB.Dal;
using VendasWEB.Models;
using VendasWEB.Utils;

namespace VendasWEB.Controllers
{
    public class HomeController  : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        private readonly CategoriaDAO _categoriaDAO;
        private readonly ItemVendaDAO _itemvendaDAO;
        private readonly Sessao _sessao;

        public HomeController(ProdutoDAO produtoDAO,
                              CategoriaDAO categoriaDAO,
                              ItemVendaDAO itemVendaDAO,
                              Sessao sessao)
        {
            _produtoDAO = produtoDAO;
            _categoriaDAO = categoriaDAO;
            _itemvendaDAO = itemVendaDAO;
            _sessao = sessao;
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
            Produto produto = _produtoDAO.BuscarPorId(id);
            ItemVenda item = new ItemVenda
            {
                Produto = produto,
                Preco = produto.Preco,
                Quantidade = 1,
                CarrinhoId = _sessao.BuscarCarrinhoId()
            };
            _itemvendaDAO.Cadatrar(item);
            return RedirectToAction("CarrinhoCompras");
        }

        public IActionResult CarrinhoCompras()
        {
            ViewBag.Title = "Carrinho de compras";
            string carrinhoId = _sessao.BuscarCarrinhoId();
            ViewBag.Total = _itemvendaDAO.SomarTotalCarrinho(carrinhoId);
            return View(_itemvendaDAO.ListarPorCarrinhoId(carrinhoId));
        }
    }
}
