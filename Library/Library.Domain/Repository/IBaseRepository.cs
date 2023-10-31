using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Library.Domain.Repository
{
     public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        void Update (TEntity entity);
        void Remove(TEntity entity);

        List<TEntity> GetEstadoPrestamos();
        TEntity GetEstadoPrestamo(int id);
        bool Exists(Expression<Func<EstadoPrestamo, bool>> filter);
    }
}
