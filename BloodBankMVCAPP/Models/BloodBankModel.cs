using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodBankMVCAPP.Models
{
    public class BloodBankModel
    {
        
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }


        public string EMAIL { get; set; }
        public string CONTACT { get; set; }
        public string GENDER { get; set; }
        public string BLOODGRP { get; set; }

        public string ADDRESS { get; set; }

        public int AGE { get; set; }
    }
}