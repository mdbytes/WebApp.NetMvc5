﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectLayer
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City {  get; set; }

        public string Country { get; set; } 

        public string Phone { get; set; }

    }

    public class CustomerVM : Customer
    {

    }
}
