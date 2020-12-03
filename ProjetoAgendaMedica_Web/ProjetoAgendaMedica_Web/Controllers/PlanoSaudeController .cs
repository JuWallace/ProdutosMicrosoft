﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoAgendaMedica_Web.Dal;
using ProjetoAgendaMedica_Web.Models;


namespace ProjetoAgendaMedica_Web.Controllers
{
    [Authorize]
    public class PlanoSaudeController : Controller
    {
        private readonly PlanoSaudeDAO _planosaudeDAO;
        private readonly IWebHostEnvironment _hosting;
        public PlanoSaudeController(PlanoSaudeDAO planosaudeDAO,
                                 IWebHostEnvironment hosting)
        {
            _planosaudeDAO = planosaudeDAO;
            _hosting = hosting;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Gerenciamento de Planos de Saúde";
            return View(_planosaudeDAO.Listar());
        }
        public IActionResult Cadastrar()
        {
            ViewBag.PlanosSaude = new SelectList(_planosaudeDAO.Listar(), "Id", "Plano", "Codigo");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(PlanoSaude planosaude, IFormFile file)
        {
            if (ModelState.IsValid)
            {                
                if (_planosaudeDAO.Cadastrar(planosaude))
                {
                    return RedirectToAction("Index", "PlanoSaude");
                }
                ModelState.AddModelError("", "Já existe um Plano com o mesmo nome!");
            }
            ViewBag.PlanosSaude = new SelectList(_planosaudeDAO.Listar(), "Id", "Plano", "Codigo");
            return View(planosaude);
        }
        public IActionResult Remover(int id)
        {
            _planosaudeDAO.Remover(id);
            return RedirectToAction("Index", "PlanoSaude");
        }
        public IActionResult Alterar(int id)
        {
            ViewBag.PlanosSaude = new SelectList(_planosaudeDAO.Listar(), "Id", "Plano", "Codigo");
            return View(_planosaudeDAO.BuscarPorId(id));
        }
        [HttpPost]
        public IActionResult Alterar(PlanoSaude planosaude)
        {
            _planosaudeDAO.Alterar(planosaude);
            return RedirectToAction("Index", "PlanoSaude");
        }
    }
}
