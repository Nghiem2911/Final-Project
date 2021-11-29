﻿using Mall.model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mall.model.Dao
{
    public class OrderDetailDao
    {
        OnlineShopDbContext db = null;
        public OrderDetailDao()
        {
            db = new OnlineShopDbContext();

        }
        public bool Insert(OrderDetail detail)
        {
            try
            {
                db.OrderDetails.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}