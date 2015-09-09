using System;
using System.Collections.Generic;

namespace ExitTask.Presentation.DI
{
    using System.Web.Mvc;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.ApplicationServices.Concrete;

    using Ninject;

    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            this.kernel = kernelParam;
            this.AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return this.kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            this.kernel.Bind<ITourService>().To<TourService>();
        }
    }
}