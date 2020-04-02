using myProject1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace myProject1.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Proucts { get; set; }
    }
}