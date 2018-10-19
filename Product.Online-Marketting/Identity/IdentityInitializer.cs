using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Product.Online_Marketting.Entity;

namespace Product.Online_Marketting.Identity
{
    public class IdentityInitializer:CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Roles
            //Users
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role=new ApplicationRole(){Name = "admin",Description = "adminstrator role"};

                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user role" };

                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "bekir inan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser(){Name = "bekir",Surname = "inan",UserName = "bekirinan",Email = "bbekirinan@gmail.com"};

                
                manager.Create(user,"002110");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");

            }

            if (!context.Users.Any(i => i.Name == "derya balıkçı"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "derya", Surname = "balıkçı", UserName = "deryabalikci", Email = "dryblkc@gmail.com" };


                manager.Create(user, "002110");
                manager.AddToRole(user.Id, "user");

            }
            





            base.Seed(context);
        }
    }
}