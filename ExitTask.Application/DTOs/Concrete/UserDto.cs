﻿namespace ExitTask.Application.DTOs.Concrete
{
    using ExitTask.Application.DTOs.Abstract;
    using ExitTask.Application.DTOs.Concrete.Enum;

    public class UserDto : EntityDto<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserDtoSex Sex { get; set; }

        public UserDtoRole Role { get; set; }

        public UserDtoState State { get; set; }

        public byte[] Avatar { get; set; }

        public CityDto City { get; set; }
    }
}
