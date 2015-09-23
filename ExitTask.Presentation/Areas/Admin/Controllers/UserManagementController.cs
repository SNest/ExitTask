using System.Web.Mvc;

namespace ExitTask.Presentation.Areas.Admin.Controllers
{
    public class UserManagementController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Details(int id)
        {
            return this.View();
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return this.RedirectToAction("Index");
            }
            catch
            {
                return this.View();
            }
        }

        public ActionResult Edit(int id)
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return this.RedirectToAction("Index");
            }
            catch
            {
                return this.View();
            }
        }

        public ActionResult Delete(int id)
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return this.RedirectToAction("Index");
            }
            catch
            {
                return this.View();
            }
        }
    }
}
