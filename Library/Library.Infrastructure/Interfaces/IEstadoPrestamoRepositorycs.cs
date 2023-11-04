using Library.Domain.Entities;
using Library.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Library.Infrastructure.Interfaces
{
    public interface IEstadoPrestamorRepository : IBaseRepository<EstadoPrestamo>
    {
        // Aqui van los metodos exclusivos de la entidad 
            bool Exists(Expression<Func<EstadoPrestamo, bool>> filter);
            List<EstadoPrestamo> GetEstadoPrestamos();
            EstadoPrestamo GetEstadoPrestamo(int id);
            void Remove(EstadoPrestamo estadoPrestamo);
            void Save(EstadoPrestamo estadoPrestamo);
            void Update(EstadoPrestamo estadoPrestamo);
    }
}
