namespace ExitTask.Presentation.Areas.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Presentation.Areas.Admin.Models;

    public class GeoManagementController : Controller
    {
        private readonly ICityService cityService;

        private readonly ICountryService countryService;

        private readonly IHotelService hotelService;

        public GeoManagementController(
            ICountryService countryService,
            ICityService cityService,
            IHotelService hotelService)
        {
            this.countryService = countryService;
            this.cityService = cityService;
            this.hotelService = hotelService;
        }

        public ActionResult GeoList()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult AddCountry()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult AddCountry(CountryViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                Mapper.CreateMap<CountryViewModel, CountryDto>();
                var country = Mapper.Map<CountryDto>(model);
                this.countryService.CreateCountry(country);
                this.countryService.Commit();
            }
            return this.View();
        }

        public ActionResult RemoveCountry()
        {
            return this.View();
        }

        private IEnumerable<SelectListItem> GetCountries()
        {
            var countries =
                this.countryService.GetAllCountries()
                    .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });

            return new SelectList(countries, "Value", "Text");
        }

        private IEnumerable<SelectListItem> GetCities()
        {
            var cities =
                this.cityService.GetAllCitys()
                    .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });

            return new SelectList(cities, "Value", "Text");
        }

        [HttpGet]
        public ActionResult AddCity()
        {
            var model = new CityViewModel { Countries = this.GetCountries() };
            return this.View(model);
        }

        [HttpPost]
        public ActionResult AddCity(CityViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                try
                {
                    //model.Country = this.countryService.GetCountry(model.CountryId);
                    Mapper.CreateMap<CityViewModel, CityDto>();
                    var city = Mapper.Map<CityDto>(model);
                    this.cityService.CreateCity(city);
                    this.cityService.Commit();
                }
                catch (Exception exception)
                {
                    this.ViewData["ErrMsg"] = exception.Message;
                    this.ViewData["ErrTrace"] = exception.StackTrace;
                    return this.View("Error", new {area =""});
                }
            }
            model = new CityViewModel { Countries = this.GetCountries() };
            return this.View(model);
        }

        public ActionResult RemoveCity()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult AddHotel()
        {
            var model = new HotelViewModel { Cities = this.GetCities() };
            return this.View(model);
        }

        [HttpPost]
        public ActionResult AddHotel(HotelViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                try
                {
                    //model.City = this.cityService.GetCity(model.CityId);
                    Mapper.CreateMap<HotelViewModel, HotelDto>();
                    var hotel = Mapper.Map<HotelDto>(model);
                    this.hotelService.CreateHotel(hotel);
                    this.hotelService.Commit();
                }
                catch (Exception exception)
                {
                    this.ViewData["ErrMsg"] = exception.Message;
                    this.ViewData["ErrTrace"] = exception.StackTrace;
                    return this.View("Error", new { area = "" });
                }
            }
            model = new HotelViewModel { Cities = this.GetCities() };
            return this.View(model);
        }

        public ActionResult RemoveHotel()
        {
            return this.View();
        }
    }
}