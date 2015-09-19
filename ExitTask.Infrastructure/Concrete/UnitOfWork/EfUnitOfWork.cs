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

        private IUserRepository userRepository;
        private ITourRepository tourRepository;

        public EfUnitOfWork(IContext db)
        {
            this.db = db;
        }

        public IGenericRepository<TEntity, TPrimaryKey> Entities<TEntity, TPrimaryKey>() where TEntity : class, IEntity<TPrimaryKey>
        {
            IGenericRepository<TEntity, TPrimaryKey> entityRepository = new EfGenericRepository<TEntity, TPrimaryKey>(this.db);
            return entityRepository;
        }

        public IUserRepository Users
        {
            get
            {
                return this.userRepository ?? (this.userRepository = new EfUserRepository(this.db));
            }
        }

        public ITourRepository Tours
        {
            get
            {
                return this.tourRepository ?? (this.tourRepository = new EfTourRepository(this.db));
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