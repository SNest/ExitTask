namespace ExitTask.Domain.Abstract.UnitOfWork
{
    using System;

    using ExitTask.Domain.Abstract.Repositories;
    using ExitTask.Domain.Entities.Abstract;

    public interface IUnitOfWork : IDisposable

    {
        IGenericRepository<TEntity, TPrimaryKey> Entities<TEntity, TPrimaryKey>() where TEntity : class, IEntity<TPrimaryKey>;

        IUserRepository Users { get; }

        ITourRepository Tours { get; }

        void Commit();
    }
}