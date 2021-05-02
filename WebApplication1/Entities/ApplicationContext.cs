using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities.configuration;

namespace WebApplication1.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
        : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentDetails> StudentsDetails { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departement> Departements { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .ToTable("Student");
            modelBuilder.Entity<Student>()
                .Property(s => s.StudentId)
                .HasColumnName("StudentId");
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Student>()
                .Property(s => s.Age)
                .IsRequired(false);
            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentId);
            modelBuilder.Entity<Student>()
       .HasData(
           new Student
           {
               StudentId = 1,
               Name = "John Doe",
               Age = 30
           },
           new Student
           {
               StudentId = 2,
               Name = "Jane Doe",
               Age = 25
           }
       );
            modelBuilder.ApplyConfiguration(new StudentSubjectConfiguration());

        }
    }
}
