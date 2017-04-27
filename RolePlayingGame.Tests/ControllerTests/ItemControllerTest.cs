using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RolePlayingGame.Controllers;
using RolePlayingGame.Models;
using RolePlayingGame.ViewModels;
using Xunit;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace RolePlayingGame.Tests.ControllerTests
{
    public class ItemControllerTest
    {
        private readonly RPGContext _db;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        [Fact]
        public void Get_Model_Index_Test()
        {
            var contextOptions = new DbContextOptionsBuilder()
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=_Flicker;integrated security=True")
                .Options;
            var _db = new RPGContext(contextOptions);
            //Arrange
            ItemController controller = new ItemController(_db);
            IActionResult actionResult = controller.Index();
            ViewResult IndexView = controller.Index() as ViewResult;

            //Act
            var result = IndexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Item>>(result);
        }
    }
}
