using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pharmsquare_prototype.Models
{
    public class Pharmacy
    {   
        [Key]
        public int ID { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public String Name { get; set; }
        public String WorkingHours { get; set; }
    }
}