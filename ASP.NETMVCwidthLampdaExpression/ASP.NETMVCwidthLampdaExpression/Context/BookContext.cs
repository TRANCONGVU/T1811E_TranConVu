using ASP.NETMVCwidthLampdaExpression.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NETMVCwidthLampdaExpression.Context
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}