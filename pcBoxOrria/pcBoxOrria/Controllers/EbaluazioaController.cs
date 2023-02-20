using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pcBoxOrria.Controllers
{
    public class EbaluazioaController : Controller
    {
        // GET: EbaluazioaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EbaluazioaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EbaluazioaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EbaluazioaController/Create
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

        // GET: EbaluazioaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EbaluazioaController/Edit/5
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

        // GET: EbaluazioaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EbaluazioaController/Delete/5
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
