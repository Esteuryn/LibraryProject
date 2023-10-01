using Library.Domain.Entities;
using Library.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Infrastructure.Models
{
    public class LibroRepository : IDLibroRepository
    {
        public List<Libro> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Libro GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Libro entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Libro entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Libro entity)
        {
            throw new NotImplementedException();
        }
    }
}
