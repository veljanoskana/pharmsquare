using pharmsquare_prototype.Models;
using pharmsquare_prototype.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pharmsquare_prototype.Controllers
{
    public class PharmaciesController : Controller
    {
        PharmacyContext db = new PharmacyContext();
        CommentContext dbComments = new CommentContext();
        // GET: Pharmacy
        public ActionResult Index()
        {
            return View(db.Pharmacies.ToList());
        }
        public ActionResult saveToDatabase()
        {
            string filePath = "C:\\Users\\user\\source\\repos\\pharmsquare-prototype\\pharmsquare-prototype\\App_Data\\filtered_dataset_final_final.csv";

            //Read the contents of CSV file.
            string csvData = System.IO.File.ReadAllText(filePath);

            //Execute a loop over the rows.
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    db.Pharmacies.Add(new Pharmacy
                    {
                        ID = (int)Convert.ToInt64(row.Split(',')[0]),
                        Longitude = Convert.ToDouble(row.Split(',')[1]),
                        Latitude = Convert.ToDouble(row.Split(',')[2]),
                        Name = row.Split(',')[3],
                        WorkingHours = row.Split(',')[4],
                    });
                    db.SaveChanges();
                }
            }
            return View("Index");
        }

        public ActionResult ShowInfo(int id)
        {
            Pharmacy pharmacy = db.Pharmacies.Find(id);
            List<Comment> comments = dbComments.comments.Where(x => x.PharmacyID == id).ToList();
            DetailsViewModel model = new DetailsViewModel();
            model.Pharmacy = pharmacy;
            model.Comments = comments;
            return View(model);
        }

    }
}