using Microsoft.AspNetCore.Mvc;
using pcBoxOrria.Models;
using pcBoxOrria.Services;
using pcBoxOrria.ViewModels;

namespace pcBoxOrria.Controllers
{
    public class RankingController : Controller
    {
        private readonly IPartidaService _partidaService;
        public RankingController(IPartidaService partidaService)
        {
            _partidaService = partidaService;
        }
        public async Task<ActionResult> MahiKingdom()
        {
            var partidaVM = new PartidaViewModel();
            List<Partida> partidaGuztiak = new List<Partida>();
            partidaGuztiak = await _partidaService.GetPartidaMahiKingdom();
            partidaVM.PartidaViewModelList = partidaGuztiak;
            partidaGuztiak.Sort((x, y) => y.puntuazioa.CompareTo(x.puntuazioa));
            return View(partidaVM);
        }
        public async Task<ActionResult> ZombieKiller()
        {
            var partidaVM = new PartidaViewModel();
            List<Partida> partidaGuztiak = new List<Partida>();
            partidaGuztiak = await _partidaService.GetPartidaZombieKiller();
            partidaVM.PartidaViewModelList = partidaGuztiak;
            partidaGuztiak.Sort((x, y) => y.puntuazioa.CompareTo(x.puntuazioa));
            return View(partidaVM);
        }
        public async Task<ActionResult> Pouni()
        {
            var partidaVM = new PartidaViewModel();
            List<Partida> partidaGuztiak = new List<Partida>();
            partidaGuztiak = await _partidaService.GetPartidaPouni();
            partidaVM.PartidaViewModelList = partidaGuztiak;
            partidaGuztiak.Sort((x, y) => y.puntuazioa.CompareTo(x.puntuazioa));
            return View(partidaVM);
        }
        public async Task<ActionResult> Johnny()
        {
            var partidaVM = new PartidaViewModel();
            List<Partida> partidaGuztiak = new List<Partida>();
            partidaGuztiak = await _partidaService.GetPartidaPouni();
            partidaVM.PartidaViewModelList = partidaGuztiak;
            partidaGuztiak.Sort((x, y) => y.puntuazioa.CompareTo(x.puntuazioa));
            return View(partidaVM);
        }
    }
}
