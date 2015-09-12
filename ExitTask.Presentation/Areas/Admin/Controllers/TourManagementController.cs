namespace ExitTask.Presentation.Areas.Admin.Controllers
{
    using System.Web.Mvc;

    using ExitTask.Application.ApplicationServices.Abstract;

    public class TourManagementController : Controller
    {
        private readonly ITourService tourService;
        public TourManagementController(ITourService tourService)
        {
            this.tourService = tourService;
        }

        [HttpGet]
        public ActionResult List()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(int id)
        {
            return this.View();
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