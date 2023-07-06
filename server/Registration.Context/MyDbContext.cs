using Microsoft.EntityFrameworkCore;
using Registration.Repositories.Entities;
using Registration.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Context
{
    public class MyDbContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<int[]>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=projectPractikumDb2;Trusted_Connection=True");
        }
    }
}
