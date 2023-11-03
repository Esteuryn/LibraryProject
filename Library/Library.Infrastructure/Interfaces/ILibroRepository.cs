using Library.Domain.Entities;
using Library.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Library.Infrastructure.Interfaces
{
    public interface ILibroRepository : IBaseRepository<Libro>
    {
        //metodos exclusivos de la entidad //
        bool Exists(Expression<Func<Libro, bool>> filter);
        List<Libro> GetLibros();

        Libro GetLibro(int Id);

        void Remove(Libro libro);

        void Save(Libro libro);

        void Update(Libro libro);

    }
}
 