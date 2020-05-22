﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class SiteData
    {

        public int SiteDataId { get; set; }
        [UrlAttribute]
        public string Website_Link { get; set; }

        public int Participate_Phase { get; set; }

        public string Survey_ID { get; set; }


    }
}
