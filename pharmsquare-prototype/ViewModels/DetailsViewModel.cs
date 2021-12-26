using pharmsquare_prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pharmsquare_prototype.ViewModels
{
    public class DetailsViewModel
    {
        public Pharmacy Pharmacy { get; set; }
        public List<Comment> Comments { get; set; }
    }
}