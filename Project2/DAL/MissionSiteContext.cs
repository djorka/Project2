using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Project2.Models;

namespace Project2.DAL
{
    public class MissionSiteContext : DbContext
    {
        public MissionSiteContext() : base("MissionSiteContext")
        {

        }
        public DbSet<Missions> Missions { get; set; }

        public System.Data.Entity.DbSet<New_Project_2.Models.Users> Users { get; set; }
    }
}