using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Survivor.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Diagnostics;
using System;


namespace Survivor.Controllers
{
    
    public class UsersController : Controller
    {
        public IActionResult Index(int id, User1 userLogin)
        {
            var foundUser = User1.GetUsers(userLogin);
            // var user = foundUser.FirstOrDefault(entry => entry.User1Id == id);
            Console.WriteLine(foundUser.Token);
            return View(foundUser);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User1 newUser)
        {
            User1.CreateUser(newUser);
            return RedirectToAction("Login");
        }
         [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User1 user)
        {
            Console.WriteLine(user.Username);
            var foundUser = User1.GetUsers(user);
            Console.WriteLine(user.Username);
            return View("Index", foundUser);
        }
    }
}