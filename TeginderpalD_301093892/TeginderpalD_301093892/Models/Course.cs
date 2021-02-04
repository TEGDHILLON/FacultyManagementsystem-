using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeginderpalD_301093892.Models
{
    public class Course
    {
        [Required(ErrorMessage = "Please enter Course name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Please enter  Department")]
        public string CourseDepartment { get; set; }

        [Required(ErrorMessage = "Please enter course Code")]
        public string CourseCode { get; set; }

       [Required(ErrorMessage = "Please Select Term")]
        public string CourseTerm { get; set; }
      
    }
}
