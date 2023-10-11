
using Library.Domain.Entities;
using Library.Domain.Repository;
using System;

namespace Library.Infrastructure.Repositories
{
    public interface IPrestamorRepository : IBaseRepository<Prestamo>
    {
        // Aqui van los metodos exclusivos de la entidad
        Prestamo ConfirmarDevolucion(DateTime FechaDevolucion, DateTime FechaConfirmacionDevolucion);

    }
}