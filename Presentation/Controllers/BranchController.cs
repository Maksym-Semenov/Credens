using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Credens.Presentation.Controllers
{
    public class BrunchController : Controller
    {
        // GET: BrunchController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BrunchController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BrunchController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrunchController/Create
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

        // GET: BrunchController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BrunchController/Edit/5
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

        // GET: BrunchController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BrunchController/Delete/5
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
