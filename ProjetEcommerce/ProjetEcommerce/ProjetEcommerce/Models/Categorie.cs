using System.ComponentModel.DataAnnotations;

namespace ProjetEcommerce.Models
{
    public class Categorie
    {
        public int CategorieId { get; set; }

        [Required]
        public string CategorieNom { get; set; }
        public List<Produit> Produits { get; set; } = new List<Produit>();
    }

}
