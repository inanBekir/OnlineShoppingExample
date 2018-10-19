using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product.Online_Marketting.Entity
{
    public enum EnumOrderState
    {
        [Display(Name = "Waiting for Approval")]
        Waiting,
        [Display(Name = "Order is Completed")]
        Completed
    }
}