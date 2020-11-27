using ProjetoAgendaMedica_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoAgendaMedica_Web.Dal
{
    public class PlanoSaudeDAO
    {
        private readonly Context _context;
        public PlanoSaudeDAO(Context context) => _context = context;
        public List<PlanoSaude> Listar() => _context.PlanosSaude.ToList();
        public PlanoSaude BuscarPorId(int id) => _context.PlanosSaude.Find(id);
    }
}
