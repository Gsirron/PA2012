using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Areas.Admin.Models
{
    public class Participant
    {   
        
        public int ParticipantId { get; set; }
        [Required]
        [EmailAddress]
        public string Participant_Email { get; set; }
        public string Participant_Data { get; set; }
        public int Participant_Phase { get; set; }

        public string Participant_Group { get; set; }
        

        public string Participant_Gender { get; set; }
        
        public int Participant_Age { get; set; }

    }
}
