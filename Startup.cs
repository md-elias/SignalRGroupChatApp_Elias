using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalRGroupChatApp_Elias.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRChatRoom_Ali.Startup))]
namespace SignalRChatRoom_Ali
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            CreateRolesandUsers();
            app.MapSignalR();
        }

        private void CreateRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            int countRole = context.Roles.Count();
            int countUser = context.Users.Count();

            if (countRole == 0 && countUser == 0)
            {
                Role adminRole = new Role();
                adminRole.Name = "Admin";
                Role userRole = new Role();
                userRole.Name = "User";
                List<Role> roles = new List<Role>();
                roles.Add(adminRole);
                roles.Add(userRole);
                context.Roles.AddRange(roles);

                User adminUser = new User();
                adminUser.UserName = "Elias";
                adminUser.Password = "Elias@123%";
                adminUser.Email = "elias@gmail.com";
                adminUser.Active = true;
                context.Users.Add(adminUser);

                UserRole aUserRole = new UserRole();
                aUserRole.User = adminUser;
                aUserRole.Role = adminRole;
                context.UserRoles.Add(aUserRole);

                context.SaveChanges();
            }
        }
    }
}