﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace View_Model.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
    }
}