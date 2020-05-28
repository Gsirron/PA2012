using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class SiteData
    {

        public int SiteDataId { get; set; }

        public string SiteData_Link { get; set; }

        public string SiteData_Name { get; set; }

        public bool SiteData_Active { get; set; } = false;

        public int SiteData_Phase { get; set; }


    }
}
