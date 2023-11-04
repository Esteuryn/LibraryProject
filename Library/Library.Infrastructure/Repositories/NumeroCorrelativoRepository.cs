using Library.Domain.Entities;
using Library.Infrastructure.Context;
using Library.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Library.Infrastructure.Repositories
{
    public class NumeroCorrelativoRepository : INumeroCorrelativoRepository

    {
        private readonly BibliotecaContext context;

        public NumeroCorrelativoRepository(BibliotecaContext context)
        {
            this.context = context;
        }

        public NumeroCorrelativo GetNumeroCorrelativoPorTipo(string tipo)
        {
            return context.numeroCorrelativos.FirstOrDefault(nc => nc.Tipo == tipo);
        }

        public void ActualizarUltimoNumero(int idNumeroCorrelativo, int nuevoUltimoNumero)
        {
            NumeroCorrelativo correlativo = context.numeroCorrelativos.FirstOrDefault(nc => nc.IdNumeroCorrelativo == idNumeroCorrelativo);
            if (correlativo != null)
            {
                correlativo.UltimoNumero = nuevoUltimoNumero;
            }
        }

        public List<NumeroCorrelativo> ObtenerNumerosCorrelativosActivos()
        {
            return context.numeroCorrelativos.Where(nc => nc.Estado).ToList();
        }

        public void Save(NumeroCorrelativo entity)
        {
            context.numeroCorrelativos.Add(entity);
            context.SaveChanges();
        }

        public void Update(NumeroCorrelativo entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(NumeroCorrelativo entity)
        {
            context.numeroCorrelativos.Remove(entity);
            context.SaveChanges();
        }

        public List<NumeroCorrelativo> GetNumeroCorrelativos()
        {
            return context.numeroCorrelativos.ToList();
        }

        public NumeroCorrelativo GetNumeroCorrelativo(int id)
        {
            return context.numeroCorrelativos.Find(id);
        }

        public bool Exists(Expression<Func<NumeroCorrelativo, bool>> filter)
        {
            return context.numeroCorrelativos.Any(filter);
        }

        public List<NumeroCorrelativo> GetEntities()
        { 
            return context.numeroCorrelativos.ToList();
        }


        public NumeroCorrelativo GetEntity(int id)
        {
            return context.numeroCorrelativos.Find(id);
        }
    }
}
