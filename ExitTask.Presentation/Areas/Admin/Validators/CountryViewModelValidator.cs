namespace ExitTask.Presentation.Areas.Admin.Validators
{
    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Presentation.Areas.Admin.Models;

    using FluentValidation;

    using Resources;

    public class CountryViewModelValidator : AbstractValidator<CountryViewModel>
    {
        private readonly ICountryService countryService;

        public CountryViewModelValidator()
        {

        }

        public CountryViewModelValidator(ICountryService countryService)
        {
            this.countryService = countryService;

            this.RuleFor(x => x.Name).NotNull().WithMessage(Resource.RequiredName).Length(0, 100);
            this.RuleFor(x => x.Description).NotNull().WithMessage(Resource.RequiredDescription);
        }

        private bool BeUniqueCountryName(string name)
        {
            return this.countryService.FindCountries(c=>c.Name == name) == null;
        }
    }
}