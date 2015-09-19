namespace ExitTask.Presentation.Areas.Security.Controllers
{
    using System;
    using System.Web.Mvc;
    using System.Web.Security;

    using ExitTask.Presentation.Areas.Security.Models;

    [AllowAnonymous]
    public class AuthorizationController : Controller
    {

        [HttpGet]
        public ActionResult SignIn()
        {
            return this.View();
        }

        public ActionResult SignIn(UserAuthorizationViewModel model)
        {
            try
            {
                if (!Membership.ValidateUser(model.Email, model.Password)) 
                    return this.RedirectToAction("Index");
                FormsAuthentication.SetAuthCookie(model.Email, false);
                return this.RedirectToAction("Index", "Home", new { area = "Common" });
            }
            catch (Exception exception)
            {
                return this.View(model);
            }
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return this.RedirectToAction("Index", "Home", new { area = "Common" });
        }
    }
}