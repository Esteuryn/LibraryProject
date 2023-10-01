using Library.Domain.Entities;
using Library.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Infrastructure.Interfaces
{
    public interface INumeroCorrelativoRepository : IBaseRepository<NumeroCorrelativo>
    {
        NumeroCorrelativo GetNumeroCorrelativoPorTipo(string tipo);
        void ActualizarUltimoNumero(int idNumeroCorrelativo, int nuevoUltimoNumero);
        List<NumeroCorrelativo> ObtenerNumerosCorrelativosActivos();
    }
}
