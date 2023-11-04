using System;


namespace Library.Domain.Core
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? Codigo { get; set; }
    }
}
