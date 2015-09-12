namespace ExitTask.Presentation.Areas.Common.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete.Tour;
    using ExitTask.Presentation.Areas.Common.Models;

    public class HomeController : Controller
    {
        private readonly ITourService tourService;

        public HomeController(ITourService tourService)
        {
            this.tourService = tourService;
        }
        public ActionResult Index()
        {
            Mapper.CreateMap<TourDetailDto, TourViewModel>();
           return this.View(Mapper.Map<List<TourViewModel>>(this.tourService.GetAllTours()));
        }
    }
}