using System;
using Microsoft.Data.Entity;
using System.Reflection;

namespace Test.Context
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
            builder.UseSqlite("Data source=c:\\temp\\dbtest.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Addition>().Key(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
