namespace ExitTask.Infrastructure.Context.Concrete
{
    using System.Data.Entity;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Infrastructure.Context.Abstract;

    public class EfContext : DbContext, IContext
    {
        public EfContext(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer(new ContextInitializer());
        }

        public IDbSet<TEntity> Set<TEntity, TPrimaryKey>() where TEntity : class, IEntity<TPrimaryKey>
        {
            return base.Set<TEntity>();
        }
    }
}