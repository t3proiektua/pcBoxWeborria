using System.ComponentModel.DataAnnotations;
namespace pcBoxOrria.Models
{
    public class Komentarioa
    {
        [Key]
        public int id;
        public string comentario;
        public string filtro;
        public string user;
        public Komentarioa(){}
    }
}
