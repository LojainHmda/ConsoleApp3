using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.ConsoleApp3;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Data
{
    internal class ApplicationDpContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=;Database=fakestore;Trusted_conniction=True;TrustServerCertificate=True");
        }
    }
}
