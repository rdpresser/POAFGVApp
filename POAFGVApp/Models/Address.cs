﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POAFGVApp.Models
{
    public class Address
    {
        public string Bourgh { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Zipcode { get; set; }
        public bool IsMainAddress { get; set; }
    }
}
