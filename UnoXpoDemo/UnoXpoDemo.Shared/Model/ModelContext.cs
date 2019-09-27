using Microsoft.EntityFrameworkCore;
using System;

namespace UnoXpoDemo.Shared.Model
{
    public class ModelContext : DbContext
    {
        private readonly string _databasePath;

        public ModelContext(string databasePath)
        {
            _databasePath = databasePath;
        }

        public DbSet<Item> Items { get; set; }     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //http://www.entityframeworktutorial.net/efcore/configure-one-to-many-relationship-using-fluent-api-in-ef-core.aspx


            modelBuilder.Entity<Item>();
            

        }
    }
}
