using EntityFrameworkCodeFrist.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFrist.DAL
{
    public class CodeFristExampleContext : DbContext        
    {
        public CodeFristExampleContext() : base("CodeFirstExampleContext") 
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<course> courses { get; set; }
        public DbSet<enrollment> enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}