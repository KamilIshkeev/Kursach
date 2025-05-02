using Kursach.Models;
using Microsoft.EntityFrameworkCore;

namespace Kursach.DataBaseContext
{
    public class KursachDbContext : DbContext
    {


        public KursachDbContext(DbContextOptions<KursachDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Achiev> Achiev { get; set; }

        public DbSet<ListAchiev> ListAchiev { get; set; }
    }
}
