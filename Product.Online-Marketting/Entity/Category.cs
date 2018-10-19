using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product.Online_Marketting.Entity
{
    public class Category
    {
        public int Id { get; set; }

        //Data Annotations.
        [DisplayName("Category Name")]
        [StringLength(maximumLength:20,ErrorMessage ="You must use max 20 characters.")]
        public string Name { get; set; }

        [DisplayName("Category Description")]
       
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}