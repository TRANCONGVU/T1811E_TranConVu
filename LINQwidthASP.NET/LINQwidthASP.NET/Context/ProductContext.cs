using LINQwidthASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LINQwidthASP.NET.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}