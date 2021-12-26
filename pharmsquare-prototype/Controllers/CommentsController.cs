using pharmsquare_prototype.Models;
using pharmsquare_prototype.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pharmsquare_prototype.Controllers
{
    public class CommentsController : Controller
    {
        [HttpPost]
        public JsonResult LeaveComment(CommentViewModel model)
        {
            var comment = new Comment();
            comment.Text = model.Text;
            comment.PharmacyID = model.PharmacyID;
            comment.Author = model.Name;
            comment.Timestamp = DateTime.Now;

            CommentContext context = new CommentContext();
            context.comments.Add(comment);
            bool success = context.SaveChanges() > 0;

            JsonResult result = new JsonResult();
            result.Data = new { Success = success};

            return result;
        }
    }
}