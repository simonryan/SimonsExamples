using System;
using System.Linq;
using System.Web.Mvc;
using MvcFundamentals.Models;

namespace MvcFundamentals.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /MovieModel/

        private MoviesEntities _dbContext;
        private MoviesEntities DbContext
        {
            get { return _dbContext ?? (_dbContext = new MoviesEntities()); }
        }

        public ActionResult Index(string genre = "")
        {
            var model = new MovieListModel();
            
            model.Movies = DbContext.Movies.OrderByDescending(m => m.ReleaseDate);
            model.Reviews = DbContext.Reviews.OrderByDescending(r => r.Reviewer);
            
            return View(model);
        }

        public ActionResult GetByGenre(string genre = "")
        {
            var model = new MovieListModel();
            
            if (string.IsNullOrEmpty(genre))
            {
                model.Movies = DbContext.Movies.OrderByDescending(m => m.ReleaseDate);
                model.Reviews = DbContext.Reviews.OrderByDescending(r => r.Reviewer);
            }
            else
            {
                model.Movies = DbContext.Movies.Where(m => m.Genre == genre);
                model.Reviews = DbContext.Reviews.OrderByDescending(r => r.Reviewer);
            }

            return View("Index", model);
        }

        //
        // GET: /MovieModel/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /MovieModel/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /MovieModel/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /MovieModel/Edit/5
 
        public ActionResult Edit(int id)
        {
            var movie = DbContext.Movies.SingleOrDefault(m => m.Id == id);
            
            return View(movie);
        }

        //
        // POST: /MovieModel/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var movie = DbContext.Movies.Single(m => m.Id == id);

            TryUpdateModel(movie, new string[] {"Title", "ReleaseDate"}, collection.ToValueProvider());
            
            if (string.IsNullOrEmpty(movie.Title))
            {
                ModelState.AddModelError("Title", "title cannot be empty");
            }

            if (ModelState.IsValid)
            {
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);

        }

        //
        // GET: /MovieModel/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /MovieModel/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GetByReleaseDate(DateTime releaseDate)
        {
            if (releaseDate == null)
            {
                return RedirectToAction("Index");
            }

            var model = new MovieListModel();
            
            model.Reviews = DbContext.Reviews.OrderByDescending(r => r.Id).ToList();
            model.Movies = DbContext.Movies.Where(movie => movie.ReleaseDate > releaseDate).ToList();
            
            return View("Index", model);
        }
    }
}
