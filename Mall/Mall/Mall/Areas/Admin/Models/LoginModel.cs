﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mall.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời bạn nhập user name vào ")]
        public string UserName { set; get; }


        [Required(ErrorMessage = "Mời bạn nhập password vào ")]
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}