using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product.Online_Marketting.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Your Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Your Surname")]
        public string SurName { get; set; }

        [Required]
        [DisplayName("Your User Name")]
        public string UserName { get; set; }


        [Required]
        [DisplayName("Your E-mail Adress")]
        [EmailAddress(ErrorMessage ="Your e-mail adress is wrong!")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Your Password")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Your Re-Password")]
        [Compare("Password",ErrorMessage ="Your passwords not the same!")]
        public string RePassword { get; set; }

    }
        
}