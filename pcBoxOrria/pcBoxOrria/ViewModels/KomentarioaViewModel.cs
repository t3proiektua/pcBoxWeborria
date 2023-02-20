using pcBoxOrria.Models;

namespace pcBoxOrria.ViewModels
{
    public class KomentarioaViewModel
    {
        public string user { get; set; }
        public string komentarioa { get; set; }
        public IList<Komentarioa> KomentarioaViewModelList { get; set; }
    }
}
