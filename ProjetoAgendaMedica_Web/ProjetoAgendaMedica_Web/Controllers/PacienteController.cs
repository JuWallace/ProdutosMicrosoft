﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoAgendaMedica_Web.Dal;
using ProjetoAgendaMedica_Web.Models;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Controllers
{
    public class PacienteController : Controller
    {
        private readonly Context _context;
        private readonly PacienteDAO _pacienteDAO;
        private readonly PlanoSaudeDAO _planosaudeDAO;
        private readonly IWebHostEnvironment _hosting;

        public PacienteController(IWebHostEnvironment hosting,
                                  PacienteDAO pacienteDAO, PlanoSaudeDAO planosaudeDAO)
        {
            _pacienteDAO = pacienteDAO;
            _planosaudeDAO = planosaudeDAO;
            _hosting = hosting;

        }
        public IActionResult Index()
        {
            ViewBag.Title = "Gerenciamento de Pacientes";
            return View(_pacienteDAO.Listar());
        }
        public IActionResult Cadastrar()
        {
            ViewBag.PlanosSaude = new SelectList(_planosaudeDAO.Listar(), "Id", "Plano", "Codigo");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Paciente paciente, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                paciente.PlanoSaude = _planosaudeDAO.BuscarPorId(paciente.PlanoSaudeId);
                if (_pacienteDAO.Cadastrar(paciente))
                {
                    return RedirectToAction("Index", "Paciente");
                }
                ModelState.AddModelError("", "Já existe um paciente com o mesmo nome!");
            }
            ViewBag.PlanosSaude = new SelectList(_planosaudeDAO.Listar(), "Id", "Plano", "Codigo");
            return View(paciente);
        }


        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Remover(int id)
        {
            _pacienteDAO.Remover(id);
            return RedirectToAction("Index", "Paciente");
        }
        public IActionResult Alterar(int id)
        {
            ViewBag.PlanosSaude = new SelectList(_planosaudeDAO.Listar(), "Id", "Plano", "Codigo");
            return View(_pacienteDAO.BuscarPorId(id));
        }
        [HttpPost]
        public IActionResult Alterar(Paciente paciente)
        {
            _pacienteDAO.Alterar(paciente);
            return RedirectToAction("Index", "Paciente");
        }

        public IActionResult AgendarPaciente(int id)
        {
            Paciente paciente = _pacienteDAO.BuscarPorId(id);
            
            return RedirectToAction("Agendar", new { paciente });
        }

        [HttpGet]
        public IActionResult Agendar(Paciente paciente)
        {   
            ViewBag.Title = "Agendar";
            //string carrinhoId = _sessao.BuscarCarrinhoId();
            //ViewBag.Total = _itemvendaDAO.SomarTotalCarrinho(carrinhoId);
            return RedirectToAction("Index", "Consulta",new { p = paciente.Id });
        }
    }
}
