namespace ExitTask.Application.ApplicationServices.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Domain.Abstract.UnitOfWork;
    using ExitTask.Domain.Entities.Concrete;

    public class UserService : AppService, IUserService
    {
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            Mapper.CreateMap<User, UserDto>();
            Mapper.CreateMap<UserDto, User>();
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            var result = Mapper.Map<List<UserDto>>(this.unitOfWork.Entities<User, int>().GetAll().ToList());
            return result;
        }

        public IEnumerable<UserDto> FindUsers(Func<UserDto, bool> predicate)
        {
            var p = Mapper.Map<Func<User, bool>>(predicate);
            var result = Mapper.Map<IEnumerable<UserDto>>(this.unitOfWork.Entities<User, int>().Find(p));
            return result;
        }

        public UserDto GetUser(int id)
        {
            var result = Mapper.Map<UserDto>(this.unitOfWork.Entities<User, int>().Get(id));
            return result;
        }
        public UserDto GetUser(string email)
        {
            var result = Mapper.Map<UserDto>(this.unitOfWork.Entities<User, int>().Find(country => country.Email == email).FirstOrDefault());
            return result;
        }

        public void CreateUser(UserDto input)
        {
            var instanse = Mapper.Map<User>(input);
            this.unitOfWork.Entities<User, int>().Create(instanse);
        }

        public void UpdateUser(UserDto input)
        {
            var instanse = Mapper.Map<User>(input);
            this.unitOfWork.Entities<User, int>().Update(instanse);
        }

        public void DeleteUser(int id)
        {
            this.unitOfWork.Entities<User, int>().Delete(id);
        }
    }
}