using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.Context
{
    public class ProniaDbContext : IdentityDbContext<User,IdentityRole<Guid>,Guid>
    {
        public ProniaDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=ProniaTask;Trusted_Connection=True;TrustServerCertificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
