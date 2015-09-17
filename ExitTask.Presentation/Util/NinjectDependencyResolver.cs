namespace ExitTask.Presentation.Util
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.ApplicationServices.Concrete;

    using FluentValidation.Mvc;

    using Ninject;
    using Ninject.Web.Mvc.FluentValidation;

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
            this.kernel.Bind<ICountryService>().To<CountryService>();
            this.kernel.Bind<ICityService>().To<CityService>();
            this.kernel.Bind<IHotelService>().To<HotelService>();
        }
    }
}