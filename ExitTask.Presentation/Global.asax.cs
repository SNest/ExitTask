namespace ExitTask.Presentation
{
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Web.Security;

    using ExitTask.DependencyResolver.Modules;
    using ExitTask.Presentation.Filters;

    using Ninject;
    using Ninject.Web.Common;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            GlobalFilters.Filters.Add(new AuthorizeAttribute());
            GlobalFilters.Filters.Add(new CultureAttribute());

            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;

            var kernel = new Bootstrapper().Kernel;
            kernel.Inject(Membership.Provider);
            kernel.Inject(Roles.Provider);
        }
    }
}
