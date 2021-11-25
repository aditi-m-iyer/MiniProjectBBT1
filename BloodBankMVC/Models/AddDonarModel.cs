using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BloodBankMVCAPP.Models
{
    public class AddDonarModel
    {

        [Required(ErrorMessage = "You cannot leave First Name empty"), MaxLength(50)]
        [Display(Name = "Please enter First Name")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "First Name can hold only Alphabet")]
        public string FIRST_NAME { get; set; }

        [Required(ErrorMessage = "You cannot leave Last Name empty"), MaxLength(50)]
        [Display(Name = "Please enter Last Name")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Last Name can hold only Alphabet")]
        public string LAST_NAME { get; set; }

        [Required(ErrorMessage = "You cannot leave Email empty"), MaxLength(50)]
        [Display(Name = "Please enter Email")]
    
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "You cannot leave ContactNumber empty"), MaxLength(10)]
        [Display(Name = "Please enter Existing Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Contact can hold only Numbers")]
        public string CONTACT { get; set; }
        [Required(ErrorMessage = "You cannot leave Gender empty")]
        [Display(Name = "Please enter Gender")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Gender can hold only Male,Female,Others")]
        public string GENDER { get; set; }

        [Required(ErrorMessage = "You cannot BloodGroup empty"), MaxLength(6)]
        [Display(Name = "Please enter Blood Group")]
        
        public string BLOODGRP { get; set; }

        [Required(ErrorMessage = "You cannot leave Address empty"), MaxLength(50)]
        [Display(Name = "Please enter Address")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Address can hold only Alphabet")]

        public string ADDRESS { get; set; }

        [Required(ErrorMessage = "You cannot leave age empty")]
        [Display(Name = "Please enter age")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "age can hold only Numbers")]
        public int AGE { get; set; }

      
    }
}