namespace ExitTask.Presentation.Util
{

    //public class NinjectDependencyResolver : IDependencyResolver
    //{
    //    private readonly IKernel kernel;
    //    public NinjectDependencyResolver(IKernel kernelParam)
    //    {
    //        this.kernel = kernelParam;

    //        this.AddBindings();
    //    }
    //    public object GetService(Type serviceType)
    //    {
    //        return this.kernel.TryGet(serviceType);
    //    }
    //    public IEnumerable<object> GetServices(Type serviceType)
    //    {
    //        return this.kernel.GetAll(serviceType);
    //    }
    //    private void AddBindings()
    //    {


    //        kernel.Bind(x => x.FromThisAssembly()
    //           .SelectAllClasses().InheritedFrom<IValidator>()
    //           .BindAllInterfaces()
    //           .Configure(b => b.InSingletonScope()));
    //    }
    //}
}