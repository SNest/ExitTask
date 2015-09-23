using System.Web.Mvc;

namespace ExitTask.Presentation.Areas.User.Controllers
{
    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Application.DTOs.Concrete.Enum;

    public class BookingController : Controller
    {
        private readonly ITourService tourService;
        private readonly IUserService userService;

        private readonly UserDto user; 
        public BookingController(ITourService tourService, IUserService userService)
        {
            this.tourService = tourService;
            this.userService = userService;
            this.user = this.userService.GetUser(this.User.Identity.Name);
        }

        [HttpGet]
        public ActionResult BookTour(int id)
        {
            var tour = this.tourService.GetTour(id);
            
            tour.CustomerId = this.user.Id;
            tour.State = TourDtoState.Booked;

            return this.RedirectToAction("ShowBookedTours");
        }

        public ActionResult ShowBookedTours()
        {
            var model = this.tourService.GetToursByUserId(this.user.Id);
            return this.View(model);
        }
    }
}