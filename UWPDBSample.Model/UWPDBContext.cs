using Microsoft.EntityFrameworkCore;
using System;

namespace UWPDBSample.Model
{
    public class UWPDBContext : DbContext
    {
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=UWPDB.db");
        }
    }

    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
