using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RolePlayingGame.Models;
using RolePlayingGame.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace RolePlayingGame.Controllers
{
    public class UserController : Controller
    {
        private readonly RPGContext _db;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController (UserManager<User> userManager, SignInManager<User> signInManager, RPGContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.User = _db.Users.FirstOrDefault(users => users.UserName == User.Identity.Name);
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var user = new User { UserName = model.UserName, Email = model.Email };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: true, lockoutOnFailure: false);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Profile(string id)
        {
            var thisUser = _db.Users.FirstOrDefault(User => User.Id == id);
            return View(thisUser);
        }

        public IActionResult Edit(string id)
        {
            var thisUser = _db.Users.FirstOrDefault(User => User.Id == id);
            return View(thisUser);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            var id = user.Id;
            var thisUser = _db.Users.FirstOrDefault(User => User.Id == id);
            thisUser.Avatar = user.Avatar;
            _db.SaveChanges();
            //_db.Entry(user).State = EntityState.Modified;
            //_db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(string id)
        {
            var thisUser = _db.Users.FirstOrDefault(User => User.Id == id);
            return View(thisUser);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string id)
        {
            var thisUser = _db.Users.FirstOrDefault(User => User.Id == id);
            _signInManager.SignOutAsync();
            _db.Users.Remove(thisUser);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
