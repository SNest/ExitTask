namespace ExitTask.Presentation.Areas.Admin.Controllers
{
    using System.IO;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Presentation.Areas.Admin.Models;

    public class TourManagementController : Controller
    {
        private readonly ITourService tourService;
        internal TourManagementController(ITourService tourService)
        {
            this.tourService = tourService;
            Mapper.CreateMap<TourViewModel, TourDto>();
        }

        [HttpGet]
        internal ActionResult List()
        {
            return this.View();
        }

        [HttpGet]
        internal ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        internal ActionResult Create(TourViewModel model, HttpPostedFileBase upload)
        {
            if (this.ModelState.IsValid)
            {
                if (upload != null && upload.ContentLength > 0)
                {
                    using (var reader = new BinaryReader(upload.InputStream))
                    {
                        model.Image = reader.ReadBytes(upload.ContentLength);
                    }
                }

                var tour = Mapper.Map<TourViewModel, TourDto>(model);
                this.tourService.CreateTour(tour);
                return this.RedirectToAction("List");
            }
            return this.View();
        }

        [HttpGet]
        internal ActionResult Update()
        {
            return this.View();
        }

        [HttpPost]
        internal ActionResult Update(int id)
        {
            return this.View();
        }

        [HttpGet]
        internal ActionResult Delete()
        {
            return this.View();
        }

        [HttpPost]
        internal ActionResult Delete(int id)
        {
            return this.View();
        }
    }
}