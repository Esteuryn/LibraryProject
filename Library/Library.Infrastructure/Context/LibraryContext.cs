using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.Infrastructure.Context
{
    public class LibraryContext : DbContext
    {

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
   
        }

        public DbSet<EstadoPrestamo> estadoPrestamos { get; set; }
    }
}
