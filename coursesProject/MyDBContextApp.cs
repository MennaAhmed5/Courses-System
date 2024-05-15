using coursesProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursesProject
{
    public class MyDBContextApp:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EOBEQTJ\\SQLEXPRESS;Database=CoursesER;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Property Configurations
             modelBuilder.Entity<Student>()
                .ToTable("Student")
                .HasKey(s => s.Id);

            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .IsRequired(false)
                .HasMaxLength(255);

            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .IsRequired(false)
                .HasMaxLength(255);

            modelBuilder.Entity<Student>()
               .Property(s => s.Phone)
               .IsRequired(false);
               

            modelBuilder.Entity<Department>()
               .ToTable("Department")
               .HasKey(d => d.Name);

            modelBuilder.Entity<Department>()
                .Property(d => d.Location)
                .IsRequired(false)
                .HasMaxLength(100)
                .HasDefaultValue("Un known");

            modelBuilder.Entity<Student>()
               .ToTable("Student")
               .HasKey(s => s.Id);

            modelBuilder.Entity<Course>()
                .ToTable("Course")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Course>()
                .Property(c => c.Duration)
                .HasDefaultValue(0);
                

            modelBuilder.Entity<Course>()
               .Property(c => c.Name)
               .IsRequired(false)
               .HasDefaultValue("Unknown"); 

            modelBuilder.Entity<Course>()
              .Property(c => c.DepartmentName)
              .IsRequired(false)
              .HasDefaultValue("Unknown");


            modelBuilder.Entity<Department>()
               .HasData(new Department()
               {
                   Name = "Default"

               });

            modelBuilder.Entity<Instructor>()
                .Property(i => i.DepartmentName)
                .HasDefaultValue("Default");

            modelBuilder.Entity<Course>()
              .Property(c => c.DepartmentName)
              .HasDefaultValue("Default");

            modelBuilder.Entity<Instructor>()
                .ToTable("Instructor")
                .HasKey(i => i.Id);

            modelBuilder.Entity<Instructor>()
                .Property(i => i.LastName)
                .IsRequired()
                .HasMaxLength(255)
                .HasDefaultValue("Unknown");

            modelBuilder.Entity<Instructor>()
               .Property(i => i.FirstName)
               .IsRequired()
               .HasMaxLength(255)
               .HasDefaultValue("Unknown"); 

            modelBuilder.Entity<Instructor>()
               .Property(i => i.Phone)
               .IsRequired(false)
               .HasDefaultValue("Unknown");
               

            modelBuilder.Entity<CourseSession>()
                .HasKey(cs => cs.Id);

            modelBuilder.Entity<CourseSession>()
               .Property(cs => cs.Date)
               .IsRequired()
               .HasDefaultValue("3-11-2024");

            modelBuilder.Entity<CourseSession>()
              .Property(cs => cs.Title)
              .IsRequired(false)
              .HasDefaultValue("learn programming");

            modelBuilder.Entity<CourseSessionAttendence>()
             .HasKey(csa => csa.Id);

            


            modelBuilder.Entity<CourseSessionAttendence>()
            .Property(csa => csa.Notes)
            .IsRequired(false);
            


            modelBuilder.Entity<Department>()  //one
                .HasMany<Instructor>()  //many
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.DepartmentName)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Department>()
                .HasMany<Course>()
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DepartmentName)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Instructor>()
                .HasMany<Course>()
                .WithOne(c => c.Instructor)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<CourseStudent>()
               .HasKey(cs => new { cs.StudentId,cs.CourseId });

            modelBuilder.Entity<Course>()
               .HasMany<CourseStudent>()
               .WithOne(cs => cs.Course)
               .HasForeignKey(cs => cs.CourseId)
               .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Student>()
               .HasMany<CourseStudent>()
               .WithOne(cs=>cs.Student)
               .HasForeignKey(cs => cs.StudentId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Instructor>()
                .HasMany<CourseSession>()
                .WithOne(cs => cs.Instructor)
                .HasForeignKey(cs => cs.InstructorID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Course>()
              .HasMany<CourseSession>()
              .WithOne(cs => cs.Course)
              .HasForeignKey(cs => cs.CourseID)
              .OnDelete(DeleteBehavior.NoAction);


           modelBuilder.Entity<CourseSession>()
              .HasMany<CourseSessionAttendence>()
              .WithOne(csa => csa.CourseSession)
              .HasForeignKey(csa => csa.CourseSessionId)
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Student>()
             .HasMany<CourseSessionAttendence>()
             .WithOne(csa => csa.Student)
             .HasForeignKey(csa => csa.StudentID)
             .OnDelete(DeleteBehavior.NoAction);




        }

        public DbSet <Student> Student { get; set; }
        public DbSet<Department> Department{ get; set; }

        public DbSet<Course> Course { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
       
        public DbSet<CourseStudent> CourseStudent { get; set; }
        public DbSet<CourseSession> CourseSession{ get; set; }

        public DbSet<CourseSessionAttendence> CourseSessionAttendence { get; set; }



    }
}
