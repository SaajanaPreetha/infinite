using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCassessm1ques2.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() : base("name=MoviesDB") { }

        public DbSet<Movie> Movies { get; set; }
    }
}