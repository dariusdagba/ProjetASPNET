using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Humanizer;

namespace FilmDatabase.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required]
        public string Titre { get; set; }
        [Required]

        public string Realisateur { get; set; }

        public int GenreId { get; set; }
        [ForeignKey("GenreId")]

        public Genre Genre { get; set; }

        public string GetFormattedTitle()
        {
            return Titre.Humanize();
        }

    }
}
