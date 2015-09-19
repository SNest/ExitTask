namespace ExitTask.Presentation.Areas.Admin.Controllers
{
    using System.Web.Mvc;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Presentation.Areas.Admin.Models;
    using ExitTask.Presentation.Filters;

    [Culture]
    public class GeoManagementController : Controller
    {
        private readonly ICountryService countryService;
        private readonly ICityService cityService;
        private readonly IHotelService hotelService;

        public GeoManagementController(ICountryService countryService, ICityService cityService, IHotelService hotelService)
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

        public ActionResult AddOrEditCity()
        {
            return this.View();
        }

        public ActionResult RemoveCity()
        {
            return this.View();
        }

        public ActionResult AddOrEditHotel()
        {
            return this.View();
        }

        public ActionResult RemoveHotel()
        {
            return this.View();
        }
    }
}