using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotatons.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Employee Name")]
        [Required(ErrorMessage = "Employee Name is Required")]
        [StringLength(35 , MinimumLength = 4)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        [StringLength(400)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Salary is Required")]
        [Range(2000, 100000 , ErrorMessage = "Salary must be between 2000 and 100000")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}" , ErrorMessage = "Wronggg ! Email")]
        public string Email { get; set; }

    }
}