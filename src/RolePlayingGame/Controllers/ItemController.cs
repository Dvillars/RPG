using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RolePlayingGame.Models;

namespace RolePlayingGame.Controllers
{
    public class ItemController : Controller
    {
        private readonly RPGContext _db;

        public ItemController(RPGContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Items.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            //            ViewBag.User = _db.Users.FirstOrDefault(users => users.UserName == User.Identity.Name);

            var item = _db.Items.FirstOrDefault(items => items.Id == id);
            return View(item);
        }
    }
}
