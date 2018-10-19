using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Product.Online_Marketting.Entity;

namespace Product.Online_Marketting.Models
{
    public class UserOrderModel
    {

        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public EnumOrderState OrderState { get; set; }
        public DateTime OrderDate { get; set; }
    }
}