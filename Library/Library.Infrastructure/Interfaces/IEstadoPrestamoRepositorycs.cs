using Library.Domain.Entities;
using Library.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Infrastructure.Interfaces
{
    public interface IEstadoPrestamorRepository : IBaseRepository<EstadoPrestamo>
    {
        // Aqui van los metodos exclusivos de la entidad
    }
}
