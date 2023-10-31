﻿using Library.Domain.Entities;
using Library.Infrastructure.Context;
using Library.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public bool Exists(Expression<Func<EstadoPrestamo, bool>> filter)
        {
            return this.context.estadoPrestamos.Any(filter); 
        }

        public List<EstadoPrestamo> GetEstadoPrestamos()
        {
            return context.estadoPrestamos.ToList();
        }

        public EstadoPrestamo GetEstadoPrestamo (int id)
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