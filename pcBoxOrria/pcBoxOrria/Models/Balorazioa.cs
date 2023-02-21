namespace pcBoxOrria.Models
{
    /// <summary>
    /// klase onek balorazioak sortzeko eta irakurtzeko erabiliko dugun modeloa da.  
    /// </summary>
    public class Balorazioa
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int JokoarenId { get; set; }
        public int Puntuazioa { get; set; }
        public string Iruzkina { get; set; }
    }
}
