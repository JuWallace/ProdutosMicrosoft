﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VendasWEB.Models;

namespace VendasWEB.Dal
{
    public class ProdutoDAO
    {
        private readonly Context _context;
        public ProdutoDAO(Context context) => _context = context;

        public List<Produto> Listar() => _context.Produtos
            .Include(x => x.Categoria).ToList();

        public Produto BuscarPorId(int id) => _context.Produtos.Find(id);

        public Produto BuscarPorNome(string nome) => _context.Produtos
            .FirstOrDefault(x => x.Nome.Equals(nome));

        public List<Produto> BuscarPorCategoria(int id) => _context.Produtos
            .Where(x => x.CategoriaId == id).ToList();
        public bool Cadastrar(Produto produto)
        {
            if (BuscarPorNome(produto.Nome) == null) { 
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Remover(int id)
        {
            _context.Produtos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public bool Alterar(Produto produto)
        {

            if(BuscarPorId(produto.Id) != null)
            {
                Produto p = _context.Produtos.First(x => x.Id == produto.Id);
                p.Nome = produto.Nome;
                p.Preco = produto.Preco;
                p.Categoria.Nome = produto.Categoria.Nome;
                _context.Update(p);
                _context.SaveChanges();
                //(_context.Produtos.First(x => x.Id == produto.Id)).Update(produto);
                //_context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
