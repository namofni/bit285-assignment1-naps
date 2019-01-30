//From Wing S Cho BIT 285 Winter 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bit285assignment1naps.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bit285assignment1naps.Controllers
{
    public class NapsController : Controller
    {
        //[HttpGet]
        //public string AccountInfo()
        //{
        //    return "Hello World";
        //}

        [HttpGet]
        public IActionResult AccountInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AccountInfo(User user)
        {
            if (ModelState.IsValid)
            {
                return  RedirectToAction("PasswordInfo", user);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult PasswordInfo(User user)
        {
            return View(user);
        }

        [HttpGet]
        public IActionResult SelectPassword(User user)
        {
            return View(user);
        }


        public IActionResult ConfirmAccount(User user)
        {
            return View(user);
        }

        public IActionResult Login(User user)
        {
            return View();
        }
    }
}
