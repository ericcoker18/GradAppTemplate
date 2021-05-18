using App.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Champion> Champions { get; set; }
        public DbSet<Lane> Lanes { get; set; }
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Lane>().HasData(
                new Lane { Id = 1, RoleName = "Mid", RoleDescription = " " },
                new Lane { Id = 2, RoleName = "Top", RoleDescription = " " },
                new Lane { Id = 3, RoleName = "Jungle", RoleDescription = " " },
                new Lane { Id = 4, RoleName = "Adc", RoleDescription = " " },
                new Lane { Id = 5, RoleName = "Support", RoleDescription = " " });

            base.OnModelCreating(builder);
        }
    }

}