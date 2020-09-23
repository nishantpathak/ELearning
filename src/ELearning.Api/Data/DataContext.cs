using System;

using Microsoft.EntityFrameworkCore;

using ELearning.Entities;

namespace ELearning.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Utility.CreatePasswordHash("123456", out byte[] passwordHash, out byte[] passwordSalt);
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, PasswordHash = passwordHash, PasswordSalt = passwordSalt, UserName = "admin" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Nishant", LastName = "Pathak", DateOfBirth = DateTime.Today },
                new Student { StudentId = 2, FirstName = "Gaurang", LastName = "Majethiya", DateOfBirth = DateTime.Today }
            );

        }
    }
}
