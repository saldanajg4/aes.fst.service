using System.Collections.Generic;
using System.Reflection.Emit;
using aes.fst.service.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace aes.fst.service.Data
{
    public class SalesPortalContext : DbContext
    {
        public SalesPortalContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(s => s.IsActive.HasValue && s.IsActive.Value);
        }
    }
}
