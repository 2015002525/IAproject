using aspIdentityLearn.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using System.Net;

namespace aspIdentityLearn.Controllers
{


    public class EditProfileController : Controller
    {
        // GET: EditProfile
        /*  public ActionResult Index()
          {
              return View();
          }
          */
        private ApplicationDbContext db = new ApplicationDbContext();
       /* public ActionResult ListUsers()
        {
            return View(db.Users.ToList());
        }*/

        [HttpGet]
        public ActionResult EditProfile()
        {
            var userId = User.Identity.GetUserId();
            var user = db.Users.Find(userId);
           /* EditProfile user = new EditProfile();
            user.FirstName = appUser.FirstName;
            user.LastName = appUser.LastName;
            // user.EmailConfirmed = appUser.EmailConfirmed;
            user.PhoneNumber = appUser.PhoneNumber;
            user.JobDescription = appUser.JobDescription;
            */

            return View(user);
        }

        [HttpPost]
        public async Task<ActionResult> EditProfile(EditProfile model)
        {


            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var store = new UserStore<ApplicationUser>(new ApplicationDbContext());
            var manager = new UserManager<ApplicationUser>(store);
            var currentUser = manager.FindByEmail(model.Email);
            currentUser.FirstName = model.FirstName;
            currentUser.LastName = model.LastName;
            currentUser.PhoneNumber = model.PhoneNumber;
            currentUser.JobDescription = model.JobDescription;
            currentUser.Email = model.Email;
            //currentUser.EmailConfirmed = model.EmailConfirmed;
            await manager.UpdateAsync(currentUser);
            var ctx = store.Context;
            ctx.SaveChanges();
            TempData["msg"] = "Profile Changes Saved !";
            return RedirectToAction("ListUser");
        }

        /*       //for Delete user 
               public ActionResult DeleteUser(string id)
               {
                   if (id == null)
                   {
                       return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                   }
                   var user = db.Users.Find(id);
                   if (user == null)
                   {
                       return HttpNotFound();
                   }
                   return View(db.Users.Find(id));
               }


               public async Task<ActionResult> UserDeleteConfirmed(string id)
               {
                   var user = await UserManager.FindByIdAsync(id);

                   var result = await UserManager.DeleteAsync(user);
                   if (result.Succeeded)
                   {
                       TempData["UserDeleted"] = "User Successfully Deleted";
                       return RedirectToAction("ManageEditors");
                   }
                   else
                   {
                       TempData["UserDeleted"] = "Error Deleting User";
                       return RedirectToAction("ManageEditors");
                   }
               }
       */
    }


}
