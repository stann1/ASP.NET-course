using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleStore;
        private readonly ApplicationDbContext context;

        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleStore, ApplicationDbContext context)
        {
            this._userManager = userManager;
            this._roleStore = roleStore;
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            
            return View(users);
        }

        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var userRoles = await _userManager.GetRolesAsync(user);

            var editModel = new UserWithRoleViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                Role = userRoles.FirstOrDefault()
            };
            var allRoles = _roleStore.Roles.Select(r => new SelectListItem { Value = r.Name, Text = r.Name }).ToList();
            ViewData["roles"] = allRoles;
            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(UserWithRoleViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            var role = _roleStore.Roles.FirstOrDefault(r => r.Name == model.Role);
            if(role != null)
            {
                await _userManager.AddToRoleAsync(user, role.NormalizedName);
            }

            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}