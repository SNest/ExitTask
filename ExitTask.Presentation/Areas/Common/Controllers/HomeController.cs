namespace ExitTask.Presentation.Areas.Common.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Presentation.Areas.Common.Models;
    using ExitTask.Presentation.Filters;

    [Culture]
    public class HomeController : Controller
    {
        private readonly ITourService tourService;

        public HomeController(ITourService tourService)
        {
            this.tourService = tourService;
        }

        public ActionResult Index()
        {
            Mapper.CreateMap<TourDto, TourViewModel>();
            return this.View(Mapper.Map<List<TourViewModel>>(this.tourService.GetTourPreviews()));
        }

        public ActionResult ChangeCulture(string lang)
        {
            var returnUrl = this.Request.UrlReferrer.AbsolutePath;
            // Список культур
            var cultures = new List<string> { "ru", "uk-UA" };
            if (!cultures.Contains(lang))
            {
                lang = "ru";
            }
            // Сохраняем выбранную культуру в куки
            var cookie = this.Request.Cookies["lang"];
            if (cookie != null)
            {
                cookie.Value = lang; // если куки уже установлено, то обновляем значение
            }
            else
            {
                cookie = new HttpCookie("lang") { HttpOnly = false, Value = lang, Expires = DateTime.Now.AddYears(1) };
            }
            this.Response.Cookies.Add(cookie);
            return this.Redirect(returnUrl);
        }
    }
}