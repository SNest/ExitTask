namespace ExitTask.Presentation
{
    using System;
    using System.Reflection;

    using ExitTask.Presentation.Areas.Admin.Models;
    using ExitTask.Presentation.Areas.Admin.Validators;

    using FluentValidation;

    using Ninject.Web.Common;
    using Ninject;

    public class FluentValidationConfig : ValidatorFactoryBase
    {
        private readonly IKernel kernel;

        public FluentValidationConfig()
        {
            this.kernel = (new Bootstrapper()).Kernel;
            this.AddBinding();
        }

        public void AddBinding()
        {
            this.kernel.Bind<IValidator<CountryViewModel>>().To<CountryViewModelValidator>();
            AssemblyScanner.FindValidatorsInAssembly(Assembly.GetExecutingAssembly())
                            .ForEach(match => this.kernel.Bind(match.InterfaceType)
                                .To(match.ValidatorType));
        }
        public override IValidator CreateInstance(Type validatorType)
        {
            var result = (validatorType == null) ? null : (IValidator)this.kernel.TryGet(validatorType);
            return result;

        }
    }
}