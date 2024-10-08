﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetApiWithAuthentication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<OrderDetail> Orderdetails { get; set; }
    }
}