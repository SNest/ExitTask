namespace ExitTask.Presentation.Areas.Admin.Controllers
{
    using System.Collections.Generic;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Presentation.Areas.Admin.Models;

    public class TourManagementController : Controller
    {
        private readonly ITourService tourService;
        public TourManagementController(ITourService tourService)
        {
            this.tourService = tourService;
            Mapper.CreateMap<TourCreateOrEditViewModel, TourDto>();
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
        public ActionResult Create(TourCreateOrEditViewModel model, HttpPostedFileBase upload)
        {
            if (this.ModelState.IsValid)
            {
                if (upload != null && upload.ContentLength > 0)
                {
                    using (var reader = new System.IO.BinaryReader(upload.InputStream))
                    {
                        model.Image = reader.ReadBytes(upload.ContentLength);
                    }
                }

                var tour = Mapper.Map<TourCreateOrEditViewModel, TourDto>(model);
                this.tourService.CreateTour(tour);
                return this.RedirectToAction("List");
            }
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