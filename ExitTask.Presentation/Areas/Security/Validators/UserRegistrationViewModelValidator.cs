namespace ExitTask.Presentation.Areas.Security.Validators
{
    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Presentation.Areas.Security.Models;

    using FluentValidation;

    using Resources;

    public class UserRegistrationViewModelValidator : AbstractValidator<UserRegistrationViewModel>
    {
        //private IUserService userService;
        //public UserRegistrationViewModelValidator(IUserService userService)
        //{
        //    this.userService = userService;
        //}

        //public UserRegistrationViewModelValidator(IUserService userService, IUserService userService1)
        //{
        //    this.userService = userService1;
        //    this.userService = userService;

        //    this.RuleFor(x => x.Name).NotNull().WithMessage(Resource.RequiredName).Length(0, 100);
        //    this.RuleFor(x => x.Description).NotNull().WithMessage(Resource.RequiredDescription);
        //}

        //private bool BeUniqueCountryName(string name)
        //{
        //    return this.countryService.FindCountries(c=>c.Name == name) == null;
        //}
    }
}