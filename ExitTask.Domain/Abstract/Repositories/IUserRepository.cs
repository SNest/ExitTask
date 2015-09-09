namespace ExitTask.Domain.Abstract.Repositories
{
    using ExitTask.Domain.Entities.Concrete;

    public interface IUserRepository : IRepository<User, int>
    {
    }
}