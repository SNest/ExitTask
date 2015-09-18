namespace ExitTask.Presentation.Util
{
    using ExitTask.Presentation.Areas.Admin.Validators;

    using FluentValidation;
    using Ninject.Modules;

    public class MvcDiModule: NinjectModule
    {
        public override void Load()
        {
            AssemblyScanner.FindValidatorsInAssemblyContaining<CountryViewModelValidator>()
             .ForEach(match => Bind(match.InterfaceType).To(match.ValidatorType));
        }
    }
}