namespace ExitTask.Presentation.Areas.Security.Models
{
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Presentation.Areas.Security.Validators;
    using ExitTask.Presentation.Models;

    using FluentValidation.Attributes;

    [Validator(typeof(UserRegistrationViewModelValidator))]
    public class UserRegistrationViewModel : ViewModel<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string EmailConfirmation { get; set; }

        public string Password { get; set; }

        public string PasswordConfirmation { get; set; }

        public UserDtoSex Sex { get; set; }

        public byte[] Avatar { get; set; }

        public CityDto City { get; set; }
    }
}