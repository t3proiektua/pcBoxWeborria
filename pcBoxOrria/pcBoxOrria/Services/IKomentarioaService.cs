using pcBoxOrria.Models;

namespace pcBoxOrria.Services
{
    public interface IKomentarioaService
    {
        Task<List<Komentarioa>> GetKomentarioak();
        Task PostKomentarioa(Komentarioa komentarioa);
    }
}
