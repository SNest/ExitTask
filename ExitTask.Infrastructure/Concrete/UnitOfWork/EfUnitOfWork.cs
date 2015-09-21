namespace ExitTask.Infrastructure.Concrete.UnitOfWork
{
    using System;
    using System.Data.Entity.Validation;
    using System.Text;

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
            try
            {
                this.db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                    );
            }
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