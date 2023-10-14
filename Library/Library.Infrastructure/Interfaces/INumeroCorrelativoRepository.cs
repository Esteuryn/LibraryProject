using Library.Domain.Entities;
using Library.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Library.Infrastructure.Interfaces
{
    public interface INumeroCorrelativoRepository : IBaseRepository<NumeroCorrelativo>
    {
        NumeroCorrelativo GetNumeroCorrelativoPorTipo(string tipo);
        void ActualizarUltimoNumero(int idNumeroCorrelativo, int nuevoUltimoNumero);
        List<NumeroCorrelativo> ObtenerNumerosCorrelativosActivos();

        void Save(NumeroCorrelativo numero);
        void Update(NumeroCorrelativo numero);
        void Remove(NumeroCorrelativo numero);

        List<NumeroCorrelativo> GetNumeroCorrelativos();
        NumeroCorrelativo GetNumeroCorrelativo(int id);

        bool Exists(Expression<Func<NumeroCorrelativo, bool>> filter);
    }
}
