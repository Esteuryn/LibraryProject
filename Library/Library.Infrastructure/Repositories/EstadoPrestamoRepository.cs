using Library.Domain.Entities;
using Library.Infrastructure.Context;
using Library.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Infrastructure.Repositories
{
    public class EstadoPrestamoRepository : IEstadoPrestamorRepository
    {
        private readonly LibraryContext context;

        public EstadoPrestamoRepository(LibraryContext context)
        {
            this.context = context;
        }

        public List<EstadoPrestamo> GetEntities()
        {
            return context.estadoPrestamos.ToList();
        }

        public EstadoPrestamo GetEntity(int id)
        {
            return this.context.estadoPrestamos.Find(id);
        }

        public void Remove(EstadoPrestamo estadoPrestamo)
        {
            if (estadoPrestamo != null)
            {
                context.estadoPrestamos.Remove(estadoPrestamo);
                context.SaveChanges();
            }
        }

        public void Save(EstadoPrestamo estadoPrestamo)
        {
            if (estadoPrestamo != null)
            {
                context.estadoPrestamos.Add(estadoPrestamo);
                context.SaveChanges();
            }
        }

        public void Update(EstadoPrestamo estadoPrestamo)
        {
            if (estadoPrestamo != null)
            {
                context.estadoPrestamos.Update(estadoPrestamo);
                context.SaveChanges();
            }
        }
    }
}