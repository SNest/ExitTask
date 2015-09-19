namespace ExitTask.Infrastructure.Concrete.Repositories
{
    using ExitTask.Domain.Abstract.Repositories;
    using ExitTask.Domain.Entities.Concrete;
    using ExitTask.Infrastructure.Context.Abstract;

    class EfTourRepository : EfGenericRepository<Tour, int>, ITourRepository
    {
        public EfTourRepository(IContext db)
            : base(db)
        {

        }
    }
}
