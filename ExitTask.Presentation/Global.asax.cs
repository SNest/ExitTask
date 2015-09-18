namespace ExitTask.Presentation
{
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    using ExitTask.Presentation.Util;

    using FluentValidation.Mvc;

    using Ninject.Web.Common;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //FluentValidationModelValidatorProvider.Configure();

            //FluentValidationModelValidatorProvider.Configure(
            //    provider => { provider.ValidatorFactory = new FluentValidationConfig(); });

            //NinjectValidatorFactory ninjectValidatorFactory = new NinjectValidatorFactory((new Bootstrapper()).Kernel);
            //ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider(ninjectValidatorFactory));

            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;

            //FluentValidationModelValidatorProvider.Configure(x => x.ValidatorFactory = ninjectValidatorFactory);

            //FluentValidationModelValidatorProvider.Configure(provider => {
            //    provider.ValidatorFactory = new NinjectValidatorFactory((new Bootstrapper()).Kernel);
            //});

            //FluentValidationModelValidatorProvider.Configure(
            //    provider => { provider.ValidatorFactory = new FluentValidationConfig(); });


        }
    }
}
