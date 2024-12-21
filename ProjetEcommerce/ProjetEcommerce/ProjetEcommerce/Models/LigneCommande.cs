using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetEcommerce.Models
{
    public class LigneCommande
    {
        public int LigneCommandeId { get; set; }

        [Required]
        public int CommandeId { get; set; }
        
        [Required]
        public int ProduitId { get; set; }

        [Required]
        public int Quantite { get; set; }
    }

}
