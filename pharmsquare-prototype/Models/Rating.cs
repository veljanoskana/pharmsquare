using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pharmsquare_prototype.Models
{
    public class Rating
    {
        [Key]
        public int ID { get; set; }
        public int Value { get; set; }
        public int PharmacyID { get; set; }
    }
}