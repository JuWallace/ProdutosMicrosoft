using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoAgendaMedica_Web.Dal;
using ProjetoAgendaMedica_Web.Models;
using ProjetoAgendaMedica_Web.Utils;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly PacienteDAO _pacienteDAO;
        private readonly MedicoDAO _medicoDAO;
        private readonly ConsultaDAO _consultaDAO;
        private readonly IWebHostEnvironment _hosting;

        private readonly IEmailSender _emailSender;

        public ConsultaController(IWebHostEnvironment hosting, PacienteDAO pacienteDAO,
                                    MedicoDAO medicoDAO, ConsultaDAO consultaDAO, IEmailSender emailSender)
        {
            _hosting = hosting;
            _pacienteDAO = pacienteDAO;
            _medicoDAO = medicoDAO;
            _consultaDAO = consultaDAO;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View(_consultaDAO.Listar());
        }

        public IActionResult Agendar(int p)
        {
            if (p != 0)
            {
                var paciente = _pacienteDAO.BuscarPorId(p);
                ViewBag.PacienteId = paciente.Id;
                ViewBag.PacienteNome = paciente.Nome;
                ViewBag.Medicos = new SelectList(_medicoDAO.Listar(), "Id", "Nome");
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Paciente");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Agendar(Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                var paciente = _pacienteDAO.BuscarPorId(consulta.PacienteId);
                consulta.Paciente = paciente;
                var medico = _medicoDAO.BuscarPorId(consulta.MedicoId);
                consulta.Medico = medico;

                string resposta = _consultaDAO.Cadastrar(consulta);

                if (resposta.Length > 0)
                {
                    ModelState.AddModelError("", resposta);
                }
                else
                {
                    var data = consulta.DataConsulta.ToString("dd/MM/yyyy");
                    var emails = new List<string>();
                    string message = "Olá sr(a). " + paciente.Nome + ", sua consulta para dia " + data + " ás " + consulta.HoraConsulta + " foi confirmada!";
                    string assunto = "Confirmação de Consulta !";
                    EmailModel novoEmail = new EmailModel() { Email = paciente.Email, Message = message, Subject = assunto };
                    emails.Add(novoEmail.Email);
                    await _emailSender.SendEmailAsync(emails, novoEmail.Subject, novoEmail.Message);

                    ViewBag.msgSucesso = "Agendadamento concluído!";
                }

            }
            //ViewBag.PlanosSaude = new SelectList(_planosaudeDAO.Listar(), "Id", "Plano", "Codigo");
            return View();
        }

        public IActionResult Alterar(int id)
        {
            if (id != 0)
            {
                var consulta = _consultaDAO.BuscarPorId(id);
                ViewBag.DtaConsulta = consulta.DataConsulta.ToString("dd/MM/yyyy");
                ViewBag.HraConsulta = new SelectList(_consultaDAO.Listar(),"Id","HoraConsulta");
                ViewBag.PacienteId = consulta.Id;
                ViewBag.PacienteNome = consulta.PacienteId;
                ViewBag.Medicos = new SelectList(_medicoDAO.Listar(), "Id","Nome");

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Paciente");
            }
        }
        [HttpPost]
        public IActionResult Alterar(Consulta consulta)
        {
            _consultaDAO.Alterar(consulta);
            return RedirectToAction("Index", "Consulta");
        }


    }
}
