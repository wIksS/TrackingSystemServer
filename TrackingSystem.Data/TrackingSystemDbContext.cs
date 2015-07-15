﻿using Microsoft.AspNet.Identity.EntityFramework;
//using TrackingSystem.Data.Migrations;
using TrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Models;

namespace TrackingSystem.Data
{
    public class TrackingSystemDbContext : IdentityDbContext
    {
        public TrackingSystemDbContext()
            : base("TrackingSystemConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TrackingSystemDbContext, Configuration>());
        } 

        IDbSet<ApplicationUser> Users { get; set; }

        public static TrackingSystemDbContext Create()
        {
            return new TrackingSystemDbContext();
        }
    }
}
