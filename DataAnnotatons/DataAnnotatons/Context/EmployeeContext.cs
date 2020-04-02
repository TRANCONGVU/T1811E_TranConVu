using DataAnnotatons.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataAnnotatons.Context
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        
    }
}