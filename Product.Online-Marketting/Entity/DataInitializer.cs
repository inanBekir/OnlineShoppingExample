using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Product.Online_Marketting.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Camera",Description="Camera Products"},
                new Category(){Name="Computer",Description="Computer Products"},
                new Category(){Name="Electronics Devices",Description="Electronics Devices Products"},
                new Category(){Name="Phones",Description="Phones Products"},
                new Category(){Name="Smart Home Devices",Description="Smart Home Devices Products"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name="Canon Eos 1200D",Description="Beatiful",Price=250,Stock=150,IsApproved=false,CategoryId=1,IsHome=false,Image="2.jpg"},
                new Product(){Name="Canon Eos 1200D",Description="Beatiful",Price=250,Stock=150,IsApproved=true,CategoryId=1,IsHome=true,Image="1.jpg"},
                new Product(){Name="Canon Eos 1200D",Description="Beatiful",Price=250,Stock=150,IsApproved=false,CategoryId=1,Image="3.jpg"},
                new Product(){Name="Canon Eos 1200D",Description="Beatiful",Price=250,Stock=150,IsApproved=true,CategoryId=1,IsHome=false,Image="4.jpg"},
                new Product(){Name="Canon Eos 1200D",Description="Beatiful",Price=250,Stock=150,IsApproved=false,CategoryId=1,Image="5.jpg"},

                new Product(){Name="Canon Eos 1200D",Description="Beatiful",Price=250,Stock=150,IsApproved=false,CategoryId=2,IsHome=true,Image="2.jpg"},
                new Product(){Name="Canon Eos 1200D",Description="Beatiful",Price=250,Stock=150,IsApproved=true,CategoryId=3,Image="3.jpg"},
                new Product(){Name="Canon Eos 1200D",Description="Beatiful",Price=250,Stock=150,IsApproved=true,CategoryId=2,IsHome=true,Image="1.jpg"},
                new Product(){Name="Canon Eos 1200D",Description="Beatiful",Price=250,Stock=150,IsApproved=true,CategoryId=4,Image="4.jpg"},
                new Product(){Name="Canon Eos 1200D",Description="Beatiful",Price=250,Stock=150,IsApproved=true,CategoryId=2,IsHome=true,Image="5.jpg"}
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);

        }
    }
}