namespace ExitTask.Presentation.Areas.Security.Controllers
{
    using System;
    using System.IO;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Presentation.Areas.Security.Models;

    [AllowAnonymous]
    public class RegistrationController : Controller
    {
        private readonly IUserService userService;

        public RegistrationController(IUserService userService)
        {
            this.userService = userService;
            Mapper.CreateMap<UserRegistrationViewModel, UserDto>();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult SignUp(UserRegistrationViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                try
                {
                    var user = Mapper.Map<UserDto>(model);
                    user.Role = UserDtoRole.Customer;
                    user.State = UserDtoState.Normal;
                    this.userService.CreateUser(user);
                    this.userService.Commit();
                    return this.RedirectToAction("Index", "Home", new { area = "Common" });
                }
                catch (Exception e)
                {
                    return this.RedirectToAction("Index", "Home", new { area = "Common" });
                }
            }
            return this.View(model);
        }

        //public ActionResult Profile()
        //{

        //    BOL.Entities.User user = userHelper.GetAll().SingleOrDefault(x => x.Email == System.Web.HttpContext.Current.User.Identity.Name);
        //    return System.Web.UI.WebControls.View(user);
        //}

        //public ActionResult Edit(int id)
        //{
        //    BOL.Entities.User user = userHelper.GetById(id);
        //    return System.Web.UI.WebControls.View(user);
        //}

        //// POST: Admin/User/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, UserAuthorizationViewModel user)
        //{
        //    try
        //    {
        //        userHelper.Edit(user);

        //        return this.RedirectToAction("Profile");
        //    }
        //    catch
        //    {
        //        return this.View("Profile");
        //    }
        //}
    }
}