using MyGiftCloset.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Diagnostics;

namespace MyGiftCloset.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (var database = new MyGiftClosetEntities())
            {
                database.Database.Log = (message) => Debug.WriteLine(message);
                var gifts = database.Gifts
                    .Include(g => g.Holiday)
                    .Include(g => g.Recipient)
                    .ToList();


                //var gifts = new List<Gift>() { new Gift()
                //{
                //    Name = "test",
                //    Holiday = new Holiday() { Name = "xmas" }
                //},

                //new Gift()
                //{
                //    Name = "tes2",
                //     Holiday = new Holiday() { Name = "xmas" }
                //} };





                return View(gifts);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}