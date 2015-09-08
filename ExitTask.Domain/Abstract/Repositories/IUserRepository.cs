namespace ExitTask.Domain.Abstract.Repositories
{
    using System;

    using ExitTask.Domain.Entities;
    using ExitTask.Domain.Entities.Concrete;

    public interface IUserRepository : IRepository<User, Guid>
    {
    }
}