using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BloodBankMVC.Models
{
    public class DeleteDonarModel
    {
        [Required(ErrorMessage = "You cannot leave donar_id empty"), ]
        [Display(Name = "Please enter Valid Donar Id")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Contact can hold only Numbers")]
        public int DONAR_ID { get; set; }
    }
}