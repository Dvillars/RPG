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

namespace RolePlayingGame.Tests.ControllerTests
{
    public class UserControllerTest
    {
        private readonly RPGContext _db;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            User newUser = new User();
            UserController controller = new UserController(_userManager, _signInManager, _db);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Register_Test()
        {
            //Arrange
            User newUser = new User();
            UserController controller = new UserController(_userManager, _signInManager, _db);

            //Act
            var result = controller.Register();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_Model_Register_Test()
        {
            //Arrange
            UserController controller = new UserController(_userManager, _signInManager, _db);
            IActionResult actionResult = controller.Register();
            ViewResult registerView = controller.Register() as ViewResult;

            //Act
            var result = registerView.ViewData.Model;

            //Assert
            Assert.IsType<RegisterViewModel>(result);
        }
    }
}
