using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pharmsquare_prototype.Models
{
    public class DrugContext : DbContext
    {
        public DbSet<Drug> Drugs { get; set; }

        public DrugContext () : base("DefaultConnection") { }

        public static PharmacyContext Create ()
        {
            return new PharmacyContext();
        }

        public System.Data.Entity.DbSet<pharmsquare_prototype.Models.Аrticle> Аrticle { get; set; }
    }
}