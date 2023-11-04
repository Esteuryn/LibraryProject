using Library.Domain.Repository;
using Library.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Library.Infrastructure.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly BibliotecaContext context;
        private DbSet<TEntity> entities;

        public BaseRepository(BibliotecaContext context)
        {
            this.context = context;
            this.entities = this.context.Set<TEntity>();
        }

        public virtual bool Exists(Expression<Func<TEntity, bool>> filter)
        {
            return entities.Any(filter);
        }

        public virtual List<TEntity> GetEntities()
        {
            return entities.ToList();
        }

        public virtual TEntity GetEntity(int id)
        {
            return entities.Find(id);
        }

        public virtual void Remove(TEntity entity)
        {
            entities.Remove(entity);
            context.SaveChanges();
        }

        public virtual void Save(TEntity entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            entities.Update(entity);
            context.SaveChanges();
        }
    }
}
