﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class Agency
    {
        public int idAgency { get; set; }
        public string nameAgency { get; set; }
        public string descriptionAgency { get; set;}
        public string phoneNumber { get; set; }
        public string mobileNumber { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int statusAgency { get; set; }
        public int idCity { get; set; }

    }
}
