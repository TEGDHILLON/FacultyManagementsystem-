using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeginderpalD_301093892.Models
{
    public class Faculty
    {

        [Required(ErrorMessage = "Please enter name")]
        public string FacultyName { get; set; }

        [Required(ErrorMessage = "Please enter Department")]
        public string FacultyDepartment { get; set; }

        [Required(ErrorMessage = "Please enter Course")]
        public string FacultyCourse { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
         ErrorMessage = "Entered phone format is not valid.")]
        public string FacultyPhone { get; set; }

   

        [Required(ErrorMessage = "Please enter email address")]
        public string FacultyEmail { get; set; }

    }
}