using aspIdentityLearn.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspIdentityLearn.Startup))]
namespace aspIdentityLearn
{
    public partial class Startup
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
          //  CreateRoles();
           // CreateUsers();
        }

        public void CreateUsers()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = new ApplicationUser
            {
                Email = "alaa@gmail.com",
                UserName = "alaa"
               
            };
            var check = userManager.Create(user,"Ala@a123");
            if (check.Succeeded)
            {
                userManager.AddToRole(user.Id, "Admin");
            }
        }

     /*   public void CreateRoles()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            IdentityRole role;

            if (!roleManager.RoleExists("Admins"))
            {
                role = new IdentityRole
                {
                    Name = "Admins"
                };
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Authors"))
            {
                role = new IdentityRole
                {
                    Name = "Authors"
                };
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Readers"))
            {
                role = new IdentityRole
                {
                    Name = "Readers"
                };
                roleManager.Create(role);
            }
        } */
    }
}
