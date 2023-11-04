using Library.Domain.Entities;
using Library.Infrastructure.Context;
using Library.Infrastructure.Core;
using Library.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Library.Infrastructure.Repositories
{
    public class NumeroCorrelativoRepository : BaseRepository<NumeroCorrelativo>, INumeroCorrelativoRepository
    {
        public NumeroCorrelativoRepository(BibliotecaContext context) : base(context)
        {
        }

        public NumeroCorrelativo GetNumeroCorrelativoPorTipo(string tipo)
        {
            return GetEntities().FirstOrDefault(nc => nc.Tipo == tipo);
        }

        public void ActualizarUltimoNumero(int idNumeroCorrelativo, int nuevoUltimoNumero)
        {
            NumeroCorrelativo correlativo = GetEntity(idNumeroCorrelativo);
            if (correlativo != null)
            {
                correlativo.UltimoNumero = nuevoUltimoNumero;
                Update(correlativo);
            }
        }

        public List<NumeroCorrelativo> ObtenerNumerosCorrelativosActivos()
        {
            return GetEntities().Where(nc => nc.Estado).ToList();
        }

        public List<NumeroCorrelativo> GetNumeroCorrelativos()
        {
            return GetEntities().ToList();
        }

        public NumeroCorrelativo GetNumeroCorrelativo(int id)
        {
            return GetEntity(id);
        }
    }


}
