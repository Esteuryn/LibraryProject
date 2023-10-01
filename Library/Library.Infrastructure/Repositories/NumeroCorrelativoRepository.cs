using Library.Domain.Entities;
using Library.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Infrastructure.Repositories
{
    internal class NumeroCorrelativoRepository : INumeroCorrelativoRepository
    {
        public void ActualizarUltimoNumero(int idNumeroCorrelativo, int nuevoUltimoNumero)
        {
            throw new NotImplementedException();
        }

        public List<NumeroCorrelativo> GetEntities()
        {
            throw new NotImplementedException();
        }

        public NumeroCorrelativo GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public NumeroCorrelativo GetNumeroCorrelativoPorTipo(string tipo)
        {
            throw new NotImplementedException();
        }

        public List<NumeroCorrelativo> ObtenerNumerosCorrelativosActivos()
        {
            throw new NotImplementedException();
        }

        public void Remove(NumeroCorrelativo entity)
        {
            throw new NotImplementedException();
        }

        public void Save(NumeroCorrelativo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(NumeroCorrelativo entity)
        {
            throw new NotImplementedException();
        }
    }
}
