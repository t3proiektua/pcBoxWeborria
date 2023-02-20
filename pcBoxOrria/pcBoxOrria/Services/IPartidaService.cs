using pcBoxOrria.Models;

namespace pcBoxOrria.Services
{
    public interface IPartidaService
    {
        Task<List<Partida>> GetPartidaMahiKingdom();
        Task<List<Partida>> GetPartidaZombieKiller();
        Task<List<Partida>> GetPartidaPouni();
        Task<List<Partida>> GetPartidaJohnny();
    }
}
