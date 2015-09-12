namespace ExitTask.DependencyResolver.Modules
{
    using ExitTask.Domain.Abstract.UnitOfWork;
    using ExitTask.Infrastructure.Concrete.UnitOfWork;
    using ExitTask.Infrastructure.Context.Abstract;
    using ExitTask.Infrastructure.Context.Concrete;

    using Ninject.Modules;

    public class DiModule : NinjectModule
    {
        private readonly string connectionString;
        public DiModule(string connection)
        {
            this.connectionString = connection;
        }
        public override void Load()
        {
            this.Bind<IUnitOfWork>().To<EfUnitOfWork>();
            this.Bind<IContext>().To<EfContext>().WithConstructorArgument(this.connectionString);
        }
    }
}
