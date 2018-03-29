using Microsoft.EntityFrameworkCore;
using WebRazorPages.Pages;

namespace WebRazorPages
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions opts) : base(opts)
        {
        }

        public DbSet<Animal> Animals { get; set; }
    }
}