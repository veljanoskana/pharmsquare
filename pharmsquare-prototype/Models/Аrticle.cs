using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pharmsquare_prototype.Models
{
    public class Аrticle
    {
        [Key]
        public int ID { get; set; }

        public String Title { get; set; }

        public String Date { get; set; }

        public String Author { get; set; }

        public String ImageURL { get; set; }

        public String Text { get; set; }

        public String shortText => Text.Substring(0, 150) + "...";

    }
}