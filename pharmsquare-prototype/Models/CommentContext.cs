using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pharmsquare_prototype.Models
{
    public class CommentContext : DbContext
    {
        public DbSet<Comment> comments { get; set; }

        public CommentContext() : base("DefaultConnection") { }

        public static CommentContext Create()
        {
            return new CommentContext();
        }

    }
}