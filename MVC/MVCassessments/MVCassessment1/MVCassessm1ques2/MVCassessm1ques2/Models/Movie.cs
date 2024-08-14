using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCassessm1ques2.Models
{
    public class Movie
    {
        [Key]
        public int Mid { get; set; }

        [Required]
        [StringLength(100)]
        public string Moviename { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateofRelease { get; set; }
    }
}