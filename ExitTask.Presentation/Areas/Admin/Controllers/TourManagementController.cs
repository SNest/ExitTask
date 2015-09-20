namespace ExitTask.Presentation.Areas.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Presentation.Areas.Admin.Models;

    public class TourManagementController : Controller
    {
        private readonly ICityService cityService;

        private readonly IHotelService hotelService;

        private readonly ITourService tourService;

        public TourManagementController(ITourService tourService, ICityService cityService, IHotelService hotelService)
        {
            this.tourService = tourService;
            this.cityService = cityService;
            this.hotelService = hotelService;
            Mapper.CreateMap<TourViewModel, TourDto>();
        }

        [HttpGet]
        public ActionResult List()
        {
            return this.View();
        }

        private IEnumerable<SelectListItem> GetCities()
        {
            var cities =
                this.cityService.GetAllCitys()
                    .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });

            return new SelectList(cities, "Value", "Text");
        }

        private IEnumerable<SelectListItem> GetHotels()
        {
            var hotels =
                this.hotelService.GetAllHotels()
                    .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });

            return new SelectList(hotels, "Value", "Text");
        }

        [HttpGet]
        public ActionResult AddTour()
        {
            var model = new TourViewModel { Cities = this.GetCities(), Hotels = this.GetHotels() };
            return this.View(model);
        }

        [HttpPost]
        public ActionResult AddTour(TourViewModel model, HttpPostedFileBase picture)
        {
            if (this.ModelState.IsValid)
            {
                try
                {
                    if (picture != null)
                    {
                        var target = new MemoryStream();
                        picture.InputStream.CopyTo(target);
                        model.Image = target.ToArray();
                    }
                    else
                    {
                        
                    }

                    var tour = Mapper.Map<TourDto>(model);
                    this.tourService.CreateTour(tour);
                    this.tourService.Commit();
                    return this.RedirectToAction("Index", "Home", new { area = "Common" });
                }
                catch (Exception exception)
                {
                    this.ViewData["ErrMsg"] = exception.Message;
                    this.ViewData["ErrTrace"] = exception.StackTrace;
                    return this.View("Error");
                }
            }
            model = new TourViewModel { Cities = this.GetCities(), Hotels = this.GetHotels() };
            return this.View(model);
        }

        [HttpGet]
        public ActionResult Update()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Update(int id)
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            return this.View();
        }
    }
}