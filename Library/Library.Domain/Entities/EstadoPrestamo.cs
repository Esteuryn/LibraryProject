using Library.Domain.Core;
using System;
using System.Collections.Generic;

namespace Library.Domain.Entities
{
    public class EstadoPrestamo : User
    {
        public EstadoPrestamo()
        {
            List<int> ints = new List<int>();
            List<string> strings = new List<string>();
            strings.Add("1");
        }

        public int IdEstadoPrestamo { get; set; }
        public string? Descripcion { get; set; }
    }
}

