namespace ExitTask.Domain.Abstract.UnitOfWork
{
    using System;

    using ExitTask.Domain.Abstract.Repositories;
    using ExitTask.Domain.Entities.Abstract;

    public interface IUnitOfWork<TEntity, in TPrimaryKey> : IDisposable
        where TEntity : class, IEntity<TPrimaryKey>
    {
        IRepository<TEntity, TPrimaryKey> Entities { get; }

        void Commit();
    }
}