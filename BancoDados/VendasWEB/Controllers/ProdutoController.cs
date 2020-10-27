using Microsoft.AspNetCore.Mvc;
using VendasWEB.Dal;
using VendasWEB.Models;

namespace VendasWEB.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;

        public ProdutoController(ProdutoDAO produtoDAO) => _produtoDAO = produtoDAO;

        public IActionResult Index()
        {
            ViewBag.Produtos = _produtoDAO.Listar();
            return View();
        }

        public IActionResult Cadastrar() => View();
        
        //[HttpPost]
        //public IActionResult Cadastrar(string txtNome,
        //                               string txtDescricao,
        //                               double txtPreco,
        //                               int txtQuantidade)
        //{
        //    Produto produto = new Produto
        //    {
        //        Nome = txtNome,
        //        Descricao = txtDescricao,
        //        Preco = txtPreco,
        //        Quantidade = txtQuantidade
        //    };

        //    _context.Produtos.Add(produto);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Produto");
        //}

        //public IActionResult Remover(int id)
        //{
        //    _context.Produtos.Remove(_context.Produtos.Find(id));
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Produto");
        //}

        //public IActionResult Editar(int id)
        //{
        //    ViewBag.Produto = _context.Produtos.Find(id);
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Editar(int txtid,
        //                               string txtNome,
        //                               string txtDescricao,
        //                               double txtPreco,
        //                               int txtQuantidade)
        //{
        //    Produto produto = _context.Produtos.Find(txtid);
        //    {
        //        produto.Nome = txtNome;
        //        produto.Descricao = txtDescricao;
        //        produto.Preco = txtPreco;
        //        produto.Quantidade = txtQuantidade;
        //    }
        //    _context.Produtos.Update(produto);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Produto");
        //}
    }
}
