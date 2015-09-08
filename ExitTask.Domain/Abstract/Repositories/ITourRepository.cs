namespace ExitTask.Domain.Abstract.Repositories
{
    using System;

    using ExitTask.Domain.Entities.Concrete;

    public interface ITourRepository : IRepository<Tour, Guid>
    {

    }
}