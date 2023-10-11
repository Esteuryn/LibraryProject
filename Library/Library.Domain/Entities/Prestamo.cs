using Library.Domain.Core;
using System;
using System.Collections.Generic;

namespace Library.Domain.Entities
{
    public class Prestamo : User
    {
        public Prestamo()
        {
            List<int> ints = new List<int>();
            List<string> strings = new List<string>();
            strings.Add("1");
        }
        public int IdPrestamo { get; set; }
        public int IdEstadoPrestamo { get; set; }
        public int IdLector { get; set; }
        public int IdLibro { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaConfirmacionDevolucion { get; set; }
        public string? EstadoEntregado { get; set; }
        public string? EstadoRecibido { get; set; }
    }
}