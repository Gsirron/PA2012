using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Prototype.Areas.Admin.Models;
using Prototype.Areas.Identity.Data;
using Prototype.Models;

namespace Prototype.Areas.Admin.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using var context = new PrototypeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PrototypeContext>>());
            
            if (context.SiteData.Any())
            {
                return; // site data as been seeded
            }
            else
            {
                context.SiteData.AddRange(


                    new SiteData()
                    {   
                        SiteData_Phase = 1,
                        SiteData_Link = "https://surveyswesternsydney.au1.qualtrics.com",
                        SiteData_Name = "Phase 1",

                    },
                    new SiteData()
                    {
                        SiteData_Phase = 2,
                        SiteData_Link = "https://surveyswesternsydney.au1.qualtrics.com",
                        SiteData_Name = "Phase 2 (Pre-Test)",

                    }
                    ,new SiteData()
                    {
                        SiteData_Phase = 3,
                        SiteData_Link = "https://surveyswesternsydney.au1.qualtrics.com",
                        SiteData_Name = "Phase 2(Post-Test)",

                    }
                    ,new SiteData()
                    {
                        SiteData_Phase = 4,
                        SiteData_Link = "https://surveyswesternsydney.au1.qualtrics.com",
                        SiteData_Name = "Closed",
                        SiteData_Active = true,

                    }
                    
                    );

                context.SaveChanges();
            }
            
            
        }
    }
}
