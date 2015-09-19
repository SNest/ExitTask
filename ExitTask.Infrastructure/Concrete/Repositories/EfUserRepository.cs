namespace ExitTask.Infrastructure.Concrete.Repositories
{
    using ExitTask.Domain.Abstract.Repositories;
    using ExitTask.Domain.Entities.Concrete;
    using ExitTask.Infrastructure.Context.Abstract;

    class EfUserRepository: EfGenericRepository<User, int>, IUserRepository
    {
        public EfUserRepository(IContext db)
            : base(db)
        {

        }
    }
}
