namespace ExitTask.Presentation.Areas.Security.Models
{
    using ExitTask.Presentation.Areas.Security.Validators;
    using ExitTask.Presentation.Models;

    using FluentValidation.Attributes;

    [Validator(typeof(UserAuthorizationViewModelValidator))]
    public class UserAuthorizationViewModel : ViewModel<int>
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}