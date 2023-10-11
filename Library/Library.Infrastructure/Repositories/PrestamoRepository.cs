using Library.Domain.Entities;
using Library.Domain.Repository;
using System;
using System.Collections.Generic;

namespace Library.Infrastructure.Repositories
{
    public class PrestamosRepository : IPrestamorRepository
    {
        public Prestamo ConfirmarDevolucion(DateTime FechaDevolucion, DateTime FechaConfirmacionDevolucion)
        {
            throw new NotImplementedException();
        }

        public List<Prestamo> GetEntities()
        {
            throw new System.NotImplementedException();
        }

        public Prestamo GetEntity(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Prestamo entity)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Prestamo entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Prestamo entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
