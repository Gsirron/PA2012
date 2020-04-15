using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prototype.Areas.Identity.Data;
using Prototype.Models;

[assembly: HostingStartup(typeof(Prototype.Areas.Identity.IdentityHostingStartup))]
namespace Prototype.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PrototypeContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PrototypeContextConnection")));

                services.AddDefaultIdentity<PrototypeUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PrototypeContext>();
            });
        }
    }
}