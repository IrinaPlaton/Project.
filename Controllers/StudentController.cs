using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJECTCTTTT.Controllers.Services;
using PROJECTCTTTT.Models;

namespace PROJECTCTTTT.Controllers
{
    public class StudentController : Controller
    {

        public ActionResult StudentList()
        {
            return View(StudentServices.Students);
        }

        // GET: StudentController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewList()
        {
            return View(StudentServices.Students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            Student x = StudentServices.Students.Where(module => module.Id == id).FirstOrDefault();
            return View(x);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student collection)
        {
            try
            {
                StudentServices.Students.Add(collection);
                return RedirectToAction(nameof(StudentList)); //!!!
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            Student x = StudentServices.Students.Where(module => module.Id == id).FirstOrDefault();
            return View(x);
            
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student collection)
        {
            try
            {
                Student x = StudentServices.Students.Where(module => module.Id == id).FirstOrDefault();
                x.clone(collection); //edit 
                return RedirectToAction(nameof(StudentList)); //!!!
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            Student x = StudentServices.Students.Where(module => module.Id == id).FirstOrDefault();
            return View(x);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            { //!!!!!!!
                Student x = StudentServices.Students.Where(module => module.Id == id).FirstOrDefault();
                int i = StudentServices.Students.IndexOf(x);
                StudentServices.Students.RemoveAt(i);
                return RedirectToAction(nameof(StudentList));
            }
            catch
            {
                return View();
            }
        }
    }
}
