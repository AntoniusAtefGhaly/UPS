using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UPS.Data;

[assembly: HostingStartup(typeof(UPS.Areas.Identity.IdentityHostingStartup))]
namespace UPS.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });

            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<ApplicationDbContext>(options =>
                    //options.UseSqlServer(
                    //    context.Configuration.GetConnectionString("ApplicationDbContextConnection")));

                //services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<ApplicationDbContext>();
           // });
        }
    }
}