using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PROJECTCTTTT.Controllers.Services;
using PROJECTCTTTT.Models;

namespace PROJECTCTTTT.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult CourseList()
        {
            return View(CourseServices.courses);
        }
        // GET: CourseController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CourseController/Details/5
        public ActionResult Details (int id) // works like edit method
        {
            Course x = CourseServices.courses.Where(module => module.Id == id).FirstOrDefault();
            return View(x);
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course collection)
        {
            try
            {
                CourseServices.courses.Add(collection);
                return RedirectToAction(nameof(CourseList)); //!!!
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit (int id)
        {
            return View();
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course collection)
        {
            try
            {
                Course x = CourseServices.courses.Where(module => module.Id == id).FirstOrDefault();
                if (x != null)
                {
                    x.Change(collection); //rabotaet kak clone  v studente
                }
                return RedirectToAction(nameof(CourseList));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id) // esli udalit elemnt id 
        {
            Course x = CourseServices.courses.Where(module => module.Id == id).FirstOrDefault(); //nahodit elemnt

            return View(x); // shows the element
        }

        // POST: CourseController/Delete/5 / 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Course collection) // udalyaet element
        {
            try 
            {
                Course x = CourseServices.courses.Where(module => module.Id == id).FirstOrDefault();
                int i = CourseServices.courses.IndexOf(x);
                CourseServices.courses.RemoveAt(i);
                return RedirectToAction(nameof(CourseList));
            }
            catch
            {
                return View();
            }
        }
    }
}
