using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAgendaMedica_Web.Dal;
using ProjetoAgendaMedica_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Controllers
{
    [Route("api/Consulta")]
    [ApiController]
    public class PacienteAPIController : ControllerBase
    {
        private readonly PacienteDAO _pacienteDAO;
        public PacienteAPIController(PacienteDAO pacienteDAO)
        {
            _pacienteDAO = pacienteDAO;
        }

        //GET: /api/Consulta/Buscar
        [HttpGet]
        [Route("Buscar/{cpf}")]
        public IActionResult Buscar(string ? cpf)
        {
            Paciente paciente = _pacienteDAO.BuscarPorCpf(cpf);
            if (paciente != null)
            {
                return Ok(paciente);
            }
            return BadRequest(new { msg = "Paciente não existe no banco" });
        }

        
    }

}
