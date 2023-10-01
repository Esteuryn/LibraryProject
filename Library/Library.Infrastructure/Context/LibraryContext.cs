using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Infrastructure.Context
{
   public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext>options) : base(options)
        { 

        }

        public DbSet<Usuario> usuarios { get; set; }
    }

}
