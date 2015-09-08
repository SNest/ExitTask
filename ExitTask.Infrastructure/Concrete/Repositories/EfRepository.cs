namespace ExitTask.Infrastructure.Concrete.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    using ExitTask.Domain.Abstract.Repositories;
    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Infrastructure.Context.Abstract;
    using NLog;

    public class EfRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        private static Logger logger;

        private readonly IContext db;

        public EfRepository(IContext db)
        {
            this.db = db;
            logger = LogManager.GetCurrentClassLogger();
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return this.db.Set<TEntity, TPrimaryKey>();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public TEntity Get(TPrimaryKey id)
        {
            try
            {
                return this.db.Set<TEntity, TPrimaryKey>().Find(id);
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            try
            {
                return this.db.Set<TEntity, TPrimaryKey>().ToList().Where(predicate).ToList();
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public void Create(TEntity item)
        {
            try
            {
                this.db.Entry(item).State = EntityState.Added;
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public void Update(TEntity item)
        {
            try
            {
                this.db.Entry(item).State = EntityState.Modified;
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }

        public void Delete(TPrimaryKey id)
        {
            try
            {
                this.db.Entry(this.Get(id)).State = EntityState.Deleted;
            }
            catch (Exception exception)
            {
                logger.Trace(exception.StackTrace);
                throw;
            }
        }
    }
}