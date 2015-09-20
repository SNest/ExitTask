﻿namespace ExitTask.Presentation.Areas.Admin.Models
{
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Presentation.Models;

    public class UserViewModel : ViewModel<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserDtoSex Sex { get; set; }

        public UserDtoRole Role { get; set; }

        public UserDtoState State { get; set; }

        public int CountryId { get; set; }

        public CityDto City { get; set; }
    }
}
