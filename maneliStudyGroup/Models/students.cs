using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace maneliStudyGroup.Models
{
    public class Students
    {

        [Display(Name = "Student Number")] //Add as decorator
        public string StudentNumber { get; set; }

        [Display(Name = "Name")] //Add as decorator
        public string Name { get; set; }

        [Display(Name = "Surname")] //Add as decorator
        public string Surname { get; set; }

        [Display(Name = "Email")] //Add as decorator
        // [Required(ErrorMessage = "Name is mandatory")]=> Example of manditory decorator
        public string Email { get; set; }
    }
}