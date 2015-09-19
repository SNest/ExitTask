namespace ExitTask.Application.ApplicationServices.Abstract
{
    using System;
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete;

    public interface IUserService : IAppService
    {
        IEnumerable<UserDto> GetAllUsers();

        IEnumerable<UserDto> FindUsers(Func<UserDto, bool> predicate);

        UserDto GetUser(int id);

        void CreateUser(UserDto input);

        void UpdateUser(UserDto input);

        void DeleteUser(int id);
    }
}
