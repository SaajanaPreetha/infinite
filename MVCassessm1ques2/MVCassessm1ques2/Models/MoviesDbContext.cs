using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCassessm1ques2.Models
{
   {
          public ProductsContext() : base("connectstr")
          { }

         public DbSet<Products> Product { get; set; }
         public DbSet<Sales> Sale { get; set; }
   }
}