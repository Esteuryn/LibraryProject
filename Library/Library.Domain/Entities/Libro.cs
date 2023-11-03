using Library.Domain.Core;
using System;


namespace Library.Domain.Entities
{
    public class Libro : BaseEntity

    {
        public int IdLibro { get; set; }

        public string? Titulo { get; set; }

        public string? Autor { get; set; }

        public int? IdCategoria { get; set; }

        public string? Editorial { get; set; }

        public string? Ubicacion { get; set; }

        public int? Ejemplares { get; set; }

        public byte[]? Portada { get; set; }
        public bool Deleted { get; set; }
    }
}
