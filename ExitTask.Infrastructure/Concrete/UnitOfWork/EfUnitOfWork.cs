namespace ExitTask.Infrastructure.Concrete.UnitOfWork
{
    using System;

    using ExitTask.Domain.Abstract.Repositories;
    using ExitTask.Domain.Abstract.UnitOfWork;
    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Infrastructure.Concrete.Repositories;
    using ExitTask.Infrastructure.Context.Abstract;

    public class EfUnitOfWork : IUnitOfWork
    {
        private bool disposed;

        private readonly IContext db;

        public EfUnitOfWork(IContext db)
        {
            this.db = db;
        }

        public IRepository<TEntity, TPrimaryKey> Entities<TEntity, TPrimaryKey>() where TEntity : class, IEntity<TPrimaryKey>
        {
            IRepository<TEntity, TPrimaryKey> entityRepository = new EfRepository<TEntity, TPrimaryKey>(this.db);
            return entityRepository;
        }

        public void Commit()
        {
            this.db.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.db.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}