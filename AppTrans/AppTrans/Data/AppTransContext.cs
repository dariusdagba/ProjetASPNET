using Microsoft.EntityFrameworkCore;
using AppTrans.Models;
namespace AppTrans.Data
{
    public class AppTransContext : DbContext
    {
        public AppTransContext(DbContextOptions<AppTransContext> options) : base(options) { }

        public DbSet<Produit> Produits { get; set; }
    }
}
