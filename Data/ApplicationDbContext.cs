using Microsoft.EntityFrameworkCore;
using WordSaverApp.Models;

namespace WordSaverApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WordEntry> WordEntries { get; set; }
    }
}
