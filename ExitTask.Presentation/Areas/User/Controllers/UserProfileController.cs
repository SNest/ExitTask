using System.Web.Mvc;

namespace ExitTask.Presentation.Areas.User.Controllers
{
    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Presentation.Models;

    public class UserProfileController : Controller
    {
        private readonly IUserService userService;
        public UserProfileController(IUserService userService)
        {
            this.userService = userService;
        }

        public ActionResult UserInfo()
        {
            Mapper.CreateMap<UserDto, UserViewModel>();
            var user = this.userService.GetUser(this.User.Identity.Name);
            var model = Mapper.Map<UserViewModel>(user);
            this.ViewBag.UserSex = user.Sex.ToString();
            this.ViewBag.UserRole = user.Role.ToString();
            return this.View(model);
        }
    }
}
