//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodBankMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DONAR
    {
        public int DONAR_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAIL { get; set; }
        public string CONTACT { get; set; }
        public string GENDER { get; set; }
        public string BLOODGRP { get; set; }
        public string ADDRESS { get; set; }
        public Nullable<int> AGE { get; set; }
    }
}