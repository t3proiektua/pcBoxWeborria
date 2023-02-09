using Microsoft.AspNetCore.Mvc;

namespace pcBoxOrria.Controllers
{
    public class RankingController : Controller
    {
        //Rankina ikuzteko erabiliko den bista deitzen du.
        public IActionResult Index()
        {
            return View("~/Views/Ranking/Index.cshtml");
        }
    }
}
