using MVCassessm1ques2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCassessm1ques2.Controllers
{
    public class MoviesController : Controller
    {
        private MoviesContext db = new MoviesContext();


        public ActionResult Year(int year)
        {
            var movies = db.Movies.Where(m => m.DateofRelease.Year == year).ToList();
            return View(movies);
        }
    }


}