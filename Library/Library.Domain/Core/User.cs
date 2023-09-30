using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Core
{
    public abstract class User : BaseEntity
    {
        public string? Correo { get; set; }
        public string? Clave { get; set; }
    }
}
