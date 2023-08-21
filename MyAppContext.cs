using Courses.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    public class MyAppContext: DbContext
    {
        public DbSet<Users> Users { get; set; }
 
        public DbSet<Subjects> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=COLLO;Database=Courses;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
              new Users { Id = 1, Name = "User1", Description = "Description1" });

            var usersData = new Users[]
            {
               new Users { Id = 2, Name = "User2", Description = "Description2" },
               new Users { Id = 3, Name = "User3", Description = "Description3" },
               new Users { Id = 4, Name = "User4", Description = "Description4" },
               new Users { Id = 5, Name = "User5", Description = "Description5" },
               new Users { Id = 6, Name = "User6", Description = "Description6" },
            };
            modelBuilder.Entity<Users>().HasData(usersData);
        }
        
        }
    }

