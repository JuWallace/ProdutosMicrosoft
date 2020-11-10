using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using VendasWEB.Dal;
using VendasWEB.Models;

namespace VendasWEB.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        private readonly IWebHostEnvironment _hosting;

        public ProdutoController(ProdutoDAO produtoDAO, IWebHostEnvironment hosting)
        {
            _produtoDAO = produtoDAO;
            _hosting = hosting;
        }

        public IActionResult Index()
        {
            return View(_produtoDAO.Listar());
        }

        public IActionResult Cadastrar() => View();

        [HttpPost]
        public IActionResult Cadastrar(Produto produto, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if(file != null)
                {

                    ///string arquivo = Path.GetFileName(file.FileName);
                    string arquivo = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                    string caminho = Path.Combine(_hosting.WebRootPath, "images", arquivo);
                    file.CopyTo(new FileStream(caminho, FileMode.CreateNew));
                    produto.Imagem = arquivo;
                }
                else
                {
                    produto.Imagem = "SemImagem.jpg";
                }

                if (_produtoDAO.Cadastrar(produto))
                {
                    return RedirectToAction("Index", "Produto");
                }
                ModelState.AddModelError("", "Já existe um Produto com este nome!");
            }
            return View();
        }

        public IActionResult Remover(int id)
        {
            _produtoDAO.Remover(id);
            return RedirectToAction("Index", "Produto");
        }

        public IActionResult Editar(int Id)
        {
            return View(_produtoDAO.BuscarPorId(Id));
        }
        [HttpPost]
        public IActionResult Editar(Produto produto)
        {
            _produtoDAO.Alterar(produto);
            return RedirectToAction("Index", "Produto");
        }
    }
}
