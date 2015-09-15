namespace ExitTask.Infrastructure.Context.Concrete
{
    using System.Data.Entity;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete;
    using ExitTask.Infrastructure.Context.Abstract;

    public class EfContext : DbContext, IContext
    {
        public EfContext()
            : base("DbConnection")
        {
            Database.SetInitializer(new ContextInitializer());
        }

        public EfContext(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer(new ContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>().ToTable("Tours");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<Hotel>().ToTable("Hotels");
            modelBuilder.Entity<Comment>().ToTable("Comments");
        }

        public IDbSet<TEntity> Set<TEntity, TPrimaryKey>() where TEntity : class, IEntity<TPrimaryKey>
        {
            return base.Set<TEntity>();
        }
    }
}