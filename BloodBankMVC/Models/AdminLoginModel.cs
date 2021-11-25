using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BloodBankMVC.Models
{
    public class AdminLoginModel
    {
        //1st
        [Required(ErrorMessage = "Username is must"), MaxLength(50)]            //Empty fields not allowed & length<=50
        [Display(Name = "Please enter Username")]                               //Label

        public String Name { get; set; }

        //2nd
        [Required(ErrorMessage = "Password is must"), MaxLength(50)]            //Empty fields not allowed & length<=50
        [Display(Name = "Please enter Password")]                               //Label
        public String Password { get; set; }

    }
}