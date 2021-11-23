using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodbankDTO
{
    public class UserDTO
    {
        public int USER_ID { get; set; }
        public string EMAIL { get; set; }
        public string FULLNAME { get; set; }



        public string CONTACT { get; set; }
        public string ADDRESS { get; set; }

        public string BLOODGRP { get; set; }
    }
}
