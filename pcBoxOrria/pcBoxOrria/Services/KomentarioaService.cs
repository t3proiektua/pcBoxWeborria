using MongoDB.Bson.IO;
using Newtonsoft.Json;
using pcBoxOrria.Models;
using System.Text;

namespace pcBoxOrria.Services
{
    public class KomentarioaService : IKomentarioaService
    {
        private Uri url = new Uri("http://localhost:8080");
        
        public async Task<List<Komentarioa>> GetKomentarioak()
        {
            List<Komentarioa> komentarioaList = new List<Komentarioa>();
            Uri urlKomentarioak = new Uri(url, "/comentarioak/comentarioGuztiak");
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(urlKomentarioak))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    komentarioaList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Komentarioa>>(apiResponse);
                }
            }
            return komentarioaList;
        }
        public async Task PostKomentarioa(Komentarioa komentarioa)
        {
            using(var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(komentarioa), Encoding.UTF8, "application/json");
                Uri urlKomentarioaGehitu = new Uri(url, "/comentarioak/comentarioBerria");
                var response = await httpClient.PostAsync(urlKomentarioaGehitu, content);
                string responseContent = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
