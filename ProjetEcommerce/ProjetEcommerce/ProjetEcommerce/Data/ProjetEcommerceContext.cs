using Microsoft.EntityFrameworkCore;
using ProjetEcommerce.Models;
namespace ProjetEcommerce.Data
{
    public class ProjetEcommerceContext : DbContext
    {
        public ProjetEcommerceContext(DbContextOptions<ProjetEcommerceContext> options) : base(options) { }

        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<LigneCommande> LigneCommandes { get; set; }

    }
}
