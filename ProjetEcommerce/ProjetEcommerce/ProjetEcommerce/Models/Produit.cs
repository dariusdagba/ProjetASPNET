using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetEcommerce.Models
{
    public class Produit
    {
        public int ProduitId { get; set; }

        [Required]
        public string ProduitNom { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Prix { get; set; }
        [Required]
        public int CategorieId { get; set; }

        public List<LigneCommande> LigneCommandes { get; set; } = new List<LigneCommande>();

    }

}
