using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFundamentals.Models
{
    public class MovieListModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Review> Reviews { get; set; }


        public IEnumerable<SelectListItem> ReviewsSelectList(int id)
        {
            IEnumerable<SelectListItem> items = Reviews.Where(r => r.MovieId == id).
                                        Select(r => new SelectListItem {Text = r.Reviewer, Value = r.Id.ToString()});

            return items;
        }
    }
}