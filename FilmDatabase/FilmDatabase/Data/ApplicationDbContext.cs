using Microsoft.EntityFrameworkCore;
using FilmDatabase.Models;
namespace FilmDatabase.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Film>Films { get; set; }
        public DbSet<Genre>Genres { get; set; }
    }
}
