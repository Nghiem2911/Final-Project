using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mall.Models
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