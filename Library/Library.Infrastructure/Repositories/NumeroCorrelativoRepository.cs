using Library.Domain.Entities;
using Library.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Infrastructure.Repositories
{
    public class NumeroCorrelativoRepository : INumeroCorrelativoRepository
    {
        private List<NumeroCorrelativo> numeroCorrelativos; 

        public NumeroCorrelativoRepository()
        {
            
            numeroCorrelativos = new List<NumeroCorrelativo>();
        }

        public NumeroCorrelativo GetNumeroCorrelativoPorTipo(string tipo)
        {
           
            return numeroCorrelativos.FirstOrDefault(nc => nc.Tipo == tipo);
        }

        public void ActualizarUltimoNumero(int idNumeroCorrelativo, int nuevoUltimoNumero)
        {
           
            NumeroCorrelativo correlativo = numeroCorrelativos.FirstOrDefault(nc => nc.IdNumeroCorrelativo == idNumeroCorrelativo);
            if (correlativo != null)
            {
                correlativo.UltimoNumero = nuevoUltimoNumero;
            }
        }

        public List<NumeroCorrelativo> GetEntities()
        {
            
            return numeroCorrelativos;
        }

        public NumeroCorrelativo GetEntity(int id)
        {
           
            return numeroCorrelativos.FirstOrDefault(nc => nc.IdNumeroCorrelativo == id);
        }

        public List<NumeroCorrelativo> ObtenerNumerosCorrelativosActivos()
        {
            
            return numeroCorrelativos.Where(nc => nc.Estado).ToList();
        }

        public void Remove(NumeroCorrelativo entity)
        {
            
            numeroCorrelativos.Remove(entity);
        }

        public void Save(NumeroCorrelativo entity)
        {
           
            numeroCorrelativos.Add(entity);
        }

        public void Update(NumeroCorrelativo entity)
        {
            
            NumeroCorrelativo existingCorrelativo = numeroCorrelativos.FirstOrDefault(nc => nc.IdNumeroCorrelativo == entity.IdNumeroCorrelativo);
            if (existingCorrelativo != null)
            {
                existingCorrelativo = entity;
            }
        }
    }

}
