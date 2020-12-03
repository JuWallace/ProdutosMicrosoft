using Microsoft.EntityFrameworkCore;
using ProjetoAgendaMedica_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgendaMedica_Web.Dal
{
    public class UsuarioDAO
    {
        private readonly Context _context;

        public UsuarioDAO(Context context) => _context = context;

        public List<UsuarioView> Listar() => _context.Usuarios.ToList();

        public UsuarioView BuscarPorId(int id) => _context.Usuarios
            .FirstOrDefault(x => x.Id == id);

        public UsuarioView BuscarPorNome(string nome) => _context.Usuarios
            .FirstOrDefault(x => x.Nome == nome);





        public void Editar(UsuarioView usuarioView)
        {
            _context.Usuarios.Update(usuarioView);
            _context.SaveChanges();
        }
    }
}
