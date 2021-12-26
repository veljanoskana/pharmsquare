using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pharmsquare_prototype.Models
{
    public class PharmacyContext : DbContext 
    {
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public PharmacyContext () : base("DefaultConnection") { }

        public static PharmacyContext Create ()
        {
            return new PharmacyContext();
        }
    }
}