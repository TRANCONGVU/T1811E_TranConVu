using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFrist.Models
{
    public class enrollment
    {
        public int EnrollmentID { get; set; }
        public int Grade { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public virtual Student Student { get; set; }
        public course Course { get; set; }
    }
}