using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMusicStore.Controllers
{
    public class RoleMaintenanceController : Controller
    {
        UserManager<IdentityUser> userManager;
        RoleManager<IdentityRole> roleManager;
        public RoleMaintenanceController(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = roleManager.Roles.OrderBy(a => a.Name);
            return View(roles);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole(string roleName)
        {
            roleName = (roleName + "").Trim();
            if (roleName == "")
            {
                TempData["message"] = "role name cannot be empty/blanks";
                return RedirectToAction("index");
            }
            // check for a duplicate
            else if (await roleManager.RoleExistsAsync(roleName))
            {
                TempData["message"] = $"role name '{roleName}' is already on file";
                return RedirectToAction("index");
            }
            try
            {
                IdentityRole role = new IdentityRole(roleName);
                IdentityResult result = await roleManager.CreateAsync(role);
                if (result.Succeeded)
                    TempData["message"] = "role added";
                else
                    throw new Exception(
                        result.Errors.FirstOrDefault().Description);
            }
            catch (Exception ex)
            {
                TempData["message"] = $"error creating role '{roleName}': " +
                    ex.GetBaseException().Message;
            }
            return RedirectToAction("index");
        }

        // display all users in the selected role
        // - and display a dropdown with users NOT in the role
        public async Task<IActionResult> UsersInRole(string roleId, string roleName)
        { 
            var users = userManager.Users.OrderBy(a => a.UserName);
            var usersInRole = await userManager.GetUsersInRoleAsync(roleName);

            List<IdentityUser> usersNotInRole = new List<IdentityUser>();
            foreach (var item in users)
            {
                
            }
            ViewBag.usersNotInRole = new SelectList(usersNotInRole, "Id", "UserName");

            return View(usersInRole);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // add the sleected use to the given role
        public async Task<IActionResult> AddUserToRole(string userId, string roleName)
        {
            try
            {
                IdentityUser user = await userManager.FindByIdAsync(userId);
                IdentityResult result = await userManager.AddToRoleAsync(user, roleName);

            }
            catch (Exception ex)
            {
                TempData["message"] = $"error adding to role: {ex.GetBaseException().Message}";
            }
            
            return RedirectToAction("Index");
        }
    }
}