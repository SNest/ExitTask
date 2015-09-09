using System.Web.Mvc;

namespace ExitTask.Presentation.Controllers
{
    using System.Collections.Generic;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Presentation.Models;

    public class HomeController : Controller
    {
        private readonly ITourService tourService;

        public HomeController(ITourService tourService)
        {
            this.tourService = tourService;
        }
        public ActionResult Index()
        {
            return this.View(Mapper.Map<List<TourViewModel>>(this.tourService.GetAllTours()));
        }
    }
}