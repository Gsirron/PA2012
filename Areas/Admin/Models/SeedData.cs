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

            using (var context = new PrototypeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PrototypeContext>>()))
            {
                if(context.Participant.Any())
                {
                    return; // db has been seeded
                }

                context.Participant.AddRange(

                    new Participant()
                    {
                        
                        Participant_Email = "Janedo@gmail.com",
                        Participant_Data = "Participant Data"
                    },


                    new Participant()
                    {
                        
                        Participant_Email = "Janes.Bob@gmail.com",
                        Participant_Data = "Participant Data"
                    },

                    new Participant()
                    {
                        
                        Participant_Email = "Megan.Dale@gmail.com",
                        Participant_Data = "Participant Data"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
