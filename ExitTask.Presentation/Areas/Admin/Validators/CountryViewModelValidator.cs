namespace ExitTask.Presentation.Areas.Admin.Validators
{
    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Presentation.Areas.Admin.Models;
    using ExitTask.Presentation.Filters;

    using FluentValidation;

    using Resources;

    [Culture]
    public class CountryViewModelValidator : AbstractValidator<CountryViewModel>
    {
        private readonly ICountryService countryService;

        public CountryViewModelValidator(ICountryService countryService)
        {
            this.countryService = countryService;

            this.RuleFor(x => x.Name).Must(this.BeUniqueCountryName).WithLocalizedMessage(() => Resource.UniqueCountyName);
            this.RuleFor(x => x.Name).NotNull().WithLocalizedMessage(() => Resource.RequiredField);
            this.RuleFor(x => x.Name).Length(2, 100).WithLocalizedMessage(() => Resource.CountryNameLength);

            this.RuleFor(x => x.Description).NotNull().WithLocalizedMessage(() => Resource.RequiredField);
        }

        private bool BeUniqueCountryName(string name)
        {
            return this.countryService.GetCountry(name) == null;
        }
    }
}