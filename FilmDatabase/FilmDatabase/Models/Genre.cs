using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }

        public ICollection<Film> Films { get; set; }
        
    }
}
