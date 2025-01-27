﻿using Mall.model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mall.model.Dao
{
    public class FooterDao
    {
        OnlineShopDbContext db = null;
        public FooterDao()
        {
            db = new OnlineShopDbContext();
        }
        public Footer GetFooter()
        {
            return db.Footers.SingleOrDefault(x => x.Status == true);
        }
    }
}