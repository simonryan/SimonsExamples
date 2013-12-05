using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EBuy.Website.Controllers
{
    public class AuctionsController : Controller
    {
        public ActionResult Details(long id = 0)
        {
            var auction = new EBuy.Website.Models.Auction
                {
                    Id = id,
                    Title = "Brand new widget 2.0",
                    Description = "This is a brand new widget",
                    StartPrice = 1.00m,
                    CurrentPrice = 13.40m,
                    StartTime = DateTime.Parse("6-15-2012 12:34 PM"),
                    EndTime = DateTime.Parse("6-15-2012 12:34 PM")
                };
            return View(auction);
        }

    }
}