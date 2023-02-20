using System.ComponentModel.DataAnnotations;

namespace pcBoxOrria.Models
{
    public class Partida
    {
        [Key]
        public int id { get; set; }
        public string data { get; set; }
        public string erabiltzailea { get; set; }
        public int jokoa { get; set; }
        public int puntuazioa { get; set; }
        public Partida() { }
    }
}
