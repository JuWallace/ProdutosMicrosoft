using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoAgendaMedica_Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Controllers
{
    public class CadastrarController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CadastrarController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
