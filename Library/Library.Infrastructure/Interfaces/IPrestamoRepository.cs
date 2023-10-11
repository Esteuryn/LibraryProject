
using Library.Domain.Entities;
using Library.Domain.Repository;

namespace Library.Infrastructure.Repositories
{
    public interface IPrestamorRepository : IBaseRepository<Prestamo>
    {
        // Aqui van los metodos exclusivos de la entidad
    }
}