using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pharmsquare_prototype.Models
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime Timestamp { get; set; }
        public int PharmacyID { get; set; }
    }
}