﻿using Microsoft.EntityFrameworkCore;
using ProjetoAgendaMedica_Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoAgendaMedica_Web.Dal
{
    public class PacienteDAO
    {
        private readonly Context _context;

        public PacienteDAO(Context context) => _context = context;

        public List<Paciente> Listar() =>
            _context.Pacientes.Include(x => x.PlanoSaude).ToList();

        public Paciente BuscarPorId(int id) => _context.Pacientes.Include(x => x.PlanoSaude)
            .FirstOrDefault(x => x.Id == id);

        public Paciente BuscarPorNome(string nome) =>
            _context.Pacientes.FirstOrDefault(x => x.Nome == nome);

        public Paciente BuscarPorCpf(string cpf) =>
            _context.Pacientes.FirstOrDefault(x => x.Cpf == cpf);

        public bool Cadastrar(Paciente paciente)
        {
            if (BuscarPorNome(paciente.Nome) == null)
            {
                _context.Pacientes.Add(paciente);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Remover(int id)
        {
            _context.Pacientes.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public void Alterar(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
            _context.SaveChanges();
        }
    }
}
