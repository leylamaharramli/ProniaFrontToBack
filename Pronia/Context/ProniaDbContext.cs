using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.Context
{
    public class ProniaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ProniaTask;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Slider> Sliders { get; set; }
    }
}
