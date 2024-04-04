﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectLayer
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderNumber { get; set; }

        public int CustomerId { get; set; }

        public decimal TotalAmount { get; set; }

    }

    public class OrderVM : Order
    {
        public Customer Customer { get; set; }

        public List<OrderItem> Items { get; set; }

    }
}
