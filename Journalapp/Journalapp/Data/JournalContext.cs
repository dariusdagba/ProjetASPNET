using Microsoft.EntityFrameworkCore;
using Journalapp.Models;

namespace Journalapp.Data
{
    public class JournalContext:DbContext
    {
        public JournalContext(DbContextOptions<JournalContext> options) : base(options) { }

        public DbSet<Article> Articles { get; set; }
    }
}
