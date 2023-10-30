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

        public interface IEstadoPrestamo
        {
            // Método para obtener un estado de préstamo por su ID
            EstadoPrestamo ObtenerEstadoPrestamoPorId(int id);

            // Método para agregar un nuevo estado de préstamo
            void AgregarEstadoPrestamo(EstadoPrestamo estado);

            // Método para actualizar un estado de préstamo existente
            void ActualizarEstadoPrestamo(EstadoPrestamo estado);

            // Método para eliminar un estado de préstamo por su ID
            void EliminarEstadoPrestamo(int id);

            // Método para obtener todos los estados de préstamo
            List<EstadoPrestamo> ObtenerTodosLosEstadosPrestamo();

        }
    }
}

