﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product.Online_Marketting.Models
{
    public class Login
    {
        [Required]
        [DisplayName("Username")]
        public string UserName { get; set; }


        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}