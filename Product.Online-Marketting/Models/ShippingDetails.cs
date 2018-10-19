using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product.Online_Marketting.Models
{
    public class ShippingDetails
    {
       
        public string Username { get; set; }

        [Required(ErrorMessage = "Please entry is your adress type.")]
        public string AdresBasligi  { get; set; }

        [Required(ErrorMessage = "Please entry is your adress.")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Please entry is your city information.")]
        public string Sehir { get; set; }

        [Required(ErrorMessage = "Please entry is your state information.")]
        public string Semt { get; set; }

        [Required(ErrorMessage = "Please entry is your street information.")]
        public string Mahalle { get; set; }
        public string PostaKodu { get; set; }
    }
}