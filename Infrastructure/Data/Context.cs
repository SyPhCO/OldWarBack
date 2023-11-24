using Domain.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class Context: IdentityDbContext
    {
        public Context(DbContextOptions options) : base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach(var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
                    }
                
            base.OnModelCreating(builder);
        }

        public DbSet<Rank> Rank { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Rank_Category> Rank_Category { get; set; }
        public DbSet<Battle> Battle { get; set; }
        public DbSet<Alliance> Alliance { get; set; }
        public DbSet<Alliance_Country> Alliance_Country { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<GlobalWar> GlobalWar { get; set; }
        public DbSet<Faction> Faction { get; set; }
        public DbSet<ByHour> ByHour { get; set; }






    }
}
