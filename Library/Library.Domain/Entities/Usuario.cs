using Library.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Entities
{
    public class Usuario : User
    {
        public int idUsuario { get; set; }
        public string? nombreApellidos { get; set; }
        public string? correo { get; set; }
        public string? clave { get; set; }
        public string? esActivo { get; set; }
        public DateTime? FechaCreacion { get; set; }

    }
}
