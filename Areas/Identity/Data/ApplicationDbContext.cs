//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

//namespace UPS.Data
//{
//    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
//    {
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//            : base(options)
//        {
//        }

//        protected override void OnModelCreating(ModelBuilder builder)
//        {
//            base.OnModelCreating(builder);
//            builder.Entity<IdentityUser>().ToTable("users","security");
//            builder.Entity<IdentityRole>().ToTable("roles","security");

//            // Customize the ASP.NET Identity model and override the defaults if needed.
//            // For example, you can rename the ASP.NET Identity table names and more.
//            // Add your customizations after calling base.OnModelCreating(builder);
//        }
//    }
//}
