using System.ComponentModel.DataAnnotations;

namespace ProjetEcommerce.Models
{
    public class Commande
    {
        public int CommandeId { get; set; }

        [Required]
        public DateTime DateCommande { get; set; }
        public List<LigneCommande> LigneCommandes { get; set; } = new List<LigneCommande>();
    }
}
