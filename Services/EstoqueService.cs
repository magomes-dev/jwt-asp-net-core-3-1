using System;
using System.Collections.Generic;
using System.Linq;
using PixForce.Entities;
using PixForce.Helpers;

namespace PixForce.Services
{
    public interface IEstoqueService
    {
        IEnumerable<Estoque> GetAll();
        Estoque GetById(int id);
        Estoque Create(Estoque estoque);
        void Update(Estoque estoque);
        void Delete(int id);
    }

    public class EstoqueServvice : IEstoqueService
    {
        private DataContext _context;

        public EstoqueServvice(DataContext context)
        {
            _context = context;
        }


        public IEnumerable<Estoque> GetAll()
        {
            return _context.Estoque;
        }

        public Estoque GetById(int id)
        {
            return _context.Estoque.Find(id);
        }

        public Estoque Create(Estoque estoque)
        {
            if (_context.Estoque.Any(x => x.CodigoCliente == estoque.CodigoCliente))
                throw new AppException("Código cliente \"" + estoque.CodigoCliente + "\" já existe");

            _context.Estoque.Add(estoque);
            _context.SaveChanges();

            return estoque;
        }

        public void Update(Estoque estoqueParam)
        {
            if (_context.Estoque.Any(x => x.CodigoCliente == estoqueParam.CodigoCliente && x.Id != estoqueParam.Id))
                throw new AppException("Código cliente " + estoqueParam.CodigoCliente + " já existe");                               
            
            _context.Estoque.Update(estoqueParam);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var estoque = _context.Estoque.Find(id);
            if (estoque != null)
            {
                _context.Estoque.Remove(estoque);
                _context.SaveChanges();
            }
        }

    }
}