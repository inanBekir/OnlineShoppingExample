using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Product.Online_Marketting.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Category Description")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}