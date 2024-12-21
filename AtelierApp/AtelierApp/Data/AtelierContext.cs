using Microsoft.EntityFrameworkCore;
using AtelierApp.Models;
namespace AtelierApp.Data
{
    public class AtelierContext : DbContext
    {
        public AtelierContext(DbContextOptions<AtelierContext> options) : base(options) { }

        public DbSet<Atelier> Ateliers { get; set; }
    }
}
