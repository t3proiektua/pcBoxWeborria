using MongoDB.Bson.IO;
using Newtonsoft.Json;
using pcBoxOrria.Models;

namespace pcBoxOrria.Services
{
    public class PartidaService : IPartidaService
    {
        //La url al json del api
        private Uri url = new Uri("http://localhost:8080/");

        public async Task<List<Partida>> GetPartidaMahiKingdom()
        {
            List<Partida> partidaList = new List<Partida>();
            Uri urlPartida1 = new Uri(url, "partidak_t1/partidaGuztiak");
            using(var httpClient = new HttpClient())
            {
                using(var response = await httpClient.GetAsync(urlPartida1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partidaList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Partida>>(apiResponse);
                }
            }
            return partidaList;
        }
        //Zombie Killer partidak jasotzeko
        public async Task<List<Partida>> GetPartidaZombieKiller()
        {
            List<Partida> partidaList = new List<Partida>();
            Uri urlPartida2 = new Uri(url, "partidak_t2/partidaGuztiak");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(urlPartida2))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partidaList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Partida>>(apiResponse);
                }
            }
            return partidaList;
        }
        //Zombie Killer partidak jasotzeko
        public async Task<List<Partida>> GetPartidaPouni()
        {
            List<Partida> partidaList = new List<Partida>();
            Uri urlPartida3 = new Uri(url, "partidak_t3/partidaGuztiak");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(urlPartida3))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partidaList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Partida>>(apiResponse);
                }
            }
            return partidaList;
        }
        //Zombie Killer partidak jasotzeko
        public async Task<List<Partida>> GetPartidaJohnny()
        {
            List<Partida> partidaList = new List<Partida>();
            Uri urlPartida4 = new Uri(url, "partidak_t4/partidaGuztiak");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(urlPartida4))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partidaList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Partida>>(apiResponse);
                }
            }
            return partidaList;
        }
    }
}
