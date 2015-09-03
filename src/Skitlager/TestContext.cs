using System;
using System.IO;
using Microsoft.Data.Entity;
using System.Reflection;

namespace Skitlager.Context
{
    public class Addition
    {
        public Guid Id { get; set; }
        public int Value { get; set; }
    }

    public class TestContext : DbContext
    {
        public DbSet<Addition> Additions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string dbPath = Path.Combine(ApplicationSettings.ApplicationBasePath, "dbtest.sqlite");
            builder.UseSqlite("Data source=" + dbPath);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Addition>().Key(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
