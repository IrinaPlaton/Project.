using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJECTCTTTT.Controllers.Services;

namespace PROJECTCTTTT.Controllers
{
    public class AttendingClassController : Controller
    {
        // GET: AttendingClassController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(StudentServices.Students);
        }

        // GET: AttendingClassController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AttendingClassController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AttendingClassController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AttendingClassController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AttendingClassController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AttendingClassController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AttendingClassController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
