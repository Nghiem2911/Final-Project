﻿using Mall.model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mall.Models
{
    [Serializable]
    public class CartItem
    {
        public Product Product { set; get; }
        public int Quantity { set; get; }
    }
}