using ExitTask.Presentation;

using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: ApplicationShutdownMethod(typeof(NinjectWebCommon), "Stop")]

namespace ExitTask.Presentation
{
    using System;
    using System.Reflection;
    using System.Web;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.ApplicationServices.Concrete;
    using ExitTask.DependencyResolver.Modules;
    using ExitTask.Presentation.Util;

    using FluentValidation;
    using FluentValidation.Mvc;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Modules;
    using Ninject.Web.Common;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        ///     Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        ///     Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        /// <summary>
        ///     Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var modules = new INinjectModule[] { new RepositoryModule("DbConnection") };

            var kernel = new StandardKernel(modules);

            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        ///     Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ITourService>().To<TourService>();
            kernel.Bind<ICountryService>().To<CountryService>();
            kernel.Bind<ICityService>().To<CityService>();
            kernel.Bind<IHotelService>().To<HotelService>();
            kernel.Bind<IUserService>().To<UserService>();

            //kernel.Bind<MembershipProvider>().To<ExitTaskMembershipProvider>().InRequestScope();
            //kernel.Bind<RoleProvider>().To<ExitTaskRoleProvider>().InRequestScope();
           

            AssemblyScanner.FindValidatorsInAssembly(Assembly.GetExecutingAssembly())
                .ForEach(match => kernel.Bind(match.InterfaceType).To(match.ValidatorType));

            FluentValidationModelValidatorProvider.Configure(
                provider => { provider.ValidatorFactory = new NinjectValidatorFactory(kernel); });
        }
    }
}