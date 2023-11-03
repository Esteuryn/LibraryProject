using Library.Domain.Entities;
using Library.Infrastructure.Context;
using Library.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Library.Infrastructure.Repositories
{
    public class LibroRepository : ILibroRepository
    {
        private readonly LibraryContext context;

        public LibroRepository(LibraryContext context)
        {
            this.context = context;
        }

        public bool Exists(Expression<Func<Libro, bool>> filter)
        {
            return this.context.Libros.Any(filter);
        }

        public List<Libro> GetLibros()
        {
            return this.context.Libros.Where(li => !li.Deleted).ToList();
        }

        public Libro GetLibro(int Id)
        {
            return this.context.Libros.Find(Id);
        }

        public Libro GetLibroAutor(string Autor)
        {
            throw new NotImplementedException();
        }

        public Libro GetLibroIdCategoria(string IdCategoria)
        {
            throw new NotImplementedException();
        }

        public Libro GetLibroTitulo(string Titulo)
        {
            throw new NotImplementedException();
        }

        public void Remove(Libro libro)
        {
            if (libro != null)
            {
                context.Libros.Remove(libro);
                context.SaveChanges();
            }
        }

        public void Save(Libro libro)
        {
            if (libro != null)
            {
                context.Libros.Add(libro);
                context.SaveChanges();
            }
        }

        public void Update(Libro libro)
        {
            if (libro != null)
            {
                context.Libros.Update(libro);
                context.SaveChanges();
            }


        }

    }
}