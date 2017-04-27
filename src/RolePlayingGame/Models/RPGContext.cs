using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RolePlayingGame.Models;

namespace RolePlayingGame.Models
{
    public class RPGContext : IdentityDbContext<User>
    {
        public RPGContext()
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<UserItem> UserItems { get; set; }

        public RPGContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RolePlayingGame;integrated security=True");
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserItem>()
                .HasKey(t => new { t.UserId, t.ItemId });
        }
    }
}
