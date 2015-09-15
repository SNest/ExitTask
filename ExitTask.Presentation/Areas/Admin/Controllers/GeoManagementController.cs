using System.Web.Mvc;

namespace ExitTask.Presentation.Areas.Admin.Controllers
{
    using ExitTask.Application.ApplicationServices.Abstract;

    public class GeoManagementController : Controller
    {
        private ICountryService countryService;
        private ICityService cityService;
        private IHotelService hotelService;

        public GeoManagementController(ICountryService countryService, ICityService cityService, IHotelService hotelService)
        {
            this.countryService = countryService;
            this.cityService = cityService;
            this.hotelService = hotelService;
        }

        public ActionResult GeoList()
        {
            return View();
        }

        public ActionResult AddCountry()
        {
            return View();
        }

        public ActionResult RemoveCountry()
        {
            return View();
        }

        public ActionResult AddOrEditCity()
        {
            return View();
        }

        public ActionResult RemoveCity()
        {
            return View();
        }

        public ActionResult AddOrEditHotel()
        {
            return View();
        }

        public ActionResult RemoveHotel()
        {
            return View();
        }
    }
}