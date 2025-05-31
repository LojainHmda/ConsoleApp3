using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LOJAIN\\MSSQLSERVER01;Database=fakestore;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
