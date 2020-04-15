using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prototype.Areas.Admin.Models;

namespace Prototype.Areas.Admin.Models
{
    public class SeedData
    {

        public List<Participant> GetParticipants()
        {

            List<Participant> result = new List<Participant>
            {
                new Participant(){
                Participant_Id = 23,
                Participant_Email = "Janedo@gmail.com",
                Participant_Data = "some Data" },

                new Participant(){
                Participant_Id = 17,
                Participant_Email = "Janes.Bob@gmail.com",
                Participant_Data = "some Data" },

                new Participant(){
                Participant_Id = 117,
                Participant_Email = "Megan.Dale@gmail.com",
                Participant_Data = "some Data" },


            };

            return result;
        }
    }
}
