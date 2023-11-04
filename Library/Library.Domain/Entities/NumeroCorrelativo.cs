using Library.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;



namespace Library.Domain.Entities
{
    public class NumeroCorrelativo : User
    {
        
        public int IdNumeroCorrelativo { get; set; }
        public string Prefijo { get; set; }
        public string Tipo { get; set; }
        public int UltimoNumero { get; set; }
        public DateTime? FechaRegistro { get; set; }

    }
}
