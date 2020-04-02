using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFrist.Models
{
    public class course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<enrollment> Enrollments { get; set; }
    }
}