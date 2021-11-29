

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BloodBankMVC.Models
{
    public class UserModel
    {

        [Required(ErrorMessage = "You cannot leave email empty")]
        [Display(Name = "Please enter email")]

        public string EMAIL { get; set; }
        [Required(ErrorMessage = "You cannot leave Full Name empty"), MaxLength(50)]
        [Display(Name = "Please enter Full Name")]
        [RegularExpression("^[a-zA-Z\\s]*$", ErrorMessage = "Full Name can hold only Alphabet")]
        public string FULLNAME { get; set; }


        [Required(ErrorMessage = "You cannot leave ContactNumber empty"), MaxLength(10)]
        [Display(Name = "Please enter Existing Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Contact can hold only Numbers")]
        public string CONTACT { get; set; }
        [Required(ErrorMessage = "You cannot leave Address empty"), MaxLength(50)]
        [Display(Name = "Please enter Address")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Address can hold only Alphabet")]
        public string ADDRESS { get; set; }

        [Required(ErrorMessage = "You cannot BloodGroup empty"), MaxLength(6)]
        [Display(Name = "Please enter Blood Group")]

        public string BLOODGRP { get; set; }
    }
}