using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJECTCTTTT.Controllers.Services;
using PROJECTCTTTT.Models;

namespace PROJECTCTTTT.Controllers
{
    public class ModuleController : Controller
    {
        
        public ActionResult ModuleList()
        {
            return View(ModuleServices.modules);
        }
        // GET: ModuleController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: ModuleController1/Details/5
        public ActionResult Details(int id)
        {
            Module x = ModuleServices.modules.Where(module => module.Id == id).FirstOrDefault();

            return View(x);
        }

        // GET: ModuleController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModuleController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Module collection)
        {
            try
            {
                ModuleServices.modules.Add((Models.Module)collection);
                return RedirectToAction(nameof(ModuleList)); //!!!
            }
            catch
            {
                return View();
            }
        }

        // GET: ModuleController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ModuleController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Module collection)
        {
            try
            {
                Module x = ModuleServices.modules.Where(module => module.Id == id).FirstOrDefault();
                x.clone(collection); //edit 
                return RedirectToAction(nameof(ModuleList));
            }
            catch
            {
                return View();
            }
        }

        // GET: ModuleController1/Delete/5
        public ActionResult Delete(int id)
        {
            Module x = ModuleServices.modules.Where(module => module.Id == id).FirstOrDefault();
            return View(x);
        }

        // POST: ModuleController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Module x = ModuleServices.modules.Where(module => module.Id == id).FirstOrDefault();
                int i = ModuleServices.modules.IndexOf(x);
                ModuleServices.modules.RemoveAt(i);
                return RedirectToAction(nameof(ModuleList));
            }
            catch
            {
                return View();
            }
        }
    }
}
