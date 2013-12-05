using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace ControllerKata.Controllers
{
    public class OutputController : Controller
    {
        //
        // GET: /Output/

        public string ShowPlainText(string text)
        {
            return text;
        }
        
        public ContentResult ShowContentResult(string text)
        {
            return Content(text, "text/plain");
        }

        public ContentResult ShowContentResultRss()
        {
            var gigs = ListOfGigs();
            
            var doc = new XDocument();

            return Content(doc.ToString(), "application/rss+xml");
        }

        private List<Gig> ListOfGigs()
        {
            return new List<Gig>
                {
                    new Gig {Venue = "Ministry of Sound", Date = new DateTime(2013, 1, 2)},
                    new Gig {Venue = "Pacha", Date = new DateTime(2013, 5, 5)},
                    new Gig {Venue = "Gatecrasher", Date = new DateTime(2013, 10, 9)}
                };
        }
    }
}
