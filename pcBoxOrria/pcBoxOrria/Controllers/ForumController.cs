using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pcBoxOrria.Models;
using pcBoxOrria.Services;
using pcBoxOrria.ViewModels;

namespace pcBoxOrria.Controllers
{
    public class ForumController : Controller
    {
        private readonly IKomentarioaService _komentarioaService;
        public ForumController(IKomentarioaService komentarioaService)
        {
            _komentarioaService = komentarioaService;
        }
        public async Task<ActionResult> Komentarioa()
        {
            var komentarioaVM = new KomentarioaViewModel();
            List<Komentarioa> komentarioGuztiak = new List<Komentarioa>();
            komentarioGuztiak = await _komentarioaService.GetKomentarioak();
            komentarioaVM.KomentarioaViewModelList = komentarioGuztiak;
            komentarioGuztiak.Sort((x, y) => y.id.CompareTo(x.id));
            return View(komentarioaVM);
        }
        /// <summary>
        /// Komentarioak rest api erabiliz igoteko erabiltzen den komentarioa
        /// </summary>
        /// <param name="user">Loginean dagoen erabiltzailea hartzen du</param>
        /// <param name="komentarioa">Idatzitako komentarioa</param>
        /// <returns></returns>
        public IActionResult PostKomentarioa(string user, string komentarioa)
        {
            Komentarioa komentarioaObject = new Komentarioa();
            komentarioaObject.user = user;
            komentarioaObject.comentario = komentarioa;
            return View();
        }

        // POST: ForumController/Create
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
        // GET: ForumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ForumController/Delete/5
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
