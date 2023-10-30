using Library.Domain.Core;
using System;
using System.Collections.Generic;

namespace Library.Domain.Entities
{
    public class EstadoPrestamo : User
    {
        public int IdEstadoPrestamo { get; set; }
        public string? Descripcion { get; set; }
    }
}

