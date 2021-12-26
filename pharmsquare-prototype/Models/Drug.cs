using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pharmsquare_prototype.Models
{
    public class Drug
    {
        [Key]
        public int ID { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public String ImageURL { get; set; }
    }
}