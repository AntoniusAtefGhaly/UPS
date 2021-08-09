using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UPS.Core.Entities;

namespace UPS.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseSubject> CourseSubjects { get; set; }
        public DbSet<ExpensesCourse> ExpensesCourses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<InstructorCourse> InstructorCourses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("users", "security");
            builder.Entity<IdentityRole>().ToTable("roles", "security");
        }
    }
}