namespace ExitTask.Presentation.Areas.Admin.Validators
{
    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Presentation.Areas.Admin.Models;

    using FluentValidation;

    public class CountryViewModelValidator : AbstractValidator<CountryViewModel>
    {
        private readonly ICountryService countryService;

        public CountryViewModelValidator()
        {
            this.RuleFor(x => x.Name).Must(this.BeUniqueCountryName).NotEmpty().WithMessage(Resources.Resource.RequiredName).Length(0, 100);
            this.RuleFor(x => x.Description).NotEmpty().WithMessage(Resources.Resource.RequiredDescription);
        }
        public CountryViewModelValidator(ICountryService countryService)
        {
            this.countryService = countryService;

            this.RuleFor(x => x.Name).Must(this.BeUniqueCountryName).NotEmpty().WithMessage(Resources.Resource.RequiredName).Length(0, 100);
            this.RuleFor(x => x.Description).NotEmpty().WithMessage(Resources.Resource.RequiredDescription);
        }

        private bool BeUniqueCountryName(string name)
        {
            return this.countryService.FindCountries(c=>c.Name == name) == null;
        }
    }
}