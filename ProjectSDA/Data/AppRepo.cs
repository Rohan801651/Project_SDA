using Microsoft.EntityFrameworkCore;

using ProjectSDA.Models;
using System.Diagnostics;

namespace ProjectSDA.Data
{
    public class AppRepo : DbContext
    {

        public AppRepo(DbContextOptions<AppRepo> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 13,
                    name = "Usman",
                    age = 18,
                    StudentAccountId = 247
                });

            // Seeding data for StudentAccount
            modelBuilder.Entity<StudentAccount>().HasData(
                new StudentAccount
                {
                    StudentId = 1,
                    RegNo = 247,
                    UserName = "Usman",
                    email = "usman@zabist",
                    phone = 1234567890,
                    City = "Karachi"
                });

            

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Student> Students { get; set; }   // Table name is Students
        public DbSet<StudentAccount> StudentAccounts { get; set; } // Table name is StudentAccounts





    }
}
