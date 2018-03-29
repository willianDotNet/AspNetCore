
using Microsoft.EntityFrameworkCore;

namespace TesteRazor
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<Animal> Animals { get; set; }
    }
}
