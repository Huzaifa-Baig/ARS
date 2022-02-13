using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ARS.Models
{
    public class Context:DbContext
    {
        public Context() : base("cs")
        {

        }
        public DbSet<AdminLogin> AdminLogin { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<AirlinePlaneInfo> AirlinePlaneInfo { get; set; }
        public DbSet<PlaneBooking> PlaneBooking { get; set; }

    }
}