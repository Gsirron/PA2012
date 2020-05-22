﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prototype.Areas.Admin.Models;
using Prototype.Areas.Identity.Data;

namespace Prototype.Models
{
    public class PrototypeContext : IdentityDbContext<PrototypeUser>
    {
        public PrototypeContext(DbContextOptions<PrototypeContext> options)
            : base(options)
        {
        }

        public DbSet<Participant> Participant { get; set; }
        public DbSet<SiteData> SiteData { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
