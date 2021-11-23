using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodBankMVC.Models
{
    public class UserModel
    {
     
        public string EMAIL { get; set; }
        public string FULLNAME { get; set; }



        public string CONTACT { get; set; }
        public string ADDRESS { get; set; }

        public string BLOODGRP { get; set; }
    }
}