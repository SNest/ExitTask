namespace ExitTask.Infrastructure.Concrete.UnitOfWork
{
    using System;

    using ExitTask.Domain.Abstract.Repositories;
    using ExitTask.Domain.Abstract.UnitOfWork;
    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Infrastructure.Concrete.Repositories;
    using ExitTask.Infrastructure.Context.Abstract;

    internal class EfUnitOfWork<TEntity, TPrimaryKey> : IUnitOfWork<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        private bool disposed;

        private IRepository<TEntity, TPrimaryKey> entityRepository;

        private readonly IContext db;

        public EfUnitOfWork(IContext db)
        {
            this.db = db;
        }

        public IRepository<TEntity, TPrimaryKey> Entities
        {
            get
            {
                return this.entityRepository
                       ?? (this.entityRepository = new EfRepository<TEntity, TPrimaryKey>(this.db));
            }
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